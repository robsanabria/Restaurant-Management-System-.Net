<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VAgregarUtiles
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
        Me.bGuardarUtiles = New System.Windows.Forms.Button()
        Me.bSalirGuardarUtiles = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tDescripcionUtiles = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tCantidadUtiles = New System.Windows.Forms.TextBox()
        Me.tCosto_unitarioUtiles = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RBOscuro = New System.Windows.Forms.RadioButton()
        Me.RBClaro = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'bGuardarUtiles
        '
        Me.bGuardarUtiles.BackgroundImage = Global.RestoBarGourmetV2.My.Resources.Resources.AceptarN
        Me.bGuardarUtiles.FlatAppearance.BorderSize = 0
        Me.bGuardarUtiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bGuardarUtiles.Location = New System.Drawing.Point(36, 294)
        Me.bGuardarUtiles.Name = "bGuardarUtiles"
        Me.bGuardarUtiles.Size = New System.Drawing.Size(166, 32)
        Me.bGuardarUtiles.TabIndex = 1
        Me.bGuardarUtiles.UseVisualStyleBackColor = True
        '
        'bSalirGuardarUtiles
        '
        Me.bSalirGuardarUtiles.BackgroundImage = Global.RestoBarGourmetV2.My.Resources.Resources.CancelarN
        Me.bSalirGuardarUtiles.FlatAppearance.BorderSize = 0
        Me.bSalirGuardarUtiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bSalirGuardarUtiles.Location = New System.Drawing.Point(230, 294)
        Me.bSalirGuardarUtiles.Name = "bSalirGuardarUtiles"
        Me.bSalirGuardarUtiles.Size = New System.Drawing.Size(166, 32)
        Me.bSalirGuardarUtiles.TabIndex = 2
        Me.bSalirGuardarUtiles.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(83, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Descripción"
        '
        'tDescripcionUtiles
        '
        Me.tDescripcionUtiles.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.tDescripcionUtiles.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tDescripcionUtiles.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tDescripcionUtiles.ForeColor = System.Drawing.Color.White
        Me.tDescripcionUtiles.Location = New System.Drawing.Point(171, 73)
        Me.tDescripcionUtiles.Name = "tDescripcionUtiles"
        Me.tDescripcionUtiles.Size = New System.Drawing.Size(174, 18)
        Me.tDescripcionUtiles.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(83, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Cantidad"
        '
        'tCantidadUtiles
        '
        Me.tCantidadUtiles.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.tCantidadUtiles.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tCantidadUtiles.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tCantidadUtiles.ForeColor = System.Drawing.Color.White
        Me.tCantidadUtiles.Location = New System.Drawing.Point(171, 106)
        Me.tCantidadUtiles.Name = "tCantidadUtiles"
        Me.tCantidadUtiles.Size = New System.Drawing.Size(174, 18)
        Me.tCantidadUtiles.TabIndex = 10
        '
        'tCosto_unitarioUtiles
        '
        Me.tCosto_unitarioUtiles.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.tCosto_unitarioUtiles.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tCosto_unitarioUtiles.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tCosto_unitarioUtiles.ForeColor = System.Drawing.Color.White
        Me.tCosto_unitarioUtiles.Location = New System.Drawing.Point(171, 143)
        Me.tCosto_unitarioUtiles.Name = "tCosto_unitarioUtiles"
        Me.tCosto_unitarioUtiles.Size = New System.Drawing.Size(174, 18)
        Me.tCosto_unitarioUtiles.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(83, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 15)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Costo unitario"
        '
        'RBOscuro
        '
        Me.RBOscuro.AutoSize = True
        Me.RBOscuro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBOscuro.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RBOscuro.Location = New System.Drawing.Point(411, 342)
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
        Me.RBClaro.Location = New System.Drawing.Point(411, 294)
        Me.RBClaro.Name = "RBClaro"
        Me.RBClaro.Size = New System.Drawing.Size(14, 13)
        Me.RBClaro.TabIndex = 16
        Me.RBClaro.TabStop = True
        Me.RBClaro.UseVisualStyleBackColor = True
        Me.RBClaro.Visible = False
        '
        'VAgregarUtiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(437, 367)
        Me.Controls.Add(Me.RBOscuro)
        Me.Controls.Add(Me.RBClaro)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tCosto_unitarioUtiles)
        Me.Controls.Add(Me.tCantidadUtiles)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tDescripcionUtiles)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bSalirGuardarUtiles)
        Me.Controls.Add(Me.bGuardarUtiles)
        Me.Cursor = System.Windows.Forms.Cursors.No
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(59, 97)
        Me.Name = "VAgregarUtiles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VAgregarUtiles"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bGuardarUtiles As Button
    Friend WithEvents bSalirGuardarUtiles As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tCantidadUtiles As TextBox
    Friend WithEvents tCosto_unitarioUtiles As TextBox
    Friend WithEvents tDescripcionUtiles As TextBox
    Friend WithEvents RBOscuro As RadioButton
    Friend WithEvents RBClaro As RadioButton
End Class
