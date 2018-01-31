using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Author: Rosen Limbu
Created date: January 6, 2018
Description: This is class in which I connect to the sql server.
*/
namespace Rosen_Limbu_CPRG200_Lab4
{
    public static class NorthWindDB
    {
        public static SqlConnection GetConnection()
        { 
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\northwnd.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection connection = new SqlConnection(connectionString);
        return connection;
        }
    }
}
