Public Class Menues
    Private Sub Menues_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        Me.ObtenerDatos()
    End Sub

    '  Sub CambiarTemaClaro()
    '      Me.BackColor = Color.FromArgb(223, 223, 223)
    '      Label2.ForeColor = Color.Black
    '      'bAgregarMenu
    '      dgvMenues.BackgroundColor = Color.FromArgb(212, 212, 212)
    '      Button5.Image = My.Resources.minimizarB
    '      Button6.Image = My.Resources.maximizarB
    '      Button7.Image = My.Resources.cerrarB
    '  End Sub
    '
    '  Sub CambiarTemaOscuro()
    '      Me.BackColor = Color.FromArgb(32, 32, 32)
    '      Label2.ForeColor = Color.White
    '      'bAgregarMenu
    '      dgvMenues.BackgroundColor = Color.FromArgb(43, 43, 43)
    '      Button5.Image = My.Resources.minimizarN
    '      Button6.Image = My.Resources.maximizarN
    '      Button7.Image = My.Resources.cerrarN
    '  End Sub

    Public Sub ObtenerDatos()
        Dim consulta As String = "select * from menues"
        Dim lb As ListBox = New ListBox()
        lb.Items.Add(dgvId)
        lb.Items.Add(dgvDescripcion)
        lb.Items.Add(dgvCosto_total)
        lb.Items.Add(dgvPrecioFinal)

        MainClass.cargarDatos(consulta, dgvMenues, lb)
    End Sub

    Private Sub bAgregarMenu_Click(sender As Object, e As EventArgs) Handles bAgregarMenu.Click
        Dim frm As VAgregarMenu = New VAgregarMenu()
        Dim consulta As String = "select max(id_menu) as maximo from menues"
        Dim id As Integer = MainClass.Id_maximo(consulta)
        frm.id = id + 1
        frm.agregarEditar = "agregar"
        frm.ShowDialog()

        ObtenerDatos()
    End Sub

    Private Sub dgvMenues_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMenues.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
        e.RowIndex >= 0 Then
            If senderGrid.Columns(e.ColumnIndex).Name = "dgvEditar" Then
                Dim frm As VAgregarMenu = New VAgregarMenu()
                frm.id = Convert.ToString(dgvMenues.CurrentRow.Cells("dgvID").Value)
                frm.lCostoTotal.Text = Convert.ToString(dgvMenues.CurrentRow.Cells("dgvCosto_total").Value)
                frm.tValorVenta.Text = Convert.ToString(dgvMenues.CurrentRow.Cells("dgvPrecioFinal").Value)
                frm.tNombreMenu.Text = Convert.ToString(dgvMenues.CurrentRow.Cells("dgvDescripcion").Value)
                frm.agregarEditar = "editar"
                frm.ShowDialog()
                ObtenerDatos()

            End If
            If senderGrid.Columns(e.ColumnIndex).Name = "dgvEliminar" Then

                Dim descripcion As String = Convert.ToString(dgvMenues.CurrentRow.Cells("dgvDescripcion").Value)
                Dim id As String = Convert.ToString(dgvMenues.CurrentRow.Cells("dgvID").Value)
                If MessageBox.Show("Está por ELIMINAR definitivamente el Menu: " & descripcion, "Eliminar Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
                Dim consulta As String = "delete from menues where id_menu='" + id + "'"
                Dim consulta2 As String = "delete from fila_menu where id_menu='" + id + "'"
                Dim ht As Hashtable = New Hashtable()

                MainClass.SQL(consulta, ht)
                MainClass.SQL(consulta2, ht)
                ObtenerDatos()
                MessageBox.Show("Se ha eliminado el Menu " + descripcion + " Correctamente")


            End If
            If senderGrid.Columns(e.ColumnIndex).Name = "dgvVerMenu" Then
                Dim frm As VVerMenu = New VVerMenu()
                frm.id = Convert.ToString(dgvMenues.CurrentRow.Cells("dgvID").Value)
                frm.lCosto.Text = Convert.ToString(dgvMenues.CurrentRow.Cells("dgvCosto_total").Value)
                frm.lImporte.Text = Convert.ToString(dgvMenues.CurrentRow.Cells("dgvPrecioFinal").Value)
                frm.lNombreMenu.Text = Convert.ToString(dgvMenues.CurrentRow.Cells("dgvDescripcion").Value)

                frm.ShowDialog()

            End If
        End If
    End Sub

End Class