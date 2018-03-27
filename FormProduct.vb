Imports System.Data.SqlClient
Public Class FormProduct
    Dim connectionString As String = "Data Source=(Local); Initial Catalog=Base_ChocolateProducts;" _
    & "Integrated Security=True;Connect Timeout=30"
    Private Sub FormProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProduct()
    End Sub

    Sub LoadProduct() 'Метод для получения списка изделий, имеющихся на складе и вывод в DGV
        Using connection As New SqlConnection(connectionString)
            Dim cmd = New SqlCommand("ПолучитьИзделие", connection)
            cmd.CommandType = CommandType.StoredProcedure
            connection.Open()
            cmd.Parameters.AddWithValue("@Вид", "")
            cmd.Parameters.AddWithValue("@Сорт", "")
            Dim dataReader As SqlDataReader = cmd.ExecuteReader()
            Do While dataReader.Read()
                DataGridViewProduct.Rows.Add(dataReader(0), dataReader(2), dataReader(3), dataReader(4), dataReader(5))
            Loop
            connection.Close()
        End Using
    End Sub

    Private Sub ButtonAddNewProduct_Click(sender As Object, e As EventArgs) Handles ButtonAddNewProduct.Click
        MsgBox("Ждите в следующих версиях", MsgBoxStyle.Information)
    End Sub
End Class