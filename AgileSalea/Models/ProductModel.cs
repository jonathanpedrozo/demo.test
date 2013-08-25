using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AgileSalea.Entities;

namespace AgileSalea.Models
{
    public class ProductModel
    {
        private DataTable ProductBundle;
        private DataTable ProductList;

        public ProductModel()
        {
            ProductBundle = new DataTable();
            List<product> pQuery = queryProducts();

            DataColumn IDColumn = ProductBundle.Columns.Add("ProductID", Type.GetType("System.Int32"));

            ProductBundle.Columns.Add("ProductCat", Type.GetType("System.String"));
            ProductBundle.Columns.Add("ProductName", Type.GetType("System.String"));
            ProductBundle.Columns.Add("ProductDesc", Type.GetType("System.String"));
            ProductBundle.Columns.Add("UnitPrice", Type.GetType("System.Double"));
            ProductBundle.Columns.Add("Discount", Type.GetType("System.Double"));
            ProductBundle.Columns.Add("ProductPhoto", Type.GetType("System.String"));
            ProductBundle.Columns.Add("MainSale", Type.GetType("System.String"));
            ProductBundle.Columns.Add("OnSale", Type.GetType("System.String"));
            ProductBundle.Columns.Add("SupplierID", Type.GetType("System.String"));

            DataColumn[] keys = new DataColumn[1];
            keys[0] = IDColumn;
            ProductBundle.PrimaryKey = keys;
            ProductList = ProductBundle.Clone();

            foreach(product plist in pQuery )
            {
                DataRow row = ProductBundle.NewRow();
                row["ProductID"] = plist.ProductID.ToString();
                row["ProductCat"] = plist.ProductCat.ToString();
                row["ProductName"] = plist.ProductName.ToString();
                row["ProductDesc"] = plist.ProductDesc.ToString();
                row["UnitPrice"] = Convert.ToDouble(plist.UnitPrice.ToString());
                row["Discount"] = Convert.ToDouble(plist.Discount.ToString());
                row["ProductPhoto"] = plist.ProductPhoto.ToString();
                row["SupplierID"] = plist.SupplierID.ToString();
                row["MainSale"] = plist.MainSale.ToString();
                row["OnSale"] = plist.OnSale.ToString();
                ProductBundle.Rows.Add(row);

            }
            
        }
        public DataTable GetProducts()
        {
            return ProductBundle;
        }

        public DataRow GetProductByID(int ID)
        {

            DataRow RowToFind = ProductBundle.Rows.Find(ID);
            if (RowToFind != null)
            {
                return RowToFind;
            }
            else
            {
                return null;
            }
        }

        public DataTable GetProductsByCategory(string id)
        {
            ProductList.Clear();
            String expression = "ProductCat = '" + id + "'";
            DataRow[] dr = ProductBundle.Select(expression);
            foreach (DataRow row in dr)
            {
                ProductList.ImportRow(row);
            }
            return ProductList;
        }
        public DataTable GetProductsOnSale()
        {
            ProductList.Clear();
            String expression = "OnSale = 'yes'";
            DataRow[] dr = ProductBundle.Select(expression);
            foreach (DataRow row in dr)
            {
                ProductList.ImportRow(row);
            }

            return ProductList.Rows.Cast<System.Data.DataRow>().Take(8).CopyToDataTable();
            
        }

        public DataTable GetMainSales()
        {
            ProductList.Clear();
            String expression = "MainSale = 'yes'";
            DataRow[] dr = ProductBundle.Select(expression);
            foreach (DataRow row in dr)
            {
                ProductList.ImportRow(row);
            }
            return ProductList;
        }

