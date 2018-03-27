<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBadProduct
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
        Me.DataGridViewBad = New System.Windows.Forms.DataGridView()
        Me.НомерСписание = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Изделие = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Количество = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ГоденДо = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridViewBad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewBad
        '
        Me.DataGridViewBad.AllowUserToAddRows = False
        Me.DataGridViewBad.AllowUserToDeleteRows = False
        Me.DataGridViewBad.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewBad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewBad.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.НомерСписание, Me.Изделие, Me.Количество, Me.ГоденДо})
        Me.DataGridViewBad.Location = New System.Drawing.Point(23, 63)
        Me.DataGridViewBad.Name = "DataGridViewBad"
        Me.DataGridViewBad.ReadOnly = True
        Me.DataGridViewBad.Size = New System.Drawing.Size(495, 279)
        Me.DataGridViewBad.TabIndex = 1
        '
        'НомерСписание
        '
        Me.НомерСписание.HeaderText = "Номер списание"
        Me.НомерСписание.Name = "НомерСписание"
        Me.НомерСписание.ReadOnly = True
        Me.НомерСписание.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.НомерСписание.Width = 60
        '
        'Изделие
        '
        Me.Изделие.HeaderText = "Изделие"
        Me.Изделие.Name = "Изделие"
        Me.Изделие.ReadOnly = True
        Me.Изделие.Width = 230
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
        'FormBadProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 353)
        Me.Controls.Add(Me.DataGridViewBad)
        Me.Name = "FormBadProduct"
        Me.Style = MetroFramework.MetroColorStyle.Red
        Me.Text = "Списанные изделия"
        CType(Me.DataGridViewBad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridViewBad As DataGridView
    Friend WithEvents НомерСписание As DataGridViewTextBoxColumn
    Friend WithEvents Изделие As DataGridViewTextBoxColumn
    Friend WithEvents Количество As DataGridViewTextBoxColumn
    Friend WithEvents ГоденДо As DataGridViewTextBoxColumn
End Class
