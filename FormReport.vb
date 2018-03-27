Imports System.Data.SqlClient
Imports Word = Microsoft.Office.Interop.Word
Imports System.IO
Public Class FormReport
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        'Огромный метод для генерации отчета по количеству списанных товаров
        'Используем подключение к БД по ADO.NET технологии, получаем списанные товары
        'После чего формируем текстовую строку и ее выгружаем при помощи Interop Word в файл

        Dim Text As String
        Dim Count As Integer
        Dim connectionString As String = "Data Source=(Local); Initial Catalog=Base_ChocolateProducts;" _
    & "Integrated Security=True;Connect Timeout=30"
        Using connection As New SqlConnection(connectionString)
            Dim cmd = New SqlCommand("КоличествоСписаннойПродукции", connection)
            cmd.CommandType = CommandType.StoredProcedure
            connection.Open()
            Dim dataReader As SqlDataReader = cmd.ExecuteReader()
            Do While dataReader.Read()
                Count = dataReader(0)
            Loop
            connection.Close()
        End Using
        Text = "За время работы магазина было списано " + Count.ToString() + " единиц продукции." + vbNewLine
        Text = Text + "В связи с чем магазин не получит значительное количество прибыли. Подробную информацию можно посмотреть на вкладке СПИСАНИЕ"
        Dim objWord As Word.Application
        Dim objDoc As Word.Document
        objWord = CreateObject("Word.Application")
        objDoc = objWord.Documents.Open(Directory.GetCurrentDirectory + "/ReportBad.docx")
        objWord.Visible = True
        With objWord
            .ActiveDocument.Bookmarks("Date").Range.Text = DateTime.Now.Date
            .ActiveDocument.Bookmarks("Text").Range.Text = Text
            objDoc.SaveAs(Directory.GetCurrentDirectory + "/" + "Отчет о списании за " + DateTime.Now.Date + ".docx")
        End With
    End Sub

    Private Sub FormReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class