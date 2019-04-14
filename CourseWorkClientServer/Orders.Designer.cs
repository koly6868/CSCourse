namespace CourseWorkClientServer
{
    partial class Orders
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
            this.OrderPanel = new System.Windows.Forms.Panel();
            this.BottomOrderPanel = new System.Windows.Forms.Panel();
            this.TopOrderPanel = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.DeleteOrderButton = new System.Windows.Forms.Button();
            this.NewOrderButton = new System.Windows.Forms.Button();
            this.Contracts = new System.Windows.Forms.ListView();
            this.Tab = new System.Windows.Forms.TabControl();
            this.OrdersTab = new System.Windows.Forms.TabPage();
            this.OrdersScreen = new System.Windows.Forms.TableLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.OrderPanel.SuspendLayout();
            this.TopOrderPanel.SuspendLayout();
            this.Tab.SuspendLayout();
            this.OrdersTab.SuspendLayout();
            this.OrdersScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.MaximumSize = new System.Drawing.Size(0, 60);
            this.TopBar.MinimumSize = new System.Drawing.Size(960, 40);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(960, 40);
            this.TopBar.TabIndex = 2;
            // 
            // OrderPanel
            // 
            this.OrderPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OrderPanel.Controls.Add(this.BottomOrderPanel);
            this.OrderPanel.Controls.Add(this.TopOrderPanel);
            this.OrderPanel.Controls.Add(this.Contracts);
            this.OrderPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.OrderPanel.Location = new System.Drawing.Point(15, 15);
            this.OrderPanel.Margin = new System.Windows.Forms.Padding(15);
            this.OrderPanel.MaximumSize = new System.Drawing.Size(300, 0);
            this.OrderPanel.MinimumSize = new System.Drawing.Size(300, 430);
            this.OrderPanel.Name = "OrderPanel";
            this.OrderPanel.Size = new System.Drawing.Size(300, 449);
            this.OrderPanel.TabIndex = 0;
            // 
            // BottomOrderPanel
            // 
            this.BottomOrderPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomOrderPanel.Location = new System.Drawing.Point(0, 410);
            this.BottomOrderPanel.Name = "BottomOrderPanel";
            this.BottomOrderPanel.Size = new System.Drawing.Size(300, 39);
            this.BottomOrderPanel.TabIndex = 2;
            // 
            // TopOrderPanel
            // 
            this.TopOrderPanel.Controls.Add(this.comboBox1);
            this.TopOrderPanel.Controls.Add(this.DeleteOrderButton);
            this.TopOrderPanel.Controls.Add(this.NewOrderButton);
            this.TopOrderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopOrderPanel.Location = new System.Drawing.Point(0, 0);
            this.TopOrderPanel.Name = "TopOrderPanel";
            this.TopOrderPanel.Size = new System.Drawing.Size(300, 45);
            this.TopOrderPanel.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(10, 10);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(68, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // DeleteOrderButton
            // 
            this.DeleteOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteOrderButton.Location = new System.Drawing.Point(84, 10);
            this.DeleteOrderButton.Margin = new System.Windows.Forms.Padding(10);
            this.DeleteOrderButton.Name = "DeleteOrderButton";
            this.DeleteOrderButton.Size = new System.Drawing.Size(99, 25);
            this.DeleteOrderButton.TabIndex = 1;
            this.DeleteOrderButton.Text = "Delete Order";
            this.DeleteOrderButton.UseVisualStyleBackColor = true;
            // 
            // NewOrderButton
            // 
            this.NewOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewOrderButton.Location = new System.Drawing.Point(189, 10);
            this.NewOrderButton.Margin = new System.Windows.Forms.Padding(10);
            this.NewOrderButton.Name = "NewOrderButton";
            this.NewOrderButton.Size = new System.Drawing.Size(101, 25);
            this.NewOrderButton.TabIndex = 0;
            this.NewOrderButton.Text = "New Oreder";
            this.NewOrderButton.UseVisualStyleBackColor = true;
            // 
            // Contracts
            // 
            this.Contracts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contracts.Location = new System.Drawing.Point(0, 0);
            this.Contracts.Name = "Contracts";
            this.Contracts.Size = new System.Drawing.Size(300, 449);
            this.Contracts.TabIndex = 0;
            this.Contracts.UseCompatibleStateImageBehavior = false;
            this.Contracts.SelectedIndexChanged += new System.EventHandler(this.Contracts_SelectedIndexChanged);
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.OrdersTab);
            this.Tab.Controls.Add(this.tabPage2);
            this.Tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tab.HotTrack = true;
            this.Tab.Location = new System.Drawing.Point(0, 40);
            this.Tab.Multiline = true;
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(944, 511);
            this.Tab.TabIndex = 4;
            // 
            // OrdersTab
            // 
            this.OrdersTab.Controls.Add(this.OrdersScreen);
            this.OrdersTab.Location = new System.Drawing.Point(4, 22);
            this.OrdersTab.Name = "OrdersTab";
            this.OrdersTab.Padding = new System.Windows.Forms.Padding(3);
            this.OrdersTab.Size = new System.Drawing.Size(936, 485);
            this.OrdersTab.TabIndex = 0;
            this.OrdersTab.Text = "Orders";
            this.OrdersTab.UseVisualStyleBackColor = true;
            // 
            // OrdersScreen
            // 
            this.OrdersScreen.ColumnCount = 2;
            this.OrdersScreen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.80645F));
            this.OrdersScreen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.19355F));
            this.OrdersScreen.Controls.Add(this.OrderPanel, 0, 0);
            this.OrdersScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrdersScreen.Location = new System.Drawing.Point(3, 3);
            this.OrdersScreen.Name = "OrdersScreen";
            this.OrdersScreen.RowCount = 1;
            this.OrdersScreen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OrdersScreen.Size = new System.Drawing.Size(930, 479);
            this.OrdersScreen.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(936, 485);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 551);
            this.Controls.Add(this.Tab);
            this.Controls.Add(this.TopBar);
            this.Name = "Orders";
            this.Text = "Orders";
            this.OrderPanel.ResumeLayout(false);
            this.TopOrderPanel.ResumeLayout(false);
            this.Tab.ResumeLayout(false);
            this.OrdersTab.ResumeLayout(false);
            this.OrdersScreen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopBar;
        private System.Windows.Forms.Panel OrderPanel;
        private System.Windows.Forms.Panel BottomOrderPanel;
        private System.Windows.Forms.Panel TopOrderPanel;
        private System.Windows.Forms.ListView Contracts;
        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.TabPage OrdersTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel OrdersScreen;
        private System.Windows.Forms.Button NewOrderButton;
        private System.Windows.Forms.Button DeleteOrderButton;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}