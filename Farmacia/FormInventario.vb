Imports System.Data.SqlClient
Public Class FormInventario
    Dim Conn As New SqlConnection("Data Source=LAPTOP-KE7692FS\SQLEXPRESS;Initial Catalog=FARMACIA;Integrated Security=True")
    Private Sub FormInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        todo_busqueda.Checked = True
    End Sub

    Private Sub busqueda_TextChanged(sender As Object, e As EventArgs) Handles busqueda.TextChanged
        If id_bus_prod.Checked Then
            Try
                Dim datos As New DataTable
                Dim adaptador As New SqlDataAdapter("exec buscar_producto_id " & busqueda.Text, Conn)
                adaptador.Fill(datos)
                DataGridView1.DataSource = datos
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
        busqueda.Enabled = True
    End Sub

    Private Sub nom_bus_prod_CheckedChanged(sender As Object, e As EventArgs) Handles nom_bus_prod.CheckedChanged
        busqueda.Enabled = True
    End Sub
End Class