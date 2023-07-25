<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Configuraciones
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RBOscuro = New System.Windows.Forms.RadioButton()
        Me.RBClaro = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bModificarContra = New System.Windows.Forms.Button()
        Me.tContraActual = New System.Windows.Forms.TextBox()
        Me.tContraNueva1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tContraNueva2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Emoji", 21.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(232, 37)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Configuraciones"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Emoji", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(14, 414)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(292, 28)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Modificar contraseña de inicio"
        '
        'RBOscuro
        '
        Me.RBOscuro.AutoSize = True
        Me.RBOscuro.Enabled = False
        Me.RBOscuro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBOscuro.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RBOscuro.Location = New System.Drawing.Point(19, 301)
        Me.RBOscuro.Name = "RBOscuro"
        Me.RBOscuro.Size = New System.Drawing.Size(106, 20)
        Me.RBOscuro.TabIndex = 27
        Me.RBOscuro.TabStop = True
        Me.RBOscuro.Text = "Tema oscuro"
        Me.RBOscuro.UseVisualStyleBackColor = True
        '
        'RBClaro
        '
        Me.RBClaro.AutoSize = True
        Me.RBClaro.Enabled = False
        Me.RBClaro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBClaro.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RBClaro.Location = New System.Drawing.Point(19, 253)
        Me.RBClaro.Name = "RBClaro"
        Me.RBClaro.Size = New System.Drawing.Size(95, 20)
        Me.RBClaro.TabIndex = 26
        Me.RBClaro.TabStop = True
        Me.RBClaro.Text = "Tema claro"
        Me.RBClaro.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Emoji", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(14, 185)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 28)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Modificar Tema"
        '
        'bModificarContra
        '
        Me.bModificarContra.BackColor = System.Drawing.Color.Transparent
        Me.bModificarContra.BackgroundImage = Global.RestoBarGourmetV2.My.Resources.Resources.ModificarContraseñaN
        Me.bModificarContra.FlatAppearance.BorderSize = 0
        Me.bModificarContra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bModificarContra.Location = New System.Drawing.Point(140, 672)
        Me.bModificarContra.Name = "bModificarContra"
        Me.bModificarContra.Size = New System.Drawing.Size(166, 32)
        Me.bModificarContra.TabIndex = 24
        Me.bModificarContra.UseVisualStyleBackColor = False
        '
        'tContraActual
        '
        Me.tContraActual.AccessibleDescription = ""
        Me.tContraActual.Location = New System.Drawing.Point(249, 526)
        Me.tContraActual.Name = "tContraActual"
        Me.tContraActual.Size = New System.Drawing.Size(166, 20)
        Me.tContraActual.TabIndex = 29
        Me.tContraActual.Tag = ""
        '
        'tContraNueva1
        '
        Me.tContraNueva1.Location = New System.Drawing.Point(249, 575)
        Me.tContraNueva1.Name = "tContraNueva1"
        Me.tContraNueva1.Size = New System.Drawing.Size(166, 20)
        Me.tContraNueva1.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(148, 529)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Contraseña actual:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(145, 578)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Nueva contraseña:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(38, 471)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(300, 13)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Para cambiar su contraseña ingrese la actual y luego la nueva"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(36, 619)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(207, 13)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Ingrese nuevamente la nueva contraseña:"
        '
        'tContraNueva2
        '
        Me.tContraNueva2.Location = New System.Drawing.Point(249, 616)
        Me.tContraNueva2.Name = "tContraNueva2"
        Me.tContraNueva2.Size = New System.Drawing.Size(166, 20)
        Me.tContraNueva2.TabIndex = 34
        '
        'Configuraciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1062, 768)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tContraNueva2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tContraNueva1)
        Me.Controls.Add(Me.tContraActual)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.RBOscuro)
        Me.Controls.Add(Me.RBClaro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bModificarContra)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Configuraciones"
        Me.Text = "Configuraciones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RBOscuro As RadioButton
    Friend WithEvents RBClaro As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents bModificarContra As Button
    Friend WithEvents tContraActual As TextBox
    Friend WithEvents tContraNueva1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents tContraNueva2 As TextBox
End Class
