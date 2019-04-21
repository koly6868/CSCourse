namespace CourseWorkClientServer.WorkerForms
{
    partial class TransportManagerForm
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
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.PriceHeader = new System.Windows.Forms.Label();
            this.TimeOfDeliveryHeader = new System.Windows.Forms.Label();
            this.MaxWeightHeader = new System.Windows.Forms.Label();
            this.NameHeader = new System.Windows.Forms.Label();
            this.TransportList = new System.Windows.Forms.ListBox();
            this.BottomTransportPanel = new System.Windows.Forms.Panel();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.TopTransportPanel = new System.Windows.Forms.Panel();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddTransportButton = new System.Windows.Forms.Button();
            this.TransportLabel = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.TransportTab = new System.Windows.Forms.TabPage();
            this.ResponseTableTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.CentralPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.StateLabel = new System.Windows.Forms.Label();
            this.IDContractLabel = new System.Windows.Forms.Label();
            this.ResponseList = new System.Windows.Forms.ListBox();
            this.TopCentralPanel = new System.Windows.Forms.Panel();
            this.RetrunProductsButton = new System.Windows.Forms.Button();
            this.ResponseLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.TransportPanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.BottomTransportPanel.SuspendLayout();
            this.TopTransportPanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.TransportTab.SuspendLayout();
            this.ResponseTableTab.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.CentralPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.TopCentralPanel.SuspendLayout();
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.TransportPanel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(930, 479);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // TransportPanel
            // 
            this.TransportPanel.Controls.Add(this.HeaderPanel);
            this.TransportPanel.Controls.Add(this.TransportList);
            this.TransportPanel.Controls.Add(this.BottomTransportPanel);
            this.TransportPanel.Controls.Add(this.TopTransportPanel);
            this.TransportPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TransportPanel.Location = new System.Drawing.Point(230, 15);
            this.TransportPanel.Margin = new System.Windows.Forms.Padding(15);
            this.TransportPanel.Name = "TransportPanel";
            this.TransportPanel.Size = new System.Drawing.Size(470, 449);
            this.TransportPanel.TabIndex = 0;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.PriceHeader);
            this.HeaderPanel.Controls.Add(this.TimeOfDeliveryHeader);
            this.HeaderPanel.Controls.Add(this.MaxWeightHeader);
            this.HeaderPanel.Controls.Add(this.NameHeader);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 45);
            this.HeaderPanel.Margin = new System.Windows.Forms.Padding(0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(470, 31);
            this.HeaderPanel.TabIndex = 5;
            // 
            // PriceHeader
            // 
            this.PriceHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PriceHeader.AutoSize = true;
            this.PriceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceHeader.Location = new System.Drawing.Point(415, 9);
            this.PriceHeader.Margin = new System.Windows.Forms.Padding(5);
            this.PriceHeader.Name = "PriceHeader";
            this.PriceHeader.Size = new System.Drawing.Size(40, 17);
            this.PriceHeader.TabIndex = 3;
            this.PriceHeader.Text = "Price";
            // 
            // TimeOfDeliveryHeader
            // 
            this.TimeOfDeliveryHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TimeOfDeliveryHeader.AutoSize = true;
            this.TimeOfDeliveryHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeOfDeliveryHeader.Location = new System.Drawing.Point(297, 9);
            this.TimeOfDeliveryHeader.Margin = new System.Windows.Forms.Padding(5);
            this.TimeOfDeliveryHeader.Name = "TimeOfDeliveryHeader";
            this.TimeOfDeliveryHeader.Size = new System.Drawing.Size(108, 17);
            this.TimeOfDeliveryHeader.TabIndex = 2;
            this.TimeOfDeliveryHeader.Text = "Time of delivery";
            // 
            // MaxWeightHeader
            // 
            this.MaxWeightHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.MaxWeightHeader.AutoSize = true;
            this.MaxWeightHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaxWeightHeader.Location = new System.Drawing.Point(210, 9);
            this.MaxWeightHeader.Margin = new System.Windows.Forms.Padding(5);
            this.MaxWeightHeader.Name = "MaxWeightHeader";
            this.MaxWeightHeader.Size = new System.Drawing.Size(77, 17);
            this.MaxWeightHeader.TabIndex = 1;
            this.MaxWeightHeader.Text = "Max weight";
            // 
            // NameHeader
            // 
            this.NameHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.NameHeader.AutoSize = true;
            this.NameHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameHeader.Location = new System.Drawing.Point(66, 9);
            this.NameHeader.Margin = new System.Windows.Forms.Padding(5);
            this.NameHeader.Name = "NameHeader";
            this.NameHeader.Size = new System.Drawing.Size(45, 17);
            this.NameHeader.TabIndex = 0;
            this.NameHeader.Text = "Name";
            // 
            // TransportList
            // 
            this.TransportList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TransportList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TransportList.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransportList.FormattingEnabled = true;
            this.TransportList.ItemHeight = 16;
            this.TransportList.Location = new System.Drawing.Point(0, 76);
            this.TransportList.Margin = new System.Windows.Forms.Padding(0);
            this.TransportList.Name = "TransportList";
            this.TransportList.Size = new System.Drawing.Size(470, 336);
            this.TransportList.TabIndex = 4;
            this.TransportList.SelectedIndexChanged += new System.EventHandler(this.TransportList_SelectedIndexChanged);
            this.TransportList.DoubleClick += new System.EventHandler(this.OnDoubleClick);
            // 
            // BottomTransportPanel
            // 
            this.BottomTransportPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BottomTransportPanel.Controls.Add(this.RefreshButton);
            this.BottomTransportPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomTransportPanel.Location = new System.Drawing.Point(0, 404);
            this.BottomTransportPanel.Margin = new System.Windows.Forms.Padding(0);
            this.BottomTransportPanel.Name = "BottomTransportPanel";
            this.BottomTransportPanel.Size = new System.Drawing.Size(470, 45);
            this.BottomTransportPanel.TabIndex = 3;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RefreshButton.Location = new System.Drawing.Point(380, 15);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(5);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 25);
            this.RefreshButton.TabIndex = 1;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // TopTransportPanel
            // 
            this.TopTransportPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TopTransportPanel.Controls.Add(this.RemoveButton);
            this.TopTransportPanel.Controls.Add(this.AddTransportButton);
            this.TopTransportPanel.Controls.Add(this.TransportLabel);
            this.TopTransportPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopTransportPanel.Location = new System.Drawing.Point(0, 0);
            this.TopTransportPanel.Margin = new System.Windows.Forms.Padding(0);
            this.TopTransportPanel.Name = "TopTransportPanel";
            this.TopTransportPanel.Size = new System.Drawing.Size(470, 45);
            this.TopTransportPanel.TabIndex = 1;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveButton.Location = new System.Drawing.Point(5, 8);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(5);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 25);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddTransportButton
            // 
            this.AddTransportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddTransportButton.Location = new System.Drawing.Point(390, 8);
            this.AddTransportButton.Margin = new System.Windows.Forms.Padding(5);
            this.AddTransportButton.Name = "AddTransportButton";
            this.AddTransportButton.Size = new System.Drawing.Size(75, 25);
            this.AddTransportButton.TabIndex = 2;
            this.AddTransportButton.Text = "Add";
            this.AddTransportButton.UseVisualStyleBackColor = true;
            this.AddTransportButton.Click += new System.EventHandler(this.AddTransportButton_Click);
            // 
            // TransportLabel
            // 
            this.TransportLabel.AutoSize = true;
            this.TransportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransportLabel.Location = new System.Drawing.Point(197, 13);
            this.TransportLabel.Name = "TransportLabel";
            this.TransportLabel.Size = new System.Drawing.Size(77, 20);
            this.TransportLabel.TabIndex = 0;
            this.TransportLabel.Text = "Transport";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.TransportTab);
            this.tabControl.Controls.Add(this.ResponseTableTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 40);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(944, 511);
            this.tabControl.TabIndex = 5;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // TransportTab
            // 
            this.TransportTab.Controls.Add(this.tableLayoutPanel1);
            this.TransportTab.Location = new System.Drawing.Point(4, 22);
            this.TransportTab.Name = "TransportTab";
            this.TransportTab.Padding = new System.Windows.Forms.Padding(3);
            this.TransportTab.Size = new System.Drawing.Size(936, 485);
            this.TransportTab.TabIndex = 0;
            this.TransportTab.Tag = CourseWorkClientServer.WorkerForms.TransportManagerForm.Tab.Transport;
            this.TransportTab.Text = "Transport";
            this.TransportTab.UseVisualStyleBackColor = true;
            // 
            // ResponseTableTab
            // 
            this.ResponseTableTab.Controls.Add(this.tableLayoutPanel2);
            this.ResponseTableTab.Location = new System.Drawing.Point(4, 22);
            this.ResponseTableTab.Name = "ResponseTableTab";
            this.ResponseTableTab.Padding = new System.Windows.Forms.Padding(3);
            this.ResponseTableTab.Size = new System.Drawing.Size(936, 485);
            this.ResponseTableTab.TabIndex = 1;
            this.ResponseTableTab.Tag = CourseWorkClientServer.WorkerForms.TransportManagerForm.Tab.ResponseTable;
            this.ResponseTableTab.Text = "Response table";
            this.ResponseTableTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.CentralPanel, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(930, 479);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // CentralPanel
            // 
            this.CentralPanel.Controls.Add(this.panel1);
            this.CentralPanel.Controls.Add(this.ResponseList);
            this.CentralPanel.Controls.Add(this.TopCentralPanel);
            this.CentralPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CentralPanel.Location = new System.Drawing.Point(230, 15);
            this.CentralPanel.Margin = new System.Windows.Forms.Padding(15);
            this.CentralPanel.Name = "CentralPanel";
            this.CentralPanel.Size = new System.Drawing.Size(470, 449);
            this.CentralPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DescriptionLabel);
            this.panel1.Controls.Add(this.StateLabel);
            this.panel1.Controls.Add(this.IDContractLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 31);
            this.panel1.TabIndex = 6;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionLabel.Location = new System.Drawing.Point(327, 9);
            this.DescriptionLabel.Margin = new System.Windows.Forms.Padding(5);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(79, 17);
            this.DescriptionLabel.TabIndex = 3;
            this.DescriptionLabel.Text = "Description";
            // 
            // StateLabel
            // 
            this.StateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.StateLabel.AutoSize = true;
            this.StateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StateLabel.Location = new System.Drawing.Point(105, 9);
            this.StateLabel.Margin = new System.Windows.Forms.Padding(5);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(41, 17);
            this.StateLabel.TabIndex = 1;
            this.StateLabel.Text = "State";
            // 
            // IDContractLabel
            // 
            this.IDContractLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.IDContractLabel.AutoSize = true;
            this.IDContractLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDContractLabel.Location = new System.Drawing.Point(19, 9);
            this.IDContractLabel.Margin = new System.Windows.Forms.Padding(5);
            this.IDContractLabel.Name = "IDContractLabel";
            this.IDContractLabel.Size = new System.Drawing.Size(76, 17);
            this.IDContractLabel.TabIndex = 0;
            this.IDContractLabel.Text = "ID contract";
            // 
            // ResponseList
            // 
            this.ResponseList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResponseList.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResponseList.FormattingEnabled = true;
            this.ResponseList.ItemHeight = 16;
            this.ResponseList.Location = new System.Drawing.Point(0, 81);
            this.ResponseList.Margin = new System.Windows.Forms.Padding(0);
            this.ResponseList.Name = "ResponseList";
            this.ResponseList.Size = new System.Drawing.Size(470, 368);
            this.ResponseList.TabIndex = 1;
            // 
            // TopCentralPanel
            // 
            this.TopCentralPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TopCentralPanel.Controls.Add(this.RetrunProductsButton);
            this.TopCentralPanel.Controls.Add(this.ResponseLabel);
            this.TopCentralPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopCentralPanel.Location = new System.Drawing.Point(0, 0);
            this.TopCentralPanel.Name = "TopCentralPanel";
            this.TopCentralPanel.Size = new System.Drawing.Size(470, 45);
            this.TopCentralPanel.TabIndex = 0;
            // 
            // RetrunProductsButton
            // 
            this.RetrunProductsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RetrunProductsButton.Location = new System.Drawing.Point(342, 11);
            this.RetrunProductsButton.Margin = new System.Windows.Forms.Padding(5);
            this.RetrunProductsButton.Name = "RetrunProductsButton";
            this.RetrunProductsButton.Size = new System.Drawing.Size(123, 25);
            this.RetrunProductsButton.TabIndex = 3;
            this.RetrunProductsButton.Text = "Return products";
            this.RetrunProductsButton.UseVisualStyleBackColor = true;
            this.RetrunProductsButton.Click += new System.EventHandler(this.RetrunProductsButton_Click);
            // 
            // ResponseLabel
            // 
            this.ResponseLabel.AutoSize = true;
            this.ResponseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResponseLabel.Location = new System.Drawing.Point(37, 12);
            this.ResponseLabel.Name = "ResponseLabel";
            this.ResponseLabel.Size = new System.Drawing.Size(179, 20);
            this.ResponseLabel.TabIndex = 0;
            this.ResponseLabel.Text = "Reponse products table";
            // 
            // TransportManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(944, 551);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.TopBar);
            this.Name = "TransportManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransportForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.TransportPanel.ResumeLayout(false);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.BottomTransportPanel.ResumeLayout(false);
            this.TopTransportPanel.ResumeLayout(false);
            this.TopTransportPanel.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.TransportTab.ResumeLayout(false);
            this.ResponseTableTab.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.CentralPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TopCentralPanel.ResumeLayout(false);
            this.TopCentralPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private enum Tab { Transport, ResponseTable }
        private System.Windows.Forms.Panel TopBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel TransportPanel;
        private System.Windows.Forms.Panel TopTransportPanel;
        private System.Windows.Forms.Label TransportLabel;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Panel BottomTransportPanel;
        private System.Windows.Forms.ListBox TransportList;
        private System.Windows.Forms.Button AddTransportButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage TransportTab;
        private System.Windows.Forms.TabPage ResponseTableTab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel CentralPanel;
        private System.Windows.Forms.ListBox ResponseList;
        private System.Windows.Forms.Panel TopCentralPanel;
        private System.Windows.Forms.Label ResponseLabel;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label MaxWeightHeader;
        private System.Windows.Forms.Label NameHeader;
        private System.Windows.Forms.Label PriceHeader;
        private System.Windows.Forms.Label TimeOfDeliveryHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label StateLabel;
        private System.Windows.Forms.Label IDContractLabel;
        private System.Windows.Forms.Button RetrunProductsButton;
    }
}