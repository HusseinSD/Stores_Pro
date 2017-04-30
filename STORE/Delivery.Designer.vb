<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Delivery
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DevTb = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.countTb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ItemNTb = New System.Windows.Forms.TextBox()
        Me.DevDateTb = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.noteTb = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.OkBtn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(368, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = " : اسم المسترجع "
        '
        'DevTb
        '
        Me.DevTb.Location = New System.Drawing.Point(176, 45)
        Me.DevTb.Name = "DevTb"
        Me.DevTb.Size = New System.Drawing.Size(186, 20)
        Me.DevTb.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(368, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = ": العدد"
        '
        'countTb
        '
        Me.countTb.Location = New System.Drawing.Point(176, 149)
        Me.countTb.Name = "countTb"
        Me.countTb.Size = New System.Drawing.Size(186, 20)
        Me.countTb.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(368, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = ": اسم المادة"
        '
        'ItemNTb
        '
        Me.ItemNTb.Location = New System.Drawing.Point(176, 112)
        Me.ItemNTb.Name = "ItemNTb"
        Me.ItemNTb.Size = New System.Drawing.Size(186, 20)
        Me.ItemNTb.TabIndex = 14
        '
        'DevDateTb
        '
        Me.DevDateTb.Location = New System.Drawing.Point(176, 198)
        Me.DevDateTb.Name = "DevDateTb"
        Me.DevDateTb.Size = New System.Drawing.Size(186, 20)
        Me.DevDateTb.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(368, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = ": تاريخ الاسترجاع"
        '
        'noteTb
        '
        Me.noteTb.Location = New System.Drawing.Point(40, 234)
        Me.noteTb.Multiline = True
        Me.noteTb.Name = "noteTb"
        Me.noteTb.Size = New System.Drawing.Size(322, 83)
        Me.noteTb.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(368, 234)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = ": ملاحظة"
        '
        'CloseBtn
        '
        Me.CloseBtn.Location = New System.Drawing.Point(40, 323)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(75, 23)
        Me.CloseBtn.TabIndex = 24
        Me.CloseBtn.Text = "الغاء"
        Me.CloseBtn.UseVisualStyleBackColor = True
        '
        'OkBtn
        '
        Me.OkBtn.Location = New System.Drawing.Point(121, 323)
        Me.OkBtn.Name = "OkBtn"
        Me.OkBtn.Size = New System.Drawing.Size(75, 23)
        Me.OkBtn.TabIndex = 25
        Me.OkBtn.Text = "تم"
        Me.OkBtn.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(368, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = ": معرف المادة"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(176, 77)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(186, 20)
        Me.TextBox1.TabIndex = 26
        '
        'Delivery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 372)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.OkBtn)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.noteTb)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DevDateTb)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DevTb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.countTb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ItemNTb)
        Me.Name = "Delivery"
        Me.Text = "Delivery"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents DevTb As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents countTb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ItemNTb As TextBox
    Friend WithEvents DevDateTb As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents noteTb As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CloseBtn As Button
    Friend WithEvents OkBtn As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
