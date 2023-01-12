Imports System.Data.SqlClient
Public Class FormMenuInicio
    Dim Conn As New SqlConnection("Data Source=LAPTOP-KE7692FS\SQLEXPRESS;Initial Catalog=FARMACIA;Integrated Security=True")
    Private Sub FormMenuInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        llenarTablaCompras()
        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        llenarTablaProveedor()
        llenarIdCompra()
        Timer1.Start()
        CargarTotal()
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

            Else
                MsgBox("Producto no encontrado", vbInformation)
                id_prod_bus.Clear()
                Conn.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cant_prod_bus_TextChanged(sender As Object, e As EventArgs) Handles cant_prod_bus.TextChanged
        subtot_prod_bus.Text = precio_prod_bus.Text * Integer.Parse(cant_prod_bus.Text)
    End Sub

    Private Sub AGREGAR_CARRITO_COMPRA_Click(sender As Object, e As EventArgs) Handles AGREGAR_CARRITO_COMPRA.Click
        Dim consulta As String = "Select ID_PRODUCTO from COMPRA_DETALLE_TEMP where ID_PRODUCTO = " & Integer.Parse(id_prod_bus.Text)
        Dim comando As New SqlCommand(consulta, Conn)
        Dim drd As SqlDataReader
        Conn.Open()
        drd = comando.ExecuteReader
        If drd.Read() Then
            Conn.Close()
            MsgBox("Existe")
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
            Catch ex As Exception
                Conn.Close()
                MsgBox("Error:" & ex.Message)
            End Try
        Else
            Conn.Close()
            Dim sql As String
            sql = String.Format("exec llenartablatemporalcompradetalle @id_prod, @id_venta, @canti, @precio")
            Try
                Dim comando2 As New SqlCommand(sql, Conn)
                comando2.Parameters.Add(New SqlParameter("@id_prod", id_prod_bus.Text))
                comando2.Parameters.Add(New SqlParameter("@id_venta", ID_COMPRA.Text))
                comando2.Parameters.Add(New SqlParameter("@canti", cant_prod_bus.Text))
                comando2.Parameters.Add(New SqlParameter("@precio", precio_prod_bus.Text))
                Conn.Open()
                comando2.ExecuteNonQuery()
                Conn.Close()
                MsgBox("Se Agrego al carrito", vbInformation)
            Catch ex As Exception
                Conn.Close()
            End Try
        End If
    End Sub
End Class