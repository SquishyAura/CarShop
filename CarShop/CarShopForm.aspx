<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CarShopForm.aspx.cs" Inherits="CarShop.CarShopForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 26px;
            padding: 10px;
        }
        .auto-style2 {
            height: 611px;
            width: 267px;
            float: left;
            border: 1px solid black;
            padding: 10px;
        }
        .auto-style3 {
            width: 268px;
            float: left;
            height: 611px;
            border: 1px solid black;
            padding: 10px;
        }
        .auto-style4 {
            height: 291px;
        }
        </style>
</head>
<body style="height: 751px; width: 1097px">
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        Car Shop</div>
        <div class="auto-style2">
            Buy Car<br />
            <br />
            Brand
            <br />
            <asp:TextBox ID="BrandBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Year
            <br />
            <asp:TextBox ID="YearBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="BuyButton" runat="server" Text="Buy" OnClick="BuyButton_Click" />
            <br />
            <br />
            <asp:Button ID="CarShowButton" runat="server" Text="Show Sold Cars" OnClick="CarShowButton_Click" />
            <br />
            <br />
            <asp:Label ID="CarLabel" runat="server"></asp:Label>
        </div>
    <div class="auto-style3">
        Sign Up As Customer<br />
        <br />
        <asp:RadioButton ID="PrivateRadio" runat="server" Text="Private" />
        <br />
        <asp:RadioButton ID="BusinessRadio" runat="server" Text="Business" />
        <br />
        Name<br />
        <asp:TextBox ID="NameBox" runat="server"></asp:TextBox>
        <br />
        <br />
        Phone Number<asp:TextBox ID="PhoneNumberBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="SignUpButton" runat="server" Text="Sign Up" OnClick="SignUpButton_Click" />
        <br />
        <br />
        <asp:Button ID="ShowCustomerButton" runat="server" Text="Show Customers" OnClick="ShowCustomerButton_Click" />
        <br />
        <br />
        <textarea id="CustomerArea" aria-readonly="True" class="auto-style4" cols="20" name="S2" rows="1"></textarea></div>
    </form>
    </body>
</html>
