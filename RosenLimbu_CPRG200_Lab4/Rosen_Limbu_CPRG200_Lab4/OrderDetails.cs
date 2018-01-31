using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Author: Rosen Limbu
Created date: January 6, 2018
Description: This is a class where I declare my variables for the orderdetails
*/
namespace Rosen_Limbu_CPRG200_Lab4
{
    public class OrderDetails
    {
        public OrderDetails() { }//empty constructor
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }
    }
}
