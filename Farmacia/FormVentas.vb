Imports System.Data.SqlClient
Public Class FormVentas
    Dim Conn As New SqlConnection("Data Source=LAPTOP-KE7692FS\SQLEXPRESS;Initial Catalog=FARMACIA;Persist Security Info=True;User ID=corn;Password=123")
    Private Sub FormVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarTablaVentas()
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Timer1.Start()
        llenarIdVenta()
        atiende.Text = VariablesGlobales.nombre_log
        cant_prod_bus.Enabled = False
        AGREGAR_CARRITO.Enabled = False
        eliminar_carrito.Enabled = False
        'Tot_venta.Text = "00.00"
        buscar_cliente.Enabled = False
        DataGridView2.Enabled = False
        CargarTotal()
    End Sub
    Sub llenarTablaVentas()
        Dim datos As New DataTable
        Dim adaptador As New SqlDataAdapter("select*from venta_detalle_ventas", Conn)
        adaptador.Fill(datos)
        DataGridView1.DataSource = datos
    End Sub
    Sub llenarTablaCliente()
        Dim datos As New DataTable
        Dim adaptador As New SqlDataAdapter("select*from llenartablaclientesventas", Conn)
        adaptador.Fill(datos)
        DataGridView2.DataSource = datos
    End Sub
    Sub llenarIdVenta()
        Conn.Close()
        Dim consulta As String = "select top 1 ID_VENTA from VENTAS order by ID_VENTA desc"
        Dim comando As New SqlCommand(consulta, Conn)
        Dim drd As SqlDataReader
        Conn.Open()
        drd = comando.ExecuteReader
        If drd.Read() Then
            Dim IDVENTA As Integer
            IDVENTA = Integer.Parse(drd.Item("Id_Venta").ToString)
            ID_VENTA.Text = IDVENTA + 1
            Conn.Close()
        Else
            ID_VENTA.Text = 1
            Conn.Close()
        End If
    End Sub
    Sub CargarTotal()
        Dim consulta As String = "select sum(SUBTOTAL) [TOTAL] from VENTA_DETALLE_TEMP "
        Dim comando As New SqlCommand(consulta, Conn)
        Dim drd As SqlDataReader
        Conn.Open()
        drd = comando.ExecuteReader
        If drd.Read() Then
            Tot_venta.Text = drd.Item("TOTAL").ToString
            Conn.Close()
        Else
            Tot_venta.Text = "00.00"
            Conn.Close()
        End If
    End Sub
    Sub limpiarBusquedaInsertar()
        id_prod_bus.Clear()
        nom_prod_bus.Text = ""
        cant_prod_bus.Clear()
        precio_prod_bus.Text = ""
        exis_prod_bus.Text = ""
        subtot_prod_bus.Text = ""
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        FECHA_LBL.Text = DateTime.Now.ToString("yyyy-MM-dd")
    End Sub

    Private Sub buscar_producto_Click(sender As Object, e As EventArgs) Handles buscar_producto.Click
        Try
            Conn.Close()
            Dim consulta As String = "SELECT ID_PRODUCTO, DESCRIP_PRODUCTO, PRECIO_PRODUC_VENTA, EXISTENCIA_PRODUCTO FROM PRODUCTOS where ID_PRODUCTO= '" & id_prod_bus.Text & "'"
            Dim comando As New SqlCommand(consulta, Conn)
            Dim drd As SqlDataReader
            Conn.Open()
            drd = comando.ExecuteReader
            If drd.Read() Then
                id_prod_bus.Text = drd.Item("ID_PRODUCTO").ToString
                nom_prod_bus.Text = drd.Item("DESCRIP_PRODUCTO").ToString
                precio_prod_bus.Text = Double.Parse(drd.Item("PRECIO_PRODUC_VENTA").ToString)
                exis_prod_bus.Text = Integer.Parse(drd.Item("EXISTENCIA_PRODUCTO").ToString)
                Conn.Close()
                AGREGAR_CARRITO.Enabled = True
                eliminar_carrito.Enabled = True
                cant_prod_bus.Enabled = True
            Else
                MsgBox("Producto no encontrado", vbInformation)
                id_prod_bus.Clear()
                Conn.Close()
                AGREGAR_CARRITO.Enabled = True
                eliminar_carrito.Enabled = True
                cant_prod_bus.Enabled = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cant_prod_bus_TextChanged(sender As Object, e As EventArgs) Handles cant_prod_bus.TextChanged
        Try
            subtot_prod_bus.Text = precio_prod_bus.Text * Integer.Parse(cant_prod_bus.Text)
        Catch ex As Exception
            Conn.Close()
        End Try

    End Sub

    Private Sub AGREGAR_CARRITO_Click(sender As Object, e As EventArgs) Handles AGREGAR_CARRITO.Click
        Dim consulta As String = "Select ID_PRODUCTO from VENTA_DETALLE_TEMP where ID_PRODUCTO = " & Integer.Parse(id_prod_bus.Text)
        Dim comando As New SqlCommand(consulta, Conn)
        Dim drd As SqlDataReader
        Conn.Open()
        drd = comando.ExecuteReader
        If drd.Read() Then
            Conn.Close()
            Dim sql As String
            sql = "exec actualizarcantidadventdetalletemp @id_prod, @canti"
            Try
                Dim comando2 As New SqlCommand(sql, Conn)
                comando2.Parameters.Add(New SqlParameter("@id_prod", Integer.Parse(id_prod_bus.Text)))
                comando2.Parameters.Add(New SqlParameter("@canti", Double.Parse(cant_prod_bus.Text)))
                Conn.Open()
                comando2.ExecuteNonQuery()
                Conn.Close()
                CargarTotal()
                llenarTablaVentas()
                id_prod_bus.Clear()
                cant_prod_bus.Clear()
            Catch ex As Exception
                Conn.Close()
            End Try
        Else
            Conn.Close()
            Dim sql As String
            sql = String.Format("exec llenartablatemporal @id_prod, @id_venta, @canti, @precio")
            Try
                Dim comando2 As New SqlCommand(sql, Conn)
                comando2.Parameters.Add(New SqlParameter("@id_prod", id_prod_bus.Text))
                comando2.Parameters.Add(New SqlParameter("@id_venta", ID_VENTA.Text))
                comando2.Parameters.Add(New SqlParameter("@canti", cant_prod_bus.Text))
                comando2.Parameters.Add(New SqlParameter("@precio", precio_prod_bus.Text))
                Conn.Open()
                comando2.ExecuteNonQuery()
                Conn.Close()
                CargarTotal()
                llenarTablaVentas()
                id_prod_bus.Clear()
                cant_prod_bus.Clear()
            Catch ex As Exception
                Conn.Close()
            End Try
        End If



    End Sub

    Private Sub eliminar_carrito_Click(sender As Object, e As EventArgs) Handles eliminar_carrito.Click
        Dim sql As String
        Dim filaDataGrid As Integer
        filaDataGrid = DataGridView1.CurrentRow.Index
        sql = String.Format("delete from VENTA_DETALLE_TEMP where ID_PRODUCTO = '{0}'", DataGridView1.Item(0, filaDataGrid).Value)
        Try
            Dim comando As New SqlCommand(sql, Conn)
            Conn.Open()
            comando.ExecuteNonQuery()
            Conn.Close()
            CargarTotal()
            llenarTablaVentas()
            eliminar_carrito.Enabled = False

        Catch ex As Exception
            Conn.Close()
        End Try
    End Sub

    Private Sub buscar_cliente_TextChanged(sender As Object, e As EventArgs) Handles buscar_cliente.TextChanged
        Try
            Dim datos As New DataTable
            Dim adaptador As New SqlDataAdapter("exec llenartablaclientenombre " & buscar_cliente.Text, Conn)
            adaptador.Fill(datos)
            DataGridView2.DataSource = datos
        Catch ex As Exception
            Conn.Close()
        End Try
    End Sub

    Private Sub buscar_producto_busqueda_Click(sender As Object, e As EventArgs) Handles buscar_producto_busqueda.Click
        Try
            Conn.Close()
            Dim consulta As String = "SELECT ID_PRODUCTO, DESCRIP_PRODUCTO, PRECIO_PRODUC_VENTA, EXISTENCIA_PRODUCTO FROM PRODUCTOS where ID_PRODUCTO= '" & id_prod_busqueda.Text & "'"
            Dim comando As New SqlCommand(consulta, Conn)
            Dim drd As SqlDataReader
            Conn.Open()
            drd = comando.ExecuteReader
            If drd.Read() Then
                nom_prod_busqueda.Text = drd.Item("DESCRIP_PRODUCTO").ToString
                precio_prod_busqueda.Text = Double.Parse(drd.Item("PRECIO_PRODUC_VENTA").ToString)
                exis_prod_busqueda.Text = Integer.Parse(drd.Item("EXISTENCIA_PRODUCTO").ToString)
                Conn.Close()
            Else
                Conn.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView2_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView2.DoubleClick
        TextBox6.Text = DataGridView2.CurrentRow.Cells(0).Value.ToString
        buscar_cliente.Enabled = False
        DataGridView2.Enabled = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim sql_line As String
        sql_line = "exec guardar_venta_transacci @id_venta, @id_clie, @id_emp, @fecha, 0"
        Try
            Dim comando As New SqlCommand(sql_line, Conn)
            comando.Parameters.Add(New SqlParameter("@id_clie", TextBox6.Text))
            comando.Parameters.Add(New SqlParameter("@id_emp", atiende.Text))
            comando.Parameters.Add(New SqlParameter("@fecha", FECHA_LBL.Text))
            comando.Parameters.Add(New SqlParameter("@id_venta", ID_VENTA.Text))
            Conn.Open()
            comando.ExecuteNonQuery()
            Conn.Close()
            CargarTotal()
            llenarTablaVentas()
            llenarIdVenta()

        Catch ex As Exception
            Conn.Close()
            MsgBox("Error:" & ex.Message)
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If MsgBox("¿Desea cancelar la venta?", vbYesNo + vbExclamation, "ADVERTENCIA") = vbYes Then
            Conn.Close()
            Dim sql As String
            Dim fila As Integer
            fila = DataGridView1.CurrentRow.Index
            sql = String.Format("delete from VENTA_DETALLE_TEMP")
            Dim comando2 As New SqlCommand(sql, Conn)
            Conn.Open()
            comando2.ExecuteNonQuery()
            Conn.Close()
            llenarTablaVentas()
            CargarTotal()
            Tot_venta.Text = "00.00"
        Else
            Conn.Close()
        End If
    End Sub

    Private Sub id_prod_bus_TextChanged(sender As Object, e As EventArgs) Handles id_prod_bus.TextChanged
        If id_prod_bus.Text = "" Then
            cant_prod_bus.Enabled = False
            AGREGAR_CARRITO.Enabled = False
            eliminar_carrito.Enabled = False
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        llenarTablaCliente()
        buscar_cliente.Enabled = True
        DataGridView2.Enabled = True
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        eliminar_carrito.Enabled = True
    End Sub


End Class