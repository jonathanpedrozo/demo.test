using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgileSalea.Entities
{
    public class Categories
    {
        private int _categoryID = -1;
        public int CategoryID
        {
            get { return _categoryID; }
            set { _categoryID = value; }
        }
        private string _categoryName = string.Empty;
        public string CategoryName
        {
            get { return _categoryName; }
            set { _categoryName = value; }
        }
    }
}
