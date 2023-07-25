<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VAgregarMesa
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
        Me.tCantidadSillas = New System.Windows.Forms.TextBox()
        Me.tNumero = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bSalirGuardarMesa = New System.Windows.Forms.Button()
        Me.bGuardarMesa = New System.Windows.Forms.Button()
        Me.RBOscuro = New System.Windows.Forms.RadioButton()
        Me.RBClaro = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'tCantidadSillas
        '
        Me.tCantidadSillas.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.tCantidadSillas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tCantidadSillas.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tCantidadSillas.ForeColor = System.Drawing.Color.White
        Me.tCantidadSillas.Location = New System.Drawing.Point(154, 88)
        Me.tCantidadSillas.Name = "tCantidadSillas"
        Me.tCantidadSillas.Size = New System.Drawing.Size(174, 18)
        Me.tCantidadSillas.TabIndex = 20
        '
        'tNumero
        '
        Me.tNumero.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.tNumero.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tNumero.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tNumero.ForeColor = System.Drawing.Color.White
        Me.tNumero.Location = New System.Drawing.Point(154, 58)
        Me.tNumero.Name = "tNumero"
        Me.tNumero.Size = New System.Drawing.Size(174, 18)
        Me.tNumero.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(39, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 15)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Cantidad de sillas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(89, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 15)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Número"
        '
        'bSalirGuardarMesa
        '
        Me.bSalirGuardarMesa.BackgroundImage = Global.RestoBarGourmetV2.My.Resources.Resources.CancelarN
        Me.bSalirGuardarMesa.FlatAppearance.BorderSize = 0
        Me.bSalirGuardarMesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bSalirGuardarMesa.Location = New System.Drawing.Point(249, 141)
        Me.bSalirGuardarMesa.Name = "bSalirGuardarMesa"
        Me.bSalirGuardarMesa.Size = New System.Drawing.Size(166, 32)
        Me.bSalirGuardarMesa.TabIndex = 13
        Me.bSalirGuardarMesa.UseVisualStyleBackColor = True
        '
        'bGuardarMesa
        '
        Me.bGuardarMesa.BackgroundImage = Global.RestoBarGourmetV2.My.Resources.Resources.AceptarN
        Me.bGuardarMesa.FlatAppearance.BorderSize = 0
        Me.bGuardarMesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bGuardarMesa.Location = New System.Drawing.Point(39, 141)
        Me.bGuardarMesa.Name = "bGuardarMesa"
        Me.bGuardarMesa.Size = New System.Drawing.Size(166, 32)
        Me.bGuardarMesa.TabIndex = 12
        Me.bGuardarMesa.UseVisualStyleBackColor = True
        '
        'RBOscuro
        '
        Me.RBOscuro.AutoSize = True
        Me.RBOscuro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBOscuro.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RBOscuro.Location = New System.Drawing.Point(426, 189)
        Me.RBOscuro.Name = "RBOscuro"
        Me.RBOscuro.Size = New System.Drawing.Size(14, 13)
        Me.RBOscuro.TabIndex = 22
        Me.RBOscuro.TabStop = True
        Me.RBOscuro.UseVisualStyleBackColor = True
        Me.RBOscuro.Visible = False
        '
        'RBClaro
        '
        Me.RBClaro.AutoSize = True
        Me.RBClaro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBClaro.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RBClaro.Location = New System.Drawing.Point(426, 141)
        Me.RBClaro.Name = "RBClaro"
        Me.RBClaro.Size = New System.Drawing.Size(14, 13)
        Me.RBClaro.TabIndex = 21
        Me.RBClaro.TabStop = True
        Me.RBClaro.UseVisualStyleBackColor = True
        Me.RBClaro.Visible = False
        '
        'VAgregarMesa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(452, 222)
        Me.Controls.Add(Me.RBOscuro)
        Me.Controls.Add(Me.RBClaro)
        Me.Controls.Add(Me.tCantidadSillas)
        Me.Controls.Add(Me.tNumero)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bSalirGuardarMesa)
        Me.Controls.Add(Me.bGuardarMesa)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "VAgregarMesa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VAgregarMesa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tCantidadSillas As TextBox
    Friend WithEvents tNumero As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents bSalirGuardarMesa As Button
    Friend WithEvents bGuardarMesa As Button
    Friend WithEvents RBOscuro As RadioButton
    Friend WithEvents RBClaro As RadioButton
End Class
