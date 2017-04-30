<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class movEmp
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
        Me.RecBtn = New System.Windows.Forms.Button()
        Me.DevBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RecBtn
        '
        Me.RecBtn.Location = New System.Drawing.Point(397, 75)
        Me.RecBtn.Name = "RecBtn"
        Me.RecBtn.Size = New System.Drawing.Size(107, 68)
        Me.RecBtn.TabIndex = 4
        Me.RecBtn.Text = "استلام"
        Me.RecBtn.UseVisualStyleBackColor = True
        '
        'DevBtn
        '
        Me.DevBtn.Location = New System.Drawing.Point(116, 75)
        Me.DevBtn.Name = "DevBtn"
        Me.DevBtn.Size = New System.Drawing.Size(107, 68)
        Me.DevBtn.TabIndex = 5
        Me.DevBtn.Text = "استرجاع"
        Me.DevBtn.UseVisualStyleBackColor = True
        '
        'movEmp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 223)
        Me.Controls.Add(Me.DevBtn)
        Me.Controls.Add(Me.RecBtn)
        Me.Name = "movEmp"
        Me.Text = "movEmp"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RecBtn As Button
    Friend WithEvents DevBtn As Button
End Class
