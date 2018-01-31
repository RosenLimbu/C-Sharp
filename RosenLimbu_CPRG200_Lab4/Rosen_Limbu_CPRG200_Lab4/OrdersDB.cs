using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
Author: Rosen Limbu
Created date: January 8, 2018
Description: This is the class where I will define the methods which will then be used to pass it back to the form for display.
*/

namespace Rosen_Limbu_CPRG200_Lab4
{
    public static class OrdersDB
    {
        //This is a method which gets the orderID by connecting to the SQL Server 
        public static Orders getOrders(int orderID)
        {
           
            Orders order = null;
            SqlConnection con = NorthWindDB.GetConnection(); //gets connections from NortwindDB class
            string selectQuery = "SELECT OrderID, CustomerID, OrderDate, RequiredDate, ShippedDate " +
                                 "FROM Orders " +
                                 "WHERE OrderID = @OrderID";
            SqlCommand selectCommand = new SqlCommand(selectQuery, con);
            selectCommand.Parameters.AddWithValue("@OrderID", orderID);
            try
            {
                con.Open();//open the connection
                SqlDataReader reader = selectCommand.ExecuteReader(System.Data.CommandBehavior.SingleRow);
               if  (reader.Read()) //reads data
                {
                    order = new Orders();//create a new order object
                    order.OrderID = (int)reader["OrderID"];
                    order.CustomerID = reader["CustomerID"].ToString();
                    if (DBNull.Value.Equals((DateTime) reader["OrderDate"]))
                        { order.OrderDate = null; } //giving a null value
                    else
                    { order.OrderDate = (DateTime)reader["OrderDate"];}
                    if(DBNull.Value.Equals(reader["RequiredDate"]))
                    { order.RequiredDate = null; }
                    else
                    { order.RequiredDate = (DateTime)reader["RequiredDate"]; }
                    if(DBNull.Value.Equals(reader["ShippedDate"]))
                    { order.ShippedDate = null; }
                    else
                { order.ShippedDate = (DateTime)reader["ShippedDate"]; }
                    //MessageBox.Show(reader["CustomerID"].ToString());
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();//close the connection
            }
           
            return order;
        }

        //this is a boolean to update order and is passing 3 arguments
        public static bool UpdateOrder(int OrderID, DateTime oldShippedDate, DateTime? newShippedDate)
        {
            SqlConnection con = NorthWindDB.GetConnection();
            string updateStmt = "UPDATE Orders SET " +
                                       "ShippedDate = @newShippedDate " +
                                       "WHERE OrderID = @OrderID " +
                                       "AND ShippedDate = @oldShippedDate";
            //string updateStmt = "UPDATE Orders SET " +
            //                    "ShippedDate = @NewShippedDate " +
            //                    "WHERE ShippedDate = @oldShippedDate is null and @OldShippedDate is null " +
            //                    " AND OrderID = @OrderID";
            SqlCommand updateCommand = new SqlCommand(updateStmt, con);
            //MessageBox.Show(oldShippedDate.ToString() + ":" + newShippedDate.ToString());
            updateCommand.Parameters.AddWithValue("@newShippedDate", newShippedDate);
            updateCommand.Parameters.AddWithValue("@OrderID", OrderID);
            updateCommand.Parameters.AddWithValue("@oldShippedDate", oldShippedDate);
            try
            {
                con.Open();
                int count = updateCommand.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                    return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
