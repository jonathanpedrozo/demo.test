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
    public partial class Category : System.Web.Mvc.ViewPage
    {
        protected Literal ProductList;
        protected Literal CategoryTitle;
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            StringBuilder SB = new StringBuilder();
            DataTable ProductTable = (DataTable)ViewData["Products"];
            DataView ProductView = ProductTable.DefaultView;
            
            foreach (DataRowView aRowView in ProductView)
            {
                SB.Append("<li><div class=\"product-photo\"><a href=\"");
                string path = "/Product/Details/" + aRowView["ProductID"].ToString();
                SB.Append(ApplicationUtility.FormatURL(path));
                SB.Append("\"><img alt=\"");
                SB.Append(aRowView["ProductName"].ToString());
                SB.Append("\" src=\"");
                SB.Append(aRowView["ProductPhoto"].ToString());
                SB.Append("-thumb.jpg\"></img></a></div><div class=\"product-desc\"><h3 class=\"product-title\"><a href=\"");
                SB.Append(ApplicationUtility.FormatURL(path));
                SB.Append("\">");
                SB.Append(aRowView["ProductName"].ToString());
                SB.Append("</a></h3><p class=\"product-price\">");
                decimal discounted =  Convert.ToDecimal(aRowView["UnitPrice"].ToString()) - Convert.ToDecimal(aRowView["Discount"].ToString());
                SB.Append(discounted);
                SB.Append("<del>");
                SB.Append(aRowView["UnitPrice"].ToString());
                SB.Append("</del></p></div></li>");
                litCategoryDesc.Text = aRowView["ProductCat"].ToString();
                litCategoryName.Text = aRowView["ProductCat"].ToString();
            }
            litProductThumb.Text = SB.ToString();

            
        }
    }
}
