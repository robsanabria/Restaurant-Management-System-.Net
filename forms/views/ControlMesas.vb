Public Class ControlMesas

    Private Sub ControlMesas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '   RBClaro.Checked = My.Settings.Claro
        '   RBOscuro.Checked = My.Settings.Oscuro
        '
        '   If RBClaro.Checked = False Then
        '       CambiarTemaOscuro()
        '   ElseIf RBOscuro.Checked = True Then
        '       CambiarTemaOscuro()
        '   ElseIf RBClaro.Checked = True Then
        '       CambiarTemaClaro()
        '   ElseIf RBOscuro.Checked = False Then
        '       CambiarTemaOscuro()
        '   End If

        ObtenerDatos()
    End Sub

    '  Sub CambiarTemaClaro()
    '      Me.BackColor = Color.FromArgb(223, 223, 223)
    '      Label2.ForeColor = Color.Black
    '      'bAgregar
    '      dgvMesas.BackgroundColor = Color.FromArgb(212, 212, 212)
    '      Button5.Image = My.Resources.minimizarB
    '      Button6.Image = My.Resources.maximizarB
    '      Button7.Image = My.Resources.cerrarB
    '  End Sub
    '
    '  Sub CambiarTemaOscuro()
    '      Me.BackColor = Color.FromArgb(32, 32, 32)
    '      Label2.ForeColor = Color.White
    '      'bAgregar
    '      dgvMesas.BackgroundColor = Color.FromArgb(43, 43, 43)
    '      Button5.Image = My.Resources.minimizarN
    '      Button6.Image = My.Resources.maximizarN
    '      Button7.Image = My.Resources.cerrarN
    '  End Sub


    Public Sub ObtenerDatos()
        Dim consulta As String = "select * from mesas"
        Dim lb As ListBox = New ListBox()
        lb.Items.Add(dgvId)
        lb.Items.Add(dgvNumero)
        lb.Items.Add(dgvCant_sillas)
        lb.Items.Add(dgvEstado)
        lb.Items.Add(dgvId_venta)
        MainClass.cargarDatos(consulta, dgvMesas, lb)
    End Sub

    Private Sub bAgregar_Click(sender As Object, e As EventArgs) Handles bAgregar.Click
        Dim frm As VAgregarMesa = New VAgregarMesa()

        frm.ShowDialog()

        ObtenerDatos()
    End Sub

    Private Sub dgvMesas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMesas.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
        e.RowIndex >= 0 Then
            If senderGrid.Columns(e.ColumnIndex).Name = "dgvEditar" Then
                Dim frm As VAgregarMesa = New VAgregarMesa()

                frm.id = Convert.ToString(dgvMesas.CurrentRow.Cells("dgvId").Value)
                frm.tNumero.Text = Convert.ToString(dgvMesas.CurrentRow.Cells("dgvNumero").Value)
                frm.tCantidadSillas.Text = Convert.ToString(dgvMesas.CurrentRow.Cells("dgvCant_sillas").Value)
                frm.ShowDialog()
                ObtenerDatos()

            End If
            If senderGrid.Columns(e.ColumnIndex).Name = "dgvEliminar" Then

                Dim descripcion As String = Convert.ToString(dgvMesas.CurrentRow.Cells("dgvNumero").Value)
                Dim id As String = Convert.ToString(dgvMesas.CurrentRow.Cells("dgvID").Value)
                If MessageBox.Show("Está por ELIMINAR definitivamente a la Mesa N°" & descripcion, "Eliminar Mesa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
                Dim consulta As String = "delete from mesas where id_mesa='" + id + "'"

                Dim ht As Hashtable = New Hashtable()

                MainClass.SQL(consulta, ht)
                ObtenerDatos()
                MessageBox.Show("Se ha eliminado a la mesa N°" + descripcion + " Correctamente")


            End If
            If senderGrid.Columns(e.ColumnIndex).Name = "dgvVenta" Then

                Dim frm As VVenta = New VVenta()

                Dim id_venta_actual As String = Convert.ToString(dgvMesas.CurrentRow.Cells("dgvId_venta").Value)

                If id_venta_actual = 0 Then
                    Dim id As String = Convert.ToString(dgvMesas.CurrentRow.Cells("dgvId").Value)
                    Dim consulta As String = "select max(id_venta) as maximo from ventas"
                    Dim consulta2 As String = "update mesas set id_venta_actual=@id_venta_actual where id_mesa='" + id + "'"
                    Dim idMax As String = MainClass.Id_maximo(consulta) + 1
                    'si es la primer venta idMax no cambia

                    Dim mesa As String = Convert.ToString(dgvMesas.CurrentRow.Cells("dgvNumero").Value)

                    If idMax <> "1" Then
                        Dim lista As List(Of Integer) = New List(Of Integer)
                        For i = 0 To (dgvMesas.Rows.Count - 1)
                            If dgvMesas.Rows(i).ToString() <> dgvMesas.CurrentRow.ToString() Then
                                lista.Add(dgvMesas.Rows(i).Cells("dgvId_venta").Value)
                            End If
                        Next

                        If lista.Count > 0 Then
                            If idMax <= lista.Max Then
                                idMax = lista.Max + 1
                            End If
                        End If


                    End If


                    Dim consulta3 As String = "INSERT INTO ventas(id_venta, importe, costo, ganancia, id_mesa, fecha, hora, descripcion, observaciones, estado, mesa)
                              VALUES(@id_venta, @importe, @costo, @ganancia, @id_mesa, @fecha, @hora, @descripcion, @observaciones, @estado, @mesa)"

                    Dim ht3 As Hashtable = New Hashtable()

                    ht3.Add("@id_venta", idMax)
                    ht3.Add("@importe", "")
                    ht3.Add("@costo", "")
                    ht3.Add("@ganancia", "")
                    ht3.Add("@id_mesa", id)
                    ht3.Add("@fecha", "")
                    ht3.Add("@hora", "")
                    ht3.Add("@descripcion", "Venta")
                    ht3.Add("@observaciones", "")
                    ht3.Add("@estado", "sin finalizar")
                    ht3.Add("@mesa", mesa)

                    MainClass.SQL(consulta3, ht3)

                    frm.id = idMax
                    frm.lMesa.Text = mesa
                    Dim ht As Hashtable = New Hashtable()
                    ht.Add("@id_venta_actual", idMax)
                    MainClass.SQL(consulta2, ht)
                    ObtenerDatos()
                Else
                    frm.id = id_venta_actual
                End If

                frm.id_mesa = Convert.ToString(dgvMesas.CurrentRow.Cells("dgvId").Value)
                frm.lMesa.Text = Convert.ToString(dgvMesas.CurrentRow.Cells("dgvNumero").Value)
                frm.ShowDialog()


            End If

            If senderGrid.Columns(e.ColumnIndex).Name = "dgvReserva" Then
                Dim frm As VVerReservas = New VVerReservas()
                frm.id = Convert.ToString(dgvMesas.CurrentRow.Cells("dgvId").Value)

                frm.ShowDialog()
            End If

        End If
        ObtenerDatos()
    End Sub

    Private Sub ControlMesas_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        ObtenerDatos()
    End Sub
End Class