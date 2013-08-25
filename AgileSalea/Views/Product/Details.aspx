<%@ Page Title="" 
Language="C#" 
MasterPageFile="~/Views/Shared/Page.Master"
CodeBehind="Details.aspx.cs" 
Inherits="AgileSalea.Views.Product.Details" AutoEventWireup="True" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ApplicationContent" runat="server">

    <div id="single-product" class="product-golden-delicious-portable clearfix">
  
    <div id="product-photos" class="clearfix">
      <div class="large-thumb">
        <asp:Literal ID="litPhoto" runat="server"></asp:Literal>
      </div>
      
      
    <!--  <ul id="product-thumbs">
        
          <li class=" zoomThumbActive first">
            <a class="lightbox" href="http://cdn.shopify.com/s/files/1/0090/9922/products/laptop1_large.jpg?16">
              <img src="http://cdn.shopify.com/s/files/1/0090/9922/products/laptop1_thumb.jpg?16" alt="Golden Delicious Portable">
            </a>
          </li>
        
          <li class="">
            <a class="lightbox" href="http://cdn.shopify.com/s/files/1/0090/9922/products/laptop4_large.jpg?16">
              <img src="http://cdn.shopify.com/s/files/1/0090/9922/products/laptop4_thumb.jpg?16" alt="Golden Delicious Portable">
            </a>
          </li>
                
      </ul> -->
           
    </div><!-- /#product-photos -->
      
    <div id="product-details" class="right">
      <div class="product-name">
        <asp:Literal ID="litProductName" runat="server"></asp:Literal>
      </div>

      <div class="options clearfix">      
        
        <p id="add-to-cart-msg"></p>                                                        
        <p class="price">
           <asp:Literal ID="litPrice" runat="server"></asp:Literal>
        </p>   
        <form action="/cart/add" method="post" class="variants clearfix">       
                                                                                
          <div class="variants-wrapper visuallyhidden"> 
            <asp:Literal ID="litCartDetails" runat="server"></asp:Literal>
          </div>
          
          <input class="btn" type="submit" name="add" id="add-to-cart" value="Add to Cart" />
        </form>
        
      </div><!-- /.options -->
      
      <div class="description">
                
        <ul id="share-list">

          
          <li><!-- share on twitter -->
            <a href="https://twitter.com/share" class="twitter-share-button" data-count="horizontal">Tweet</a>
          </li>
          

          
          <li><!-- share on facebook -->
            <div id="fb-root"></div>
            <div class="fb-like" data-send="false" data-layout="button_count" data-width="120" data-show-faces="false"></div>          
          </li>
          

          
          <li><!-- +1 it -->
            <div class="g-plusone" data-size="medium" data-annotation="inline" data-width="150"></div>
          </li>
          
          
          
          <li><!-- pin -->
            <a href="http://pinterest.com/pin/create/button/?url=http://megatronic-theme.myshopify.com/products/golden-delicious-portable&media=http://cdn.shopify.com/s/files/1/0090/9922/products/laptop1_grande.jpg&description=Golden%20Delicious%20Portable" class="pin-it-button">Pin It</a>
            <script type="text/javascript" src="http://assets.pinterest.com/js/pinit.js"></script>
          </li>
          

        </ul>
        

        <asp:Literal ID="litDescription" runat="server"></asp:Literal>

      </div>      
    </div><!-- /#product-details -->

  </div><!-- /#single-product -->

</asp:Content>
