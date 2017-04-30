<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.txtDec = New System.Windows.Forms.TextBox()
        Me.rdate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSerial = New System.Windows.Forms.TextBox()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.claseBtn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtStatus)
        Me.GroupBox1.Controls.Add(Me.txtDec)
        Me.GroupBox1.Controls.Add(Me.rdate)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.txtNumber)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtSerial)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(471, 349)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "عملية التعديل "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(410, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = " : الحالة"
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(29, 129)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(322, 20)
        Me.txtStatus.TabIndex = 33
        '
        'txtDec
        '
        Me.txtDec.Location = New System.Drawing.Point(19, 217)
        Me.txtDec.Multiline = True
        Me.txtDec.Name = "txtDec"
        Me.txtDec.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDec.Size = New System.Drawing.Size(428, 106)
        Me.txtDec.TabIndex = 29
        '
        'rdate
        '
        Me.rdate.Location = New System.Drawing.Point(151, 163)
        Me.rdate.Name = "rdate"
        Me.rdate.Size = New System.Drawing.Size(200, 20)
        Me.rdate.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(373, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = " : رقم المعرف "
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(29, 25)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(322, 20)
        Me.txtID.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(403, 198)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = ": الوصف"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(379, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = " : اسم المادة"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(369, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = ": تاريخ الاستلام"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(29, 51)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(322, 20)
        Me.txtName.TabIndex = 22
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(29, 103)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(322, 20)
        Me.txtNumber.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(353, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = ": الرقم التسلسلي"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(410, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = ": العدد"
        '
        'txtSerial
        '
        Me.txtSerial.Location = New System.Drawing.Point(29, 77)
        Me.txtSerial.Name = "txtSerial"
        Me.txtSerial.Size = New System.Drawing.Size(322, 20)
        Me.txtSerial.TabIndex = 24
        '
        'AddBtn
        '
        Me.AddBtn.Location = New System.Drawing.Point(93, 367)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(75, 25)
        Me.AddBtn.TabIndex = 20
        Me.AddBtn.Text = "اضافة"
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'claseBtn
        '
        Me.claseBtn.Location = New System.Drawing.Point(12, 367)
        Me.claseBtn.Name = "claseBtn"
        Me.claseBtn.Size = New System.Drawing.Size(75, 25)
        Me.claseBtn.TabIndex = 19
        Me.claseBtn.Text = "خروج"
        Me.claseBtn.UseVisualStyleBackColor = True
        '
        'Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 406)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.AddBtn)
        Me.Controls.Add(Me.claseBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Edit"
        Me.Text = "تعديل "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtDec As TextBox
    Friend WithEvents rdate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSerial As TextBox
    Friend WithEvents AddBtn As Button
    Friend WithEvents claseBtn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtStatus As TextBox
End Class
