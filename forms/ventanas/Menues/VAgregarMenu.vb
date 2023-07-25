Public Class VAgregarMenu
    Public id As Integer
    Public agregarEditar As String



    Public Sub ObtenerDatos()

        If id <> 0 Then
            Dim consulta As String = "select id_fila_menu, descripcion, tipo_unidad, cantidad, costo_total from fila_menu where id_menu='" + CType(id, String) + "'"
            Dim lb As ListBox = New ListBox()
            lb.Items.Add(dgvId)
            lb.Items.Add(dgvDescripcion)
            lb.Items.Add(dgvTipoUnidad)
            lb.Items.Add(dgvCantidad)
            lb.Items.Add(dgvCosto_total)

            MainClass.cargarDatos(consulta, dgvMenu, lb)

            Dim suma As Double = 0

            For i = 0 To dgvMenu.Rows.Count - 1
                suma += dgvMenu.Rows(i).Cells(8).Value
            Next

            lCostoTotal.Text = suma

        End If


    End Sub

    Private Sub bAgregarIngrediente_Click(sender As Object, e As EventArgs) Handles bAgregarIngrediente.Click
        Dim frm As VAgregarIngredienteMenu = New VAgregarIngredienteMenu()
        frm.id = Me.id
        frm.ShowDialog()

        ObtenerDatos()
    End Sub


    Private Sub bCancelarMenu_Click(sender As Object, e As EventArgs) Handles bCancelarMenu.Click

        Dim consulta As String

        If agregarEditar = "agregar" Then
            consulta = "delete from fila_menu where id_menu='" + id.ToString() + "'"
            Dim ht As Hashtable = New Hashtable()

            MainClass.SQL(consulta, ht)
            ObtenerDatos()
            Me.Hide()
        End If
        If agregarEditar = "editar" Then
            Me.Hide()
        End If


    End Sub

    Private Sub bAceptarMenu_Click(sender As Object, e As EventArgs) Handles bAceptarMenu.Click

        If dgvMenu.Rows.Count = 0 Then
            If MessageBox.Show("Está por guardar un menú vacío. ¿Desea continuar?", "Menú vacío", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        End If

        Dim consulta As String

        If agregarEditar = "agregar" Then
            consulta = "insert into menues(id_menu,descripcion,costo_total,precio_final)
                                                    values(@id_menu,@descripcion,@costo_total,@precio_final)"
        End If
        If agregarEditar = "editar" Then
            consulta = "update menues set descripcion = @descripcion,costo_total=@costo_total,precio_final=@precio_final where id_menu='" + id.ToString() + "'"
        End If

        Dim ht As Hashtable = New Hashtable()


        Dim valorVenta As Double
        If Not Double.TryParse(tValorVenta.Text, valorVenta) OrElse valorVenta <= 0 Then
            MessageBox.Show("Ingrese un valor de venta válido.")
            Return
        End If

        If String.IsNullOrEmpty(tNombreMenu.Text) Then
            MessageBox.Show("Ingrese un nombre de menú válido.")
            Return
        End If

        ht.Add("@id_menu", CType(id, Integer))
        ht.Add("@descripcion", tNombreMenu.Text)
        ht.Add("@costo_total", CType(lCostoTotal.Text, Double))
        ht.Add("@precio_final", CType(valorVenta, Double))


        If MainClass.SQL(consulta, ht) > 0 Then
            MessageBox.Show("Se guardó correctamente")
            Me.Hide()
            VAgregarIngredienteMenu.Hide()
        End If
    End Sub


    Private Sub dgvMenu_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMenu.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
        e.RowIndex >= 0 Then
            If senderGrid.Columns(e.ColumnIndex).Name = "dgvEditar" Then
                Dim frm As VIngresarCantidadIngrediente = New VIngresarCantidadIngrediente()
                Dim descripcion As String = Convert.ToString(dgvMenu.CurrentRow.Cells("dgvDescripcion").Value)
                Dim tipoUnidad As String = Convert.ToString(dgvMenu.CurrentRow.Cells("dgvTipoUnidad").Value)
                Dim cantidad As Double = Convert.ToDouble(dgvMenu.CurrentRow.Cells("dgvCantidad").Value)
                Dim costo As Double = Convert.ToDouble(dgvMenu.CurrentRow.Cells("dgvCosto_total").Value)
                Dim precioUnitario As String = costo / cantidad
                frm.IdFila = Convert.ToString(dgvMenu.CurrentRow.Cells("dgvId").Value)
                frm.esEditar = True
                frm.lIngrediente.Text = descripcion + " expresados en " + tipoUnidad
                frm.tCantidadIngrediente.Text = cantidad
                frm.costo_unidad = precioUnitario
                frm.ShowDialog()
                ObtenerDatos()
            End If
            If senderGrid.Columns(e.ColumnIndex).Name = "dgvEliminar" Then
                If MessageBox.Show("¿Desea eliminar el ingrediente?", "Eliminar ingrediente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
                Dim id As String = Convert.ToString(dgvMenu.CurrentRow.Cells("dgvID").Value)
                Dim consulta As String = "delete from fila_menu where id_fila_menu='" + id + "'"
                Dim ht As Hashtable = New Hashtable()

                MainClass.SQL(consulta, ht)
                ObtenerDatos()


            End If
        End If
    End Sub

    Private Sub VAgregarMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    ' Sub CambiarTemaClaro()
    '     Me.BackColor = Color.FromArgb(130, 130, 130)
    '     'bAgregarIngrediente
    '     dgvMenu.BackgroundColor = Color.FromArgb(159, 159, 159)
    '     Label1.ForeColor = Color.Black
    '     Label2.ForeColor = Color.Black
    '     Label3.ForeColor = Color.Black
    '     lCostoTotal.ForeColor = Color.Black
    '     tNombreMenu.BackColor = Color.FromArgb(159, 159, 159)
    '     tNombreMenu.ForeColor = Color.Black
    '     tValorVenta.BackColor = Color.FromArgb(159, 159, 159)
    '     tValorVenta.ForeColor = Color.Black
    '     'bAceptarMenu
    '     'bCancelarMenu
    ' End Sub
    '
    ' Sub CambiarTemaOscuro()
    '     Me.BackColor = Color.FromArgb(125, 125, 125)
    '     'bAgregarIngrediente
    '     dgvMenu.BackgroundColor = Color.FromArgb(96, 96, 96)
    '     Label1.ForeColor = Color.White
    '     Label2.ForeColor = Color.White
    '     Label3.ForeColor = Color.White
    '     lCostoTotal.ForeColor = Color.White
    '     tNombreMenu.BackColor = Color.FromArgb(96, 96, 96)
    '     tNombreMenu.ForeColor = Color.White
    '     tValorVenta.BackColor = Color.FromArgb(96, 96, 96)
    '     tValorVenta.ForeColor = Color.White
    '     'bAceptarMenu
    '     'bCancelarMenu
    ' End Sub

End Class