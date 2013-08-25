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
    public partial class Index : System.Web.Mvc.ViewPage
    {
        public void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                litPersProvinceDDL.Text = "<select><option value=\"1\">Buenos Aires</option><option value=\"2\">Cordoba</option><option value=\"3\">Santa Fe</option></select>";
                litDelProv.Text = "<select><option value=\"1\">Buenos Aires</option><option value=\"2\">Cordoba</option><option value=\"3\">Santa Fe</option></select>";
                litShippingDay.Text = "<select><option value=\"1\">Monday</option><option value=\"2\">Wednesday</option><option value=\"3\">Friday</option></select>";
                litTimeRange.Text = "<select><option value=\"1\">09hs - 12hs</option><option value=\"2\">13hs - 17hs</option><option value=\"3\">17hs - 20hs</option></select>";
            }

        }
    }
}
