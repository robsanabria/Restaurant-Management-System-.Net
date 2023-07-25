Imports System.Net
Imports System.Net.Mail

Public Class PantallaBloqueo

    'Botón para entrar al menú principal validando el pin ingresado
    Private Sub bEntrar_Click(sender As Object, e As EventArgs) Handles bEntrar.Click
        If (MainClass.pinValido(tPin.Text)) = False Then
            MessageBox.Show("PIN ingresado incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Me.Hide()
            MenuPrincipal.Show()
            tPin.Text = ""
        End If

    End Sub

    Private Sub EnviarCorreoCodigo(destinatario As String, codigoPIN As String)
        Try
            Dim remitente As New MailAddress("eric.secchiari.sistema@gmail.com", "Polo Opuesto") 'aca poner el mail de poloopuesto
            Dim destinatarioCorreo As New MailAddress(destinatario)
            Dim mensaje As New MailMessage(remitente, destinatarioCorreo)


            mensaje.Subject = "MODIFICACION DE CONTRASEÑA"
            mensaje.Body = "Saludos Señor Dechert, este es un mensaje para la obtencion de su PIN olvidado. Su numero de Pin actual es: " & codigoPIN


            Dim smtpCliente As New SmtpClient("smtp.gmail.com", 587)
            smtpCliente.EnableSsl = True
            smtpCliente.Credentials = New NetworkCredential("eric.secchiari.sistema@gmail.com", "ykeyaoentxoljdlx") 'aca cambiar ambos por los del dueño


            smtpCliente.Send(mensaje)

            MessageBox.Show("PIN enviado correctamente, por favor verifique su buzon de correo.", "Verifique su buzon", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al enviar el correo de su PIN: " & ex.Message, "Error de envío", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Botón para cerrar el programa
    Private Sub bSalirBloqueo_Click(sender As Object, e As EventArgs) Handles bSalirBloqueo.Click
        Application.Exit()

    End Sub

    Private Sub PantallaBloqueo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LHora.Text = DateTime.Now.ToString("HH:mm")
        Dim fechaActual As DateTime = DateTime.Now
        Dim fechaFormateada As String = fechaActual.ToString("dddd dd 'de' MMMM 'de' yyyy")
        LFecha.Text = fechaFormateada
    End Sub

    Private Sub LHora_Click(sender As Object, e As EventArgs) Handles LHora.Click
        PantallaDifuminada()
    End Sub

    Private Sub LFecha_Click(sender As Object, e As EventArgs) Handles LFecha.Click
        PantallaDifuminada()
    End Sub

    Sub PantallaDifuminada()


        Me.BackgroundImage = My.Resources.FondoD


        LHora.Visible() = False
        LFecha.Visible() = False
        BDifuminar.Visible() = False
        PLogo.Visible() = True
        LNombre.Visible() = True
        LOlvide.Visible() = True
        lPin.Visible() = True
        tPin.Visible() = True
        bEntrar.Visible() = True
        bAtrasBloqueo.Visible() = True
        bSalirBloqueo.Visible() = True

    End Sub

    Private Sub bAtrasBloqueo_Click(sender As Object, e As EventArgs) Handles bAtrasBloqueo.Click
        Me.BackgroundImage = My.Resources.Fondo
        LHora.Visible() = True
        LFecha.Visible() = True
        BDifuminar.Visible() = True
    End Sub

    Private Sub BDifuminar_Click(sender As Object, e As EventArgs) Handles BDifuminar.Click
        PantallaDifuminada()
    End Sub

    Private Sub LOlvide_Click(sender As Object, e As EventArgs) Handles LOlvide.Click
        Dim consulta As String = "select * from pines where id=1"
        Dim pin As String = MainClass.SQL_pin(consulta)


        EnviarCorreoCodigo("dechertguillermo@gmail.com", pin)
    End Sub

    Private Sub tPin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tPin.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then

            bEntrar.PerformClick()
            e.Handled = True
        End If
    End Sub
End Class
