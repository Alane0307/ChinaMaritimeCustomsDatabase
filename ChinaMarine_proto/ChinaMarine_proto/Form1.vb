Imports System.Data.SqlClient
Public Class Form1

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        'Dim myconn As New SqlClient.SqlConnection("Initial Catalog = ChinaMarinetime; Data Source = (local); Integrated Security = SSPI;")
        ''Dim myconn As New SqlClient.SqlConnection("Initial Catalog = ChinaMarinetime; Data Source = marine.c1v6bx62rekg.ap-northeast-1.rds.amazonaws.com,1433; User ID = liuchang; Password = e0099ENT!;")
        'Dim mycomm As New SqlClient.SqlCommand("pageinfo_procA", myconn)

        'mycomm.CommandType = CommandType.StoredProcedure

        'Dim para_kw As SqlClient.SqlParameter = mycomm.Parameters.Add("@_kw", System.Data.SqlDbType.VarChar, 20)

        'para_kw.Value = KeyWord.Text

        'Dim myadapter As New SqlClient.SqlDataAdapter(mycomm)
        'Dim pageinfo As New System.Data.DataTable

        'myadapter.Fill(pageinfo)
        'Me.DataGridView1.DataSource = pageinfo

        'Now we start the integrated search block
        'Dim myconn As New SqlClient.SqlConnection("Initial Catalog = ChinaMarinetime; Data Source = (local); Integrated Security = SSPI;")
        Dim myconn As New SqlClient.SqlConnection("Initial Catalog = ChinaMarinetime; Data Source = marine.c1v6bx62rekg.ap-northeast-1.rds.amazonaws.com,1433; User ID = liuchang; Password = e0099ENT!;")
        Dim mycomm As New SqlClient.SqlCommand("fuzsearch_procA", myconn)

        mycomm.CommandType = CommandType.StoredProcedure

        'First, we define the parameters being used in sql procedure
        Dim para_fzw As SqlClient.SqlParameter = mycomm.Parameters.Add("@_fzw", System.Data.SqlDbType.VarChar, 300)
        Dim para_bookname As SqlClient.SqlParameter = mycomm.Parameters.Add("@_bookname", System.Data.SqlDbType.VarChar, 300)
        Dim para_time As SqlClient.SqlParameter = mycomm.Parameters.Add("@_time", System.Data.SqlDbType.SmallInt)
        Dim para_page As SqlClient.SqlParameter = mycomm.Parameters.Add("@_page", System.Data.SqlDbType.SmallInt)
        Dim para_region As SqlClient.SqlParameter = mycomm.Parameters.Add("@_region", System.Data.SqlDbType.VarChar, 50)
        Dim para_title As SqlClient.SqlParameter = mycomm.Parameters.Add("@_title", System.Data.SqlDbType.VarChar, 300)
        Dim para_keyword As SqlClient.SqlParameter = mycomm.Parameters.Add("@_keyword", System.Data.SqlDbType.VarChar, 20)
        Dim para_mapflag As SqlClient.SqlParameter = mycomm.Parameters.Add("@_mapflag", System.Data.SqlDbType.NChar, 1)
        Dim para_graphflag As SqlClient.SqlParameter = mycomm.Parameters.Add("@_graphflag", System.Data.SqlDbType.NChar, 1)
        Dim para_photoflag As SqlClient.SqlParameter = mycomm.Parameters.Add("@_photoflag", System.Data.SqlDbType.NChar, 1)
        Dim para_sketchflag As SqlClient.SqlParameter = mycomm.Parameters.Add("@_sketchflag", System.Data.SqlDbType.NChar, 1)
        Dim para_otherflag As SqlClient.SqlParameter = mycomm.Parameters.Add("@_otherflag", System.Data.SqlDbType.NChar, 1)

        'Second, assign different values to parameters
        para_fzw.Value = FuzzyTxt.Text
        para_bookname.Value = BookName.Text
        para_region.Value = Region.Text
        para_title.Value = Title.Text
        para_keyword.Value = KeyWord.Text

        If Map.Checked = True Then
            para_mapflag.Value = "M"
        Else
            para_mapflag.Value = "N"
        End If

        If Graph.Checked = True Then
            para_graphflag.Value = "G"
        Else
            para_graphflag.Value = "N"
        End If

        If Photo.Checked = True Then
            para_photoflag.Value = "P"
        Else
            para_photoflag.Value = "N"
        End If

        If Sketch.Checked = True Then
            para_sketchflag.Value = "S"
        Else
            para_sketchflag.Value = "N"
        End If

        If Other.Checked = True Then
            para_otherflag.Value = "T"
        Else
            para_otherflag.Value = "N"
        End If

        If Year.Text = "" Then
            para_time.Value = 0
        Else
            para_time.Value = CType(Year.Text, Integer)
        End If

        If Page.Text = "" Then
            para_page.Value = 0
        Else
            para_page.Value = CType(Page.Text, Integer)
        End If


        Dim myadapter As New SqlClient.SqlDataAdapter(mycomm)
        Dim pageinfo As New System.Data.DataTable

        myadapter.Fill(pageinfo)
        Me.DataGridView1.DataSource = pageinfo
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim s As String
        s = DataGridView1.CurrentRow.Cells(0).Value.ToString
        'Label1.Text = s

        'Dim myconn As New SqlClient.SqlConnection("Initial Catalog = ChinaMarinetime; Data Source = (local); Integrated Security = SSPI;")
        Dim myconn As New SqlClient.SqlConnection("Initial Catalog = ChinaMarinetime; Data Source = marine.c1v6bx62rekg.ap-northeast-1.rds.amazonaws.com,1433; User ID = liuchang; Password = e0099ENT!;")
        Dim mycomm As New SqlClient.SqlCommand("fileno_procA", myconn)

        mycomm.CommandType = CommandType.StoredProcedure

        Dim para_cn As SqlClient.SqlParameter = mycomm.Parameters.Add("@_cn", System.Data.SqlDbType.NChar, 5)

        para_cn.Value = s

        Dim myadapter As New SqlClient.SqlDataAdapter(mycomm)
        Dim fileno As New System.Data.DataTable

        myadapter.Fill(fileno)

        Dim frm2 As New Form2
        frm2.DataGridView1.DataSource = fileno
        frm2.ShowDialog()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles AdvancedSearch.Enter

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Sketch.CheckedChanged

    End Sub
End Class
