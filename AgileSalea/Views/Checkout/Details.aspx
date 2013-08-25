<%@ Page Title="" 
Language="C#" 
MasterPageFile="~/Views/Shared/Site.Master" 
CodeBehind="~/Views/Checkout/Details.aspx.cs"
Inherits="AgileSalea.Views.Checkout.Details"
AutoEventWireup="True" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ApplicationContent" runat="server">

    <h2>My Cart Details</h2>
    <hr />
    <asp:Literal ID="litNotification" runat="server"></asp:Literal>
    <asp:Literal ID="litCartBundle" runat="server"></asp:Literal>
    <asp:Literal ID="litInvoice" runat="server"></asp:Literal>

</asp:Content>
