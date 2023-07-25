<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VAgregarMercaderia
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
        Me.bGuardarMercaderia = New System.Windows.Forms.Button()
        Me.bSalirGuardarMercaderia = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tDescripcionMercaderia = New System.Windows.Forms.TextBox()
        Me.tCantidadMercaderia = New System.Windows.Forms.TextBox()
        Me.tCosto_unitarioMercaderia = New System.Windows.Forms.TextBox()
        Me.cmbTipo_unidadMercaderia = New System.Windows.Forms.ComboBox()
        Me.cmbCategoriaMercaderia = New System.Windows.Forms.ComboBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.RBOscuro = New System.Windows.Forms.RadioButton()
        Me.RBClaro = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'bGuardarMercaderia
        '
        Me.bGuardarMercaderia.BackgroundImage = Global.RestoBarGourmetV2.My.Resources.Resources.AceptarN
        Me.bGuardarMercaderia.FlatAppearance.BorderSize = 0
        Me.bGuardarMercaderia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bGuardarMercaderia.Location = New System.Drawing.Point(29, 291)
        Me.bGuardarMercaderia.Name = "bGuardarMercaderia"
        Me.bGuardarMercaderia.Size = New System.Drawing.Size(166, 32)
        Me.bGuardarMercaderia.TabIndex = 0
        Me.bGuardarMercaderia.UseVisualStyleBackColor = True
        '
        'bSalirGuardarMercaderia
        '
        Me.bSalirGuardarMercaderia.BackgroundImage = Global.RestoBarGourmetV2.My.Resources.Resources.CancelarN
        Me.bSalirGuardarMercaderia.FlatAppearance.BorderSize = 0
        Me.bSalirGuardarMercaderia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bSalirGuardarMercaderia.Location = New System.Drawing.Point(239, 291)
        Me.bSalirGuardarMercaderia.Name = "bSalirGuardarMercaderia"
        Me.bSalirGuardarMercaderia.Size = New System.Drawing.Size(166, 32)
        Me.bSalirGuardarMercaderia.TabIndex = 1
        Me.bSalirGuardarMercaderia.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(74, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Descripción"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(59, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tipo de unidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(83, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Categoría"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(88, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Cantidad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(66, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 15)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Costo unitario"
        '
        'tDescripcionMercaderia
        '
        Me.tDescripcionMercaderia.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.tDescripcionMercaderia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tDescripcionMercaderia.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tDescripcionMercaderia.ForeColor = System.Drawing.Color.White
        Me.tDescripcionMercaderia.Location = New System.Drawing.Point(148, 68)
        Me.tDescripcionMercaderia.Name = "tDescripcionMercaderia"
        Me.tDescripcionMercaderia.Size = New System.Drawing.Size(174, 18)
        Me.tDescripcionMercaderia.TabIndex = 7
        '
        'tCantidadMercaderia
        '
        Me.tCantidadMercaderia.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.tCantidadMercaderia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tCantidadMercaderia.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tCantidadMercaderia.ForeColor = System.Drawing.Color.White
        Me.tCantidadMercaderia.Location = New System.Drawing.Point(148, 148)
        Me.tCantidadMercaderia.Name = "tCantidadMercaderia"
        Me.tCantidadMercaderia.Size = New System.Drawing.Size(174, 18)
        Me.tCantidadMercaderia.TabIndex = 8
        '
        'tCosto_unitarioMercaderia
        '
        Me.tCosto_unitarioMercaderia.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.tCosto_unitarioMercaderia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tCosto_unitarioMercaderia.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tCosto_unitarioMercaderia.ForeColor = System.Drawing.Color.White
        Me.tCosto_unitarioMercaderia.Location = New System.Drawing.Point(148, 174)
        Me.tCosto_unitarioMercaderia.Name = "tCosto_unitarioMercaderia"
        Me.tCosto_unitarioMercaderia.Size = New System.Drawing.Size(174, 18)
        Me.tCosto_unitarioMercaderia.TabIndex = 9
        '
        'cmbTipo_unidadMercaderia
        '
        Me.cmbTipo_unidadMercaderia.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbTipo_unidadMercaderia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbTipo_unidadMercaderia.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipo_unidadMercaderia.ForeColor = System.Drawing.Color.White
        Me.cmbTipo_unidadMercaderia.FormattingEnabled = True
        Me.cmbTipo_unidadMercaderia.Items.AddRange(New Object() {"Kilogramos", "gramos", "Litros", "mililitros", "Unidad", "centímetros cúbicos"})
        Me.cmbTipo_unidadMercaderia.Location = New System.Drawing.Point(148, 94)
        Me.cmbTipo_unidadMercaderia.Name = "cmbTipo_unidadMercaderia"
        Me.cmbTipo_unidadMercaderia.Size = New System.Drawing.Size(174, 25)
        Me.cmbTipo_unidadMercaderia.TabIndex = 10
        '
        'cmbCategoriaMercaderia
        '
        Me.cmbCategoriaMercaderia.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbCategoriaMercaderia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCategoriaMercaderia.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCategoriaMercaderia.ForeColor = System.Drawing.Color.White
        Me.cmbCategoriaMercaderia.FormattingEnabled = True
        Me.cmbCategoriaMercaderia.Items.AddRange(New Object() {"Carne", "Lacteo", "Verdura", "Fruta", "Condimento", "Harinas", "Bebida"})
        Me.cmbCategoriaMercaderia.Location = New System.Drawing.Point(148, 121)
        Me.cmbCategoriaMercaderia.Name = "cmbCategoriaMercaderia"
        Me.cmbCategoriaMercaderia.Size = New System.Drawing.Size(174, 25)
        Me.cmbCategoriaMercaderia.TabIndex = 11
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
        'VAgregarMercaderia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(437, 367)
        Me.Controls.Add(Me.RBOscuro)
        Me.Controls.Add(Me.RBClaro)
        Me.Controls.Add(Me.cmbCategoriaMercaderia)
        Me.Controls.Add(Me.cmbTipo_unidadMercaderia)
        Me.Controls.Add(Me.tCosto_unitarioMercaderia)
        Me.Controls.Add(Me.tCantidadMercaderia)
        Me.Controls.Add(Me.tDescripcionMercaderia)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bSalirGuardarMercaderia)
        Me.Controls.Add(Me.bGuardarMercaderia)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "VAgregarMercaderia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VAgregarMercaderia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bGuardarMercaderia As Button
    Friend WithEvents bSalirGuardarMercaderia As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tDescripcionMercaderia As TextBox
    Friend WithEvents tCantidadMercaderia As TextBox
    Friend WithEvents tCosto_unitarioMercaderia As TextBox
    Friend WithEvents cmbTipo_unidadMercaderia As ComboBox
    Friend WithEvents cmbCategoriaMercaderia As ComboBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents RBOscuro As RadioButton
    Friend WithEvents RBClaro As RadioButton
End Class
