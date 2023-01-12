<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.VentasToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosSubToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.EmpleadosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosSubToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProveedoresToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesionToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Font = New System.Drawing.Font("Roboto Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VentasToolStripMenuItem4, Me.InventarioStripMenuItem4, Me.ComprasStripMenuItem4, Me.ClientesToolStripMenuItem2, Me.ProductosToolStripMenuItem3, Me.EmpleadosToolStripMenuItem1, Me.ProveedoresToolStripMenuItem1, Me.CerrarSesionToolStripMenuItem4})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1920, 36)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'VentasToolStripMenuItem4
        '
        Me.VentasToolStripMenuItem4.Image = Global.Farmacia.My.Resources.Resources.ventas
        Me.VentasToolStripMenuItem4.Name = "VentasToolStripMenuItem4"
        Me.VentasToolStripMenuItem4.Size = New System.Drawing.Size(130, 32)
        Me.VentasToolStripMenuItem4.Text = "VENTAS"
        '
        'InventarioStripMenuItem4
        '
        Me.InventarioStripMenuItem4.Image = Global.Farmacia.My.Resources.Resources.inventario
        Me.InventarioStripMenuItem4.Name = "InventarioStripMenuItem4"
        Me.InventarioStripMenuItem4.Size = New System.Drawing.Size(175, 32)
        Me.InventarioStripMenuItem4.Text = "INVENTARIO"
        '
        'ComprasStripMenuItem4
        '
        Me.ComprasStripMenuItem4.Image = Global.Farmacia.My.Resources.Resources.compra
        Me.ComprasStripMenuItem4.Name = "ComprasStripMenuItem4"
        Me.ComprasStripMenuItem4.Size = New System.Drawing.Size(154, 32)
        Me.ComprasStripMenuItem4.Text = "COMPRAS"
        '
        'ClientesToolStripMenuItem2
        '
        Me.ClientesToolStripMenuItem2.Image = CType(resources.GetObject("ClientesToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.ClientesToolStripMenuItem2.Name = "ClientesToolStripMenuItem2"
        Me.ClientesToolStripMenuItem2.Size = New System.Drawing.Size(149, 32)
        Me.ClientesToolStripMenuItem2.Text = "CLIENTES"
        '
        'ProductosToolStripMenuItem3
        '
        Me.ProductosToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosSubToolStripMenuItem4, Me.ToolStripSeparator2})
        Me.ProductosToolStripMenuItem3.Image = CType(resources.GetObject("ProductosToolStripMenuItem3.Image"), System.Drawing.Image)
        Me.ProductosToolStripMenuItem3.Name = "ProductosToolStripMenuItem3"
        Me.ProductosToolStripMenuItem3.Size = New System.Drawing.Size(180, 32)
        Me.ProductosToolStripMenuItem3.Text = "PRODUCTOS"
        '
        'ProductosSubToolStripMenuItem4
        '
        Me.ProductosSubToolStripMenuItem4.Image = CType(resources.GetObject("ProductosSubToolStripMenuItem4.Image"), System.Drawing.Image)
        Me.ProductosSubToolStripMenuItem4.Name = "ProductosSubToolStripMenuItem4"
        Me.ProductosSubToolStripMenuItem4.Size = New System.Drawing.Size(232, 32)
        Me.ProductosSubToolStripMenuItem4.Text = "PRODUCTOS"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(229, 6)
        '
        'EmpleadosToolStripMenuItem1
        '
        Me.EmpleadosToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpleadosSubToolStripMenuItem1, Me.ToolStripSeparator1})
        Me.EmpleadosToolStripMenuItem1.Image = CType(resources.GetObject("EmpleadosToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.EmpleadosToolStripMenuItem1.Name = "EmpleadosToolStripMenuItem1"
        Me.EmpleadosToolStripMenuItem1.Size = New System.Drawing.Size(177, 32)
        Me.EmpleadosToolStripMenuItem1.Text = "EMPLEADOS"
        '
        'EmpleadosSubToolStripMenuItem1
        '
        Me.EmpleadosSubToolStripMenuItem1.Image = CType(resources.GetObject("EmpleadosSubToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.EmpleadosSubToolStripMenuItem1.Name = "EmpleadosSubToolStripMenuItem1"
        Me.EmpleadosSubToolStripMenuItem1.Size = New System.Drawing.Size(229, 32)
        Me.EmpleadosSubToolStripMenuItem1.Text = "EMPLEADOS"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(226, 6)
        '
        'ProveedoresToolStripMenuItem1
        '
        Me.ProveedoresToolStripMenuItem1.Image = CType(resources.GetObject("ProveedoresToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ProveedoresToolStripMenuItem1.Name = "ProveedoresToolStripMenuItem1"
        Me.ProveedoresToolStripMenuItem1.Size = New System.Drawing.Size(204, 32)
        Me.ProveedoresToolStripMenuItem1.Text = "PROVEEDORES"
        '
        'CerrarSesionToolStripMenuItem4
        '
        Me.CerrarSesionToolStripMenuItem4.Image = CType(resources.GetObject("CerrarSesionToolStripMenuItem4.Image"), System.Drawing.Image)
        Me.CerrarSesionToolStripMenuItem4.Name = "CerrarSesionToolStripMenuItem4"
        Me.CerrarSesionToolStripMenuItem4.Size = New System.Drawing.Size(218, 32)
        Me.CerrarSesionToolStripMenuItem4.Text = "CERRAR SESIÓN"
        '
        'PanelContenedor
        '
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(0, 36)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(1920, 966)
        Me.PanelContenedor.TabIndex = 1
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1920, 1002)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormMenu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripTextBox4 As ToolStripTextBox
    Friend WithEvents ToolStripTextBox3 As ToolStripTextBox
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripTextBox2 As ToolStripTextBox
    Friend WithEvents EmpleadosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EmpleadosSubToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ClientesToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ProductosSubToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents HolaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DfsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents CerrarSesionToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents COMPRAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprasStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents InventarioStripMenuItem4 As ToolStripMenuItem
End Class
