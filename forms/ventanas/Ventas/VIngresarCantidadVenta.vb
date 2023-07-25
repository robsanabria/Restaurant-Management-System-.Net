Public Class VIngresarCantidadVenta

    Public id_venta As Integer
    Public id_menu As Integer
    Public descripcion As String
    Public costo As Double
    Public costo_total As Double
    Public precio_unitario As Double
    Public precio_total As Double
    Private Sub bAceptarMenu_Click(sender As Object, e As EventArgs) Handles bAceptarMenu.Click

        Dim cantidad As Double
        If Not Integer.TryParse(tCantidadMenu.Text, cantidad) OrElse cantidad <= 0 Then
            MessageBox.Show("Ingrese una cantidad válida.")
            Return
        End If


        Dim control As String

        control = MainClass.checkStock(id_menu, cantidad)

        If control <> 0 Then
            MessageBox.Show("No hay stock suficiente para la cantidad ingresada")
            Return
        End If


        costo_total = cantidad * costo
        precio_total = cantidad * precio_unitario

        Dim consulta As String = "insert into fila_venta(id_menu,id_venta,descripcion,cantidad,costo,costo_total,precio_unitario,precio_total)
                                                    values(@id_menu,@id_venta,@descripcion,@cantidad,@costo,@costo_total,@precio_unitario,@precio_total)"

        Dim ht As Hashtable = New Hashtable()


        ht.Add("@id_menu", id_menu)
        ht.Add("@id_venta", id_venta)
        ht.Add("@descripcion", descripcion)
        ht.Add("@cantidad", cantidad)
        ht.Add("@costo", costo)
        ht.Add("@costo_total", costo_total)
        ht.Add("@precio_unitario", precio_unitario)
        ht.Add("@precio_total", precio_total)


        If MainClass.SQL(consulta, ht) > 0 Then
            MessageBox.Show("Se guardó correctamente")
            Me.Hide()
            VAgregarIngredienteMenu.Hide()

            VAgregarMenu.ObtenerDatos()
        End If

    End Sub

    Private Sub bCancelarMenu_Click(sender As Object, e As EventArgs) Handles bCancelarMenu.Click
        Me.Hide()
    End Sub

    '  Private Sub VIngresarCantidadVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '      RBClaro.Checked = My.Settings.Claro
    '      RBOscuro.Checked = My.Settings.Oscuro
    '
    '      If RBClaro.Checked = False Then
    '          CambiarTemaOscuro()
    '      ElseIf RBOscuro.Checked = True Then
    '          CambiarTemaOscuro()
    '      ElseIf RBClaro.Checked = True Then
    '          CambiarTemaClaro()
    '      ElseIf RBOscuro.Checked = False Then
    '          CambiarTemaOscuro()
    '      End If
    '  End Sub
    '
    '  Sub CambiarTemaClaro()
    '      Me.BackColor = Color.FromArgb(159, 159, 159)
    '      lMenu.ForeColor = Color.Black
    '      Label1.ForeColor = Color.Black
    '      tCantidadMenu.BackColor = Color.FromArgb(187, 187, 187)
    '      tCantidadMenu.ForeColor = Color.Black
    '  End Sub
    '
    '  Sub CambiarTemaOscuro()
    '      Me.BackColor = Color.FromArgb(96, 96, 96)
    '      lMenu.ForeColor = Color.White
    '      Label1.ForeColor = Color.White
    '      tCantidadMenu.BackColor = Color.FromArgb(68, 68, 68)
    '      tCantidadMenu.ForeColor = Color.White
    '  End Sub

End Class