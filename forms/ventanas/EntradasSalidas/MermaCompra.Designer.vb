<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MermaCompra
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
        Me.lDescripcion = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tCantidad = New System.Windows.Forms.TextBox()
        Me.tObservaciones = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bCancelar = New System.Windows.Forms.Button()
        Me.bRegistrar = New System.Windows.Forms.Button()
        Me.cMermaCompra = New System.Windows.Forms.ComboBox()
        Me.RBOscuro = New System.Windows.Forms.RadioButton()
        Me.RBClaro = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'lDescripcion
        '
        Me.lDescripcion.AutoSize = True
        Me.lDescripcion.Location = New System.Drawing.Point(136, 30)
        Me.lDescripcion.Name = "lDescripcion"
        Me.lDescripcion.Size = New System.Drawing.Size(39, 13)
        Me.lDescripcion.TabIndex = 0
        Me.lDescripcion.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tipo de operación:"
        '
        'tCantidad
        '
        Me.tCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.tCantidad.ForeColor = System.Drawing.Color.White
        Me.tCantidad.Location = New System.Drawing.Point(121, 131)
        Me.tCantidad.Name = "tCantidad"
        Me.tCantidad.Size = New System.Drawing.Size(120, 20)
        Me.tCantidad.TabIndex = 2
        '
        'tObservaciones
        '
        Me.tObservaciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.tObservaciones.ForeColor = System.Drawing.Color.White
        Me.tObservaciones.Location = New System.Drawing.Point(342, 27)
        Me.tObservaciones.Multiline = True
        Me.tObservaciones.Name = "tObservaciones"
        Me.tObservaciones.Size = New System.Drawing.Size(169, 183)
        Me.tObservaciones.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Cantidad:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(339, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Observaciones:"
        '
        'bCancelar
        '
        Me.bCancelar.BackgroundImage = Global.RestoBarGourmetV2.My.Resources.Resources.CancelarChiquitoN
        Me.bCancelar.FlatAppearance.BorderSize = 0
        Me.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCancelar.Location = New System.Drawing.Point(22, 177)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(80, 32)
        Me.bCancelar.TabIndex = 7
        Me.bCancelar.UseVisualStyleBackColor = True
        '
        'bRegistrar
        '
        Me.bRegistrar.BackgroundImage = Global.RestoBarGourmetV2.My.Resources.Resources.AgregarChiquitoN
        Me.bRegistrar.FlatAppearance.BorderSize = 0
        Me.bRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bRegistrar.Location = New System.Drawing.Point(162, 177)
        Me.bRegistrar.Name = "bRegistrar"
        Me.bRegistrar.Size = New System.Drawing.Size(80, 32)
        Me.bRegistrar.TabIndex = 8
        Me.bRegistrar.UseVisualStyleBackColor = True
        '
        'cMermaCompra
        '
        Me.cMermaCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cMermaCompra.ForeColor = System.Drawing.Color.White
        Me.cMermaCompra.FormattingEnabled = True
        Me.cMermaCompra.Items.AddRange(New Object() {"Compra", "Merma"})
        Me.cMermaCompra.Location = New System.Drawing.Point(121, 81)
        Me.cMermaCompra.Name = "cMermaCompra"
        Me.cMermaCompra.Size = New System.Drawing.Size(121, 21)
        Me.cMermaCompra.TabIndex = 9
        '
        'RBOscuro
        '
        Me.RBOscuro.AutoSize = True
        Me.RBOscuro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBOscuro.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RBOscuro.Location = New System.Drawing.Point(322, 132)
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
        Me.RBClaro.Location = New System.Drawing.Point(322, 84)
        Me.RBClaro.Name = "RBClaro"
        Me.RBClaro.Size = New System.Drawing.Size(14, 13)
        Me.RBClaro.TabIndex = 16
        Me.RBClaro.TabStop = True
        Me.RBClaro.UseVisualStyleBackColor = True
        Me.RBClaro.Visible = False
        '
        'MermaCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(529, 230)
        Me.Controls.Add(Me.RBOscuro)
        Me.Controls.Add(Me.RBClaro)
        Me.Controls.Add(Me.cMermaCompra)
        Me.Controls.Add(Me.bRegistrar)
        Me.Controls.Add(Me.bCancelar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tObservaciones)
        Me.Controls.Add(Me.tCantidad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lDescripcion)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MermaCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MermaCompra"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lDescripcion As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tCantidad As TextBox
    Friend WithEvents tObservaciones As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents bCancelar As Button
    Friend WithEvents bRegistrar As Button
    Friend WithEvents cMermaCompra As ComboBox
    Friend WithEvents RBOscuro As RadioButton
    Friend WithEvents RBClaro As RadioButton
End Class
