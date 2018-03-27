<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDetailOrder
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
        Me.ListBoxOrder = New System.Windows.Forms.ListBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.LabelSumAll = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.LabelPeople = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'ListBoxOrder
        '
        Me.ListBoxOrder.FormattingEnabled = True
        Me.ListBoxOrder.Location = New System.Drawing.Point(23, 54)
        Me.ListBoxOrder.Name = "ListBoxOrder"
        Me.ListBoxOrder.Size = New System.Drawing.Size(491, 160)
        Me.ListBoxOrder.TabIndex = 0
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(297, 244)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(141, 25)
        Me.MetroLabel1.TabIndex = 1
        Me.MetroLabel1.Text = "Итоговая сумма:"
        '
        'LabelSumAll
        '
        Me.LabelSumAll.AutoSize = True
        Me.LabelSumAll.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.LabelSumAll.Location = New System.Drawing.Point(439, 246)
        Me.LabelSumAll.Name = "LabelSumAll"
        Me.LabelSumAll.Size = New System.Drawing.Size(21, 25)
        Me.LabelSumAll.TabIndex = 2
        Me.LabelSumAll.Text = "0"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.Location = New System.Drawing.Point(23, 217)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(99, 25)
        Me.MetroLabel2.TabIndex = 3
        Me.MetroLabel2.Text = "Сотрудник:"
        '
        'LabelPeople
        '
        Me.LabelPeople.AutoSize = True
        Me.LabelPeople.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.LabelPeople.Location = New System.Drawing.Point(128, 217)
        Me.LabelPeople.Name = "LabelPeople"
        Me.LabelPeople.Size = New System.Drawing.Size(33, 25)
        Me.LabelPeople.TabIndex = 4
        Me.LabelPeople.Text = "***"
        '
        'FormDetailOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 272)
        Me.Controls.Add(Me.LabelPeople)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.LabelSumAll)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.ListBoxOrder)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormDetailOrder"
        Me.Style = MetroFramework.MetroColorStyle.Red
        Me.Text = "Подробно"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBoxOrder As ListBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents LabelSumAll As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents LabelPeople As MetroFramework.Controls.MetroLabel
End Class
