Imports System.Data.SqlClient
Public Class FormAutorisation
    Dim ListID As New List(Of Integer)
    Dim connectionString As String = "Data Source=(Local); Initial Catalog=Base_ChocolateProducts;" _
    & "Integrated Security=True;Connect Timeout=30" 'Строка подключения
    Private Sub FormAutorisation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetPeople()
        ComboBoxPeople.SelectedIndex = 0
    End Sub

    'Метод для получения списка сотрудников
    Sub GetPeople()
        Using connection As New SqlConnection(connectionString)
            Dim cmd = New SqlCommand("ПолучитьСотрудников", connection)
            cmd.CommandType = CommandType.StoredProcedure
            connection.Open()
            Dim dataReader As SqlDataReader = cmd.ExecuteReader()
            Do While dataReader.Read()
                ListID.Add(dataReader(0))
                ComboBoxPeople.Items.Add(dataReader(1) + " " + dataReader(2) + " " + dataReader(3))
            Loop
            connection.Close()
        End Using
    End Sub
    'Кнопка для авторизации
    Private Sub ButtonAutorisation_Click(sender As Object, e As EventArgs) Handles ButtonAutorisation.Click
        Kill("People.txt")
        Dim file = My.Computer.FileSystem.OpenTextFileWriter("People.txt", True)
        file.Write(ListID(ComboBoxPeople.SelectedIndex))
        file.Close()
        Dim NewForm As New FormStart()
        NewForm.ShowDialog()
    End Sub
    'Кнопка для вызова справки
    Private Sub ButtonHelp_Click(sender As Object, e As EventArgs) Handles ButtonHelp.Click
        Dim NewForm As New FormHelp()
        NewForm.ShowDialog()
    End Sub
End Class