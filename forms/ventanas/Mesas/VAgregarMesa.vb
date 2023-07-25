Imports System.Data.SqlClient

Public Class VAgregarMesa
    Public id As Integer

    Private Sub bGuardarMesa_Click(sender As Object, e As EventArgs) Handles bGuardarMesa.Click
        Dim numero As Integer
        Dim cantSillas As Integer

        ' Validar número de mesa
        If Not Integer.TryParse(tNumero.Text, numero) Then
            MessageBox.Show("Ingrese un número de mesa válido.")
            Return
        End If

        ' Validar cantidad de sillas
        If Not Integer.TryParse(tCantidadSillas.Text, cantSillas) Then
            MessageBox.Show("Ingrese una cantidad de sillas válida.")
            Return
        End If

        ' Validar que el número de mesa no exista
        If MesaExists(numero) Then
            MessageBox.Show("El número de mesa ya existe.")
            Return
        End If

        Dim consulta As String = ""
        Dim ht As Hashtable = New Hashtable()

        If id = 0 Then
            consulta = "insert into mesas(numero,cant_sillas,id_venta_actual,estado) values(@numero,@cant_sillas,@id_venta_actual,@estado)"

            ht.Add("@numero", tNumero.Text)
            ht.Add("@cant_sillas", tCantidadSillas.Text)
            ht.Add("@id_venta_actual", "0")
            ht.Add("@estado", "sin reservas")
        Else
            consulta = "update mesas set numero = @numero, cant_sillas = @cant_sillas where id_mesa = @id_mesa"

            ht.Add("@numero", tNumero.Text)
            ht.Add("@cant_sillas", tCantidadSillas.Text)
            ht.Add("@id_mesa", id.ToString())
        End If


        If MainClass.SQL(consulta, ht) Then
            MessageBox.Show("Se guardó correctamente")
            tNumero.Text = ""
            tCantidadSillas.Text = ""
            Me.Hide()
        End If

    End Sub

    Private Sub bSalirGuardarMesa_Click(sender As Object, e As EventArgs) Handles bSalirGuardarMesa.Click
        Me.Hide()
    End Sub

    Private Function MesaExists(numero As Integer) As Boolean
        Dim consulta As String = "SELECT COUNT(*) FROM mesas WHERE numero = @numero"

        Using connection As SqlConnection = New SqlConnection(MainClass.connectionString)
            connection.Open()

            Using command As SqlCommand = New SqlCommand(consulta, connection)
                command.Parameters.AddWithValue("@numero", numero.ToString())

                Dim result As Object = command.ExecuteScalar()

                If result IsNot Nothing AndAlso Integer.TryParse(result.ToString(), Nothing) AndAlso CInt(result) > 0 Then
                    Return True
                End If
            End Using
        End Using

        Return False
    End Function

    '  Private Sub VAgregarMesa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    '      Me.BackColor = Color.FromArgb(187, 187, 187)
    '      Label1.ForeColor = Color.Black
    '      Label2.ForeColor = Color.Black
    '      tNumero.BackColor = Color.FromArgb(159, 159, 159)
    '      tNumero.ForeColor = Color.Black
    '      tCantidadSillas.BackColor = Color.FromArgb(159, 159, 159)
    '      tCantidadSillas.ForeColor = Color.Black
    '      'bGuardarMesa
    '      'bSalirMesa
    '  End Sub
    '
    '  Sub CambiarTemaOscuro()
    '      Me.BackColor = Color.FromArgb(68, 68, 68)
    '      Label1.ForeColor = Color.White
    '      Label2.ForeColor = Color.White
    '      tNumero.BackColor = Color.FromArgb(96, 96, 96)
    '      tNumero.ForeColor = Color.White
    '      tCantidadSillas.BackColor = Color.FromArgb(96, 96, 96)
    '      tCantidadSillas.ForeColor = Color.White
    '      'bGuardarMesa
    '      'bSalirMesa
    '  End Sub

End Class
