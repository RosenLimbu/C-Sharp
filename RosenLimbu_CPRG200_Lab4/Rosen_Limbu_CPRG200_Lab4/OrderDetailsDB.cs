using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Author: Rosen Limbu
Created date: January 9, 2018
Description: This is the class for the modify form where I will open connection and load the orderdetails to a list and pass it back to the modify form. Also, I will do my calculations
for getting total charge
*/
namespace Rosen_Limbu_CPRG200_Lab4
{
   public class OrderDetailsDB
    {
        public static List<OrderDetails> getOrderDetails(int orderID)//loads up the ordertails to a list and passes using orderID
        {
            List<OrderDetails> od = new List<OrderDetails>();
            OrderDetails ordDet = null;
            SqlConnection con = NorthWindDB.GetConnection();//connection to the data source
            string selectQuery = "SELECT * FROM [Order Details] " + "WHERE OrderID = @OrderID";
            SqlCommand selectCommand = new SqlCommand(selectQuery, con);
            selectCommand.Parameters.AddWithValue("@OrderID", orderID);
            //Console.WriteLine("Attempting OD fetch...");
            try
            {
                con.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();// System.Data.CommandBehavior.SingleRow);
                while (reader.Read())
                {
                   // Console.WriteLine("Building Row...");
                    ordDet = new OrderDetails();
                    ordDet.OrderID = (int)reader["OrderID"];
                    ordDet.ProductID = (int)reader["ProductID"];
                    ordDet.UnitPrice = (decimal)reader["UnitPrice"];
                    ordDet.Quantity = Convert.ToInt32(reader["Quantity"]);
                    ordDet.Discount = Convert.ToDecimal(reader["Discount"]);
                    od.Add(ordDet);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            //Console.WriteLine("SetSize: "+od.Count);
            return od;
        }

        //method to get the total charge for the orderID selected on the datagridview
        public static decimal GetTotalCharge(int orderID)
        {

            SqlConnection con = NorthWindDB.GetConnection();
            string selectStatement = "SELECT sum(UnitPrice*Quantity*(1- Discount)) as totalcharge " +
                                       "FROM [Order Details] " +
                                      "WHERE OrderID = @OrderID";
            SqlCommand selectCommand = new SqlCommand(selectStatement, con);
            selectCommand.Parameters.AddWithValue("@OrderID", orderID);
            try
            {
                con.Open(); // open database connection
                SqlDataReader reader = selectCommand.ExecuteReader(); // execute query
                if (reader.Read()) // read next record while there is one
                {
                    return Convert.ToDecimal(reader["totalcharge"]);
                }
                else
                {
                    return 0m;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close(); //closes connection
            }

        }

    }
}
