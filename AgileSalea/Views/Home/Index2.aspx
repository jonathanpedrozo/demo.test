<%@ Page Title="" 
Language="C#" 
MasterPageFile="~/Views/Shared/Site.Master" 
CodeBehind="Index2.aspx.cs"
Inherits="AgileSalea.Views.Home.Index2" 
AutoEventWireup="True" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ApplicationContent" runat="server">

  <div id="page-content">
      <div id="index-content">
        <div id="slider-content">
           <div class="slider">
             <asp:Literal ID="litSlider" runat="server"></asp:Literal>
           </div>
        </div>
        <br />
        <div class="mini-slider-content">
           <h3>Featured Products</h3>
           <div class="products" style="display:block">
                <asp:Literal ID="litProducts" runat="server"></asp:Literal>
           </div>
          </div>
          <br />
          <hr />
          <div id="top-brands">
               <h2>Top Brands</h2>
                 <ul>
                    <li><img src="../../Content/images/hp.jpg" /></li>
                    <li><img src="../../Content/images/sony.jpg" /></li>
                    <li><img src="../../Content/images/nokia.jpg" /></li>
                 </ul>
          </div>
          <hr />
      </div>
  </div>
    

</asp:Content>
