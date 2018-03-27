<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormStock
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
        Me.DataGridViewStock = New System.Windows.Forms.DataGridView()
        Me.НомерПартии = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Изделие = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Поставщик = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Количество = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ГоденДо = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.ComboBoxNameProduct = New MetroFramework.Controls.MetroComboBox()
        Me.ButtonAddNewProduct = New MetroFramework.Controls.MetroButton()
        CType(Me.DataGridViewStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewStock
        '
        Me.DataGridViewStock.AllowUserToAddRows = False
        Me.DataGridViewStock.AllowUserToDeleteRows = False
        Me.DataGridViewStock.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewStock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.НомерПартии, Me.Изделие, Me.Поставщик, Me.Количество, Me.ГоденДо})
        Me.DataGridViewStock.Location = New System.Drawing.Point(20, 66)
        Me.DataGridViewStock.Name = "DataGridViewStock"
        Me.DataGridViewStock.ReadOnly = True
        Me.DataGridViewStock.Size = New System.Drawing.Size(684, 279)
        Me.DataGridViewStock.TabIndex = 0
        '
        'НомерПартии
        '
        Me.НомерПартии.HeaderText = "Номер партии"
        Me.НомерПартии.Name = "НомерПартии"
        Me.НомерПартии.ReadOnly = True
        Me.НомерПартии.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.НомерПартии.Width = 50
        '
        'Изделие
        '
        Me.Изделие.HeaderText = "Изделие"
        Me.Изделие.Name = "Изделие"
        Me.Изделие.ReadOnly = True
        Me.Изделие.Width = 230
        '
        'Поставщик
        '
        Me.Поставщик.HeaderText = "Поставщик"
        Me.Поставщик.Name = "Поставщик"
        Me.Поставщик.ReadOnly = True
        Me.Поставщик.Width = 200
        '
        'Количество
        '
        Me.Количество.HeaderText = "Количество"
        Me.Количество.Name = "Количество"
        Me.Количество.ReadOnly = True
        Me.Количество.Width = 80
        '
        'ГоденДо
        '
        Me.ГоденДо.HeaderText = "Годен до"
        Me.ГоденДо.Name = "ГоденДо"
        Me.ГоденДо.ReadOnly = True
        Me.ГоденДо.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ГоденДо.Width = 80
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(129, 29)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(61, 19)
        Me.MetroLabel1.TabIndex = 1
        Me.MetroLabel1.Text = "Изделие"
        '
        'ComboBoxNameProduct
        '
        Me.ComboBoxNameProduct.FormattingEnabled = True
        Me.ComboBoxNameProduct.ItemHeight = 23
        Me.ComboBoxNameProduct.Items.AddRange(New Object() {""})
        Me.ComboBoxNameProduct.Location = New System.Drawing.Point(212, 24)
        Me.ComboBoxNameProduct.Name = "ComboBoxNameProduct"
        Me.ComboBoxNameProduct.Size = New System.Drawing.Size(324, 29)
        Me.ComboBoxNameProduct.TabIndex = 28
        Me.ComboBoxNameProduct.UseSelectable = True
        '
        'ButtonAddNewProduct
        '
        Me.ButtonAddNewProduct.Location = New System.Drawing.Point(558, 24)
        Me.ButtonAddNewProduct.Name = "ButtonAddNewProduct"
        Me.ButtonAddNewProduct.Size = New System.Drawing.Size(129, 29)
        Me.ButtonAddNewProduct.TabIndex = 29
        Me.ButtonAddNewProduct.Text = "Добавить"
        Me.ButtonAddNewProduct.UseSelectable = True
        '
        'FormStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 353)
        Me.Controls.Add(Me.ButtonAddNewProduct)
        Me.Controls.Add(Me.ComboBoxNameProduct)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.DataGridViewStock)
        Me.Name = "FormStock"
        Me.Style = MetroFramework.MetroColorStyle.Red
        Me.Text = "Склад"
        CType(Me.DataGridViewStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewStock As DataGridView
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ComboBoxNameProduct As MetroFramework.Controls.MetroComboBox
    Friend WithEvents НомерПартии As DataGridViewTextBoxColumn
    Friend WithEvents Изделие As DataGridViewTextBoxColumn
    Friend WithEvents Поставщик As DataGridViewTextBoxColumn
    Friend WithEvents Количество As DataGridViewTextBoxColumn
    Friend WithEvents ГоденДо As DataGridViewTextBoxColumn
    Friend WithEvents ButtonAddNewProduct As MetroFramework.Controls.MetroButton
End Class
