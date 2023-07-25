Public Class MenuPrincipal
    '----------------------------------------------------------------------------------------
    'RUTINAS

    'Este sub inserta un formulario, pasado por parametro, dentro de un panel (en este caso pCentral)
    Public Sub agregarControles(f As Form)
        pCentral.Controls.Clear()
        f.Dock = DockStyle.Fill
        f.MdiParent = Me
        pCentral.Controls.Add(f)
        f.Show()
    End Sub

    '-----------------------------------------------------------------------------------------

    'Botón para volver a la pantalla de bloqueo
    Private Sub bSalirMenuP_Click(sender As Object, e As EventArgs) Handles bSalirMenuP.Click
        Me.Hide()
        PantallaBloqueo.Show()
    End Sub




    Private Sub bMercaderia_Click(sender As Object, e As EventArgs) Handles bMercaderia.Click
        agregarControles(New InventarioMercaderia())
    End Sub

    Private Sub bMenues_Click(sender As Object, e As EventArgs) Handles bMenues.Click
        agregarControles(New Menues())
    End Sub

    Private Sub bCMesas_Click(sender As Object, e As EventArgs) Handles bCMesas.Click
        agregarControles(New ControlMesas())
    End Sub

    Private Sub bUtiles_Click(sender As Object, e As EventArgs) Handles bUtiles.Click
        agregarControles(New InventarioUtiles())
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        agregarControles(New Bienvenido())
    End Sub

    Private Sub bEntradaSalida_Click(sender As Object, e As EventArgs) Handles bEntradaSalida.Click
        agregarControles(New EntradaSalida())
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        agregarControles(New AgendaTelefonica())
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        agregarControles(New Configuraciones())
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        agregarControles(New ManualAyuda())
    End Sub

    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        agregarControles(New Bienvenido())

        Me.MaximizedBounds = Screen.FromHandle(Me.Handle).WorkingArea
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub pNavegacion_Paint(sender As Object, e As PaintEventArgs) Handles pNavegacion.Paint

        RBClaro.Checked = My.Settings.Claro
        RBOscuro.Checked = My.Settings.Oscuro

        If RBClaro.Checked = False Then
            CambiarTemaOscuro()
        ElseIf RBOscuro.Checked = True Then
            CambiarTemaOscuro()
        ElseIf RBClaro.Checked = True Then
            CambiarTemaClaro()
        ElseIf RBOscuro.Checked = False Then
            CambiarTemaOscuro()
        End If
    End Sub

    Sub CambiarTemaClaro()
        '     bSalirMenuP.BackgroundImage = My.Resources.atrasB
        '     Label1.ForeColor = Color.Black
        '     Label2.ForeColor = Color.Black
        '     Button2.BackgroundImage = My.Resources.BienvenidaB
        '     bCMesas.BackgroundImage = My.Resources.ControlDeMesasB
        '     bMercaderia.BackgroundImage = My.Resources.ControlMercaderiasB
        '     bMenues.BackgroundImage = My.Resources.MenuDisponibleB
        '     bUtiles.BackgroundImage = My.Resources.InventarioDeUtilesB
        '     bEntradaSalida.BackgroundImage = My.Resources.EntradasYSalidasB
        '     Button1.BackgroundImage = My.Resources.AgendaTelefonicaB
        '     Button3.BackgroundImage = My.Resources.ConfiguracionesB
        '     Button4.BackgroundImage = My.Resources.ManualDeAyudaB
        '     pNavegacion.BackColor = Color.FromArgb(223, 223, 223)
        '     pCentral.BackColor = Color.FromArgb(223, 223, 233)
        '     Button5.BackgroundImage = My.Resources.minimizarB
        '     Button6.BackgroundImage = My.Resources.maximizarB
        '     Button7.BackgroundImage = My.Resources.cerrarB

    End Sub

    Sub CambiarTemaOscuro()
        '    bSalirMenuP.BackgroundImage = My.Resources.atrasN
        '    Label1.ForeColor = Color.White
        '    Label2.ForeColor = Color.White
        '    Button2.BackgroundImage = My.Resources.BienvenidaN
        '    bCMesas.BackgroundImage = My.Resources.ControlDeMesasN
        '    bMercaderia.BackgroundImage = My.Resources.ControlMercaderiasN
        '    bMenues.BackgroundImage = My.Resources.MenuDisponibleN
        '    bUtiles.BackgroundImage = My.Resources.InventarioDeUtilesN
        '    bEntradaSalida.BackgroundImage = My.Resources.EntradasYSalidasN
        '    Button1.BackgroundImage = My.Resources.AgendaTelefonicaN
        '    Button3.BackgroundImage = My.Resources.ConfiguracionesN
        '    Button4.BackgroundImage = My.Resources.ManualDeAyudaN
        '    Me.BackColor = Color.FromArgb(32, 32, 32)
        '    pCentral.BackColor = Color.FromArgb(32, 32, 32)
        '    Button5.BackgroundImage = My.Resources.minimizarN
        '    Button6.BackgroundImage = My.Resources.maximizarN
        '    Button7.BackgroundImage = My.Resources.cerrarN
    End Sub

    Private Sub pCentral_Paint(sender As Object, e As PaintEventArgs) Handles pCentral.Paint
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
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Minimized
        ElseIf Me.WindowState = FormWindowState.Minimized Then
            Me.WindowState = FormWindowState.Normal
        End If


    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim respuesta As Integer
        respuesta = MessageBox.Show("¿Está seguro que desea salir de la aplicación?", "Cerrar aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If respuesta = vbYes Then
            Application.Exit()
        End If
    End Sub

    ' Public Sub RBClaro_CheckedChanged(sender As Object, e As EventArgs) Handles RBClaro.CheckedChanged
    '
    '     My.Settings.Claro = RBClaro.Checked
    '     My.Settings.Save()
    '
    '     CambiarTemaClaro()
    '
    ' End Sub
    '
    ' Public Sub RBOscuro_CheckedChanged(sender As Object, e As EventArgs) Handles RBOscuro.CheckedChanged
    '
    '
    '
    '     My.Settings.Oscuro = RBOscuro.Checked
    '     My.Settings.Save()
    '
    '     CambiarTemaOscuro()
    '
    '
    ' End Sub
End Class