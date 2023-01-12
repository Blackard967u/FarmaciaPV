Imports System.Data.SqlClient
Public Class FormEmpleados
    Dim Conn As New SqlConnection("Data Source=LAPTOP-KE7692FS\SQLEXPRESS;Initial Catalog=FARMACIA;Integrated Security=True")
    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        Dim sql_line As String
        sql_line = "exec insertar_empleado @cargo, @nombre, @apellido, @direccion, @telefono, @email, @nss, @salario, @usuario, @contras"
        Try
            Dim comando As New SqlCommand(sql_line, Conn)
            comando.Parameters.Add(New SqlParameter("@ID", id_empleado.Text))
            comando.Parameters.Add(New SqlParameter("@cargo", Cargo_empleado.SelectedItem))
            comando.Parameters.Add(New SqlParameter("@nombre", nom_empleado.Text))
            comando.Parameters.Add(New SqlParameter("@apellido", ape_empleado.Text))
            comando.Parameters.Add(New SqlParameter("@direccion", dir_empleado.Text))
            comando.Parameters.Add(New SqlParameter("@telefono", Tel_empleado.Text))
            comando.Parameters.Add(New SqlParameter("@email", email_empleado.Text))
            comando.Parameters.Add(New SqlParameter("@nss", nss_empleado.Text))
            comando.Parameters.Add(New SqlParameter("@salario", salario_empleado.Text))
            comando.Parameters.Add(New SqlParameter("@usuario", usuario_empleado.Text))
            comando.Parameters.Add(New SqlParameter("@contras", contras_empleado.Text))
            Conn.Open()
            comando.ExecuteNonQuery()
            Conn.Close()
            llenarDatos()
            limpiarCampos()
            Button4.Enabled = True
            desabilitar_campos()
        Catch ex As Exception
            Conn.Close()
            MsgBox("Error:" & ex.Message)
        End Try

    End Sub
    Sub llenarDatos()
        Dim datos As New DataTable
        Dim adaptador As New SqlDataAdapter("select*from llenartablaempleados", Conn)
        adaptador.Fill(datos)
        DataGridView1.DataSource = datos
    End Sub
    Sub limpiarCampos()
        id_empleado.Clear()
        Cargo_empleado.SelectedIndex = 2
        nom_empleado.Clear()
        ape_empleado.Clear()
        dir_empleado.Clear()
        Tel_empleado.Clear()
        email_empleado.Clear()
        nss_empleado.Clear()
        salario_empleado.Clear()
        usuario_empleado.Clear()
        contras_empleado.Clear()
    End Sub
    Sub desabilitar_campos()
        Cargo_empleado.Enabled = False
        nom_empleado.Enabled = False
        ape_empleado.Enabled = False
        dir_empleado.Enabled = False
        Tel_empleado.Enabled = False
        email_empleado.Enabled = False
        nss_empleado.Enabled = False
        salario_empleado.Enabled = False
        usuario_empleado.Enabled = False
        contras_empleado.Enabled = False
        Guardar.Enabled = False
        Button3.Enabled = False
        Button2.Enabled = False
    End Sub
    Sub habilitar_campos()
        Cargo_empleado.Enabled = True
        nom_empleado.Enabled = True
        ape_empleado.Enabled = True
        dir_empleado.Enabled = True
        Tel_empleado.Enabled = True
        email_empleado.Enabled = True
        nss_empleado.Enabled = True
        salario_empleado.Enabled = True
        usuario_empleado.Enabled = True
        contras_empleado.Enabled = True
        Guardar.Enabled = True
        Button3.Enabled = True
        Button2.Enabled = True
    End Sub
    Private Sub FormEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarDatos()
        limpiarCampos()
        desabilitar_campos()
        todo_busqueda.Checked = True
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        id_empleado.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        Cargo_empleado.SelectedItem = DataGridView1.CurrentRow.Cells(1).Value.ToString
        nom_empleado.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        ape_empleado.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        dir_empleado.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        Tel_empleado.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        email_empleado.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
        nss_empleado.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString
        salario_empleado.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString
        usuario_empleado.Text = DataGridView1.CurrentRow.Cells(9).Value.ToString
        contras_empleado.Text = DataGridView1.CurrentRow.Cells(10).Value.ToString

        habilitar_campos()

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim sql_line As String
        sql_line = "exec actualizar_empleado @ID, @cargo, @nombre, @apellido, @direccion, @telefono, @email, @nss, @salario, @usuario, @contras"
        Try
            Dim comando As New SqlCommand(sql_line, Conn)
            comando.Parameters.Add(New SqlParameter("@ID", id_empleado.Text))
            comando.Parameters.Add(New SqlParameter("@cargo", Cargo_empleado.SelectedItem))
            comando.Parameters.Add(New SqlParameter("@nombre", nom_empleado.Text))
            comando.Parameters.Add(New SqlParameter("@apellido", ape_empleado.Text))
            comando.Parameters.Add(New SqlParameter("@direccion", dir_empleado.Text))
            comando.Parameters.Add(New SqlParameter("@telefono", Tel_empleado.Text))
            comando.Parameters.Add(New SqlParameter("@email", email_empleado.Text))
            comando.Parameters.Add(New SqlParameter("@nss", nss_empleado.Text))
            comando.Parameters.Add(New SqlParameter("@salario", salario_empleado.Text))
            comando.Parameters.Add(New SqlParameter("@usuario", usuario_empleado.Text))
            comando.Parameters.Add(New SqlParameter("@contras", contras_empleado.Text))
            Conn.Open()
            comando.ExecuteNonQuery()
            Conn.Close()
            llenarDatos()
            limpiarCampos()
        Catch ex As Exception
            Conn.Close()
            MsgBox("Error:" & ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sql_line As String
        sql_line = "exec eliminar_empleado @ID"
        Try
            Dim comando As New SqlCommand(sql_line, Conn)
            comando.Parameters.Add(New SqlParameter("@ID", id_empleado.Text))
            Conn.Open()
            comando.ExecuteNonQuery()
            Conn.Close()
            llenarDatos()
            limpiarCampos()
        Catch ex As Exception
            Conn.Close()
            MsgBox("Error:" & ex.Message)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles busqueda.TextChanged
        If id_busqueda.Checked Then
            Try
                Dim datos As New DataTable
                Dim adaptador As New SqlDataAdapter("exec busqueda_empleado_id " & busqueda.Text, Conn)
                adaptador.Fill(datos)
                DataGridView1.DataSource = datos
            Catch ex As Exception
                Conn.Close()
                MsgBox("Error:" & ex.Message)
            End Try
        End If
        If nom_bus.Checked Then
            Try
                Dim datos As New DataTable
                Dim adaptador As New SqlDataAdapter("exec busqueda_empleado_nombre " & busqueda.Text, Conn)
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
            Dim adaptador As New SqlDataAdapter("select*from llenartablaempleados", Conn)
            adaptador.Fill(datos)
            DataGridView1.DataSource = datos
            busqueda.Clear()
        Catch ex As Exception
            Conn.Close()
            MsgBox("Error:" & ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button4.Enabled = False
        habilitar_campos()
    End Sub
End Class