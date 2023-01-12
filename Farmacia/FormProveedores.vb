Imports System.Data.SqlClient
Public Class FormProveedores
    Dim Conn As New SqlConnection("Data Source=LAPTOP-KE7692FS\SQLEXPRESS;Initial Catalog=FARMACIA;Integrated Security=True")
    Private Sub FormProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarDatos()
        limpiarcampos()
        inabilitarCampos()
        todo_busqueda.Checked = True
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

    End Sub
    Sub llenarDatos()
        Dim datos As New DataTable
        Dim adaptador As New SqlDataAdapter("select*from llenartablaproveedores", Conn)
        adaptador.Fill(datos)
        DataGridView1.DataSource = datos
    End Sub
    Sub limpiarcampos()
        id_prov.Clear()
        emp_prov.Clear()
        nom_prov.Clear()
        ape_prov.Clear()
        dir_prov.Clear()
        tel_prov.Clear()
    End Sub
    Sub inabilitarCampos()
        id_prov.Enabled = False
        emp_prov.Enabled = False
        nom_prov.Enabled = False
        ape_prov.Enabled = False
        dir_prov.Enabled = False
        tel_prov.Enabled = False
        guardar.Enabled = False
        Modificar.Enabled = False
        eliminar.Enabled = False
    End Sub
    Sub habilitarCampos()
        emp_prov.Enabled = True
        nom_prov.Enabled = True
        ape_prov.Enabled = True
        dir_prov.Enabled = True
        tel_prov.Enabled = True
        guardar.Enabled = True
        Modificar.Enabled = True
        eliminar.Enabled = True
    End Sub

    Private Sub guardar_Click(sender As Object, e As EventArgs) Handles guardar.Click
        Dim sql_line As String
        sql_line = "exec insertar_proveedor @empresa, @nombre, @apellido, @direccion, @telefono"
        Try
            Dim comando As New SqlCommand(sql_line, Conn)
            comando.Parameters.Add(New SqlParameter("@empresa", emp_prov.Text))
            comando.Parameters.Add(New SqlParameter("@nombre", nom_prov.Text))
            comando.Parameters.Add(New SqlParameter("@apellido", ape_prov.Text))
            comando.Parameters.Add(New SqlParameter("@direccion", dir_prov.Text))
            comando.Parameters.Add(New SqlParameter("@telefono", tel_prov.Text))
            Conn.Open()
            comando.ExecuteNonQuery()
            Conn.Close()
            llenarDatos()
            limpiarcampos()
        Catch ex As Exception
            Conn.Close()
            MsgBox("Error:" & ex.Message)
        End Try
    End Sub

    Private Sub Modificar_Click(sender As Object, e As EventArgs) Handles Modificar.Click
        Dim sql_line As String
        sql_line = "exec actualizar_proveedor @id, @empresa, @nombre, @apellido, @direccion, @telefono"
        Try
            Dim comando As New SqlCommand(sql_line, Conn)
            comando.Parameters.Add(New SqlParameter("@id", id_prov.Text))
            comando.Parameters.Add(New SqlParameter("@empresa", emp_prov.Text))
            comando.Parameters.Add(New SqlParameter("@nombre", nom_prov.Text))
            comando.Parameters.Add(New SqlParameter("@apellido", ape_prov.Text))
            comando.Parameters.Add(New SqlParameter("@direccion", dir_prov.Text))
            comando.Parameters.Add(New SqlParameter("@telefono", tel_prov.Text))
            Conn.Open()
            comando.ExecuteNonQuery()
            Conn.Close()
            llenarDatos()
            limpiarcampos()
        Catch ex As Exception
            Conn.Close()
            MsgBox("Error:" & ex.Message)
        End Try
    End Sub

    Private Sub eliminar_Click(sender As Object, e As EventArgs) Handles eliminar.Click
        Dim sql_line As String
        sql_line = "exec eliminar_proveedor @id"
        Try
            Dim comando As New SqlCommand(sql_line, Conn)
            comando.Parameters.Add(New SqlParameter("@id", id_prov.Text))
            Conn.Open()
            comando.ExecuteNonQuery()
            Conn.Close()
            llenarDatos()
            limpiarcampos()
        Catch ex As Exception
            Conn.Close()
            MsgBox("Error:" & ex.Message)
        End Try
    End Sub
    Private Sub agregar_Click(sender As Object, e As EventArgs) Handles agregar.Click
        habilitarCampos()
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        id_prov.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        emp_prov.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        nom_prov.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        ape_prov.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        dir_prov.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        tel_prov.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
    End Sub

    Private Sub busqueda_TextChanged(sender As Object, e As EventArgs) Handles busqueda.TextChanged
        If nom_prov_bus.Checked Then
            Try
                Dim datos As New DataTable
                Dim adaptador As New SqlDataAdapter("exec busqueda_proveedor_nombre " & busqueda.Text, Conn)
                adaptador.Fill(datos)
                DataGridView1.DataSource = datos
            Catch ex As Exception
                Conn.Close()
                MsgBox("Error:" & ex.Message)
            End Try
        End If
        If nom_emp_bus.Checked Then
            Try
                Dim datos As New DataTable
                Dim adaptador As New SqlDataAdapter("exec busqueda_proveedor_empresa " & busqueda.Text, Conn)
                adaptador.Fill(datos)
                DataGridView1.DataSource = datos
            Catch ex As Exception
                Conn.Close()
                MsgBox("Error:" & ex.Message)
            End Try
        End If
    End Sub

    Private Sub todo_busqueda_CheckedChanged(sender As Object, e As EventArgs) Handles todo_busqueda.CheckedChanged
        Try
            Dim datos As New DataTable
            Dim adaptador As New SqlDataAdapter("select*from llenartablaproveedores", Conn)
            adaptador.Fill(datos)
            DataGridView1.DataSource = datos
            busqueda.Clear()
        Catch ex As Exception
            Conn.Close()
            MsgBox("Error:" & ex.Message)
        End Try
    End Sub
End Class