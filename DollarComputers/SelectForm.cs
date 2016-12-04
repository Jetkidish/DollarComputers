using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarComputers
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);


        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProductDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in ProductDataGridView.SelectedRows)
            {
                for (int c = 0; c < 31; c++){
                    Program.selection[c] = row.Cells[c].Value.ToString();
                }
                SelectionTextBox.Text = Program.selection[2] + " " + Program.selection[3] + " Priced at: " + Program.selection[1];
                
            }
            NextButton.Enabled = true;

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            ProductInfoForm productInfoForm = new DollarComputers.ProductInfoForm();
            productInfoForm.Show();
            this.Hide();
        }
    }
}
