<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VAgregarTelefono
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbDescripcionTel = New System.Windows.Forms.TextBox()
        Me.TbNumeroTel = New System.Windows.Forms.TextBox()
        Me.bAceptar = New System.Windows.Forms.Button()
        Me.bCancelar = New System.Windows.Forms.Button()
        Me.RBOscuro = New System.Windows.Forms.RadioButton()
        Me.RBClaro = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(83, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Descripcion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(83, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Telefono"
        '
        'TbDescripcionTel
        '
        Me.TbDescripcionTel.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.TbDescripcionTel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbDescripcionTel.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!)
        Me.TbDescripcionTel.ForeColor = System.Drawing.Color.White
        Me.TbDescripcionTel.Location = New System.Drawing.Point(171, 73)
        Me.TbDescripcionTel.Name = "TbDescripcionTel"
        Me.TbDescripcionTel.Size = New System.Drawing.Size(178, 18)
        Me.TbDescripcionTel.TabIndex = 8
        '
        'TbNumeroTel
        '
        Me.TbNumeroTel.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.TbNumeroTel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbNumeroTel.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!)
        Me.TbNumeroTel.ForeColor = System.Drawing.Color.White
        Me.TbNumeroTel.Location = New System.Drawing.Point(171, 130)
        Me.TbNumeroTel.Name = "TbNumeroTel"
        Me.TbNumeroTel.Size = New System.Drawing.Size(178, 18)
        Me.TbNumeroTel.TabIndex = 8
        '
        'bAceptar
        '
        Me.bAceptar.BackgroundImage = Global.RestoBarGourmetV2.My.Resources.Resources.AceptarN
        Me.bAceptar.Cursor = System.Windows.Forms.Cursors.No
        Me.bAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAceptar.Location = New System.Drawing.Point(43, 222)
        Me.bAceptar.Name = "bAceptar"
        Me.bAceptar.Size = New System.Drawing.Size(167, 34)
        Me.bAceptar.TabIndex = 4
        Me.bAceptar.UseVisualStyleBackColor = True
        '
        'bCancelar
        '
        Me.bCancelar.BackgroundImage = Global.RestoBarGourmetV2.My.Resources.Resources.CancelarN
        Me.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCancelar.Location = New System.Drawing.Point(244, 222)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(168, 34)
        Me.bCancelar.TabIndex = 5
        Me.bCancelar.UseVisualStyleBackColor = True
        '
        'RBOscuro
        '
        Me.RBOscuro.AutoSize = True
        Me.RBOscuro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBOscuro.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RBOscuro.Location = New System.Drawing.Point(411, 344)
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
        Me.RBClaro.Location = New System.Drawing.Point(411, 296)
        Me.RBClaro.Name = "RBClaro"
        Me.RBClaro.Size = New System.Drawing.Size(14, 13)
        Me.RBClaro.TabIndex = 16
        Me.RBClaro.TabStop = True
        Me.RBClaro.UseVisualStyleBackColor = True
        Me.RBClaro.Visible = False
        '
        'VAgregarTelefono
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(437, 367)
        Me.Controls.Add(Me.RBOscuro)
        Me.Controls.Add(Me.RBClaro)
        Me.Controls.Add(Me.bCancelar)
        Me.Controls.Add(Me.bAceptar)
        Me.Controls.Add(Me.TbNumeroTel)
        Me.Controls.Add(Me.TbDescripcionTel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(59, 97)
        Me.Name = "VAgregarTelefono"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VAgregarTelefonovb"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TbDescripcionTel As TextBox
    Friend WithEvents TbNumeroTel As TextBox
    Friend WithEvents bAceptar As Button
    Friend WithEvents bCancelar As Button
    Friend WithEvents RBOscuro As RadioButton
    Friend WithEvents RBClaro As RadioButton
End Class
