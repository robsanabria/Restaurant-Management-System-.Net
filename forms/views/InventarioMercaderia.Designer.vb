<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InventarioMercaderia
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
        Me.dgvMercaderias = New System.Windows.Forms.DataGridView()
        Me.dgvId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvTipoUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvCosto_unidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvCosto_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvMermaCompra = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.dgvEditar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.dgvEliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RBOscuro = New System.Windows.Forms.RadioButton()
        Me.RBClaro = New System.Windows.Forms.RadioButton()
        Me.bAgregarMercaderia = New System.Windows.Forms.Button()
        CType(Me.dgvMercaderias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvMercaderias
        '
        Me.dgvMercaderias.AllowUserToAddRows = False
        Me.dgvMercaderias.AllowUserToDeleteRows = False
        Me.dgvMercaderias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMercaderias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMercaderias.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.dgvMercaderias.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvMercaderias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.dgvMercaderias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMercaderias.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMercaderias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMercaderias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvId, Me.dgvDescripcion, Me.dgvTipoUnidad, Me.dgvCategoria, Me.dgvCantidad, Me.dgvCosto_unidad, Me.dgvCosto_total, Me.dgvMermaCompra, Me.dgvEditar, Me.dgvEliminar})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMercaderias.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvMercaderias.EnableHeadersVisualStyles = False
        Me.dgvMercaderias.GridColor = System.Drawing.Color.DarkGray
        Me.dgvMercaderias.Location = New System.Drawing.Point(12, 104)
        Me.dgvMercaderias.Name = "dgvMercaderias"
        Me.dgvMercaderias.ReadOnly = True
        Me.dgvMercaderias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMercaderias.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvMercaderias.RowHeadersVisible = False
        Me.dgvMercaderias.Size = New System.Drawing.Size(1038, 465)
        Me.dgvMercaderias.TabIndex = 3
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
        Me.dgvDescripcion.HeaderText = "Descripción"
        Me.dgvDescripcion.Name = "dgvDescripcion"
        Me.dgvDescripcion.ReadOnly = True
        Me.dgvDescripcion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'dgvTipoUnidad
        '
        Me.dgvTipoUnidad.HeaderText = "Tipo de unidad"
        Me.dgvTipoUnidad.Name = "dgvTipoUnidad"
        Me.dgvTipoUnidad.ReadOnly = True
        '
        'dgvCategoria
        '
        Me.dgvCategoria.HeaderText = "Categoría"
        Me.dgvCategoria.Name = "dgvCategoria"
        Me.dgvCategoria.ReadOnly = True
        '
        'dgvCantidad
        '
        Me.dgvCantidad.HeaderText = "Cantidad"
        Me.dgvCantidad.Name = "dgvCantidad"
        Me.dgvCantidad.ReadOnly = True
        '
        'dgvCosto_unidad
        '
        Me.dgvCosto_unidad.HeaderText = "Costo por unidad"
        Me.dgvCosto_unidad.Name = "dgvCosto_unidad"
        Me.dgvCosto_unidad.ReadOnly = True
        '
        'dgvCosto_total
        '
        Me.dgvCosto_total.HeaderText = "Costo total"
        Me.dgvCosto_total.Name = "dgvCosto_total"
        Me.dgvCosto_total.ReadOnly = True
        '
        'dgvMermaCompra
        '
        Me.dgvMermaCompra.HeaderText = "Merma / Compra"
        Me.dgvMermaCompra.Name = "dgvMermaCompra"
        Me.dgvMermaCompra.ReadOnly = True
        Me.dgvMermaCompra.Text = "Merma / Compra"
        Me.dgvMermaCompra.ToolTipText = "Merma / Compra"
        Me.dgvMermaCompra.UseColumnTextForButtonValue = True
        '
        'dgvEditar
        '
        Me.dgvEditar.HeaderText = "Editar"
        Me.dgvEditar.Name = "dgvEditar"
        Me.dgvEditar.ReadOnly = True
        Me.dgvEditar.Text = "Editar"
        Me.dgvEditar.UseColumnTextForButtonValue = True
        '
        'dgvEliminar
        '
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
        Me.Label2.Size = New System.Drawing.Size(272, 37)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Control mercaderia"
        '
        'RBOscuro
        '
        Me.RBOscuro.AutoSize = True
        Me.RBOscuro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBOscuro.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RBOscuro.Location = New System.Drawing.Point(1036, 744)
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
        Me.RBClaro.Location = New System.Drawing.Point(1036, 696)
        Me.RBClaro.Name = "RBClaro"
        Me.RBClaro.Size = New System.Drawing.Size(14, 13)
        Me.RBClaro.TabIndex = 16
        Me.RBClaro.TabStop = True
        Me.RBClaro.UseVisualStyleBackColor = True
        Me.RBClaro.Visible = False
        '
        'bAgregarMercaderia
        '
        Me.bAgregarMercaderia.BackgroundImage = Global.RestoBarGourmetV2.My.Resources.Resources.AgregarN
        Me.bAgregarMercaderia.FlatAppearance.BorderSize = 0
        Me.bAgregarMercaderia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAgregarMercaderia.Location = New System.Drawing.Point(12, 592)
        Me.bAgregarMercaderia.Name = "bAgregarMercaderia"
        Me.bAgregarMercaderia.Size = New System.Drawing.Size(166, 32)
        Me.bAgregarMercaderia.TabIndex = 0
        Me.bAgregarMercaderia.UseVisualStyleBackColor = True
        '
        'InventarioMercaderia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1062, 768)
        Me.Controls.Add(Me.RBOscuro)
        Me.Controls.Add(Me.RBClaro)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvMercaderias)
        Me.Controls.Add(Me.bAgregarMercaderia)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "InventarioMercaderia"
        Me.Text = "InventarioMercaderia"
        CType(Me.dgvMercaderias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bAgregarMercaderia As Button
    Friend WithEvents dgvMercaderias As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvId As DataGridViewTextBoxColumn
    Friend WithEvents dgvDescripcion As DataGridViewTextBoxColumn
    Friend WithEvents dgvTipoUnidad As DataGridViewTextBoxColumn
    Friend WithEvents dgvCategoria As DataGridViewTextBoxColumn
    Friend WithEvents dgvCantidad As DataGridViewTextBoxColumn
    Friend WithEvents dgvCosto_unidad As DataGridViewTextBoxColumn
    Friend WithEvents dgvCosto_total As DataGridViewTextBoxColumn
    Friend WithEvents dgvMermaCompra As DataGridViewButtonColumn
    Friend WithEvents dgvEditar As DataGridViewButtonColumn
    Friend WithEvents dgvEliminar As DataGridViewButtonColumn
    Friend WithEvents RBOscuro As RadioButton
    Friend WithEvents RBClaro As RadioButton
End Class
