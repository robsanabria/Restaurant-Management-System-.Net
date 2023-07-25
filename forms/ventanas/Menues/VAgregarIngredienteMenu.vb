Public Class VAgregarIngredienteMenu
    Public id As Integer
    Public Sub ObtenerDatos()
        Dim consulta As String = "select * from mercaderias"
        Dim lb As ListBox = New ListBox()
        lb.Items.Add(dgvId)
        lb.Items.Add(dgvDescripcion)
        lb.Items.Add(dgvTipoUnidad)
        lb.Items.Add(dgvCategoria)
        lb.Items.Add(dgvCantidad)
        lb.Items.Add(dgvCosto_unidad)

        MainClass.cargarDatos(consulta, dgvIngredientes, lb)
    End Sub

    Private Sub dgvIngredientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvIngredientes.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
        e.RowIndex >= 0 Then
            If senderGrid.Columns(e.ColumnIndex).Name = "dgvAgregar" Then
                Dim frm As VIngresarCantidadIngrediente = New VIngresarCantidadIngrediente()
                Dim descripcion As String = Convert.ToString(dgvIngredientes.CurrentRow.Cells("dgvDescripcion").Value)
                Dim tipoUnidad As String = Convert.ToString(dgvIngredientes.CurrentRow.Cells("dgvTipoUnidad").Value)
                frm.lIngrediente.Text = descripcion + " expresados en " + tipoUnidad
                frm.id_menu = Me.id
                frm.id_mercaderia = Convert.ToString(dgvIngredientes.CurrentRow.Cells("dgvId").Value)
                frm.descripcion = Convert.ToString(dgvIngredientes.CurrentRow.Cells("dgvDescripcion").Value)
                frm.tipo_unidad = Convert.ToString(dgvIngredientes.CurrentRow.Cells("dgvTipoUnidad").Value)
                frm.costo_unidad = Convert.ToString(dgvIngredientes.CurrentRow.Cells("dgvCosto_Unidad").Value)
                frm.categoria = Convert.ToString(dgvIngredientes.CurrentRow.Cells("dgvCategoria").Value)
                frm.esEditar = False
                frm.ShowDialog()
                ObtenerDatos()
                Me.Hide()

            End If
        End If

    End Sub

    Private Sub bCancelarIngrediente_Click(sender As Object, e As EventArgs) Handles bCancelarIngrediente.Click
        Me.Hide()
    End Sub

    Private Sub VAgregarIngredienteMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' RBClaro.Checked = My.Settings.Claro
        ' RBOscuro.Checked = My.Settings.Oscuro
        '
        ' If RBClaro.Checked = False Then
        '     CambiarTemaOscuro()
        ' ElseIf RBOscuro.Checked = True Then
        '     CambiarTemaOscuro()
        ' ElseIf RBClaro.Checked = True Then
        '     CambiarTemaClaro()
        ' ElseIf RBOscuro.Checked = False Then
        '     CambiarTemaOscuro()
        ' End If
        ObtenerDatos()
    End Sub
    '  Sub CambiarTemaClaro()
    '      Me.BackColor = Color.FromArgb(159, 159, 159)
    '      dgvIngredientes.BackgroundColor = Color.FromArgb(130, 130, 130)
    '      'bCancelarIngrediente
    '  End Sub
    '
    '  Sub CambiarTemaOscuro()
    '      Me.BackColor = Color.FromArgb(96, 96, 96)
    '      dgvIngredientes.BackgroundColor = Color.FromArgb(125, 125, 125)
    '      'bCancelarIngrediente
    '  End Sub


End Class