        public static List<product> queryProducts()
        {
            List<product> query = new List<product>
            {
                new product(){ProductID =1, ProductName ="MULTIFUNCTION HP DESKJET INK ADVANTAGE 2515",ProductCat ="Printers", UnitPrice =150, Discount=10,OnSale="yes",MainSale="no", ProductPhoto ="../../Content/images/products/products/1", ProductDesc ="Phasellus vestibulum dolor commodo odio fringilla pretium. In est elit, malesuada et cursus et, ullamcorper eu leo. Duis fermentum ipsum vel neque interdum id molestie lorem rutrum. Ut nulla enim, venenatis ullamcorper accumsan id, commodo et turpis. Integer dictum pretium ante, eu facilisis metus lacinia in. Pellentesque ullamcorper orci ullamcorper tortor ornare non luctus lorem rhoncus. Suspendisse ornare bibendum dapibus.", SupplierID = "HP"},
                new product(){ProductID =2, ProductName ="MULTIFUNCTION PRINTER EPSON XP-211",ProductCat ="Printers", UnitPrice =200, Discount=10,OnSale="no",MainSale="no", ProductPhoto ="../../Content/images/products/products/2", ProductDesc ="Phasellus vestibulum dolor commodo odio fringilla pretium. In est elit, malesuada et cursus et, ullamcorper eu leo. Duis fermentum ipsum vel neque interdum id molestie lorem rutrum. Ut nulla enim, venenatis ullamcorper accumsan id, commodo et turpis. Integer dictum pretium ante, eu facilisis metus lacinia in. Pellentesque ullamcorper orci ullamcorper tortor ornare non luctus lorem rhoncus. Suspendisse ornare bibendum dapibus.", SupplierID = "EPSON"},
                new product(){ProductID =3, ProductName ="LASER SAMSUNG M2825DW",ProductCat ="Printers", UnitPrice =500, Discount=20,OnSale="yes",MainSale="no", ProductPhoto ="../../Content/images/products/products/3", ProductDesc ="Phasellus vestibulum dolor commodo odio fringilla pretium. In est elit, malesuada et cursus et, ullamcorper eu leo. Duis fermentum ipsum vel neque interdum id molestie lorem rutrum. Ut nulla enim, venenatis ullamcorper accumsan id, commodo et turpis. Integer dictum pretium ante, eu facilisis metus lacinia in. Pellentesque ullamcorper orci ullamcorper tortor ornare non luctus lorem rhoncus. Suspendisse ornare bibendum dapibus.", SupplierID = "SAMSUNG"},
                new product(){ProductID =4, ProductName ="LASER SAMSUNG ML2165W",ProductCat ="Printers", UnitPrice =200, Discount=15,OnSale="yes",MainSale="no", ProductPhoto ="../../Content/images/products/products/4", ProductDesc ="Phasellus vestibulum dolor commodo odio fringilla pretium. In est elit, malesuada et cursus et, ullamcorper eu leo. Duis fermentum ipsum vel neque interdum id molestie lorem rutrum. Ut nulla enim, venenatis ullamcorper accumsan id, commodo et turpis. Integer dictum pretium ante, eu facilisis metus lacinia in. Pellentesque ullamcorper orci ullamcorper tortor ornare non luctus lorem rhoncus. Suspendisse ornare bibendum dapibus.", SupplierID = "SAMSUNG"},
                new product(){ProductID =5, ProductName ="MULTIFUNCTION PRINTER EPSON L-210",ProductCat ="Printers", UnitPrice =550, Discount=0,OnSale="no",MainSale="yes", ProductPhoto ="../../Content/images/products/products/5", ProductDesc ="Phasellus vestibulum dolor commodo odio fringilla pretium. In est elit, malesuada et cursus et, ullamcorper eu leo. Duis fermentum ipsum vel neque interdum id molestie lorem rutrum. Ut nulla enim, venenatis ullamcorper accumsan id, commodo et turpis. Integer dictum pretium ante, eu facilisis metus lacinia in. Pellentesque ullamcorper orci ullamcorper tortor ornare non luctus lorem rhoncus. Suspendisse ornare bibendum dapibus.", SupplierID = "EPSON"},
                new product(){ProductID =6, ProductName ="IMPRESORA MULTIFUNCION HP DESKJET AL-5525",ProductCat ="Printers", UnitPrice =260, Discount=15,OnSale="yes",MainSale="no", ProductPhoto ="../../Content/images/products/products/6", ProductDesc ="Phasellus vestibulum dolor commodo odio fringilla pretium. In est elit, malesuada et cursus et, ullamcorper eu leo. Duis fermentum ipsum vel neque interdum id molestie lorem rutrum. Ut nulla enim, venenatis ullamcorper accumsan id, commodo et turpis. Integer dictum pretium ante, eu facilisis metus lacinia in. Pellentesque ullamcorper orci ullamcorper tortor ornare non luctus lorem rhoncus. Suspendisse ornare bibendum dapibus.", SupplierID = "HP"},
                new product(){ProductID =7, ProductName ="SAMSUNG E2121",ProductCat ="Phones", UnitPrice =20, Discount=0,OnSale="yes",MainSale="no", ProductPhoto ="../../Content/images/products/products/7", ProductDesc ="Phasellus vestibulum dolor commodo odio fringilla pretium. In est elit, malesuada et cursus et, ullamcorper eu leo. Duis fermentum ipsum vel neque interdum id molestie lorem rutrum. Ut nulla enim, venenatis ullamcorper accumsan id, commodo et turpis. Integer dictum pretium ante, eu facilisis metus lacinia in. Pellentesque ullamcorper orci ullamcorper tortor ornare non luctus lorem rhoncus. Suspendisse ornare bibendum dapibus.", SupplierID = "SAMSUNG"},
                new product(){ProductID =8, ProductName ="NOKIA N 201",ProductCat ="Phones", UnitPrice =50, Discount=10,OnSale="yes",MainSale="no", ProductPhoto ="../../Content/images/products/products/8", ProductDesc ="Phasellus vestibulum dolor commodo odio fringilla pretium. In est elit, malesuada et cursus et, ullamcorper eu leo. Duis fermentum ipsum vel neque interdum id molestie lorem rutrum. Ut nulla enim, venenatis ullamcorper accumsan id, commodo et turpis. Integer dictum pretium ante, eu facilisis metus lacinia in. Pellentesque ullamcorper orci ullamcorper tortor ornare non luctus lorem rhoncus. Suspendisse ornare bibendum dapibus.", SupplierID = "NOKIA"},
                new product(){ProductID =9, ProductName ="nokia lumia",ProductCat ="Phones", UnitPrice =700, Discount=10,OnSale="no",MainSale="yes", ProductPhoto ="../../Content/images/products/products/9", ProductDesc ="Phasellus vestibulum dolor commodo odio fringilla pretium. In est elit, malesuada et cursus et, ullamcorper eu leo. Duis fermentum ipsum vel neque interdum id molestie lorem rutrum. Ut nulla enim, venenatis ullamcorper accumsan id, commodo et turpis. Integer dictum pretium ante, eu facilisis metus lacinia in. Pellentesque ullamcorper orci ullamcorper tortor ornare non luctus lorem rhoncus. Suspendisse ornare bibendum dapibus.", SupplierID = "NOKIA"},
                new product(){ProductID =10, ProductName ="SAMSUNG STAR II",ProductCat ="Phones", UnitPrice =130, Discount=20,OnSale="yes",MainSale="no", ProductPhoto ="../../Content/images/products/products/10", ProductDesc ="Phasellus vestibulum dolor commodo odio fringilla pretium. In est elit, malesuada et cursus et, ullamcorper eu leo. Duis fermentum ipsum vel neque interdum id molestie lorem rutrum. Ut nulla enim, venenatis ullamcorper accumsan id, commodo et turpis. Integer dictum pretium ante, eu facilisis metus lacinia in. Pellentesque ullamcorper orci ullamcorper tortor ornare non luctus lorem rhoncus. Suspendisse ornare bibendum dapibus.", SupplierID = "SAMSUNG"},
                new product(){ProductID =11, ProductName ="LG OPTIMUS L7",ProductCat ="Phones", UnitPrice =240, Discount=0,OnSale="no",MainSale="no", ProductPhoto ="../../Content/images/products/products/11", ProductDesc ="Phasellus vestibulum dolor commodo odio fringilla pretium. In est elit, malesuada et cursus et, ullamcorper eu leo. Duis fermentum ipsum vel neque interdum id molestie lorem rutrum. Ut nulla enim, venenatis ullamcorper accumsan id, commodo et turpis. Integer dictum pretium ante, eu facilisis metus lacinia in. Pellentesque ullamcorper orci ullamcorper tortor ornare non luctus lorem rhoncus. Suspendisse ornare bibendum dapibus.", SupplierID = "LG"},
                new product(){ProductID =12, ProductName ="PC ALL IN ONE ACER AZ-1620-AR308",ProductCat ="Desktops", UnitPrice =700, Discount=100,OnSale="yes",MainSale="no", ProductPhoto ="../../Content/images/products/products/12", ProductDesc ="Phasellus vestibulum dolor commodo odio fringilla pretium. In est elit, malesuada et cursus et, ullamcorper eu leo. Duis fermentum ipsum vel neque interdum id molestie lorem rutrum. Ut nulla enim, venenatis ullamcorper accumsan id, commodo et turpis. Integer dictum pretium ante, eu facilisis metus lacinia in. Pellentesque ullamcorper orci ullamcorper tortor ornare non luctus lorem rhoncus. Suspendisse ornare bibendum dapibus.", SupplierID = "ACER"},
                new product(){ProductID =13, ProductName ="PC DE ESCRITORIO ADMIRAL AMD A4 4G/1TB/W8",ProductCat ="Desktops", UnitPrice =550, Discount=50,OnSale="yes",MainSale="no", ProductPhoto ="../../Content/images/products/products/13", ProductDesc ="Phasellus vestibulum dolor commodo odio fringilla pretium. In est elit, malesuada et cursus et, ullamcorper eu leo. Duis fermentum ipsum vel neque interdum id molestie lorem rutrum. Ut nulla enim, venenatis ullamcorper accumsan id, commodo et turpis. Integer dictum pretium ante, eu facilisis metus lacinia in. Pellentesque ullamcorper orci ullamcorper tortor ornare non luctus lorem rhoncus. Suspendisse ornare bibendum dapibus.", SupplierID = "ADMIRAL"},
                new product(){ProductID =14, ProductName ="NOTEBOOK ADMIRAL PS-CEL-002",ProductCat ="Desktops", UnitPrice =450, Discount=60,OnSale="yes",MainSale="no", ProductPhoto ="../../Content/images/products/products/14", ProductDesc ="Phasellus vestibulum dolor commodo odio fringilla pretium. In est elit, malesuada et cursus et, ullamcorper eu leo. Duis fermentum ipsum vel neque interdum id molestie lorem rutrum. Ut nulla enim, venenatis ullamcorper accumsan id, commodo et turpis. Integer dictum pretium ante, eu facilisis metus lacinia in. Pellentesque ullamcorper orci ullamcorper tortor ornare non luctus lorem rhoncus. Suspendisse ornare bibendum dapibus.", SupplierID = "ADMIRAL"},
                new product(){ProductID =15, ProductName ="NOTEBOOK TOSHIBA L845-SP4105LA",ProductCat ="Desktops", UnitPrice =1000, Discount=0,OnSale="no",MainSale="no", ProductPhoto ="../../Content/images/products/products/15", ProductDesc ="Phasellus vestibulum dolor commodo odio fringilla pretium. In est elit, malesuada et cursus et, ullamcorper eu leo. Duis fermentum ipsum vel neque interdum id molestie lorem rutrum. Ut nulla enim, venenatis ullamcorper accumsan id, commodo et turpis. Integer dictum pretium ante, eu facilisis metus lacinia in. Pellentesque ullamcorper orci ullamcorper tortor ornare non luctus lorem rhoncus. Suspendisse ornare bibendum dapibus.", SupplierID = "TOSHIBA"},
                new product(){ProductID =16, ProductName ="VAIO Notebook",ProductCat ="Desktops", UnitPrice =250, Discount=5,OnSale="no",MainSale="no", ProductPhoto ="../../Content/images/products/products/16", ProductDesc ="Phasellus vestibulum dolor commodo odio fringilla pretium. In est elit, malesuada et cursus et, ullamcorper eu leo. Duis fermentum ipsum vel neque interdum id molestie lorem rutrum. Ut nulla enim, venenatis ullamcorper accumsan id, commodo et turpis. Integer dictum pretium ante, eu facilisis metus lacinia in. Pellentesque ullamcorper orci ullamcorper tortor ornare non luctus lorem rhoncus. Suspendisse ornare bibendum dapibus.", SupplierID = "VAIO"},
                new product(){ProductID =17, ProductName ="ACER Netbook",ProductCat ="Desktops", UnitPrice =340, Discount=10,OnSale="no",MainSale="no", ProductPhoto ="../../Content/images/products/products/17", ProductDesc ="Phasellus vestibulum dolor commodo odio fringilla pretium. In est elit, malesuada et cursus et, ullamcorper eu leo. Duis fermentum ipsum vel neque interdum id molestie lorem rutrum. Ut nulla enim, venenatis ullamcorper accumsan id, commodo et turpis. Integer dictum pretium ante, eu facilisis metus lacinia in. Pellentesque ullamcorper orci ullamcorper tortor ornare non luctus lorem rhoncus. Suspendisse ornare bibendum dapibus.", SupplierID = "ACER"},
                new product(){ProductID =18, ProductName ="HP Netbook",ProductCat ="Desktops", UnitPrice =400, Discount=10,OnSale="no",MainSale="no", ProductPhoto ="../../Content/images/products/products/18", ProductDesc ="Phasellus vestibulum dolor commodo odio fringilla pretium. In est elit, malesuada et cursus et, ullamcorper eu leo. Duis fermentum ipsum vel neque interdum id molestie lorem rutrum. Ut nulla enim, venenatis ullamcorper accumsan id, commodo et turpis. Integer dictum pretium ante, eu facilisis metus lacinia in. Pellentesque ullamcorper orci ullamcorper tortor ornare non luctus lorem rhoncus. Suspendisse ornare bibendum dapibus.", SupplierID = "HP"},
                new product(){ProductID =19, ProductName ="Samsung Galaxy Tablet",ProductCat ="Tablets", UnitPrice =600, Discount=10,OnSale="no",MainSale="yes", ProductPhoto ="../../Content/images/products/products/19", ProductDesc ="Phasellus vestibulum dolor commodo odio fringilla pretium. In est elit, malesuada et cursus et, ullamcorper eu leo. Duis fermentum ipsum vel neque interdum id molestie lorem rutrum. Ut nulla enim, venenatis ullamcorper accumsan id, commodo et turpis. Integer dictum pretium ante, eu facilisis metus lacinia in. Pellentesque ullamcorper orci ullamcorper tortor ornare non luctus lorem rhoncus. Suspendisse ornare bibendum dapibus.", SupplierID = "SAMSUNG"},
                new product(){ProductID =20, ProductName ="Ipad 3 3G",ProductCat ="Tablets", UnitPrice =1300, Discount=50,OnSale="no",MainSale="no", ProductPhoto ="../../Content/images/products/products/20", ProductDesc ="Phasellus vestibulum dolor commodo odio fringilla pretium. In est elit, malesuada et cursus et, ullamcorper eu leo. Duis fermentum ipsum vel neque interdum id molestie lorem rutrum. Ut nulla enim, venenatis ullamcorper accumsan id, commodo et turpis. Integer dictum pretium ante, eu facilisis metus lacinia in. Pellentesque ullamcorper orci ullamcorper tortor ornare non luctus lorem rhoncus. Suspendisse ornare bibendum dapibus.", SupplierID = "APPLE"},
                new product(){ProductID =21, ProductName ="TABLET POSITIVO BGH YPY 7",ProductCat ="Tablets", UnitPrice =240, Discount=20,OnSale="yes",MainSale="no", ProductPhoto ="../../Content/images/products/products/21", ProductDesc ="Phasellus vestibulum dolor commodo odio fringilla pretium. In est elit, malesuada et cursus et, ullamcorper eu leo. Duis fermentum ipsum vel neque interdum id molestie lorem rutrum. Ut nulla enim, venenatis ullamcorper accumsan id, commodo et turpis. Integer dictum pretium ante, eu facilisis metus lacinia in. Pellentesque ullamcorper orci ullamcorper tortor ornare non luctus lorem rhoncus. Suspendisse ornare bibendum dapibus.", SupplierID = "BGH"},
                new product(){ProductID =22, ProductName ="TABLET APPLE IPAD MINI 3G 64GB",ProductCat ="Tablets", UnitPrice =1200, Discount=120,OnSale="yes",MainSale="no../../Content/images/products/products/22", ProductDesc ="Phasellus vestibulum dolor commodo odio fringilla pretium. In est elit, malesuada et cursus et, ullamcorper eu leo. Duis fermentum ipsum vel neque interdum id molestie lorem rutrum. Ut nulla enim, venenatis ullamcorper accumsan id, commodo et turpis. Integer dictum pretium ante, eu facilisis metus lacinia in. Pellentesque ullamcorper orci ullamcorper tortor ornare non luctus lorem rhoncus. Suspendisse ornare bibendum dapibus.", SupplierID = "APPLE"}
            };
            return query;
        }

        public static DataTable GetCatalog()
        {
            throw new NotImplementedException();
        }
    }
}
