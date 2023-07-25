Public Class VAgregarMercaderia
    Public id As Integer
    Public cantidadVieja As Double

    Private Sub bGuardarMercaderia_Click(sender As Object, e As EventArgs) Handles bGuardarMercaderia.Click
        Dim consulta As String = ""

        If String.IsNullOrEmpty(tDescripcionMercaderia.Text) Then
            MessageBox.Show("Ingrese una descripción válida.")
            Return
        End If

        If cmbTipo_unidadMercaderia.SelectedItem Is Nothing Then
            MessageBox.Show("Seleccione un tipo de unidad.")
            Return
        End If

        If cmbCategoriaMercaderia.SelectedItem Is Nothing Then
            MessageBox.Show("Seleccione una categoría.")
            Return
        End If

        Dim cantidad As Double
        If Not Double.TryParse(MainClass.reemplazarPunto(tCantidadMercaderia.Text), cantidad) OrElse cantidad <= 0 Then
            MessageBox.Show("Ingrese una cantidad válida.")
            Return
        End If

        Dim costoUnitario As Double
        If Not Double.TryParse(tCosto_unitarioMercaderia.Text, costoUnitario) OrElse costoUnitario <= 0 Then
            MessageBox.Show("Ingrese un costo unitario válido.")
            Return
        End If

        Dim costoTotal As Double = cantidad * costoUnitario

        Dim ht As Hashtable = New Hashtable()

        If id = 0 Then
            consulta = "INSERT INTO mercaderias (descripcion, tipo_unidad, categoria, cantidad, costo_unidad, costo_total)
                        VALUES (@descripcion, @tipoUnidad, @categoria, @cantidad, @costoUnidad, @costoTotal)"
            cantidadVieja = 0
        Else
            consulta = "UPDATE mercaderias SET descripcion = @descripcion, tipo_unidad = @tipoUnidad, categoria = @categoria, cantidad = @cantidad, costo_unidad = @costoUnidad, costo_total = @costoTotal
                        WHERE id_mercaderia = '" + id.ToString() + "'"
        End If

        ht.Add("@descripcion", tDescripcionMercaderia.Text)
        ht.Add("@tipoUnidad", cmbTipo_unidadMercaderia.SelectedItem.ToString())
        ht.Add("@categoria", cmbCategoriaMercaderia.SelectedItem.ToString())
        ht.Add("@cantidad", cantidad)
        ht.Add("@costoUnidad", costoUnitario)
        ht.Add("@costoTotal", costoTotal)

        If MainClass.SQL(consulta, ht) > 0 Then
            MessageBox.Show("Se guardó correctamente")
            tDescripcionMercaderia.Text = ""
            tCantidadMercaderia.Text = ""
            tCosto_unitarioMercaderia.Text = "0"
            Me.Hide()
        End If
    End Sub

    Private Sub bSalirGuardarMercaderia_Click(sender As Object, e As EventArgs) Handles bSalirGuardarMercaderia.Click
        Me.Hide()
    End Sub



    Private Sub VAgregarMercaderia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub

    '  Sub CambiarTemaClaro()
    '      Me.BackColor = Color.FromArgb(187, 187, 187)
    '      Label1.ForeColor = Color.Black
    '      Label2.ForeColor = Color.Black
    '      Label3.ForeColor = Color.Black
    '      Label4.ForeColor = Color.Black
    '      Label5.ForeColor = Color.Black
    '      tDescripcionMercaderia.BackColor = Color.FromArgb(159, 159, 159)
    '      tDescripcionMercaderia.ForeColor = Color.Black
    '      cmbTipo_unidadMercaderia.BackColor = Color.FromArgb(159, 159, 159)
    '      cmbTipo_unidadMercaderia.ForeColor = Color.Black
    '      cmbCategoriaMercaderia.BackColor = Color.FromArgb(159, 159, 159)
    '      cmbCategoriaMercaderia.ForeColor = Color.Black
    '      tCantidadMercaderia.BackColor = Color.FromArgb(159, 159, 159)
    '      tCantidadMercaderia.ForeColor = Color.Black
    '      tCosto_unitarioMercaderia.BackColor = Color.FromArgb(159, 159, 159)
    '      tCosto_unitarioMercaderia.ForeColor = Color.Black
    '      'bGuardarMercaderia
    '      'bSalirGuardarMercaderia
    '  End Sub
    '
    '  Sub CambiarTemaOscuro()
    '      Me.BackColor = Color.FromArgb(68, 68, 68)
    '      Label1.ForeColor = Color.White
    '      Label2.ForeColor = Color.White
    '      Label3.ForeColor = Color.White
    '      Label4.ForeColor = Color.White
    '      Label5.ForeColor = Color.White
    '      tDescripcionMercaderia.BackColor = Color.FromArgb(96, 96, 96)
    '      tDescripcionMercaderia.ForeColor = Color.White
    '      cmbTipo_unidadMercaderia.BackColor = Color.FromArgb(96, 96, 96)
    '      cmbTipo_unidadMercaderia.ForeColor = Color.White
    '      cmbCategoriaMercaderia.BackColor = Color.FromArgb(96, 96, 96)
    '      cmbCategoriaMercaderia.ForeColor = Color.White
    '      tCantidadMercaderia.BackColor = Color.FromArgb(96, 96, 96)
    '      tCantidadMercaderia.ForeColor = Color.White
    '      tCosto_unitarioMercaderia.BackColor = Color.FromArgb(96, 96, 96)
    '      tCosto_unitarioMercaderia.ForeColor = Color.White
    '      'bGuardarMercaderia
    '      'bSalirGuardarMercaderia
    '  End Sub

End Class
