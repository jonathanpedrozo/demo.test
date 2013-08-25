using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AgileSalea.Entities;

namespace AgileSalea.Models
{
    public class CartModel
    {
        private DataTable CartBundle;

        public CartModel()
        {
            CartBundle = new DataTable();
            DataColumn IDColumn = CartBundle.Columns.Add("cartID", Type.GetType("System.Int32"));
            IDColumn.AutoIncrement = true;
            IDColumn.AutoIncrementSeed = 1;
            IDColumn.AutoIncrementStep = 1;

            CartBundle.Columns.Add("ProductID", Type.GetType("System.Int32"));
            CartBundle.Columns.Add("ProductDesc", Type.GetType("System.String"));
            CartBundle.Columns.Add("ProductPrice", Type.GetType("System.Double"));
            CartBundle.Columns.Add("Total", Type.GetType("System.Double"));
            CartBundle.Columns.Add("ProductPhoto", Type.GetType("System.String"));
            CartBundle.Columns.Add("Qty", Type.GetType("System.Int32"));

            DataColumn[] keys = new DataColumn[1];
            keys[0] = IDColumn;
            CartBundle.PrimaryKey = keys;
        }

        public void AddCart(DataRow product, int qty)
        {
            DataRow row = CartBundle.NewRow();
            CartBundle.Rows.Add(row);
            row["ProductID"] = Convert.ToInt32(product["ProductID"].ToString());
            row["ProductDesc"] = product["ProductDesc"].ToString();
            row["ProductPrice"] = Convert.ToDouble(product["UnitPrice"].ToString());
            row["Qty"] = qty;
            row["Total"] = Convert.ToDouble(product["UnitPrice"].ToString()) * qty;
            row["ProductPhoto"] = product["ProductPhoto"].ToString();
        }

        public void DeleteCart(int ID)
        {
            DataRow RowToDelete = CartBundle.Rows.Find(ID);
            if (RowToDelete != null)
            {
                CartBundle.Rows.Remove(RowToDelete);
            }
        }

        public void EditCart(int ID, int Qty)
        {
            DataRow RowToEdit = CartBundle.Rows.Find(ID);
            if (RowToEdit != null)
            {

                RowToEdit["Qty"] = Qty;
                RowToEdit["Total"] = Convert.ToDouble(RowToEdit["ProductPrice"].ToString()) * Qty;

            }
        }

        public DataTable GetCarts()
        {
            return CartBundle;
        }
    }
}
