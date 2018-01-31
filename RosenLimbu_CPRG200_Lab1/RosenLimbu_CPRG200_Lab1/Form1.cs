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
 * Date: November 21, 2017
 * Description: The purpose of the form box is to determine the cost of kWh used for each customer type (residential, commercial, industrial)
 * When the radio button is clicked the correct rate of the specific customer type will be applied  and a total value will be displayed at the bottom.
 * */

namespace RosenLimbu_CPRG200_Lab1
{
    public partial class Form1 : Form
    {
        //These are the constant variables for the flat fees and the rates for each customer types
        const double resFlat = 6;               //Residential flat fee
        const double resRate = 0.052;           //Residential rate for kwh
        const double commFlat = 60;             //Commercial flat fee
        const double commRate = 0.045;          //Commercial rate for kwh
        const double peakFlat = 76;             //peakhours flat fee
        const double peakRate = .065;           //Peak hours rate for kwh
        const double offPeakFlat = 40;          //off-peakhours flat fee
        const double offPeakRate = .028;        //off-Peak hours rate for kwh
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();    //the close method is called when the Exit button is clicked
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtResidential.Clear();     //the textbox for the residential input will be cleared when the reset button is clicked
            txtTotalBill.Clear();       //the textbox for the Total input will be cleared when the reset button is clicked
            txtCommerce.Clear();        //the textbox for the Commercial input will be cleared when the reset button is clicked
            txtPeak.Clear();            //the textbox for the peak hours input will be cleared when the reset button is clicked
            txtOffPeak.Clear();         //the textbox for the off peak hours input will be cleared when the reset button is clicked

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double Total = 0;

            //The checked property is used indicate which of the checked button is selected
            //Once the checked button has been selected, the validator class is used to check for alphabets and negative fields inside the input
            if (radResidential.Checked)

            {
                if (Validator.IsPresent(txtResidential, "The kWh") &&           //IsPresent function is used to check for empty fields inside the input
                     Validator.IsDouble(txtResidential, "The kWh") &&           //IsDouble function is used to check for double data types inside the input (no strings)
                     Validator.IsNonNegativeDouble(txtResidential, "The kWh"))  //IsNonNegativeDouble function is used to check for inputs that have values less than 0
                {
                    double residentialKWH = Convert.ToDouble(txtResidential.Text);  //the textbox for the residential input is converted to double type
                    Total = residentialCalc(residentialKWH);                       //the method is being called into action by the residential input
                }
            }
            else if (radCommercial.Checked)
            {
                if (Validator.IsPresent(txtCommerce, "The kWh") &&
                     Validator.IsDouble(txtCommerce, "The kWh") &&
                     Validator.IsNonNegativeDouble(txtCommerce, "The kWh"))
                {
                    double CommerceKWH = Convert.ToDouble(txtCommerce.Text);    //the textbox for the commercial input is converted to a double type
                    Total = commercialCalc(CommerceKWH);                       //the commercial_bill method is being called into action by the commercial input
                }
            }
            else if (radIndustrial.Checked)
            {
                if (Validator.IsPresent(txtPeak, "The kWh for peak hours") &&
                    Validator.IsDouble(txtPeak, "The kWh for peak hours") &&
                     Validator.IsNonNegativeDouble(txtPeak, "The kWh for peak hours") &&
                     Validator.IsPresent(txtOffPeak, "The kWh for Off-peak hours") &&
                     Validator.IsDouble(txtOffPeak, "The kWh for Off-peak hours") &&
                     Validator.IsNonNegativeDouble(txtOffPeak, "The kWh for Off-peak hours"))
                {
                    
                    double peakKWH = Convert.ToDouble(txtPeak.Text);                    //the textbox for the peak hours input is converted to a double type
                    double offPeakKWH = Convert.ToDouble(txtOffPeak.Text);              //the textbox for the off-peak hours input is converted to a double type
                    Total = industrial_bill(peakKWH) + industrial_bill1(offPeakKWH);    //The methods are being called into action by both the peak hours input and the off-peak hours input
                }
            }


            txtTotalBill.Text = Total.ToString("c");    //the total is being converted back into a string to be displayed in a currency format
        }

        
        private void radResidential_CheckedChanged(object sender, EventArgs e)
        {
            txtResidential.Visible = true;      //The textbox for the residential customer will be visible when radio button is clicked
            lblKWH.Visible = true;              //The labelbox for the input will be visible when radio button is clicked
            txtCommerce.Visible = false;        //The textbox for the commercial customer will be hidden when radio button is clicked
            txtPeak.Visible = false;            //The textbox for the peak hours input will be hidden when radio button is clicked
            txtOffPeak.Visible = false;         //The textbox for the peak hours input will be hidden when radio button is clicked
            lblPeak.Visible = false;            //The labelbox for the peak hours input will be hidden when radio button is clicked
            lblOffPeak.Visible = false;         //The labelbox for the off-peak hours input will be hidden when radio button is clicked

        }


        private void radCommercial_CheckedChanged(object sender, EventArgs e)
        {
            lblKWH.Visible = true;              
            txtCommerce.Visible = true;         //The textbox for the commercial customer will be visible when radio button is clicked
            txtResidential.Visible = false;     //The textbox for the residential customer will be hidden when radio button is clicked
            txtPeak.Visible = false;            
            txtOffPeak.Visible = false;         
            lblPeak.Visible = false;            
            lblOffPeak.Visible = false;         
        }

        private void radIndustrial_CheckedChanged(object sender, EventArgs e)
        {
            lblKWH.Visible = false;             //The labelbox for theinput will be hidden when radio button is clicked
            txtCommerce.Visible = false;        
            txtResidential.Visible = false;     
            txtPeak.Visible = true;             //The textbox for the Peak hours will be visible when radio button is clicked
            txtOffPeak.Visible = true;          //The textbox for the Off-Peak hours will be visible when radio button is clicked
            lblPeak.Visible = true;             //The labelbox for the peak hours will be visible when radio button is clicked
            lblOffPeak.Visible = true;          //The labelbox for the off-peak hours will be visible when radio button is clicked


        }

        //The method is being used to calculate the bill for the residential customer
        private double residentialCalc(double residentialKWH)
        {
            return (resFlat + (resRate * residentialKWH));

        }

        //The method is being used to calculate the bill for the commercial customer
        private double commercialCalc(double commercialKWH)
        {
            if (commercialKWH <= 1000)
                return (commFlat);
            else
            {
                return (commFlat + (commRate * commercialKWH));
            }
        }

        //The method is being used to calculate the bill for the industrial customer during peak hours 
        private double industrial_bill(double peakKWH)
        {
            if (peakKWH <= 1000)
                return (peakFlat);
            else
            {
                return (peakFlat + (peakKWH * peakRate));
            }
        }

        //The method is being used to calculate the bill for the industrial customer during off-peak hours 
        private double industrial_bill1(double offPeakKWH)
        {
            if (offPeakKWH <= 1000)
                return (offPeakFlat);
            else
            {
                return (offPeakFlat + (offPeakKWH * offPeakRate));
            }
        }


    }
}