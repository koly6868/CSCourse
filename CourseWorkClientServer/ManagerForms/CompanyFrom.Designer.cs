namespace CourseWorkClientServer.ManagerForms
{
    partial class CompanyFrom
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
            this.CompanyPanel = new System.Windows.Forms.Panel();
            this.DeleteAdresButon = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.AddAdressButton = new System.Windows.Forms.Button();
            this.FormLabel = new System.Windows.Forms.Label();
            this.FormOfompanyBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.AdressOfCompanyLabel = new System.Windows.Forms.Label();
            this.AdressBox = new System.Windows.Forms.ComboBox();
            this.CompanyRaitingLable = new System.Windows.Forms.Label();
            this.CompanyRaitingBox = new System.Windows.Forms.TextBox();
            this.CompanyNameLabel = new System.Windows.Forms.Label();
            this.CompanyNameBox = new System.Windows.Forms.TextBox();
            this.CompanyLabel = new System.Windows.Forms.Label();
            this.EditAdress = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.CompanyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.CompanyPanel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(944, 501);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // CompanyPanel
            // 
            this.CompanyPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CompanyPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CompanyPanel.Controls.Add(this.EditAdress);
            this.CompanyPanel.Controls.Add(this.DeleteAdresButon);
            this.CompanyPanel.Controls.Add(this.ErrorLabel);
            this.CompanyPanel.Controls.Add(this.AddAdressButton);
            this.CompanyPanel.Controls.Add(this.FormLabel);
            this.CompanyPanel.Controls.Add(this.FormOfompanyBox);
            this.CompanyPanel.Controls.Add(this.SaveButton);
            this.CompanyPanel.Controls.Add(this.PhoneLabel);
            this.CompanyPanel.Controls.Add(this.PhoneBox);
            this.CompanyPanel.Controls.Add(this.AdressOfCompanyLabel);
            this.CompanyPanel.Controls.Add(this.AdressBox);
            this.CompanyPanel.Controls.Add(this.CompanyRaitingLable);
            this.CompanyPanel.Controls.Add(this.CompanyRaitingBox);
            this.CompanyPanel.Controls.Add(this.CompanyNameLabel);
            this.CompanyPanel.Controls.Add(this.CompanyNameBox);
            this.CompanyPanel.Controls.Add(this.CompanyLabel);
            this.CompanyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CompanyPanel.Location = new System.Drawing.Point(287, 15);
            this.CompanyPanel.Margin = new System.Windows.Forms.Padding(15);
            this.CompanyPanel.MaximumSize = new System.Drawing.Size(600, 800);
            this.CompanyPanel.MinimumSize = new System.Drawing.Size(300, 400);
            this.CompanyPanel.Name = "CompanyPanel";
            this.CompanyPanel.Size = new System.Drawing.Size(370, 471);
            this.CompanyPanel.TabIndex = 4;
            // 
            // DeleteAdresButon
            // 
            this.DeleteAdresButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteAdresButon.Location = new System.Drawing.Point(185, 287);
            this.DeleteAdresButon.Margin = new System.Windows.Forms.Padding(10);
            this.DeleteAdresButon.Name = "DeleteAdresButon";
            this.DeleteAdresButon.Size = new System.Drawing.Size(60, 25);
            this.DeleteAdresButon.TabIndex = 15;
            this.DeleteAdresButon.Text = "Delete";
            this.DeleteAdresButon.UseVisualStyleBackColor = true;
            this.DeleteAdresButon.Click += new System.EventHandler(this.DeleteAdresButon_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.LightPink;
            this.ErrorLabel.Location = new System.Drawing.Point(140, 399);
            this.ErrorLabel.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(95, 17);
            this.ErrorLabel.TabIndex = 14;
            this.ErrorLabel.Text = "Incorrect data";
            this.ErrorLabel.Visible = false;
            // 
            // AddAdressButton
            // 
            this.AddAdressButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddAdressButton.Location = new System.Drawing.Point(265, 287);
            this.AddAdressButton.Margin = new System.Windows.Forms.Padding(10);
            this.AddAdressButton.Name = "AddAdressButton";
            this.AddAdressButton.Size = new System.Drawing.Size(60, 25);
            this.AddAdressButton.TabIndex = 13;
            this.AddAdressButton.Text = "Add";
            this.AddAdressButton.UseVisualStyleBackColor = true;
            this.AddAdressButton.Click += new System.EventHandler(this.AddAdressButton_Click);
            // 
            // FormLabel
            // 
            this.FormLabel.AutoSize = true;
            this.FormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormLabel.Location = new System.Drawing.Point(15, 184);
            this.FormLabel.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.FormLabel.Name = "FormLabel";
            this.FormLabel.Size = new System.Drawing.Size(40, 17);
            this.FormLabel.TabIndex = 12;
            this.FormLabel.Text = "Form";
            // 
            // FormOfompanyBox
            // 
            this.FormOfompanyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormOfompanyBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FormOfompanyBox.Location = new System.Drawing.Point(95, 181);
            this.FormOfompanyBox.Margin = new System.Windows.Forms.Padding(15);
            this.FormOfompanyBox.Name = "FormOfompanyBox";
            this.FormOfompanyBox.Size = new System.Drawing.Size(245, 23);
            this.FormOfompanyBox.TabIndex = 11;
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(134, 431);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(15);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(101, 25);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneLabel.Location = new System.Drawing.Point(15, 340);
            this.PhoneLabel.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(49, 17);
            this.PhoneLabel.TabIndex = 9;
            this.PhoneLabel.Text = "Phone";
            // 
            // PhoneBox
            // 
            this.PhoneBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PhoneBox.Location = new System.Drawing.Point(95, 337);
            this.PhoneBox.Margin = new System.Windows.Forms.Padding(15);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.ReadOnly = true;
            this.PhoneBox.Size = new System.Drawing.Size(245, 23);
            this.PhoneBox.TabIndex = 8;
            // 
            // AdressOfCompanyLabel
            // 
            this.AdressOfCompanyLabel.AutoSize = true;
            this.AdressOfCompanyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdressOfCompanyLabel.Location = new System.Drawing.Point(15, 255);
            this.AdressOfCompanyLabel.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.AdressOfCompanyLabel.Name = "AdressOfCompanyLabel";
            this.AdressOfCompanyLabel.Size = new System.Drawing.Size(52, 17);
            this.AdressOfCompanyLabel.TabIndex = 7;
            this.AdressOfCompanyLabel.Text = "Adress";
            // 
            // AdressBox
            // 
            this.AdressBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdressBox.FormattingEnabled = true;
            this.AdressBox.Location = new System.Drawing.Point(95, 252);
            this.AdressBox.Margin = new System.Windows.Forms.Padding(15);
            this.AdressBox.Name = "AdressBox";
            this.AdressBox.Size = new System.Drawing.Size(245, 24);
            this.AdressBox.Sorted = true;
            this.AdressBox.TabIndex = 5;
            this.AdressBox.SelectedIndexChanged += new System.EventHandler(this.AdressBox_SelectedIndexChanged);
            // 
            // CompanyRaitingLable
            // 
            this.CompanyRaitingLable.AutoSize = true;
            this.CompanyRaitingLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompanyRaitingLable.Location = new System.Drawing.Point(15, 131);
            this.CompanyRaitingLable.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.CompanyRaitingLable.Name = "CompanyRaitingLable";
            this.CompanyRaitingLable.Size = new System.Drawing.Size(52, 17);
            this.CompanyRaitingLable.TabIndex = 4;
            this.CompanyRaitingLable.Text = "Raiting";
            // 
            // CompanyRaitingBox
            // 
            this.CompanyRaitingBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CompanyRaitingBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompanyRaitingBox.Location = new System.Drawing.Point(95, 128);
            this.CompanyRaitingBox.Margin = new System.Windows.Forms.Padding(15);
            this.CompanyRaitingBox.Name = "CompanyRaitingBox";
            this.CompanyRaitingBox.Size = new System.Drawing.Size(245, 23);
            this.CompanyRaitingBox.TabIndex = 3;
            // 
            // CompanyNameLabel
            // 
            this.CompanyNameLabel.AutoSize = true;
            this.CompanyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompanyNameLabel.Location = new System.Drawing.Point(15, 75);
            this.CompanyNameLabel.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.CompanyNameLabel.Name = "CompanyNameLabel";
            this.CompanyNameLabel.Size = new System.Drawing.Size(45, 17);
            this.CompanyNameLabel.TabIndex = 2;
            this.CompanyNameLabel.Text = "Name";
            // 
            // CompanyNameBox
            // 
            this.CompanyNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CompanyNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompanyNameBox.Location = new System.Drawing.Point(95, 75);
            this.CompanyNameBox.Margin = new System.Windows.Forms.Padding(15);
            this.CompanyNameBox.Name = "CompanyNameBox";
            this.CompanyNameBox.Size = new System.Drawing.Size(245, 23);
            this.CompanyNameBox.TabIndex = 1;
            // 
            // CompanyLabel
            // 
            this.CompanyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompanyLabel.Location = new System.Drawing.Point(130, 10);
            this.CompanyLabel.Margin = new System.Windows.Forms.Padding(10);
            this.CompanyLabel.Name = "CompanyLabel";
            this.CompanyLabel.Size = new System.Drawing.Size(109, 26);
            this.CompanyLabel.TabIndex = 0;
            this.CompanyLabel.Text = "Company";
            // 
            // EditAdress
            // 
            this.EditAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditAdress.Location = new System.Drawing.Point(105, 287);
            this.EditAdress.Margin = new System.Windows.Forms.Padding(10);
            this.EditAdress.Name = "EditAdress";
            this.EditAdress.Size = new System.Drawing.Size(60, 25);
            this.EditAdress.TabIndex = 16;
            this.EditAdress.Text = "Edit";
            this.EditAdress.UseVisualStyleBackColor = true;
            this.EditAdress.Click += new System.EventHandler(this.EditAdress_Click);
            // 
            // CompanyFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CompanyFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompanyFrom";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.CompanyPanel.ResumeLayout(false);
            this.CompanyPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel CompanyPanel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.Label AdressOfCompanyLabel;
        private System.Windows.Forms.ComboBox AdressBox;
        private System.Windows.Forms.Label CompanyRaitingLable;
        private System.Windows.Forms.TextBox CompanyRaitingBox;
        private System.Windows.Forms.Label CompanyNameLabel;
        private System.Windows.Forms.TextBox CompanyNameBox;
        private System.Windows.Forms.Label CompanyLabel;
        private System.Windows.Forms.Label FormLabel;
        private System.Windows.Forms.TextBox FormOfompanyBox;
        private System.Windows.Forms.Button AddAdressButton;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Button DeleteAdresButon;
        private System.Windows.Forms.Button EditAdress;
    }
}