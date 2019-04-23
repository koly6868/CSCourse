namespace CourseWorkClientServer.AccountantForms
{
    partial class TransportAddForm
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
            this.TopBar = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TransportPanel = new System.Windows.Forms.Panel();
            this.BottomTransportPanel = new System.Windows.Forms.Panel();
            this.OkButton = new System.Windows.Forms.Button();
            this.TransportList = new System.Windows.Forms.ListView();
            this.TransportName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TransportMaxWeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TransportPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TransportTimeOfDelivery = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TopTransportPanel = new System.Windows.Forms.Panel();
            this.TransportLabel = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.TransportPanel.SuspendLayout();
            this.BottomTransportPanel.SuspendLayout();
            this.TopTransportPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Margin = new System.Windows.Forms.Padding(0);
            this.TopBar.MaximumSize = new System.Drawing.Size(0, 60);
            this.TopBar.MinimumSize = new System.Drawing.Size(960, 40);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(960, 40);
            this.TopBar.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 355F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.TransportPanel, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(948, 514);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // TransportPanel
            // 
            this.TransportPanel.Controls.Add(this.BottomTransportPanel);
            this.TransportPanel.Controls.Add(this.TransportList);
            this.TransportPanel.Controls.Add(this.TopTransportPanel);
            this.TransportPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TransportPanel.Location = new System.Drawing.Point(311, 15);
            this.TransportPanel.Margin = new System.Windows.Forms.Padding(15);
            this.TransportPanel.Name = "TransportPanel";
            this.TransportPanel.Size = new System.Drawing.Size(325, 484);
            this.TransportPanel.TabIndex = 0;
            // 
            // BottomTransportPanel
            // 
            this.BottomTransportPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BottomTransportPanel.Controls.Add(this.ErrorLabel);
            this.BottomTransportPanel.Controls.Add(this.OkButton);
            this.BottomTransportPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomTransportPanel.Location = new System.Drawing.Point(0, 439);
            this.BottomTransportPanel.Margin = new System.Windows.Forms.Padding(0);
            this.BottomTransportPanel.Name = "BottomTransportPanel";
            this.BottomTransportPanel.Size = new System.Drawing.Size(325, 45);
            this.BottomTransportPanel.TabIndex = 3;
            // 
            // OkButton
            // 
            this.OkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OkButton.Location = new System.Drawing.Point(245, 15);
            this.OkButton.Margin = new System.Windows.Forms.Padding(5);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 25);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // TransportList
            // 
            this.TransportList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TransportName,
            this.TransportMaxWeight,
            this.TransportPrice,
            this.TransportTimeOfDelivery});
            this.TransportList.Location = new System.Drawing.Point(0, 45);
            this.TransportList.Margin = new System.Windows.Forms.Padding(0);
            this.TransportList.Name = "TransportList";
            this.TransportList.Size = new System.Drawing.Size(325, 394);
            this.TransportList.TabIndex = 2;
            this.TransportList.UseCompatibleStateImageBehavior = false;
            this.TransportList.View = System.Windows.Forms.View.Details;
            this.TransportList.DoubleClick += new System.EventHandler(this.OnDoubleClick);
            // 
            // TransportName
            // 
            this.TransportName.Text = "Name";
            // 
            // TransportMaxWeight
            // 
            this.TransportMaxWeight.Text = "Max weight";
            this.TransportMaxWeight.Width = 69;
            // 
            // TransportPrice
            // 
            this.TransportPrice.Text = "Price";
            this.TransportPrice.Width = 72;
            // 
            // TransportTimeOfDelivery
            // 
            this.TransportTimeOfDelivery.Text = "Time of delivery";
            this.TransportTimeOfDelivery.Width = 120;
            // 
            // TopTransportPanel
            // 
            this.TopTransportPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TopTransportPanel.Controls.Add(this.TransportLabel);
            this.TopTransportPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopTransportPanel.Location = new System.Drawing.Point(0, 0);
            this.TopTransportPanel.Margin = new System.Windows.Forms.Padding(0);
            this.TopTransportPanel.Name = "TopTransportPanel";
            this.TopTransportPanel.Size = new System.Drawing.Size(325, 45);
            this.TopTransportPanel.TabIndex = 1;
            // 
            // TransportLabel
            // 
            this.TransportLabel.AutoSize = true;
            this.TransportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransportLabel.Location = new System.Drawing.Point(124, 13);
            this.TransportLabel.Name = "TransportLabel";
            this.TransportLabel.Size = new System.Drawing.Size(77, 20);
            this.TransportLabel.TabIndex = 0;
            this.TransportLabel.Text = "Transport";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.LightPink;
            this.ErrorLabel.Location = new System.Drawing.Point(106, 19);
            this.ErrorLabel.Margin = new System.Windows.Forms.Padding(15);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(95, 17);
            this.ErrorLabel.TabIndex = 10;
            this.ErrorLabel.Text = "Incorrect data";
            this.ErrorLabel.Visible = false;
            // 
            // TransportAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(944, 551);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.TopBar);
            this.Name = "TransportAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransportForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.TransportPanel.ResumeLayout(false);
            this.BottomTransportPanel.ResumeLayout(false);
            this.BottomTransportPanel.PerformLayout();
            this.TopTransportPanel.ResumeLayout(false);
            this.TopTransportPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel TransportPanel;
        private System.Windows.Forms.Panel TopTransportPanel;
        private System.Windows.Forms.Label TransportLabel;
        private System.Windows.Forms.ListView TransportList;
        private System.Windows.Forms.ColumnHeader TransportName;
        private System.Windows.Forms.ColumnHeader TransportMaxWeight;
        private System.Windows.Forms.ColumnHeader TransportPrice;
        private System.Windows.Forms.ColumnHeader TransportTimeOfDelivery;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Panel BottomTransportPanel;
        private System.Windows.Forms.Label ErrorLabel;
    }
}