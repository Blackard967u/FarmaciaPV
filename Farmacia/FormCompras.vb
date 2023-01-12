Imports System.Data.SqlClient
Public Class FormCompras
    Dim Conn As New SqlConnection("Data Source=LAPTOP-KE7692FS\SQLEXPRESS;Initial Catalog=FARMACIA;Integrated Security=True")
    Private Sub FormCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        llenarTablaCompras()
        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        llenarIdCompra()
        Timer1.Start()
        CargarTotal()
        cant_prod_bus.Enabled = False
        AGREGAR_CARRITO_COMPRA.Enabled = False
        eliminar_carrito.Enabled = False
        total_compra.Text = "00.00"
        buscar_proveedor.Enabled = False
    End Sub
    Sub llenarTablaCompras()
        Dim datos As New DataTable
        Dim adaptador As New SqlDataAdapter("select*from compra_detalle_compras", Conn)
        adaptador.Fill(datos)
        DataGridView1.DataSource = datos
    End Sub
    Sub llenarTablaProveedor()
        Dim datos As New DataTable
        Dim adaptador As New SqlDataAdapter("select*from llenartablaproveedorcompra", Conn)
        adaptador.Fill(datos)
        DataGridView2.DataSource = datos
    End Sub
    Sub llenarIdCompra()
        Conn.Close()
        Dim consulta As String = "select top 1 ID_COMPRA from COMPRAS order by ID_COMPRA desc"
        Dim comando As New SqlCommand(consulta, Conn)
        Dim drd As SqlDataReader
        Conn.Open()
        drd = comando.ExecuteReader
        If drd.Read() Then
            Dim IDCOMPRA As Integer
            IDCOMPRA = Integer.Parse(drd.Item("ID_COMPRA").ToString)
            ID_COMPRA.Text = IDCOMPRA + 1
            Conn.Close()
        Else
            ID_COMPRA.Text = 1
            Conn.Close()
        End If
    End Sub
    Sub CargarTotal()
        Dim consulta As String = "select sum(SUBTOTAL) [TOTAL] from COMPRA_DETALLE_TEMP "
        Dim comando As New SqlCommand(consulta, Conn)
        Dim drd As SqlDataReader
        Conn.Open()
        drd = comando.ExecuteReader
        If drd.Read() Then
            total_compra.Text = drd.Item("TOTAL").ToString
            Conn.Close()
        Else
            total_compra.Text = "00.00"
            Conn.Close()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        FECHA_LBL.Text = DateTime.Now.ToString("yyyy-MM-dd")
    End Sub

    Private Sub buscar_producto_Click(sender As Object, e As EventArgs) Handles buscar_producto.Click
        Try
            Conn.Close()
            Dim consulta As String = "SELECT ID_PRODUCTO, DESCRIP_PRODUCTO, PRECIO_COMPRA FROM PRODUCTOS where ID_PRODUCTO= '" & id_prod_bus.Text & "'"
            Dim comando As New SqlCommand(consulta, Conn)
            Dim drd As SqlDataReader
            Conn.Open()
            drd = comando.ExecuteReader
            If drd.Read() Then
                id_prod_bus.Text = drd.Item("ID_PRODUCTO").ToString
                nom_prod_bus.Text = drd.Item("DESCRIP_PRODUCTO").ToString
                precio_prod_bus.Text = Double.Parse(drd.Item("PRECIO_COMPRA").ToString)
                Conn.Close()
                AGREGAR_CARRITO_COMPRA.Enabled = True
                eliminar_carrito.Enabled = True
                cant_prod_bus.Enabled = True

            Else
                MsgBox("Producto no encontrado", vbInformation)
                id_prod_bus.Clear()
                Conn.Close()
                AGREGAR_CARRITO_COMPRA.Enabled = True
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

    Private Sub AGREGAR_CARRITO_COMPRA_Click(sender As Object, e As EventArgs) Handles AGREGAR_CARRITO_COMPRA.Click
        Dim consulta As String = "Select ID_PRODUCTO from COMPRA_DETALLE_TEMP where ID_PRODUCTO = " & Integer.Parse(id_prod_bus.Text)
        Dim comando As New SqlCommand(consulta, Conn)
        Dim drd As SqlDataReader
        Conn.Open()
        drd = comando.ExecuteReader
        If drd.Read() Then
            Conn.Close()
            Dim sql As String
            sql = "exec actualizarcantidadcompradetalletemp @id_prod, @canti"
            Try
                Dim comando2 As New SqlCommand(sql, Conn)
                comando2.Parameters.Add(New SqlParameter("@id_prod", Integer.Parse(id_prod_bus.Text)))
                comando2.Parameters.Add(New SqlParameter("@canti", Double.Parse(cant_prod_bus.Text)))
                Conn.Open()
                comando2.ExecuteNonQuery()
                Conn.Close()
                llenarTablaCompras()
                CargarTotal()
                id_prod_bus.Clear()
                cant_prod_bus.Clear()
            Catch ex As Exception
                Conn.Close()
            End Try
        Else
            Conn.Close()
            Dim sql As String
            sql = String.Format("exec llenartablatemporalcompradetalle @id_prod, @id_compra, @canti, @precio")
            Try
                Dim comando2 As New SqlCommand(sql, Conn)
                comando2.Parameters.Add(New SqlParameter("@id_prod", id_prod_bus.Text))
                comando2.Parameters.Add(New SqlParameter("@id_compra", ID_COMPRA.Text))
                comando2.Parameters.Add(New SqlParameter("@canti", cant_prod_bus.Text))
                comando2.Parameters.Add(New SqlParameter("@precio", precio_prod_bus.Text))
                Conn.Open()
                comando2.ExecuteNonQuery()
                Conn.Close()
                CargarTotal()
                llenarTablaCompras()
                llenarIdCompra()
                id_prod_bus.Clear()
                cant_prod_bus.Clear()
            Catch ex As Exception
                Conn.Close()
            End Try
        End If
    End Sub

    Private Sub DataGridView2_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView2.DoubleClick
        nom_proveedor.Text = DataGridView2.CurrentRow.Cells(1).Value.ToString
        buscar_proveedor.Enabled = False
        DataGridView2.Enabled = False
    End Sub

    Private Sub buscar_proveedor_TextChanged(sender As Object, e As EventArgs) Handles buscar_proveedor.TextChanged
        Try
            Dim datos As New DataTable
            Dim adaptador As New SqlDataAdapter("exec lllenartablaproveedornombre " & buscar_proveedor.Text, Conn)
            adaptador.Fill(datos)
            DataGridView2.DataSource = datos
        Catch ex As Exception
            Conn.Close()
        End Try
    End Sub

    Private Sub eliminar_carrito_Click(sender As Object, e As EventArgs) Handles eliminar_carrito.Click
        Dim sql As String
        Dim filaDataGrid As Integer
        filaDataGrid = DataGridView1.CurrentRow.Index
        sql = String.Format("delete from COMPRA_DETALLE_TEMP where ID_PRODUCTO = '{0}'", DataGridView1.Item(0, filaDataGrid).Value)
        Try
            Dim comando As New SqlCommand(sql, Conn)
            Conn.Open()
            comando.ExecuteNonQuery()
            Conn.Close()
            llenarTablaCompras()
            CargarTotal()
        Catch ex As Exception
            Conn.Close()
        End Try
        eliminar_carrito.Enabled = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim sql_line As String
        sql_line = "exec guardar_compra_transacci @id_compra, @id_prov, @fecha, 0"
        Try
            Dim comando As New SqlCommand(sql_line, Conn)
            comando.Parameters.Add(New SqlParameter("@id_compra", ID_COMPRA.Text))
            comando.Parameters.Add(New SqlParameter("@id_prov", nom_proveedor.Text))
            comando.Parameters.Add(New SqlParameter("@fecha", FECHA_LBL.Text))
            Conn.Open()
            comando.ExecuteNonQuery()
            Conn.Close()
            llenarTablaCompras()
            llenarIdCompra()
            CargarTotal()
        Catch ex As Exception
            Conn.Close()
            MsgBox("Error:" & ex.Message)
        End Try
    End Sub

    Private Sub id_prod_bus_TextChanged(sender As Object, e As EventArgs) Handles id_prod_bus.TextChanged
        If id_prod_bus.Text = "" Then
            cant_prod_bus.Enabled = False
            AGREGAR_CARRITO_COMPRA.Enabled = False
            eliminar_carrito.Enabled = False
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If MsgBox("¿Desea cancelar la venta?", vbYesNo + vbExclamation, "ADVERTENCIA") = vbYes Then
            Conn.Close()
            Dim sql As String
            Dim fila As Integer
            fila = DataGridView1.CurrentRow.Index
            sql = String.Format("delete from COMPRA_DETALLE_TEMP")
            Dim comando2 As New SqlCommand(sql, Conn)
            Conn.Open()
            comando2.ExecuteNonQuery()
            Conn.Close()
            llenarTablaCompras()
            CargarTotal()
            total_compra.Text = "00.00"
        Else
            Conn.Close()
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        llenarTablaProveedor()
        buscar_proveedor.Enabled = True
        DataGridView2.Enabled = True
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        eliminar_carrito.Enabled = True
    End Sub

End Class