<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgendaTelefonica
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgendaTelefonica))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DgvTelefonos = New System.Windows.Forms.DataGridView()
        Me.dgvId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvNumero_telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvEditar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.dgvEliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.RBOscuro = New System.Windows.Forms.RadioButton()
        Me.RBClaro = New System.Windows.Forms.RadioButton()
        Me.bAgregarTelefono = New System.Windows.Forms.Button()
        CType(Me.DgvTelefonos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Emoji", 21.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(258, 37)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Agenda telefonica"
        '
        'DgvTelefonos
        '
        Me.DgvTelefonos.AllowUserToAddRows = False
        Me.DgvTelefonos.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.DgvTelefonos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvTelefonos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvTelefonos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.DgvTelefonos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvTelefonos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.DgvTelefonos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Emoji", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvTelefonos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvTelefonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvTelefonos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvId, Me.dgvDescripcion, Me.dgvNumero_telefono, Me.dgvEditar, Me.dgvEliminar})
        Me.DgvTelefonos.Cursor = System.Windows.Forms.Cursors.Arrow
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvTelefonos.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgvTelefonos.EnableHeadersVisualStyles = False
        Me.DgvTelefonos.GridColor = System.Drawing.Color.DarkGray
        Me.DgvTelefonos.Location = New System.Drawing.Point(19, 104)
        Me.DgvTelefonos.Name = "DgvTelefonos"
        Me.DgvTelefonos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvTelefonos.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvTelefonos.RowHeadersVisible = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.DgvTelefonos.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DgvTelefonos.Size = New System.Drawing.Size(998, 465)
        Me.DgvTelefonos.TabIndex = 4
        '
        'dgvId
        '
        Me.dgvId.HeaderText = "ID"
        Me.dgvId.Name = "dgvId"
        Me.dgvId.Visible = False
        '
        'dgvDescripcion
        '
        Me.dgvDescripcion.FillWeight = 12.69035!
        Me.dgvDescripcion.HeaderText = "Descripcion"
        Me.dgvDescripcion.Name = "dgvDescripcion"
        '
        'dgvNumero_telefono
        '
        Me.dgvNumero_telefono.FillWeight = 12.69035!
        Me.dgvNumero_telefono.HeaderText = "Telefono"
        Me.dgvNumero_telefono.Name = "dgvNumero_telefono"
        '
        'dgvEditar
        '
        Me.dgvEditar.FillWeight = 12.69035!
        Me.dgvEditar.HeaderText = "Editar"
        Me.dgvEditar.Name = "dgvEditar"
        Me.dgvEditar.Text = "Editar"
        Me.dgvEditar.UseColumnTextForButtonValue = True
        '
        'dgvEliminar
        '
        Me.dgvEliminar.FillWeight = 12.69035!
        Me.dgvEliminar.HeaderText = "Eliminar"
        Me.dgvEliminar.Name = "dgvEliminar"
        Me.dgvEliminar.Text = "Eliminar"
        Me.dgvEliminar.UseColumnTextForButtonValue = True
        '
        'RBOscuro
        '
        Me.RBOscuro.AutoSize = True
        Me.RBOscuro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBOscuro.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RBOscuro.Location = New System.Drawing.Point(1036, 743)
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
        Me.RBClaro.Location = New System.Drawing.Point(1036, 695)
        Me.RBClaro.Name = "RBClaro"
        Me.RBClaro.Size = New System.Drawing.Size(14, 13)
        Me.RBClaro.TabIndex = 16
        Me.RBClaro.TabStop = True
        Me.RBClaro.UseVisualStyleBackColor = True
        Me.RBClaro.Visible = False
        '
        'bAgregarTelefono
        '
        Me.bAgregarTelefono.BackgroundImage = CType(resources.GetObject("bAgregarTelefono.BackgroundImage"), System.Drawing.Image)
        Me.bAgregarTelefono.FlatAppearance.BorderSize = 0
        Me.bAgregarTelefono.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAgregarTelefono.Location = New System.Drawing.Point(30, 603)
        Me.bAgregarTelefono.Name = "bAgregarTelefono"
        Me.bAgregarTelefono.Size = New System.Drawing.Size(166, 32)
        Me.bAgregarTelefono.TabIndex = 6
        Me.bAgregarTelefono.UseVisualStyleBackColor = True
        '
        'AgendaTelefonica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1062, 768)
        Me.Controls.Add(Me.RBOscuro)
        Me.Controls.Add(Me.RBClaro)
        Me.Controls.Add(Me.bAgregarTelefono)
        Me.Controls.Add(Me.DgvTelefonos)
        Me.Controls.Add(Me.Label2)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AgendaTelefonica"
        Me.Text = "AgendaTelefonica"
        CType(Me.DgvTelefonos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents DgvTelefonos As DataGridView
    Friend WithEvents bAgregarTelefono As Button
    Friend WithEvents RBOscuro As RadioButton
    Friend WithEvents RBClaro As RadioButton
    Friend WithEvents dgvId As DataGridViewTextBoxColumn
    Friend WithEvents dgvDescripcion As DataGridViewTextBoxColumn
    Friend WithEvents dgvNumero_telefono As DataGridViewTextBoxColumn
    Friend WithEvents dgvEditar As DataGridViewButtonColumn
    Friend WithEvents dgvEliminar As DataGridViewButtonColumn
End Class
