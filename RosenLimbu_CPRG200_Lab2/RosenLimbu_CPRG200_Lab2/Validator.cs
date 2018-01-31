using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Author: Rosen Limbu
 * Date: December 21, 2017
 * Description: In this class, I created restrictions for the user when they input information in the textbox
 * */
namespace RosenLimbu_CPRG200_Lab2
{
    public static class Validator
    {
        //check if textbox is empty
        public static bool IsPresent(TextBox tb)
        {
            bool valid = true; //assume the textbox is not empty
            if (tb.Text == "") 
            {
                valid = false;
                MessageBox.Show("Please fill in field");
                tb.Focus();
            }
            return valid;
        }

        //textbox must have int value
        public static bool isInt32(TextBox tb)
        {
            bool valid = true; //assume that textbox has int value
            int value;
            if(!Int32.TryParse(tb.Text, out value))//txtbox does not have int value
            {
                valid = false;
                MessageBox.Show("Please input a whole number");
                tb.Focus();
                tb.SelectAll();
            }
            return valid;
        }

        //textbox must not be less than 0
        public static bool IsNonNegativeDouble(TextBox tb)
        {
            bool valid = true; //assume user has input value greater than 0
            double value;
            if (!Double.TryParse(tb.Text, out value)) //if not a double
            {
                valid = false;
                MessageBox.Show("The KWH must be a number");
                tb.SelectAll();
                tb.Focus();
            }
            else if (value <0)
            {
                valid = false;
                MessageBox.Show("The input value must be equal to or greater than zero");
                tb.SelectAll();
                tb.Focus(); 
            }
            return valid;
        }
    }
}
