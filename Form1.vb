Imports System.Data.SqlClient
Imports Word = Microsoft.Office.Interop.Word
Imports System.IO
Public Class FormAddOrder
    Dim y As Integer = 10
    Dim ListItem As New List(Of TextBox)
    Dim ListCount As New List(Of TextBox)
    Dim ListCost As New List(Of TextBox)
    Dim ListSum As New List(Of TextBox)
    Dim ListDeleteButton As New List(Of Button)
    Dim ListTempForDeleteCount As New List(Of Integer) 'Листы для хранения данных
    Dim ListTempForDeleteIndex As New List(Of Integer)
    Dim ListPar As New List(Of Integer)
    Dim IDButtonTemp As Integer
    Dim NumberButton As Integer
    Dim IDItem As Integer
    Dim NumberPar As Integer

    Private Sub FormAddOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxType.Items.Add("") 'Добавляем пустые строки в комбобоксы
        ComboBoxVariety.Items.Add("")
        LoadProductType()
        LoadProductVariety()
        ComboBoxType.SelectedIndex = 0
        ComboBoxVariety.SelectedIndex = 0
        ' LoadProduct()
        LabelNumberOrder.Text = GetNumberOrder()
        Dim file = My.Computer.FileSystem.OpenTextFileReader("People.txt") 'В файле хранится номер сотрудника
        LabelPeople.Text = (file.ReadLine())
        file.Close()
    End Sub
    Private Sub ComboBoxNameProduct_SelectedIndexChanged_1(sender As Object, e As EventArgs)
        CountBarItem.Value = 0
        CountBarItem.Maximum = 0
        LabelCount.Text = 0
        LoadProductCost()
        GetIDItem() 'Вызываем метод для получения ID заказа
        LoadProductCount()

    End Sub
    Private Sub ComboBoxNameProduct_SelectedIndexChanged(sender As Object, e As EventArgs)
        ComboBoxNameProduct.Items.Clear()
        LoadProduct() 'Вызываем метод для загрузки изделий
    End Sub

    Dim connectionString As String = "Data Source=(Local); Initial Catalog=Base_ChocolateProducts;" _
    & "Integrated Security=True;Connect Timeout=30" 'Объявляем строку подключения к БД

    Sub LoadProduct() ' Метод для получения изделия по заданным характеристикам
        Using connection As New SqlConnection(connectionString)
            Dim cmd = New SqlCommand("ПолучитьИзделие", connection)
            cmd.CommandType = CommandType.StoredProcedure
            connection.Open()
            cmd.Parameters.AddWithValue("@Вид", ComboBoxType.SelectedItem) ';
            cmd.Parameters.AddWithValue("@Сорт", ComboBoxVariety.SelectedItem)
            Dim dataReader As SqlDataReader = cmd.ExecuteReader()
            Do While dataReader.Read()
                ComboBoxNameProduct.Items.Add(dataReader(0))
            Loop
            connection.Close()
        End Using
    End Sub

    Public Function GetIDItem() 'Метод для получения ID выбранного элемента
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim cmd = New SqlCommand("ПолучитьНомер", connection)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Вид", ComboBoxType.SelectedItem)
            cmd.Parameters.AddWithValue("@Сорт", ComboBoxVariety.SelectedItem)
            cmd.Parameters.AddWithValue("@Название", ComboBoxNameProduct.SelectedItem)
            NumberPar = cmd.ExecuteScalar()
            connection.Close()
        End Using

    End Function

    Public Function GetNumberOrder() As String 'Функция для генерации номера заказа
        Dim NumStr As String
        NumStr = DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second
        Return NumStr
    End Function

    Sub SetNewPositionOnOrder(IDItem As Integer) 'Добавление новой позиции в БД по заданным характеристикам
        GetIDItem()
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            'Dim cmd = New OleDbCommand("Update_Client", connection)
            Dim cmd = New SqlCommand("НовыйЗаказ", connection)
            cmd.CommandType = CommandType.StoredProcedure
            'cmd.Parameters.AddWithValue("@ID", Name)
            cmd.Parameters.AddWithValue("@НомерЗаказа", CInt(LabelNumberOrder.Text))
            cmd.Parameters.AddWithValue("@НомерИзделия", CInt(IDItem))
            cmd.Parameters.AddWithValue("@НомерСотрудника", CInt(LabelPeople.Text))
            cmd.Parameters.AddWithValue("@Количество", CInt(LabelCount.Text))
            cmd.Parameters.AddWithValue("@НомерПартии", NumberPar)
            cmd.Parameters.AddWithValue("@Сумма", LabelCount.Text * LabelCost.Text)
            cmd.ExecuteNonQuery()
            connection.Close()
        End Using
    End Sub

    Sub AddNewPositionOrder(TEXT As ComboBox, Count As Label, Cost As Label)
        'Динамичное создание интерфейса заказа
        PanelOrder.Controls.Clear()
        Dim TextBoxPosition As TextBox = New TextBox
        Dim TextBoxCount As TextBox = New TextBox
        Dim TextBoxCost As TextBox = New TextBox
        Dim TextBoxSum As TextBox = New TextBox
        Dim ButtonDelete As Button = New Button
        ' TextBoxPosition.Location = New Point(0, y)
        TextBoxPosition.Size = New Size(300, 21)
        TextBoxPosition.Enabled = False
        TextBoxPosition.BackColor = Color.White

        ' TextBoxCount.Location = New Point(301, y)
        TextBoxCount.Enabled = False
        TextBoxCount.BackColor = Color.White
        TextBoxCount.Size = New Size(40, 21)

        ' TextBoxCost.Location = New Point(342, y)
        TextBoxCost.Enabled = False
        TextBoxCost.BackColor = Color.White
        TextBoxCost.Size = New Size(45, 21)

        ' TextBoxSum.Location = New Point(388, y)
        TextBoxSum.Enabled = False
        TextBoxSum.BackColor = Color.White
        TextBoxSum.Size = New Size(45, 21)

        ' ButtonDelete.Location = New Point(434, y)
        ButtonDelete.Text = "X"
        ButtonDelete.Size = New Size(21, 21)
        ButtonDelete.Name = NumberButton.ToString()
        AddHandler ButtonDelete.Click, AddressOf EventDeletePosition 'Вызов события удаления позиции
        'MessageBox.Show(IDItem)
        TextBoxPosition.Text = TEXT.SelectedItem
        TextBoxCount.Text = Count.Text
        'Отнять от товара
        TextBoxCost.Text = Cost.Text
        TextBoxSum.Text = Count.Text * Cost.Text
        ListItem.Add(TextBoxPosition)
        ListCount.Add(TextBoxCount)
        ListCost.Add(TextBoxCost)
        ListSum.Add(TextBoxSum)
        ListDeleteButton.Add(ButtonDelete)
        ListPar.Add(NumberPar)
        'PanelOrder.Controls.Add(TextBoxPosition)
        'PanelOrder.Controls.Add(TextBoxCount)
        'PanelOrder.Controls.Add(TextBoxCost)
        'PanelOrder.Controls.Add(TextBoxSum)
        UpdateBox() 'Вызываем метод для обновления на экране позиций заказа
        NumberButton = NumberButton + 1
    End Sub

    Sub UpdateBox() 'Метод для обновления интерфейса заказа
        Dim Sum As Double
        y = 10
        PanelOrder.Controls.Clear()
        For i = 0 To ListItem.Count - 1 Step 1
            PanelOrder.Controls.Add(ListItem(i))
            PanelOrder.Controls.Add(ListCount(i))
            PanelOrder.Controls.Add(ListCost(i))
            PanelOrder.Controls.Add(ListSum(i))
            PanelOrder.Controls.Add(ListDeleteButton(i))
            ListItem(i).Name = i.ToString()
            ListCount(i).Name = i.ToString()
            ListCost(i).Name = i.ToString()
            ListSum(i).Name = i.ToString()
            ListDeleteButton(i).Name = i.ToString()

            ListItem(i).Location = New Point(0, y)
            ListCount(i).Location = New Point(301, y)
            ListCost(i).Location = New Point(342, y)
            ListSum(i).Location = New Point(388, y)
            ListDeleteButton(i).Location = New Point(434, y)
            y = y + 25
            Sum = Sum + ListSum(i).Text
        Next
        LabelSum.Text = Sum
    End Sub

    Private Sub EventDeletePosition(sender As Object, e As EventArgs) 'Событие для удаления позиции из заказа
        IDButtonTemp = Integer.Parse(CType(sender, Button).Name) 'Получаем номер для удаления
        'MessageBox.Show(IDButtonTemp.ToString())
        'Удалять по индексу кнопки

        'Выполнить добавление обратно в партию
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            'Dim cmd = New OleDbCommand("Update_Client", connection)
            Dim cmd = New SqlCommand("ОтменитьЗаказ", connection)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@НомерПартии", ListPar(IDButtonTemp))
            cmd.Parameters.AddWithValue("@Количество", ListCount(IDButtonTemp).Text)
            cmd.ExecuteNonQuery()
            connection.Close()
        End Using
        ListItem.RemoveAt(IDButtonTemp)
        ListCost.RemoveAt(IDButtonTemp)
        ListCount.RemoveAt(IDButtonTemp)
        ListSum.RemoveAt(IDButtonTemp)
        ListDeleteButton.RemoveAt(IDButtonTemp)
        ListPar.RemoveAt(IDButtonTemp)
        UpdateBox()
        LoadProductCount()
    End Sub

    Sub LoadProductVariety() 'Метод для получения сорта изделия
        Using connection As New SqlConnection(connectionString)
            Dim cmd = New SqlCommand("ПолучитьСортИзделия", connection)
            cmd.CommandType = CommandType.StoredProcedure
            connection.Open()
            Dim dataReader As SqlDataReader = cmd.ExecuteReader()
            Do While dataReader.Read()
                ComboBoxVariety.Items.Add(dataReader(0))
            Loop
            connection.Close()
        End Using
    End Sub
    Sub LoadProductType() 'Метод для получения вида изделия
        Using connection As New SqlConnection(connectionString)
            Dim cmd = New SqlCommand("ПолучитьВидИзделия", connection)
            cmd.CommandType = CommandType.StoredProcedure
            connection.Open()
            Dim dataReader As SqlDataReader = cmd.ExecuteReader()
            Do While dataReader.Read()
                ComboBoxType.Items.Add(dataReader(0))
            Loop
            connection.Close()
        End Using
    End Sub
    Sub LoadProductCost() 'Метод для получения цены изделия
        Using connection As New SqlConnection(connectionString)
            Dim cmd = New SqlCommand("ПолучитьЦену", connection)
            cmd.CommandType = CommandType.StoredProcedure
            connection.Open()
            cmd.Parameters.AddWithValue("@Вид", ComboBoxType.SelectedItem) ';
            cmd.Parameters.AddWithValue("@Сорт", ComboBoxVariety.SelectedItem)
            cmd.Parameters.AddWithValue("@Название", ComboBoxNameProduct.SelectedItem) ';
            Dim dataReader As SqlDataReader = cmd.ExecuteReader()
            Do While dataReader.Read()
                LabelCost.Text = dataReader(1)
            Loop
            connection.Close()
        End Using
    End Sub
    Sub LoadProductCount() 'Метод для получения общего количества выбранного изделия
        Using connection As New SqlConnection(connectionString)
            Dim cmd = New SqlCommand("ПолучитьКоличество", connection)
            cmd.CommandType = CommandType.StoredProcedure
            connection.Open()
            cmd.Parameters.AddWithValue("@Вид", ComboBoxType.SelectedItem) ';
            cmd.Parameters.AddWithValue("@Сорт", ComboBoxVariety.SelectedItem)
            cmd.Parameters.AddWithValue("@Название", ComboBoxNameProduct.SelectedItem) ';
            Dim dataReader As SqlDataReader = cmd.ExecuteReader()
            LabelMaxCount.Text = 0
            Do While dataReader.Read()
                LabelMaxCount.Text = dataReader(0)
                CountBarItem.Maximum = dataReader(0)
            Loop
            connection.Close()
        End Using
    End Sub
    'Метод для отмены ВСЕГО заказа
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        'Очищаем все листы, в которых хранятся данные
        ListTempForDeleteCount.Clear()
        ListTempForDeleteIndex.Clear()
        ListItem.Clear()
        ListCost.Clear()
        ListCount.Clear()
        ListSum.Clear()
        ListDeleteButton.Clear()
        PanelOrder.Controls.Clear()
        Using connection As New SqlConnection(connectionString)
            Dim cmd = New SqlCommand("ПолучитьДляОтмены", connection)
            cmd.CommandType = CommandType.StoredProcedure
            connection.Open()
            cmd.Parameters.AddWithValue("@НомерЗаказа", CInt(LabelNumberOrder.Text)) ';
            Dim dataReader As SqlDataReader = cmd.ExecuteReader()
            Do While dataReader.Read()
                ListTempForDeleteCount.Add(dataReader(0))
                ListTempForDeleteIndex.Add(dataReader(1))
            Loop
            connection.Close()
        End Using

        For i = 0 To ListTempForDeleteCount.Count - 1 Step 1
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                'Dim cmd = New OleDbCommand("Update_Client", connection)
                Dim cmd = New SqlCommand("ОтменитьЗаказ", connection)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@НомерПартии", ListTempForDeleteIndex(i))
                cmd.Parameters.AddWithValue("@Количество", ListTempForDeleteCount(i))
                cmd.ExecuteNonQuery()
                connection.Close()
            End Using
        Next

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            'Dim cmd = New OleDbCommand("Update_Client", connection)
            Dim cmd = New SqlCommand("УдалениеПоНомеруЗаказа", connection)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@НомерЗаказа", CInt(LabelNumberOrder.Text))

            cmd.ExecuteNonQuery()
            connection.Close()
        End Using

        LoadProductCount()
        UpdateBox() 'Вызов метода для обновления интерфейса на экране
    End Sub
    'Кнопка для добавления позиции в заказ
    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        If CInt(LabelCount.Text) > 0 And CInt(LabelMaxCount.Text) > 0 Then
            AddNewPositionOrder(ComboBoxNameProduct, LabelCount, LabelCost)
            GetIDItem()
            SetNewPositionOnOrder(NumberPar)
            LoadProductCount()
            LabelCount.Text = 0
            CountBarItem.Value = 0
        End If
    End Sub
    'Событие выбора товара
    Private Sub ComboBoxNameProduct_SelectedIndexChanged_2(sender As Object, e As EventArgs) Handles ComboBoxNameProduct.Click
        ComboBoxNameProduct.Items.Clear()
        LoadProduct()
    End Sub
    Private Sub ComboBoxNameProduct_SelectedIndexChanged_3(sender As Object, e As EventArgs) Handles ComboBoxNameProduct.SelectedIndexChanged
        CountBarItem.Value = 0
        ' CountBarItem.Maximum = 0
        LabelCount.Text = 0
        LoadProductCost()
        GetIDItem()
        LoadProductCount()
    End Sub

    Private Sub CountBarItem_Scroll(sender As Object, e As EventArgs) Handles CountBarItem.Scroll
        LabelCount.Text = 0

        LabelCount.Text = CountBarItem.Value
    End Sub

    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click

        PrintAllSum(LabelNumberOrder.Text)
        Me.Close()
    End Sub
    'Событие для генерации чека 
    Sub PrintAllSum(Number As String)
        Try


            Dim result, Position, People As String
            result = ""
            Using connection As New SqlConnection(connectionString)
                Dim cmd = New SqlCommand("ПолучитьЧек", connection)
                cmd.CommandType = CommandType.StoredProcedure
                connection.Open()
                cmd.Parameters.AddWithValue("@НомерЗаказа", Number) ';
                Dim dataReader As SqlDataReader = cmd.ExecuteReader()
                Do While dataReader.Read()
                    Position = Position + dataReader(0).ToString() + " " + dataReader(1).ToString() + " " + dataReader(2).ToString() + vbNewLine
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
                    result = dataReader(0)
                Loop
                connection.Close()
            End Using
            Using connection As New SqlConnection(connectionString)
                Dim cmd = New SqlCommand("ПолучитьСотрудника", connection)
                cmd.CommandType = CommandType.StoredProcedure
                connection.Open()
                cmd.Parameters.AddWithValue("@НомерСотрудника", LabelPeople.Text) ';
                Dim dataReader As SqlDataReader = cmd.ExecuteReader()
                Do While dataReader.Read()
                    People = dataReader(1) + " " + dataReader(2) + " " + dataReader(3)
                Loop
                connection.Close()
            End Using
            'Используем InteropWord
            Dim objWord As Word.Application
            Dim objDoc As Word.Document
            objWord = CreateObject("Word.Application")
            objDoc = objWord.Documents.Open(Directory.GetCurrentDirectory + "/Check.docx")
            objWord.Visible = True
            With objWord
                'Заменяя закладки в шаблоне получаем чек
                .ActiveDocument.Bookmarks("DateTime").Range.Text = DateTime.Now.Date.ToString()
                .ActiveDocument.Bookmarks("People").Range.Text = People
                .ActiveDocument.Bookmarks("Position").Range.Text = Position.ToString()
                .ActiveDocument.Bookmarks("Result").Range.Text = result
                objDoc.SaveAs(Directory.GetCurrentDirectory + "/" + Number + ".docx")
            End With
        Catch ex As Exception
            MsgBox("", MsgBoxStyle.Critical)
        End Try
    End Sub


End Class
