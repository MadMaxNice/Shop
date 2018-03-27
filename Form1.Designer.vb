<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAddOrder
    Inherits MetroFramework.Forms.MetroForm

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LabelPeople = New System.Windows.Forms.Label()
        Me.LabelNumberOrder = New System.Windows.Forms.Label()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.ComboBoxVariety = New MetroFramework.Controls.MetroComboBox()
        Me.ComboBoxType = New MetroFramework.Controls.MetroComboBox()
        Me.ComboBoxNameProduct = New MetroFramework.Controls.MetroComboBox()
        Me.PanelOrder = New MetroFramework.Controls.MetroPanel()
        Me.CountBarItem = New System.Windows.Forms.TrackBar()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.LabelSum = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.LabelCost = New MetroFramework.Controls.MetroLabel()
        Me.LabelCount = New MetroFramework.Controls.MetroLabel()
        Me.LabelMaxCount = New MetroFramework.Controls.MetroLabel()
        Me.ButtonNext = New MetroFramework.Controls.MetroButton()
        CType(Me.CountBarItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelPeople
        '
        Me.LabelPeople.AutoSize = True
        Me.LabelPeople.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LabelPeople.Location = New System.Drawing.Point(5, 7)
        Me.LabelPeople.Name = "LabelPeople"
        Me.LabelPeople.Size = New System.Drawing.Size(19, 20)
        Me.LabelPeople.TabIndex = 20
        Me.LabelPeople.Text = "0"
        Me.LabelPeople.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelPeople.Visible = False
        '
        'LabelNumberOrder
        '
        Me.LabelNumberOrder.AutoSize = True
        Me.LabelNumberOrder.Location = New System.Drawing.Point(109, 640)
        Me.LabelNumberOrder.Name = "LabelNumberOrder"
        Me.LabelNumberOrder.Size = New System.Drawing.Size(39, 13)
        Me.LabelNumberOrder.TabIndex = 21
        Me.LabelNumberOrder.Text = "Label2"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(12, 634)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 23)
        Me.MetroButton1.TabIndex = 23
        Me.MetroButton1.Text = "Отменить"
        Me.MetroButton1.UseSelectable = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(193, 212)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(100, 22)
        Me.MetroButton2.TabIndex = 24
        Me.MetroButton2.Text = "Добавить"
        Me.MetroButton2.UseSelectable = True
        '
        'ComboBoxVariety
        '
        Me.ComboBoxVariety.FormattingEnabled = True
        Me.ComboBoxVariety.ItemHeight = 23
        Me.ComboBoxVariety.Location = New System.Drawing.Point(69, 63)
        Me.ComboBoxVariety.Name = "ComboBoxVariety"
        Me.ComboBoxVariety.Size = New System.Drawing.Size(309, 29)
        Me.ComboBoxVariety.TabIndex = 25
        Me.ComboBoxVariety.UseSelectable = True
        '
        'ComboBoxType
        '
        Me.ComboBoxType.FormattingEnabled = True
        Me.ComboBoxType.ItemHeight = 23
        Me.ComboBoxType.Location = New System.Drawing.Point(69, 93)
        Me.ComboBoxType.Name = "ComboBoxType"
        Me.ComboBoxType.Size = New System.Drawing.Size(309, 29)
        Me.ComboBoxType.TabIndex = 26
        Me.ComboBoxType.UseSelectable = True
        '
        'ComboBoxNameProduct
        '
        Me.ComboBoxNameProduct.FormattingEnabled = True
        Me.ComboBoxNameProduct.ItemHeight = 23
        Me.ComboBoxNameProduct.Location = New System.Drawing.Point(69, 125)
        Me.ComboBoxNameProduct.Name = "ComboBoxNameProduct"
        Me.ComboBoxNameProduct.Size = New System.Drawing.Size(309, 29)
        Me.ComboBoxNameProduct.TabIndex = 27
        Me.ComboBoxNameProduct.UseSelectable = True
        '
        'PanelOrder
        '
        Me.PanelOrder.HorizontalScrollbarBarColor = True
        Me.PanelOrder.HorizontalScrollbarHighlightOnWheel = False
        Me.PanelOrder.HorizontalScrollbarSize = 10
        Me.PanelOrder.Location = New System.Drawing.Point(14, 240)
        Me.PanelOrder.Name = "PanelOrder"
        Me.PanelOrder.Size = New System.Drawing.Size(478, 388)
        Me.PanelOrder.TabIndex = 28
        Me.PanelOrder.VerticalScrollbarBarColor = True
        Me.PanelOrder.VerticalScrollbarHighlightOnWheel = False
        Me.PanelOrder.VerticalScrollbarSize = 10
        '
        'CountBarItem
        '
        Me.CountBarItem.Location = New System.Drawing.Point(36, 181)
        Me.CountBarItem.Name = "CountBarItem"
        Me.CountBarItem.Size = New System.Drawing.Size(418, 45)
        Me.CountBarItem.TabIndex = 29
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(318, 640)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(106, 19)
        Me.MetroLabel1.TabIndex = 30
        Me.MetroLabel1.Text = "Сумма покупки:"
        '
        'LabelSum
        '
        Me.LabelSum.AutoSize = True
        Me.LabelSum.Location = New System.Drawing.Point(425, 640)
        Me.LabelSum.Name = "LabelSum"
        Me.LabelSum.Size = New System.Drawing.Size(16, 19)
        Me.LabelSum.TabIndex = 31
        Me.LabelSum.Text = "0"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(9, 66)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(39, 19)
        Me.MetroLabel2.TabIndex = 32
        Me.MetroLabel2.Text = "Сорт"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(11, 99)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(32, 19)
        Me.MetroLabel3.TabIndex = 33
        Me.MetroLabel3.Text = "Вид"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(9, 127)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(61, 19)
        Me.MetroLabel4.TabIndex = 34
        Me.MetroLabel4.Text = "Изделие"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(193, 159)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(79, 19)
        Me.MetroLabel5.TabIndex = 35
        Me.MetroLabel5.Text = "Количество"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(383, 127)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(41, 19)
        Me.MetroLabel6.TabIndex = 36
        Me.MetroLabel6.Text = "Цена"
        '
        'LabelCost
        '
        Me.LabelCost.AutoSize = True
        Me.LabelCost.Location = New System.Drawing.Point(427, 127)
        Me.LabelCost.Name = "LabelCost"
        Me.LabelCost.Size = New System.Drawing.Size(16, 19)
        Me.LabelCost.TabIndex = 37
        Me.LabelCost.Text = "0"
        '
        'LabelCount
        '
        Me.LabelCount.AutoSize = True
        Me.LabelCount.Location = New System.Drawing.Point(9, 181)
        Me.LabelCount.Name = "LabelCount"
        Me.LabelCount.Size = New System.Drawing.Size(16, 19)
        Me.LabelCount.TabIndex = 38
        Me.LabelCount.Text = "0"
        '
        'LabelMaxCount
        '
        Me.LabelMaxCount.AutoSize = True
        Me.LabelMaxCount.Location = New System.Drawing.Point(460, 181)
        Me.LabelMaxCount.Name = "LabelMaxCount"
        Me.LabelMaxCount.Size = New System.Drawing.Size(16, 19)
        Me.LabelMaxCount.TabIndex = 39
        Me.LabelMaxCount.Text = "0"
        '
        'ButtonNext
        '
        Me.ButtonNext.Location = New System.Drawing.Point(403, 28)
        Me.ButtonNext.Name = "ButtonNext"
        Me.ButtonNext.Size = New System.Drawing.Size(89, 23)
        Me.ButtonNext.TabIndex = 40
        Me.ButtonNext.Text = "Продолжить"
        Me.ButtonNext.UseSelectable = True
        '
        'FormAddOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 678)
        Me.Controls.Add(Me.ButtonNext)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.LabelMaxCount)
        Me.Controls.Add(Me.LabelCost)
        Me.Controls.Add(Me.LabelCount)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.ComboBoxNameProduct)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.LabelSum)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.PanelOrder)
        Me.Controls.Add(Me.CountBarItem)
        Me.Controls.Add(Me.ComboBoxType)
        Me.Controls.Add(Me.ComboBoxVariety)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.LabelNumberOrder)
        Me.Controls.Add(Me.LabelPeople)
        Me.Name = "FormAddOrder"
        Me.Style = MetroFramework.MetroColorStyle.Red
        Me.Text = "Новый заказ"
        CType(Me.CountBarItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelPeople As Label
    Friend WithEvents LabelNumberOrder As Label
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents ComboBoxVariety As MetroFramework.Controls.MetroComboBox
    Friend WithEvents ComboBoxType As MetroFramework.Controls.MetroComboBox
    Friend WithEvents ComboBoxNameProduct As MetroFramework.Controls.MetroComboBox
    Friend WithEvents PanelOrder As MetroFramework.Controls.MetroPanel
    Friend WithEvents CountBarItem As TrackBar
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents LabelSum As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents LabelCost As MetroFramework.Controls.MetroLabel
    Friend WithEvents LabelCount As MetroFramework.Controls.MetroLabel
    Friend WithEvents LabelMaxCount As MetroFramework.Controls.MetroLabel
    Friend WithEvents ButtonNext As MetroFramework.Controls.MetroButton
End Class
