using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Author: Rosen Limbu
 * Date: December 21, 2017
 * Description: In this class, I created a method to read customer data and a second method to write the text file. 
 * Both these methods are using the data which is pulled from the List Customer class
 * */
namespace RosenLimbu_CPRG200_Lab2
{
    public static class CustomerDB
    {
        const string path = "listDirectory.txt";//a text file will be created and will be located inside the Debug folder  

        public static List<Customer> LoadCustomers()//the method will use the data from the list of Customer class 
        {
            List<Customer> customers = new List<Customer>();//an instance of the List Customer class is created 
            FileStream fs = null;
            StreamReader sr = null;
            string line;//next line for file
            string[] parts;//used for splitting the line

            try
            {
                //opens exisiting files, otherwise creates new text file
                fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
                sr = new StreamReader(fs);

                while (!sr.EndOfStream) //While there is still data to read
                {
                    line = sr.ReadLine();
                    parts = line.Split(','); //split on the commas
                    Customer c = new Customer(Convert.ToInt32(parts[0]), parts[1], parts[2].Trim(), Convert.ToDecimal(parts[3]));
                    customers.Add(c); 
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sr != null) sr.Close(); //close the file if opend
            }
            return customers;
        }
        //This method is used to save the data in the text file
        public static void SaveCustomers(List<Customer> customers)
        {
            FileStream fs;
            StreamWriter sw = null;
            string line;
            try
            {
                //open the file for writing
                fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(fs);
                //write data
                foreach (Customer c in customers)
                {
                    line = c.acctNo.ToString() + ", ";
                    line += c.Name + ", ";
                    line += c.custType + ", ";
                    line = line + c.Amount.ToString();
                    sw.WriteLine(line);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sw != null) sw.Close(); //close the streamwriter when there is no more data to write
            }
        }
    }
}
