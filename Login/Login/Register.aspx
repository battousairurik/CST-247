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
            <asp:Label ID="FirstNameLabel" runat="server" Text="First Name" Width="100px"></asp:Label>
            <asp:TextBox ID="TextBoxfirstname" runat="server" style="margin-right: 10px" Width="160px" AutoPostBack="True"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="LastNameLabel" runat="server" Text="Last Name" Width="100px"></asp:Label>
            <asp:TextBox ID="TextBoxlastname" runat="server" style="margin-right: 10px" Width="160px" AutoPostBack="True"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="GenderLabel" runat="server" Text="Gender" Width="100px"></asp:Label> 
            <asp:RadioButton ID="RadioButton1" runat="server" text="Male" Width="100px"/>
            <asp:RadioButton ID="RadioButton2" runat="server" text="Female" Width="100px"/>
        </p>
        <p>
            <asp:Label ID="AgeLabel" runat="server" Text="Age" Width="100px"></asp:Label>
            <asp:TextBox ID="TextBoxAge" runat="server" style="margin-right: 10px" Width="160px" AutoPostBack="True"></asp:TextBox>

        </p>
        <p>
            <asp:Label ID="StateLabel" runat="server" Text="State" Width="100px"></asp:Label> 
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
        </p>
        <p>
            <asp:Label ID="EmailLabel" runat="server" Text="Email Address" Width="100px"></asp:Label> 
            <asp:TextBox ID="TextBoxemail" runat="server" style="margin-right: 10px" Width="160px" AutoPostBack="True"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="UsernameLabel" runat="server" Text="Username" Width="100px"></asp:Label> 
            <asp:TextBox ID="TextBoxusername" runat="server" style="margin-right: 10px" Width="160px" AutoPostBack="True"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="PasswordLabel" runat="server" Text="Password" Width="100px"></asp:Label>  
            <asp:TextBox ID="TextBoxpassword" runat="server" style="margin-right: 10px" Width="160px" AutoPostBack="True"></asp:TextBox>
        </p>
        <p style="margin-left: 80px">
            <asp:Label ID="Label3" runat="server" Visible="False"></asp:Label>
        </p>
        <p>
            <asp:Button ID="Buttonregister" runat="server" OnClick="Buttonregister_Click" Text="Register" Width="83px" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="margin-left: 219px" Text="Login" Width="83px" />
        </p>
    </form>
</body>
</html>
