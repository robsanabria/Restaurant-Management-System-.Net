Imports System.Data.SqlClient
Public Class MainClass
    Public id As Int16 = 0
    'Estas lineas generan la conexión con la base de datos integrada
    Public Shared ReadOnly connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\54113\OneDrive\Escritorio\RestoBar Final\RestoBarGourmetV2\database\RBGDB.mdf;Integrated Security=True"
    Public Shared connection As SqlConnection = New SqlConnection(connectionString)

    'Esta función valida el pin ingresado en la pantalla de bloqueo
    Public Shared Function pinValido(pin As String)
        Dim valido As Boolean = False

        Dim consulta As String = "select * from pines where pin='" + pin + "'"
        Dim comando As SqlCommand = New SqlCommand(consulta, connection)
        Dim dt As DataTable = New DataTable()
        Dim da As SqlDataAdapter = New SqlDataAdapter(comando)
        da.Fill(dt)

        If (dt.Rows.Count > 0) Then

            valido = True

        End If

        Return valido
    End Function


    Public Shared Function SQL(consulta As String, ht As Hashtable)
        Dim res As Integer = 0


        Try
            Dim cmd As SqlCommand = New SqlCommand(consulta, connection)
            cmd.CommandType = CommandType.Text

            For Each item As DictionaryEntry In ht
                cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value)
            Next

            If connection.State = ConnectionState.Closed Then connection.Open()
            res = cmd.ExecuteNonQuery()
            If connection.State = ConnectionState.Open Then connection.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            connection.Close()
        End Try


        Return res
    End Function

    Public Shared Function Id_maximo(consulta As String)

        Dim id As Integer = 0

        Try
            Using command As New SqlCommand(consulta, connection)
                ' Ejecutar la consulta y obtener el resultado
                connection.Open()
                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        ' Obtener el valor máximo y guardarlo en la variable
                        If IsDBNull(reader("maximo")) Then
                            id = 0
                        Else
                            id = reader("maximo")
                        End If


                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            connection.Close()
        End Try
        connection.Close()
        Return id
    End Function

    Public Shared Sub cargarDatos(consulta As String, gv As DataGridView, lb As ListBox)
        Try
            Dim cmd As SqlCommand = New SqlCommand(consulta, connection)
            cmd.CommandType = CommandType.Text

            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim dt As DataTable = New DataTable()
            da.Fill(dt)

            For i = 0 To (lb.Items.Count - 1) Step 1
                Dim colNam1 As String = CType(lb.Items(i), DataGridViewColumn).Name
                gv.Columns(colNam1).DataPropertyName = dt.Columns(i).ToString()
            Next

            gv.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            connection.Close()
        End Try
    End Sub

    Public Shared Sub descontarStock(id_menu As String, cantidad As String)
        Try
            Dim consulta As String = "select * from fila_menu where id_menu='" + id_menu + "'"
            Dim cmd As SqlCommand = New SqlCommand(consulta, connection)
            cmd.CommandType = CommandType.Text

            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim ds As DataSet = New DataSet()
            da.Fill(ds, "menu")

            Dim id_alimento As String
            Dim consulta2 As String
            Dim cant_alimento As String
            Dim cant_a_descontar As String
            Dim ht As Hashtable = New Hashtable()

            For i = 0 To (ds.Tables("menu").Rows.Count - 1) Step 1
                id_alimento = ds.Tables("menu").Rows(i)("id_alimento")
                cant_alimento = ds.Tables("menu").Rows(i)("cantidad")
                cant_a_descontar = cantidad * cant_alimento
                cant_a_descontar = cant_a_descontar.Replace(",", ".")
                consulta2 = "update mercaderias set cantidad = (cantidad- " + cant_a_descontar + "), costo_total= ((cantidad-" + cant_a_descontar + ") * costo_unidad) where id_mercaderia='" + id_alimento + "'"

                SQL(consulta2, ht)

            Next

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            connection.Close()
        End Try
    End Sub

    Public Shared Function reemplazarPunto(cadena As String)

        cadena = cadena.Replace(".", ",")

        Return cadena

    End Function

    Public Shared Function SQL_obs(consulta As String)

        Dim obs As String = ""
        connection.Open()
        Dim da As New SqlDataAdapter(consulta, connection)
        Dim ds As New DataSet()

        da.Fill(ds, "obs")

        If ds.Tables("obs").Rows.Count > 0 Then
            obs = ds.Tables("obs").Rows(0)("observaciones")
        End If

        connection.Close()
        Return obs
    End Function

    Public Shared Function SQL_pin(consulta As String)

        Dim obs As String = ""
        connection.Open()
        Dim da As New SqlDataAdapter(consulta, connection)
        Dim ds As New DataSet()

        da.Fill(ds, "obs")

        If ds.Tables("obs").Rows.Count > 0 Then
            obs = ds.Tables("obs").Rows(0)("pin")
        End If

        connection.Close()
        Return obs
    End Function

    Public Shared Function checkStock(id_menu As String, cantidad As String)

        Try
            Dim consulta As String = "select id_alimento, cantidad from fila_menu where id_menu='" + id_menu + "'"
            Dim cmd As SqlCommand = New SqlCommand(consulta, connection)
            cmd.CommandType = CommandType.Text

            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim ds As DataSet = New DataSet()
            da.Fill(ds, "menu")

            Dim id_alimento As String
            Dim consulta2 As String
            Dim cant_alimento As String
            Dim cant_alimento2 As String
            Dim diferencia As Double

            For i = 0 To (ds.Tables("menu").Rows.Count - 1) Step 1

                id_alimento = ds.Tables("menu").Rows(i)("id_alimento")
                cant_alimento = ds.Tables("menu").Rows(i)("cantidad") * cantidad
                consulta2 = "select cantidad from mercaderias where id_mercaderia='" + id_alimento + "'"

                Dim cmd2 As SqlCommand = New SqlCommand(consulta2, connection)
                cmd2.CommandType = CommandType.Text

                Dim da2 As SqlDataAdapter = New SqlDataAdapter(cmd2)
                Dim ds2 As DataSet = New DataSet()
                da2.Fill(ds2, "stock")

                cant_alimento2 = ds2.Tables("stock").Rows(0)("cantidad")

                diferencia = cant_alimento2 - cant_alimento

                If diferencia < 0 Then
                    connection.Close()
                    Return 1
                End If

            Next

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            connection.Close()
        End Try
        connection.Close()
        Return 0
    End Function

End Class
