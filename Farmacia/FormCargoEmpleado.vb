Imports System.Data.SqlClient
Public Class FormCargoEmpleado
    Dim Conn As New SqlConnection("Data Source=LAPTOP-KE7692FS\SQLEXPRESS;Initial Catalog=FARMACIA;Integrated Security=True")
    Private Sub FormCargoEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarDatos()
    End Sub
    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        Dim sql As String
        sql = String.Format("insert into CARGOS_EMPLEADO values(@desc_Cargo)")
        Try
            Dim comando As New SqlCommand(sql, Conn)
            comando.Parameters.Add(New SqlParameter("@ID", ID_car.Text))
            comando.Parameters.Add(New SqlParameter("@desc_cargo", desc_cargo.Text))
            Conn.Open()
            comando.ExecuteNonQuery()
            Conn.Close()
            llenarDatos()
        Catch ex As Exception
            Conn.Close()
            MsgBox("Error:" & ex.Message)
        End Try
    End Sub
    Sub llenarDatos()
        Dim datos As New DataTable
        Dim adaptador As New SqlDataAdapter("select*from CARGOS_EMPLEADO", Conn)
        adaptador.Fill(datos)
        DataGridView1.DataSource = datos
    End Sub


    Private Sub actualizar_Click(sender As Object, e As EventArgs) Handles actualizar.Click
        Dim sql As String
        sql = String.Format("update CARGOS_EMPLEADO set NOMBRE_CARGO_EMP=@desc_cargo where ID_CARGO_EMP=@ID")
        Try
            Dim comando As New SqlCommand(sql, Conn)
            comando.Parameters.Add(New SqlParameter("@ID", ID_car.Text))
            comando.Parameters.Add(New SqlParameter("@desc_cargo", desc_cargo.Text))
            Conn.Open()
            comando.ExecuteNonQuery()
            Conn.Close()
            llenarDatos()
        Catch ex As Exception
            Conn.Close()
            MsgBox("Error:" & ex.Message)
        End Try
    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        Dim sql As String
        sql = String.Format("delete from CARGOS_EMPLEADO where ID_CARGO_EMP=@ID")
        Try
            Dim comando As New SqlCommand(sql, Conn)
            comando.Parameters.Add(New SqlParameter("@ID", ID_car.Text))
            Conn.Open()
            comando.ExecuteNonQuery()
            Conn.Close()
            llenarDatos()
        Catch ex As Exception
            Conn.Close()
            MsgBox("Error:" & ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        ID_car.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        desc_cargo.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
    End Sub
End Class