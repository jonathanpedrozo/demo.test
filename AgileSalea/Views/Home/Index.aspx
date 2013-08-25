<%@ Page Title="" 
Language="C#" 
MasterPageFile="~/Views/Shared/Page.Master"
CodeBehind="Index.aspx.cs" 
Inherits="AgileSalea.Views.Home.Index" AutoEventWireup="True" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ApplicationContent" runat="server">
		<div id="carousel-wrapper">
			<div id="carousel">	
				<ol class="items">
				     <asp:Literal ID="litCarouselItems" runat="server"></asp:Literal>
				</ol>						
			</div>
			<div id="carousel-controls" class="clearfix">
				<ol id="carousel-slide-menu">
                 <li id="control1" class="active"></li><li id="control2"></li><li id="control3"></li>
                </ol>
				<p class="carousel-nextprev"><a class="prev browse left" title="Previous slide" id="sliderPrev">Previous</a> / <a class="next browse right" title="Next slide" id="sliderNext">Next</a> </p>				
			</div>
			
			
		</div>
	<div class="home-ads clearfix">
		
		<!-- Ad on the left #1 -->
		<div class="widget widget-image" id="widget-home-ad-1">
			<div class="widget-content">			
				
					<img src="../../Content/images/ads/ad-left.jpg" alt="" />
				
			</div>
		</div><!-- /.widget -->
	
		<!-- Ad on the right #2 -->
		<div class="widget widget-image" id="widget-home-ad-2">
			<div class="widget-content">
				
					<img src="../../Content/images/ads/ad-right.jpg" alt="" />
									
			</div>
		</div><!-- /.widget -->
		
	</div>
	
	<!-- Product list -->
	<div class="productlist-wrapper condensed">
		<div class="productlist-header section-header">
			<h2><a href="/collections/frontpage" title="">This Week's Super Sale!</a></h2>
		</div>
		<ul class="thumbgrid clearfix">
            <asp:Literal ID="litSaleProducts" runat="server"></asp:Literal>			
		</ul>
	</div><!-- /.productlist-wrapper -->
</asp:Content>
