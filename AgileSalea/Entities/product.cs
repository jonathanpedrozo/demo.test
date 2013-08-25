using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgileSalea.Entities
{
    public class product : SubCategories
    {
        private int _productID = -1;
        public int ProductID
        {
            get { return _productID; }
            set { _productID = value; }
        }
        private string _productName = string.Empty;
        public string ProductName
        {
            get { return _productName; }
            set { _productName = value; }
        }
        private string _productDesc = string.Empty;
        public string ProductDesc
        {
            get { return _productDesc; }
            set { _productDesc = value; }
        }
        private string _productCat = string.Empty;
        public string ProductCat
        {
            get { return _productCat; }
            set { _productCat = value; }
        }
        private string _onSale = "no";
        public string OnSale
        {
            get { return _onSale; }
            set { _onSale = value; }
        }
        private string _mainSale = "no";
        public string MainSale
        {
            get { return _mainSale; }
            set { _mainSale = value; }
        }
        private double _unitPrice = -1;
        public double UnitPrice
        {
            get { return _unitPrice; }
            set { _unitPrice = value; }
        }
        private double _discount = -1;
        public double Discount
        {
            get { return _discount; }
            set { _discount = value; }
        }
        private string _supplierID = string.Empty;
        public string SupplierID
        {
            get { return _supplierID; }
            set { _supplierID = value; }
        }
        private string _productPhoto = string.Empty;
        public string ProductPhoto
        {
            get { return _productPhoto; }
            set { _productPhoto = value; }
        }
        private int _views = 0;
        public int Views
        {
            get { return _views; }
            set { _views = value; }
        }


    }
}
