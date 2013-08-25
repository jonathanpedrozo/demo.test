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
    public partial class Page : System.Web.Mvc.ViewMasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            StringBuilder SBout = new StringBuilder();
            DataTable menuTable = (DataTable)ViewData["Categories"];
            DataView menuView = menuTable.DefaultView;
            foreach (DataRowView mRowView in menuView)
            {
                SBout.Append("<li><a href=\"/Home/Category/");
                SBout.Append(mRowView["CategoryName"].ToString());
                SBout.Append("\" title=\"");
                SBout.Append(mRowView["CategoryName"].ToString());
                SBout.Append("\">");
                SBout.Append(mRowView["CategoryName"].ToString());
                SBout.Append("<span class=\"arrow\"></span></a></li>");
                
            }
            litMenu.Text = SBout.ToString();
        }
    }
}
