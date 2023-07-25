<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VIngresarCantidadVenta
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
        Me.tCantidadMenu = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lMenu = New System.Windows.Forms.Label()
        Me.bCancelarMenu = New System.Windows.Forms.Button()
        Me.bAceptarMenu = New System.Windows.Forms.Button()
        Me.RBOscuro = New System.Windows.Forms.RadioButton()
        Me.RBClaro = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'tCantidadMenu
        '
        Me.tCantidadMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.tCantidadMenu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tCantidadMenu.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tCantidadMenu.ForeColor = System.Drawing.Color.White
        Me.tCantidadMenu.Location = New System.Drawing.Point(139, 72)
        Me.tCantidadMenu.Name = "tCantidadMenu"
        Me.tCantidadMenu.Size = New System.Drawing.Size(175, 18)
        Me.tCantidadMenu.TabIndex = 7
        Me.tCantidadMenu.Text = "1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(32, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Ingrese Cantidad:"
        '
        'lMenu
        '
        Me.lMenu.AutoSize = True
        Me.lMenu.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lMenu.ForeColor = System.Drawing.Color.White
        Me.lMenu.Location = New System.Drawing.Point(32, 27)
        Me.lMenu.Name = "lMenu"
        Me.lMenu.Size = New System.Drawing.Size(40, 15)
        Me.lMenu.TabIndex = 5
        Me.lMenu.Text = "Label1"
        '
        'bCancelarMenu
        '
        Me.bCancelarMenu.BackgroundImage = Global.RestoBarGourmetV2.My.Resources.Resources.CancelarChiquitoN
        Me.bCancelarMenu.FlatAppearance.BorderSize = 0
        Me.bCancelarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCancelarMenu.Location = New System.Drawing.Point(214, 132)
        Me.bCancelarMenu.Name = "bCancelarMenu"
        Me.bCancelarMenu.Size = New System.Drawing.Size(80, 32)
        Me.bCancelarMenu.TabIndex = 9
        Me.bCancelarMenu.UseVisualStyleBackColor = True
        '
        'bAceptarMenu
        '
        Me.bAceptarMenu.BackgroundImage = Global.RestoBarGourmetV2.My.Resources.Resources.AceptarChiquitoN
        Me.bAceptarMenu.FlatAppearance.BorderSize = 0
        Me.bAceptarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAceptarMenu.Location = New System.Drawing.Point(55, 132)
        Me.bAceptarMenu.Name = "bAceptarMenu"
        Me.bAceptarMenu.Size = New System.Drawing.Size(80, 32)
        Me.bAceptarMenu.TabIndex = 8
        Me.bAceptarMenu.UseVisualStyleBackColor = True
        '
        'RBOscuro
        '
        Me.RBOscuro.AutoSize = True
        Me.RBOscuro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBOscuro.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RBOscuro.Location = New System.Drawing.Point(326, 159)
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
        Me.RBClaro.Location = New System.Drawing.Point(326, 111)
        Me.RBClaro.Name = "RBClaro"
        Me.RBClaro.Size = New System.Drawing.Size(14, 13)
        Me.RBClaro.TabIndex = 16
        Me.RBClaro.TabStop = True
        Me.RBClaro.UseVisualStyleBackColor = True
        Me.RBClaro.Visible = False
        '
        'VIngresarCantidadVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(343, 186)
        Me.Controls.Add(Me.RBOscuro)
        Me.Controls.Add(Me.RBClaro)
        Me.Controls.Add(Me.bCancelarMenu)
        Me.Controls.Add(Me.bAceptarMenu)
        Me.Controls.Add(Me.tCantidadMenu)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "VIngresarCantidadVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VIngresarCantidadVenta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bCancelarMenu As Button
    Friend WithEvents bAceptarMenu As Button
    Friend WithEvents tCantidadMenu As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lMenu As Label
    Friend WithEvents RBOscuro As RadioButton
    Friend WithEvents RBClaro As RadioButton
End Class
