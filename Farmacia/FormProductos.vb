Imports System.Data.SqlClient
Public Class FormProductos
    Dim Conn As New SqlConnection("Data Source=LAPTOP-KE7692FS\SQLEXPRESS;Initial Catalog=FARMACIA;Integrated Security=True")
    Private Sub FormProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarDatos()
        llenarTablaCategoria()
        deshabilitarCamposCategoria()
        todo_busqueda_categoria.Checked = True
        todo_busqueda.Checked = True
        LlenarComboBoxCategorias()
        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub
    Sub llenarDatos()
        Dim datos As New DataTable
        Dim adaptador As New SqlDataAdapter("select*from llenartablaproductos", Conn)
        adaptador.Fill(datos)
        DataGridView1.DataSource = datos
    End Sub
    Sub LlenarComboBoxCategorias()
        categ_prod.Items.Clear()
        Dim consulta As String = "select NOMBRE_CATEG_PROD from CATEGORIAS_PROD"
        Dim comando As New SqlCommand(consulta, Conn)
        Dim drd As SqlDataReader
        Conn.Open()
        drd = comando.ExecuteReader
        While drd.Read

            Dim resultado = drd.Item("NOMBRE_CATEG_PROD").ToString
            categ_prod.Items.Add(resultado)

        End While
        Conn.Close()
    End Sub

    Private Sub guardar_Click(sender As Object, e As EventArgs) Handles guardar.Click
        Dim sql_line As String
        sql_line = "exec guardar_producto @cat_prod, @des_prod, @exist_prod, @pre_venta, @pre_compra"
        Try
            Dim comando As New SqlCommand(sql_line, Conn)
            comando.Parameters.Add(New SqlParameter("@cat_prod", categ_prod.SelectedItem))
            comando.Parameters.Add(New SqlParameter("@des_prod", desc_prod.Text))
            comando.Parameters.Add(New SqlParameter("@exist_prod", exis_prod.Text))
            comando.Parameters.Add(New SqlParameter("@pre_venta", precio_venta_prod.Text))
            comando.Parameters.Add(New SqlParameter("@pre_compra", precio_compra_prod.Text))
            Conn.Open()
            comando.ExecuteNonQuery()
            Conn.Close()
            llenarDatos()
        Catch ex As Exception
            Conn.Close()
            MsgBox("Error:" & ex.Message)
        End Try
    End Sub

    Private Sub modificar_Click(sender As Object, e As EventArgs) Handles modificar.Click
        Dim sql_line As String
        sql_line = "exec modificar_producto @id, @cat_prod, @des_prod, @exist_prod, @pre_venta, @pre_compra"
        Try
            Dim comando As New SqlCommand(sql_line, Conn)
            comando.Parameters.Add(New SqlParameter("@id", id_prod.Text))
            comando.Parameters.Add(New SqlParameter("@cat_prod", categ_prod.SelectedItem))
            comando.Parameters.Add(New SqlParameter("@des_prod", desc_prod.Text))
            comando.Parameters.Add(New SqlParameter("@exist_prod", exis_prod.Text))
            comando.Parameters.Add(New SqlParameter("@pre_venta", precio_venta_prod.Text))
            comando.Parameters.Add(New SqlParameter("@pre_compra", precio_compra_prod.Text))
            Conn.Open()
            comando.ExecuteNonQuery()
            Conn.Close()
            llenarDatos()
        Catch ex As Exception
            Conn.Close()
            MsgBox("Error:" & ex.Message)
        End Try
    End Sub

    Private Sub eliminar_Click(sender As Object, e As EventArgs) Handles eliminar.Click
        Dim sql_line As String
        sql_line = "exec eliminar_producto @id"
        Try
            Dim comando As New SqlCommand(sql_line, Conn)
            comando.Parameters.Add(New SqlParameter("@id", id_prod.Text))
            Conn.Open()
            comando.ExecuteNonQuery()
            Conn.Close()
            llenarDatos()
        Catch ex As Exception
            Conn.Close()
            MsgBox("Error:" & ex.Message)
        End Try
    End Sub

    Private Sub nuevo_Click(sender As Object, e As EventArgs) Handles nuevo.Click

    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        id_prod.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        categ_prod.SelectedItem = DataGridView1.CurrentRow.Cells(1).Value.ToString
        desc_prod.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        exis_prod.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        precio_venta_prod.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        precio_compra_prod.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
    End Sub


    'CATEGORIAS
    Sub llenarTablaCategoria()
        Dim datos As New DataTable
        Dim adaptador As New SqlDataAdapter("select*from llenartablaproductoscategorias", Conn)
        adaptador.Fill(datos)
        DataGridView2.DataSource = datos

    End Sub
    Sub habilitarCamposCategoria()
        desc_categ.Enabled = True
        guardar_categ.Enabled = True
        modificar_categ.Enabled = True
        eliminar_categ.Enabled = True
    End Sub
    Sub deshabilitarCamposCategoria()
        desc_categ.Enabled = False
        guardar_categ.Enabled = False
        modificar_categ.Enabled = False
        eliminar_categ.Enabled = False
    End Sub
    Sub limpiarcamposCategoria()
        id_categ.Clear()
        desc_categ.Clear()
    End Sub
    Private Sub guardar_categ_Click(sender As Object, e As EventArgs) Handles guardar_categ.Click
        Dim sql_line As String
        sql_line = "exec insertarcategoriaproducto @nombre_Categ"
        Try
            Dim comando As New SqlCommand(sql_line, Conn)
            comando.Parameters.Add(New SqlParameter("@nombre_Categ", desc_categ.Text))
            Conn.Open()
            comando.ExecuteNonQuery()
            Conn.Close()
            llenarTablaCategoria()
            deshabilitarCamposCategoria()
            limpiarcamposCategoria()
            LlenarComboBoxCategorias()
        Catch ex As Exception
            Conn.Close()
            MsgBox("Error:" & ex.Message)
        End Try
    End Sub
    Private Sub modificar_categ_Click(sender As Object, e As EventArgs) Handles modificar_categ.Click
        Dim sql_line As String
        sql_line = "exec modificarcategoriaproducto @id, @descrip_categ"
        Try
            Dim comando As New SqlCommand(sql_line, Conn)
            comando.Parameters.Add(New SqlParameter("@id", id_categ.Text))
            comando.Parameters.Add(New SqlParameter("@descrip_categ", desc_categ.Text))
            Conn.Open()
            comando.ExecuteNonQuery()
            Conn.Close()
            llenarTablaCategoria()
            deshabilitarCamposCategoria()
            limpiarcamposCategoria()
        Catch ex As Exception
            Conn.Close()
            MsgBox("Error:" & ex.Message)
        End Try
    End Sub
    Private Sub eliminar_categ_Click(sender As Object, e As EventArgs) Handles eliminar_categ.Click
        Dim sql_line As String
        sql_line = "exec eliminarcategoriaproducto @id"
        Try
            Dim comando As New SqlCommand(sql_line, Conn)
            comando.Parameters.Add(New SqlParameter("@id", id_categ.Text))
            Conn.Open()
            comando.ExecuteNonQuery()
            Conn.Close()
            llenarTablaCategoria()
            deshabilitarCamposCategoria()
            limpiarcamposCategoria()
        Catch ex As Exception
            Conn.Close()
            MsgBox("Error:" & ex.Message)
        End Try
    End Sub
    Private Sub nuevo_categ_Click(sender As Object, e As EventArgs) Handles nuevo_categ.Click
        habilitarCamposCategoria()
        limpiarcamposCategoria()
    End Sub

    Private Sub DataGridView2_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView2.DoubleClick
        id_categ.Text = DataGridView2.CurrentRow.Cells(0).Value.ToString
        desc_categ.Text = DataGridView2.CurrentRow.Cells(1).Value.ToString
        guardar_categ.Enabled = False
        modificar_categ.Enabled = True
        eliminar_categ.Enabled = True
        desc_categ.Enabled = True
    End Sub

    Private Sub busqueda_categ_TextChanged(sender As Object, e As EventArgs) Handles busqueda_categ.TextChanged
        Try
            Dim datos As New DataTable
            Dim adaptador As New SqlDataAdapter("exec busqueda_producto_categoria " & busqueda_categ.Text, Conn)
            adaptador.Fill(datos)
            DataGridView2.DataSource = datos
            todo_busqueda_categoria.Checked = False
        Catch ex As Exception
            Conn.Close()
        End Try
    End Sub

    Private Sub todo_busqueda_categoria_CheckedChanged(sender As Object, e As EventArgs) Handles todo_busqueda_categoria.CheckedChanged
        Try
            Dim datos As New DataTable
            Dim adaptador As New SqlDataAdapter("select*from llenartablaproductoscategorias", Conn)
            adaptador.Fill(datos)
            DataGridView2.DataSource = datos
            busqueda_categ.Clear()
        Catch ex As Exception
            Conn.Close()
        End Try
    End Sub

    Private Sub busqueda_TextChanged(sender As Object, e As EventArgs) Handles busqueda.TextChanged
        If id_bus_prod.Checked Then
            Try
                Dim datos As New DataTable
                Dim adaptador As New SqlDataAdapter("exec buscar_producto_id " & busqueda.Text, Conn)
                adaptador.Fill(datos)
                DataGridView1.DataSource = datos
                todo_busqueda_categoria.Checked = False
            Catch ex As Exception
                Conn.Close()
            End Try
        End If
        If nom_bus_prod.Checked Then
            If nom_bus_prod.Checked Then
                Try
                    Dim datos As New DataTable
                    Dim adaptador As New SqlDataAdapter("exec buscar_producto_nombre " & busqueda.Text, Conn)
                    adaptador.Fill(datos)
                    DataGridView1.DataSource = datos
                    todo_busqueda_categoria.Checked = False
                Catch ex As Exception
                    Conn.Close()
                End Try
            End If
        End If

    End Sub

    Private Sub todo_busqueda_CheckedChanged(sender As Object, e As EventArgs) Handles todo_busqueda.CheckedChanged
        Try
            Dim datos As New DataTable
            Dim adaptador As New SqlDataAdapter("select*from llenartablaproductos", Conn)
            adaptador.Fill(datos)
            DataGridView1.DataSource = datos
            busqueda.Clear()
            busqueda.Enabled = False
        Catch ex As Exception
            Conn.Close()
        End Try
    End Sub

    Private Sub id_bus_prod_CheckedChanged(sender As Object, e As EventArgs) Handles id_bus_prod.CheckedChanged
        busqueda.Clear()
        busqueda.Enabled = True
    End Sub

    Private Sub nom_bus_prod_CheckedChanged(sender As Object, e As EventArgs) Handles nom_bus_prod.CheckedChanged
        busqueda.Clear()
        busqueda.Enabled = True
    End Sub

    Private Sub Gb1_Enter(sender As Object, e As EventArgs) Handles Gb1.Enter

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

End Class