<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInventario
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.nom_bus_prod = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.todo_busqueda = New System.Windows.Forms.RadioButton()
        Me.id_bus_prod = New System.Windows.Forms.RadioButton()
        Me.busqueda = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Roboto Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(34, 259)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(1841, 674)
        Me.DataGridView1.TabIndex = 0
        '
        'nom_bus_prod
        '
        Me.nom_bus_prod.AutoSize = True
        Me.nom_bus_prod.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.nom_bus_prod.Location = New System.Drawing.Point(334, 176)
        Me.nom_bus_prod.Name = "nom_bus_prod"
        Me.nom_bus_prod.Size = New System.Drawing.Size(219, 28)
        Me.nom_bus_prod.TabIndex = 58
        Me.nom_bus_prod.Text = "Nombre del producto:"
        Me.nom_bus_prod.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Roboto Light", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label13.Location = New System.Drawing.Point(40, 61)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(271, 34)
        Me.Label13.TabIndex = 57
        Me.Label13.Text = "BUSCAR PRODUCTO"
        '
        'todo_busqueda
        '
        Me.todo_busqueda.AutoSize = True
        Me.todo_busqueda.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.todo_busqueda.Location = New System.Drawing.Point(40, 176)
        Me.todo_busqueda.Name = "todo_busqueda"
        Me.todo_busqueda.Size = New System.Drawing.Size(75, 28)
        Me.todo_busqueda.TabIndex = 56
        Me.todo_busqueda.Text = "Todo"
        Me.todo_busqueda.UseVisualStyleBackColor = True
        '
        'id_bus_prod
        '
        Me.id_bus_prod.AutoSize = True
        Me.id_bus_prod.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.id_bus_prod.Location = New System.Drawing.Point(132, 176)
        Me.id_bus_prod.Name = "id_bus_prod"
        Me.id_bus_prod.Size = New System.Drawing.Size(196, 28)
        Me.id_bus_prod.TabIndex = 55
        Me.id_bus_prod.Text = "Clave del producto:"
        Me.id_bus_prod.UseVisualStyleBackColor = True
        '
        'busqueda
        '
        Me.busqueda.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.busqueda.Location = New System.Drawing.Point(40, 118)
        Me.busqueda.Name = "busqueda"
        Me.busqueda.Size = New System.Drawing.Size(561, 32)
        Me.busqueda.TabIndex = 54
        '
        'FormInventario
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
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormInventario"
        Me.Text = "FormInventario"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents nom_bus_prod As RadioButton
    Friend WithEvents Label13 As Label
    Friend WithEvents todo_busqueda As RadioButton
    Friend WithEvents id_bus_prod As RadioButton
    Friend WithEvents busqueda As TextBox
End Class
