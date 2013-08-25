using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Data;
using System.Web.UI.WebControls;
using AgileSalea.Models;
using AgileSalea.Utilities;


namespace AgileSalea.Views.Checkout
{
    public partial class Details : System.Web.Mvc.ViewPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            StringBuilder SB = new StringBuilder();
            Double total = 0;
            DataTable cartTable = (DataTable)ViewData["Cart"];
            DataView CartView = cartTable.DefaultView;
            if (ViewData["Notification"] != null)
            {
                litNotification.Text = (String)ViewData["Notification"];
            }
            else { litNotification.Text = ""; }
            foreach (DataRowView aRowView in CartView)
            {
                SB.Append("<form method=\"post\" action=\"");
                SB.Append(ApplicationUtility.FormatURL("/Checkout/Edit"));
                SB.Append("\"><table width=\"50%\" class=\"productTable\"><tr><th>Product</th><th>Qty</th><th>Price</th><th></th></tr><td><img src=\"");
                SB.Append(aRowView["ProductPhoto"].ToString());
                SB.Append("\"style=\"width: 95px; height: 83px\" />");
                SB.Append(aRowView["ProductDesc"].ToString());
                SB.Append("</td><td> <input type=\"text\" name=\"txtQty\" value=\"");
                SB.Append(aRowView["Qty"].ToString());
                SB.Append("\" style=\"width: 10px\" /> <input type=\"hidden\" name=\"txtID\" value=\"");
                SB.Append(aRowView["cartID"].ToString());
                SB.Append("\"/><input type=\"submit\" value=\"Change\"></td><td> ");
                SB.Append(aRowView["ProductPrice"].ToString());
                SB.Append("</td><td> delete</td><tr></tr></table></form>");
                total = total + Convert.ToDouble(aRowView["Total"].ToString());
            }
            litCartBundle.Text = SB.ToString();
            SB.Replace(SB.ToString(), "");
            SB.Append("<table class=\"invoice\"><th colspan=\"2\"><h2> - Invoice - </h2><hr /></th><tr><td>Subtotal<hr /></td><td>");
            SB.Append(total);
            SB.Append("<hr /></td></tr><tr><td>Total:<hr /></td><td>");
            SB.Append(total);
            SB.Append("<hr /></td></tr><tr><td colspan=\"2\" class=\"payButton\"><a href=\"");
            SB.Append(ApplicationUtility.FormatURL("/Checkout"));
            SB.Append("\">Start Payment</a></td></tr></table>");
            litInvoice.Text = SB.ToString();
        }
    }
}
