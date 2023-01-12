<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCargoEmpleado
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
        Me.ID_car = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.desc_cargo = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Guardar = New System.Windows.Forms.Button()
        Me.Eliminar = New System.Windows.Forms.Button()
        Me.actualizar = New System.Windows.Forms.Button()
        Me.xdxdxd = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_car
        '
        Me.ID_car.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ID_car.Location = New System.Drawing.Point(12, 68)
        Me.ID_car.Name = "ID_car"
        Me.ID_car.Size = New System.Drawing.Size(64, 32)
        Me.ID_car.TabIndex = 0
        Me.ID_car.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(12, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre del cargo:"
        '
        'desc_cargo
        '
        Me.desc_cargo.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.desc_cargo.Location = New System.Drawing.Point(12, 173)
        Me.desc_cargo.Multiline = True
        Me.desc_cargo.Name = "desc_cargo"
        Me.desc_cargo.Size = New System.Drawing.Size(376, 56)
        Me.desc_cargo.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 250)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 70
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(376, 134)
        Me.DataGridView1.TabIndex = 4
        '
        'Guardar
        '
        Me.Guardar.Location = New System.Drawing.Point(12, 390)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(101, 37)
        Me.Guardar.TabIndex = 5
        Me.Guardar.Text = "Guardar"
        Me.Guardar.UseVisualStyleBackColor = True
        '
        'Eliminar
        '
        Me.Eliminar.Location = New System.Drawing.Point(153, 390)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(94, 37)
        Me.Eliminar.TabIndex = 6
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'actualizar
        '
        Me.actualizar.Location = New System.Drawing.Point(288, 390)
        Me.actualizar.Name = "actualizar"
        Me.actualizar.Size = New System.Drawing.Size(100, 37)
        Me.actualizar.TabIndex = 7
        Me.actualizar.Text = "Actualizar"
        Me.actualizar.UseVisualStyleBackColor = True
        '
        'xdxdxd
        '
        Me.xdxdxd.AutoSize = True
        Me.xdxdxd.Font = New System.Drawing.Font("Roboto Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.xdxdxd.Location = New System.Drawing.Point(153, 20)
        Me.xdxdxd.Name = "xdxdxd"
        Me.xdxdxd.Size = New System.Drawing.Size(111, 37)
        Me.xdxdxd.TabIndex = 8
        Me.xdxdxd.Text = "Cargos"
        '
        'FormCargoEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 488)
        Me.Controls.Add(Me.xdxdxd)
        Me.Controls.Add(Me.actualizar)
        Me.Controls.Add(Me.Eliminar)
        Me.Controls.Add(Me.Guardar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.desc_cargo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ID_car)
        Me.Name = "FormCargoEmpleado"
        Me.Text = "FormCargoEmpleado"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ID_car As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents desc_cargo As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Guardar As Button
    Friend WithEvents Eliminar As Button
    Friend WithEvents actualizar As Button
    Friend WithEvents xdxdxd As Label
End Class
