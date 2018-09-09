<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form2 {
            width: 438px;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
        <div>
        </div>
        <p>
            User Name<asp:TextBox ID="TextBoxusername" runat="server" style="margin-left: 59px" Width="224px"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" Visible="False"></asp:Label>
        </p>
        <p>
            E-Mail<asp:TextBox ID="TextBoxemail" runat="server" style="margin-left: 87px" Width="224px"></asp:TextBox>
        </p>
        <p>
            Password<asp:TextBox ID="TextBoxpassword" runat="server" style="margin-left: 71px" Width="221px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Buttonregister" runat="server" OnClick="Buttonregister_Click" Text="Register" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="margin-left: 219px" Text="Login" Width="83px" />
        </p>
    </form>
</body>
</html>
