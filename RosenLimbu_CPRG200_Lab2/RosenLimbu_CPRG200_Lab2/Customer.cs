using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Author: Rosen Limbu
 * Date: December 21, 2017
 * Description: In this class, I created a constructor so that it will be invoked inside the List Class when the Customer class is used
 * */

namespace RosenLimbu_CPRG200_Lab2
{
    public class Customer
    {
        private static int count = 0;

        public static int Count
        {get{return count;}}

        public int acctNo { get; set; }//auto-implemented getter and setter method 

        public string Name { get; set; }

        public string custType { get; set; } 

        public decimal Amount { get; set; }
 
        //default constructor
        public Customer() { }

        //overloaded constructor
        public Customer(int acct, string n, string cust, decimal amt)
        {
            acctNo = acct;
            Name = n;
            custType = cust;
            Amount = amt;
            count++;
        }

        //the ToString method is used to generate a string for the object
        public override string ToString()
        {
            return acctNo.ToString() + ", " + Name + ", " + custType + ", " + Amount.ToString("c");
        }
    }
}

