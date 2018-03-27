<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddToStock
    Inherits MetroFramework.Forms.MetroForm

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.ComboBoxNameProduct = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.TextBoxNumber = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.ComboBoxProvider = New MetroFramework.Controls.MetroComboBox()
        Me.TextBoxCount = New System.Windows.Forms.TextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.TextBoxBestBefore = New System.Windows.Forms.MaskedTextBox()
        Me.ButtonAdd = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(8, 92)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(61, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Изделие"
        '
        'ComboBoxNameProduct
        '
        Me.ComboBoxNameProduct.FormattingEnabled = True
        Me.ComboBoxNameProduct.ItemHeight = 23
        Me.ComboBoxNameProduct.Items.AddRange(New Object() {""})
        Me.ComboBoxNameProduct.Location = New System.Drawing.Point(87, 88)
        Me.ComboBoxNameProduct.Name = "ComboBoxNameProduct"
        Me.ComboBoxNameProduct.Size = New System.Drawing.Size(268, 29)
        Me.ComboBoxNameProduct.TabIndex = 29
        Me.ComboBoxNameProduct.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(8, 63)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(73, 19)
        Me.MetroLabel2.TabIndex = 30
        Me.MetroLabel2.Text = "№ партии"
        '
        'TextBoxNumber
        '
        '
        '
        '
        Me.TextBoxNumber.CustomButton.Image = Nothing
        Me.TextBoxNumber.CustomButton.Location = New System.Drawing.Point(246, 1)
        Me.TextBoxNumber.CustomButton.Name = ""
        Me.TextBoxNumber.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.TextBoxNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TextBoxNumber.CustomButton.TabIndex = 1
        Me.TextBoxNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TextBoxNumber.CustomButton.UseSelectable = True
        Me.TextBoxNumber.CustomButton.Visible = False
        Me.TextBoxNumber.Lines = New String(-1) {}
        Me.TextBoxNumber.Location = New System.Drawing.Point(87, 59)
        Me.TextBoxNumber.MaxLength = 32767
        Me.TextBoxNumber.Name = "TextBoxNumber"
        Me.TextBoxNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBoxNumber.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TextBoxNumber.SelectedText = ""
        Me.TextBoxNumber.SelectionLength = 0
        Me.TextBoxNumber.SelectionStart = 0
        Me.TextBoxNumber.ShortcutsEnabled = True
        Me.TextBoxNumber.Size = New System.Drawing.Size(268, 23)
        Me.TextBoxNumber.TabIndex = 31
        Me.TextBoxNumber.UseSelectable = True
        Me.TextBoxNumber.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TextBoxNumber.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(5, 127)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(76, 19)
        Me.MetroLabel3.TabIndex = 32
        Me.MetroLabel3.Text = "Поставщик"
        '
        'ComboBoxProvider
        '
        Me.ComboBoxProvider.FormattingEnabled = True
        Me.ComboBoxProvider.ItemHeight = 23
        Me.ComboBoxProvider.Items.AddRange(New Object() {""})
        Me.ComboBoxProvider.Location = New System.Drawing.Point(87, 123)
        Me.ComboBoxProvider.Name = "ComboBoxProvider"
        Me.ComboBoxProvider.Size = New System.Drawing.Size(268, 29)
        Me.ComboBoxProvider.TabIndex = 33
        Me.ComboBoxProvider.UseSelectable = True
        '
        'TextBoxCount
        '
        Me.TextBoxCount.Location = New System.Drawing.Point(87, 158)
        Me.TextBoxCount.Name = "TextBoxCount"
        Me.TextBoxCount.Size = New System.Drawing.Size(66, 20)
        Me.TextBoxCount.TabIndex = 34
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(5, 158)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(79, 19)
        Me.MetroLabel4.TabIndex = 35
        Me.MetroLabel4.Text = "Количество"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(8, 189)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(64, 19)
        Me.MetroLabel5.TabIndex = 36
        Me.MetroLabel5.Text = "Годен до"
        '
        'TextBoxBestBefore
        '
        Me.TextBoxBestBefore.Location = New System.Drawing.Point(87, 189)
        Me.TextBoxBestBefore.Mask = "00/00/0000"
        Me.TextBoxBestBefore.Name = "TextBoxBestBefore"
        Me.TextBoxBestBefore.Size = New System.Drawing.Size(66, 20)
        Me.TextBoxBestBefore.TabIndex = 37
        Me.TextBoxBestBefore.ValidatingType = GetType(Date)
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Location = New System.Drawing.Point(119, 215)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(140, 27)
        Me.ButtonAdd.TabIndex = 38
        Me.ButtonAdd.Text = "Добавить"
        Me.ButtonAdd.UseSelectable = True
        '
        'FormAddToStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 255)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.TextBoxBestBefore)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.TextBoxCount)
        Me.Controls.Add(Me.ComboBoxProvider)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.TextBoxNumber)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.ComboBoxNameProduct)
        Me.Controls.Add(Me.MetroLabel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormAddToStock"
        Me.Style = MetroFramework.MetroColorStyle.Red
        Me.Text = "Поступление товара"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ComboBoxNameProduct As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents TextBoxNumber As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ComboBoxProvider As MetroFramework.Controls.MetroComboBox
    Friend WithEvents TextBoxCount As TextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents TextBoxBestBefore As MaskedTextBox
    Friend WithEvents ButtonAdd As MetroFramework.Controls.MetroButton
End Class
