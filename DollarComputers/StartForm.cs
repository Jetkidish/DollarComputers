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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// NewOrderButton_Click
        /// This will show the next form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            SelectForm selectForm = new DollarComputers.SelectForm();
            selectForm.Show();
            this.Hide();
        }
        /// <summary>
        /// OpenSavedOrderButton_Click
        /// This will set the program flag and open the product info form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenSavedOrderButton_Click(object sender, EventArgs e)
        {
            Program.flag = 1;
            ProductInfoForm productInfoForm = new DollarComputers.ProductInfoForm();
            productInfoForm.Show();
            this.Hide();
        }
        /// <summary>
        /// exitbutton_click event handler
        /// This exits the app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
