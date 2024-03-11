Imports System.Data.SqlClient
Public Class Form2

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        'Dim myconn As New SqlClient.SqlConnection("Initial Catalog = ChinaMarinetime; Data Source = (local); Integrated Security = SSPI;")
        Dim myconn As New SqlClient.SqlConnection("Initial Catalog = ChinaMarinetime; Data Source = marine.c1v6bx62rekg.ap-northeast-1.rds.amazonaws.com,1433; User ID = liuchang; Password = e0099ENT!;")
        Dim mycomm As New SqlClient.SqlCommand("fileroute_procA", myconn)

        mycomm.CommandType = CommandType.StoredProcedure

        Dim para_fn As SqlClient.SqlParameter = mycomm.Parameters.Add("@_fn", System.Data.SqlDbType.NChar, 5)
        Dim para_fr As SqlClient.SqlParameter = mycomm.Parameters.Add("@_fr", System.Data.SqlDbType.VarChar, 200)

        Dim s As String
        s = DataGridView1.CurrentRow.Cells(0).Value.ToString
        para_fn.Value = s
        para_fr.Direction = ParameterDirection.Output

        myconn.Open()
        mycomm.ExecuteScalar()
        myconn.Close()

        Label1.Text = para_fr.Value.ToString

        Dim RetVal
        RetVal = Shell("rundll32.exe shimgvw.dll ImageView_Fullscreen " & para_fr.Value.ToString, vbNormalFocus)
    End Sub
End Class