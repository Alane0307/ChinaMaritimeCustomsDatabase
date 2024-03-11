<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.KeyWord = New System.Windows.Forms.TextBox()
        Me.Search = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BookName = New System.Windows.Forms.TextBox()
        Me.Region = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Title = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Year = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AdvancedSearch = New System.Windows.Forms.GroupBox()
        Me.Other = New System.Windows.Forms.CheckBox()
        Me.Graph = New System.Windows.Forms.CheckBox()
        Me.Map = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Page = New System.Windows.Forms.TextBox()
        Me.FuzzySearch = New System.Windows.Forms.GroupBox()
        Me.FuzzyTxt = New System.Windows.Forms.TextBox()
        Me.Sketch = New System.Windows.Forms.CheckBox()
        Me.Photo = New System.Windows.Forms.CheckBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AdvancedSearch.SuspendLayout()
        Me.FuzzySearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'KeyWord
        '
        Me.KeyWord.Location = New System.Drawing.Point(162, 14)
        Me.KeyWord.Name = "KeyWord"
        Me.KeyWord.Size = New System.Drawing.Size(124, 21)
        Me.KeyWord.TabIndex = 0
        '
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(310, 12)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(75, 241)
        Me.Search.TabIndex = 1
        Me.Search.Text = "検索"
        Me.Search.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(391, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.Size = New System.Drawing.Size(577, 241)
        Me.DataGridView1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(91, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "キーワード"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(91, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "書名"
        '
        'BookName
        '
        Me.BookName.Location = New System.Drawing.Point(162, 41)
        Me.BookName.Name = "BookName"
        Me.BookName.Size = New System.Drawing.Size(124, 21)
        Me.BookName.TabIndex = 5
        '
        'Region
        '
        Me.Region.Location = New System.Drawing.Point(162, 68)
        Me.Region.Name = "Region"
        Me.Region.Size = New System.Drawing.Size(124, 21)
        Me.Region.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(91, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 12)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "地名"
        '
        'Title
        '
        Me.Title.Location = New System.Drawing.Point(162, 95)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(124, 21)
        Me.Title.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(91, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 12)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "タイトル"
        '
        'Year
        '
        Me.Year.Location = New System.Drawing.Point(162, 122)
        Me.Year.Name = "Year"
        Me.Year.Size = New System.Drawing.Size(124, 21)
        Me.Year.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(91, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 12)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "年代"
        '
        'AdvancedSearch
        '
        Me.AdvancedSearch.Controls.Add(Me.Photo)
        Me.AdvancedSearch.Controls.Add(Me.Sketch)
        Me.AdvancedSearch.Controls.Add(Me.Other)
        Me.AdvancedSearch.Controls.Add(Me.Graph)
        Me.AdvancedSearch.Controls.Add(Me.Map)
        Me.AdvancedSearch.Controls.Add(Me.Label6)
        Me.AdvancedSearch.Controls.Add(Me.KeyWord)
        Me.AdvancedSearch.Controls.Add(Me.Page)
        Me.AdvancedSearch.Controls.Add(Me.Label1)
        Me.AdvancedSearch.Controls.Add(Me.Label2)
        Me.AdvancedSearch.Controls.Add(Me.Label5)
        Me.AdvancedSearch.Controls.Add(Me.BookName)
        Me.AdvancedSearch.Controls.Add(Me.Year)
        Me.AdvancedSearch.Controls.Add(Me.Label3)
        Me.AdvancedSearch.Controls.Add(Me.Title)
        Me.AdvancedSearch.Controls.Add(Me.Region)
        Me.AdvancedSearch.Controls.Add(Me.Label4)
        Me.AdvancedSearch.Location = New System.Drawing.Point(12, 77)
        Me.AdvancedSearch.Name = "AdvancedSearch"
        Me.AdvancedSearch.Size = New System.Drawing.Size(292, 176)
        Me.AdvancedSearch.TabIndex = 12
        Me.AdvancedSearch.TabStop = False
        Me.AdvancedSearch.Text = "アドバンスド検索"
        '
        'Other
        '
        Me.Other.AutoSize = True
        Me.Other.Checked = True
        Me.Other.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Other.Location = New System.Drawing.Point(6, 144)
        Me.Other.Name = "Other"
        Me.Other.Size = New System.Drawing.Size(48, 16)
        Me.Other.TabIndex = 17
        Me.Other.Text = "文書"
        Me.Other.UseVisualStyleBackColor = True
        '
        'Graph
        '
        Me.Graph.AutoSize = True
        Me.Graph.Checked = True
        Me.Graph.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Graph.Location = New System.Drawing.Point(6, 122)
        Me.Graph.Name = "Graph"
        Me.Graph.Size = New System.Drawing.Size(48, 16)
        Me.Graph.TabIndex = 16
        Me.Graph.Text = "図表"
        Me.Graph.UseVisualStyleBackColor = True
        '
        'Map
        '
        Me.Map.AutoSize = True
        Me.Map.Checked = True
        Me.Map.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Map.Location = New System.Drawing.Point(6, 100)
        Me.Map.Name = "Map"
        Me.Map.Size = New System.Drawing.Size(48, 16)
        Me.Map.TabIndex = 15
        Me.Map.Text = "地図"
        Me.Map.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(91, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 12)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "ページ"
        '
        'Page
        '
        Me.Page.Location = New System.Drawing.Point(162, 149)
        Me.Page.Name = "Page"
        Me.Page.Size = New System.Drawing.Size(124, 21)
        Me.Page.TabIndex = 13
        '
        'FuzzySearch
        '
        Me.FuzzySearch.Controls.Add(Me.FuzzyTxt)
        Me.FuzzySearch.Location = New System.Drawing.Point(12, 12)
        Me.FuzzySearch.Name = "FuzzySearch"
        Me.FuzzySearch.Size = New System.Drawing.Size(292, 49)
        Me.FuzzySearch.TabIndex = 13
        Me.FuzzySearch.TabStop = False
        Me.FuzzySearch.Text = "曖昧検索"
        '
        'FuzzyTxt
        '
        Me.FuzzyTxt.Location = New System.Drawing.Point(6, 20)
        Me.FuzzyTxt.Name = "FuzzyTxt"
        Me.FuzzyTxt.Size = New System.Drawing.Size(280, 21)
        Me.FuzzyTxt.TabIndex = 0
        '
        'Sketch
        '
        Me.Sketch.AutoSize = True
        Me.Sketch.Checked = True
        Me.Sketch.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Sketch.Location = New System.Drawing.Point(6, 78)
        Me.Sketch.Name = "Sketch"
        Me.Sketch.Size = New System.Drawing.Size(72, 16)
        Me.Sketch.TabIndex = 18
        Me.Sketch.Text = "スケッチ"
        Me.Sketch.UseVisualStyleBackColor = True
        '
        'Photo
        '
        Me.Photo.AutoSize = True
        Me.Photo.Checked = True
        Me.Photo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Photo.Location = New System.Drawing.Point(6, 56)
        Me.Photo.Name = "Photo"
        Me.Photo.Size = New System.Drawing.Size(48, 16)
        Me.Photo.TabIndex = 19
        Me.Photo.Text = "写真"
        Me.Photo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(980, 265)
        Me.Controls.Add(Me.FuzzySearch)
        Me.Controls.Add(Me.AdvancedSearch)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Search)
        Me.Name = "Form1"
        Me.Text = "資料検索"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AdvancedSearch.ResumeLayout(False)
        Me.AdvancedSearch.PerformLayout()
        Me.FuzzySearch.ResumeLayout(False)
        Me.FuzzySearch.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KeyWord As System.Windows.Forms.TextBox
    Friend WithEvents Search As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BookName As System.Windows.Forms.TextBox
    Friend WithEvents Region As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Title As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Year As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents AdvancedSearch As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Page As System.Windows.Forms.TextBox
    Friend WithEvents Other As System.Windows.Forms.CheckBox
    Friend WithEvents Graph As System.Windows.Forms.CheckBox
    Friend WithEvents Map As System.Windows.Forms.CheckBox
    Friend WithEvents FuzzySearch As System.Windows.Forms.GroupBox
    Friend WithEvents FuzzyTxt As System.Windows.Forms.TextBox
    Friend WithEvents Photo As System.Windows.Forms.CheckBox
    Friend WithEvents Sketch As System.Windows.Forms.CheckBox

End Class
