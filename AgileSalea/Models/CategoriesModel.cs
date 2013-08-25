using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AgileSalea.Entities;

namespace AgileSalea.Models
{
    public class CategoriesModel
    {
        private DataTable CategoriesBundle;

        public CategoriesModel()
        {
            CategoriesBundle = new DataTable();
            List<Categories> cQuery = queryCategories();

            DataColumn IDColumn = CategoriesBundle.Columns.Add("CategoryID", Type.GetType("System.Int32"));
            CategoriesBundle.Columns.Add("SubCategoryName", Type.GetType("System.String"));
            CategoriesBundle.Columns.Add("CategoryName", Type.GetType("System.String"));
            

            DataColumn[] keys = new DataColumn[1];
            keys[0] = IDColumn;
            CategoriesBundle.PrimaryKey = keys;

            foreach (Categories clist in cQuery)
            {
                DataRow row = CategoriesBundle.NewRow();
                row["CategoryName"] = clist.CategoryName.ToString();
                row["CategoryID"] = Convert.ToInt32(clist.CategoryID.ToString());
                CategoriesBundle.Rows.Add(row);

            }
        }

        public DataTable GetCategories()
        {
            return CategoriesBundle;
        }

        public static List<Categories> queryCategories()
        {
          List<Categories> query = new List<Categories>
           {
            new Categories(){ CategoryID = 1, CategoryName = "Desktops"},
            new Categories(){ CategoryID = 2, CategoryName = "Printers"},
            new Categories(){ CategoryID = 3, CategoryName = "Phones"},
            new Categories(){ CategoryID = 4, CategoryName = "Tablets"}
           };
          return query;       
        }

    }
}
