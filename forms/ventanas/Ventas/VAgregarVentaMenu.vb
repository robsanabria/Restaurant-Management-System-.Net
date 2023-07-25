Public Class VAgregarVentaMenu

    Public id As Integer

    Private Sub VAgregarVentaMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    '      Me.BackColor = Color.FromArgb(130, 130, 130)
    '      dgvMenues.BackgroundColor = Color.FromArgb(159, 159, 159)
    '      'Button1
    '  End Sub
    '
    '  Sub CambiarTemaOscuro()
    '      Me.BackColor = Color.FromArgb(125, 125, 125)
    '      dgvMenues.BackgroundColor = Color.FromArgb(96, 96, 96)
    '      'Button1
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

    Private Sub dgvMenues_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMenues.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
        e.RowIndex >= 0 Then
            If senderGrid.Columns(e.ColumnIndex).Name = "dgvAgregar" Then
                Dim id_menu As String = Convert.ToString(dgvMenues.CurrentRow.Cells("dgvId").Value)
                Dim control As String

                control = MainClass.checkStock(id_menu, "1")

                If control = 0 Then
                    Dim frm As VIngresarCantidadVenta = New VIngresarCantidadVenta()
                    frm.lMenu.Text = Convert.ToString(dgvMenues.CurrentRow.Cells("dgvDescripcion").Value)
                    frm.id_venta = Me.id
                    frm.id_menu = id_menu
                    frm.descripcion = Convert.ToString(dgvMenues.CurrentRow.Cells("dgvDescripcion").Value)
                    frm.costo = Convert.ToString(dgvMenues.CurrentRow.Cells("dgvCosto_Total").Value)
                    frm.precio_unitario = Convert.ToString(dgvMenues.CurrentRow.Cells("dgvPrecioFinal").Value)
                    frm.ShowDialog()
                    ObtenerDatos()
                    Me.Hide()
                Else
                    MessageBox.Show("No hay stock suficiente")
                End If



            End If
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub tBuscar_TextChanged(sender As Object, e As EventArgs) Handles tBuscar.TextChanged
        Dim consulta As String = "select * from menues where descripcion like '%" + tBuscar.Text + "%'"
        Dim lb As ListBox = New ListBox()
        lb.Items.Add(dgvId)
        lb.Items.Add(dgvDescripcion)
        lb.Items.Add(dgvCosto_Total)
        lb.Items.Add(dgvPrecioFinal)

        MainClass.cargarDatos(consulta, dgvMenues, lb)
    End Sub
End Class