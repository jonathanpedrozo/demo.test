using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgileSalea.Entities
{
    public class Cart
    {
        private int _cartID = -1;
        public int CartID
        {
            get { return _cartID; }
            set { _cartID = value; }
        }
        private int _prodID = -1;
        public int ProdID
        {
            get { return _prodID; }
            set { _prodID = value; }
        }
        private string _prodDesc = string.Empty;
        public string ProdDesc
        {
            get { return _prodDesc; }
            set { _prodDesc = value; }
        }
        private Double _unitPrice = -1;
        public Double UnitPrice
        {
            get { return _unitPrice; }
            set { _unitPrice = value; }
        }
        private Double _total = -1;
        public Double Total
        {
            get { return _total; }
            set { _total = value; }
        }
        private int _qty = -1;
        public int Qty
        {
            get { return _qty; }
            set { _qty = value; }
        }
        private string _photo = string.Empty;
        public string Photo
        {
            get { return _photo; }
            set { _photo = value; }
        }

    }
}
