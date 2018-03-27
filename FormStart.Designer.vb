<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormStart
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
        Me.ButtonNewReport = New MetroFramework.Controls.MetroButton()
        Me.ButtonNewBad = New MetroFramework.Controls.MetroButton()
        Me.ButtonNewFinishOrder = New MetroFramework.Controls.MetroButton()
        Me.ButtonNewProduct = New MetroFramework.Controls.MetroButton()
        Me.ButtonNewStock = New MetroFramework.Controls.MetroButton()
        Me.ButtonNewOrder = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'ButtonNewReport
        '
        Me.ButtonNewReport.BackgroundImage = Global.ChocolateStore.My.Resources.Resources.cashflow
        Me.ButtonNewReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonNewReport.Location = New System.Drawing.Point(904, 328)
        Me.ButtonNewReport.Name = "ButtonNewReport"
        Me.ButtonNewReport.Size = New System.Drawing.Size(308, 337)
        Me.ButtonNewReport.TabIndex = 5
        Me.ButtonNewReport.UseSelectable = True
        '
        'ButtonNewBad
        '
        Me.ButtonNewBad.BackgroundImage = Global.ChocolateStore.My.Resources.Resources._9e42b66a37d13c860bd751a103fd5fb6
        Me.ButtonNewBad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonNewBad.Location = New System.Drawing.Point(475, 328)
        Me.ButtonNewBad.Name = "ButtonNewBad"
        Me.ButtonNewBad.Size = New System.Drawing.Size(308, 337)
        Me.ButtonNewBad.TabIndex = 4
        Me.ButtonNewBad.UseSelectable = True
        '
        'ButtonNewFinishOrder
        '
        Me.ButtonNewFinishOrder.BackgroundImage = Global.ChocolateStore.My.Resources.Resources.images
        Me.ButtonNewFinishOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonNewFinishOrder.Location = New System.Drawing.Point(56, 328)
        Me.ButtonNewFinishOrder.Name = "ButtonNewFinishOrder"
        Me.ButtonNewFinishOrder.Size = New System.Drawing.Size(308, 337)
        Me.ButtonNewFinishOrder.TabIndex = 3
        Me.ButtonNewFinishOrder.UseSelectable = True
        '
        'ButtonNewProduct
        '
        Me.ButtonNewProduct.BackgroundImage = Global.ChocolateStore.My.Resources.Resources.шоко
        Me.ButtonNewProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonNewProduct.Location = New System.Drawing.Point(857, 38)
        Me.ButtonNewProduct.Name = "ButtonNewProduct"
        Me.ButtonNewProduct.Size = New System.Drawing.Size(400, 225)
        Me.ButtonNewProduct.TabIndex = 2
        Me.ButtonNewProduct.UseSelectable = True
        '
        'ButtonNewStock
        '
        Me.ButtonNewStock.BackgroundImage = Global.ChocolateStore.My.Resources.Resources._5b5365681a52d6ce7b36bf6496c32624
        Me.ButtonNewStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonNewStock.Location = New System.Drawing.Point(439, 38)
        Me.ButtonNewStock.Name = "ButtonNewStock"
        Me.ButtonNewStock.Size = New System.Drawing.Size(400, 225)
        Me.ButtonNewStock.TabIndex = 1
        Me.ButtonNewStock.UseSelectable = True
        '
        'ButtonNewOrder
        '
        Me.ButtonNewOrder.BackgroundImage = Global.ChocolateStore.My.Resources.Resources.zakaz
        Me.ButtonNewOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonNewOrder.Location = New System.Drawing.Point(23, 38)
        Me.ButtonNewOrder.Name = "ButtonNewOrder"
        Me.ButtonNewOrder.Size = New System.Drawing.Size(400, 225)
        Me.ButtonNewOrder.TabIndex = 0
        Me.ButtonNewOrder.UseSelectable = True
        '
        'FormStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.ButtonNewReport)
        Me.Controls.Add(Me.ButtonNewBad)
        Me.Controls.Add(Me.ButtonNewFinishOrder)
        Me.Controls.Add(Me.ButtonNewProduct)
        Me.Controls.Add(Me.ButtonNewStock)
        Me.Controls.Add(Me.ButtonNewOrder)
        Me.Name = "FormStart"
        Me.Style = MetroFramework.MetroColorStyle.Red
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonNewOrder As MetroFramework.Controls.MetroButton
    Friend WithEvents ButtonNewStock As MetroFramework.Controls.MetroButton
    Friend WithEvents ButtonNewProduct As MetroFramework.Controls.MetroButton
    Friend WithEvents ButtonNewFinishOrder As MetroFramework.Controls.MetroButton
    Friend WithEvents ButtonNewBad As MetroFramework.Controls.MetroButton
    Friend WithEvents ButtonNewReport As MetroFramework.Controls.MetroButton
End Class
