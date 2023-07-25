Public Class VAgregarTelefono
    Public Property EditarRegistro As Boolean = False
    Public Property IdRegistro As Integer = 0
    Private Sub bAceptar_Click(sender As Object, e As EventArgs) Handles bAceptar.Click
        Dim descripcion As String = TbDescripcionTel.Text.Trim()
        Dim numeroTelefono As Integer

        ' Validar que se haya ingresado una descripción
        If String.IsNullOrWhiteSpace(descripcion) Then
            MessageBox.Show("Por favor, ingrese una descripción válida.")
            Return
        End If

        ' Validar que se haya ingresado un número de teléfono válido
        If Not Integer.TryParse(TbNumeroTel.Text, numeroTelefono) Then
            MessageBox.Show("Por favor, ingrese un número de teléfono válido.")
            Return
        End If

        ' Validar que el número de teléfono sea positivo
        If numeroTelefono <= 0 Then
            MessageBox.Show("Por favor, ingrese un número de teléfono válido.")
            Return
        End If

        ' Validar la longitud del número de teléfono (opcional)
        If TbNumeroTel.Text.Length < 7 Then
            MessageBox.Show("El número de teléfono debe tener al menos 7 dígitos.")
            Return
        End If

        If EditarRegistro Then
            ' Realizar la actualización del registro en la base de datos utilizando el IdRegistro
            Dim consulta As String = "UPDATE [dbo].[Telefonos] SET [descripcion] = @descripcion, [numero_telefono] = @numeroTelefono WHERE [id_telefono] = @idRegistro"
            Dim ht As Hashtable = New Hashtable()
            ht.Add("@descripcion", descripcion)
            ht.Add("@numeroTelefono", numeroTelefono)
            ht.Add("@idRegistro", IdRegistro)

            If MainClass.SQL(consulta, ht) > 0 Then
                MessageBox.Show("Se actualizó correctamente")
                TbDescripcionTel.Text = ""
                TbNumeroTel.Text = ""
                Me.Hide()
            End If
        Else
            ' Realizar la inserción del nuevo registro en la base de datos
            Dim consulta As String = "INSERT INTO [dbo].[Telefonos] ([descripcion], [numero_telefono]) VALUES (@descripcion, @numeroTelefono)"
            Dim ht As Hashtable = New Hashtable()
            ht.Add("@descripcion", descripcion)
            ht.Add("@numeroTelefono", numeroTelefono)

            If MainClass.SQL(consulta, ht) > 0 Then
                MessageBox.Show("Se guardó correctamente")
                TbDescripcionTel.Text = ""
                TbNumeroTel.Text = ""
                Me.Hide()
            End If
        End If
    End Sub



    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Me.Hide()
    End Sub

    Private Sub TbNumeroTel_TextChanged(sender As Object, e As EventArgs) Handles TbNumeroTel.TextChanged

    End Sub

    ' Private Sub VAgregarTelefono_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '     RBClaro.Checked = My.Settings.Claro
    '     RBOscuro.Checked = My.Settings.Oscuro
    '
    '     If RBClaro.Checked = False Then
    '         CambiarTemaOscuro()
    '     ElseIf RBOscuro.Checked = True Then
    '         CambiarTemaOscuro()
    '     ElseIf RBClaro.Checked = True Then
    '         CambiarTemaClaro()
    '     ElseIf RBOscuro.Checked = False Then
    '         CambiarTemaOscuro()
    '     End If
    ' End Sub
    '
    ' Sub CambiarTemaClaro()
    '     Me.BackColor = Color.FromArgb(187, 187, 187)
    '     Label1.ForeColor = Color.Black
    '     Label2.ForeColor = Color.Black
    '     TbDescripcionTel.BackColor = Color.FromArgb(159, 159, 159)
    '     TbDescripcionTel.ForeColor = Color.Black
    '     TbNumeroTel.BackColor = Color.FromArgb(159, 159, 159)
    '     TbNumeroTel.ForeColor = Color.Black
    '     'bAceptar
    '     'bCancelar
    ' End Sub
    '
    ' Sub CambiarTemaOscuro()
    '     Me.BackColor = Color.FromArgb(68, 68, 68)
    '     Label1.ForeColor = Color.White
    '     Label2.ForeColor = Color.White
    '     TbDescripcionTel.BackColor = Color.FromArgb(96, 96, 96)
    '     TbDescripcionTel.ForeColor = Color.White
    '     TbNumeroTel.BackColor = Color.FromArgb(96, 96, 96)
    '     TbNumeroTel.ForeColor = Color.White
    '     'bAceptar
    '     'bCancelar
    ' End Sub
End Class