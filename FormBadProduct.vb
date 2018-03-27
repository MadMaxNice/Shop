Imports System.Data.SqlClient
Public Class FormBadProduct

    Dim connectionString As String = "Data Source=(Local); Initial Catalog=Base_ChocolateProducts;" _
    & "Integrated Security=True;Connect Timeout=30"
    Sub GetBadProduct() 'Метод для получения списанной продукции и вывода ее на экран в DGV
        DataGridViewBad.Rows.Clear()
        Using connection As New SqlConnection(connectionString)
            Dim cmd = New SqlCommand("ПолучитьСписание", connection)
            cmd.CommandType = CommandType.StoredProcedure
            connection.Open()
            Dim dataReader As SqlDataReader = cmd.ExecuteReader()
            Do While dataReader.Read()
                DataGridViewBad.Rows.Add(dataReader(0), dataReader(1), dataReader(2), dataReader(3))
            Loop
            connection.Close()
        End Using
    End Sub
    Private Sub FormBadProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetBadProduct()
    End Sub

End Class