<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Bottom.aspx.vb" Inherits="ExcelExport.Bottom" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title></title>
    </head>
    <body>
        <form id="form1" runat="server">
            <div>
                <asp:datagrid id="DataGrid1" runat="server" GridLines="Vertical" CellPadding="3" BackColor="White"
            BorderColor="#999999" BorderWidth="1px" BorderStyle="None" Width="100%" Height="100%" Font-Size="X-Small"
            Font-Names="Verdana">
	                <SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#008A8C"></SelectedItemStyle>
	                <AlternatingItemStyle BackColor="Gainsboro"></AlternatingItemStyle>
	                <ItemStyle BorderWidth="2px" ForeColor="Black" BorderStyle="Solid" BorderColor="Black" BackColor="#EEEEEE"></ItemStyle>
	                <HeaderStyle Font-Bold="True" HorizontalAlign="Center" BorderWidth="2px" ForeColor="White" BorderStyle="Solid"
	                BorderColor="Black" BackColor="#000084"></HeaderStyle>
	                <FooterStyle ForeColor="Black" BackColor="#CCCCCC"></FooterStyle>
	                <PagerStyle HorizontalAlign="Center" ForeColor="Black" BackColor="#999999" Mode="NumericPages"></PagerStyle>
                </asp:datagrid>
            </div>
        </form>
    </body>
</html>
