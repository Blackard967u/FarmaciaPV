<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormProveedores))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Gb1 = New System.Windows.Forms.GroupBox()
        Me.tel_prov = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ape_prov = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.nom_prov = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.emp_prov = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Modificar = New System.Windows.Forms.Button()
        Me.agregar = New System.Windows.Forms.Button()
        Me.guardar = New System.Windows.Forms.Button()
        Me.eliminar = New System.Windows.Forms.Button()
        Me.id_prov = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dir_prov = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.todo_busqueda = New System.Windows.Forms.RadioButton()
        Me.nom_prov_bus = New System.Windows.Forms.RadioButton()
        Me.busqueda = New System.Windows.Forms.TextBox()
        Me.nom_emp_bus = New System.Windows.Forms.RadioButton()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Gb1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Gb1
        '
        Me.Gb1.BackColor = System.Drawing.Color.White
        Me.Gb1.Controls.Add(Me.tel_prov)
        Me.Gb1.Controls.Add(Me.Label5)
        Me.Gb1.Controls.Add(Me.ape_prov)
        Me.Gb1.Controls.Add(Me.Label8)
        Me.Gb1.Controls.Add(Me.nom_prov)
        Me.Gb1.Controls.Add(Me.Label7)
        Me.Gb1.Controls.Add(Me.emp_prov)
        Me.Gb1.Controls.Add(Me.Label2)
        Me.Gb1.Controls.Add(Me.Modificar)
        Me.Gb1.Controls.Add(Me.agregar)
        Me.Gb1.Controls.Add(Me.guardar)
        Me.Gb1.Controls.Add(Me.eliminar)
        Me.Gb1.Controls.Add(Me.id_prov)
        Me.Gb1.Controls.Add(Me.Label1)
        Me.Gb1.Controls.Add(Me.Label3)
        Me.Gb1.Controls.Add(Me.dir_prov)
        Me.Gb1.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Gb1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Gb1.Location = New System.Drawing.Point(12, 12)
        Me.Gb1.Name = "Gb1"
        Me.Gb1.Size = New System.Drawing.Size(523, 946)
        Me.Gb1.TabIndex = 15
        Me.Gb1.TabStop = False
        Me.Gb1.Text = "PROVEEDORES"
        '
        'tel_prov
        '
        Me.tel_prov.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tel_prov.Location = New System.Drawing.Point(39, 523)
        Me.tel_prov.Name = "tel_prov"
        Me.tel_prov.Size = New System.Drawing.Size(390, 32)
        Me.tel_prov.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(39, 498)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(196, 24)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Teléfono de contacto:"
        '
        'ape_prov
        '
        Me.ape_prov.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ape_prov.Location = New System.Drawing.Point(39, 303)
        Me.ape_prov.Name = "ape_prov"
        Me.ape_prov.Size = New System.Drawing.Size(390, 32)
        Me.ape_prov.TabIndex = 41
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(39, 278)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(205, 24)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Apellido del Proveedor:"
        '
        'nom_prov
        '
        Me.nom_prov.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.nom_prov.Location = New System.Drawing.Point(39, 235)
        Me.nom_prov.Name = "nom_prov"
        Me.nom_prov.Size = New System.Drawing.Size(390, 32)
        Me.nom_prov.TabIndex = 39
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(39, 210)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(209, 24)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Nombre del Proveedor:"
        '
        'emp_prov
        '
        Me.emp_prov.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.emp_prov.Location = New System.Drawing.Point(39, 168)
        Me.emp_prov.Name = "emp_prov"
        Me.emp_prov.Size = New System.Drawing.Size(390, 32)
        Me.emp_prov.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(39, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 24)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Empresa:"
        '
        'Modificar
        '
        Me.Modificar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Modificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Modificar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Modificar.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Modificar.Image = CType(resources.GetObject("Modificar.Image"), System.Drawing.Image)
        Me.Modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Modificar.Location = New System.Drawing.Point(181, 600)
        Me.Modificar.Name = "Modificar"
        Me.Modificar.Size = New System.Drawing.Size(134, 41)
        Me.Modificar.TabIndex = 19
        Me.Modificar.Text = "Modificar"
        Me.Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Modificar.UseVisualStyleBackColor = False
        '
        'agregar
        '
        Me.agregar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.agregar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.agregar.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.agregar.Image = CType(resources.GetObject("agregar.Image"), System.Drawing.Image)
        Me.agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.agregar.Location = New System.Drawing.Point(235, 90)
        Me.agregar.Name = "agregar"
        Me.agregar.Size = New System.Drawing.Size(217, 41)
        Me.agregar.TabIndex = 33
        Me.agregar.Text = "Agregar Proveedor"
        Me.agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.agregar.UseVisualStyleBackColor = False
        '
        'guardar
        '
        Me.guardar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.guardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.guardar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.guardar.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.guardar.Image = CType(resources.GetObject("guardar.Image"), System.Drawing.Image)
        Me.guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.guardar.Location = New System.Drawing.Point(21, 600)
        Me.guardar.Name = "guardar"
        Me.guardar.Size = New System.Drawing.Size(134, 41)
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
        Me.eliminar.Image = CType(resources.GetObject("eliminar.Image"), System.Drawing.Image)
        Me.eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.eliminar.Location = New System.Drawing.Point(346, 600)
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Size = New System.Drawing.Size(134, 41)
        Me.eliminar.TabIndex = 18
        Me.eliminar.Text = "Eliminar"
        Me.eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.eliminar.UseVisualStyleBackColor = False
        '
        'id_prov
        '
        Me.id_prov.Enabled = False
        Me.id_prov.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.id_prov.Location = New System.Drawing.Point(39, 99)
        Me.id_prov.Name = "id_prov"
        Me.id_prov.Size = New System.Drawing.Size(156, 32)
        Me.id_prov.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(39, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID del Proveedor:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(39, 352)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Dirección:"
        '
        'dir_prov
        '
        Me.dir_prov.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dir_prov.Location = New System.Drawing.Point(39, 377)
        Me.dir_prov.Multiline = True
        Me.dir_prov.Name = "dir_prov"
        Me.dir_prov.Size = New System.Drawing.Size(390, 100)
        Me.dir_prov.TabIndex = 6
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
        Me.DataGridView1.Location = New System.Drawing.Point(573, 222)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(1317, 725)
        Me.DataGridView1.TabIndex = 16
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Roboto Light", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label12.Location = New System.Drawing.Point(573, 45)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(285, 34)
        Me.Label12.TabIndex = 47
        Me.Label12.Text = "BUSCAR PROVEEDOR"
        '
        'todo_busqueda
        '
        Me.todo_busqueda.AutoSize = True
        Me.todo_busqueda.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.todo_busqueda.Location = New System.Drawing.Point(573, 160)
        Me.todo_busqueda.Name = "todo_busqueda"
        Me.todo_busqueda.Size = New System.Drawing.Size(75, 28)
        Me.todo_busqueda.TabIndex = 46
        Me.todo_busqueda.Text = "Todo"
        Me.todo_busqueda.UseVisualStyleBackColor = True
        '
        'nom_prov_bus
        '
        Me.nom_prov_bus.AutoSize = True
        Me.nom_prov_bus.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.nom_prov_bus.Location = New System.Drawing.Point(665, 160)
        Me.nom_prov_bus.Name = "nom_prov_bus"
        Me.nom_prov_bus.Size = New System.Drawing.Size(225, 28)
        Me.nom_prov_bus.TabIndex = 45
        Me.nom_prov_bus.Text = "Nombre del proveedor"
        Me.nom_prov_bus.UseVisualStyleBackColor = True
        '
        'busqueda
        '
        Me.busqueda.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.busqueda.Location = New System.Drawing.Point(573, 102)
        Me.busqueda.Name = "busqueda"
        Me.busqueda.Size = New System.Drawing.Size(561, 32)
        Me.busqueda.TabIndex = 43
        '
        'nom_emp_bus
        '
        Me.nom_emp_bus.AutoSize = True
        Me.nom_emp_bus.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.nom_emp_bus.Location = New System.Drawing.Point(904, 162)
        Me.nom_emp_bus.Name = "nom_emp_bus"
        Me.nom_emp_bus.Size = New System.Drawing.Size(230, 28)
        Me.nom_emp_bus.TabIndex = 48
        Me.nom_emp_bus.Text = "Nombre de la empresa"
        Me.nom_emp_bus.UseVisualStyleBackColor = True
        '
        'FormProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1920, 970)
        Me.Controls.Add(Me.nom_emp_bus)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.todo_busqueda)
        Me.Controls.Add(Me.nom_prov_bus)
        Me.Controls.Add(Me.busqueda)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Gb1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormProveedores"
        Me.Text = "FormProveedores"
        Me.Gb1.ResumeLayout(False)
        Me.Gb1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Gb1 As GroupBox
    Friend WithEvents Modificar As Button
    Friend WithEvents agregar As Button
    Friend WithEvents guardar As Button
    Friend WithEvents eliminar As Button
    Friend WithEvents id_prov As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dir_prov As TextBox
    Friend WithEvents emp_prov As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ape_prov As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents nom_prov As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tel_prov As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label12 As Label
    Friend WithEvents todo_busqueda As RadioButton
    Friend WithEvents nom_prov_bus As RadioButton
    Friend WithEvents busqueda As TextBox
    Friend WithEvents nom_emp_bus As RadioButton
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
