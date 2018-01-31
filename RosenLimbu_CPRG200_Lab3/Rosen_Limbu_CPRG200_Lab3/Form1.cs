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

namespace Rosen_Limbu_CPRG200_Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwndDataSet);

        }

        private void productsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            try
            {
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwndDataSet);
            }

            catch (SqlException ex)
            {
                MessageBox.Show("Database error #" + ex.Number + ":\n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Another error: " + ex.GetType().ToString() + ":\n" + ex.Message, "Save Error");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
            // TODO: This line of code loads data into the 'northwndDataSet.Order_Details' table. You can move, or remove it, as needed.
            this.order_DetailsTableAdapter.Fill(this.northwndDataSet.Order_Details);
            // TODO: This line of code loads data into the 'northwndDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.northwndDataSet.Categories);
            // TODO: This line of code loads data into the 'northwndDataSet.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.northwndDataSet.Suppliers);
            // TODO: This line of code loads data into the 'northwndDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.northwndDataSet.Products);
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Database error #" + ex.Number + ":\n" + ex.Message);
            }
        }

        private void getIDByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
//                this.order_DetailsTableAdapter.GetIDBy(this.northwndDataSet.Order_Details, ((int)(System.Convert.ChangeType(productIDToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
