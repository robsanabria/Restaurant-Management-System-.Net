Public Class InventarioUtiles

    Private Sub InventarioUtiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        '
        ObtenerDatos()
    End Sub

    '  Sub CambiarTemaClaro()
    '      Me.BackColor = Color.FromArgb(223, 223, 223)
    '      Label2.ForeColor = Color.Black
    '      'bAgregarUtil
    '      dgvUtiles.BackgroundColor = Color.FromArgb(212, 212, 212)
    '      Button5.Image = My.Resources.minimizarB
    '      Button6.Image = My.Resources.maximizarB
    '      Button7.Image = My.Resources.cerrarB
    '  End Sub
    '
    '  Sub CambiarTemaOscuro()
    '      Me.BackColor = Color.FromArgb(32, 32, 32)
    '      Label2.ForeColor = Color.White
    '      'bAgregarUtil
    '      dgvUtiles.BackgroundColor = Color.FromArgb(43, 43, 43)
    '      Button5.Image = My.Resources.minimizarN
    '      Button6.Image = My.Resources.maximizarN
    '      Button7.Image = My.Resources.cerrarN
    '  End Sub

    Public Sub ObtenerDatos()
        Dim consulta As String = "select * from Utiles"
        Dim lb As ListBox = New ListBox()
        lb.Items.Add(dgvId)
        lb.Items.Add(dgvDescripcion)
        lb.Items.Add(dgvCantidad)
        lb.Items.Add(dgvCosto_unidad)
        lb.Items.Add(dgvCosto_total)

        MainClass.cargarDatos(consulta, dgvUtiles, lb)
    End Sub
    Private Sub bAgregarUtil_Click(sender As Object, e As EventArgs) Handles bAgregarUtil.Click

        Dim frm As VAgregarUtiles = New VAgregarUtiles()
        frm.ShowDialog()
        ObtenerDatos()
    End Sub

    Private Sub dgvUtiles_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUtiles.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
         e.RowIndex >= 0 Then
            If senderGrid.Columns(e.ColumnIndex).Name = "dgvEditar" Then
                Dim frm As VAgregarUtiles = New VAgregarUtiles()

                frm.id = Convert.ToInt32(dgvUtiles.CurrentRow.Cells("dgvID").Value)
                frm.tDescripcionUtiles.Text = Convert.ToString(dgvUtiles.CurrentRow.Cells("dgvDescripcion").Value)
                frm.tCantidadUtiles.Text = Convert.ToString(dgvUtiles.CurrentRow.Cells("dgvCantidad").Value)
                frm.tCosto_unitarioUtiles.Text = Convert.ToString(dgvUtiles.CurrentRow.Cells("dgvCosto_Unidad").Value)
                frm.cantidadVieja = Convert.ToDouble(dgvUtiles.CurrentRow.Cells("dgvCantidad").Value)
                frm.ShowDialog()
                ObtenerDatos()

            End If
            If senderGrid.Columns(e.ColumnIndex).Name = "dgvEliminar" Then

                Dim descripcion As String = Convert.ToString(dgvUtiles.CurrentRow.Cells("dgvDescripcion").Value)
                Dim id As String = Convert.ToString(dgvUtiles.CurrentRow.Cells("dgvID").Value)
                If MessageBox.Show("Está por ELIMINAR definitivamente el Util : " & descripcion, "Eliminar Util", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
                Dim consulta As String = "delete from Utiles where id_util='" + id + "'"

                Dim ht As Hashtable = New Hashtable()

                MainClass.SQL(consulta, ht)
                ObtenerDatos()
                MessageBox.Show("Se ha eliminado la utilidad " + descripcion + " Correctamente")


            End If
            If senderGrid.Columns(e.ColumnIndex).Name = "dgvMermaCompra" Then
                Dim frm As MermaCompra = New MermaCompra()

                frm.id = Convert.ToString(dgvUtiles.CurrentRow.Cells("dgvId").Value)
                frm.lDescripcion.Text = Convert.ToString(dgvUtiles.CurrentRow.Cells("dgvDescripcion").Value)
                frm.costoUnitario = Convert.ToString(dgvUtiles.CurrentRow.Cells("dgvCosto_Unidad").Value)
                frm.mercaderiaUtil = "util"
                frm.ShowDialog()
                ObtenerDatos()

            End If
        End If
    End Sub
End Class