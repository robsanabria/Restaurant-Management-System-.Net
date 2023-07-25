<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PantallaBloqueo
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
        Me.tPin = New System.Windows.Forms.TextBox()
        Me.bEntrar = New System.Windows.Forms.Button()
        Me.lPin = New System.Windows.Forms.Label()
        Me.bSalirBloqueo = New System.Windows.Forms.Button()
        Me.PLogo = New System.Windows.Forms.PictureBox()
        Me.LHora = New System.Windows.Forms.Label()
        Me.LFecha = New System.Windows.Forms.Label()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.LOlvide = New System.Windows.Forms.Label()
        Me.bAtrasBloqueo = New System.Windows.Forms.Button()
        Me.BDifuminar = New System.Windows.Forms.Button()
        CType(Me.PLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tPin
        '
        Me.tPin.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPin.Location = New System.Drawing.Point(563, 477)
        Me.tPin.Name = "tPin"
        Me.tPin.Size = New System.Drawing.Size(244, 22)
        Me.tPin.TabIndex = 0
        Me.tPin.UseSystemPasswordChar = True
        '
        'bEntrar
        '
        Me.bEntrar.BackColor = System.Drawing.Color.Transparent
        Me.bEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bEntrar.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bEntrar.ForeColor = System.Drawing.Color.White
        Me.bEntrar.Location = New System.Drawing.Point(813, 472)
        Me.bEntrar.Name = "bEntrar"
        Me.bEntrar.Size = New System.Drawing.Size(67, 30)
        Me.bEntrar.TabIndex = 1
        Me.bEntrar.Text = "Entrar"
        Me.bEntrar.UseVisualStyleBackColor = False
        '
        'lPin
        '
        Me.lPin.AutoSize = True
        Me.lPin.BackColor = System.Drawing.Color.Transparent
        Me.lPin.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lPin.ForeColor = System.Drawing.Color.White
        Me.lPin.Location = New System.Drawing.Point(462, 477)
        Me.lPin.Name = "lPin"
        Me.lPin.Size = New System.Drawing.Size(102, 20)
        Me.lPin.TabIndex = 2
        Me.lPin.Text = "Ingrese su PIN"
        '
        'bSalirBloqueo
        '
        Me.bSalirBloqueo.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bSalirBloqueo.Location = New System.Drawing.Point(1279, 727)
        Me.bSalirBloqueo.Name = "bSalirBloqueo"
        Me.bSalirBloqueo.Size = New System.Drawing.Size(75, 29)
        Me.bSalirBloqueo.TabIndex = 3
        Me.bSalirBloqueo.Text = "Salir"
        Me.bSalirBloqueo.UseVisualStyleBackColor = True
        '
        'PLogo
        '
        Me.PLogo.BackColor = System.Drawing.Color.Transparent
        Me.PLogo.BackgroundImage = Global.RestoBarGourmetV2.My.Resources.Resources.Logo
        Me.PLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PLogo.Location = New System.Drawing.Point(603, 253)
        Me.PLogo.Name = "PLogo"
        Me.PLogo.Size = New System.Drawing.Size(158, 158)
        Me.PLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PLogo.TabIndex = 4
        Me.PLogo.TabStop = False
        '
        'LHora
        '
        Me.LHora.AutoSize = True
        Me.LHora.BackColor = System.Drawing.Color.Transparent
        Me.LHora.Font = New System.Drawing.Font("Segoe UI Emoji", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LHora.ForeColor = System.Drawing.Color.White
        Me.LHora.Location = New System.Drawing.Point(548, 125)
        Me.LHora.Name = "LHora"
        Me.LHora.Size = New System.Drawing.Size(285, 128)
        Me.LHora.TabIndex = 5
        Me.LHora.Text = "00:00"
        Me.LHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LFecha
        '
        Me.LFecha.AutoEllipsis = True
        Me.LFecha.AutoSize = True
        Me.LFecha.BackColor = System.Drawing.Color.Transparent
        Me.LFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LFecha.Font = New System.Drawing.Font("Segoe UI Emoji", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFecha.ForeColor = System.Drawing.Color.White
        Me.LFecha.Location = New System.Drawing.Point(444, 241)
        Me.LFecha.Name = "LFecha"
        Me.LFecha.Size = New System.Drawing.Size(474, 47)
        Me.LFecha.TabIndex = 6
        Me.LFecha.Text = "Thursday 01 de June de 2023"
        Me.LFecha.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.BackColor = System.Drawing.Color.Transparent
        Me.LNombre.Font = New System.Drawing.Font("Segoe UI Emoji", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNombre.ForeColor = System.Drawing.Color.White
        Me.LNombre.Location = New System.Drawing.Point(576, 432)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(216, 32)
        Me.LNombre.TabIndex = 7
        Me.LNombre.Text = "Resto Bar Gourmet"
        '
        'LOlvide
        '
        Me.LOlvide.AutoSize = True
        Me.LOlvide.BackColor = System.Drawing.Color.Transparent
        Me.LOlvide.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LOlvide.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LOlvide.ForeColor = System.Drawing.Color.White
        Me.LOlvide.Location = New System.Drawing.Point(637, 525)
        Me.LOlvide.Name = "LOlvide"
        Me.LOlvide.Size = New System.Drawing.Size(100, 20)
        Me.LOlvide.TabIndex = 8
        Me.LOlvide.Text = "Olvide mi PIN"
        '
        'bAtrasBloqueo
        '
        Me.bAtrasBloqueo.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAtrasBloqueo.Location = New System.Drawing.Point(1198, 727)
        Me.bAtrasBloqueo.Name = "bAtrasBloqueo"
        Me.bAtrasBloqueo.Size = New System.Drawing.Size(75, 29)
        Me.bAtrasBloqueo.TabIndex = 9
        Me.bAtrasBloqueo.Text = "Atras"
        Me.bAtrasBloqueo.UseVisualStyleBackColor = True
        '
        'BDifuminar
        '
        Me.BDifuminar.BackColor = System.Drawing.Color.Transparent
        Me.BDifuminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BDifuminar.FlatAppearance.BorderSize = 0
        Me.BDifuminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BDifuminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BDifuminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BDifuminar.Location = New System.Drawing.Point(0, 0)
        Me.BDifuminar.Name = "BDifuminar"
        Me.BDifuminar.Size = New System.Drawing.Size(1366, 768)
        Me.BDifuminar.TabIndex = 11
        Me.BDifuminar.UseVisualStyleBackColor = False
        '
        'PantallaBloqueo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.RestoBarGourmetV2.My.Resources.Resources.Fondo
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.LHora)
        Me.Controls.Add(Me.LFecha)
        Me.Controls.Add(Me.BDifuminar)
        Me.Controls.Add(Me.bAtrasBloqueo)
        Me.Controls.Add(Me.LOlvide)
        Me.Controls.Add(Me.LNombre)
        Me.Controls.Add(Me.PLogo)
        Me.Controls.Add(Me.bSalirBloqueo)
        Me.Controls.Add(Me.lPin)
        Me.Controls.Add(Me.bEntrar)
        Me.Controls.Add(Me.tPin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PantallaBloqueo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tPin As TextBox
    Friend WithEvents bEntrar As Button
    Friend WithEvents lPin As Label
    Friend WithEvents bSalirBloqueo As Button
    Friend WithEvents PLogo As PictureBox
    Friend WithEvents LHora As Label
    Friend WithEvents LFecha As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents LOlvide As Label
    Friend WithEvents bAtrasBloqueo As Button
    Friend WithEvents BDifuminar As Button
End Class
