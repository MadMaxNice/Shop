<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProduct
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
        Me.DataGridViewProduct = New System.Windows.Forms.DataGridView()
        Me.Изделие = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Сорт = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Вид = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Цена = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Марка = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonAddNewProduct = New MetroFramework.Controls.MetroButton()
        CType(Me.DataGridViewProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewProduct
        '
        Me.DataGridViewProduct.AllowUserToAddRows = False
        Me.DataGridViewProduct.AllowUserToDeleteRows = False
        Me.DataGridViewProduct.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewProduct.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Изделие, Me.Сорт, Me.Вид, Me.Цена, Me.Марка})
        Me.DataGridViewProduct.Location = New System.Drawing.Point(20, 63)
        Me.DataGridViewProduct.Name = "DataGridViewProduct"
        Me.DataGridViewProduct.ReadOnly = True
        Me.DataGridViewProduct.Size = New System.Drawing.Size(684, 279)
        Me.DataGridViewProduct.TabIndex = 1
        '
        'Изделие
        '
        Me.Изделие.HeaderText = "Изделие"
        Me.Изделие.Name = "Изделие"
        Me.Изделие.ReadOnly = True
        Me.Изделие.Width = 230
        '
        'Сорт
        '
        Me.Сорт.HeaderText = "Сорт"
        Me.Сорт.Name = "Сорт"
        Me.Сорт.ReadOnly = True
        '
        'Вид
        '
        Me.Вид.HeaderText = "Вид"
        Me.Вид.Name = "Вид"
        Me.Вид.ReadOnly = True
        '
        'Цена
        '
        Me.Цена.HeaderText = "Цена"
        Me.Цена.Name = "Цена"
        Me.Цена.ReadOnly = True
        '
        'Марка
        '
        Me.Марка.HeaderText = "Марка"
        Me.Марка.Name = "Марка"
        Me.Марка.ReadOnly = True
        '
        'ButtonAddNewProduct
        '
        Me.ButtonAddNewProduct.Location = New System.Drawing.Point(575, 22)
        Me.ButtonAddNewProduct.Name = "ButtonAddNewProduct"
        Me.ButtonAddNewProduct.Size = New System.Drawing.Size(129, 29)
        Me.ButtonAddNewProduct.TabIndex = 30
        Me.ButtonAddNewProduct.Text = "Добавить"
        Me.ButtonAddNewProduct.UseSelectable = True
        '
        'FormProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 353)
        Me.Controls.Add(Me.ButtonAddNewProduct)
        Me.Controls.Add(Me.DataGridViewProduct)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormProduct"
        Me.Style = MetroFramework.MetroColorStyle.Red
        Me.Text = "Изделия"
        CType(Me.DataGridViewProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridViewProduct As DataGridView
    Friend WithEvents Изделие As DataGridViewTextBoxColumn
    Friend WithEvents Сорт As DataGridViewTextBoxColumn
    Friend WithEvents Вид As DataGridViewTextBoxColumn
    Friend WithEvents Цена As DataGridViewTextBoxColumn
    Friend WithEvents Марка As DataGridViewTextBoxColumn
    Friend WithEvents ButtonAddNewProduct As MetroFramework.Controls.MetroButton
End Class
