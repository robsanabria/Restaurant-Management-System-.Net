Public Class VAgregarUtiles

    Public id As Integer
    Public cantidadVieja As Double
    Private Sub bGuardarUtiles_Click(sender As Object, e As EventArgs) Handles bGuardarUtiles.Click
        Dim consulta As String = ""
        If id = 0 Then
            consulta = "INSERT INTO Utiles(descripcion, cantidad, costo_unidad, costo_total) VALUES (@descripcion, @cantidad, @costoUnidad, @costoTotal)"
            cantidadVieja = 0
        Else
            consulta = "UPDATE Utiles SET descripcion = @descripcion, cantidad = @cantidad, costo_unidad = @costoUnidad, costo_total = @costoTotal WHERE id_util = '" + id.ToString() + "'"
        End If

        Dim ht As Hashtable = New Hashtable()

        Dim descripcion As String = tDescripcionUtiles.Text.Trim()
        Dim cantidad As Integer
        Dim costoUnidad As Double

        ' Validar que se haya ingresado una descripción
        If String.IsNullOrWhiteSpace(descripcion) Then
            MessageBox.Show("Por favor, ingrese una descripción válida.")
            Return
        End If

        ' Validar que se haya ingresado una cantidad válida
        If Not Integer.TryParse(tCantidadUtiles.Text, cantidad) Then
            MessageBox.Show("Por favor, ingrese una cantidad válida.")
            Return
        End If

        ' Validar que se haya ingresado un costo por unidad válido
        If Not Double.TryParse(tCosto_unitarioUtiles.Text, costoUnidad) Then
            MessageBox.Show("Por favor, ingrese un costo por unidad válido.")
            Return
        End If

        ' Calcular el costo total
        Dim costoTotal As Double = cantidad * costoUnidad

        ' Asignar los valores a los parámetros
        ht.Add("@descripcion", descripcion)
        ht.Add("@cantidad", cantidad)
        ht.Add("@costoUnidad", costoUnidad)
        ht.Add("@costoTotal", costoTotal)



        If MainClass.SQL(consulta, ht) > 0 Then
            MessageBox.Show("Se guardó correctamente")
            tDescripcionUtiles.Text = ""
            tCantidadUtiles.Text = ""
            tCosto_unitarioUtiles.Text = "0"
            Me.Hide()
        End If
    End Sub


    Private Sub bSalirGuardarUtiles_Click(sender As Object, e As EventArgs) Handles bSalirGuardarUtiles.Click
        Me.Hide()
    End Sub


    ' Private Sub VAgregarUtiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    '     Me.BackColor = Color.FromArgb(187, 187, 187)
    '     Label1.ForeColor = Color.Black
    '     Label4.ForeColor = Color.Black
    '     Label5.ForeColor = Color.Black
    '     tDescripcionUtiles.BackColor = Color.FromArgb(159, 159, 159)
    '     tDescripcionUtiles.ForeColor = Color.Black
    '     tCantidadUtiles.BackColor = Color.FromArgb(159, 159, 159)
    '     tCantidadUtiles.ForeColor = Color.Black
    '     tCosto_unitarioUtiles.BackColor = Color.FromArgb(159, 159, 159)
    '     tCosto_unitarioUtiles.ForeColor = Color.Black
    '     'bGuardarUtiles
    '     'bSalirGuardarUtiles
    ' End Sub
    '
    ' Sub CambiarTemaOscuro()
    '     Me.BackColor = Color.FromArgb(68, 68, 68)
    '     Label1.ForeColor = Color.White
    '     Label4.ForeColor = Color.White
    '     Label5.ForeColor = Color.White
    '     tDescripcionUtiles.BackColor = Color.FromArgb(96, 96, 96)
    '     tDescripcionUtiles.ForeColor = Color.White
    '     tCantidadUtiles.BackColor = Color.FromArgb(96, 96, 96)
    '     tCantidadUtiles.ForeColor = Color.White
    '     tCosto_unitarioUtiles.BackColor = Color.FromArgb(96, 96, 96)
    '     tCosto_unitarioUtiles.ForeColor = Color.White
    '     'bGuardarUtiles
    '     'bSalirGuardarUtiles
    ' End Sub

End Class