<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuInicio
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
        Me.components = New System.ComponentModel.Container()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ID_COMPRA = New System.Windows.Forms.Label()
        Me.total_compra = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.buscar_cliente = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.FECHA_LBL = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.subtot_prod_bus = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.buscar_producto = New System.Windows.Forms.Button()
        Me.precio_prod_bus = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.eliminar_carrito = New System.Windows.Forms.Button()
        Me.AGREGAR_CARRITO_COMPRA = New System.Windows.Forms.Button()
        Me.nom_prod_bus = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cant_prod_bus = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.id_prod_bus = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Roboto Light", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label18.Location = New System.Drawing.Point(362, 926)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(107, 34)
        Me.Label18.TabIndex = 29
        Me.Label18.Text = "VENTA:"
        '
        'ID_COMPRA
        '
        Me.ID_COMPRA.AutoSize = True
        Me.ID_COMPRA.Font = New System.Drawing.Font("Roboto Light", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ID_COMPRA.Location = New System.Drawing.Point(464, 926)
        Me.ID_COMPRA.Name = "ID_COMPRA"
        Me.ID_COMPRA.Size = New System.Drawing.Size(133, 34)
        Me.ID_COMPRA.TabIndex = 28
        Me.ID_COMPRA.Text = "ID VENTA"
        '
        'total_compra
        '
        Me.total_compra.AutoSize = True
        Me.total_compra.Font = New System.Drawing.Font("Roboto", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.total_compra.Location = New System.Drawing.Point(1537, 852)
        Me.total_compra.Name = "total_compra"
        Me.total_compra.Size = New System.Drawing.Size(0, 34)
        Me.total_compra.TabIndex = 27
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button7)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.TextBox6)
        Me.GroupBox3.Controls.Add(Me.DataGridView2)
        Me.GroupBox3.Controls.Add(Me.buscar_cliente)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox3.Location = New System.Drawing.Point(1288, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(620, 473)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "AGREGAR CLIENTE"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(16, 156)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(226, 48)
        Me.Button7.TabIndex = 5
        Me.Button7.Text = "ESCOGER CLIENTE"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 58)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 24)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "CLIENTE:"
        '
        'TextBox6
        '
        Me.TextBox6.Enabled = False
        Me.TextBox6.Location = New System.Drawing.Point(16, 85)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(226, 32)
        Me.TextBox6.TabIndex = 3
        Me.TextBox6.Text = "CLIENTE GENERAL"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(108, 295)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 29
        Me.DataGridView2.Size = New System.Drawing.Size(451, 137)
        Me.DataGridView2.TabIndex = 2
        '
        'buscar_cliente
        '
        Me.buscar_cliente.Location = New System.Drawing.Point(255, 245)
        Me.buscar_cliente.Name = "buscar_cliente"
        Me.buscar_cliente.Size = New System.Drawing.Size(239, 32)
        Me.buscar_cliente.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(160, 248)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 24)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "BUSCAR:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Roboto", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label15.Location = New System.Drawing.Point(1521, 740)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(179, 57)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "TOTAL:"
        '
        'FECHA_LBL
        '
        Me.FECHA_LBL.AutoSize = True
        Me.FECHA_LBL.Font = New System.Drawing.Font("Roboto Light", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FECHA_LBL.Location = New System.Drawing.Point(12, 926)
        Me.FECHA_LBL.Name = "FECHA_LBL"
        Me.FECHA_LBL.Size = New System.Drawing.Size(102, 34)
        Me.FECHA_LBL.TabIndex = 24
        Me.FECHA_LBL.Text = "FECHA"
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Roboto", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button6.Location = New System.Drawing.Point(1033, 717)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(217, 187)
        Me.Button6.TabIndex = 23
        Me.Button6.Text = "CANCELAR VENTA"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Roboto", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(795, 717)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(217, 187)
        Me.Button5.TabIndex = 22
        Me.Button5.Text = "REALIZAR VENTA"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 307)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(1238, 354)
        Me.DataGridView1.TabIndex = 18
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.subtot_prod_bus)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.buscar_producto)
        Me.GroupBox1.Controls.Add(Me.precio_prod_bus)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.eliminar_carrito)
        Me.GroupBox1.Controls.Add(Me.AGREGAR_CARRITO_COMPRA)
        Me.GroupBox1.Controls.Add(Me.nom_prod_bus)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cant_prod_bus)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.id_prod_bus)
        Me.GroupBox1.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1238, 272)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "VENTAS"
        '
        'subtot_prod_bus
        '
        Me.subtot_prod_bus.AutoSize = True
        Me.subtot_prod_bus.Location = New System.Drawing.Point(1037, 154)
        Me.subtot_prod_bus.Name = "subtot_prod_bus"
        Me.subtot_prod_bus.Size = New System.Drawing.Size(166, 24)
        Me.subtot_prod_bus.TabIndex = 14
        Me.subtot_prod_bus.Text = "--------------------------"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label17.Location = New System.Drawing.Point(925, 151)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(91, 24)
        Me.Label17.TabIndex = 13
        Me.Label17.Text = "Subtotal:"
        '
        'buscar_producto
        '
        Me.buscar_producto.Location = New System.Drawing.Point(689, 61)
        Me.buscar_producto.Name = "buscar_producto"
        Me.buscar_producto.Size = New System.Drawing.Size(211, 32)
        Me.buscar_producto.TabIndex = 12
        Me.buscar_producto.Text = "BUSCAR PRODUCTO"
        Me.buscar_producto.UseVisualStyleBackColor = True
        '
        'precio_prod_bus
        '
        Me.precio_prod_bus.AutoSize = True
        Me.precio_prod_bus.Location = New System.Drawing.Point(734, 154)
        Me.precio_prod_bus.Name = "precio_prod_bus"
        Me.precio_prod_bus.Size = New System.Drawing.Size(166, 24)
        Me.precio_prod_bus.TabIndex = 9
        Me.precio_prod_bus.Text = "--------------------------"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label12.Location = New System.Drawing.Point(655, 154)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 24)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Precio:"
        '
        'eliminar_carrito
        '
        Me.eliminar_carrito.Location = New System.Drawing.Point(523, 214)
        Me.eliminar_carrito.Name = "eliminar_carrito"
        Me.eliminar_carrito.Size = New System.Drawing.Size(236, 39)
        Me.eliminar_carrito.TabIndex = 7
        Me.eliminar_carrito.Text = "ELIMINAR PRODUCTO"
        Me.eliminar_carrito.UseVisualStyleBackColor = True
        '
        'AGREGAR_CARRITO_COMPRA
        '
        Me.AGREGAR_CARRITO_COMPRA.Location = New System.Drawing.Point(274, 214)
        Me.AGREGAR_CARRITO_COMPRA.Name = "AGREGAR_CARRITO_COMPRA"
        Me.AGREGAR_CARRITO_COMPRA.Size = New System.Drawing.Size(236, 39)
        Me.AGREGAR_CARRITO_COMPRA.TabIndex = 6
        Me.AGREGAR_CARRITO_COMPRA.Text = "AGREGAR PRODUCTO"
        Me.AGREGAR_CARRITO_COMPRA.UseVisualStyleBackColor = True
        '
        'nom_prod_bus
        '
        Me.nom_prod_bus.AutoSize = True
        Me.nom_prod_bus.Location = New System.Drawing.Point(147, 154)
        Me.nom_prod_bus.Name = "nom_prod_bus"
        Me.nom_prod_bus.Size = New System.Drawing.Size(166, 24)
        Me.nom_prod_bus.TabIndex = 5
        Me.nom_prod_bus.Text = "--------------------------"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(31, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Producto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(371, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cantidad:"
        '
        'cant_prod_bus
        '
        Me.cant_prod_bus.Location = New System.Drawing.Point(469, 151)
        Me.cant_prod_bus.Name = "cant_prod_bus"
        Me.cant_prod_bus.Size = New System.Drawing.Size(126, 32)
        Me.cant_prod_bus.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(31, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Código del producto:"
        '
        'id_prod_bus
        '
        Me.id_prod_bus.Location = New System.Drawing.Point(235, 61)
        Me.id_prod_bus.Name = "id_prod_bus"
        Me.id_prod_bus.Size = New System.Drawing.Size(423, 32)
        Me.id_prod_bus.TabIndex = 0
        '
        'Timer1
        '
        '
        'FormMenuInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1920, 970)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.ID_COMPRA)
        Me.Controls.Add(Me.total_compra)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.FECHA_LBL)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormMenuInicio"
        Me.Text = "FormMenuInicio"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label18 As Label
    Friend WithEvents ID_COMPRA As Label
    Friend WithEvents total_compra As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents buscar_cliente As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents FECHA_LBL As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents subtot_prod_bus As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents buscar_producto As Button
    Friend WithEvents exis_prod_bus As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents precio_prod_bus As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents eliminar_carrito As Button
    Friend WithEvents AGREGAR_CARRITO_COMPRA As Button
    Friend WithEvents nom_prod_bus As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cant_prod_bus As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents id_prod_bus As TextBox
    Friend WithEvents Timer1 As Timer
End Class
