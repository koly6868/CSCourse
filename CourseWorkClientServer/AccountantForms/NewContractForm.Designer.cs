namespace CourseWorkClientServer.AccountantForms
{
    partial class NewContractForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.NewContractPanel = new System.Windows.Forms.Panel();
            this.TransportValueLabel = new System.Windows.Forms.Label();
            this.TransportLabel = new System.Windows.Forms.Label();
            this.ContProductsValueLabel = new System.Windows.Forms.Label();
            this.ProductsCountLabel = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.ContactDateBox = new System.Windows.Forms.DateTimePicker();
            this.CreateButton = new System.Windows.Forms.Button();
            this.AddTransportButton = new System.Windows.Forms.Button();
            this.AddProductsButton = new System.Windows.Forms.Button();
            this.ContractDateLabel = new System.Windows.Forms.Label();
            this.IDContractLabel = new System.Windows.Forms.Label();
            this.IDContractBox = new System.Windows.Forms.TextBox();
            this.NewContractLabel = new System.Windows.Forms.Label();
            this.CompanyBox = new System.Windows.Forms.ComboBox();
            this.CompanyLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.NewContractPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 330F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.NewContractPanel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(944, 551);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // NewContractPanel
            // 
            this.NewContractPanel.Controls.Add(this.CompanyLabel);
            this.NewContractPanel.Controls.Add(this.CompanyBox);
            this.NewContractPanel.Controls.Add(this.TransportValueLabel);
            this.NewContractPanel.Controls.Add(this.TransportLabel);
            this.NewContractPanel.Controls.Add(this.ContProductsValueLabel);
            this.NewContractPanel.Controls.Add(this.ProductsCountLabel);
            this.NewContractPanel.Controls.Add(this.ErrorLabel);
            this.NewContractPanel.Controls.Add(this.ContactDateBox);
            this.NewContractPanel.Controls.Add(this.CreateButton);
            this.NewContractPanel.Controls.Add(this.AddTransportButton);
            this.NewContractPanel.Controls.Add(this.AddProductsButton);
            this.NewContractPanel.Controls.Add(this.ContractDateLabel);
            this.NewContractPanel.Controls.Add(this.IDContractLabel);
            this.NewContractPanel.Controls.Add(this.IDContractBox);
            this.NewContractPanel.Controls.Add(this.NewContractLabel);
            this.NewContractPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewContractPanel.Location = new System.Drawing.Point(307, 0);
            this.NewContractPanel.Margin = new System.Windows.Forms.Padding(0);
            this.NewContractPanel.Name = "NewContractPanel";
            this.NewContractPanel.Size = new System.Drawing.Size(330, 551);
            this.NewContractPanel.TabIndex = 1;
            // 
            // TransportValueLabel
            // 
            this.TransportValueLabel.AutoSize = true;
            this.TransportValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransportValueLabel.Location = new System.Drawing.Point(149, 279);
            this.TransportValueLabel.Margin = new System.Windows.Forms.Padding(15);
            this.TransportValueLabel.Name = "TransportValueLabel";
            this.TransportValueLabel.Size = new System.Drawing.Size(13, 17);
            this.TransportValueLabel.TabIndex = 13;
            this.TransportValueLabel.Text = "-";
            // 
            // TransportLabel
            // 
            this.TransportLabel.AutoSize = true;
            this.TransportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransportLabel.Location = new System.Drawing.Point(15, 279);
            this.TransportLabel.Margin = new System.Windows.Forms.Padding(15);
            this.TransportLabel.Name = "TransportLabel";
            this.TransportLabel.Size = new System.Drawing.Size(70, 17);
            this.TransportLabel.TabIndex = 12;
            this.TransportLabel.Text = "Transport";
            // 
            // ContProductsValueLabel
            // 
            this.ContProductsValueLabel.AutoSize = true;
            this.ContProductsValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContProductsValueLabel.Location = new System.Drawing.Point(149, 176);
            this.ContProductsValueLabel.Margin = new System.Windows.Forms.Padding(15);
            this.ContProductsValueLabel.Name = "ContProductsValueLabel";
            this.ContProductsValueLabel.Size = new System.Drawing.Size(16, 17);
            this.ContProductsValueLabel.TabIndex = 11;
            this.ContProductsValueLabel.Text = "0";
            // 
            // ProductsCountLabel
            // 
            this.ProductsCountLabel.AutoSize = true;
            this.ProductsCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductsCountLabel.Location = new System.Drawing.Point(15, 176);
            this.ProductsCountLabel.Margin = new System.Windows.Forms.Padding(15);
            this.ProductsCountLabel.Name = "ProductsCountLabel";
            this.ProductsCountLabel.Size = new System.Drawing.Size(104, 17);
            this.ProductsCountLabel.TabIndex = 10;
            this.ProductsCountLabel.Text = "Count products";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.LightPink;
            this.ErrorLabel.Location = new System.Drawing.Point(112, 519);
            this.ErrorLabel.Margin = new System.Windows.Forms.Padding(15);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(95, 17);
            this.ErrorLabel.TabIndex = 9;
            this.ErrorLabel.Text = "Incorrect data";
            this.ErrorLabel.Visible = false;
            // 
            // ContactDateBox
            // 
            this.ContactDateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContactDateBox.Location = new System.Drawing.Point(89, 127);
            this.ContactDateBox.Margin = new System.Windows.Forms.Padding(15);
            this.ContactDateBox.Name = "ContactDateBox";
            this.ContactDateBox.Size = new System.Drawing.Size(131, 23);
            this.ContactDateBox.TabIndex = 8;
            // 
            // CreateButton
            // 
            this.CreateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateButton.Location = new System.Drawing.Point(127, 484);
            this.CreateButton.Margin = new System.Windows.Forms.Padding(15);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 25);
            this.CreateButton.TabIndex = 7;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // AddTransportButton
            // 
            this.AddTransportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddTransportButton.Location = new System.Drawing.Point(89, 326);
            this.AddTransportButton.Margin = new System.Windows.Forms.Padding(15);
            this.AddTransportButton.Name = "AddTransportButton";
            this.AddTransportButton.Size = new System.Drawing.Size(136, 26);
            this.AddTransportButton.TabIndex = 6;
            this.AddTransportButton.Text = "Add transport";
            this.AddTransportButton.UseVisualStyleBackColor = true;
            this.AddTransportButton.Click += new System.EventHandler(this.AddTransportButton_Click);
            // 
            // AddProductsButton
            // 
            this.AddProductsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddProductsButton.Location = new System.Drawing.Point(89, 223);
            this.AddProductsButton.Margin = new System.Windows.Forms.Padding(15);
            this.AddProductsButton.Name = "AddProductsButton";
            this.AddProductsButton.Size = new System.Drawing.Size(136, 26);
            this.AddProductsButton.TabIndex = 5;
            this.AddProductsButton.Text = "Choose products";
            this.AddProductsButton.UseVisualStyleBackColor = true;
            this.AddProductsButton.Click += new System.EventHandler(this.AddProductsButton_Click);
            // 
            // ContractDateLabel
            // 
            this.ContractDateLabel.AutoSize = true;
            this.ContractDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContractDateLabel.Location = new System.Drawing.Point(15, 127);
            this.ContractDateLabel.Margin = new System.Windows.Forms.Padding(15);
            this.ContractDateLabel.Name = "ContractDateLabel";
            this.ContractDateLabel.Size = new System.Drawing.Size(38, 17);
            this.ContractDateLabel.TabIndex = 4;
            this.ContractDateLabel.Text = "Date";
            // 
            // IDContractLabel
            // 
            this.IDContractLabel.AutoSize = true;
            this.IDContractLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDContractLabel.Location = new System.Drawing.Point(15, 68);
            this.IDContractLabel.Margin = new System.Windows.Forms.Padding(15);
            this.IDContractLabel.Name = "IDContractLabel";
            this.IDContractLabel.Size = new System.Drawing.Size(21, 17);
            this.IDContractLabel.TabIndex = 2;
            this.IDContractLabel.Text = "ID";
            // 
            // IDContractBox
            // 
            this.IDContractBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDContractBox.Location = new System.Drawing.Point(89, 68);
            this.IDContractBox.Margin = new System.Windows.Forms.Padding(15);
            this.IDContractBox.Name = "IDContractBox";
            this.IDContractBox.Size = new System.Drawing.Size(136, 23);
            this.IDContractBox.TabIndex = 1;
            // 
            // NewContractLabel
            // 
            this.NewContractLabel.AutoSize = true;
            this.NewContractLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewContractLabel.Location = new System.Drawing.Point(132, 21);
            this.NewContractLabel.Margin = new System.Windows.Forms.Padding(15);
            this.NewContractLabel.Name = "NewContractLabel";
            this.NewContractLabel.Size = new System.Drawing.Size(61, 17);
            this.NewContractLabel.TabIndex = 0;
            this.NewContractLabel.Text = "Contract";
            // 
            // CompanyBox
            // 
            this.CompanyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompanyBox.FormattingEnabled = true;
            this.CompanyBox.Location = new System.Drawing.Point(90, 382);
            this.CompanyBox.Margin = new System.Windows.Forms.Padding(15);
            this.CompanyBox.Name = "CompanyBox";
            this.CompanyBox.Size = new System.Drawing.Size(135, 24);
            this.CompanyBox.TabIndex = 14;
            this.CompanyBox.SelectedIndexChanged += new System.EventHandler(this.CompanyBox_SelectedIndexChanged);
            // 
            // CompanyLabel
            // 
            this.CompanyLabel.AutoSize = true;
            this.CompanyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompanyLabel.Location = new System.Drawing.Point(15, 382);
            this.CompanyLabel.Margin = new System.Windows.Forms.Padding(15);
            this.CompanyLabel.Name = "CompanyLabel";
            this.CompanyLabel.Size = new System.Drawing.Size(67, 17);
            this.CompanyLabel.TabIndex = 15;
            this.CompanyLabel.Text = "Compnay";
            // 
            // NewContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(944, 551);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "NewContractForm";
            this.Text = "NewContractForm";
            this.Load += new System.EventHandler(this.NewContractForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.NewContractPanel.ResumeLayout(false);
            this.NewContractPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel NewContractPanel;
        private System.Windows.Forms.Label NewContractLabel;
        private System.Windows.Forms.Button AddTransportButton;
        private System.Windows.Forms.Button AddProductsButton;
        private System.Windows.Forms.Label ContractDateLabel;
        private System.Windows.Forms.Label IDContractLabel;
        private System.Windows.Forms.TextBox IDContractBox;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.DateTimePicker ContactDateBox;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label TransportValueLabel;
        private System.Windows.Forms.Label TransportLabel;
        private System.Windows.Forms.Label ContProductsValueLabel;
        private System.Windows.Forms.Label ProductsCountLabel;
        private System.Windows.Forms.Label CompanyLabel;
        private System.Windows.Forms.ComboBox CompanyBox;
    }
}