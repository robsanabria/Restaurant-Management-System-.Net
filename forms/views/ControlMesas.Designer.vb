<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ControlMesas
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
        Me.dgvMesas = New System.Windows.Forms.DataGridView()
        Me.dgvId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvNumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvCant_sillas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvId_venta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvVenta = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.dgvReserva = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.dgvEditar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.dgvEliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.RBOscuro = New System.Windows.Forms.RadioButton()
        Me.RBClaro = New System.Windows.Forms.RadioButton()
        Me.bAgregar = New System.Windows.Forms.Button()
        CType(Me.dgvMesas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Emoji", 21.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(248, 37)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Control de mesas"
        '
        'dgvMesas
        '
        Me.dgvMesas.AllowUserToAddRows = False
        Me.dgvMesas.AllowUserToDeleteRows = False
        Me.dgvMesas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMesas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMesas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.dgvMesas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvMesas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.dgvMesas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMesas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMesas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvId, Me.dgvNumero, Me.dgvCant_sillas, Me.dgvEstado, Me.dgvId_venta, Me.dgvVenta, Me.dgvReserva, Me.dgvEditar, Me.dgvEliminar})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMesas.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvMesas.EnableHeadersVisualStyles = False
        Me.dgvMesas.GridColor = System.Drawing.Color.DarkGray
        Me.dgvMesas.Location = New System.Drawing.Point(12, 104)
        Me.dgvMesas.Name = "dgvMesas"
        Me.dgvMesas.ReadOnly = True
        Me.dgvMesas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMesas.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvMesas.RowHeadersVisible = False
        Me.dgvMesas.Size = New System.Drawing.Size(998, 465)
        Me.dgvMesas.TabIndex = 4
        '
        'dgvId
        '
        Me.dgvId.HeaderText = "ID"
        Me.dgvId.Name = "dgvId"
        Me.dgvId.ReadOnly = True
        Me.dgvId.Visible = False
        '
        'dgvNumero
        '
        Me.dgvNumero.FillWeight = 41.7694!
        Me.dgvNumero.HeaderText = "Número"
        Me.dgvNumero.Name = "dgvNumero"
        Me.dgvNumero.ReadOnly = True
        Me.dgvNumero.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'dgvCant_sillas
        '
        Me.dgvCant_sillas.FillWeight = 41.7694!
        Me.dgvCant_sillas.HeaderText = "Cantidad de sillas"
        Me.dgvCant_sillas.Name = "dgvCant_sillas"
        Me.dgvCant_sillas.ReadOnly = True
        '
        'dgvEstado
        '
        Me.dgvEstado.FillWeight = 41.7694!
        Me.dgvEstado.HeaderText = "Estado"
        Me.dgvEstado.Name = "dgvEstado"
        Me.dgvEstado.ReadOnly = True
        '
        'dgvId_venta
        '
        Me.dgvId_venta.HeaderText = "idVenta"
        Me.dgvId_venta.Name = "dgvId_venta"
        Me.dgvId_venta.ReadOnly = True
        Me.dgvId_venta.Visible = False
        '
        'dgvVenta
        '
        Me.dgvVenta.FillWeight = 41.7694!
        Me.dgvVenta.HeaderText = "Venta"
        Me.dgvVenta.Name = "dgvVenta"
        Me.dgvVenta.ReadOnly = True
        Me.dgvVenta.Text = "Venta"
        Me.dgvVenta.UseColumnTextForButtonValue = True
        '
        'dgvReserva
        '
        Me.dgvReserva.FillWeight = 41.7694!
        Me.dgvReserva.HeaderText = "Reservas"
        Me.dgvReserva.Name = "dgvReserva"
        Me.dgvReserva.ReadOnly = True
        Me.dgvReserva.Text = "Reservas"
        Me.dgvReserva.UseColumnTextForButtonValue = True
        '
        'dgvEditar
        '
        Me.dgvEditar.FillWeight = 41.7694!
        Me.dgvEditar.HeaderText = "Editar"
        Me.dgvEditar.Name = "dgvEditar"
        Me.dgvEditar.ReadOnly = True
        Me.dgvEditar.Text = "Editar"
        Me.dgvEditar.UseColumnTextForButtonValue = True
        '
        'dgvEliminar
        '
        Me.dgvEliminar.FillWeight = 41.7694!
        Me.dgvEliminar.HeaderText = "Eliminar"
        Me.dgvEliminar.Name = "dgvEliminar"
        Me.dgvEliminar.ReadOnly = True
        Me.dgvEliminar.Text = "Eliminar"
        Me.dgvEliminar.UseColumnTextForButtonValue = True
        '
        'RBOscuro
        '
        Me.RBOscuro.AutoSize = True
        Me.RBOscuro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBOscuro.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RBOscuro.Location = New System.Drawing.Point(1036, 739)
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
        Me.RBClaro.Location = New System.Drawing.Point(1036, 691)
        Me.RBClaro.Name = "RBClaro"
        Me.RBClaro.Size = New System.Drawing.Size(14, 13)
        Me.RBClaro.TabIndex = 16
        Me.RBClaro.TabStop = True
        Me.RBClaro.UseVisualStyleBackColor = True
        Me.RBClaro.Visible = False
        '
        'bAgregar
        '
        Me.bAgregar.BackColor = System.Drawing.Color.Transparent
        Me.bAgregar.BackgroundImage = Global.RestoBarGourmetV2.My.Resources.Resources.AgregarMesaN
        Me.bAgregar.FlatAppearance.BorderSize = 0
        Me.bAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAgregar.Location = New System.Drawing.Point(12, 585)
        Me.bAgregar.Name = "bAgregar"
        Me.bAgregar.Size = New System.Drawing.Size(166, 32)
        Me.bAgregar.TabIndex = 6
        Me.bAgregar.UseVisualStyleBackColor = False
        '
        'ControlMesas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1062, 768)
        Me.Controls.Add(Me.RBOscuro)
        Me.Controls.Add(Me.RBClaro)
        Me.Controls.Add(Me.bAgregar)
        Me.Controls.Add(Me.dgvMesas)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ControlMesas"
        Me.Text = "ControlMesas"
        CType(Me.dgvMesas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents dgvMesas As DataGridView
    Friend WithEvents bAgregar As Button
    Friend WithEvents RBOscuro As RadioButton
    Friend WithEvents RBClaro As RadioButton
    Friend WithEvents dgvId As DataGridViewTextBoxColumn
    Friend WithEvents dgvNumero As DataGridViewTextBoxColumn
    Friend WithEvents dgvCant_sillas As DataGridViewTextBoxColumn
    Friend WithEvents dgvEstado As DataGridViewTextBoxColumn
    Friend WithEvents dgvId_venta As DataGridViewTextBoxColumn
    Friend WithEvents dgvVenta As DataGridViewButtonColumn
    Friend WithEvents dgvReserva As DataGridViewButtonColumn
    Friend WithEvents dgvEditar As DataGridViewButtonColumn
    Friend WithEvents dgvEliminar As DataGridViewButtonColumn
End Class
