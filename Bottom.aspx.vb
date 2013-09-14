Public Class Bottom
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Create a connection and open it.
        Dim objConn As New System.Data.OleDb.OleDbConnection("provider=microsoft.jet.oledb.4.0; data source=~\Northwind.mdb;")
        objConn.Open()

        Dim strSQL As String
        Dim objDataset As New DataSet()
        Dim objAdapter As New System.Data.OleDb.OleDbDataAdapter()

        ' Get all the customers from the USA.
        strSQL = "Select * from customers where country='USA'"
        objAdapter.SelectCommand = New System.Data.OleDb.OleDbCommand(strSQL, objConn)
        ' Fill the dataset.
        objAdapter.Fill(objDataset)
        ' Create a new view.
        Dim oView As New DataView(objDataset.Tables(0))
        ' Set up the data grid and bind the data.
        DataGrid1.DataSource = oView
        DataGrid1.DataBind()

        ' Verify if the page is to be displayed in Excel.
        If Request.QueryString("bExcel") = "1" Then
            ' Set the content type to Excel.
            Response.ContentType = "application/vnd.ms-excel"
            ' Remove the charset from the Content-Type header.
            Response.Charset = ""
            ' Turn off the view state.
            Me.EnableViewState = False

            Dim tw As New System.IO.StringWriter()
            Dim hw As New System.Web.UI.HtmlTextWriter(tw)

            ' Get the HTML for the control.
            DataGrid1.RenderControl(hw)
            ' Write the HTML back to the browser.
            Response.Write(tw.ToString())
            ' End the response.
            Response.End()
        End If
    End Sub

End Class