<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EntradaSalida
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvEyS = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cTipo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dDesde = New System.Windows.Forms.DateTimePicker()
        Me.dHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbFiltros = New System.Windows.Forms.CheckBox()
        Me.bBuscar = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RBOscuro = New System.Windows.Forms.RadioButton()
        Me.RBClaro = New System.Windows.Forms.RadioButton()
        Me.bImprimir = New System.Windows.Forms.Button()
        Me.dgvId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvHora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvValor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvMesa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvDetalle = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.dgvEliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.dgvEyS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Emoji", 21.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(252, 37)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Entradas y salidas"
        '
        'dgvEyS
        '
        Me.dgvEyS.AllowUserToAddRows = False
        Me.dgvEyS.AllowUserToDeleteRows = False
        Me.dgvEyS.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvEyS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEyS.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.dgvEyS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvEyS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.dgvEyS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEyS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvEyS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEyS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvId, Me.dgvDescripcion, Me.dgvFecha, Me.dgvHora, Me.dgvValor, Me.dgvMesa, Me.dgvDetalle, Me.dgvEliminar})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEyS.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvEyS.EnableHeadersVisualStyles = False
        Me.dgvEyS.GridColor = System.Drawing.Color.DarkGray
        Me.dgvEyS.Location = New System.Drawing.Point(32, 152)
        Me.dgvEyS.Name = "dgvEyS"
        Me.dgvEyS.ReadOnly = True
        Me.dgvEyS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEyS.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvEyS.RowHeadersVisible = False
        Me.dgvEyS.Size = New System.Drawing.Size(998, 465)
        Me.dgvEyS.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(352, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Activar filtros"
        '
        'cTipo
        '
        Me.cTipo.FormattingEnabled = True
        Me.cTipo.Items.AddRange(New Object() {"Todo", "venta", "Merma", "Compra"})
        Me.cTipo.Location = New System.Drawing.Point(540, 112)
        Me.cTipo.Name = "cTipo"
        Me.cTipo.Size = New System.Drawing.Size(121, 21)
        Me.cTipo.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(503, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Tipo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(736, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Desde:"
        '
        'dDesde
        '
        Me.dDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dDesde.Location = New System.Drawing.Point(783, 113)
        Me.dDesde.Name = "dDesde"
        Me.dDesde.Size = New System.Drawing.Size(91, 20)
        Me.dDesde.TabIndex = 10
        '
        'dHasta
        '
        Me.dHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dHasta.Location = New System.Drawing.Point(939, 113)
        Me.dHasta.Name = "dHasta"
        Me.dHasta.Size = New System.Drawing.Size(91, 20)
        Me.dHasta.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(895, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Hasta:"
        '
        'cbFiltros
        '
        Me.cbFiltros.AutoSize = True
        Me.cbFiltros.Location = New System.Drawing.Point(425, 83)
        Me.cbFiltros.Name = "cbFiltros"
        Me.cbFiltros.Size = New System.Drawing.Size(15, 14)
        Me.cbFiltros.TabIndex = 13
        Me.cbFiltros.UseVisualStyleBackColor = True
        '
        'bBuscar
        '
        Me.bBuscar.Location = New System.Drawing.Point(355, 113)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(75, 23)
        Me.bBuscar.TabIndex = 14
        Me.bBuscar.Text = "Refrescar"
        Me.bBuscar.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(355, 102)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(675, 44)
        Me.Panel1.TabIndex = 15
        '
        'RBOscuro
        '
        Me.RBOscuro.AutoSize = True
        Me.RBOscuro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBOscuro.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RBOscuro.Location = New System.Drawing.Point(1036, 746)
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
        Me.RBClaro.Location = New System.Drawing.Point(1036, 698)
        Me.RBClaro.Name = "RBClaro"
        Me.RBClaro.Size = New System.Drawing.Size(14, 13)
        Me.RBClaro.TabIndex = 16
        Me.RBClaro.TabStop = True
        Me.RBClaro.UseVisualStyleBackColor = True
        Me.RBClaro.Visible = False
        '
        'bImprimir
        '
        Me.bImprimir.BackColor = System.Drawing.Color.Transparent
        Me.bImprimir.BackgroundImage = Global.RestoBarGourmetV2.My.Resources.Resources.ImprimirN
        Me.bImprimir.FlatAppearance.BorderSize = 0
        Me.bImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bImprimir.Location = New System.Drawing.Point(864, 633)
        Me.bImprimir.Name = "bImprimir"
        Me.bImprimir.Size = New System.Drawing.Size(166, 32)
        Me.bImprimir.TabIndex = 5
        Me.bImprimir.UseVisualStyleBackColor = False
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
        'dgvFecha
        '
        Me.dgvFecha.HeaderText = "Fecha"
        Me.dgvFecha.Name = "dgvFecha"
        Me.dgvFecha.ReadOnly = True
        '
        'dgvHora
        '
        Me.dgvHora.HeaderText = "Hora"
        Me.dgvHora.Name = "dgvHora"
        Me.dgvHora.ReadOnly = True
        '
        'dgvValor
        '
        Me.dgvValor.HeaderText = "Valor"
        Me.dgvValor.Name = "dgvValor"
        Me.dgvValor.ReadOnly = True
        '
        'dgvMesa
        '
        Me.dgvMesa.HeaderText = "mesa"
        Me.dgvMesa.Name = "dgvMesa"
        Me.dgvMesa.ReadOnly = True
        Me.dgvMesa.Visible = False
        '
        'dgvDetalle
        '
        Me.dgvDetalle.HeaderText = "Ver Detalle"
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.ReadOnly = True
        Me.dgvDetalle.Text = "Ver Detalle"
        Me.dgvDetalle.ToolTipText = "Ver Detalle"
        Me.dgvDetalle.UseColumnTextForButtonValue = True
        '
        'dgvEliminar
        '
        Me.dgvEliminar.HeaderText = "Eliminar"
        Me.dgvEliminar.Name = "dgvEliminar"
        Me.dgvEliminar.ReadOnly = True
        Me.dgvEliminar.Text = "Eliminar"
        Me.dgvEliminar.ToolTipText = "Eliminar"
        Me.dgvEliminar.UseColumnTextForButtonValue = True
        '
        'EntradaSalida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1062, 768)
        Me.ControlBox = False
        Me.Controls.Add(Me.RBOscuro)
        Me.Controls.Add(Me.RBClaro)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.bBuscar)
        Me.Controls.Add(Me.cbFiltros)
        Me.Controls.Add(Me.dHasta)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dDesde)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cTipo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bImprimir)
        Me.Controls.Add(Me.dgvEyS)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EntradaSalida"
        Me.Text = "EntradaSalida"
        CType(Me.dgvEyS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents dgvEyS As DataGridView
    Friend WithEvents bImprimir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cTipo As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dDesde As DateTimePicker
    Friend WithEvents dHasta As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents cbFiltros As CheckBox
    Friend WithEvents bBuscar As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RBOscuro As RadioButton
    Friend WithEvents RBClaro As RadioButton
    Friend WithEvents dgvId As DataGridViewTextBoxColumn
    Friend WithEvents dgvDescripcion As DataGridViewTextBoxColumn
    Friend WithEvents dgvFecha As DataGridViewTextBoxColumn
    Friend WithEvents dgvHora As DataGridViewTextBoxColumn
    Friend WithEvents dgvValor As DataGridViewTextBoxColumn
    Friend WithEvents dgvMesa As DataGridViewTextBoxColumn
    Friend WithEvents dgvDetalle As DataGridViewButtonColumn
    Friend WithEvents dgvEliminar As DataGridViewButtonColumn
End Class
