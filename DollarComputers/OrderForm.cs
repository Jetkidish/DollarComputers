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

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Step 1 - instantiate an object of the AboutBox form
           // AboutBox aboutBox = new AboutBox();

            // Step 2 - use the ShowDialog method of the aboutbox
            //aboutBox.ShowDialog();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductInfoForm infoForm = new DollarComputers.ProductInfoForm();
            infoForm.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {

        }
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
    }
}
