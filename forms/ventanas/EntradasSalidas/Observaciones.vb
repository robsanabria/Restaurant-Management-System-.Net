Public Class Observaciones
    Public id As String
    Private Sub bCerrar_Click(sender As Object, e As EventArgs) Handles bCerrar.Click
        Me.Hide()
    End Sub

    Private Sub Observaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    '      Label4.ForeColor = Color.Black
    '      lTotal.ForeColor = Color.Black
    '      lMesa.ForeColor = Color.Black
    '      'bImprimir
    '      'bCerrar
    '      dgvVenta.BackgroundColor = Color.FromArgb(159, 159, 159)
    '      tObservaciones.BackColor = Color.Black
    '      tObservaciones.ForeColor = Color.White
    '  End Sub
    '
    '  Sub CambiarTemaOscuro()
    '      Me.BackColor = Color.FromArgb(68, 68, 68)
    '      Label1.ForeColor = Color.White
    '      Label2.ForeColor = Color.White
    '      Label4.ForeColor = Color.White
    '      lTotal.ForeColor = Color.White
    '      lMesa.ForeColor = Color.White
    '      'bImprimir
    '      'bCerrar
    '      dgvVenta.BackgroundColor = Color.FromArgb(96, 96, 96)
    '      tObservaciones.BackColor = Color.White
    '      tObservaciones.ForeColor = Color.Black
    '  End Sub

    Public Sub ObtenerDatos()
        Dim consulta As String = ""
        Dim lb As ListBox = New ListBox()

        consulta = "select descripcion,cantidad,precio_unitario,precio_total from fila_venta where id_venta='" + id + "'"

        lb.Items.Add(dgvDescripcion)
        lb.Items.Add(dgvCantidad)
        lb.Items.Add(dgvPrecioUnitario)
        lb.Items.Add(dgvPrecioTotal)


        MainClass.cargarDatos(consulta, dgvVenta, lb)
    End Sub

    Private Sub bImprimir_Click(sender As Object, e As EventArgs) Handles bImprimir.Click
        PrintDocument1.Print()
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
        valor = lTotal.Text - total
        Lvalor = Len(valor)

        total += valor
        texto = "   " & "Propina" & tabulacion & StrDup(CInt(13 - Lvalor), " ") & valor
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
End Class