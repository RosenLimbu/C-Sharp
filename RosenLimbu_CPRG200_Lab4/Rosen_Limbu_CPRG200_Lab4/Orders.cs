using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Author: Rosen Limbu
Created date: January 6, 2018
Description: This is a class where I declare my variables
*/
namespace Rosen_Limbu_CPRG200_Lab4
{
    public class Orders
    {
        public Orders() { }//empty constructor
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public DateTime? OrderDate { get; set; } //? makes the DateTime nullable
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
    }
}
