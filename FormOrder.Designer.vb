<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOrder
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
        Me.DataGridViewOrder = New System.Windows.Forms.DataGridView()
        Me.НомерЗаказа = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Количество = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Сумма = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridViewOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewOrder
        '
        Me.DataGridViewOrder.AllowUserToAddRows = False
        Me.DataGridViewOrder.AllowUserToDeleteRows = False
        Me.DataGridViewOrder.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewOrder.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.НомерЗаказа, Me.Количество, Me.Сумма})
        Me.DataGridViewOrder.Location = New System.Drawing.Point(20, 63)
        Me.DataGridViewOrder.Name = "DataGridViewOrder"
        Me.DataGridViewOrder.ReadOnly = True
        Me.DataGridViewOrder.Size = New System.Drawing.Size(684, 279)
        Me.DataGridViewOrder.TabIndex = 1
        '
        'НомерЗаказа
        '
        Me.НомерЗаказа.HeaderText = "Номер заказа"
        Me.НомерЗаказа.Name = "НомерЗаказа"
        Me.НомерЗаказа.ReadOnly = True
        Me.НомерЗаказа.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.НомерЗаказа.Width = 50
        '
        'Количество
        '
        Me.Количество.HeaderText = "Количество"
        Me.Количество.Name = "Количество"
        Me.Количество.ReadOnly = True
        Me.Количество.Width = 230
        '
        'Сумма
        '
        Me.Сумма.HeaderText = "Сумма"
        Me.Сумма.Name = "Сумма"
        Me.Сумма.ReadOnly = True
        Me.Сумма.Width = 200
        '
        'FormOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 353)
        Me.Controls.Add(Me.DataGridViewOrder)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormOrder"
        Me.Style = MetroFramework.MetroColorStyle.Red
        Me.Text = "Выполненные заказы"
        CType(Me.DataGridViewOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridViewOrder As DataGridView
    Friend WithEvents НомерЗаказа As DataGridViewTextBoxColumn
    Friend WithEvents Количество As DataGridViewTextBoxColumn
    Friend WithEvents Сумма As DataGridViewTextBoxColumn
End Class
