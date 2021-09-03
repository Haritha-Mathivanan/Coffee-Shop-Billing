using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeshopBilling2
{
    public class Daybill
    {
        List<Calculatebill> daylist;
        public Daybill()
        {
            daylist = new List<Calculatebill>();
            Calculatebill x = new Calculatebill("Greentea", 65, 0, 0);
            Calculatebill x1 = new Calculatebill("Cappucino", 65, 0, 0);
            Calculatebill x2 = new Calculatebill("Hot Chocolate", 85, 0, 0);
            Calculatebill x3 = new Calculatebill("Cafe Latte", 70, 0, 0);
            Calculatebill x4 = new Calculatebill("Chai", 60, 0, 0);
            daylist.Add(x);
            daylist.Add(x1);
            daylist.Add(x2);
            daylist.Add(x3);
            daylist.Add(x4);
        }
        public String Productname(int prodno)
        {
            
            int count = 0;
            foreach (Calculatebill x in daylist)
            {
                if (count == prodno)
                {
                    return x.Product;
                }
                count++;
            }
            return "";

        }
        public int Unitprice(String product)
        {
            int up = 0;
            foreach(Calculatebill c in daylist)
            {
                if (c.Product == product)
                {
                    up = c.Unitprice;
                }
            }
            return up;
        }
        public void Addtodaylist(String pd, int qt, int Amt)
        {
            foreach (Calculatebill bb in daylist)
            {
                if (bb.Product == pd)
                {
                    bb.Quantity += qt;
                    bb.Total += Amt;
                }
            }
        }
        public override string ToString()
        {
            int daytotal=0;
            String daycalc = "Product Name" +"\t|\t"+ "Unitprice" +"\t|\t"+ "Quantity"+"\t|\t" + "Amount" + "\n";
            foreach(Calculatebill c in daylist)
            {
                daycalc += c.Product + " \t\t|\t " + c.Unitprice + " \t|\t " + c.Quantity + "\t|\t " + c.Total + "\n";
                daytotal+=c.Total;
            }
            daycalc+="Day Total :  "+daytotal;
            return daycalc;
        }
           
    }
}
