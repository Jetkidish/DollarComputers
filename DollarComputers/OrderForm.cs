using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarComputers
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
            OrderForm_Load();
        }
        /// <summary>
        /// OrderForm_Load method
        /// This will load all the info into the correct textboxes, it also calls the calculate total method
        /// </summary>
        private void OrderForm_Load()
        {
            ModelTextBox.Text = Program.selection[3];
            ManufacturerTextBox.Text = Program.selection[2];
            OSTextBox.Text = Program.selection[15];
            PlatformTextBox.Text = Program.selection[16];
            WebCamTextBox.Text = Program.selection[30];
            GPUTypeTextBox.Text = Program.selection[19];
            HDDTextBox.Text = Program.selection[17];
            CPUModelTextBox.Text = Program.selection[11];
            CPUSpeedTextBox.Text = Program.selection[12];
            LCDSizeTextBox.Text = Program.selection[7];
            CPUTypeTextBox.Text = Program.selection[10];
            CPUBrandTextBox.Text = Program.selection[9];
            MemoryTextBox.Text = Program.selection[4];
            ConditionTextBox.Text = Program.selection[14];
            CostTextBox.Text = Program.selection[1];
            CalculateTotal();
        }
        /// <summary>
        /// abouttoolstripmenuitem_click event handler
        /// this will show the about box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Step 1 - instantiate an object of the AboutBox form
            AboutBox aboutBox = new AboutBox();

            // Step 2 - use the ShowDialog method of the aboutbox
            aboutBox.ShowDialog();
        }
        /// <summary>
        /// backtoolstripmenuitem_click event handler
        /// this will show the previous form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductInfoForm infoForm = new DollarComputers.ProductInfoForm();
            infoForm.Show();
            this.Hide();
        }
        /// <summary>
        /// exittoolstripmenuitem_click
        /// this will exit the app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// finishbutton_click
        /// this will show a message box, then exit the app when the user clicks ok
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void FinishButton_Click(object sender, EventArgs e)
        {
           if  (MessageBox.Show("Thank your for your business!" + Environment.NewLine +  "Your order will be processed in 7-10 business days", "Thank You!", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        /// <summary>
        /// calculatetotal method
        /// this calculates the sales tax and the total
        /// </summary>
        private void CalculateTotal()
        {
            double _Cost;
            double _SalesTax;
            double _Total;

            _Cost = double.Parse(CostTextBox.Text, System.Globalization.NumberStyles.Currency);
            _SalesTax = _Cost * 0.13;
            _Total = _Cost + _SalesTax;
            SalesTaxTextBox.Text = _SalesTax.ToString("C2");
            TotalTextBox.Text = _Total.ToString("C2");
        }
        /// <summary>
        /// printtoolstripmenuitem_click
        /// this shows a message box that tells the user their order was printer. it lies though.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing!", "Sent to printer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
