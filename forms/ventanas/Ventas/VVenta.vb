Public Class VVenta

    Public id As Integer
    Public id_mesa As Integer
    'Public agregarEditar As String


    Private Sub VVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '    RBClaro.Checked = My.Settings.Claro
        '    RBOscuro.Checked = My.Settings.Oscuro
        '
        '    If RBClaro.Checked = False Then
        '        CambiarTemaOscuro()
        '    ElseIf RBOscuro.Checked = True Then
        '        CambiarTemaOscuro()
        '    ElseIf RBClaro.Checked = True Then
        '        CambiarTemaClaro()
        '    ElseIf RBOscuro.Checked = False Then
        '        CambiarTemaOscuro()
        '    End If

        ObtenerDatos()
    End Sub

    ' Sub CambiarTemaClaro()
    '     Me.BackColor = Color.FromArgb(187, 187, 187)
    '     'bAgregarItem
    '     tObservaciones.BackColor = Color.Black
    '     tObservaciones.ForeColor = Color.White
    '     Label1.ForeColor = Color.Black
    '     Label2.ForeColor = Color.Black
    '     Label3.ForeColor = Color.Black
    '     lMesa.ForeColor = Color.Black
    '     lTotalPago.ForeColor = Color.Black
    '     cImprimir.ForeColor = Color.Black
    '     'bCerrar
    '     'bConcretarVenta
    ' End Sub
    '
    ' Sub CambiarTemaOscuro()
    '     Me.BackColor = Color.FromArgb(68, 68, 68)
    '     'bAgregarItem
    '     tObservaciones.BackColor = Color.White
    '     tObservaciones.ForeColor = Color.Black
    '     Label1.ForeColor = Color.White
    '     Label2.ForeColor = Color.White
    '     Label3.ForeColor = Color.White
    '     lMesa.ForeColor = Color.White
    '     lTotalPago.ForeColor = Color.White
    '     cImprimir.ForeColor = Color.White
    '     'bCerrar
    '     'bConcretarVenta
    ' End Sub

    Public Sub ObtenerDatos()

        If id <> 0 Then
            Dim consulta As String = "select id_fila_venta,id_venta,id_menu, descripcion, cantidad, costo,costo_total,precio_unitario,precio_total from fila_venta where id_venta='" + id.ToString() + "'"
            Dim consulta2 As String = "select observaciones from ventas where id_venta='" + id.ToString() + "'"
            Dim lb As ListBox = New ListBox()
            lb.Items.Add(dgvId_fila_venta)
            lb.Items.Add(dgvIdMenu)
            lb.Items.Add(dgvIdVenta)
            lb.Items.Add(dgvDescripcion)
            lb.Items.Add(dgvCantidad)
            lb.Items.Add(dgvCosto)
            lb.Items.Add(dgvCostoTotal)
            lb.Items.Add(dgvPrecioUnitario)
            lb.Items.Add(dgvPrecioTotal)

            MainClass.cargarDatos(consulta, dgvVenta, lb)
            tObservaciones.Text = MainClass.SQL_obs(consulta2)

            Dim suma As Double = 0

            For i = 0 To dgvVenta.Rows.Count - 1
                suma += dgvVenta.Rows(i).Cells(9).Value
            Next

            lTotalPago.Text = suma

            Dim suma2 As Double = 0

            For i = 0 To dgvVenta.Rows.Count - 1
                suma2 += dgvVenta.Rows(i).Cells(7).Value
            Next

            propina()


        End If

    End Sub
    Private Sub bAgregarItem_Click(sender As Object, e As EventArgs) Handles bAgregarItem.Click
        Dim frm As VAgregarVentaMenu = New VAgregarVentaMenu()
        frm.id = Me.id
        frm.ShowDialog()

        ObtenerDatos()
    End Sub

    Private Function propina()
        Dim propinaV As Double
        If Not Double.TryParse(tPropina.Text, propinaV) OrElse propinaV < 0 Then
            MessageBox.Show("Ingrese un importe válido para la propina.")
            Return 1
        End If

        lTotal.Text = lTotalPago.Text + propinaV

        Return 0
    End Function
    Private Sub dgvVenta_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVenta.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
        e.RowIndex >= 0 Then
            If senderGrid.Columns(e.ColumnIndex).Name = "dgvEliminar" Then
                If MessageBox.Show("¿Desea eliminar la fila seleccionada?", "Eliminar Fila", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
                Dim id As String = Convert.ToString(dgvVenta.CurrentRow.Cells("dgvId_fila_venta").Value)
                Dim consulta As String = "delete from fila_venta where id_fila_venta='" + id + "'"
                Dim ht As Hashtable = New Hashtable()

                MainClass.SQL(consulta, ht)
                ObtenerDatos()

            End If
        End If

    End Sub

    Private Sub bCerrar_Click(sender As Object, e As EventArgs) Handles bCerrar.Click
        Dim consulta As String = "UPDATE ventas set observaciones=@observaciones where id_venta='" + id.ToString() + "'"
        Dim ht As Hashtable = New Hashtable()
        ht.Add("@observaciones", tObservaciones.Text)
        MainClass.SQL(consulta, ht)
        ObtenerDatos()
        Me.Hide()
    End Sub

    Private Sub bConcretarVenta_Click(sender As Object, e As EventArgs) Handles bConcretarVenta.Click
        ' Verificar si hay filas en la tabla de ventas
        If dgvVenta.Rows.Count = 0 Then
            MessageBox.Show("No se puede concretar la venta porque no hay productos en la lista.")
            Return
        End If

        ' Generar la venta
        Dim suma As Double = 0

        For i = 0 To dgvVenta.Rows.Count - 1
            Dim valorVenta As Double
            If Double.TryParse(dgvVenta.Rows(i).Cells(7).Value.ToString(), valorVenta) Then
                suma += valorVenta
            Else
                MessageBox.Show("El valor de venta en la fila " & (i + 1) & " no es válido.")
                Return
            End If
        Next

        If propina() = 1 Then
            Return
        End If

        Dim propinaMsje As String = "Propina: " + tPropina.Text

        ' Validar la existencia de la mesa
        If Me.id_mesa = 0 Then
            MessageBox.Show("No se puede concretar la venta porque no se ha seleccionado una mesa.")
            Return
        End If

        Dim consulta As String = "UPDATE ventas set  importe=@importe, costo=@costo, ganancia=@ganancia, id_mesa=@id_mesa, fecha=@fecha, hora=@hora, descripcion=@descripcion, observaciones=@observaciones, estado=@estado where id_venta='" + id.ToString() + "'"

        Dim ht As Hashtable = New Hashtable()

        ht.Add("@importe", lTotal.Text)
        ht.Add("@costo", suma)
        ht.Add("@ganancia", lTotal.Text - suma)
        ht.Add("@id_mesa", Me.id_mesa)
        ht.Add("@fecha", Date.Now.ToString("yyyy-MM-dd"))
        ht.Add("@hora", Date.Now.ToString("HH:mm:ss"))
        ht.Add("@descripcion", "Venta")
        ht.Add("@observaciones", propinaMsje + tObservaciones.Text)
        ht.Add("@estado", "finalizada")

        If MainClass.SQL(consulta, ht) > 0 Then
            MessageBox.Show("Se guardó correctamente")

            Dim consulta2 As String = "UPDATE mesas SET id_venta_actual = @id_venta_actual WHERE id_mesa = @id_mesa"
            Dim ht2 As Hashtable = New Hashtable()
            ht2.Add("@id_venta_actual", "0")
            ht2.Add("@id_mesa", id_mesa.ToString())
            MainClass.SQL(consulta2, ht2)

            If cImprimir.Checked Then
                PrintDocument1.Print()
            End If

            Me.Hide()
            ' Restar del stock los ingredientes: con el id_menu buscar en fila_ventas los que pertenecen al mismo, de ahí buscar los id_ingrediente y cantidad a descontar
            ' dgvIdMenu dgvCantidad
            restarStock()
        End If
    End Sub


    Private Sub restarStock()
        Dim id_menu_buscar As String
        Dim cantidad_menu As String
        'Label2.Text = dgvVenta.Rows(0).Cells(5).Value
        For i = 0 To (dgvVenta.Rows.Count - 1)
            id_menu_buscar = dgvVenta.Rows(i).Cells(3).Value
            cantidad_menu = dgvVenta.Rows(i).Cells(5).Value
            MainClass.descontarStock(id_menu_buscar, cantidad_menu)
        Next
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim fuente As System.Drawing.Font = New Font("consolas", 15)
        Dim topMargin As Double = e.MarginBounds.Top
        Dim yPos As Double = 0
        Dim count As Integer = 0
        Dim texto As String = ""
        Dim unidad As Byte = 0
        Dim detalle As String = ""
        Dim valor As Decimal = 0
        Dim tabulacion As String = ""
        Dim compensador As Integer = 0
        Dim total As Decimal = 0
        Dim Lvalor As Double
        Dim lineaTotal As String

        ' Imprime la cabecera
        yPos = 40
        Dim printFont As System.Drawing.Font = New Font("consolas", 12)
        e.Graphics.DrawString("Polo Opuesto", fuente, Brushes.Black, 100, 40)
        e.Graphics.DrawString("Polo Opuesto Gastrobar", printFont, Brushes.Black, 10, 120)
        e.Graphics.DrawString("Fecha: " & Date.Now, printFont, Brushes.Black, 10, 140)
        e.Graphics.DrawString("Dirección: OHiggins 1049", printFont, Brushes.Black, 10, 160)
        e.Graphics.DrawString("Ciudad: Punta Arenas", printFont, Brushes.Black, 10, 180)
        e.Graphics.DrawString("RUT: 77.638.853-K", printFont, Brushes.Black, 10, 200)
        e.Graphics.DrawString("Razón Social: Restaurant Morales y", printFont, Brushes.Black, 10, 220)
        e.Graphics.DrawString("              Dechert Limitada.", printFont, Brushes.Black, 10, 240)
        e.Graphics.DrawString("Mesa N. " & lMesa.Text, printFont, Brushes.Black, 10, 260)
        e.Graphics.DrawString("-----------------------------------", printFont, Brushes.Black, 10, 280)


        For Each row As DataGridViewRow In dgvVenta.Rows
            unidad = row.Cells("dgvCantidad").Value : detalle = row.Cells("dgvDescripcion").Value : valor = row.Cells("dgvPrecioTotal").FormattedValue
            Lvalor = Len(row.Cells("dgvPrecioTotal").FormattedValue.ToString)
            compensador = Len(row.Cells("dgvDescripcion").Value)
            tabulacion = StrDup(22 - compensador, " ")

            texto = unidad & "    " & detalle & tabulacion & StrDup(CInt(8 - Lvalor), " ") & valor 'Configura la linea
            yPos = 220 + topMargin + (count * printFont.GetHeight(e.Graphics)) ' Calcula la posición en la que se escribe la línea
            ' Imprime la línea con el objeto Graphics
            If Not row.IsNewRow Then
                e.Graphics.DrawString(texto, printFont, System.Drawing.Brushes.Black, 10, yPos)
                total += valor
            End If
            count += 1
        Next
        compensador = Len("Propina")
        tabulacion = StrDup(22 - compensador, " ")
        Lvalor = Len(tPropina.Text)
        valor = tPropina.Text
        total += tPropina.Text
        texto = "   " & "Propina" & tabulacion & StrDup(CInt(8 - Lvalor), " ") & valor
        yPos = 220 + topMargin + (count * printFont.GetHeight(e.Graphics))
        e.Graphics.DrawString(texto, printFont, System.Drawing.Brushes.Black, 30, yPos)
        yPos += 10
        e.Graphics.DrawString("                           _______", printFont, System.Drawing.Brushes.Black, 30, yPos)
        Dim XXX As Integer = 0
        XXX = Len(total.ToString)
        lineaTotal = StrDup(30 - XXX, ".")
        yPos += 20
        e.Graphics.DrawString("Total" & lineaTotal & total, printFont, System.Drawing.Brushes.Black, 10, yPos)

    End Sub

    Private Sub b10_Click(sender As Object, e As EventArgs) Handles b10.Click
        tPropina.Text = CType(lTotalPago.Text, Double) * 0.1
        propina()
    End Sub

    Private Sub b15_Click(sender As Object, e As EventArgs) Handles b15.Click
        tPropina.Text = CType(lTotalPago.Text, Double) * 0.15
        propina()
    End Sub

    Private Sub b20_Click(sender As Object, e As EventArgs) Handles b20.Click
        tPropina.Text = CType(lTotalPago.Text, Double) * 0.2
        propina()
    End Sub

End Class