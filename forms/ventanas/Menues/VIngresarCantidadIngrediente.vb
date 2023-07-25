
Public Class VIngresarCantidadIngrediente
    Public id_menu As Integer
    Public id_mercaderia As String
    Public descripcion As String
    Public tipo_unidad As String
    Public categoria As String
    Public costo_unidad As String
    Public esEditar As Boolean = False
    Public IdFila As String
    Private Sub bAceptarIngrediente_Click(sender As Object, e As EventArgs) Handles bAceptarIngrediente.Click

        Dim cantidad As Double
        If Not Double.TryParse(MainClass.reemplazarPunto(tCantidadIngrediente.Text), cantidad) OrElse cantidad <= 0 Then
            MessageBox.Show("Ingrese una cantidad válida.")
            Return
        End If

        Dim consulta As String

        Dim ht As Hashtable = New Hashtable()

        If Not esEditar Then
            consulta = "insert into fila_menu(id_menu,id_alimento,descripcion,tipo_unidad,cantidad,costo_total)
                                                    values(@id_menu,@id_alimento,@descripcion,@tipo_unidad,@cantidad,@costo_total)"
            ht.Add("@id_menu", id_menu)
            ht.Add("@id_alimento", id_mercaderia)
            ht.Add("@descripcion", descripcion)
            ht.Add("@tipo_unidad", tipo_unidad)
            ht.Add("@cantidad", cantidad)
            ht.Add("@costo_total", costo_unidad * cantidad)
        Else

            consulta = "update fila_menu set cantidad=@cantidad, costo_total=@costo_total where id_fila_menu='" + IdFila + "'"

            ht.Add("@cantidad", cantidad)
            ht.Add("@costo_total", costo_unidad * cantidad)
        End If

        If MainClass.SQL(consulta, ht) > 0 Then
            MessageBox.Show("Se guardó correctamente")
            Me.Hide()
        End If
    End Sub

    Private Sub bCancelarIngrediente_Click(sender As Object, e As EventArgs) Handles bCancelarIngrediente.Click
        Me.Hide()
    End Sub

    ' Private Sub VIngresarCantidadIngrediente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    '
    ' Sub CambiarTemaClaro()
    '     Me.BackColor = Color.FromArgb(159, 159, 159)
    '     lIngrediente.ForeColor = Color.Black
    '     Label1.ForeColor = Color.Black
    '     tCantidadIngrediente.BackColor = Color.FromArgb(130, 130, 130)
    '     tCantidadIngrediente.ForeColor = Color.Black
    '     'bCancelarIngrediente
    '     'bAceptarIngrediente
    ' End Sub
    '
    ' Sub CambiarTemaOscuro()
    '     Me.BackColor = Color.FromArgb(96, 96, 96)
    '     lIngrediente.ForeColor = Color.White
    '     Label1.ForeColor = Color.White
    '     tCantidadIngrediente.BackColor = Color.FromArgb(125, 125, 125)
    '     tCantidadIngrediente.ForeColor = Color.White
    '     'bCancelarIngrediente
    '     'bAceptarIngrediente
    ' End Sub

End Class