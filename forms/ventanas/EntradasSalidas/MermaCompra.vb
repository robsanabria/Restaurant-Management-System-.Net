Public Class MermaCompra
    Public mercaderiaUtil As String = ""
    Public costoUnitario As Double = 0
    Public id As String
    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Me.Hide()
    End Sub

    Private Sub bRegistrar_Click(sender As Object, e As EventArgs) Handles bRegistrar.Click
        'validar cantidad

        Dim cantidad As Double
        Dim mensaje As String = ""
        Dim tabla As String = ""
        Dim consulta As String = ""
        Dim costo_total As Double = 0
        If Not Double.TryParse(MainClass.reemplazarPunto(tCantidad.Text), cantidad) OrElse cantidad <= 0 Then
            MessageBox.Show("Ingrese una cantidad válida.")
            Return
        End If

        If mercaderiaUtil = "mercaderia" Then
            tabla = "mercaderias"
        End If

        If mercaderiaUtil = "util" Then
            tabla = "utiles"
        End If

        costo_total = costoUnitario * cantidad

        If cMermaCompra.SelectedItem Is Nothing Then
            MessageBox.Show("Seleccione un tipo de operación.")
            Return
        End If

        If cMermaCompra.SelectedItem.ToString() = "Merma" Then
            consulta = "UPDATE " + tabla + " SET cantidad = (cantidad - @cantidad), costo_total = (costo_total - @costo_total)
            WHERE id_" + mercaderiaUtil + " = '" + id + "'"
            mensaje = "merma"

        End If

        If cMermaCompra.SelectedItem.ToString() = "Compra" Then
            consulta = "UPDATE " + tabla + " SET cantidad = (cantidad + @cantidad), costo_total = (costo_total + @costo_total)
            WHERE id_" + mercaderiaUtil + " = '" + id + "'"
            mensaje = "compra"

        End If



        Dim ht As Hashtable = New Hashtable()

        ht.Add("@cantidad", cantidad)
        ht.Add("@costo_total", costo_total)



        Dim consulta2 As String = "INSERT INTO ventas (id_venta, descripcion, importe, fecha, hora, observaciones, estado, mesa)
                                       VALUES (@id_venta, @descripcion, @importe, @fecha, @hora, @observaciones, @estado, @mesa)"

        Dim consulta3 As String = "SELECT MAX(id_venta) AS maximo FROM ventas"
        Dim idMax As String = MainClass.Id_maximo(consulta3) + 1
        Dim ht2 As Hashtable = New Hashtable()


        ht2.Add("@id_venta", idMax)
        ht2.Add("@descripcion", cMermaCompra.SelectedItem.ToString())
        ht2.Add("@importe", -costo_total)
        ht2.Add("@fecha", Date.Now.ToString("yyyy-MM-dd"))
        ht2.Add("@hora", Date.Now.ToString("HH:mm:ss"))
        ht2.Add("@observaciones", tObservaciones.Text + " / " + mensaje + " de " + lDescripcion.Text + " por " + cantidad.ToString() + " unidades.")
        ht2.Add("@estado", "finalizada")
        ht2.Add("@mesa", "-")


        MainClass.SQL(consulta2, ht2)

        If MainClass.SQL(consulta, ht) > 0 Then
            MessageBox.Show("Se registró la operación correctamente")
            tCantidad.Text = "0"
            tObservaciones.Text = ""
            Me.Hide()
        End If

    End Sub

    ' Private Sub MermaCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '     RBClaro.Checked = My.Settings.Claro
    '     RBOscuro.Checked = My.Settings.Oscuro
    '
    '     If RBClaro.Checked = False Then
    '         CambiarTemaOscuro()
    '     ElseIf RBOscuro.Checked = True Then
    '         CambiarTemaOscuro()
    '     ElseIf RBClaro.Checked = True Then
    '         CambiarTemaClaro()
    '     ElseIf RBOscuro.Checked = False Then
    '         CambiarTemaOscuro()
    '     End If
    ' End Sub
    ' Sub CambiarTemaClaro()
    '     Me.BackColor = Color.FromArgb(159, 159, 159)
    '     lDescripcion.ForeColor = Color.Black
    '     Label2.ForeColor = Color.Black
    '     Label3.ForeColor = Color.Black
    '     Label4.ForeColor = Color.Black
    '     cMermaCompra.BackColor = Color.FromArgb(130, 130, 130)
    '     cMermaCompra.ForeColor = Color.Black
    '     tCantidad.BackColor = Color.FromArgb(130, 130, 130)
    '     tCantidad.ForeColor = Color.Black
    '     tObservaciones.BackColor = Color.FromArgb(130, 130, 130)
    '     tObservaciones.ForeColor = Color.Black
    '     'bCancelar
    '     'bRegistrar
    ' End Sub
    '
    ' Sub CambiarTemaOscuro()
    '     Me.BackColor = Color.FromArgb(96, 96, 96)
    '     lDescripcion.ForeColor = Color.White
    '     Label2.ForeColor = Color.White
    '     Label3.ForeColor = Color.White
    '     Label4.ForeColor = Color.White
    '     cMermaCompra.BackColor = Color.FromArgb(125, 125, 125)
    '     cMermaCompra.ForeColor = Color.White
    '     tCantidad.BackColor = Color.FromArgb(125, 125, 125)
    '     tCantidad.ForeColor = Color.White
    '     tObservaciones.BackColor = Color.FromArgb(125, 125, 125)
    '     tObservaciones.ForeColor = Color.White
    '     'bCancelar
    '     'bRegistrar
    ' End Sub

End Class