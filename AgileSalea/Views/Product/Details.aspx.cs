using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Data;
using System.Web.UI.WebControls;
using AgileSalea.Models;
using AgileSalea.Utilities;

namespace AgileSalea.Views.Product
{
    public partial class Details : System.Web.Mvc.ViewPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            StringBuilder SB = new StringBuilder();
            DataRow pRow = (DataRow)ViewData["Product"];
                SB.Append("<h1>");
                SB.Append(pRow["ProductName"].ToString());
                SB.Append("</h1>");
                litProductName.Text = SB.ToString();
                SB.Replace(SB.ToString(), "");
                SB.Append("<a class=\"lightbox\" href=\"");
                SB.Append(pRow["ProductPhoto"].ToString());
                SB.Append("-large.jpg\"><img src=\"");
                SB.Append(pRow["ProductPhoto"].ToString());
                SB.Append("-medium.jpg\"><img src=\"");
                SB.Append("\" alt=\"");
                SB.Append(pRow["ProductName"].ToString());
                SB.Append("\" /></a>");
                litPhoto.Text = SB.ToString();
                SB.Replace(SB.ToString(),"");
                SB.Append("<strong>$ ");
                Decimal price = Convert.ToDecimal(pRow["UnitPrice"].ToString()) - Convert.ToDecimal(pRow["Discount"].ToString());
                SB.Append(price);
                SB.Append(" USD</strong><span class=\"compare_at_price\">");
                SB.Append("was <del>$");
                SB.Append(pRow["UnitPrice"].ToString());
                SB.Append(" USD</del></span>");
                litPrice.Text = SB.ToString();
                SB.Replace(SB.ToString(), "");
                SB.Append("<select id=\"product-select\" name=\"id\"><option value=\"price\">");
                SB.Append(price);
                SB.Append("</option></select>");
                litCartDetails.Text = SB.ToString();
                SB.Replace(SB.ToString(), "");
                SB.Append(pRow["ProductDesc"].ToString());
                litDescription.Text = SB.ToString();
        }
    }
}
