<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VAgregarMenu
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
        Me.dgvMenu = New System.Windows.Forms.DataGridView()
        Me.lCostoTotal = New System.Windows.Forms.Label()
        Me.tNombreMenu = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tValorVenta = New System.Windows.Forms.TextBox()
        Me.bCancelarMenu = New System.Windows.Forms.Button()
        Me.bAceptarMenu = New System.Windows.Forms.Button()
        Me.bAgregarIngrediente = New System.Windows.Forms.Button()
        Me.RBOscuro = New System.Windows.Forms.RadioButton()
        Me.RBClaro = New System.Windows.Forms.RadioButton()
        Me.dgvId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvId_menu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvId_mercaderia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvTipoUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvCosto_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvEditar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.dgvEliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.dgvMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvMenu
        '
        Me.dgvMenu.AllowUserToAddRows = False
        Me.dgvMenu.AllowUserToDeleteRows = False
        Me.dgvMenu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMenu.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.dgvMenu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMenu.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMenu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvId, Me.dgvId_menu, Me.dgvId_mercaderia, Me.dgvDescripcion, Me.dgvTipoUnidad, Me.dgvCantidad, Me.dgvCosto_total, Me.dgvEditar, Me.dgvEliminar})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMenu.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvMenu.EnableHeadersVisualStyles = False
        Me.dgvMenu.GridColor = System.Drawing.Color.DarkGray
        Me.dgvMenu.Location = New System.Drawing.Point(36, 75)
        Me.dgvMenu.Name = "dgvMenu"
        Me.dgvMenu.ReadOnly = True
        Me.dgvMenu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMenu.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvMenu.RowHeadersVisible = False
        Me.dgvMenu.Size = New System.Drawing.Size(745, 373)
        Me.dgvMenu.TabIndex = 7
        '
        'lCostoTotal
        '
        Me.lCostoTotal.AutoSize = True
        Me.lCostoTotal.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lCostoTotal.ForeColor = System.Drawing.Color.White
        Me.lCostoTotal.Location = New System.Drawing.Point(498, 465)
        Me.lCostoTotal.Name = "lCostoTotal"
        Me.lCostoTotal.Size = New System.Drawing.Size(46, 15)
        Me.lCostoTotal.TabIndex = 8
        Me.lCostoTotal.Text = "0000.00"
        '
        'tNombreMenu
        '
        Me.tNombreMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.tNombreMenu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tNombreMenu.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tNombreMenu.ForeColor = System.Drawing.Color.White
        Me.tNombreMenu.Location = New System.Drawing.Point(137, 467)
        Me.tNombreMenu.Name = "tNombreMenu"
        Me.tNombreMenu.Size = New System.Drawing.Size(166, 18)
        Me.tNombreMenu.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(50, 468)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 15)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Nombre Menú:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(420, 465)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Costo total:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(378, 491)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 15)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Valor de venta total:"
        '
        'tValorVenta
        '
        Me.tValorVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.tValorVenta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tValorVenta.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tValorVenta.ForeColor = System.Drawing.Color.White
        Me.tValorVenta.Location = New System.Drawing.Point(490, 490)
        Me.tValorVenta.Name = "tValorVenta"
        Me.tValorVenta.Size = New System.Drawing.Size(100, 18)
        Me.tValorVenta.TabIndex = 17
        '
        'bCancelarMenu
        '
        Me.bCancelarMenu.BackgroundImage = Global.RestoBarGourmetV2.My.Resources.Resources.CancelarN
        Me.bCancelarMenu.FlatAppearance.BorderSize = 0
        Me.bCancelarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCancelarMenu.Location = New System.Drawing.Point(595, 546)
        Me.bCancelarMenu.Name = "bCancelarMenu"
        Me.bCancelarMenu.Size = New System.Drawing.Size(166, 32)
        Me.bCancelarMenu.TabIndex = 12
        Me.bCancelarMenu.UseVisualStyleBackColor = True
        '
        'bAceptarMenu
        '
        Me.bAceptarMenu.BackgroundImage = Global.RestoBarGourmetV2.My.Resources.Resources.AceptarN
        Me.bAceptarMenu.FlatAppearance.BorderSize = 0
        Me.bAceptarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAceptarMenu.Location = New System.Drawing.Point(56, 546)
        Me.bAceptarMenu.Name = "bAceptarMenu"
        Me.bAceptarMenu.Size = New System.Drawing.Size(166, 32)
        Me.bAceptarMenu.TabIndex = 11
        Me.bAceptarMenu.UseVisualStyleBackColor = True
        '
        'bAgregarIngrediente
        '
        Me.bAgregarIngrediente.BackgroundImage = Global.RestoBarGourmetV2.My.Resources.Resources.AgregarIngredienteN
        Me.bAgregarIngrediente.FlatAppearance.BorderSize = 0
        Me.bAgregarIngrediente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAgregarIngrediente.Location = New System.Drawing.Point(36, 36)
        Me.bAgregarIngrediente.Name = "bAgregarIngrediente"
        Me.bAgregarIngrediente.Size = New System.Drawing.Size(166, 32)
        Me.bAgregarIngrediente.TabIndex = 6
        Me.bAgregarIngrediente.UseVisualStyleBackColor = True
        '
        'RBOscuro
        '
        Me.RBOscuro.AutoSize = True
        Me.RBOscuro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBOscuro.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RBOscuro.Location = New System.Drawing.Point(767, 520)
        Me.RBOscuro.Name = "RBOscuro"
        Me.RBOscuro.Size = New System.Drawing.Size(14, 13)
        Me.RBOscuro.TabIndex = 19
        Me.RBOscuro.TabStop = True
        Me.RBOscuro.UseVisualStyleBackColor = True
        Me.RBOscuro.Visible = False
        '
        'RBClaro
        '
        Me.RBClaro.AutoSize = True
        Me.RBClaro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBClaro.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RBClaro.Location = New System.Drawing.Point(767, 472)
        Me.RBClaro.Name = "RBClaro"
        Me.RBClaro.Size = New System.Drawing.Size(14, 13)
        Me.RBClaro.TabIndex = 18
        Me.RBClaro.TabStop = True
        Me.RBClaro.UseVisualStyleBackColor = True
        Me.RBClaro.Visible = False
        '
        'dgvId
        '
        Me.dgvId.HeaderText = "ID"
        Me.dgvId.Name = "dgvId"
        Me.dgvId.ReadOnly = True
        Me.dgvId.Visible = False
        '
        'dgvId_menu
        '
        Me.dgvId_menu.HeaderText = "id_menu"
        Me.dgvId_menu.Name = "dgvId_menu"
        Me.dgvId_menu.ReadOnly = True
        Me.dgvId_menu.Visible = False
        '
        'dgvId_mercaderia
        '
        Me.dgvId_mercaderia.HeaderText = "id_mercaderia"
        Me.dgvId_mercaderia.Name = "dgvId_mercaderia"
        Me.dgvId_mercaderia.ReadOnly = True
        Me.dgvId_mercaderia.Visible = False
        '
        'dgvDescripcion
        '
        Me.dgvDescripcion.HeaderText = "Descripcion"
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
        'dgvCantidad
        '
        Me.dgvCantidad.HeaderText = "Cantidad"
        Me.dgvCantidad.Name = "dgvCantidad"
        Me.dgvCantidad.ReadOnly = True
        '
        'dgvCosto_total
        '
        Me.dgvCosto_total.HeaderText = "Costo"
        Me.dgvCosto_total.Name = "dgvCosto_total"
        Me.dgvCosto_total.ReadOnly = True
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
        'VAgregarMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(793, 589)
        Me.Controls.Add(Me.RBOscuro)
        Me.Controls.Add(Me.RBClaro)
        Me.Controls.Add(Me.tValorVenta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tNombreMenu)
        Me.Controls.Add(Me.bCancelarMenu)
        Me.Controls.Add(Me.bAceptarMenu)
        Me.Controls.Add(Me.lCostoTotal)
        Me.Controls.Add(Me.dgvMenu)
        Me.Controls.Add(Me.bAgregarIngrediente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "VAgregarMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VAgregarMenu"
        CType(Me.dgvMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvMenu As DataGridView
    Friend WithEvents bAgregarIngrediente As Button
    Friend WithEvents lCostoTotal As Label
    Friend WithEvents bAceptarMenu As Button
    Friend WithEvents bCancelarMenu As Button
    Friend WithEvents tNombreMenu As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tValorVenta As TextBox
    Friend WithEvents RBOscuro As RadioButton
    Friend WithEvents RBClaro As RadioButton
    Friend WithEvents dgvId As DataGridViewTextBoxColumn
    Friend WithEvents dgvId_menu As DataGridViewTextBoxColumn
    Friend WithEvents dgvId_mercaderia As DataGridViewTextBoxColumn
    Friend WithEvents dgvDescripcion As DataGridViewTextBoxColumn
    Friend WithEvents dgvTipoUnidad As DataGridViewTextBoxColumn
    Friend WithEvents dgvCantidad As DataGridViewTextBoxColumn
    Friend WithEvents dgvCosto_total As DataGridViewTextBoxColumn
    Friend WithEvents dgvEditar As DataGridViewButtonColumn
    Friend WithEvents dgvEliminar As DataGridViewButtonColumn
End Class
