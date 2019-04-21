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
            this.TransportList = new System.Windows.Forms.ListBox();
            this.BottomTransportPanel = new System.Windows.Forms.Panel();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.TopTransportPanel = new System.Windows.Forms.Panel();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddTransportButton = new System.Windows.Forms.Button();
            this.TransportLabel = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.TransportPanel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(944, 511);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // TransportPanel
            // 
            this.TransportPanel.Controls.Add(this.TransportList);
            this.TransportPanel.Controls.Add(this.BottomTransportPanel);
            this.TransportPanel.Controls.Add(this.TopTransportPanel);
            this.TransportPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TransportPanel.Location = new System.Drawing.Point(311, 15);
            this.TransportPanel.Margin = new System.Windows.Forms.Padding(15);
            this.TransportPanel.Name = "TransportPanel";
            this.TransportPanel.Size = new System.Drawing.Size(325, 484);
            this.TransportPanel.TabIndex = 0;
            // 
            // TransportList
            // 
            this.TransportList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TransportList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TransportList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransportList.FormattingEnabled = true;
            this.TransportList.ItemHeight = 16;
            this.TransportList.Location = new System.Drawing.Point(0, 45);
            this.TransportList.Margin = new System.Windows.Forms.Padding(0);
            this.TransportList.Name = "TransportList";
            this.TransportList.Size = new System.Drawing.Size(325, 400);
            this.TransportList.TabIndex = 4;
            this.TransportList.SelectedIndexChanged += new System.EventHandler(this.TransportList_SelectedIndexChanged);
            this.TransportList.DoubleClick += new System.EventHandler(this.OnDoubleClick);
            // 
            // BottomTransportPanel
            // 
            this.BottomTransportPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BottomTransportPanel.Controls.Add(this.RefreshButton);
            this.BottomTransportPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomTransportPanel.Location = new System.Drawing.Point(0, 439);
            this.BottomTransportPanel.Margin = new System.Windows.Forms.Padding(0);
            this.BottomTransportPanel.Name = "BottomTransportPanel";
            this.BottomTransportPanel.Size = new System.Drawing.Size(325, 45);
            this.BottomTransportPanel.TabIndex = 3;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RefreshButton.Location = new System.Drawing.Point(245, 15);
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
            this.TopTransportPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TopTransportPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TopTransportPanel.Controls.Add(this.RemoveButton);
            this.TopTransportPanel.Controls.Add(this.AddTransportButton);
            this.TopTransportPanel.Controls.Add(this.TransportLabel);
            this.TopTransportPanel.Location = new System.Drawing.Point(0, 0);
            this.TopTransportPanel.Margin = new System.Windows.Forms.Padding(0);
            this.TopTransportPanel.Name = "TopTransportPanel";
            this.TopTransportPanel.Size = new System.Drawing.Size(325, 45);
            this.TopTransportPanel.TabIndex = 1;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveButton.Location = new System.Drawing.Point(5, 12);
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
            this.AddTransportButton.Location = new System.Drawing.Point(234, 12);
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
            this.TransportLabel.Location = new System.Drawing.Point(124, 13);
            this.TransportLabel.Name = "TransportLabel";
            this.TransportLabel.Size = new System.Drawing.Size(77, 20);
            this.TransportLabel.TabIndex = 0;
            this.TransportLabel.Text = "Transport";
            // 
            // TransportManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(944, 551);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.TopBar);
            this.Name = "TransportManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransportForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.TransportPanel.ResumeLayout(false);
            this.BottomTransportPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Panel BottomTransportPanel;
        private System.Windows.Forms.ListBox TransportList;
        private System.Windows.Forms.Button AddTransportButton;
        private System.Windows.Forms.Button RemoveButton;
    }
}