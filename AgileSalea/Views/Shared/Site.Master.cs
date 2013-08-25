using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using AgileSalea.Models;
using AgileSalea.Utilities;

namespace AgileSalea.Views.Shared
{
    public partial class Site : System.Web.Mvc.ViewMasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            StringBuilder SBout = new StringBuilder();
            string cartNumber = string.Empty;

            DataTable menuTable = (DataTable)ViewData["Categories"];
            DataView menuView = menuTable.DefaultView;

            DataTable cartTable = (DataTable)ViewData["Cart"];
            DataView cartView = cartTable.DefaultView;
            if (cartView.Table.Rows.Count > 0)
            {
                cartNumber = cartView.Table.Rows.Count.ToString();
            }

            menuView.Sort = "CategoryID Asc";
            SBout.Append("<ul><li class=\"homeMenu\"><a href=\"");
            SBout.Append(ApplicationUtility.FormatURL("/Checkout/Details/"));
            SBout.Append("\">My Cart</a><span class=\"cartBuble\">");
            SBout.Append(cartNumber);
            SBout.Append("</span></li>|<li class=\"homeMenu\"><a href=\"");
            SBout.Append(ApplicationUtility.FormatURL("/Home/Index/"));
            SBout.Append("\">Home Page</a></li></ul>");
            litHomeMenu.Text = SBout.ToString();
            SBout.Replace(SBout.ToString(), "");

            foreach (DataRowView mRowView in menuView)
            {

                SBout.Append("<li class=\"menu\"><a href=\"/Home/Category/");
                SBout.Append(mRowView["CategoryName"].ToString());
                SBout.Append("\">");
                SBout.Append(mRowView["CategoryName"].ToString());
                SBout.Append("</a></li>");
                litMenu.Text = SBout.ToString();
            }
        }
    }
}

