Imports System.Data.SqlClient
Public Class Form1

    Dim Conn As New SqlConnection("Data Source=LAPTOP-KE7692FS\SQLEXPRESS;Initial Catalog=FARMACIA;Integrated Security=True")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim consulta As String = "select NOMBRE_EMPLEADO, NOMBRE_CARGO from EMPLEADOS where USUARIO = '" & usu.Text & "' AND CONTRASENA = '" & contras.Text & "'"
        Dim comando As New SqlCommand(consulta, Conn)
        Dim drd As SqlDataReader
        Conn.Open()
        drd = comando.ExecuteReader
        If drd.Read() Then
            VariablesGlobales.nombre_log = drd.Item("NOMBRE_EMPLEADO").ToString
            VariablesGlobales.puesto = drd.Item("NOMBRE_CARGO").ToString
            Dim Menu As New FormMenu
            Menu.Show()
            Me.Hide()

            If puesto = "Empleado" Then
                Menu.ComprasStripMenuItem4.Visible = False
                Menu.ClientesToolStripMenuItem2.Visible = False
                Menu.ProductosToolStripMenuItem3.Visible = False
                Menu.EmpleadosToolStripMenuItem1.Visible = False
                Menu.ProveedoresToolStripMenuItem1.Visible = False

            End If

        Else
            MsgBox("Usuario o contraseña incorrecta", vbExclamation)
            Conn.Close()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

End Class
