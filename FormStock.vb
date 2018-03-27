Imports System.Data.SqlClient
Public Class FormStock
    Dim connectionString As String = "Data Source=(Local); Initial Catalog=Base_ChocolateProducts;" _
    & "Integrated Security=True;Connect Timeout=30"
    Sub LoadStock() 'Метод для получения списка всех продуктов и вывода информации в DGV
        DataGridViewStock.Rows.Clear()
        Using connection As New SqlConnection(connectionString)
            Dim cmd = New SqlCommand("ПолучитьСклад", connection)
            cmd.CommandType = CommandType.StoredProcedure
            connection.Open()
            cmd.Parameters.AddWithValue("@Поставщик", "")
            cmd.Parameters.AddWithValue("@Изделие", ComboBoxNameProduct.SelectedItem)
            Dim dataReader As SqlDataReader = cmd.ExecuteReader()
            Do While dataReader.Read()
                DataGridViewStock.Rows.Add(dataReader(0), dataReader(1), dataReader(2), dataReader(3), dataReader(4))
            Loop
            connection.Close()
        End Using
    End Sub

    Sub LoadProduct() 'Метод для получения изделия
        Using connection As New SqlConnection(connectionString)
            Dim cmd = New SqlCommand("ПолучитьИзделие", connection)
            cmd.CommandType = CommandType.StoredProcedure
            connection.Open()
            cmd.Parameters.AddWithValue("@Вид", "")
            cmd.Parameters.AddWithValue("@Сорт", "")
            Dim dataReader As SqlDataReader = cmd.ExecuteReader()
            Do While dataReader.Read()
                ComboBoxNameProduct.Items.Add(dataReader(0))
            Loop
            connection.Close()
        End Using

    End Sub

    Private Sub FormStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxNameProduct.SelectedIndex = 0
        LoadProduct() 'Вызорв методов
        LoadStock() 'Вызов методов
    End Sub

    Private Sub ComboBoxNameProduct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxNameProduct.SelectedIndexChanged
        LoadStock()
    End Sub

    Private Sub ButtonAddNewProduct_Click(sender As Object, e As EventArgs) Handles ButtonAddNewProduct.Click
        Dim NewForm As New FormAddToStock()
        NewForm.ShowDialog()

    End Sub
End Class