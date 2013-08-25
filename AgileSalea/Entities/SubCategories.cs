using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgileSalea.Entities
{
    public class SubCategories : Categories
    {
        private int _subCategoryID = -1;
        public int SubCategoryID
        {
            get { return _subCategoryID; }
            set { _subCategoryID = value; }
        }
        private string _subCategoryName = string.Empty;
        public string SubCategoryName
        {
            get { return _subCategoryName; }
            set { _subCategoryName = value; }
        }
    }
}
