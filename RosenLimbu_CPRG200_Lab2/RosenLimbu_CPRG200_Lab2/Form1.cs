using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Author: Rosen Limbu
 * Date: December 21, 2017
 * Description: In this class, I will determine all the functionality of the buttons and also when the form loads and exit
 * */

namespace RosenLimbu_CPRG200_Lab2
{
    public partial class Form1 : Form
    {
        List<Customer> customers = null;

        const double resFlat = 6;               //Residential flat fee
        const double resRate = 0.052;           //Residential rate for kwh
        const double commFlat = 60;             //Commercial flat fee
        const double commRate = 0.045;          //Commercial rate for kwh
        const double peakFlat = 76;             //peakhours flat fee
        const double peakRate = .065;           //Peak hours rate for kwh
        const double offPeakFlat = 40;          //off-peakhours flat fee
        const double offPeakRate = .028;        //off-Peak hours rate for kwh
        const int MAXSiZE = 50;
        string[] names = new string[MAXSiZE];
        int[] accountNo = new int[MAXSiZE];
        double[] amountRes_Comm = new double[MAXSiZE];
        double[] amountPeak = new double[MAXSiZE];
        double[] amountOffPeak = new double[MAXSiZE];
        double totalR = 0;
        double totalI = 0;
        double totalC = 0;
        double totalCharge = 0;
        int count = 1;
        string line;
        decimal sum = 0;

        public Form1()
        {
            InitializeComponent();
        }

