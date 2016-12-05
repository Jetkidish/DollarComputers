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
        /// <summary>
        /// SelectForm_Load event handler
        /// This will load and fill the table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);


        }
        /// <summary>
        /// CancelButton_Click event handler
        /// This exits the app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// ProductDataGridView_CellContentClick event handler
        /// This handles a user click in the box, and also enables the next button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

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
        /// <summary>
        /// NExtButton_Click event handler
        /// this will show the next form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            ProductInfoForm productInfoForm = new DollarComputers.ProductInfoForm();
            productInfoForm.Show();
            this.Hide();
        }
    }
}
