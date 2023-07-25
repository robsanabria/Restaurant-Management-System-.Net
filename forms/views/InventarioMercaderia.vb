Public Class InventarioMercaderia

    Private Sub InventarioMercaderia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  RBClaro.Checked = My.Settings.Claro
        '  RBOscuro.Checked = My.Settings.Oscuro
        '
        '  If RBClaro.Checked = False Then
        '      CambiarTemaOscuro()
        '  ElseIf RBOscuro.Checked = True Then
        '      CambiarTemaOscuro()
        '  ElseIf RBClaro.Checked = True Then
        '      CambiarTemaClaro()
        '  ElseIf RBOscuro.Checked = False Then
        '      CambiarTemaOscuro()
        '  End If

        ObtenerDatos()
    End Sub
    '   Sub CambiarTemaClaro()
    '       Me.BackColor = Color.FromArgb(223, 223, 223)
    '       Label2.ForeColor = Color.Black
    '       dgvMercaderias.BackgroundColor = Color.FromArgb(212, 212, 212)
    '       'bAgregaraMercaderia
    '       Button5.Image = My.Resources.minimizarB
    '       Button6.Image = My.Resources.maximizarB
    '       Button7.Image = My.Resources.cerrarB
    '   End Sub
    '
    '   Sub CambiarTemaOscuro()
    '       Me.BackColor = Color.FromArgb(32, 32, 32)
    '       Label2.ForeColor = Color.White
    '       dgvMercaderias.BackgroundColor = Color.FromArgb(43, 43, 43)
    '       'bAgregaraMercaderia
    '       Button5.Image = My.Resources.minimizarN
    '       Button6.Image = My.Resources.maximizarN
    '       Button7.Image = My.Resources.cerrarN
    '   End Sub

    Public Sub ObtenerDatos()
        Dim consulta As String = "select * from mercaderias"
        Dim lb As ListBox = New ListBox()
        lb.Items.Add(dgvId)
        lb.Items.Add(dgvDescripcion)
        lb.Items.Add(dgvTipoUnidad)
        lb.Items.Add(dgvCategoria)
        lb.Items.Add(dgvCantidad)
        lb.Items.Add(dgvCosto_unidad)
        lb.Items.Add(dgvCosto_total)

        MainClass.cargarDatos(consulta, dgvMercaderias, lb)
    End Sub

    Private Sub bAgregarMercaderia_Click(sender As Object, e As EventArgs) Handles bAgregarMercaderia.Click

        Dim frm As VAgregarMercaderia = New VAgregarMercaderia()

        frm.ShowDialog()

        ObtenerDatos()
    End Sub

    Private Sub dgvMercaderias_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMercaderias.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
        e.RowIndex >= 0 Then
            If senderGrid.Columns(e.ColumnIndex).Name = "dgvEditar" Then
                Dim frm As VAgregarMercaderia = New VAgregarMercaderia()

                frm.id = Convert.ToInt32(dgvMercaderias.CurrentRow.Cells("dgvId").Value)
                frm.tDescripcionMercaderia.Text = Convert.ToString(dgvMercaderias.CurrentRow.Cells("dgvDescripcion").Value)
                frm.tCantidadMercaderia.Text = Convert.ToString(dgvMercaderias.CurrentRow.Cells("dgvCantidad").Value)
                frm.tCosto_unitarioMercaderia.Text = Convert.ToString(dgvMercaderias.CurrentRow.Cells("dgvCosto_Unidad").Value)
                frm.cmbCategoriaMercaderia.SelectedItem = Convert.ToString(dgvMercaderias.CurrentRow.Cells("dgvCategoria").Value)
                frm.cmbTipo_unidadMercaderia.SelectedItem = Convert.ToString(dgvMercaderias.CurrentRow.Cells("dgvTipoUnidad").Value)
                frm.cantidadVieja = Convert.ToDouble(dgvMercaderias.CurrentRow.Cells("dgvCantidad").Value)
                frm.ShowDialog()
                ObtenerDatos()

            End If
            If senderGrid.Columns(e.ColumnIndex).Name = "dgvEliminar" Then

                Dim descripcion As String = Convert.ToString(dgvMercaderias.CurrentRow.Cells("dgvDescripcion").Value)
                Dim id As String = Convert.ToString(dgvMercaderias.CurrentRow.Cells("dgvId").Value)
                If MessageBox.Show("Está por ELIMINAR definitivamente a la Mercadería: " & descripcion, "Eliminar Mercadería", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
                Dim consulta As String = "delete from mercaderias where id_mercaderia='" + id + "'"
                Dim consulta2 As String = "delete from fila_menu where id_alimento='" + id + "'"
                Dim ht As Hashtable = New Hashtable()

                MainClass.SQL(consulta, ht)
                MainClass.SQL(consulta2, ht)
                ObtenerDatos()
                MessageBox.Show("Se ha eliminado a la mercadería " + descripcion + " Correctamente")


            End If
            If senderGrid.Columns(e.ColumnIndex).Name = "dgvMermaCompra" Then
                Dim frm As MermaCompra = New MermaCompra()

                frm.id = Convert.ToString(dgvMercaderias.CurrentRow.Cells("dgvId").Value)
                frm.lDescripcion.Text = Convert.ToString(dgvMercaderias.CurrentRow.Cells("dgvDescripcion").Value)
                frm.costoUnitario = Convert.ToString(dgvMercaderias.CurrentRow.Cells("dgvCosto_Unidad").Value)
                frm.mercaderiaUtil = "mercaderia"
                frm.ShowDialog()
                ObtenerDatos()

            End If
        End If

    End Sub


End Class