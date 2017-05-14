<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class item
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EditBtn = New System.Windows.Forms.Button()
        Me.num_tb = New System.Windows.Forms.TextBox()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.trans_btn = New System.Windows.Forms.Button()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.CbFilter = New System.Windows.Forms.ComboBox()
        Me.TbSearch = New System.Windows.Forms.TextBox()
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.DGV = New System.Windows.Forms.DataGridView()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.EditBtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.num_tb)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AddBtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.trans_btn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DeleteBtn)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(719, 523)
        Me.SplitContainer1.SplitterDistance = 97
        Me.SplitContainer1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 292)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = ": العدد"
        '
        'EditBtn
        '
        Me.EditBtn.BackgroundImage = Global.STORE.My.Resources.Resources._1_512
        Me.EditBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EditBtn.FlatAppearance.BorderSize = 0
        Me.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditBtn.Location = New System.Drawing.Point(12, 161)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(75, 77)
        Me.EditBtn.TabIndex = 1
        Me.EditBtn.UseVisualStyleBackColor = True
        '
        'num_tb
        '
        Me.num_tb.Location = New System.Drawing.Point(6, 289)
        Me.num_tb.Name = "num_tb"
        Me.num_tb.Size = New System.Drawing.Size(43, 20)
        Me.num_tb.TabIndex = 8
        '
        'AddBtn
        '
        Me.AddBtn.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.AddBtn.BackgroundImage = Global.STORE.My.Resources.Resources.sign_add_icon
        Me.AddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AddBtn.FlatAppearance.BorderSize = 0
        Me.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddBtn.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.AddBtn.Location = New System.Drawing.Point(12, 18)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(75, 68)
        Me.AddBtn.TabIndex = 10
        Me.AddBtn.UseVisualStyleBackColor = False
        '
        'trans_btn
        '
        Me.trans_btn.Location = New System.Drawing.Point(6, 260)
        Me.trans_btn.Name = "trans_btn"
        Me.trans_btn.Size = New System.Drawing.Size(81, 23)
        Me.trans_btn.TabIndex = 1
        Me.trans_btn.Text = "استلام  "
        Me.trans_btn.UseVisualStyleBackColor = True
        '
        'DeleteBtn
        '
        Me.DeleteBtn.BackgroundImage = Global.STORE.My.Resources.Resources.mActionDeleteSelected
        Me.DeleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DeleteBtn.FlatAppearance.BorderSize = 0
        Me.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteBtn.Location = New System.Drawing.Point(12, 92)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(75, 63)
        Me.DeleteBtn.TabIndex = 11
        Me.DeleteBtn.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer2.Location = New System.Drawing.Point(-54, 6)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.BackColor = System.Drawing.Color.LimeGreen
        Me.SplitContainer2.Panel1.Controls.Add(Me.CbFilter)
        Me.SplitContainer2.Panel1.Controls.Add(Me.TbSearch)
        Me.SplitContainer2.Panel1.Controls.Add(Me.SearchBtn)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.DGV)
        Me.SplitContainer2.Size = New System.Drawing.Size(725, 434)
        Me.SplitContainer2.SplitterDistance = 47
        Me.SplitContainer2.TabIndex = 13
        '
        'CbFilter
        '
        Me.CbFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbFilter.FormattingEnabled = True
        Me.CbFilter.Items.AddRange(New Object() {"المعرف ", "الاسم ", "الرقم التسلسلي ", "الحالة"})
        Me.CbFilter.Location = New System.Drawing.Point(341, 15)
        Me.CbFilter.Name = "CbFilter"
        Me.CbFilter.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CbFilter.Size = New System.Drawing.Size(113, 21)
        Me.CbFilter.TabIndex = 7
        Me.CbFilter.Text = "اخثر نوع البحث"
        '
        'TbSearch
        '
        Me.TbSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbSearch.Location = New System.Drawing.Point(460, 16)
        Me.TbSearch.Name = "TbSearch"
        Me.TbSearch.Size = New System.Drawing.Size(166, 20)
        Me.TbSearch.TabIndex = 5
        Me.TbSearch.Text = "ابحث"
        Me.TbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SearchBtn
        '
        Me.SearchBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchBtn.BackColor = System.Drawing.Color.Transparent
        Me.SearchBtn.BackgroundImage = Global.STORE.My.Resources.Resources.Graphicloads_100_Flat_Zoom_search_2
        Me.SearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SearchBtn.FlatAppearance.BorderSize = 0
        Me.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchBtn.ForeColor = System.Drawing.Color.LimeGreen
        Me.SearchBtn.Location = New System.Drawing.Point(632, 13)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(37, 24)
        Me.SearchBtn.TabIndex = 6
        Me.SearchBtn.UseVisualStyleBackColor = False
        '
        'DGV
        '
        Me.DGV.AllowUserToOrderColumns = True
        Me.DGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(57, 3)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(610, 359)
        Me.DGV.TabIndex = 10
        '
        'item
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(719, 523)
        Me.Controls.Add(Me.SplitContainer1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "item"
        Me.Text = "item"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents AddBtn As Button
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents CbFilter As ComboBox
    Friend WithEvents TbSearch As TextBox
    Friend WithEvents SearchBtn As Button
    Friend WithEvents DGV As DataGridView
    Friend WithEvents EditBtn As Button
    Friend WithEvents trans_btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents num_tb As TextBox
End Class
