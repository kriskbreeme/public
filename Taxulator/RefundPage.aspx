<%@ Page Language="VB" AutoEventWireup="false" CodeFile="RefundPage.aspx.vb" Inherits="RefundPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Refund or Owing Page</title>

     <link href="stylesheetGreenBackgroundLavender.css" rel ="stylesheet"
        type ="text/css" />

    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 191px;
        }
        .auto-style3 {
            width: 191px;
            height: 26px;
        }
        .auto-style4 {
            height: 26px;
        }
        .auto-style5 {
            width: 191px;
            height: 25px;
        }
        .auto-style6 {
            height: 25px;
        }
        .auto-style7 {
            width: 195px;
        }
    </style>

</head>
<body>

    <center><img src ="logo.png" alt ="logo" /></center>
    <center><h1>Here is your Tax Refund or Owing Information</h1></center>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">First Name:</td>
                <td>
                    <asp:Label ID="lblFirstName" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Last Name:</td>
                <td>
                    <asp:Label ID="lblLastName" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Address:</td>
                <td>
                    <asp:Label ID="lblAddress" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">City:</td>
                <td class="auto-style6">
                    <asp:Label ID="lblCity" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">State:</td>
                <td>
                    <asp:Label ID="lblState" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Zip Code:</td>
                <td>
                    <asp:Label ID="lblZipCode" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style5"></td>
                <td class="auto-style6"></td>
            </tr>
            <tr>
                <td class="auto-style3">Wages, salaries, and tips:</td>
                <td class="auto-style4">
                    <asp:Label ID="lblWages" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Taxable interest:</td>
                <td class="auto-style6">
                    <asp:Label ID="lblInterest" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Taxable Income:</td>
                <td>
                    <asp:Label ID="lblTaxableIncome" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Federal income tax withheld:</td>
                <td>
                    <asp:Label ID="lblIncomeTaxWHeld" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="Button1" runat="server" Text="TAXULATE!" Width="198px" />
                </td>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/TaxTable.accdb" SelectCommand="SELECT [ID], [LowerBound], [UpperBound], [Tax] FROM [Tax]"></asp:AccessDataSource>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">This is your refund:</td>
                <td>
                    <asp:Label ID="lblRefund" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
        </table>
        <table class="auto-style1">
            <tr>
                <td class="auto-style7">This is how much you owe:</td>
                <td>
                    <asp:Label ID="lblOwing" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
