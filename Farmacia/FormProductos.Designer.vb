<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProductos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.id_prod = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.desc_prod = New System.Windows.Forms.TextBox()
        Me.categ_prod = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.exis_prod = New System.Windows.Forms.TextBox()
        Me.precio_venta_prod = New System.Windows.Forms.TextBox()
        Me.precio_compra_prod = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Gb1 = New System.Windows.Forms.GroupBox()
        Me.modificar = New System.Windows.Forms.Button()
        Me.nuevo = New System.Windows.Forms.Button()
        Me.guardar = New System.Windows.Forms.Button()
        Me.eliminar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.todo_busqueda_categoria = New System.Windows.Forms.RadioButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.busqueda_categ = New System.Windows.Forms.TextBox()
        Me.desc_categ = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.modificar_categ = New System.Windows.Forms.Button()
        Me.nuevo_categ = New System.Windows.Forms.Button()
        Me.guardar_categ = New System.Windows.Forms.Button()
        Me.eliminar_categ = New System.Windows.Forms.Button()
        Me.id_categ = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.todo_busqueda = New System.Windows.Forms.RadioButton()
        Me.id_bus_prod = New System.Windows.Forms.RadioButton()
        Me.busqueda = New System.Windows.Forms.TextBox()
        Me.nom_bus_prod = New System.Windows.Forms.RadioButton()
        Me.Gb1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(29, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID del Producto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(29, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(212, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Categoría del Producto:"
        '
        'id_prod
        '
        Me.id_prod.Enabled = False
        Me.id_prod.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.id_prod.Location = New System.Drawing.Point(29, 99)
        Me.id_prod.Name = "id_prod"
        Me.id_prod.Size = New System.Drawing.Size(135, 32)
        Me.id_prod.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(29, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(229, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Descripción del Producto:"
        '
        'desc_prod
        '
        Me.desc_prod.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.desc_prod.Location = New System.Drawing.Point(29, 234)
        Me.desc_prod.Multiline = True
        Me.desc_prod.Name = "desc_prod"
        Me.desc_prod.Size = New System.Drawing.Size(390, 100)
        Me.desc_prod.TabIndex = 6
        '
        'categ_prod
        '
        Me.categ_prod.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.categ_prod.FormattingEnabled = True
        Me.categ_prod.Items.AddRange(New Object() {"Inyecciones"})
        Me.categ_prod.Location = New System.Drawing.Point(29, 167)
        Me.categ_prod.Name = "categ_prod"
        Me.categ_prod.Size = New System.Drawing.Size(390, 32)
        Me.categ_prod.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(29, 349)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 24)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Existencias:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(29, 423)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(147, 24)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Precio de venta:"
        '
        'exis_prod
        '
        Me.exis_prod.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.exis_prod.Location = New System.Drawing.Point(29, 374)
        Me.exis_prod.Name = "exis_prod"
        Me.exis_prod.Size = New System.Drawing.Size(390, 32)
        Me.exis_prod.TabIndex = 10
        '
        'precio_venta_prod
        '
        Me.precio_venta_prod.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.precio_venta_prod.Location = New System.Drawing.Point(29, 448)
        Me.precio_venta_prod.Name = "precio_venta_prod"
        Me.precio_venta_prod.Size = New System.Drawing.Size(390, 32)
        Me.precio_venta_prod.TabIndex = 11
        '
        'precio_compra_prod
        '
        Me.precio_compra_prod.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.precio_compra_prod.Location = New System.Drawing.Point(29, 520)
        Me.precio_compra_prod.Name = "precio_compra_prod"
        Me.precio_compra_prod.Size = New System.Drawing.Size(390, 32)
        Me.precio_compra_prod.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(29, 495)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(170, 24)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Precio de Compra:"
        '
        'Gb1
        '
        Me.Gb1.BackColor = System.Drawing.Color.White
        Me.Gb1.Controls.Add(Me.modificar)
        Me.Gb1.Controls.Add(Me.nuevo)
        Me.Gb1.Controls.Add(Me.guardar)
        Me.Gb1.Controls.Add(Me.eliminar)
        Me.Gb1.Controls.Add(Me.id_prod)
        Me.Gb1.Controls.Add(Me.Label6)
        Me.Gb1.Controls.Add(Me.Label1)
        Me.Gb1.Controls.Add(Me.precio_compra_prod)
        Me.Gb1.Controls.Add(Me.Label2)
        Me.Gb1.Controls.Add(Me.precio_venta_prod)
        Me.Gb1.Controls.Add(Me.exis_prod)
        Me.Gb1.Controls.Add(Me.Label3)
        Me.Gb1.Controls.Add(Me.Label5)
        Me.Gb1.Controls.Add(Me.desc_prod)
        Me.Gb1.Controls.Add(Me.Label4)
        Me.Gb1.Controls.Add(Me.categ_prod)
        Me.Gb1.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Gb1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Gb1.Location = New System.Drawing.Point(12, 12)
        Me.Gb1.Name = "Gb1"
        Me.Gb1.Size = New System.Drawing.Size(497, 946)
        Me.Gb1.TabIndex = 14
        Me.Gb1.TabStop = False
        Me.Gb1.Text = "PRODUCTOS"
        '
        'modificar
        '
        Me.modificar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.modificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.modificar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.modificar.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.modificar.Image = Global.Farmacia.My.Resources.Resources.modificar1
        Me.modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.modificar.Location = New System.Drawing.Point(183, 612)
        Me.modificar.Name = "modificar"
        Me.modificar.Size = New System.Drawing.Size(135, 41)
        Me.modificar.TabIndex = 19
        Me.modificar.Text = "Modificar"
        Me.modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.modificar.UseVisualStyleBackColor = False
        '
        'nuevo
        '
        Me.nuevo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.nuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nuevo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nuevo.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.nuevo.Image = Global.Farmacia.My.Resources.Resources.agregar
        Me.nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.nuevo.Location = New System.Drawing.Point(226, 91)
        Me.nuevo.Name = "nuevo"
        Me.nuevo.Size = New System.Drawing.Size(193, 41)
        Me.nuevo.TabIndex = 33
        Me.nuevo.Text = "Nuevo Producto"
        Me.nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.nuevo.UseVisualStyleBackColor = False
        '
        'guardar
        '
        Me.guardar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.guardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.guardar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.guardar.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.guardar.Image = Global.Farmacia.My.Resources.Resources.GUARDAR1
        Me.guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.guardar.Location = New System.Drawing.Point(19, 612)
        Me.guardar.Name = "guardar"
        Me.guardar.Size = New System.Drawing.Size(135, 41)
        Me.guardar.TabIndex = 17
        Me.guardar.Text = "Guardar"
        Me.guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.guardar.UseVisualStyleBackColor = False
        '
        'eliminar
        '
        Me.eliminar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.eliminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.eliminar.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.eliminar.Image = Global.Farmacia.My.Resources.Resources.eliminar1
        Me.eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.eliminar.Location = New System.Drawing.Point(343, 612)
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Size = New System.Drawing.Size(135, 41)
        Me.eliminar.TabIndex = 18
        Me.eliminar.Text = "Eliminar"
        Me.eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.eliminar.UseVisualStyleBackColor = False
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
        Me.DataGridView1.Location = New System.Drawing.Point(528, 198)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(803, 748)
        Me.DataGridView1.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.todo_busqueda_categoria)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.busqueda_categ)
        Me.GroupBox1.Controls.Add(Me.desc_categ)
        Me.GroupBox1.Controls.Add(Me.DataGridView2)
        Me.GroupBox1.Controls.Add(Me.modificar_categ)
        Me.GroupBox1.Controls.Add(Me.nuevo_categ)
        Me.GroupBox1.Controls.Add(Me.guardar_categ)
        Me.GroupBox1.Controls.Add(Me.eliminar_categ)
        Me.GroupBox1.Controls.Add(Me.id_categ)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(1351, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(557, 946)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CATEGORÍAS DE PRODUCTO"
        '
        'todo_busqueda_categoria
        '
        Me.todo_busqueda_categoria.AutoSize = True
        Me.todo_busqueda_categoria.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.todo_busqueda_categoria.Location = New System.Drawing.Point(29, 419)
        Me.todo_busqueda_categoria.Name = "todo_busqueda_categoria"
        Me.todo_busqueda_categoria.Size = New System.Drawing.Size(75, 28)
        Me.todo_busqueda_categoria.TabIndex = 50
        Me.todo_busqueda_categoria.Text = "Todo"
        Me.todo_busqueda_categoria.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Roboto Light", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label12.Location = New System.Drawing.Point(29, 344)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(273, 34)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "BUSCAR CATEGORÍA"
        '
        'busqueda_categ
        '
        Me.busqueda_categ.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.busqueda_categ.Location = New System.Drawing.Point(29, 381)
        Me.busqueda_categ.Name = "busqueda_categ"
        Me.busqueda_categ.Size = New System.Drawing.Size(501, 32)
        Me.busqueda_categ.TabIndex = 48
        '
        'desc_categ
        '
        Me.desc_categ.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.desc_categ.Location = New System.Drawing.Point(29, 171)
        Me.desc_categ.Name = "desc_categ"
        Me.desc_categ.Size = New System.Drawing.Size(390, 32)
        Me.desc_categ.TabIndex = 34
        '
        'DataGridView2
        '
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Roboto Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Roboto Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView2.Location = New System.Drawing.Point(29, 448)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 29
        Me.DataGridView2.Size = New System.Drawing.Size(501, 284)
        Me.DataGridView2.TabIndex = 34
        '
        'modificar_categ
        '
        Me.modificar_categ.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.modificar_categ.Cursor = System.Windows.Forms.Cursors.Hand
        Me.modificar_categ.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.modificar_categ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.modificar_categ.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.modificar_categ.Image = Global.Farmacia.My.Resources.Resources.modificar
        Me.modificar_categ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.modificar_categ.Location = New System.Drawing.Point(216, 229)
        Me.modificar_categ.Name = "modificar_categ"
        Me.modificar_categ.Size = New System.Drawing.Size(135, 41)
        Me.modificar_categ.TabIndex = 19
        Me.modificar_categ.Text = "Modificar"
        Me.modificar_categ.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.modificar_categ.UseVisualStyleBackColor = False
        '
        'nuevo_categ
        '
        Me.nuevo_categ.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.nuevo_categ.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nuevo_categ.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.nuevo_categ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nuevo_categ.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.nuevo_categ.Image = Global.Farmacia.My.Resources.Resources.agregar
        Me.nuevo_categ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.nuevo_categ.Location = New System.Drawing.Point(226, 91)
        Me.nuevo_categ.Name = "nuevo_categ"
        Me.nuevo_categ.Size = New System.Drawing.Size(193, 41)
        Me.nuevo_categ.TabIndex = 33
        Me.nuevo_categ.Text = "Nueva categoría"
        Me.nuevo_categ.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.nuevo_categ.UseVisualStyleBackColor = False
        '
        'guardar_categ
        '
        Me.guardar_categ.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.guardar_categ.Cursor = System.Windows.Forms.Cursors.Hand
        Me.guardar_categ.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.guardar_categ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.guardar_categ.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.guardar_categ.Image = Global.Farmacia.My.Resources.Resources.GUARDAR
        Me.guardar_categ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.guardar_categ.Location = New System.Drawing.Point(29, 229)
        Me.guardar_categ.Name = "guardar_categ"
        Me.guardar_categ.Size = New System.Drawing.Size(135, 41)
        Me.guardar_categ.TabIndex = 17
        Me.guardar_categ.Text = "Guardar"
        Me.guardar_categ.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.guardar_categ.UseVisualStyleBackColor = False
        '
        'eliminar_categ
        '
        Me.eliminar_categ.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.eliminar_categ.Cursor = System.Windows.Forms.Cursors.Hand
        Me.eliminar_categ.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.eliminar_categ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.eliminar_categ.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.eliminar_categ.Image = Global.Farmacia.My.Resources.Resources.eliminar
        Me.eliminar_categ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.eliminar_categ.Location = New System.Drawing.Point(395, 229)
        Me.eliminar_categ.Name = "eliminar_categ"
        Me.eliminar_categ.Size = New System.Drawing.Size(135, 41)
        Me.eliminar_categ.TabIndex = 18
        Me.eliminar_categ.Text = "Eliminar"
        Me.eliminar_categ.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.eliminar_categ.UseVisualStyleBackColor = False
        '
        'id_categ
        '
        Me.id_categ.Enabled = False
        Me.id_categ.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.id_categ.Location = New System.Drawing.Point(29, 99)
        Me.id_categ.Name = "id_categ"
        Me.id_categ.Size = New System.Drawing.Size(135, 32)
        Me.id_categ.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(29, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(147, 24)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "ID de Categoría:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(29, 142)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(197, 24)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Nombre de categoría:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Roboto Light", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label13.Location = New System.Drawing.Point(528, 26)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(271, 34)
        Me.Label13.TabIndex = 52
        Me.Label13.Text = "BUSCAR PRODUCTO"
        '
        'todo_busqueda
        '
        Me.todo_busqueda.AutoSize = True
        Me.todo_busqueda.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.todo_busqueda.Location = New System.Drawing.Point(528, 141)
        Me.todo_busqueda.Name = "todo_busqueda"
        Me.todo_busqueda.Size = New System.Drawing.Size(75, 28)
        Me.todo_busqueda.TabIndex = 51
        Me.todo_busqueda.Text = "Todo"
        Me.todo_busqueda.UseVisualStyleBackColor = True
        '
        'id_bus_prod
        '
        Me.id_bus_prod.AutoSize = True
        Me.id_bus_prod.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.id_bus_prod.Location = New System.Drawing.Point(620, 141)
        Me.id_bus_prod.Name = "id_bus_prod"
        Me.id_bus_prod.Size = New System.Drawing.Size(196, 28)
        Me.id_bus_prod.TabIndex = 50
        Me.id_bus_prod.Text = "Clave del producto:"
        Me.id_bus_prod.UseVisualStyleBackColor = True
        '
        'busqueda
        '
        Me.busqueda.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.busqueda.Location = New System.Drawing.Point(528, 83)
        Me.busqueda.Name = "busqueda"
        Me.busqueda.Size = New System.Drawing.Size(561, 32)
        Me.busqueda.TabIndex = 49
        '
        'nom_bus_prod
        '
        Me.nom_bus_prod.AutoSize = True
        Me.nom_bus_prod.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.nom_bus_prod.Location = New System.Drawing.Point(822, 141)
        Me.nom_bus_prod.Name = "nom_bus_prod"
        Me.nom_bus_prod.Size = New System.Drawing.Size(219, 28)
        Me.nom_bus_prod.TabIndex = 53
        Me.nom_bus_prod.Text = "Nombre del producto:"
        Me.nom_bus_prod.UseVisualStyleBackColor = True
        '
        'FormProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1920, 970)
        Me.Controls.Add(Me.nom_bus_prod)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.todo_busqueda)
        Me.Controls.Add(Me.id_bus_prod)
        Me.Controls.Add(Me.busqueda)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Gb1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "-"
        Me.Gb1.ResumeLayout(False)
        Me.Gb1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents id_prod As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents desc_prod As TextBox
    Friend WithEvents categ_prod As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents exis_prod As TextBox
    Friend WithEvents precio_venta_prod As TextBox
    Friend WithEvents precio_compra_prod As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Gb1 As GroupBox
    Friend WithEvents modificar As Button
    Friend WithEvents eliminar As Button
    Friend WithEvents guardar As Button
    Friend WithEvents nuevo As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents id_categ As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents desc_categ As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents modificar_categ As Button
    Friend WithEvents nuevo_categ As Button
    Friend WithEvents guardar_categ As Button
    Friend WithEvents eliminar_categ As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents busqueda_categ As TextBox
    Friend WithEvents todo_busqueda_categoria As RadioButton
    Friend WithEvents Label13 As Label
    Friend WithEvents todo_busqueda As RadioButton
    Friend WithEvents id_bus_prod As RadioButton
    Friend WithEvents busqueda As TextBox
    Friend WithEvents nom_bus_prod As RadioButton
End Class
