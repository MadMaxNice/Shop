Imports System.Data.SqlClient
Public Class FormOrder
    Public IDPar As String
    Dim connectionString As String = "Data Source=(Local); Initial Catalog=Base_ChocolateProducts;" _
    & "Integrated Security=True;Connect Timeout=30"
    Private Sub FormOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOrder() 'Вызов метода
    End Sub

    Sub LoadOrder() 'Метод для получения выполненных заказов и вывода информации в DGV
        Using connection As New SqlConnection(connectionString)
            Dim cmd = New SqlCommand("ПолучитьЗавершенныеОперации", connection)
            cmd.CommandType = CommandType.StoredProcedure
            connection.Open()
            Dim dataReader As SqlDataReader = cmd.ExecuteReader()
            Do While dataReader.Read()
                DataGridViewOrder.Rows.Add(dataReader(0), dataReader(2), dataReader(1))
            Loop
            connection.Close()
        End Using
    End Sub

    Private Sub DataGridViewOrder_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewOrder.CellContentDoubleClick
        Kill("temp.txt")
        IDPar = DataGridViewOrder.Rows(e.RowIndex).Cells(0).Value
        Dim file = My.Computer.FileSystem.OpenTextFileWriter("temp.txt", True)
        file.Write(IDPar)
        file.Close()
        Dim NewForm As New FormDetailOrder()
        NewForm.ShowDialog()
    End Sub
End Class