<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menues
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvMenues = New System.Windows.Forms.DataGridView()
        Me.dgvId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvCosto_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvPrecioFinal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvVerMenu = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.dgvEditar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.dgvEliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RBOscuro = New System.Windows.Forms.RadioButton()
        Me.RBClaro = New System.Windows.Forms.RadioButton()
        Me.bAgregarMenu = New System.Windows.Forms.Button()
        CType(Me.dgvMenues, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvMenues
        '
        Me.dgvMenues.AllowUserToAddRows = False
        Me.dgvMenues.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvMenues.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMenues.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMenues.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMenues.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.dgvMenues.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvMenues.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.dgvMenues.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMenues.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvMenues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMenues.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvId, Me.dgvDescripcion, Me.dgvCosto_total, Me.dgvPrecioFinal, Me.dgvVerMenu, Me.dgvEditar, Me.dgvEliminar})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMenues.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvMenues.EnableHeadersVisualStyles = False
        Me.dgvMenues.GridColor = System.Drawing.Color.DarkGray
        Me.dgvMenues.Location = New System.Drawing.Point(12, 104)
        Me.dgvMenues.Name = "dgvMenues"
        Me.dgvMenues.ReadOnly = True
        Me.dgvMenues.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMenues.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvMenues.RowHeadersVisible = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.dgvMenues.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvMenues.Size = New System.Drawing.Size(998, 465)
        Me.dgvMenues.TabIndex = 5
        '
        'dgvId
        '
        Me.dgvId.HeaderText = "ID"
        Me.dgvId.Name = "dgvId"
        Me.dgvId.ReadOnly = True
        Me.dgvId.Visible = False
        '
        'dgvDescripcion
        '
        Me.dgvDescripcion.FillWeight = 31.9797!
        Me.dgvDescripcion.HeaderText = "Descripción"
        Me.dgvDescripcion.Name = "dgvDescripcion"
        Me.dgvDescripcion.ReadOnly = True
        Me.dgvDescripcion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'dgvCosto_total
        '
        Me.dgvCosto_total.FillWeight = 31.9797!
        Me.dgvCosto_total.HeaderText = "Costo"
        Me.dgvCosto_total.Name = "dgvCosto_total"
        Me.dgvCosto_total.ReadOnly = True
        '
        'dgvPrecioFinal
        '
        Me.dgvPrecioFinal.FillWeight = 31.9797!
        Me.dgvPrecioFinal.HeaderText = "Precio Final"
        Me.dgvPrecioFinal.Name = "dgvPrecioFinal"
        Me.dgvPrecioFinal.ReadOnly = True
        '
        'dgvVerMenu
        '
        Me.dgvVerMenu.FillWeight = 31.9797!
        Me.dgvVerMenu.HeaderText = "Ver Menu"
        Me.dgvVerMenu.Name = "dgvVerMenu"
        Me.dgvVerMenu.ReadOnly = True
        Me.dgvVerMenu.Text = "Ver"
        Me.dgvVerMenu.UseColumnTextForButtonValue = True
        '
        'dgvEditar
        '
        Me.dgvEditar.FillWeight = 31.9797!
        Me.dgvEditar.HeaderText = "Editar"
        Me.dgvEditar.Name = "dgvEditar"
        Me.dgvEditar.ReadOnly = True
        Me.dgvEditar.Text = "Editar"
        Me.dgvEditar.UseColumnTextForButtonValue = True
        '
        'dgvEliminar
        '
        Me.dgvEliminar.FillWeight = 31.9797!
        Me.dgvEliminar.HeaderText = "Eliminar"
        Me.dgvEliminar.Name = "dgvEliminar"
        Me.dgvEliminar.ReadOnly = True
        Me.dgvEliminar.Text = "Eliminar"
        Me.dgvEliminar.UseColumnTextForButtonValue = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Emoji", 21.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(240, 37)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Menu disponible"
        '
        'RBOscuro
        '
        Me.RBOscuro.AutoSize = True
        Me.RBOscuro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBOscuro.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RBOscuro.Location = New System.Drawing.Point(1036, 738)
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
        Me.RBClaro.Location = New System.Drawing.Point(1036, 690)
        Me.RBClaro.Name = "RBClaro"
        Me.RBClaro.Size = New System.Drawing.Size(14, 13)
        Me.RBClaro.TabIndex = 16
        Me.RBClaro.TabStop = True
        Me.RBClaro.UseVisualStyleBackColor = True
        Me.RBClaro.Visible = False
        '
        'bAgregarMenu
        '
        Me.bAgregarMenu.BackgroundImage = Global.RestoBarGourmetV2.My.Resources.Resources.AgregarN
        Me.bAgregarMenu.FlatAppearance.BorderSize = 0
        Me.bAgregarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAgregarMenu.Location = New System.Drawing.Point(12, 592)
        Me.bAgregarMenu.Name = "bAgregarMenu"
        Me.bAgregarMenu.Size = New System.Drawing.Size(166, 32)
        Me.bAgregarMenu.TabIndex = 4
        Me.bAgregarMenu.UseVisualStyleBackColor = True
        '
        'Menues
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1062, 768)
        Me.Controls.Add(Me.RBOscuro)
        Me.Controls.Add(Me.RBClaro)
        Me.Controls.Add(Me.dgvMenues)
        Me.Controls.Add(Me.bAgregarMenu)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Menues"
        Me.Text = "Menues"
        CType(Me.dgvMenues, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvMenues As DataGridView
    Friend WithEvents bAgregarMenu As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents RBOscuro As RadioButton
    Friend WithEvents RBClaro As RadioButton
    Friend WithEvents dgvId As DataGridViewTextBoxColumn
    Friend WithEvents dgvDescripcion As DataGridViewTextBoxColumn
    Friend WithEvents dgvCosto_total As DataGridViewTextBoxColumn
    Friend WithEvents dgvPrecioFinal As DataGridViewTextBoxColumn
    Friend WithEvents dgvVerMenu As DataGridViewButtonColumn
    Friend WithEvents dgvEditar As DataGridViewButtonColumn
    Friend WithEvents dgvEliminar As DataGridViewButtonColumn
End Class
