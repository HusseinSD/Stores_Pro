<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Receipt
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NoteTb = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rdate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RecNameTb = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.countTb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IDitemTb = New System.Windows.Forms.TextBox()
        Me.OkBtn = New System.Windows.Forms.Button()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbItemName = New System.Windows.Forms.TextBox()
        Me.cmbSubject = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(380, 226)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = ": ملاحظة"
        '
        'NoteTb
        '
        Me.NoteTb.Location = New System.Drawing.Point(52, 226)
        Me.NoteTb.Multiline = True
        Me.NoteTb.Name = "NoteTb"
        Me.NoteTb.Size = New System.Drawing.Size(322, 83)
        Me.NoteTb.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(380, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = ": تاريخ الاستلام"
        '
        'rdate
        '
        Me.rdate.Location = New System.Drawing.Point(174, 193)
        Me.rdate.Name = "rdate"
        Me.rdate.Size = New System.Drawing.Size(200, 20)
        Me.rdate.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(380, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = " : اسم المستلم "
        '
        'RecNameTb
        '
        Me.RecNameTb.Location = New System.Drawing.Point(274, 37)
        Me.RecNameTb.Name = "RecNameTb"
        Me.RecNameTb.Size = New System.Drawing.Size(100, 20)
        Me.RecNameTb.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(380, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = ": العدد"
        '
        'countTb
        '
        Me.countTb.Location = New System.Drawing.Point(274, 153)
        Me.countTb.Name = "countTb"
        Me.countTb.Size = New System.Drawing.Size(100, 20)
        Me.countTb.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(380, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = ": معرف المادة"
        '
        'IDitemTb
        '
        Me.IDitemTb.Location = New System.Drawing.Point(274, 115)
        Me.IDitemTb.Name = "IDitemTb"
        Me.IDitemTb.Size = New System.Drawing.Size(100, 20)
        Me.IDitemTb.TabIndex = 24
        '
        'OkBtn
        '
        Me.OkBtn.Location = New System.Drawing.Point(133, 329)
        Me.OkBtn.Name = "OkBtn"
        Me.OkBtn.Size = New System.Drawing.Size(75, 23)
        Me.OkBtn.TabIndex = 35
        Me.OkBtn.Text = "تم"
        Me.OkBtn.UseVisualStyleBackColor = True
        '
        'CloseBtn
        '
        Me.CloseBtn.Location = New System.Drawing.Point(52, 329)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(75, 23)
        Me.CloseBtn.TabIndex = 34
        Me.CloseBtn.Text = "الغاء"
        Me.CloseBtn.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(380, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = ": اسم المادة"
        '
        'tbItemName
        '
        Me.tbItemName.Location = New System.Drawing.Point(90, 40)
        Me.tbItemName.Name = "tbItemName"
        Me.tbItemName.Size = New System.Drawing.Size(100, 20)
        Me.tbItemName.TabIndex = 36
        '
        'cmbSubject
        '
        Me.cmbSubject.FormattingEnabled = True
        Me.cmbSubject.Location = New System.Drawing.Point(274, 78)
        Me.cmbSubject.Name = "cmbSubject"
        Me.cmbSubject.Size = New System.Drawing.Size(100, 21)
        Me.cmbSubject.TabIndex = 38
        '
        'Receipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 394)
        Me.Controls.Add(Me.cmbSubject)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbItemName)
        Me.Controls.Add(Me.OkBtn)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.NoteTb)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.rdate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.RecNameTb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.countTb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.IDitemTb)
        Me.Name = "Receipt"
        Me.Text = "Receipt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents NoteTb As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents rdate As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents RecNameTb As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents countTb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents IDitemTb As TextBox
    Friend WithEvents OkBtn As Button
    Friend WithEvents CloseBtn As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents tbItemName As TextBox
    Friend WithEvents cmbSubject As ComboBox
End Class
