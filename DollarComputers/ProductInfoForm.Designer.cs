namespace DollarComputers
{
    partial class ProductInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductInfoForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selecAnotherProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductIDLabel = new System.Windows.Forms.Label();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.ProductInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.ManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.OSTextBox = new System.Windows.Forms.TextBox();
            this.PlatformTextBox = new System.Windows.Forms.TextBox();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.OSLabel = new System.Windows.Forms.Label();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.TechSpecsGroupBox = new System.Windows.Forms.GroupBox();
            this.WebCamTextBox = new System.Windows.Forms.TextBox();
            this.GPUTypeTextBox = new System.Windows.Forms.TextBox();
            this.HDDTextBox = new System.Windows.Forms.TextBox();
            this.CPUModelTextBox = new System.Windows.Forms.TextBox();
            this.CPUSpeedTextBox = new System.Windows.Forms.TextBox();
            this.LCDSizeTextBox = new System.Windows.Forms.TextBox();
            this.CPUTypeTextBox = new System.Windows.Forms.TextBox();
            this.CPUBrandTextBox = new System.Windows.Forms.TextBox();
            this.MemoryTextBox = new System.Windows.Forms.TextBox();
            this.WebCamLabel = new System.Windows.Forms.Label();
            this.CPUModelLabel = new System.Windows.Forms.Label();
            this.CPUTypeLabel = new System.Windows.Forms.Label();
            this.GPUTypeLabel = new System.Windows.Forms.Label();
            this.CPUSpeedLabel = new System.Windows.Forms.Label();
            this.CPUBrandLabel = new System.Windows.Forms.Label();
            this.HDDLabel = new System.Windows.Forms.Label();
            this.LCDSizeLabel = new System.Windows.Forms.Label();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.ClickNextLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.ProductIDTextBox = new System.Windows.Forms.TextBox();
            this.ConditionTextBox = new System.Windows.Forms.TextBox();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.ProductInfoGroupBox.SuspendLayout();
            this.TechSpecsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(870, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selecAnotherProductToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // selecAnotherProductToolStripMenuItem
            // 
            this.selecAnotherProductToolStripMenuItem.Name = "selecAnotherProductToolStripMenuItem";
            this.selecAnotherProductToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.selecAnotherProductToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.selecAnotherProductToolStripMenuItem.Text = "Select Another Product";
            this.selecAnotherProductToolStripMenuItem.Click += new System.EventHandler(this.selecAnotherProductToolStripMenuItem_Click);
            // 
            // ProductIDLabel
            // 
            this.ProductIDLabel.AutoSize = true;
            this.ProductIDLabel.Location = new System.Drawing.Point(33, 47);
            this.ProductIDLabel.Name = "ProductIDLabel";
            this.ProductIDLabel.Size = new System.Drawing.Size(58, 13);
            this.ProductIDLabel.TabIndex = 1;
            this.ProductIDLabel.Text = "Product ID";
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Location = new System.Drawing.Point(211, 47);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(51, 13);
            this.ConditionLabel.TabIndex = 2;
            this.ConditionLabel.Text = "Condition";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(388, 47);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(28, 13);
            this.CostLabel.TabIndex = 3;
            this.CostLabel.Text = "Cost";
            // 
            // ProductInfoGroupBox
            // 
            this.ProductInfoGroupBox.Controls.Add(this.ModelTextBox);
            this.ProductInfoGroupBox.Controls.Add(this.ManufacturerTextBox);
            this.ProductInfoGroupBox.Controls.Add(this.OSTextBox);
            this.ProductInfoGroupBox.Controls.Add(this.PlatformTextBox);
            this.ProductInfoGroupBox.Controls.Add(this.ModelLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ManufacturerLabel);
            this.ProductInfoGroupBox.Controls.Add(this.OSLabel);
            this.ProductInfoGroupBox.Controls.Add(this.PlatformLabel);
            this.ProductInfoGroupBox.Location = new System.Drawing.Point(12, 74);
            this.ProductInfoGroupBox.Name = "ProductInfoGroupBox";
            this.ProductInfoGroupBox.Size = new System.Drawing.Size(838, 103);
            this.ProductInfoGroupBox.TabIndex = 4;
            this.ProductInfoGroupBox.TabStop = false;
            this.ProductInfoGroupBox.Text = "Product Info";
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Location = new System.Drawing.Point(363, 63);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.ReadOnly = true;
            this.ModelTextBox.Size = new System.Drawing.Size(469, 20);
            this.ModelTextBox.TabIndex = 7;
            // 
            // ManufacturerTextBox
            // 
            this.ManufacturerTextBox.Location = new System.Drawing.Point(101, 63);
            this.ManufacturerTextBox.Name = "ManufacturerTextBox";
            this.ManufacturerTextBox.ReadOnly = true;
            this.ManufacturerTextBox.Size = new System.Drawing.Size(169, 20);
            this.ManufacturerTextBox.TabIndex = 6;
            // 
            // OSTextBox
            // 
            this.OSTextBox.Location = new System.Drawing.Point(363, 32);
            this.OSTextBox.Name = "OSTextBox";
            this.OSTextBox.ReadOnly = true;
            this.OSTextBox.Size = new System.Drawing.Size(469, 20);
            this.OSTextBox.TabIndex = 5;
            // 
            // PlatformTextBox
            // 
            this.PlatformTextBox.Location = new System.Drawing.Point(101, 32);
            this.PlatformTextBox.Name = "PlatformTextBox";
            this.PlatformTextBox.ReadOnly = true;
            this.PlatformTextBox.Size = new System.Drawing.Size(169, 20);
            this.PlatformTextBox.TabIndex = 4;
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(321, 66);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(36, 13);
            this.ModelLabel.TabIndex = 3;
            this.ModelLabel.Text = "Model";
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Location = new System.Drawing.Point(25, 66);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(70, 13);
            this.ManufacturerLabel.TabIndex = 2;
            this.ManufacturerLabel.Text = "Manufacturer";
            // 
            // OSLabel
            // 
            this.OSLabel.AutoSize = true;
            this.OSLabel.Location = new System.Drawing.Point(335, 35);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(22, 13);
            this.OSLabel.TabIndex = 1;
            this.OSLabel.Text = "OS";
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.AutoSize = true;
            this.PlatformLabel.Location = new System.Drawing.Point(50, 35);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(45, 13);
            this.PlatformLabel.TabIndex = 0;
            this.PlatformLabel.Text = "Platform";
            // 
            // TechSpecsGroupBox
            // 
            this.TechSpecsGroupBox.Controls.Add(this.WebCamTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.GPUTypeTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.HDDTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.CPUModelTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.CPUSpeedTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.LCDSizeTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.CPUTypeTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.CPUBrandTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.MemoryTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.WebCamLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUModelLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUTypeLabel);
            this.TechSpecsGroupBox.Controls.Add(this.GPUTypeLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUSpeedLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUBrandLabel);
            this.TechSpecsGroupBox.Controls.Add(this.HDDLabel);
            this.TechSpecsGroupBox.Controls.Add(this.LCDSizeLabel);
            this.TechSpecsGroupBox.Controls.Add(this.MemoryLabel);
            this.TechSpecsGroupBox.Location = new System.Drawing.Point(12, 183);
            this.TechSpecsGroupBox.Name = "TechSpecsGroupBox";
            this.TechSpecsGroupBox.Size = new System.Drawing.Size(838, 100);
            this.TechSpecsGroupBox.TabIndex = 5;
            this.TechSpecsGroupBox.TabStop = false;
            this.TechSpecsGroupBox.Text = "Tech Specs";
            // 
            // WebCamTextBox
            // 
            this.WebCamTextBox.Location = new System.Drawing.Point(444, 64);
            this.WebCamTextBox.Name = "WebCamTextBox";
            this.WebCamTextBox.ReadOnly = true;
            this.WebCamTextBox.Size = new System.Drawing.Size(306, 20);
            this.WebCamTextBox.TabIndex = 17;
            // 
            // GPUTypeTextBox
            // 
            this.GPUTypeTextBox.Location = new System.Drawing.Point(444, 40);
            this.GPUTypeTextBox.Name = "GPUTypeTextBox";
            this.GPUTypeTextBox.ReadOnly = true;
            this.GPUTypeTextBox.Size = new System.Drawing.Size(306, 20);
            this.GPUTypeTextBox.TabIndex = 16;
            // 
            // HDDTextBox
            // 
            this.HDDTextBox.Location = new System.Drawing.Point(444, 17);
            this.HDDTextBox.Name = "HDDTextBox";
            this.HDDTextBox.ReadOnly = true;
            this.HDDTextBox.Size = new System.Drawing.Size(306, 20);
            this.HDDTextBox.TabIndex = 15;
            // 
            // CPUModelTextBox
            // 
            this.CPUModelTextBox.Location = new System.Drawing.Point(276, 64);
            this.CPUModelTextBox.Name = "CPUModelTextBox";
            this.CPUModelTextBox.ReadOnly = true;
            this.CPUModelTextBox.Size = new System.Drawing.Size(100, 20);
            this.CPUModelTextBox.TabIndex = 14;
            // 
            // CPUSpeedTextBox
            // 
            this.CPUSpeedTextBox.Location = new System.Drawing.Point(276, 40);
            this.CPUSpeedTextBox.Name = "CPUSpeedTextBox";
            this.CPUSpeedTextBox.ReadOnly = true;
            this.CPUSpeedTextBox.Size = new System.Drawing.Size(100, 20);
            this.CPUSpeedTextBox.TabIndex = 13;
            // 
            // LCDSizeTextBox
            // 
            this.LCDSizeTextBox.Location = new System.Drawing.Point(276, 17);
            this.LCDSizeTextBox.Name = "LCDSizeTextBox";
            this.LCDSizeTextBox.ReadOnly = true;
            this.LCDSizeTextBox.Size = new System.Drawing.Size(100, 20);
            this.LCDSizeTextBox.TabIndex = 12;
            // 
            // CPUTypeTextBox
            // 
            this.CPUTypeTextBox.Location = new System.Drawing.Point(101, 64);
            this.CPUTypeTextBox.Name = "CPUTypeTextBox";
            this.CPUTypeTextBox.ReadOnly = true;
            this.CPUTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.CPUTypeTextBox.TabIndex = 11;
            // 
            // CPUBrandTextBox
            // 
            this.CPUBrandTextBox.Location = new System.Drawing.Point(101, 40);
            this.CPUBrandTextBox.Name = "CPUBrandTextBox";
            this.CPUBrandTextBox.ReadOnly = true;
            this.CPUBrandTextBox.Size = new System.Drawing.Size(100, 20);
            this.CPUBrandTextBox.TabIndex = 10;
            // 
            // MemoryTextBox
            // 
            this.MemoryTextBox.Location = new System.Drawing.Point(101, 17);
            this.MemoryTextBox.Name = "MemoryTextBox";
            this.MemoryTextBox.ReadOnly = true;
            this.MemoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.MemoryTextBox.TabIndex = 9;
            // 
            // WebCamLabel
            // 
            this.WebCamLabel.AutoSize = true;
            this.WebCamLabel.Location = new System.Drawing.Point(384, 67);
            this.WebCamLabel.Name = "WebCamLabel";
            this.WebCamLabel.Size = new System.Drawing.Size(54, 13);
            this.WebCamLabel.TabIndex = 8;
            this.WebCamLabel.Text = "Web Cam";
            // 
            // CPUModelLabel
            // 
            this.CPUModelLabel.AutoSize = true;
            this.CPUModelLabel.Location = new System.Drawing.Point(209, 67);
            this.CPUModelLabel.Name = "CPUModelLabel";
            this.CPUModelLabel.Size = new System.Drawing.Size(61, 13);
            this.CPUModelLabel.TabIndex = 7;
            this.CPUModelLabel.Text = "CPU Model";
            // 
            // CPUTypeLabel
            // 
            this.CPUTypeLabel.AutoSize = true;
            this.CPUTypeLabel.Location = new System.Drawing.Point(39, 67);
            this.CPUTypeLabel.Name = "CPUTypeLabel";
            this.CPUTypeLabel.Size = new System.Drawing.Size(56, 13);
            this.CPUTypeLabel.TabIndex = 6;
            this.CPUTypeLabel.Text = "CPU Type";
            // 
            // GPUTypeLabel
            // 
            this.GPUTypeLabel.AutoSize = true;
            this.GPUTypeLabel.Location = new System.Drawing.Point(381, 43);
            this.GPUTypeLabel.Name = "GPUTypeLabel";
            this.GPUTypeLabel.Size = new System.Drawing.Size(57, 13);
            this.GPUTypeLabel.TabIndex = 5;
            this.GPUTypeLabel.Text = "GPU Type";
            // 
            // CPUSpeedLabel
            // 
            this.CPUSpeedLabel.AutoSize = true;
            this.CPUSpeedLabel.Location = new System.Drawing.Point(207, 43);
            this.CPUSpeedLabel.Name = "CPUSpeedLabel";
            this.CPUSpeedLabel.Size = new System.Drawing.Size(63, 13);
            this.CPUSpeedLabel.TabIndex = 4;
            this.CPUSpeedLabel.Text = "CPU Speed";
            // 
            // CPUBrandLabel
            // 
            this.CPUBrandLabel.AutoSize = true;
            this.CPUBrandLabel.Location = new System.Drawing.Point(35, 43);
            this.CPUBrandLabel.Name = "CPUBrandLabel";
            this.CPUBrandLabel.Size = new System.Drawing.Size(60, 13);
            this.CPUBrandLabel.TabIndex = 3;
            this.CPUBrandLabel.Text = "CPU Brand";
            // 
            // HDDLabel
            // 
            this.HDDLabel.AutoSize = true;
            this.HDDLabel.Location = new System.Drawing.Point(407, 22);
            this.HDDLabel.Name = "HDDLabel";
            this.HDDLabel.Size = new System.Drawing.Size(31, 13);
            this.HDDLabel.TabIndex = 2;
            this.HDDLabel.Text = "HDD";
            // 
            // LCDSizeLabel
            // 
            this.LCDSizeLabel.AutoSize = true;
            this.LCDSizeLabel.Location = new System.Drawing.Point(219, 22);
            this.LCDSizeLabel.Name = "LCDSizeLabel";
            this.LCDSizeLabel.Size = new System.Drawing.Size(51, 13);
            this.LCDSizeLabel.TabIndex = 1;
            this.LCDSizeLabel.Text = "LCD Size";
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.AutoSize = true;
            this.MemoryLabel.Location = new System.Drawing.Point(51, 22);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(44, 13);
            this.MemoryLabel.TabIndex = 0;
            this.MemoryLabel.Text = "Memory";
            // 
            // ClickNextLabel
            // 
            this.ClickNextLabel.AutoSize = true;
            this.ClickNextLabel.Location = new System.Drawing.Point(50, 323);
            this.ClickNextLabel.Name = "ClickNextLabel";
            this.ClickNextLabel.Size = new System.Drawing.Size(177, 13);
            this.ClickNextLabel.TabIndex = 6;
            this.ClickNextLabel.Text = "Click Next to Confirm Your Selection";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(555, 312);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(126, 23);
            this.BackButton.TabIndex = 7;
            this.BackButton.Text = "Select Another Product";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.selecAnotherProductToolStripMenuItem_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(687, 311);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(769, 312);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 9;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // ProductIDTextBox
            // 
            this.ProductIDTextBox.Location = new System.Drawing.Point(97, 44);
            this.ProductIDTextBox.Name = "ProductIDTextBox";
            this.ProductIDTextBox.ReadOnly = true;
            this.ProductIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.ProductIDTextBox.TabIndex = 10;
            // 
            // ConditionTextBox
            // 
            this.ConditionTextBox.Location = new System.Drawing.Point(268, 44);
            this.ConditionTextBox.Name = "ConditionTextBox";
            this.ConditionTextBox.ReadOnly = true;
            this.ConditionTextBox.Size = new System.Drawing.Size(100, 20);
            this.ConditionTextBox.TabIndex = 11;
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(422, 44);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.ReadOnly = true;
            this.CostTextBox.Size = new System.Drawing.Size(100, 20);
            this.CostTextBox.TabIndex = 12;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.FileName = "order";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // ProductInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 363);
            this.ControlBox = false;
            this.Controls.Add(this.CostTextBox);
            this.Controls.Add(this.ConditionTextBox);
            this.Controls.Add(this.ProductIDTextBox);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ClickNextLabel);
            this.Controls.Add(this.TechSpecsGroupBox);
            this.Controls.Add(this.ProductInfoGroupBox);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.ConditionLabel);
            this.Controls.Add(this.ProductIDLabel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Information Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ProductInfoGroupBox.ResumeLayout(false);
            this.ProductInfoGroupBox.PerformLayout();
            this.TechSpecsGroupBox.ResumeLayout(false);
            this.TechSpecsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selecAnotherProductToolStripMenuItem;
        private System.Windows.Forms.Label ProductIDLabel;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.GroupBox ProductInfoGroupBox;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.GroupBox TechSpecsGroupBox;
        private System.Windows.Forms.Label WebCamLabel;
        private System.Windows.Forms.Label CPUModelLabel;
        private System.Windows.Forms.Label CPUTypeLabel;
        private System.Windows.Forms.Label GPUTypeLabel;
        private System.Windows.Forms.Label CPUSpeedLabel;
        private System.Windows.Forms.Label CPUBrandLabel;
        private System.Windows.Forms.Label HDDLabel;
        private System.Windows.Forms.Label LCDSizeLabel;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.Label ClickNextLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.TextBox ManufacturerTextBox;
        private System.Windows.Forms.TextBox OSTextBox;
        private System.Windows.Forms.TextBox PlatformTextBox;
        private System.Windows.Forms.TextBox ProductIDTextBox;
        private System.Windows.Forms.TextBox ConditionTextBox;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.TextBox WebCamTextBox;
        private System.Windows.Forms.TextBox GPUTypeTextBox;
        private System.Windows.Forms.TextBox HDDTextBox;
        private System.Windows.Forms.TextBox CPUModelTextBox;
        private System.Windows.Forms.TextBox CPUSpeedTextBox;
        private System.Windows.Forms.TextBox LCDSizeTextBox;
        private System.Windows.Forms.TextBox CPUTypeTextBox;
        private System.Windows.Forms.TextBox CPUBrandTextBox;
        private System.Windows.Forms.TextBox MemoryTextBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}