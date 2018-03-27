<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAutorisation
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
        Me.ComboBoxPeople = New MetroFramework.Controls.MetroComboBox()
        Me.ButtonAutorisation = New MetroFramework.Controls.MetroButton()
        Me.ButtonHelp = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'ComboBoxPeople
        '
        Me.ComboBoxPeople.FormattingEnabled = True
        Me.ComboBoxPeople.ItemHeight = 23
        Me.ComboBoxPeople.Location = New System.Drawing.Point(23, 53)
        Me.ComboBoxPeople.Name = "ComboBoxPeople"
        Me.ComboBoxPeople.Size = New System.Drawing.Size(369, 29)
        Me.ComboBoxPeople.TabIndex = 0
        Me.ComboBoxPeople.UseSelectable = True
        '
        'ButtonAutorisation
        '
        Me.ButtonAutorisation.Location = New System.Drawing.Point(254, 88)
        Me.ButtonAutorisation.Name = "ButtonAutorisation"
        Me.ButtonAutorisation.Size = New System.Drawing.Size(138, 32)
        Me.ButtonAutorisation.TabIndex = 1
        Me.ButtonAutorisation.Text = "Выбрать"
        Me.ButtonAutorisation.UseSelectable = True
        '
        'ButtonHelp
        '
        Me.ButtonHelp.Location = New System.Drawing.Point(0, 5)
        Me.ButtonHelp.Name = "ButtonHelp"
        Me.ButtonHelp.Size = New System.Drawing.Size(66, 18)
        Me.ButtonHelp.TabIndex = 2
        Me.ButtonHelp.Text = "Справка"
        Me.ButtonHelp.UseSelectable = True
        '
        'FormAutorisation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 139)
        Me.Controls.Add(Me.ButtonHelp)
        Me.Controls.Add(Me.ButtonAutorisation)
        Me.Controls.Add(Me.ComboBoxPeople)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormAutorisation"
        Me.Style = MetroFramework.MetroColorStyle.Red
        Me.Text = "Выберите сотрудника"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ComboBoxPeople As MetroFramework.Controls.MetroComboBox
    Friend WithEvents ButtonAutorisation As MetroFramework.Controls.MetroButton
    Friend WithEvents ButtonHelp As MetroFramework.Controls.MetroButton
End Class
