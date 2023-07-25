Public Class VAgregarReserva
    Dim fecha As String
    Dim hora As String
    Public id As String
    Public id_reserva As String
    Private Sub bAceptar_Click(sender As Object, e As EventArgs) Handles bAceptar.Click
        fecha = dFecha.Value.Year.ToString + "-" + dFecha.Value.Month.ToString + "-" + dFecha.Value.Day.ToString
        hora = dHora.Value.Hour.ToString + ":" + dHora.Value.Minute.ToString + ":" + dHora.Value.Second.ToString

        If String.IsNullOrEmpty(tNombre.Text) Then
            MessageBox.Show("Ingrese un Nombre válido.")
            Return
        End If

        Dim consulta As String = ""
        Dim consulta2 As String = ""

        If id_reserva = 0 Then
            consulta = "insert into reservas(id_mesa,nombre,fecha,hora)
                                        values(@id_mesa,@nombre,@fecha,@hora)"
            consulta2 = "update mesas set estado='Con reservas' where id_mesa='" + id + "'"
        Else
            consulta = "update reservas set(nombre,fecha,hora)
                                         values(@nombre,@fecha,@hora) where id_reserva='" + id_reserva + "'"
        End If


        Dim ht As Hashtable = New Hashtable()
        Dim ht2 As Hashtable = New Hashtable()

        ht.Add("@id_mesa", id)
        ht.Add("@nombre", tNombre.Text)
        ht.Add("@fecha", fecha)
        ht.Add("@hora", hora)

        If MainClass.SQL(consulta, ht) > 0 Then
            MainClass.SQL(consulta2, ht2)
            MessageBox.Show("Se guardó correctamente")
            tNombre.Text = ""
            Me.Hide()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    '  Private Sub VAgregarReserva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    '      Label1.ForeColor = Color.Black
    '      Label2.ForeColor = Color.Black
    '      Label3.ForeColor = Color.Black
    '      tNombre.BackColor = Color.FromArgb(130, 130, 130)
    '      tNombre.ForeColor = Color.Black
    '      'bAceptar
    '      'Button2
    '  End Sub
    '
    '  Sub CambiarTemaOscuro()
    '      Me.BackColor = Color.FromArgb(96, 96, 96)
    '      Label1.ForeColor = Color.White
    '      Label2.ForeColor = Color.White
    '      Label3.ForeColor = Color.White
    '      tNombre.BackColor = Color.FromArgb(125, 125, 125)
    '      tNombre.ForeColor = Color.White
    '      'bAceptar
    '      'Button2
    '  End Sub

End Class