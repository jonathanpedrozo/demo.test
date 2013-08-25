<%@ Page Title="" 
Language="C#" 
MasterPageFile="~/Views/Shared/Page.Master" 
CodeBehind="~/Views/Home/Category.aspx.cs"
Inherits="AgileSalea.Views.Home.Category"
AutoEventWireup="True" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ApplicationContent" runat="server">

   <!-- <asp:Literal ID="CategoryTitle" runat="server"></asp:Literal>
    <hr />
    <asp:Literal ID="ProductList" runat="server"></asp:Literal> !-->
    <div class="productlist-wrapper condensed collection collection-desktops">
      <div class="productlist-header section-header"><h1>
        <asp:Literal ID="litCategoryName" runat="server"></asp:Literal>
    </h1>
      </div>
        <asp:Literal ID="litCategoryDesc" runat="server"></asp:Literal>
    <br></br>
      <ul class="thumbgrid clearfix">
         <asp:Literal ID="litProductThumb" runat="server"></asp:Literal>
      </ul>
    </div>

</asp:Content>
