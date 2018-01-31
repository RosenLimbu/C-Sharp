using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
Author: Rosen Limbu
Created date: January 7, 2018
Description: This is the main form which displays the orders and order details which are being pulled from the DB of both tables
*/
namespace Rosen_Limbu_CPRG200_Lab4
{
    public partial class MainForm : Form
    {
        public Orders order; //placeholder to be used in the current class
        public MainForm()
        {
            InitializeComponent();
        }
        private Orders orders;
        public int orderID;
        public Orders ord; //to be used for display in text
        public List<OrderDetails> orderDet;// = new List<OrderDetails>();
        public OrderDetails ordDet; //to be use for display in order details text

        private void btnGetOrder_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(txtOrderID) && Validator.isInt32(txtOrderID)) //run validation
            {

                //MessageBox.Show("testing");
                int orderID = Convert.ToInt32(txtOrderID.Text); //putting OrderID textbox into OrderID
                this.GetOrder(orderID);
                //ord= OrdersDB.getOrders(orderID);
                if (order == null)
                {
                    MessageBox.Show("The Order ID is invalid", "Order not found");
                    this.ClearControls();
                }
                else
                {
                    orderDet = OrderDetailsDB.getOrderDetails(orderID);
                    decimal totalcharge = OrderDetailsDB.GetTotalCharge(orderID);
                    txtOrderTotal.Text = totalcharge.ToString("c");
                    this.DisplayOrder();
                    this.DisplayOrderDetails(orderID);
                }
            }
        }

        //use this constructor to get the getOrders method from the DB class and catch exception
        private void GetOrder(int orderID)
        {
            try
            {
                order = OrdersDB.getOrders(orderID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        //This will be called to display order
        private void DisplayOrder()
        {
            //txtOrderID.Text = ord.OrderID.ToString();
            txtCustID.Text = order.CustomerID;
            if(order.OrderDate == null) //if there is null on the dates, the shipped date should say N/A
            {txtOrdDate.Text = "N/A"; }
            else
            { txtOrdDate.Text = Convert.ToDateTime(order.OrderDate).ToShortDateString(); }
            if(order.RequiredDate == null)
            { txtReqDate.Text = "N/A"; }
            else
            { txtReqDate.Text = Convert.ToDateTime(order.RequiredDate).ToShortDateString(); }
            if (order.ShippedDate == null)
            { txtShippedDate.Text = "N/A"; }
            else
            { txtShippedDate.Text = Convert.ToDateTime(order.ShippedDate).ToShortDateString(); }
        }

        //this will be called to display order details in gridview
        private void DisplayOrderDetails(int orderID)
        {
            dgvOrderDetails.DataSource = orderDet;
            btnModify.Enabled = true;
        }
        //constructor to be called to clear textbox forms
        private void ClearControls()
        {
            txtOrderID.Text = "";
            txtCustID.Text = "";
            txtOrdDate.Text = "";
            txtReqDate.Text = "";
            txtShippedDate.Text = "";
            btnModify.Enabled = false;
            txtOrderID.Select();
            
        }

        //resets textbox
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCustID.Clear();
            txtOrderID.Clear();
            txtOrdDate.Clear();
            txtReqDate.Clear();
            txtShippedDate.Clear();
            txtOrderID.Select();
            btnModify.Enabled = false;
        }

        //when modify button is clicked, an instance of the modify form object should be created 
        private void btnModify_Click(object sender, EventArgs e)
        {
            
            int orderid = Convert.ToInt32(txtOrderID.Text); //loading up data into orderid which is coming from txtbox
            string custid = txtCustID.Text; //loading up data into custid which is coming from txtbox
            DateTime orderdate = Convert.ToDateTime(txtOrdDate.Text); //loading up data into local var  which is coming from txtbox
            DateTime reqdate = Convert.ToDateTime(txtReqDate.Text); //loading up data into local var which is coming from txtbox
            DateTime shippeddate = Convert.ToDateTime(txtShippedDate.Text); //loading up data into local var which is coming from txtbox
            
            ModifyForm updateForm = new ModifyForm(orderid, custid, orderdate, reqdate, shippeddate);//new object is created and is passing argument to Modify form
            updateForm.orders = orders; //set the public orders field to the current orders object

            DialogResult result = updateForm.ShowDialog();//starts the dialog
            if (result == DialogResult.OK)//receives dialog response
            {
                this.DisplayOrder();
            }
        }

        //closes the form when clicked
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //when loading 
        private void MainForm_Load(object sender, EventArgs e)
        {
            btnModify.Enabled = false;
        }
    }
}
