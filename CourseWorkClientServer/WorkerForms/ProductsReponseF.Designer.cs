namespace CourseWorkClientServer.WorkerForms
{
    partial class ProductsReponseF
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
            this.CentralPanel = new System.Windows.Forms.Panel();
            this.TopCentralPanel = new System.Windows.Forms.Panel();
            this.ResponseList = new System.Windows.Forms.ListBox();
            this.ResponseLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.CentralPanel.SuspendLayout();
            this.TopCentralPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.CentralPanel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(944, 551);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // CentralPanel
            // 
            this.CentralPanel.Controls.Add(this.ResponseList);
            this.CentralPanel.Controls.Add(this.TopCentralPanel);
            this.CentralPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CentralPanel.Location = new System.Drawing.Point(237, 15);
            this.CentralPanel.Margin = new System.Windows.Forms.Padding(15);
            this.CentralPanel.Name = "CentralPanel";
            this.CentralPanel.Size = new System.Drawing.Size(470, 521);
            this.CentralPanel.TabIndex = 0;
            // 
            // TopCentralPanel
            // 
            this.TopCentralPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TopCentralPanel.Controls.Add(this.ResponseLabel);
            this.TopCentralPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopCentralPanel.Location = new System.Drawing.Point(0, 0);
            this.TopCentralPanel.Name = "TopCentralPanel";
            this.TopCentralPanel.Size = new System.Drawing.Size(470, 45);
            this.TopCentralPanel.TabIndex = 0;
            // 
            // ResponseList
            // 
            this.ResponseList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResponseList.FormattingEnabled = true;
            this.ResponseList.Location = new System.Drawing.Point(0, 48);
            this.ResponseList.Margin = new System.Windows.Forms.Padding(0);
            this.ResponseList.Name = "ResponseList";
            this.ResponseList.Size = new System.Drawing.Size(470, 468);
            this.ResponseList.TabIndex = 1;
            this.ResponseList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ResponseLabel
            // 
            this.ResponseLabel.AutoSize = true;
            this.ResponseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResponseLabel.Location = new System.Drawing.Point(141, 12);
            this.ResponseLabel.Name = "ResponseLabel";
            this.ResponseLabel.Size = new System.Drawing.Size(179, 20);
            this.ResponseLabel.TabIndex = 0;
            this.ResponseLabel.Text = "Reponse products table";
            // 
            // ProductsReponseFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(944, 551);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProductsReponseFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductsReponseFrom";
            this.Load += new System.EventHandler(this.ProductsReponseFrom_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.CentralPanel.ResumeLayout(false);
            this.TopCentralPanel.ResumeLayout(false);
            this.TopCentralPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel CentralPanel;
        private System.Windows.Forms.ListBox ResponseList;
        private System.Windows.Forms.Panel TopCentralPanel;
        private System.Windows.Forms.Label ResponseLabel;
    }
}