        //When the reset button is clicked, the data that is currently inside the textboxes will be cleared 
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAcctNo.Clear();
            txtAcctNo.Focus();
            txtCustName.Clear();
            txtKWH.Clear();
            txtPeakKWH.Clear();
            txtOffPeakKWH.Clear();
            lblKWH.Visible = true;
            txtKWH.Visible = true;
            lblPeak.Visible = false;
            lblOffPeak.Visible = false;
            txtPeakKWH.Visible = false;
            txtOffPeakKWH.Visible = false;
            cmbCustType.SelectedIndex = 0;
        }
        //when the form is loaded
        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnAdd, "Please Add!");
            toolTip1.SetToolTip(btnReset, "Reset!");
            toolTip1.SetToolTip(txtAcctNo, "Account Number");
            try
            {
                customers = CustomerDB.LoadCustomers();//calls on CustomerDB class to load method for reading txt file which had customer data in listdirectory
                displayCustomerInfo();//intialize the method to display the data, if any, inside the list box
            }
            catch
            (Exception ex)
            {
                MessageBox.Show("Error while reading customer data: " + ex.Message);
            }
            cmbCustType.Items.Add("R");
            cmbCustType.Items.Add("C");
            cmbCustType.Items.Add("I");
            cmbCustType.SelectedIndex = 0;
        }

        //when the add button is clicked
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();//an instance of the Customer class is created
            if (cmbCustType.Text == "R")//when the specific combobox selection is clicked
            {
                //all the validation must be passed
                if(Validator.IsPresent(txtAcctNo)&&
                    Validator.isInt32(txtAcctNo)&&
                    Validator.IsPresent(txtCustName)&&
                    Validator.isInt32(txtKWH)&&
                    Validator.IsNonNegativeDouble(txtKWH))
                { 
                    double resKWH = Convert.ToDouble(txtKWH.Text);
                    totalR =totalR + totalRes(resKWH);
                    totalCharge = totalCharge + totalR;
                    txtTotalRes.Text = totalR.ToString("c");
                    c.acctNo= Convert.ToInt32(txtAcctNo.Text);
                    c.Name = txtCustName.Text;
                    c.custType = cmbCustType.Text;
                    c.Amount = Convert.ToDecimal(totalRes(resKWH));
                    customers.Add(c); //adding new customer to the list
                    displayCustomerInfo();//calling the function for the customer data to be added to listbox 
                    count++;//The customer is being added to the listbox
                    txtAcctNo.Focus();
                    txtAcctNo.Clear();
                    txtCustName.Clear();
                    txtKWH.Clear();
                }
            }
            else if (cmbCustType.Text == "C")
            {
                if(Validator.IsPresent(txtAcctNo) &&
                    Validator.isInt32(txtAcctNo) &&
                    Validator.IsPresent(txtCustName) &&
                    Validator.isInt32(txtKWH) &&
                    Validator.IsNonNegativeDouble(txtKWH))
                {
                    double commKWH = Convert.ToDouble(txtKWH.Text);
                    totalC = totalC + totalComm(commKWH);
                    txtTotalComm.Text = totalC.ToString("c");
                    totalCharge = totalCharge + totalC;
                    c.acctNo = Convert.ToInt32(txtAcctNo.Text);
                    c.Name = txtCustName.Text;
                    c.custType = cmbCustType.Text;
                    c.Amount = Convert.ToDecimal(totalComm(commKWH));
                    customers.Add(c);
                    displayCustomerInfo();//calling the function for the customer data to be added to listbox 
                    count++;//The customer is being added to the listbox
                    txtAcctNo.Focus();
                    txtAcctNo.Clear();
                    txtCustName.Clear();
                    txtKWH.Clear();
                    cmbCustType.SelectedIndex = 0;
                }
            }
            else if(cmbCustType.Text == "I")
            {
                if (Validator.IsPresent(txtAcctNo) &&
                    Validator.isInt32(txtAcctNo) &&
                    Validator.IsPresent(txtCustName) &&
                    Validator.isInt32(txtOffPeakKWH) &&
                    Validator.isInt32(txtPeakKWH) &&
                    Validator.IsNonNegativeDouble(txtPeakKWH)&&
                    Validator.IsNonNegativeDouble(txtOffPeakKWH))
                {
                    double indPeakKWH = Convert.ToDouble(txtPeakKWH.Text);
                    double indOffPeakKWH = Convert.ToDouble(txtOffPeakKWH.Text);
                    totalI = totalI + totalIndPeak(indPeakKWH) + totalIndOffPeak(indOffPeakKWH);
                    txtTotalInd.Text = totalI.ToString("c");
                    totalCharge = totalCharge + totalI;
                    c.acctNo = Convert.ToInt32(txtAcctNo.Text);
                    c.Name = txtCustName.Text;
                    c.custType = cmbCustType.Text;
                    c.Amount = Convert.ToDecimal(totalIndPeak(indPeakKWH) + totalIndOffPeak(indOffPeakKWH));
                    customers.Add(c);
                    displayCustomerInfo();//calling the function for the customer data to be added to listbox 
                    count++;//The customer is being added to the listbox
                    txtAcctNo.Focus();
                    txtAcctNo.Clear();
                    txtCustName.Clear();
                    txtPeakKWH.Clear();
                    txtOffPeakKWH.Clear();
                    cmbCustType.SelectedIndex = 0;
                }
            }
           // txtTotalCharge.Text = totalCharge.ToString("c");
        }

        //method to add data to listbox
        private void displayCustomerInfo()
        {
            
            string line;
            lstDirectory.Items.Clear();//must clear the listbox before data is inputted
            lstDirectory.Items.Add("Account Number:\tCustomer Name\tCustomer Type\tAmount");
            int customerCount = 0;
            totalCharge = 0;//reset totalcharge so that it does not duplicate the amount
            totalR = 0; //reset totalR to be 0 so that it does not get picked up in foreach loop when adding new customer
            totalC = 0;
            totalI = 0;
            //foreach loop for each Customer class in customer collection
            foreach (Customer c in customers)
            {
                line = c.acctNo.ToString() + "\t\t" + c.Name + "\t\t" + c.custType + "\t\t" + c.Amount.ToString("c");
                lstDirectory.Items.Add(line);
                txtTotalCust.Text = count.ToString();
                if (c.custType == "R") {totalR = totalR + Convert.ToDouble(c.Amount); }
                if (c.custType == "C") { totalC = totalC + Convert.ToDouble(c.Amount); }
                if (c.custType == "I") { totalI = totalI + Convert.ToDouble(c.Amount); }
                customerCount++;
            }
            txtTotalCust.Text = customerCount.ToString();
            txtTotalRes.Text = totalR.ToString("c");
            txtTotalComm.Text = totalC.ToString("c");
            txtTotalInd.Text = totalI.ToString("c");
            totalCharge = totalR + totalC + totalI;
            txtTotalCharge.Text = totalCharge.ToString("c");
        }

        //method for residential calculations
        private double totalRes(double resKWH)
        {
            return (resFlat + resRate * resKWH);
        }

        //Method for Commercial calculationss
        private double totalComm(double commKWH)
        {
            if (commKWH <= 1000)
                return commFlat;
            else return (commFlat + (commRate * (commKWH-1000)));
        }

        //Method for Peak hours calculations
        private double totalIndPeak(double indPeakKWH)
        {
            if (indPeakKWH <= 1000)
                return peakFlat;
            else return (peakFlat + (peakRate * (indPeakKWH-1000)));
        }

        //Method for Off-Peak hours calculations
        private double totalIndOffPeak(double indOffPeakKWH)
        {
            if (indOffPeakKWH <= 1000)
                return (offPeakFlat);
            else return (offPeakFlat + (offPeakRate * (indOffPeakKWH-1000)));
        }

        //when combobox changes index
        private void cmbCustType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbCustType.SelectedIndex ==0 || cmbCustType.SelectedIndex ==1)
            {
                lblKWH.Visible = true;
                txtKWH.Visible = true;
                lblPeak.Visible = false;
                lblOffPeak.Visible = false;
                txtPeakKWH.Visible = false;
                txtOffPeakKWH.Visible = false;

            }
            else if (cmbCustType.SelectedIndex == 2)
            { 
                lblPeak.Visible = true;
                lblOffPeak.Visible = true;
                txtPeakKWH.Visible = true;
                txtOffPeakKWH.Visible = true;
                txtKWH.Visible = false;
                lblKWH.Visible = false;
            }
        }
        //saves data as the form closes
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                CustomerDB.SaveCustomers(customers);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error while saving the customers: " + ex.GetType() + " - " + ex.Message);
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
        }
    }
}
