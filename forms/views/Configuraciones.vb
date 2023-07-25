Imports System.Net
Imports System.Net.Mail

Public Class Configuraciones
        Private Sub Configuraciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '        RBClaro.Checked = My.Settings.Claro
        '        RBOscuro.Checked = My.Settings.Oscuro
        '
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
    End Sub

    Private Sub bModificarContra_Click(sender As Object, e As EventArgs) Handles bModificarContra.Click
        Dim contraActual As String = tContraActual.Text
        Dim contraNueva1 As Integer
        Dim contraNueva2 As String = tContraNueva2.Text
        Dim consulta As String = "select * from pines where id=1"
        Dim pin As String = MainClass.SQL_pin(consulta)

        If pin <> contraActual Then
            MessageBox.Show("Pin actual inválido.")
            Return
        End If

        If Not Integer.TryParse(tContraNueva1.Text, contraNueva1) Or contraNueva1 <= 0 Or contraNueva1.ToString().Length <> 4 Then
            MessageBox.Show("Pin inválido, debe contener un número entero positivo de 4 dígitos.")
            Return
        End If

        If contraNueva1.ToString() <> contraNueva2 Then
            MessageBox.Show("El pin nuevo ingresado no coincide.")
            Return
        End If


        Dim consulta2 As String = "update pines set pin='" + contraNueva1.ToString() + "' where id=1"
        Dim ht As Hashtable = New Hashtable()
        MainClass.SQL(consulta2, ht)

        EnviarCorreoValidacion("dechertguillermo@gmail.com", contraNueva1)
    End Sub

    Private Function GenerarNumeroRandom(ByRef numero As Integer) As String
            Dim rnd As New Random()
            numero = rnd.Next(0, 10000)


            Return numero.ToString("D4")
        End Function



        Private Sub EnviarCorreoValidacion(destinatario As String, codigoValidacion As String)
        Try
            Dim remitente As New MailAddress("eric.secchiari.sistema@gmail.com", "Polo Opuesto") 'aca poner el mail de poloopuesto
            Dim destinatarioCorreo As New MailAddress(destinatario)
            Dim mensaje As New MailMessage(remitente, destinatarioCorreo)


            mensaje.Subject = "MODIFICACION DE CONTRASEÑA"
            mensaje.Body = "Saludos Señor Dechert, le informamos que se hizo un cambio de contraseña recientemente, recuerde que sin ella no podra acceder a la aplicacion, por ende, no podra hacer uso de ella, para poder ingresar coloque este codigo de 4 digitos en la casilla de PIN por favor:  " & codigoValidacion


            Dim smtpCliente As New SmtpClient("smtp.gmail.com", 587)
            smtpCliente.EnableSsl = True
            smtpCliente.Credentials = New NetworkCredential("eric.secchiari.sistema@gmail.com", "ykeyaoentxoljdlx") 'aca cambiar ambos por los del dueño


            smtpCliente.Send(mensaje)

            MessageBox.Show("Contraseña modificada correctamente, por favor verifique su buzon de correo.", "Verifique su buzon", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al enviar el correo de validación: " & ex.Message, "Error de envío", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '  Public Sub RBClaro_CheckedChanged(sender As Object, e As EventArgs) Handles RBClaro.CheckedChanged
    '
    '      My.Settings.Claro = RBClaro.Checked
    '      My.Settings.Save()
    '
    '      CambiarTemaClaro()
    '
    '  End Sub
    '
    '  Public Sub RBOscuro_CheckedChanged(sender As Object, e As EventArgs) Handles RBOscuro.CheckedChanged
    '
    '
    '
    '      My.Settings.Oscuro = RBOscuro.Checked
    '      My.Settings.Save()
    '
    '      CambiarTemaOscuro()
    '
    '
    '  End Sub
    '
    '  Sub CambiarTemaClaro()
    '          'agregar boton
    '          Label1.ForeColor = Color.Black
    '          Label2.ForeColor = Color.Black
    '          Label3.ForeColor = Color.Black
    '          RBClaro.ForeColor = Color.Black
    '          RBOscuro.ForeColor = Color.Black
    '          Me.BackColor = Color.FromArgb(223, 223, 223)
    '          MenuPrincipal.pNavegacion.BackColor = Color.FromArgb(223, 223, 223)
    '          'MenuPrincipal.bSalirMenuP
    '          MenuPrincipal.Label1.ForeColor = Color.Black
    '          MenuPrincipal.Label2.ForeColor = Color.Black
    '          'MenuPrincipal.Button2
    '          'MenuPrincipal.bCMesas
    '          'MenuPrincipal.bMercaderia
    '          'MenuPrincipal.bMenues
    '          'MenuPrincipal.bUtiles
    '          'MenuPrincipal.bEntradaSalida
    '          'MenuPrincipal.Button1
    '          'MenuPrincipal.Button3
    '          'MenuPrincipal.Button4
    '          MenuPrincipal.pCentral.BackColor = Color.FromArgb(223, 223, 223)
    '      'MenuPrincipal.Button5
    '      'MenuPrincipal.Button6
    '      'MenuPrincipal.Button7
    '      Button5.Image = My.Resources.minimizarB
    '      Button6.Image = My.Resources.maximizarB
    '      Button7.Image = My.Resources.cerrarB
    '  End Sub
    '
    '      Sub CambiarTemaOscuro()
    '          'agregar boton
    '          Label1.ForeColor = Color.White
    '          Label2.ForeColor = Color.White
    '          Label3.ForeColor = Color.White
    '          RBClaro.ForeColor = Color.White
    '          RBOscuro.ForeColor = Color.White
    '          Me.BackColor = Color.FromArgb(32, 32, 32)
    '          MenuPrincipal.pNavegacion.BackColor = Color.FromArgb(32, 32, 32)
    '          'MenuPrincipal.bSalirMenuP
    '          MenuPrincipal.Label1.ForeColor = Color.White
    '          MenuPrincipal.Label2.ForeColor = Color.White
    '          'MenuPrincipal.Button2
    '          'MenuPrincipal.bCMesas
    '          'MenuPrincipal.bMercaderia
    '          'MenuPrincipal.bMenues
    '          'MenuPrincipal.bUtiles
    '          'MenuPrincipal.bEntradaSalida
    '          'MenuPrincipal.Button1
    '          'MenuPrincipal.Button3
    '          'MenuPrincipal.Button4
    '          MenuPrincipal.pCentral.BackColor = Color.FromArgb(32, 32, 32)
    '      'MenuPrincipal.Button5
    '      'MenuPrincipal.Button6
    '      'MenuPrincipal.Button7
    '      Button5.Image = My.Resources.minimizarN
    '      Button6.Image = My.Resources.maximizarN
    '      Button7.Image = My.Resources.cerrarN
    '  End Sub
    '
    '

End Class