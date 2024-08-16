<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebFormsApplication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Support Form</h1>
            <p>
                <asp:Literal runat="server" ID="ltMessage"></asp:Literal>&nbsp;</p>
            <label id="lblFirstname">Firstname</label><asp:TextBox runat="server" ID="txtFirstname"></asp:TextBox><asp:RequiredFieldValidator runat="server"  ID="valFirstname" ForeColor="Red"></asp:RequiredFieldValidator>
            
        </div>
        <div>
            <asp:Label runat="server" Text="Lastname" ID="ctl24"></asp:Label>
            <asp:TextBox runat="server" ID="txtLastName"></asp:TextBox>&nbsp;</div>
        <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label><asp:TextBox runat="server" ID="txtEmail"></asp:TextBox><asp:RequiredFieldValidator runat="server" ID="valEmail" ForeColor="Red"></asp:RequiredFieldValidator>
        <div>
            <asp:Label runat="server" Text="Description" ID="ctl27"></asp:Label><asp:TextBox runat="server" Height="200px" ID="txtDescription" TextMode="MultiLine"></asp:TextBox>&nbsp;</div>
        <div>
            <asp:Button runat="server" Text="Submit" ID="btnSubmit"></asp:Button>
            &nbsp;</div>
    </form>
</body>
</html>
