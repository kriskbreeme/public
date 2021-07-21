<%@ Page Language="VB" AutoEventWireup="false" CodeFile="FilerPage.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Income Tax Calculator - Filer Page </title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 96px;
        }
        .auto-style4 {
            width: 96px;
            height: 25px;
        }
        .auto-style5 {
            height: 25px;
            width: 807px;
        }
        .auto-style7 {
            width: 96px;
            height: 28px;
        }
        .auto-style8 {
            height: 28px;
            width: 807px;
        }
        .auto-style9 {
            width: 807px;
        }
        .auto-style10 {
            width: 96px;
            height: 32px;
        }
        .auto-style11 {
            width: 807px;
            height: 32px;
        }
    </style>
    <link href="stylesheetGreenBackgroundLavender.css" rel ="stylesheet"
        type ="text/css" />
</head>
<body>
    <center><img src ="logo.png" alt ="logo" /></center>
    <center><h1>Please fill out the filer information below:</h1></center>
    
    <form id="form1" runat="server">
    <div>
    
    </div>
    <table class="auto-style1">
        <tr>
            <td class="auto-style7">First Name:</td>
            <td class="auto-style8">
                <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFirstName" ErrorMessage="RequiredFieldValidator">Please enter your name</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Last Name:</td>
            <td class="auto-style9">
                <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Home Address:</td>
            <td class="auto-style9">
                <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">City:</td>
            <td class="auto-style9">
                <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">State:</td>
            <td class="auto-style9">
                <asp:TextBox ID="txtState" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtState" ErrorMessage="RequiredFieldValidator">Please enter your state</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Zip Code:</td>
            <td class="auto-style8">
                <asp:TextBox ID="txtZip" runat="server"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtZip" ErrorMessage="RangeValidator" MaximumValue="99999" MinimumValue="00000">Please enter a valid zip code</asp:RangeValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style4"></td>
            <td class="auto-style5"></td>
        </tr>
        <tr>
            <td class="auto-style10">
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" Width="115px" />
            </td>
            <td class="auto-style11">Clicking the submit button will take you onto the next steps!</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Button ID="btnClear" runat="server" Text="Clear" Width="115px" />
            </td>
            <td class="auto-style9">&nbsp;</td>
        </tr>
    </table>
    </form>
    </body>
</html>
