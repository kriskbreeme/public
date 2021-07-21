<%@ Page Language="VB" AutoEventWireup="false" CodeFile="PaymentsPage.aspx.vb" Inherits="PaymentsPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Payments Page</title>

    <link href="stylesheetGreenBackgroundLavender.css" rel ="stylesheet"
        type ="text/css" />
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 538px;
        }
    </style>
</head>
<body>
     <center><img src ="logo.png" alt ="logo" /></center>
    <center><h1>Please fill out the box below:</h1></center>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Federal income tax withheld and reported (from forms W-2 and 1099, 1040EZ line 7):</td>
                <td>
                    <asp:TextBox ID="txtFedIncomeTaxWHeld" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="continueButton2" runat="server" Text="Continue" Width="127px" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
