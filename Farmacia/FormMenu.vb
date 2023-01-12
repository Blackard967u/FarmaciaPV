Public Class FormMenu
    Private Sub EmpleadosSubToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EmpleadosSubToolStripMenuItem1.Click
        AbrirFormEmpleados(New FormEmpleados)
    End Sub
    Private Sub AbrirFormEmpleados(formHijoEmp As Object)
        If (PanelContenedor.Controls.Count > 0) Then
            PanelContenedor.Controls.RemoveAt(0)
        End If
        Dim frmEmp As Form
        frmEmp = formHijoEmp
        frmEmp.TopLevel = False
        'frmProd.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(frmEmp)
        PanelContenedor.Tag = frmEmp
        frmEmp.Show()
    End Sub

    Private Sub ProductosSubToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ProductosSubToolStripMenuItem4.Click
        AbrirFormProductos(New FormProductos)
    End Sub
    Private Sub AbrirFormProductos(formHijoProd As Object)
        If (PanelContenedor.Controls.Count > 0) Then
            PanelContenedor.Controls.RemoveAt(0)
        End If
        Dim frmProd As Form
        frmProd = formHijoProd
        frmProd.TopLevel = False
        'frmProd.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(frmProd)
        PanelContenedor.Tag = frmProd
        frmProd.Show()
    End Sub

    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirFormVentas(New FormVentas)
    End Sub

    Private Sub CerrarSesionToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles CerrarSesionToolStripMenuItem4.Click
        If MsgBox("Está a punto del sistema, ¿Está seguro de salir?", vbYesNo + vbExclamation, "ADVERTENCIA") = vbYes Then
            If MsgBox("¿Seguro que desea salir?", vbYesNo + vbExclamation, "ADVERTENCIA") = vbYes Then
                Dim Login As New Form1
                Login.Show()
                Me.Hide()
            End If
        End If


    End Sub

    Private Sub ProveedoresToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem1.Click
        AbrirFormProveedores(New FormProveedores)
    End Sub
    Private Sub AbrirFormProveedores(formHijoProve As Object)
        If (PanelContenedor.Controls.Count > 0) Then
            PanelContenedor.Controls.RemoveAt(0)
        End If
        Dim frmProveedores As Form
        frmProveedores = formHijoProve
        frmProveedores.TopLevel = False
        'frmProd.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(frmProveedores)
        PanelContenedor.Tag = frmProveedores
        frmProveedores.Show()

    End Sub

    Private Sub ClientesToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem2.Click
        AbrirFormClientes(New FormClientes)
    End Sub
    Private Sub AbrirFormClientes(formHijoClientes As Object)
        If (PanelContenedor.Controls.Count > 0) Then
            PanelContenedor.Controls.RemoveAt(0)
        End If
        Dim frmMenuClie As Form
        frmMenuClie = formHijoClientes
        frmMenuClie.TopLevel = False
        'frmProd.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(frmMenuClie)
        PanelContenedor.Tag = frmMenuClie
        frmMenuClie.Show()
    End Sub

    Private Sub VentasToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem4.Click
        AbrirFormVentas(New FormVentas)
    End Sub
    Private Sub AbrirFormVentas(formHijoVentas As Object)
        If (PanelContenedor.Controls.Count > 0) Then
            PanelContenedor.Controls.RemoveAt(0)
        End If
        Dim frmVentas As Form
        frmVentas = formHijoVentas
        frmVentas.TopLevel = False
        'frmProd.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(frmVentas)
        PanelContenedor.Tag = frmVentas
        frmVentas.Show()
    End Sub

    Private Sub AbrirFormCompra(formHijoCompras As Object)
        If (PanelContenedor.Controls.Count > 0) Then
            PanelContenedor.Controls.RemoveAt(0)
        End If
        Dim frmCompras As Form
        frmCompras = formHijoCompras
        frmCompras.TopLevel = False
        'frmProd.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(frmCompras)
        PanelContenedor.Tag = frmCompras
        frmCompras.Show()
    End Sub

    Private Sub ComprasStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ComprasStripMenuItem4.Click
        AbrirFormCompra(New FormCompras)
    End Sub

    Private Sub InventarioStripMenuItem4_Click(sender As Object, e As EventArgs) Handles InventarioStripMenuItem4.Click
        AbrirFormInventario(New FormInventario)
    End Sub
    Private Sub AbrirFormInventario(formHijoInventario As Object)
        If (PanelContenedor.Controls.Count > 0) Then
            PanelContenedor.Controls.RemoveAt(0)
        End If
        Dim frmInventario As Form
        frmInventario = formHijoInventario
        frmInventario.TopLevel = False
        'frmProd.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(frmInventario)
        PanelContenedor.Tag = frmInventario
        frmInventario.Show()
    End Sub
End Class