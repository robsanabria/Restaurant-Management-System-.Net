Public Class VVerReservas

    Public id As String

    Private Sub VVerReservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    '  Sub CambiarTemaClaro()
    '      Me.BackColor = Color.FromArgb(187, 187, 187)
    '      Label1.ForeColor = Color.Black
    '      Label2.ForeColor = Color.Black
    '      dgvReservas.BackgroundColor = Color.FromArgb(159, 159, 159)
    '      'bAgregar
    '      'Button2
    '  End Sub
    '
    '  Sub CambiarTemaOscuro()
    '      Me.BackColor = Color.FromArgb(68, 68, 68)
    '      Label1.ForeColor = Color.White
    '      Label2.ForeColor = Color.White
    '      dgvReservas.BackgroundColor = Color.FromArgb(96, 96, 96)
    '      'bAgregar
    '      'Button2
    '  End Sub

    Public Sub ObtenerDatos()
        Dim consulta As String = "select id_reserva,nombre,hora,fecha from reservas where id_mesa='" + id + "'"
        Dim consulta2 As String = ""
        Dim lb As ListBox = New ListBox()
        lb.Items.Add(dgvId)
        lb.Items.Add(dgvNombre)
        lb.Items.Add(dgvHora)
        lb.Items.Add(dgvFecha)

        MainClass.cargarDatos(consulta, dgvReservas, lb)

        Label2.Text = dgvReservas.Rows.Count

        If dgvReservas.Rows.Count = 0 Then
            consulta2 = "update mesas set estado='Sin reservas' where id_mesa='" + id + "'"
            Dim ht As Hashtable = New Hashtable()
            MainClass.SQL(consulta2, ht)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub bAgregar_Click(sender As Object, e As EventArgs) Handles bAgregar.Click
        Dim frm As VAgregarReserva = New VAgregarReserva()
        frm.id = id
        frm.ShowDialog()
        ObtenerDatos()
    End Sub

    Private Sub dgvReservas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReservas.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
        e.RowIndex >= 0 Then
            If senderGrid.Columns(e.ColumnIndex).Name = "dgvEditar" Then
                Dim frm As VAgregarReserva = New VAgregarReserva()

                frm.id = id
                frm.tNombre.Text = Convert.ToString(dgvReservas.CurrentRow.Cells("dgvNombre").Value)
                frm.dFecha.Text = Convert.ToString(dgvReservas.CurrentRow.Cells("dgvFecha").Value).Replace("-", "/")
                frm.dHora.Text = Convert.ToString(dgvReservas.CurrentRow.Cells("dgvHora").Value)
                frm.ShowDialog()
                ObtenerDatos()

            End If
            If senderGrid.Columns(e.ColumnIndex).Name = "dgvEliminar" Then
                Dim fec As Date
                Dim fecha As String = Convert.ToString(dgvReservas.CurrentRow.Cells("dgvFecha").Value)
                fec = CType(fecha, Date)
                fecha = fec.Day.ToString + "-" + fec.Month.ToString + "-" + fec.Year.ToString
                Dim hora As String = Convert.ToString(dgvReservas.CurrentRow.Cells("dgvHora").Value)
                If MessageBox.Show("Está por ELIMINAR la Reserva de fecha " + fecha + " y hora " + hora, "Eliminar Reserva", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
                Dim idReserva As String = Convert.ToString(dgvReservas.CurrentRow.Cells("dgvId").Value)
                Dim consulta As String = "delete from reservas where id_reserva='" + idReserva + "'"

                Dim ht As Hashtable = New Hashtable()

                MainClass.SQL(consulta, ht)
                ObtenerDatos()
                MessageBox.Show("Se ha eliminado la reserva correctamente")


            End If
        End If

    End Sub

End Class