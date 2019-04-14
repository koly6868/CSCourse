namespace CourseWorkClientServer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CompanyList = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderRating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.TextBox();
            this.AdressOfCompanyLabel = new System.Windows.Forms.Label();
            this.Adress = new System.Windows.Forms.ComboBox();
            this.CompanyRaitingLable = new System.Windows.Forms.Label();
            this.CompanyRaiting = new System.Windows.Forms.TextBox();
            this.CompanyNameLabel = new System.Windows.Forms.Label();
            this.CompanyName = new System.Windows.Forms.TextBox();
            this.CompanyLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(857, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "To Orders";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(0, 60);
            this.panel1.MinimumSize = new System.Drawing.Size(960, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 40);
            this.panel1.TabIndex = 1;
            // 
            // CompanyList
            // 
            this.CompanyList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderRating});
            this.CompanyList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompanyList.Location = new System.Drawing.Point(25, 69);
            this.CompanyList.MaximumSize = new System.Drawing.Size(440, 800);
            this.CompanyList.MinimumSize = new System.Drawing.Size(220, 400);
            this.CompanyList.Name = "CompanyList";
            this.CompanyList.Size = new System.Drawing.Size(220, 400);
            this.CompanyList.TabIndex = 2;
            this.CompanyList.UseCompatibleStateImageBehavior = false;
            this.CompanyList.View = System.Windows.Forms.View.Details;
            this.CompanyList.SelectedIndexChanged += new System.EventHandler(this.CompanyList_SelectedIndexChanged);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 110;
            // 
            // columnHeaderRating
            // 
            this.columnHeaderRating.Text = "Raiting";
            this.columnHeaderRating.Width = 147;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.PhoneLabel);
            this.panel2.Controls.Add(this.Phone);
            this.panel2.Controls.Add(this.AdressOfCompanyLabel);
            this.panel2.Controls.Add(this.Adress);
            this.panel2.Controls.Add(this.CompanyRaitingLable);
            this.panel2.Controls.Add(this.CompanyRaiting);
            this.panel2.Controls.Add(this.CompanyNameLabel);
            this.panel2.Controls.Add(this.CompanyName);
            this.panel2.Controls.Add(this.CompanyLabel);
            this.panel2.Location = new System.Drawing.Point(339, 69);
            this.panel2.MaximumSize = new System.Drawing.Size(600, 800);
            this.panel2.MinimumSize = new System.Drawing.Size(300, 400);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 400);
            this.panel2.TabIndex = 3;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(70, 209);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(38, 13);
            this.PhoneLabel.TabIndex = 9;
            this.PhoneLabel.Text = "Phone";
            // 
            // Phone
            // 
            this.Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Phone.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Phone.Location = new System.Drawing.Point(73, 225);
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Size = new System.Drawing.Size(121, 29);
            this.Phone.TabIndex = 8;
            // 
            // AdressOfCompanyLabel
            // 
            this.AdressOfCompanyLabel.AutoSize = true;
            this.AdressOfCompanyLabel.Location = new System.Drawing.Point(70, 152);
            this.AdressOfCompanyLabel.Name = "AdressOfCompanyLabel";
            this.AdressOfCompanyLabel.Size = new System.Drawing.Size(39, 13);
            this.AdressOfCompanyLabel.TabIndex = 7;
            this.AdressOfCompanyLabel.Text = "Adress";
            // 
            // Adress
            // 
            this.Adress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Adress.FormattingEnabled = true;
            this.Adress.Location = new System.Drawing.Point(73, 168);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(121, 32);
            this.Adress.Sorted = true;
            this.Adress.TabIndex = 5;
            this.Adress.SelectedIndexChanged += new System.EventHandler(this.AdressButton_SelectedIndexChanged);
            // 
            // CompanyRaitingLable
            // 
            this.CompanyRaitingLable.AutoSize = true;
            this.CompanyRaitingLable.Location = new System.Drawing.Point(70, 104);
            this.CompanyRaitingLable.Name = "CompanyRaitingLable";
            this.CompanyRaitingLable.Size = new System.Drawing.Size(40, 13);
            this.CompanyRaitingLable.TabIndex = 4;
            this.CompanyRaitingLable.Text = "Raiting";
            // 
            // CompanyRaiting
            // 
            this.CompanyRaiting.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CompanyRaiting.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompanyRaiting.Location = new System.Drawing.Point(73, 120);
            this.CompanyRaiting.Name = "CompanyRaiting";
            this.CompanyRaiting.ReadOnly = true;
            this.CompanyRaiting.Size = new System.Drawing.Size(175, 29);
            this.CompanyRaiting.TabIndex = 3;
            // 
            // CompanyNameLabel
            // 
            this.CompanyNameLabel.AutoSize = true;
            this.CompanyNameLabel.Location = new System.Drawing.Point(70, 46);
            this.CompanyNameLabel.Name = "CompanyNameLabel";
            this.CompanyNameLabel.Size = new System.Drawing.Size(35, 13);
            this.CompanyNameLabel.TabIndex = 2;
            this.CompanyNameLabel.Text = "Name";
            // 
            // CompanyName
            // 
            this.CompanyName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompanyName.Location = new System.Drawing.Point(73, 62);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.ReadOnly = true;
            this.CompanyName.Size = new System.Drawing.Size(175, 29);
            this.CompanyName.TabIndex = 1;
            // 
            // CompanyLabel
            // 
            this.CompanyLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CompanyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompanyLabel.Location = new System.Drawing.Point(0, 0);
            this.CompanyLabel.Margin = new System.Windows.Forms.Padding(10);
            this.CompanyLabel.Name = "CompanyLabel";
            this.CompanyLabel.Size = new System.Drawing.Size(300, 26);
            this.CompanyLabel.TabIndex = 0;
            this.CompanyLabel.Text = "Company";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.CompanyList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView CompanyList;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderRating;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CompanyLabel;
        private System.Windows.Forms.TextBox CompanyName;
        private System.Windows.Forms.Label CompanyNameLabel;
        private System.Windows.Forms.ComboBox Adress;
        private System.Windows.Forms.Label CompanyRaitingLable;
        private System.Windows.Forms.TextBox CompanyRaiting;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.Label AdressOfCompanyLabel;
        private System.Windows.Forms.Label PhoneLabel;
    }
}

