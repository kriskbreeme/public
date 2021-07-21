<%@ Page Language="VB" AutoEventWireup="false" CodeFile="IncomePage.aspx.vb" Inherits="IncomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Income Page </title>

     <link href="stylesheetGreenBackgroundLavender.css" rel ="stylesheet"
        type ="text/css" />
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 298px;
        }
        .auto-style3 {
            width: 112px;
            height: 29px;
        }
        .auto-style4 {
            height: 29px;
        }
    </style>
</head>
<body>

    <center><center><img src ="logo.png" alt ="logo" /></center> </center>
    <center><h1>Fill out the income information below:</h1></center>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Wages, salaries, and tips (from 1040EZ line 1):</td>
                <td>
                    <asp:TextBox ID="txtWages" runat="server"></asp:TextBox>
                    <asp:RangeValidator ID="RangeValidator3" runat="server" ControlToValidate="txtWages" ErrorMessage="RangeValidator" MaximumValue="200000" MinimumValue="0">Please enter your wages</asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Taxable Interest (see 1040EZ line 2):</td>
                <td>
                    <asp:TextBox ID="txtInterest" runat="server"></asp:TextBox>
                    <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="txtInterest" ErrorMessage="Cannot use 1040EZ for interest greater than $1,500" MaximumValue="1500" Type="Double">Cannot use 1040EZ, interest greater than $1,500!</asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">If married filing jointly check the bubble:</td>
                <td>
                    <asp:RadioButton ID="jointRadioButton" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="btnCalculate" runat="server" Text="Calculate Taxable Income" Width="235px" />
                </td>
                <td>
                    <asp:Button ID="btnContinue" runat="server" Text="Continue" Width="235px" />
                </td>
            </tr>
        </table>
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">Taxable Income:</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtTaxableIncome" runat="server"></asp:TextBox>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtTaxableIncome" ErrorMessage="Cannot use 1040EZ for Income greater than $100,000" MaximumValue="100000"></asp:RangeValidator>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
