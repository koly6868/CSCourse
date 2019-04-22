namespace CourseWorkClientServer.ManagerForms
{
    partial class CompanyManagerForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CompanyListPanel = new System.Windows.Forms.Panel();
            this.CompanyListTopPanel = new System.Windows.Forms.Panel();
            this.NewCompanyButton = new System.Windows.Forms.Button();
            this.DeleteCompanyButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.CompanyListPanel.SuspendLayout();
            this.CompanyListTopPanel.SuspendLayout();
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
            this.CompanyList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.CompanyList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderRating});
            this.CompanyList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompanyList.Location = new System.Drawing.Point(0, 45);
            this.CompanyList.Margin = new System.Windows.Forms.Padding(0);
            this.CompanyList.Name = "CompanyList";
            this.CompanyList.Size = new System.Drawing.Size(370, 386);
            this.CompanyList.TabIndex = 2;
            this.CompanyList.UseCompatibleStateImageBehavior = false;
            this.CompanyList.View = System.Windows.Forms.View.Details;
            this.CompanyList.DoubleClick += new System.EventHandler(this.OnDoubleClick);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 223;
            // 
            // columnHeaderRating
            // 
            this.columnHeaderRating.Text = "Raiting";
            this.columnHeaderRating.Width = 140;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.CompanyListPanel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(944, 461);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // CompanyListPanel
            // 
            this.CompanyListPanel.Controls.Add(this.CompanyListTopPanel);
            this.CompanyListPanel.Controls.Add(this.CompanyList);
            this.CompanyListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CompanyListPanel.Location = new System.Drawing.Point(287, 15);
            this.CompanyListPanel.Margin = new System.Windows.Forms.Padding(15);
            this.CompanyListPanel.Name = "CompanyListPanel";
            this.CompanyListPanel.Size = new System.Drawing.Size(370, 431);
            this.CompanyListPanel.TabIndex = 4;
            // 
            // CompanyListTopPanel
            // 
            this.CompanyListTopPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CompanyListTopPanel.Controls.Add(this.NewCompanyButton);
            this.CompanyListTopPanel.Controls.Add(this.DeleteCompanyButton);
            this.CompanyListTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CompanyListTopPanel.Location = new System.Drawing.Point(0, 0);
            this.CompanyListTopPanel.Margin = new System.Windows.Forms.Padding(0);
            this.CompanyListTopPanel.Name = "CompanyListTopPanel";
            this.CompanyListTopPanel.Size = new System.Drawing.Size(370, 45);
            this.CompanyListTopPanel.TabIndex = 3;
            // 
            // NewCompanyButton
            // 
            this.NewCompanyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewCompanyButton.Location = new System.Drawing.Point(245, 11);
            this.NewCompanyButton.Margin = new System.Windows.Forms.Padding(10);
            this.NewCompanyButton.Name = "NewCompanyButton";
            this.NewCompanyButton.Size = new System.Drawing.Size(111, 25);
            this.NewCompanyButton.TabIndex = 3;
            this.NewCompanyButton.Text = "New company";
            this.NewCompanyButton.UseVisualStyleBackColor = true;
            this.NewCompanyButton.Click += new System.EventHandler(this.NewCompanyButton_Click);
            // 
            // DeleteCompanyButton
            // 
            this.DeleteCompanyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteCompanyButton.Location = new System.Drawing.Point(10, 11);
            this.DeleteCompanyButton.Margin = new System.Windows.Forms.Padding(10);
            this.DeleteCompanyButton.Name = "DeleteCompanyButton";
            this.DeleteCompanyButton.Size = new System.Drawing.Size(118, 25);
            this.DeleteCompanyButton.TabIndex = 2;
            this.DeleteCompanyButton.Text = "Delete company";
            this.DeleteCompanyButton.UseVisualStyleBackColor = true;
            this.DeleteCompanyButton.Click += new System.EventHandler(this.DeleteCompanyButton_Click);
            // 
            // CompanyManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "CompanyManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.CompanyListPanel.ResumeLayout(false);
            this.CompanyListTopPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClosing);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView CompanyList;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderRating;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel CompanyListPanel;
        private System.Windows.Forms.Panel CompanyListTopPanel;
        private System.Windows.Forms.Button DeleteCompanyButton;
        private System.Windows.Forms.Button NewCompanyButton;
    }
}

