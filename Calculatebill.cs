using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeshopBilling2
{
    public class Calculatebill
    {
        String _product;
        int _unitprice;
        int _quantity;
        int _total;
        public Calculatebill(String product,int unitprice,int quantity,int total)
        {
            this.Product = product;
            this.Unitprice = unitprice;
            this.Quantity = quantity;
            this.Total = total;
            
        }
        
        public String Product
        {
            get { return _product; }
            set { _product = value; }
        }
      
        public int Unitprice
        {
            get { return _unitprice; }
            set { _unitprice = value; }
        }
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
        public int Total
        {
            get { return _total; }
            set { _total = value; }
        }
    }
}
