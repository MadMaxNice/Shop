Imports System.Data.SqlClient
Public Class FormAddToStock
    Dim ListNumberIndex As New List(Of Integer)
    Dim ListNumberIndexProvider As New List(Of Integer)
    Private Sub FormAddToStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProduct()
        LoadProvider()
    End Sub
    Dim connectionString As String = "Data Source=(Local); Initial Catalog=Base_ChocolateProducts;" _
    & "Integrated Security=True;Connect Timeout=30"
    'Метод для получения изделий по заданным характеристикам
    Sub LoadProduct()
        Using connection As New SqlConnection(connectionString)
            Dim cmd = New SqlCommand("ПолучитьИзделие", connection)
            cmd.CommandType = CommandType.StoredProcedure
            connection.Open()
            cmd.Parameters.AddWithValue("@Вид", "")
            cmd.Parameters.AddWithValue("@Сорт", "")
            Dim dataReader As SqlDataReader = cmd.ExecuteReader()
            Do While dataReader.Read()
                ComboBoxNameProduct.Items.Add(dataReader(0))
                ListNumberIndex.Add(dataReader(1))
            Loop
            connection.Close()
        End Using
    End Sub
    'Метод для получения списка поставщиков
    Sub LoadProvider()
        Using connection As New SqlConnection(connectionString)
            Dim cmd = New SqlCommand("ПолучитьПоставщика", connection)
            cmd.CommandType = CommandType.StoredProcedure
            connection.Open()
            Dim dataReader As SqlDataReader = cmd.ExecuteReader()
            Do While dataReader.Read()
                ListNumberIndexProvider.Add(dataReader(0))
                ComboBoxProvider.Items.Add(dataReader(1))
            Loop
            connection.Close()
        End Using
    End Sub
    'Метод для добавления продукции на склад по заданным характеристикам
    Sub AddNewProduct()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim cmd = New SqlCommand("Поступление", connection)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@НомерПартии", CInt(TextBoxNumber.Text))
                cmd.Parameters.AddWithValue("@КодИзделия", CInt(ListNumberIndex(ComboBoxNameProduct.SelectedIndex - 1)))
                cmd.Parameters.AddWithValue("@ПорядковыйНомерПоставщик", CInt(ListNumberIndexProvider(ComboBoxProvider.SelectedIndex - 1)))
                cmd.Parameters.AddWithValue("@Количество", CInt(TextBoxCount.Text))
                cmd.Parameters.AddWithValue("@ГоденДо", TextBoxBestBefore.Text)
                cmd.ExecuteNonQuery()
                connection.Close()
            End Using
        Catch ex As Exception
            MsgBox("Проверьте введенные данные!", MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        AddNewProduct()
    End Sub
End Class