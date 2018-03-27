Imports System.Data.SqlClient
Public Class FormStart
    Dim connectionString As String = "Data Source=(Local); Initial Catalog=Base_ChocolateProducts;" _
    & "Integrated Security=True;Connect Timeout=30"
    Private Sub ButtonNewOrder_Click_1(sender As Object, e As EventArgs) Handles ButtonNewOrder.Click
        Dim NewForm As New FormAddOrder()
        NewForm.ShowDialog()
    End Sub

    Private Sub ButtonNewStock_Click(sender As Object, e As EventArgs) Handles ButtonNewStock.Click
        Dim NewForm As New FormStock()
        NewForm.ShowDialog()
    End Sub

    Private Sub ButtonNewProduct_Click(sender As Object, e As EventArgs) Handles ButtonNewProduct.Click
        Dim NewForm As New FormProduct()
        NewForm.ShowDialog()
    End Sub

    Private Sub FormStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetOverdue()
    End Sub

    Sub GetOverdue() 'Метод для автоматической проверки на просроченную продукцию
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                'Dim cmd = New OleDbCommand("Update_Client", connection)
                Dim cmd = New SqlCommand("ПроверкаПросроченности", connection)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.ExecuteNonQuery()
                connection.Close()
            End Using
            MsgBox("Был осуществлен контроль сроков хранения продукции", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Что-то пошло не так", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub ButtonNewFinishOrder_Click(sender As Object, e As EventArgs) Handles ButtonNewFinishOrder.Click
        Dim NewForm As New FormOrder()
        NewForm.ShowDialog()
    End Sub

    Private Sub ButtonNewBad_Click(sender As Object, e As EventArgs) Handles ButtonNewBad.Click
        Dim NewForm As New FormBadProduct()
        NewForm.ShowDialog()
    End Sub

    Private Sub ButtonNewReport_Click(sender As Object, e As EventArgs) Handles ButtonNewReport.Click
        Dim NewForm As New FormReport()
        NewForm.ShowDialog()
    End Sub
End Class