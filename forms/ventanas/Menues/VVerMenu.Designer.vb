<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VVerMenu
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvVerMenu = New System.Windows.Forms.DataGridView()
        Me.dgvDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvTipoUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lCosto = New System.Windows.Forms.Label()
        Me.lImporte = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lNombreMenu = New System.Windows.Forms.Label()
        Me.RBOscuro = New System.Windows.Forms.RadioButton()
        Me.RBClaro = New System.Windows.Forms.RadioButton()
        CType(Me.dgvVerMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvVerMenu
        '
        Me.dgvVerMenu.AllowUserToAddRows = False
        Me.dgvVerMenu.AllowUserToDeleteRows = False
        Me.dgvVerMenu.AllowUserToResizeColumns = False
        Me.dgvVerMenu.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgvVerMenu.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvVerMenu.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVerMenu.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvVerMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVerMenu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvDescripcion, Me.dgvTipoUnidad, Me.dgvCantidad})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvVerMenu.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvVerMenu.EnableHeadersVisualStyles = False
        Me.dgvVerMenu.Location = New System.Drawing.Point(71, 45)
        Me.dgvVerMenu.Name = "dgvVerMenu"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVerMenu.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvVerMenu.RowHeadersVisible = False
        Me.dgvVerMenu.Size = New System.Drawing.Size(379, 315)
        Me.dgvVerMenu.TabIndex = 0
        '
        'dgvDescripcion
        '
        Me.dgvDescripcion.HeaderText = "Descripcion"
        Me.dgvDescripcion.Name = "dgvDescripcion"
        '
        'dgvTipoUnidad
        '
        Me.dgvTipoUnidad.HeaderText = "Tipo de Unidad"
        Me.dgvTipoUnidad.Name = "dgvTipoUnidad"
        '
        'dgvCantidad
        '
        Me.dgvCantidad.HeaderText = "Cantidad"
        Me.dgvCantidad.Name = "dgvCantidad"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.RestoBarGourmetV2.My.Resources.Resources.CerrarBN
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(370, 384)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 32)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lCosto
        '
        Me.lCosto.AutoSize = True
        Me.lCosto.Location = New System.Drawing.Point(68, 403)
        Me.lCosto.Name = "lCosto"
        Me.lCosto.Size = New System.Drawing.Size(39, 13)
        Me.lCosto.TabIndex = 2
        Me.lCosto.Text = "Label1"
        '
        'lImporte
        '
        Me.lImporte.AutoSize = True
        Me.lImporte.Location = New System.Drawing.Point(175, 403)
        Me.lImporte.Name = "lImporte"
        Me.lImporte.Size = New System.Drawing.Size(39, 13)
        Me.lImporte.TabIndex = 3
        Me.lImporte.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 380)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Costo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(175, 380)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Importe"
        '
        'lNombreMenu
        '
        Me.lNombreMenu.AutoSize = True
        Me.lNombreMenu.Location = New System.Drawing.Point(68, 19)
        Me.lNombreMenu.Name = "lNombreMenu"
        Me.lNombreMenu.Size = New System.Drawing.Size(19, 13)
        Me.lNombreMenu.TabIndex = 6
        Me.lNombreMenu.Text = "----"
        '
        'RBOscuro
        '
        Me.RBOscuro.AutoSize = True
        Me.RBOscuro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBOscuro.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RBOscuro.Location = New System.Drawing.Point(496, 428)
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
        Me.RBClaro.Location = New System.Drawing.Point(496, 380)
        Me.RBClaro.Name = "RBClaro"
        Me.RBClaro.Size = New System.Drawing.Size(14, 13)
        Me.RBClaro.TabIndex = 16
        Me.RBClaro.TabStop = True
        Me.RBClaro.UseVisualStyleBackColor = True
        Me.RBClaro.Visible = False
        '
        'VVerMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(522, 450)
        Me.Controls.Add(Me.RBOscuro)
        Me.Controls.Add(Me.RBClaro)
        Me.Controls.Add(Me.lNombreMenu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lImporte)
        Me.Controls.Add(Me.lCosto)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgvVerMenu)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "VVerMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VVerMenu"
        CType(Me.dgvVerMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvVerMenu As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents dgvDescripcion As DataGridViewTextBoxColumn
    Friend WithEvents dgvTipoUnidad As DataGridViewTextBoxColumn
    Friend WithEvents dgvCantidad As DataGridViewTextBoxColumn
    Friend WithEvents lCosto As Label
    Friend WithEvents lImporte As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lNombreMenu As Label
    Friend WithEvents RBOscuro As RadioButton
    Friend WithEvents RBClaro As RadioButton
End Class
