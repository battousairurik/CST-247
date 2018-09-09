<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form2 {
            width: 418px;
            height: 475px;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
        <div>
        </div>
        <p>
            First Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxfirstname" runat="server" Width="217px"></asp:TextBox>
        </p>
        <p>
            Last Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxlastname" runat="server"></asp:TextBox>
        </p>
        <p>
            Gender&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxgender" runat="server"></asp:TextBox>
        </p>
        <p>
            Age&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxage" runat="server"></asp:TextBox>
        </p>
        <p>
            State&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxstate" runat="server"></asp:TextBox>
        </p>
        <p>
            E-Mail<asp:TextBox ID="TextBoxemail" runat="server" style="margin-left: 87px" Width="224px"></asp:TextBox>
        </p>
        <p>
            User Name<asp:TextBox ID="TextBoxusername" runat="server" style="margin-left: 59px" Width="224px"></asp:TextBox>
        </p>
        <p>
            Password<asp:TextBox ID="TextBoxpassword" runat="server" style="margin-left: 71px" Width="221px"></asp:TextBox>
        </p>
        <p style="margin-left: 80px">
            <asp:Label ID="Label3" runat="server" Visible="False"></asp:Label>
        </p>
        <p>
            <asp:Button ID="Buttonregister" runat="server" OnClick="Buttonregister_Click" Text="Register" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="margin-left: 219px" Text="Login" Width="83px" />
        </p>
    </form>
</body>
</html>
