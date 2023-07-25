Public Class EntradaSalida
    Private Sub EntradaSalida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    '      Label1.ForeColor = Color.Black
    '      Label2.ForeColor = Color.Black
    '      Label3.ForeColor = Color.Black
    '      Label4.ForeColor = Color.Black
    '      Label5.ForeColor = Color.Black
    '      'bBuscar
    '      cTipo.BackColor = Color.Black
    '      cTipo.ForeColor = Color.White
    '      dgvEyS.BackgroundColor = Color.FromArgb(212, 212, 212)
    '      'bImprimir
    '      Button5.Image = My.Resources.minimizarB
    '      Button6.Image = My.Resources.maximizarB
    '      Button7.Image = My.Resources.cerrarB
    '  End Sub
    '
    '  Sub CambiarTemaOscuro()
    '      Me.BackColor = Color.FromArgb(32, 32, 32)
    '      Label1.ForeColor = Color.White
    '      Label2.ForeColor = Color.White
    '      Label3.ForeColor = Color.White
    '      Label4.ForeColor = Color.White
    '      Label5.ForeColor = Color.White
    '      'bBuscar
    '      cTipo.BackColor = Color.White
    '      cTipo.ForeColor = Color.Black
    '      dgvEyS.BackgroundColor = Color.FromArgb(43, 43, 43)
    '      'bImprimir
    '      Button5.Image = My.Resources.minimizarN
    '      Button6.Image = My.Resources.maximizarN
    '      Button7.Image = My.Resources.cerrarN
    '  End Sub

    Public Sub ObtenerDatos()
        Dim consulta As String = ""
        Dim lb As ListBox = New ListBox()

        consulta = "select id_venta,descripcion,fecha,hora,importe,mesa from ventas where estado='finalizada'"

        lb.Items.Add(dgvId)
        lb.Items.Add(dgvDescripcion)
        lb.Items.Add(dgvFecha)
        lb.Items.Add(dgvHora)
        lb.Items.Add(dgvValor)
        lb.Items.Add(dgvMesa)


        MainClass.cargarDatos(consulta, dgvEyS, lb)
    End Sub

    Private Sub dgvEyS_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEyS.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
        e.RowIndex >= 0 Then
            If senderGrid.Columns(e.ColumnIndex).Name = "dgvDetalle" Then
                Dim frm As Observaciones = New Observaciones()
                '373; 307
                Dim id As String = Convert.ToString(dgvEyS.CurrentRow.Cells("dgvId").Value)
                Dim consulta As String = "select observaciones from ventas where id_venta='" + id + "'"
                Dim tipo As String = Convert.ToString(dgvEyS.CurrentRow.Cells("dgvDescripcion").Value)


                If tipo = "Venta" Then
                    frm.Size = New Size(860, 307)
                    frm.id = id
                    frm.lTotal.Text = Convert.ToString(dgvEyS.CurrentRow.Cells("dgvValor").Value)
                    frm.lMesa.Text = Convert.ToString(dgvEyS.CurrentRow.Cells("dgvMesa").Value)
                Else
                    frm.Size = New Size(373, 307)
                End If

                frm.tObservaciones.Text = MainClass.SQL_obs(consulta)
                frm.ShowDialog()

            End If
            If senderGrid.Columns(e.ColumnIndex).Name = "dgvEliminar" Then

                Dim id As String = Convert.ToString(dgvEyS.CurrentRow.Cells("dgvId").Value)
                Dim consulta As String = "delete from ventas where id_venta='" + id + "'"
                Dim consulta2 As String = "delete from fila_venta where id_venta='" + id + "'"

                If MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Eliminar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
                Dim ht As Hashtable = New Hashtable()

                MainClass.SQL(consulta, ht)
                MainClass.SQL(consulta2, ht)
                ObtenerDatos()

            End If
        End If

    End Sub

    Private Sub bBuscar_Click(sender As Object, e As EventArgs) Handles bBuscar.Click
        Dim consulta As String = ""
        Dim lb As ListBox = New ListBox()
        Dim desde As String = dDesde.Value.Year.ToString + "-" + dDesde.Value.Month.ToString + "-" + dDesde.Value.Day.ToString
        Dim hasta As String = dHasta.Value.Year.ToString + "-" + dHasta.Value.Month.ToString + "-" + dHasta.Value.Day.ToString


        If cbFiltros.Checked Then

            If cTipo.SelectedItem Is Nothing Then
                MessageBox.Show("Seleccione una categoría de búsqueda.")
                Return
            End If
            Dim tipo As String = cTipo.SelectedItem.ToString()
            If dDesde.Value.Year > dHasta.Value.Year Then
                MessageBox.Show("La fecha 'Desde' debe ser menor o igual que la de 'Hasta'.")
                Return
            ElseIf dDesde.Value.Year = dHasta.Value.Year And dDesde.Value.Month > dHasta.Value.Month Then

                MessageBox.Show("La fecha 'Desde' debe ser menor o igual que la de 'Hasta'.")
                Return
            ElseIf dDesde.Value.Year = dHasta.Value.Year And dDesde.Value.Month = dHasta.Value.Month And dDesde.Value.Day > dHasta.Value.Day Then

                MessageBox.Show("La fecha 'Desde' debe ser menor o igual que la de 'Hasta'.")
                Return

            End If

            If tipo = "Todo" Then

                consulta = "select id_venta,descripcion,fecha,hora,importe from ventas where estado='finalizada' and (fecha between '" + desde + "' and '" + hasta + "')"

            Else

                consulta = "select id_venta,descripcion,fecha,hora,importe from ventas where estado='finalizada' and descripcion='" + tipo + "' and (fecha between '" + desde + "' and '" + hasta + "')"

            End If

        Else

            consulta = "select id_venta,descripcion,fecha,hora,importe from ventas where estado='finalizada'"

        End If

        lb.Items.Add(dgvId)
        lb.Items.Add(dgvDescripcion)
        lb.Items.Add(dgvFecha)
        lb.Items.Add(dgvHora)
        lb.Items.Add(dgvValor)


        MainClass.cargarDatos(consulta, dgvEyS, lb)
    End Sub

    Private Sub bImprimir_Click(sender As Object, e As EventArgs) Handles bImprimir.Click
        PrintDocument1.Print()
    End Sub


    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim fuente As System.Drawing.Font = New Font("consolas", 15)
        Dim topMargin As Double = e.MarginBounds.Top
        Dim yPos As Double
        Dim count As Integer = 0
        Dim texto As String
        'Dim unidad As Byte = 0
        Dim detalle As String
        Dim valor As Decimal
        Dim tabulacion As String
        Dim tabulacion2 As String
        Dim tabulacion3 As String
        Dim compensador As Integer
        Dim total As Decimal = 0
        Dim fecha As String
        Dim hora As String
        Dim Lvalor As Integer

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
        e.Graphics.DrawString("-----------------------------------", printFont, Brushes.Black, 10, 280)


        For Each row As DataGridViewRow In dgvEyS.Rows
            Lvalor = Len(row.Cells("dgvValor").FormattedValue.ToString)
            detalle = row.Cells("dgvDescripcion").Value
            fecha = row.Cells("dgvFecha").Value.ToString().Replace("0:00:00", "")
            hora = row.Cells("dgvHora").Value.ToString()
            valor = row.Cells("dgvValor").FormattedValue
            ' Lvalor = Len(row.Cells("dgvPrecioTotal").FormattedValue.ToString)
            compensador = Len(row.Cells("dgvDescripcion").Value)
            tabulacion = StrDup(22 - compensador, " ")
            tabulacion2 = StrDup(17, " ")
            tabulacion3 = StrDup(17 - Lvalor, " ")
            texto = detalle & tabulacion & fecha & tabulacion2 & hora & tabulacion3 & valor 'Configura la linea
            yPos = 220 + topMargin + (count * printFont.GetHeight(e.Graphics)) ' Calcula la posición en la que se escribe la línea
            ' Imprime la línea con el objeto Graphics
            If Not row.IsNewRow Then
                e.Graphics.DrawString(texto, printFont, System.Drawing.Brushes.Black, 10, yPos)
                total += valor
            End If
            count += 1
        Next

    End Sub

    Private Sub cbFiltros_CheckedChanged(sender As Object, e As EventArgs) Handles cbFiltros.CheckedChanged
        If cbFiltros.Checked Then
            Panel1.Hide()
        Else
            Panel1.Show()
        End If
    End Sub
End Class