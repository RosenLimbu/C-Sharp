using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RosenLimbu_CPRG200_Lab1
{
    // repository for validating methods
    public static class Validator
    {
        // check if text box not empty
        public static bool IsPresent(TextBox tb, string name)
        {
            bool valid = true; // innocent until proven guilty
            if(tb.Text == "") // bad
            {
                valid = false;
                MessageBox.Show(name + " is required","Please Review");
                tb.Focus();
            }
            return valid;
        }

        // check if textbox has int value in it
        public static bool IsDouble(TextBox tb, string name)
        {
            bool valid = true; // presumme valid
            double value;
            if(!Double.TryParse(tb.Text, out value)) // bad news
            {
                valid = false;
                MessageBox.Show(name + " must be a number", "Please Review");
                tb.SelectAll();
                tb.Focus();
            }
            return valid;
        }

        // check if textbox has non-negative int value
        public static bool IsNonNegativeDouble(TextBox tb, string name)
        {
            bool valid = true;
            double value;

            if (!Double.TryParse(tb.Text, out value)) // bad news
            {
                valid = false;
                MessageBox.Show(name + " must be  a number", "Please Review");
                tb.SelectAll();
                tb.Focus();
            }
            else if (value < 0) // bad
            {
                valid = false;
                MessageBox.Show(name + " must be a equal to or greater than zero");
                tb.SelectAll();
                tb.Focus();
            }
            return valid;
        }
        
    }
}
