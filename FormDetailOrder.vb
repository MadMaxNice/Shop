Imports System.Data.SqlClient
Public Class FormDetailOrder

    Dim connectionString As String = "Data Source=(Local); Initial Catalog=Base_ChocolateProducts;" _
        & "Integrated Security=True;Connect Timeout=30" 'Строка подключения
    'Метод для загрузки информации по заказу
    Sub LoadOrderDetail(Number As Integer)
        Using connection As New SqlConnection(connectionString)
            Dim cmd = New SqlCommand("ПолучитьЧек", connection)
            cmd.CommandType = CommandType.StoredProcedure
            connection.Open()
            cmd.Parameters.AddWithValue("@НомерЗаказа", Number) ';
            Dim dataReader As SqlDataReader = cmd.ExecuteReader()
            Do While dataReader.Read()
                'Получаем заказ и сотрудника
                ListBoxOrder.Items.Add(dataReader(0).ToString() + " " + dataReader(1).ToString() + " " + dataReader(2).ToString())
                LabelPeople.Text = dataReader(3) + " " + dataReader(4) + " " + dataReader(5)

            Loop
            connection.Close()
        End Using
        Using connection As New SqlConnection(connectionString)
            Dim cmd = New SqlCommand("ПолучитьСуммуЧека", connection)
            cmd.CommandType = CommandType.StoredProcedure
            connection.Open()
            cmd.Parameters.AddWithValue("@НомерЗаказа", Number) ';
            Dim dataReader As SqlDataReader = cmd.ExecuteReader()
            Do While dataReader.Read()
                'Получаем общую сумму заказа
                LabelSumAll.Text = dataReader(0)
            Loop
            connection.Close()
        End Using
    End Sub
    Private Sub FormDetailOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim file = My.Computer.FileSystem.OpenTextFileReader("temp.txt")
        LoadOrderDetail(file.ReadLine())
        file.Close()
    End Sub
End Class