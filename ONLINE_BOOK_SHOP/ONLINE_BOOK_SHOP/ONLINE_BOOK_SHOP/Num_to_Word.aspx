<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Num_to_Word.aspx.cs" Inherits="ONLINE_BOOK_SHOP.Num_to_Word" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            <h3>Number to Words Conversion</h3>
            <asp:Label ID="lblResult" runat="server"></asp:Label>
            <br />
            <asp:TextBox ID="txtNumber" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnConvert" runat="server" Text="Convert" OnClick="btnConvert_Click" />
        </div>
    </form>
</body>
</html>
