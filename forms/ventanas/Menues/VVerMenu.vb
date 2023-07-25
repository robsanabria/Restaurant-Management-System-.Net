Public Class VVerMenu
    Public id As String

    Private Sub VVerMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        Dim consulta As String = "select descripcion, tipo_unidad, cantidad from fila_menu where id_menu='" + CType(id, String) + "'"
        Dim lb As ListBox = New ListBox()
        lb.Items.Add(dgvDescripcion)
        lb.Items.Add(dgvTipoUnidad)
        lb.Items.Add(dgvCantidad)

        MainClass.cargarDatos(consulta, dgvVerMenu, lb)
    End Sub

    '  Sub CambiarTemaClaro()
    '      Me.BackColor = Color.FromArgb(187, 187, 187)
    '      lNombreMenu.ForeColor = Color.Black
    '      dgvVerMenu.BackgroundColor = Color.FromArgb(159, 159, 159)
    '      Label1.ForeColor = Color.Black
    '      Label2.ForeColor = Color.Black
    '      lCosto.ForeColor = Color.Black
    '      lImporte.ForeColor = Color.Black
    '      'Button1
    '  End Sub
    '
    '  Sub CambiarTemaOscuro()
    '      Me.BackColor = Color.FromArgb(68, 68, 68)
    '      lNombreMenu.ForeColor = Color.White
    '      dgvVerMenu.BackgroundColor = Color.FromArgb(96, 96, 96)
    '      Label1.ForeColor = Color.White
    '      Label2.ForeColor = Color.White
    '      lCosto.ForeColor = Color.White
    '      lImporte.ForeColor = Color.White
    '      'Button1
    '  End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub
End Class