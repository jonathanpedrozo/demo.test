//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Web;
//using System.Data;
//using System.Web.UI.WebControls;
//using AgileSalea.Models;
//using AgileSalea.Utilities;


//namespace AgileSalea.Views.Home
//{
//    public partial class Index2 : System.Web.Mvc.ViewPage
//    {
//        protected void Page_Load(object sender, EventArgs e)
//        {
//            Response.Cache.SetCacheability(HttpCacheability.NoCache);
//            StringBuilder SB = new StringBuilder();
//            DataTable ContentsTable = (DataTable)ViewData["Contents"];
//            DataView ContentsView = ContentsTable.DefaultView;
//            DataTable SaleTable = (DataTable)ViewData["OnSale"];
//            DataView SaleView = SaleTable.DefaultView;
//            int sliderid = 1;
//            foreach (DataRowView cRowView in ContentsView)
//            {
//                string obName = "";
//                string obPath = "";
//                obName = cRowView["Name"].ToString();
//                obPath = cRowView["Path"].ToString();
//                SB.Append("<div><img src=\"../../Content/images/products/sales/");
//                SB.Append(obName);
//                SB.Append(".jpg\" /><br /> Samgung $10</div>");
//            }

//            litProducts.Text = SB.ToString();
//            SB.Replace(SB.ToString(), "");
//            foreach (DataRowView sRowView in SaleView)
//            {
//                SB.Append("<a href=\"");
//                SB.Append(ApplicationUtility.FormatURL("/Checkout/Cart/"));
//                SB.Append(sRowView["ProductID"].ToString());
//                SB.Append("\"><img id=\"");
//                SB.Append(sliderid);         
//                SB.Append("\" src=\"../../Content/images/products/sales/");
//                SB.Append(sRowView["ProductID"].ToString());
//                SB.Append(".jpg\" /></a>");
//                sliderid = sliderid + 1;
//            }
//            litSlider.Text = SB.ToString();
//        }

//    }
//}
