<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEmpleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEmpleados))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Gb1 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Guardar = New System.Windows.Forms.Button()
        Me.contras_empleado = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.usuario_empleado = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.salario_empleado = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.nss_empleado = New System.Windows.Forms.TextBox()
        Me.ape_empleado = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.nom_empleado = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.id_empleado = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.email_empleado = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tel_empleado = New System.Windows.Forms.TextBox()
        Me.dir_empleado = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Cargo_empleado = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.busqueda = New System.Windows.Forms.TextBox()
        Me.id_busqueda = New System.Windows.Forms.RadioButton()
        Me.nom_bus = New System.Windows.Forms.RadioButton()
        Me.todo_busqueda = New System.Windows.Forms.RadioButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Gb1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Gb1
        '
        Me.Gb1.BackColor = System.Drawing.Color.White
        Me.Gb1.Controls.Add(Me.Button4)
        Me.Gb1.Controls.Add(Me.Label11)
        Me.Gb1.Controls.Add(Me.Button3)
        Me.Gb1.Controls.Add(Me.Guardar)
        Me.Gb1.Controls.Add(Me.contras_empleado)
        Me.Gb1.Controls.Add(Me.Button2)
        Me.Gb1.Controls.Add(Me.Label10)
        Me.Gb1.Controls.Add(Me.usuario_empleado)
        Me.Gb1.Controls.Add(Me.Label9)
        Me.Gb1.Controls.Add(Me.salario_empleado)
        Me.Gb1.Controls.Add(Me.Label8)
        Me.Gb1.Controls.Add(Me.nss_empleado)
        Me.Gb1.Controls.Add(Me.ape_empleado)
        Me.Gb1.Controls.Add(Me.Label7)
        Me.Gb1.Controls.Add(Me.nom_empleado)
        Me.Gb1.Controls.Add(Me.Label3)
        Me.Gb1.Controls.Add(Me.id_empleado)
        Me.Gb1.Controls.Add(Me.Label6)
        Me.Gb1.Controls.Add(Me.Label1)
        Me.Gb1.Controls.Add(Me.email_empleado)
        Me.Gb1.Controls.Add(Me.Label2)
        Me.Gb1.Controls.Add(Me.Tel_empleado)
        Me.Gb1.Controls.Add(Me.dir_empleado)
        Me.Gb1.Controls.Add(Me.Label5)
        Me.Gb1.Controls.Add(Me.Label4)
        Me.Gb1.Controls.Add(Me.Cargo_empleado)
        Me.Gb1.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Gb1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Gb1.Location = New System.Drawing.Point(1352, 12)
        Me.Gb1.Name = "Gb1"
        Me.Gb1.Size = New System.Drawing.Size(556, 946)
        Me.Gb1.TabIndex = 15
        Me.Gb1.TabStop = False
        Me.Gb1.Text = "EMPLEADOS"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(252, 56)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(195, 44)
        Me.Button4.TabIndex = 31
        Me.Button4.Text = "Nuevo Empleado"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(55, 766)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(115, 24)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Contraseña:"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = Global.Farmacia.My.Resources.Resources.modificar
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(206, 863)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(136, 41)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Modificar"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Guardar
        '
        Me.Guardar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Guardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guardar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Guardar.Image = Global.Farmacia.My.Resources.Resources.GUARDAR
        Me.Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Guardar.Location = New System.Drawing.Point(25, 863)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(137, 41)
        Me.Guardar.TabIndex = 14
        Me.Guardar.Text = "Guardar"
        Me.Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Guardar.UseVisualStyleBackColor = False
        '
        'contras_empleado
        '
        Me.contras_empleado.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.contras_empleado.Location = New System.Drawing.Point(55, 791)
        Me.contras_empleado.Name = "contras_empleado"
        Me.contras_empleado.Size = New System.Drawing.Size(390, 32)
        Me.contras_empleado.TabIndex = 27
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.Farmacia.My.Resources.Resources.eliminar
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(389, 863)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(136, 41)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Eliminar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(55, 703)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 24)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Usuario:"
        '
        'usuario_empleado
        '
        Me.usuario_empleado.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.usuario_empleado.Location = New System.Drawing.Point(55, 728)
        Me.usuario_empleado.Name = "usuario_empleado"
        Me.usuario_empleado.Size = New System.Drawing.Size(390, 32)
        Me.usuario_empleado.TabIndex = 25
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(55, 639)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 24)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Salario:"
        '
        'salario_empleado
        '
        Me.salario_empleado.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.salario_empleado.Location = New System.Drawing.Point(55, 664)
        Me.salario_empleado.Name = "salario_empleado"
        Me.salario_empleado.Size = New System.Drawing.Size(390, 32)
        Me.salario_empleado.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(57, 573)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(317, 24)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Número de Seguridad Social (NSS):"
        '
        'nss_empleado
        '
        Me.nss_empleado.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.nss_empleado.Location = New System.Drawing.Point(57, 598)
        Me.nss_empleado.Name = "nss_empleado"
        Me.nss_empleado.Size = New System.Drawing.Size(390, 32)
        Me.nss_empleado.TabIndex = 21
        '
        'ape_empleado
        '
        Me.ape_empleado.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ape_empleado.Location = New System.Drawing.Point(55, 274)
        Me.ape_empleado.Name = "ape_empleado"
        Me.ape_empleado.Size = New System.Drawing.Size(390, 32)
        Me.ape_empleado.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(55, 249)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(212, 24)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Apellidos del empleado:"
        '
        'nom_empleado
        '
        Me.nom_empleado.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.nom_empleado.Location = New System.Drawing.Point(55, 198)
        Me.nom_empleado.Name = "nom_empleado"
        Me.nom_empleado.Size = New System.Drawing.Size(390, 32)
        Me.nom_empleado.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(55, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(206, 24)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Nombre del empleado:"
        '
        'id_empleado
        '
        Me.id_empleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.id_empleado.Enabled = False
        Me.id_empleado.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.id_empleado.Location = New System.Drawing.Point(57, 68)
        Me.id_empleado.Name = "id_empleado"
        Me.id_empleado.Size = New System.Drawing.Size(152, 32)
        Me.id_empleado.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(55, 504)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(173, 24)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Correo Electrónico:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(55, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID del Empleado:"
        '
        'email_empleado
        '
        Me.email_empleado.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.email_empleado.Location = New System.Drawing.Point(55, 529)
        Me.email_empleado.Name = "email_empleado"
        Me.email_empleado.Size = New System.Drawing.Size(390, 32)
        Me.email_empleado.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(55, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cargo del Empleado:"
        '
        'Tel_empleado
        '
        Me.Tel_empleado.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Tel_empleado.Location = New System.Drawing.Point(55, 458)
        Me.Tel_empleado.Name = "Tel_empleado"
        Me.Tel_empleado.Size = New System.Drawing.Size(390, 32)
        Me.Tel_empleado.TabIndex = 11
        '
        'dir_empleado
        '
        Me.dir_empleado.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dir_empleado.Location = New System.Drawing.Point(55, 343)
        Me.dir_empleado.Multiline = True
        Me.dir_empleado.Name = "dir_empleado"
        Me.dir_empleado.Size = New System.Drawing.Size(390, 72)
        Me.dir_empleado.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(55, 433)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(196, 24)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Teléfono de contacto:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(55, 318)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 24)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Dirección:"
        '
        'Cargo_empleado
        '
        Me.Cargo_empleado.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Cargo_empleado.FormattingEnabled = True
        Me.Cargo_empleado.Items.AddRange(New Object() {"Dueño", "Gerente", "Empleado"})
        Me.Cargo_empleado.Location = New System.Drawing.Point(55, 131)
        Me.Cargo_empleado.Name = "Cargo_empleado"
        Me.Cargo_empleado.Size = New System.Drawing.Size(390, 32)
        Me.Cargo_empleado.TabIndex = 7
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
        Me.DataGridView1.Location = New System.Drawing.Point(23, 185)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(1297, 760)
        Me.DataGridView1.TabIndex = 37
        '
        'busqueda
        '
        Me.busqueda.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.busqueda.Location = New System.Drawing.Point(23, 79)
        Me.busqueda.Name = "busqueda"
        Me.busqueda.Size = New System.Drawing.Size(561, 32)
        Me.busqueda.TabIndex = 38
        '
        'id_busqueda
        '
        Me.id_busqueda.AutoSize = True
        Me.id_busqueda.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.id_busqueda.Location = New System.Drawing.Point(128, 138)
        Me.id_busqueda.Name = "id_busqueda"
        Me.id_busqueda.Size = New System.Drawing.Size(49, 28)
        Me.id_busqueda.TabIndex = 39
        Me.id_busqueda.Text = "ID"
        Me.id_busqueda.UseVisualStyleBackColor = True
        '
        'nom_bus
        '
        Me.nom_bus.AutoSize = True
        Me.nom_bus.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.nom_bus.Location = New System.Drawing.Point(215, 138)
        Me.nom_bus.Name = "nom_bus"
        Me.nom_bus.Size = New System.Drawing.Size(112, 28)
        Me.nom_bus.TabIndex = 40
        Me.nom_bus.Text = "Nombres"
        Me.nom_bus.UseVisualStyleBackColor = True
        '
        'todo_busqueda
        '
        Me.todo_busqueda.AutoSize = True
        Me.todo_busqueda.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.todo_busqueda.Location = New System.Drawing.Point(23, 137)
        Me.todo_busqueda.Name = "todo_busqueda"
        Me.todo_busqueda.Size = New System.Drawing.Size(75, 28)
        Me.todo_busqueda.TabIndex = 41
        Me.todo_busqueda.Text = "Todo"
        Me.todo_busqueda.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Roboto Light", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label12.Location = New System.Drawing.Point(23, 30)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(269, 34)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "BUSCAR EMPLEADO"
        '
        'FormEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1920, 970)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.todo_busqueda)
        Me.Controls.Add(Me.nom_bus)
        Me.Controls.Add(Me.id_busqueda)
        Me.Controls.Add(Me.busqueda)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Gb1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormEmpleados"
        Me.Text = "FormEmpleados"
        Me.Gb1.ResumeLayout(False)
        Me.Gb1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Gb1 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Guardar As Button
    Friend WithEvents id_empleado As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents email_empleado As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Tel_empleado As TextBox
    Friend WithEvents dir_empleado As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Cargo_empleado As ComboBox
    Friend WithEvents ape_empleado As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents nom_empleado As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents salario_empleado As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents nss_empleado As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents contras_empleado As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents usuario_empleado As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents busqueda As TextBox
    Friend WithEvents id_busqueda As RadioButton
    Friend WithEvents nom_bus As RadioButton
    Friend WithEvents todo_busqueda As RadioButton
    Friend WithEvents Label12 As Label
End Class
