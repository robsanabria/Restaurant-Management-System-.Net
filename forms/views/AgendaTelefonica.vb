Imports System.Data.SqlClient

Public Class AgendaTelefonica
    Private Sub AgendaTelefonica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    ' Sub CambiarTemaClaro()
    '     Me.BackColor = Color.FromArgb(223, 223, 223)
    '     Label2.ForeColor = Color.Black
    '     DgvTelefonos.BackgroundColor = Color.FromArgb(212, 212, 212)
    '     'bAgregarTelefono
    '     Button5.Image = My.Resources.minimizarB
    '     Button6.Image = My.Resources.maximizarB
    '     Button7.Image = My.Resources.cerrarB
    ' End Sub
    '
    ' Sub CambiarTemaOscuro()
    '     Me.BackColor = Color.FromArgb(32, 32, 32)
    '     Label2.ForeColor = Color.White
    '     DgvTelefonos.BackgroundColor = Color.FromArgb(43, 43, 43)
    '     'bAgregarTelefono
    '     Button5.Image = My.Resources.minimizarN
    '     Button6.Image = My.Resources.maximizarN
    '     Button7.Image = My.Resources.cerrarN
    ' End Sub


    Public Sub ObtenerDatos()
        Dim consulta As String = "SELECT * FROM [dbo].[Telefonos]"
        Dim lb As ListBox = New ListBox()
        lb.Items.Add(dgvId)
        lb.Items.Add(dgvDescripcion)
        lb.Items.Add(dgvNumero_telefono)

        MainClass.cargarDatos(consulta, dgvTelefonos, lb)
    End Sub

    Private Sub bAgregarTelefono_Click(sender As Object, e As EventArgs) Handles bAgregarTelefono.Click
        Dim frm As VAgregarTelefono = New VAgregarTelefono()

        ' Pasar los datos del registro actual al formulario
        frm.TbDescripcionTel.Text = ""
        frm.TbNumeroTel.Text = ""

        frm.ShowDialog()
        ObtenerDatos()
    End Sub

    Private Sub dgvTelefonos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvTelefonos.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            If senderGrid.Columns(e.ColumnIndex).Name = "dgvEditar" Then
                Dim frm As VAgregarTelefono = New VAgregarTelefono()

                ' Establecer el modo de edición en el formulario VAgregarTelefono
                frm.EditarRegistro = True

                ' Pasar los datos del registro actual al formulario
                frm.TbDescripcionTel.Text = Convert.ToString(DgvTelefonos.CurrentRow.Cells("dgvDescripcion").Value)
                frm.TbNumeroTel.Text = Convert.ToString(DgvTelefonos.CurrentRow.Cells("dgvNumero_telefono").Value)

                ' Pasar el ID del registro actual al formulario
                frm.IdRegistro = Convert.ToInt32(DgvTelefonos.CurrentRow.Cells("dgvId").Value)

                frm.ShowDialog()
                ObtenerDatos()

            End If
            If senderGrid.Columns(e.ColumnIndex).Name = "dgvEliminar" Then

                Dim descripcion As String = Convert.ToString(DgvTelefonos.CurrentRow.Cells("dgvDescripcion").Value)
                Dim id As String = Convert.ToString(DgvTelefonos.CurrentRow.Cells("dgvId").Value)
                If MessageBox.Show("Está por ELIMINAR definitivamente el Teléfono: " & descripcion, "Eliminar Teléfono", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
                Dim consulta As String = "delete from Telefonos where id_telefono='" + id + "'"

                Dim ht As Hashtable = New Hashtable()

                MainClass.SQL(consulta, ht)
                ObtenerDatos()
                MessageBox.Show("Se ha eliminado el teléfono " + descripcion + " correctamente")
            End If
        End If
    End Sub


End Class
