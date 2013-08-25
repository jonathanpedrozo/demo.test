using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Data;
using System.Web.UI.WebControls;
using AgileSalea.Models;
using AgileSalea.Utilities;

namespace AgileSalea.Views.Home
{
    public partial class Index : System.Web.Mvc.ViewPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            StringBuilder SB = new StringBuilder();
            DataTable SaleTable = (DataTable)ViewData["OnSale"];
            DataView SaleView = SaleTable.DefaultView;
            DataTable MainSaleTable = (DataTable)ViewData["MainSale"];
            DataView MainSaleView = MainSaleTable.DefaultView;
            int sliderid = 1;
            foreach (DataRowView sRowView in MainSaleView)
            {
                SB.Append("<li id=\"");
                SB.Append(sliderid);
                SB.Append("\"> <img src=\"../../Content/images/products/sales/");
                SB.Append(sRowView["ProductID"].ToString());
                SB.Append(".jpg\" alt=\"\" /></li>");
                sliderid = sliderid + 1;
            }
            litCarouselItems.Text= SB.ToString();
            SB.Replace(SB.ToString(),"");
            foreach (DataRowView pRowView in SaleView)
            {
                SB.Append("<li><div class=\"product-photo\"><a href=\"/Product/Details/");
                SB.Append(pRowView["ProductID"].ToString());
                SB.Append("\"><img src=\"");
                SB.Append(pRowView["ProductPhoto"].ToString());
                SB.Append("-thumb.jpg\" alt=\"");
                SB.Append(pRowView["ProductName"].ToString());
                SB.Append("\" /></a></div><div class=\"product-desc\"><h3 class=\"product-title\"><a href=\"/Product/Details/");
                SB.Append(pRowView["ProductID"].ToString());
                SB.Append("\">");
                SB.Append(pRowView["ProductName"].ToString());
                SB.Append("</a></h3><p class=\"product-price\">");
                decimal discount = Convert.ToDecimal(pRowView["UnitPrice"].ToString()) - Convert.ToDecimal(pRowView["Discount"].ToString());
                SB.Append(discount);
                SB.Append("</p><del>");
                SB.Append(pRowView["UnitPrice"].ToString());
                SB.Append("</del></p></div></li>");
            }
            litSaleProducts.Text = SB.ToString();
        }
    }
}
