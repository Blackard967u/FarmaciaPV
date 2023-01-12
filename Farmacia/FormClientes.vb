Imports System.Data.SqlClient
Public Class FormClientes
    Dim Conn As New SqlConnection("Data Source=LAPTOP-KE7692FS\SQLEXPRESS;Initial Catalog=FARMACIA;Integrated Security=True")
    Private Sub FormClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarDatos()
        inhabilitarCampos()
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub
    Sub llenarDatos()
        Dim datos As New DataTable
        Dim adaptador As New SqlDataAdapter("select*from llenartablaclientes", Conn)
        adaptador.Fill(datos)
        DataGridView1.DataSource = datos
    End Sub
    Sub limpiarCampos()
        id_clie.Clear()
        nom_clie.Clear()
        ape_clie.Clear()
        dire_clie.Clear()
        tel_clie.Clear()
        email_clie.Clear()
    End Sub
    Sub inhabilitarCampos()
        id_clie.Enabled = False
        nom_clie.Enabled = False
        ape_clie.Enabled = False
        dire_clie.Enabled = False
        tel_clie.Enabled = False
        email_clie.Enabled = False
        guardar.Enabled = False
        Modificar.Enabled = False
        eliminar.Enabled = False
    End Sub
    Sub habilitarCampos()
        id_clie.Enabled = True
        nom_clie.Enabled = True
        ape_clie.Enabled = True
        dire_clie.Enabled = True
        tel_clie.Enabled = True
        email_clie.Enabled = True
        guardar.Enabled = True
        Modificar.Enabled = True
        eliminar.Enabled = True
    End Sub

    Private Sub guardar_Click(sender As Object, e As EventArgs) Handles guardar.Click
        Dim sql_line As String
        sql_line = "exec guardar_cliente @nom_cliente, @ape_cliente, @dir_cliente, @tel_cliente, @email_cliente"
        Try
            Dim comando As New SqlCommand(sql_line, Conn)
            comando.Parameters.Add(New SqlParameter("@nom_cliente", nom_clie.Text))
            comando.Parameters.Add(New SqlParameter("@ape_cliente", ape_clie.Text))
            comando.Parameters.Add(New SqlParameter("@dir_cliente", dire_clie.Text))
            comando.Parameters.Add(New SqlParameter("@tel_cliente", tel_clie.Text))
            comando.Parameters.Add(New SqlParameter("@email_cliente", email_clie.Text))
            Conn.Open()
            comando.ExecuteNonQuery()
            Conn.Close()
            llenarDatos()
            limpiarCampos()
            inhabilitarCampos()

        Catch ex As Exception
            Conn.Close()
            MsgBox("Error:" & ex.Message)
        End Try
    End Sub

    Private Sub Modificar_Click(sender As Object, e As EventArgs) Handles Modificar.Click
        Dim sql_line As String
        sql_line = "exec modificar_cliente @id, @nom_cliente, @ape_cliente, @dir_cliente, @tel_cliente, @email_cliente"
        Try
            Dim comando As New SqlCommand(sql_line, Conn)
            comando.Parameters.Add(New SqlParameter("@id", id_clie.Text))
            comando.Parameters.Add(New SqlParameter("@nom_cliente", nom_clie.Text))
            comando.Parameters.Add(New SqlParameter("@ape_cliente", ape_clie.Text))
            comando.Parameters.Add(New SqlParameter("@dir_cliente", dire_clie.Text))
            comando.Parameters.Add(New SqlParameter("@tel_cliente", tel_clie.Text))
            comando.Parameters.Add(New SqlParameter("@email_cliente", email_clie.Text))
            Conn.Open()
            comando.ExecuteNonQuery()
            Conn.Close()
            llenarDatos()
            limpiarCampos()
            inhabilitarCampos()

        Catch ex As Exception
            Conn.Close()
            MsgBox("Error:" & ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        id_clie.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        nom_clie.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        ape_clie.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        dire_clie.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        tel_clie.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        email_clie.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        habilitarCampos()
    End Sub

    Private Sub eliminar_Click(sender As Object, e As EventArgs) Handles eliminar.Click
        Dim sql_line As String
        sql_line = "exec eliminar_cliente @id"
        Try
            Dim comando As New SqlCommand(sql_line, Conn)
            comando.Parameters.Add(New SqlParameter("@id", id_clie.Text))
            Conn.Open()
            comando.ExecuteNonQuery()
            Conn.Close()
            llenarDatos()
            limpiarCampos()
            inhabilitarCampos()

        Catch ex As Exception
            Conn.Close()
            MsgBox("Error:" & ex.Message)
        End Try
    End Sub

    Private Sub busqueda_TextChanged(sender As Object, e As EventArgs) Handles busqueda.TextChanged
        If id_clie_bus.Checked Then
            Try
                Dim datos As New DataTable
                Dim adaptador As New SqlDataAdapter("exec buscar_cliente_id " & busqueda.Text, Conn)
                adaptador.Fill(datos)
                DataGridView1.DataSource = datos
            Catch ex As Exception
                Conn.Close()
            End Try
        End If
        If nom_clie_bus.Checked Then
            Try
                Dim datos As New DataTable
                Dim adaptador As New SqlDataAdapter("exec buscar_cliente_nombre " & busqueda.Text, Conn)
                adaptador.Fill(datos)
                DataGridView1.DataSource = datos
            Catch ex As Exception
                Conn.Close()
            End Try
        End If
    End Sub

    Private Sub todo_busqueda_CheckedChanged(sender As Object, e As EventArgs) Handles todo_busqueda.CheckedChanged
        Try
            Dim datos As New DataTable
            Dim adaptador As New SqlDataAdapter("select*from llenartablaclientes", Conn)
            adaptador.Fill(datos)
            DataGridView1.DataSource = datos
            busqueda.Clear()
        Catch ex As Exception
            Conn.Close()
            MsgBox("Error:" & ex.Message)
        End Try
    End Sub

    Private Sub agregar_Click(sender As Object, e As EventArgs) Handles agregar.Click
        habilitarCampos()
    End Sub
End Class