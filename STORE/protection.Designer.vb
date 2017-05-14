<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class protection
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
        Me.proDGV = New System.Windows.Forms.DataGridView()
        Me.TbSearch = New System.Windows.Forms.TextBox()
        Me.CbFilter = New System.Windows.Forms.ComboBox()
        Me.Retn_Btn = New System.Windows.Forms.Button()
        Me.num_tb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.proDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'proDGV
        '
        Me.proDGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.proDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.proDGV.Location = New System.Drawing.Point(12, 82)
        Me.proDGV.Name = "proDGV"
        Me.proDGV.Size = New System.Drawing.Size(638, 353)
        Me.proDGV.TabIndex = 0
        '
        'TbSearch
        '
        Me.TbSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbSearch.Location = New System.Drawing.Point(509, 12)
        Me.TbSearch.Name = "TbSearch"
        Me.TbSearch.Size = New System.Drawing.Size(141, 20)
        Me.TbSearch.TabIndex = 1
        '
        'CbFilter
        '
        Me.CbFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbFilter.FormattingEnabled = True
        Me.CbFilter.Items.AddRange(New Object() {"معرف الموظف", "اسم الموظف "})
        Me.CbFilter.Location = New System.Drawing.Point(405, 12)
        Me.CbFilter.Name = "CbFilter"
        Me.CbFilter.Size = New System.Drawing.Size(98, 21)
        Me.CbFilter.TabIndex = 2
        '
        'Retn_Btn
        '
        Me.Retn_Btn.Location = New System.Drawing.Point(12, 12)
        Me.Retn_Btn.Name = "Retn_Btn"
        Me.Retn_Btn.Size = New System.Drawing.Size(92, 21)
        Me.Retn_Btn.TabIndex = 3
        Me.Retn_Btn.Text = "ارجاع للمخزن"
        Me.Retn_Btn.UseVisualStyleBackColor = True
        '
        'num_tb
        '
        Me.num_tb.Location = New System.Drawing.Point(12, 39)
        Me.num_tb.Name = "num_tb"
        Me.num_tb.Size = New System.Drawing.Size(37, 20)
        Me.num_tb.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = ": العدد   "
        '
        'protection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 489)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.num_tb)
        Me.Controls.Add(Me.Retn_Btn)
        Me.Controls.Add(Me.CbFilter)
        Me.Controls.Add(Me.TbSearch)
        Me.Controls.Add(Me.proDGV)
        Me.Name = "protection"
        Me.Text = "protection"
        CType(Me.proDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents proDGV As DataGridView
    Friend WithEvents TbSearch As TextBox
    Friend WithEvents CbFilter As ComboBox
    Friend WithEvents Retn_Btn As Button
    Friend WithEvents num_tb As TextBox
    Friend WithEvents Label1 As Label
End Class
