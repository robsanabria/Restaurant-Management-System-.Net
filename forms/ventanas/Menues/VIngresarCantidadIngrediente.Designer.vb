<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VIngresarCantidadIngrediente
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
        Me.lIngrediente = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tCantidadIngrediente = New System.Windows.Forms.TextBox()
        Me.bCancelarIngrediente = New System.Windows.Forms.Button()
        Me.bAceptarIngrediente = New System.Windows.Forms.Button()
        Me.RBOscuro = New System.Windows.Forms.RadioButton()
        Me.RBClaro = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'lIngrediente
        '
        Me.lIngrediente.AutoSize = True
        Me.lIngrediente.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lIngrediente.ForeColor = System.Drawing.Color.White
        Me.lIngrediente.Location = New System.Drawing.Point(27, 23)
        Me.lIngrediente.Name = "lIngrediente"
        Me.lIngrediente.Size = New System.Drawing.Size(40, 15)
        Me.lIngrediente.TabIndex = 0
        Me.lIngrediente.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(27, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ingrese Cantidad:"
        '
        'tCantidadIngrediente
        '
        Me.tCantidadIngrediente.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.tCantidadIngrediente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tCantidadIngrediente.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tCantidadIngrediente.ForeColor = System.Drawing.Color.White
        Me.tCantidadIngrediente.Location = New System.Drawing.Point(134, 68)
        Me.tCantidadIngrediente.Name = "tCantidadIngrediente"
        Me.tCantidadIngrediente.Size = New System.Drawing.Size(175, 18)
        Me.tCantidadIngrediente.TabIndex = 2
        Me.tCantidadIngrediente.Text = "1"
        '
        'bCancelarIngrediente
        '
        Me.bCancelarIngrediente.BackgroundImage = Global.RestoBarGourmetV2.My.Resources.Resources.CancelarChiquitoN
        Me.bCancelarIngrediente.FlatAppearance.BorderSize = 0
        Me.bCancelarIngrediente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCancelarIngrediente.Location = New System.Drawing.Point(209, 128)
        Me.bCancelarIngrediente.Name = "bCancelarIngrediente"
        Me.bCancelarIngrediente.Size = New System.Drawing.Size(80, 32)
        Me.bCancelarIngrediente.TabIndex = 4
        Me.bCancelarIngrediente.UseVisualStyleBackColor = True
        '
        'bAceptarIngrediente
        '
        Me.bAceptarIngrediente.BackgroundImage = Global.RestoBarGourmetV2.My.Resources.Resources.AceptarChiquitoN
        Me.bAceptarIngrediente.FlatAppearance.BorderSize = 0
        Me.bAceptarIngrediente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAceptarIngrediente.Location = New System.Drawing.Point(50, 128)
        Me.bAceptarIngrediente.Name = "bAceptarIngrediente"
        Me.bAceptarIngrediente.Size = New System.Drawing.Size(80, 32)
        Me.bAceptarIngrediente.TabIndex = 3
        Me.bAceptarIngrediente.UseVisualStyleBackColor = True
        '
        'RBOscuro
        '
        Me.RBOscuro.AutoSize = True
        Me.RBOscuro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBOscuro.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RBOscuro.Location = New System.Drawing.Point(317, 161)
        Me.RBOscuro.Name = "RBOscuro"
        Me.RBOscuro.Size = New System.Drawing.Size(14, 13)
        Me.RBOscuro.TabIndex = 17
        Me.RBOscuro.TabStop = True
        Me.RBOscuro.UseVisualStyleBackColor = True
        Me.RBOscuro.Visible = False
        '
        'RBClaro
        '
        Me.RBClaro.AutoSize = True
        Me.RBClaro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBClaro.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RBClaro.Location = New System.Drawing.Point(317, 113)
        Me.RBClaro.Name = "RBClaro"
        Me.RBClaro.Size = New System.Drawing.Size(14, 13)
        Me.RBClaro.TabIndex = 16
        Me.RBClaro.TabStop = True
        Me.RBClaro.UseVisualStyleBackColor = True
        Me.RBClaro.Visible = False
        '
        'VIngresarCantidadIngrediente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(343, 186)
        Me.Controls.Add(Me.RBOscuro)
        Me.Controls.Add(Me.RBClaro)
        Me.Controls.Add(Me.bCancelarIngrediente)
        Me.Controls.Add(Me.bAceptarIngrediente)
        Me.Controls.Add(Me.tCantidadIngrediente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lIngrediente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "VIngresarCantidadIngrediente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VIngresarCantidadIngrediente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lIngrediente As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tCantidadIngrediente As TextBox
    Friend WithEvents bAceptarIngrediente As Button
    Friend WithEvents bCancelarIngrediente As Button
    Friend WithEvents RBOscuro As RadioButton
    Friend WithEvents RBClaro As RadioButton
End Class
