using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeshopBilling2
{
    class Program
    {
       // static Menu m = new Menu();
        static Daybill db = new Daybill();
              
        static void Main(string[] args)
        {
            String Continue = "";
          do
          {
               List<Calculatebill> Singlebill = new List<Calculatebill>();
               Console.Clear();
               Console.WriteLine("Greentea-0\t"+ "Cappucino-1 \t"+ "Hot Chocolate-2 \t" +"Cafe Latte-3 \t" +"Chai-4");
          do
          {
              GetInput(Singlebill);
              Console.WriteLine("Press c for next entry \n Press q for Close today billing");
              Continue = Console.ReadLine();
             
          }while(Continue=="c"||Continue=="C");

          display(Singlebill);
          Console.ReadLine();

          }while(Continue!="q");
          Console.WriteLine("------------------------X---------------------------");
          Console.WriteLine("****************Today Sales********************");
          Console.WriteLine(db);
          
        }
        public static void display(List<Calculatebill> Singlebill)
        {
            Console.WriteLine("productname \t unitprice \t Quantity  \t Amount");
            Console.WriteLine("___________________________________________");
            int Bill=0;
            foreach(Calculatebill c in Singlebill)
            {
                Console.WriteLine(c.Product+" \t "+c.Unitprice+" \t "+c.Quantity+" \t "+c.Total);
                Bill+=c.Total;
            }
          
            Console.WriteLine("Total Amount : "+Bill);
            
        }
        public static void GetInput(List<Calculatebill> Singlebill)
        {
            Console.Write("Productno : ");
            int productno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Quantity  :  ");
            int Quantity = Convert.ToInt32(Console.ReadLine());
            String productname = db.Productname(productno);
            int unitprice = db.Unitprice(productname);
            int Amount = unitprice * Quantity;
            Calculatebill c = new Calculatebill(productname, unitprice, Quantity, Amount);
            Singlebill.Add(c);
            db.Addtodaylist(productname, Quantity, Amount);
        }
       
            

        }
    }

