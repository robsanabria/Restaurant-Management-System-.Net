<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VVenta
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvVenta = New System.Windows.Forms.DataGridView()
        Me.dgvIdVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvId_fila_venta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvIdMenu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvCosto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvCostoTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvPrecioUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvPrecioTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvEliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.bCerrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lTotalPago = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tObservaciones = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lMesa = New System.Windows.Forms.Label()
        Me.cImprimir = New System.Windows.Forms.CheckBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.RBOscuro = New System.Windows.Forms.RadioButton()
        Me.RBClaro = New System.Windows.Forms.RadioButton()
        Me.bConcretarVenta = New System.Windows.Forms.Button()
        Me.bAgregarItem = New System.Windows.Forms.Button()
        Me.tPropina = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.b10 = New System.Windows.Forms.Button()
        Me.b15 = New System.Windows.Forms.Button()
        Me.b20 = New System.Windows.Forms.Button()
        Me.lTotal = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dgvVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvVenta
        '
        Me.dgvVenta.AllowUserToAddRows = False
        Me.dgvVenta.AllowUserToDeleteRows = False
        Me.dgvVenta.AllowUserToResizeColumns = False
        Me.dgvVenta.AllowUserToResizeRows = False
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White
        Me.dgvVenta.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvVenta.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.dgvVenta.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVenta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVenta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvIdVenta, Me.dgvId_fila_venta, Me.dgvIdMenu, Me.dgvDescripcion, Me.dgvCantidad, Me.dgvCosto, Me.dgvCostoTotal, Me.dgvPrecioUnitario, Me.dgvPrecioTotal, Me.dgvEliminar})
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvVenta.DefaultCellStyle = DataGridViewCellStyle13
        Me.dgvVenta.EnableHeadersVisualStyles = False
        Me.dgvVenta.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dgvVenta.Location = New System.Drawing.Point(14, 54)
        Me.dgvVenta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvVenta.Name = "dgvVenta"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVenta.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dgvVenta.RowHeadersVisible = False
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White
        Me.dgvVenta.RowsDefaultCellStyle = DataGridViewCellStyle15
        Me.dgvVenta.Size = New System.Drawing.Size(868, 438)
        Me.dgvVenta.TabIndex = 0
        '
        'dgvIdVenta
        '
        Me.dgvIdVenta.HeaderText = "idventa"
        Me.dgvIdVenta.Name = "dgvIdVenta"
        Me.dgvIdVenta.Visible = False
        '
        'dgvId_fila_venta
        '
        Me.dgvId_fila_venta.HeaderText = "idFilaVenta"
        Me.dgvId_fila_venta.Name = "dgvId_fila_venta"
        Me.dgvId_fila_venta.Visible = False
        '
        'dgvIdMenu
        '
        Me.dgvIdMenu.HeaderText = "idMenu"
        Me.dgvIdMenu.Name = "dgvIdMenu"
        Me.dgvIdMenu.Visible = False
        '
        'dgvDescripcion
        '
        Me.dgvDescripcion.HeaderText = "Descripcion"
        Me.dgvDescripcion.Name = "dgvDescripcion"
        '
        'dgvCantidad
        '
        Me.dgvCantidad.HeaderText = "Cantidad"
        Me.dgvCantidad.Name = "dgvCantidad"
        '
        'dgvCosto
        '
        Me.dgvCosto.HeaderText = "Costo"
        Me.dgvCosto.Name = "dgvCosto"
        '
        'dgvCostoTotal
        '
        Me.dgvCostoTotal.HeaderText = "Costo Total"
        Me.dgvCostoTotal.Name = "dgvCostoTotal"
        '
        'dgvPrecioUnitario
        '
        Me.dgvPrecioUnitario.HeaderText = "Precio Unitario"
        Me.dgvPrecioUnitario.Name = "dgvPrecioUnitario"
        '
        'dgvPrecioTotal
        '
        Me.dgvPrecioTotal.HeaderText = "Precio Total"
        Me.dgvPrecioTotal.Name = "dgvPrecioTotal"
        '
        'dgvEliminar
        '
        Me.dgvEliminar.HeaderText = "Eliminar"
        Me.dgvEliminar.Name = "dgvEliminar"
        Me.dgvEliminar.Text = "Eliminar"
        Me.dgvEliminar.ToolTipText = "Eliminar"
        Me.dgvEliminar.UseColumnTextForButtonValue = True
        '
        'bCerrar
        '
        Me.bCerrar.BackColor = System.Drawing.Color.Transparent
        Me.bCerrar.BackgroundImage = Global.RestoBarGourmetV2.My.Resources.Resources.CerrarBN
        Me.bCerrar.FlatAppearance.BorderSize = 0
        Me.bCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCerrar.Location = New System.Drawing.Point(14, 557)
        Me.bCerrar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bCerrar.Name = "bCerrar"
        Me.bCerrar.Size = New System.Drawing.Size(80, 32)
        Me.bCerrar.TabIndex = 2
        Me.bCerrar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(417, 529)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Total:"
        '
        'lTotalPago
        '
        Me.lTotalPago.AutoSize = True
        Me.lTotalPago.ForeColor = System.Drawing.Color.White
        Me.lTotalPago.Location = New System.Drawing.Point(621, 505)
        Me.lTotalPago.Name = "lTotalPago"
        Me.lTotalPago.Size = New System.Drawing.Size(15, 17)
        Me.lTotalPago.TabIndex = 5
        Me.lTotalPago.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(917, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Observaciones:"
        '
        'tObservaciones
        '
        Me.tObservaciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.tObservaciones.ForeColor = System.Drawing.Color.White
        Me.tObservaciones.Location = New System.Drawing.Point(920, 54)
        Me.tObservaciones.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tObservaciones.Multiline = True
        Me.tObservaciones.Name = "tObservaciones"
        Me.tObservaciones.Size = New System.Drawing.Size(306, 437)
        Me.tObservaciones.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(232, 505)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Mesa:"
        '
        'lMesa
        '
        Me.lMesa.AutoSize = True
        Me.lMesa.ForeColor = System.Drawing.Color.White
        Me.lMesa.Location = New System.Drawing.Point(281, 505)
        Me.lMesa.Name = "lMesa"
        Me.lMesa.Size = New System.Drawing.Size(46, 17)
        Me.lMesa.TabIndex = 9
        Me.lMesa.Text = "Label4"
        '
        'cImprimir
        '
        Me.cImprimir.AutoSize = True
        Me.cImprimir.ForeColor = System.Drawing.Color.White
        Me.cImprimir.Location = New System.Drawing.Point(671, 562)
        Me.cImprimir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cImprimir.Name = "cImprimir"
        Me.cImprimir.Size = New System.Drawing.Size(76, 21)
        Me.cImprimir.TabIndex = 10
        Me.cImprimir.Text = "Imprimir"
        Me.cImprimir.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'RBOscuro
        '
        Me.RBOscuro.AutoSize = True
        Me.RBOscuro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBOscuro.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RBOscuro.Location = New System.Drawing.Point(1223, 583)
        Me.RBOscuro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
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
        Me.RBClaro.Location = New System.Drawing.Point(1223, 520)
        Me.RBClaro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RBClaro.Name = "RBClaro"
        Me.RBClaro.Size = New System.Drawing.Size(14, 13)
        Me.RBClaro.TabIndex = 16
        Me.RBClaro.TabStop = True
        Me.RBClaro.UseVisualStyleBackColor = True
        Me.RBClaro.Visible = False
        '
        'bConcretarVenta
        '
        Me.bConcretarVenta.BackColor = System.Drawing.Color.Transparent
        Me.bConcretarVenta.BackgroundImage = Global.RestoBarGourmetV2.My.Resources.Resources.ConcretarVentaN
        Me.bConcretarVenta.FlatAppearance.BorderSize = 0
        Me.bConcretarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bConcretarVenta.Location = New System.Drawing.Point(470, 557)
        Me.bConcretarVenta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bConcretarVenta.Name = "bConcretarVenta"
        Me.bConcretarVenta.Size = New System.Drawing.Size(166, 32)
        Me.bConcretarVenta.TabIndex = 3
        Me.bConcretarVenta.UseVisualStyleBackColor = False
        '
        'bAgregarItem
        '
        Me.bAgregarItem.BackColor = System.Drawing.Color.Transparent
        Me.bAgregarItem.BackgroundImage = Global.RestoBarGourmetV2.My.Resources.Resources.AgregarChiquitoN
        Me.bAgregarItem.FlatAppearance.BorderSize = 0
        Me.bAgregarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAgregarItem.Location = New System.Drawing.Point(14, 16)
        Me.bAgregarItem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bAgregarItem.Name = "bAgregarItem"
        Me.bAgregarItem.Size = New System.Drawing.Size(80, 32)
        Me.bAgregarItem.TabIndex = 1
        Me.bAgregarItem.UseVisualStyleBackColor = False
        '
        'tPropina
        '
        Me.tPropina.Location = New System.Drawing.Point(188, 560)
        Me.tPropina.Name = "tPropina"
        Me.tPropina.Size = New System.Drawing.Size(104, 25)
        Me.tPropina.TabIndex = 18
        Me.tPropina.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(131, 564)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 17)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Propina:"
        '
        'b10
        '
        Me.b10.Location = New System.Drawing.Point(298, 560)
        Me.b10.Name = "b10"
        Me.b10.Size = New System.Drawing.Size(42, 23)
        Me.b10.TabIndex = 20
        Me.b10.Text = "10%"
        Me.b10.UseVisualStyleBackColor = True
        '
        'b15
        '
        Me.b15.Location = New System.Drawing.Point(346, 560)
        Me.b15.Name = "b15"
        Me.b15.Size = New System.Drawing.Size(42, 23)
        Me.b15.TabIndex = 21
        Me.b15.Text = "15%"
        Me.b15.UseVisualStyleBackColor = True
        '
        'b20
        '
        Me.b20.Location = New System.Drawing.Point(394, 560)
        Me.b20.Name = "b20"
        Me.b20.Size = New System.Drawing.Size(42, 23)
        Me.b20.TabIndex = 22
        Me.b20.Text = "20%"
        Me.b20.UseVisualStyleBackColor = True
        '
        'lTotal
        '
        Me.lTotal.AutoSize = True
        Me.lTotal.ForeColor = System.Drawing.Color.White
        Me.lTotal.Location = New System.Drawing.Point(621, 529)
        Me.lTotal.Name = "lTotal"
        Me.lTotal.Size = New System.Drawing.Size(15, 17)
        Me.lTotal.TabIndex = 24
        Me.lTotal.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(417, 505)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 17)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Sub total:"
        '
        'VVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1253, 603)
        Me.Controls.Add(Me.lTotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.b20)
        Me.Controls.Add(Me.b15)
        Me.Controls.Add(Me.b10)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tPropina)
        Me.Controls.Add(Me.RBOscuro)
        Me.Controls.Add(Me.RBClaro)
        Me.Controls.Add(Me.cImprimir)
        Me.Controls.Add(Me.lMesa)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tObservaciones)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lTotalPago)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bConcretarVenta)
        Me.Controls.Add(Me.bCerrar)
        Me.Controls.Add(Me.bAgregarItem)
        Me.Controls.Add(Me.dgvVenta)
        Me.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "VVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VVenta"
        CType(Me.dgvVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvVenta As DataGridView
    Friend WithEvents bAgregarItem As Button
    Friend WithEvents bCerrar As Button
    Friend WithEvents bConcretarVenta As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lTotalPago As Label
    Friend WithEvents dgvIdVenta As DataGridViewTextBoxColumn
    Friend WithEvents dgvId_fila_venta As DataGridViewTextBoxColumn
    Friend WithEvents dgvIdMenu As DataGridViewTextBoxColumn
    Friend WithEvents dgvDescripcion As DataGridViewTextBoxColumn
    Friend WithEvents dgvCantidad As DataGridViewTextBoxColumn
    Friend WithEvents dgvCosto As DataGridViewTextBoxColumn
    Friend WithEvents dgvCostoTotal As DataGridViewTextBoxColumn
    Friend WithEvents dgvPrecioUnitario As DataGridViewTextBoxColumn
    Friend WithEvents dgvPrecioTotal As DataGridViewTextBoxColumn
    Friend WithEvents dgvEliminar As DataGridViewButtonColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents tObservaciones As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lMesa As Label
    Friend WithEvents cImprimir As CheckBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents RBOscuro As RadioButton
    Friend WithEvents RBClaro As RadioButton
    Friend WithEvents tPropina As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents b10 As Button
    Friend WithEvents b15 As Button
    Friend WithEvents b20 As Button
    Friend WithEvents lTotal As Label
    Friend WithEvents Label6 As Label
End Class
