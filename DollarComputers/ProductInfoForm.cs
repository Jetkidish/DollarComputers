using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarComputers
{
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
            this.ProductSelectionForm_Load();
        }
        /// <summary>
        /// ProgramSelectionForm_Load event handler
        /// This populates the textboxes, and checks the flag status
        /// </summary>
        private void ProductSelectionForm_Load()
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
            ProductIDTextBox.Text = Program.selection[0];
            ConditionTextBox.Text = Program.selection[14];
            CostTextBox.Text = Program.selection[1];
            while (Program.flag == 1)
            {
                Program.flag = 0;
                openToolStripMenuItem.PerformClick(); 
            }

        }
        /// <summary>
        /// NextButton_Click Event handler
        /// this handles the next button, and shows the next form if clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new DollarComputers.OrderForm();
            orderForm.Show();
            this.Hide();
        }
        /// <summary>
        /// selecAnotherProductToolStripMenuItem_Click event handler
        /// this will take the user back to the selection form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selecAnotherProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectForm selectForm = new DollarComputers.SelectForm();
            selectForm.Show();
            this.Hide();
        }
        /// <summary>
        /// exitToolStripMenuItem_Click event handler
        /// This exits the app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// openToolStripMenuItemClick
        /// This will open a dialog box allowing the user to open a saved order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult responseDialogResult;
            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            responseDialogResult = openFileDialog.ShowDialog();
            if (responseDialogResult != DialogResult.Cancel)
            {
                StreamReader reader = new StreamReader(openFileDialog.FileName);

                while (reader.Peek() != -1)
                {
                    for (int counter = 0; counter < 31; counter++)
                    {
                        Program.selection[counter] = reader.ReadLine();
                    }
                    this.ProductSelectionForm_Load();
                }

                reader.Close();
            }
        }
        /// <summary>
        /// saveToolStripMenuItem_Click
        /// This will allow the user to save their current order details in a text file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult saveResponseDialogResult;
            saveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            saveResponseDialogResult = saveFileDialog.ShowDialog();
            if (saveResponseDialogResult != DialogResult.Cancel)
            {
                StreamWriter writer = new StreamWriter(saveFileDialog.FileName);

                for (int counter = 0; counter < 31; counter++)
                {
                    writer.WriteLine(Program.selection[counter]);
                }

                writer.Close();
            }
        }
    }
}
