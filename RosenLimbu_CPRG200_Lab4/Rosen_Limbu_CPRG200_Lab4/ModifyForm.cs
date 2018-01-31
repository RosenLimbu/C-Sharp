using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
Author: Rosen Limbu
Created date: January 8, 2018
Description: This is the modify form which gets the var from the main form and receives the data from the main form for display
*/
namespace Rosen_Limbu_CPRG200_Lab4
{
    public partial class ModifyForm : Form
    {
        int OrderID; //declare to be used in current class for arguments coming from main form
        string CustID; //declare to be used in current class for arguments coming from main form
        DateTime OrderDATE; //declare to be used in current class for arguments coming from main form
        DateTime ReqDATE; //declare to be used in current class for arguments coming from main form
        DateTime ShippedDATE; //declare to be used in current class for arguments coming from main form
        DateTime oldShippedDate;

        public ModifyForm(int orderid, string custid, DateTime orderdate, DateTime reqdate, DateTime shippeddate) //receives the argument from Mainform
        {
            InitializeComponent();

            OrderID = orderid; //loading up in current class
            CustID = custid; //loading up in current class
            OrderDATE = orderdate; //loading up in current class
            ReqDATE = reqdate; //loading up in current class
            ShippedDATE = shippeddate; //loading up in current class

            oldShippedDate = ShippedDATE;
        }

        public Orders orders;


        //when form loads, the texbox gets populated
        private void AddModifyForm_Load(object sender, EventArgs e)
        {
            //load up from Mainform after passing to current class
            this.txtOrderID.Text = OrderID.ToString(); //this indicates this form
            this.txtCustID.Text = CustID.ToString();
            this.txtOrderDate.Text = OrderDATE.ToShortDateString();
            this.txtReqDate.Text = ReqDATE.ToShortDateString();
            this.txtShippedDate.Text = ShippedDATE.ToShortDateString();
            txtShippedDate.Select();

        }

        //when cancel button is click, the form closes
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //when update button is clicked, the data updates the database
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DateTime? newShippedDate;
            if (txtShippedDate.Text == "")
            {
                newShippedDate = null;
            
                try { 
                    if (newShippedDate > OrderDATE && newShippedDate < ReqDATE || newShippedDate == null) //validation to ensure the newshippedDate is between orderDate and requiredDate or is null
                    { OrdersDB.UpdateOrder(OrderID, oldShippedDate, newShippedDate);
                        this.DialogResult = DialogResult.OK; }//sends back response 
                    else
                    {
                        MessageBox.Show("You have provided the wrong Shipped Date");
                        this.DialogResult = DialogResult.Retry;
                    }
                }
                catch(Exception ex)
                { MessageBox.Show(ex.Message, ex.GetType().ToString()); }
            }
        }
    }
}

