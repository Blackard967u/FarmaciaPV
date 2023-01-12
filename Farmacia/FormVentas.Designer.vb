<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVentas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.id_prod_bus = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.subtot_prod_bus = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.buscar_producto = New System.Windows.Forms.Button()
        Me.exis_prod_bus = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.precio_prod_bus = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.eliminar_carrito = New System.Windows.Forms.Button()
        Me.AGREGAR_CARRITO = New System.Windows.Forms.Button()
        Me.nom_prod_bus = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cant_prod_bus = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.exis_prod_busqueda = New System.Windows.Forms.Label()
        Me.precio_prod_busqueda = New System.Windows.Forms.Label()
        Me.nom_prod_busqueda = New System.Windows.Forms.Label()
        Me.buscar_producto_busqueda = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.id_prod_busqueda = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FECHA_LBL = New System.Windows.Forms.Label()
        Me.atiende = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.buscar_cliente = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Tot_venta = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ID_VENTA = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'id_prod_bus
        '
        Me.id_prod_bus.Location = New System.Drawing.Point(235, 61)
        Me.id_prod_bus.Name = "id_prod_bus"
        Me.id_prod_bus.Size = New System.Drawing.Size(423, 32)
        Me.id_prod_bus.TabIndex = 0
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.subtot_prod_bus)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.buscar_producto)
        Me.GroupBox1.Controls.Add(Me.exis_prod_bus)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.precio_prod_bus)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.eliminar_carrito)
        Me.GroupBox1.Controls.Add(Me.AGREGAR_CARRITO)
        Me.GroupBox1.Controls.Add(Me.nom_prod_bus)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cant_prod_bus)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.id_prod_bus)
        Me.GroupBox1.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1238, 272)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "VENTAS"
        '
        'subtot_prod_bus
        '
        Me.subtot_prod_bus.AutoSize = True
        Me.subtot_prod_bus.Location = New System.Drawing.Point(985, 229)
        Me.subtot_prod_bus.Name = "subtot_prod_bus"
        Me.subtot_prod_bus.Size = New System.Drawing.Size(166, 24)
        Me.subtot_prod_bus.TabIndex = 14
        Me.subtot_prod_bus.Text = "--------------------------"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label17.Location = New System.Drawing.Point(1003, 175)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(91, 24)
        Me.Label17.TabIndex = 13
        Me.Label17.Text = "Subtotal:"
        '
        'buscar_producto
        '
        Me.buscar_producto.Image = Global.Farmacia.My.Resources.Resources.buscar
        Me.buscar_producto.Location = New System.Drawing.Point(664, 60)
        Me.buscar_producto.Name = "buscar_producto"
        Me.buscar_producto.Size = New System.Drawing.Size(40, 33)
        Me.buscar_producto.TabIndex = 12
        Me.buscar_producto.UseVisualStyleBackColor = True
        '
        'exis_prod_bus
        '
        Me.exis_prod_bus.AutoSize = True
        Me.exis_prod_bus.Location = New System.Drawing.Point(985, 93)
        Me.exis_prod_bus.Name = "exis_prod_bus"
        Me.exis_prod_bus.Size = New System.Drawing.Size(166, 24)
        Me.exis_prod_bus.TabIndex = 11
        Me.exis_prod_bus.Text = "--------------------------"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label14.Location = New System.Drawing.Point(1003, 39)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(117, 24)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "Existencias:"
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
        Me.eliminar_carrito.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.eliminar_carrito.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.eliminar_carrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.eliminar_carrito.Image = Global.Farmacia.My.Resources.Resources.eliminar_Carrito
        Me.eliminar_carrito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.eliminar_carrito.Location = New System.Drawing.Point(252, 214)
        Me.eliminar_carrito.Name = "eliminar_carrito"
        Me.eliminar_carrito.Size = New System.Drawing.Size(205, 39)
        Me.eliminar_carrito.TabIndex = 7
        Me.eliminar_carrito.Text = "Eliminar del carrito"
        Me.eliminar_carrito.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.eliminar_carrito.UseVisualStyleBackColor = False
        '
        'AGREGAR_CARRITO
        '
        Me.AGREGAR_CARRITO.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.AGREGAR_CARRITO.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.AGREGAR_CARRITO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AGREGAR_CARRITO.Image = Global.Farmacia.My.Resources.Resources.anadir_al_carrito
        Me.AGREGAR_CARRITO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AGREGAR_CARRITO.Location = New System.Drawing.Point(31, 214)
        Me.AGREGAR_CARRITO.Name = "AGREGAR_CARRITO"
        Me.AGREGAR_CARRITO.Size = New System.Drawing.Size(195, 39)
        Me.AGREGAR_CARRITO.TabIndex = 6
        Me.AGREGAR_CARRITO.Text = "Agregar al carrito"
        Me.AGREGAR_CARRITO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AGREGAR_CARRITO.UseVisualStyleBackColor = False
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
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Roboto Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Roboto Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(12, 308)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(1238, 354)
        Me.DataGridView1.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.exis_prod_busqueda)
        Me.GroupBox2.Controls.Add(Me.precio_prod_busqueda)
        Me.GroupBox2.Controls.Add(Me.nom_prod_busqueda)
        Me.GroupBox2.Controls.Add(Me.buscar_producto_busqueda)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.id_prod_busqueda)
        Me.GroupBox2.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.Location = New System.Drawing.Point(1286, 139)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(622, 568)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "VERIFICADOR DE PRECIOS"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label20.Location = New System.Drawing.Point(31, 447)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(101, 24)
        Me.Label20.TabIndex = 12
        Me.Label20.Text = "Existencia:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label19.Location = New System.Drawing.Point(31, 315)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(68, 24)
        Me.Label19.TabIndex = 11
        Me.Label19.Text = "Precio:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(31, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 24)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Producto:"
        '
        'exis_prod_busqueda
        '
        Me.exis_prod_busqueda.AutoSize = True
        Me.exis_prod_busqueda.Font = New System.Drawing.Font("Roboto", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.exis_prod_busqueda.Location = New System.Drawing.Point(251, 496)
        Me.exis_prod_busqueda.Name = "exis_prod_busqueda"
        Me.exis_prod_busqueda.Size = New System.Drawing.Size(0, 37)
        Me.exis_prod_busqueda.TabIndex = 9
        '
        'precio_prod_busqueda
        '
        Me.precio_prod_busqueda.AutoSize = True
        Me.precio_prod_busqueda.Font = New System.Drawing.Font("Roboto", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.precio_prod_busqueda.Location = New System.Drawing.Point(251, 368)
        Me.precio_prod_busqueda.Name = "precio_prod_busqueda"
        Me.precio_prod_busqueda.Size = New System.Drawing.Size(0, 37)
        Me.precio_prod_busqueda.TabIndex = 8
        '
        'nom_prod_busqueda
        '
        Me.nom_prod_busqueda.AutoSize = True
        Me.nom_prod_busqueda.Font = New System.Drawing.Font("Roboto", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.nom_prod_busqueda.Location = New System.Drawing.Point(251, 248)
        Me.nom_prod_busqueda.Name = "nom_prod_busqueda"
        Me.nom_prod_busqueda.Size = New System.Drawing.Size(0, 37)
        Me.nom_prod_busqueda.TabIndex = 7
        '
        'buscar_producto_busqueda
        '
        Me.buscar_producto_busqueda.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.buscar_producto_busqueda.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.buscar_producto_busqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buscar_producto_busqueda.Location = New System.Drawing.Point(31, 117)
        Me.buscar_producto_busqueda.Name = "buscar_producto_busqueda"
        Me.buscar_producto_busqueda.Size = New System.Drawing.Size(565, 39)
        Me.buscar_producto_busqueda.TabIndex = 6
        Me.buscar_producto_busqueda.Text = "Verificar precio"
        Me.buscar_producto_busqueda.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(31, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(194, 24)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Código del producto:"
        '
        'id_prod_busqueda
        '
        Me.id_prod_busqueda.Location = New System.Drawing.Point(235, 61)
        Me.id_prod_busqueda.Name = "id_prod_busqueda"
        Me.id_prod_busqueda.Size = New System.Drawing.Size(361, 32)
        Me.id_prod_busqueda.TabIndex = 0
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Roboto", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button5.Image = Global.Farmacia.My.Resources.Resources.realizar_compra1
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button5.Location = New System.Drawing.Point(791, 729)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(217, 153)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "REALIZAR VENTA"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Roboto", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button6.Image = Global.Farmacia.My.Resources.Resources.cancelarventa
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button6.Location = New System.Drawing.Point(1033, 729)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(217, 153)
        Me.Button6.TabIndex = 10
        Me.Button6.Text = "CANCELAR VENTA"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'FECHA_LBL
        '
        Me.FECHA_LBL.AutoSize = True
        Me.FECHA_LBL.Font = New System.Drawing.Font("Roboto Light", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FECHA_LBL.Location = New System.Drawing.Point(12, 927)
        Me.FECHA_LBL.Name = "FECHA_LBL"
        Me.FECHA_LBL.Size = New System.Drawing.Size(102, 34)
        Me.FECHA_LBL.TabIndex = 11
        Me.FECHA_LBL.Text = "FECHA"
        '
        'atiende
        '
        Me.atiende.AutoSize = True
        Me.atiende.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.atiende.Location = New System.Drawing.Point(1442, 57)
        Me.atiende.Name = "atiende"
        Me.atiende.Size = New System.Drawing.Size(0, 48)
        Me.atiende.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(1332, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 24)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Le atiende:"
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
        Me.GroupBox3.Location = New System.Drawing.Point(12, 683)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(742, 241)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "AGREGAR CLIENTE"
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Location = New System.Drawing.Point(16, 156)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(226, 48)
        Me.Button7.TabIndex = 5
        Me.Button7.Text = "ESCOGER CLIENTE"
        Me.Button7.UseVisualStyleBackColor = False
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
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Roboto Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Roboto Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView2.Location = New System.Drawing.Point(267, 85)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 29
        Me.DataGridView2.Size = New System.Drawing.Size(451, 137)
        Me.DataGridView2.TabIndex = 2
        '
        'buscar_cliente
        '
        Me.buscar_cliente.Location = New System.Drawing.Point(414, 35)
        Me.buscar_cliente.Name = "buscar_cliente"
        Me.buscar_cliente.Size = New System.Drawing.Size(239, 32)
        Me.buscar_cliente.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(319, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 24)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "BUSCAR:"
        '
        'Tot_venta
        '
        Me.Tot_venta.AutoSize = True
        Me.Tot_venta.Font = New System.Drawing.Font("Roboto", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Tot_venta.Location = New System.Drawing.Point(1537, 853)
        Me.Tot_venta.Name = "Tot_venta"
        Me.Tot_venta.Size = New System.Drawing.Size(0, 34)
        Me.Tot_venta.TabIndex = 14
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Roboto", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label15.Location = New System.Drawing.Point(1521, 741)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(179, 57)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "TOTAL:"
        '
        'ID_VENTA
        '
        Me.ID_VENTA.AutoSize = True
        Me.ID_VENTA.Font = New System.Drawing.Font("Roboto Light", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ID_VENTA.Location = New System.Drawing.Point(464, 927)
        Me.ID_VENTA.Name = "ID_VENTA"
        Me.ID_VENTA.Size = New System.Drawing.Size(133, 34)
        Me.ID_VENTA.TabIndex = 15
        Me.ID_VENTA.Text = "ID VENTA"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Roboto Light", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label18.Location = New System.Drawing.Point(362, 927)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(107, 34)
        Me.Label18.TabIndex = 16
        Me.Label18.Text = "VENTA:"
        '
        'FormVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1920, 970)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.ID_VENTA)
        Me.Controls.Add(Me.Tot_venta)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.atiende)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.FECHA_LBL)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormVentas"
        Me.Text = "FormVentas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents id_prod_bus As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents exis_prod_busqueda As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents eliminar_carrito As Button
    Friend WithEvents AGREGAR_CARRITO As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents buscar_producto_busqueda As Button
    Friend WithEvents FECHA_LBL As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Tot_venta As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents id_prod_busqueda As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents atiende As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents buscar_cliente As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents buscar_producto As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents subtot_prod_bus As Label
    Friend WithEvents exis_prod_bus As Label
    Friend WithEvents precio_prod_bus As Label
    Friend WithEvents nom_prod_bus As Label
    Friend WithEvents cant_prod_bus As TextBox
    Friend WithEvents ID_VENTA As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents precio_prod_busqueda As Label
    Friend WithEvents nom_prod_busqueda As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cliente_atendio As Label
End Class
