Public Class Bienvenido
    Private Sub Bienvenido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Public Sub ObtenerDatos()
        Dim consulta As String = "select descripcion,tipo_unidad,cantidad from mercaderias where cantidad<'10'"
        Dim lb As ListBox = New ListBox()
        lb.Items.Add(dgvDescripcion)
        lb.Items.Add(dgvTipoUnidad)
        lb.Items.Add(dgvCantidad)

        MainClass.cargarDatos(consulta, dgvMercaderias, lb)
    End Sub

    Sub CambiarTemaClaro()
        '  Me.BackColor = Color.FromArgb(223, 223, 223)
        '  Label1.ForeColor = Color.Black
        '  Label2.ForeColor = Color.Black
        '  Label3.ForeColor = Color.Black
        '  Label4.ForeColor = Color.Black
        '  Label5.ForeColor = Color.Black
        '  Label6.ForeColor = Color.Black
        '  Label7.ForeColor = Color.Black
        '  Button5.Image = My.Resources.minimizarB
        '  Button6.Image = My.Resources.maximizarB
        '  Button7.Image = My.Resources.cerrarB
    End Sub

    Sub CambiarTemaOscuro()
        ' Me.BackColor = Color.FromArgb(32, 32, 32)
        ' Label1.ForeColor = Color.White
        ' Label2.ForeColor = Color.White
        ' Label3.ForeColor = Color.White
        ' Label4.ForeColor = Color.White
        ' Label5.ForeColor = Color.White
        ' Label6.ForeColor = Color.White
        ' Label7.ForeColor = Color.White
        ' Button5.Image = My.Resources.minimizarN
        ' Button6.Image = My.Resources.maximizarN
        ' Button7.Image = My.Resources.cerrarN
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim url As String = "https://www.facebook.com/profile.php?id=100086084727188"
        Process.Start(url)
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim url As String = "https://www.facebook.com/profile.php?id=100086084727188"
        Process.Start(url)
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim url As String = "https://www.instagram.com/polo_opuestogastrobar/"
        Process.Start(url)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim url As String = "https://www.instagram.com/polo_opuestogastrobar/"
        Process.Start(url)
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Dim url As String = "https://web.whatsapp.com/"
        Process.Start(url)
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim url As String = "https://web.whatsapp.com/"
        Process.Start(url)
    End Sub

End Class