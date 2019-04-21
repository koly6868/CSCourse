namespace CourseWorkClientServer.AccountantForms
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
            this.TopOrderPanel = new System.Windows.Forms.Panel();
            this.SortButton = new System.Windows.Forms.ComboBox();
            this.DeleteOrderButton = new System.Windows.Forms.Button();
            this.NewOrderButton = new System.Windows.Forms.Button();
            this.Contracts = new System.Windows.Forms.ListView();
            this.ContractsID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ContractsFullPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ContractsDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ContractsTransport = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrdersScreen = new System.Windows.Forms.TableLayoutPanel();
            this.ProductPanel = new System.Windows.Forms.Panel();
            this.TopProductPanel = new System.Windows.Forms.Panel();
            this.ProductPanelLabel = new System.Windows.Forms.Label();
            this.Products = new System.Windows.Forms.ListView();
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductColoer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductWeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderPanel.SuspendLayout();
            this.TopOrderPanel.SuspendLayout();
            this.OrdersScreen.SuspendLayout();
            this.ProductPanel.SuspendLayout();
            this.TopProductPanel.SuspendLayout();
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
            this.OrderPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.OrderPanel.Controls.Add(this.TopOrderPanel);
            this.OrderPanel.Controls.Add(this.Contracts);
            this.OrderPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.OrderPanel.Location = new System.Drawing.Point(15, 15);
            this.OrderPanel.Margin = new System.Windows.Forms.Padding(15);
            this.OrderPanel.MinimumSize = new System.Drawing.Size(300, 430);
            this.OrderPanel.Name = "OrderPanel";
            this.OrderPanel.Size = new System.Drawing.Size(370, 481);
            this.OrderPanel.TabIndex = 0;
            // 
            // TopOrderPanel
            // 
            this.TopOrderPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TopOrderPanel.Controls.Add(this.SortButton);
            this.TopOrderPanel.Controls.Add(this.DeleteOrderButton);
            this.TopOrderPanel.Controls.Add(this.NewOrderButton);
            this.TopOrderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopOrderPanel.Location = new System.Drawing.Point(0, 0);
            this.TopOrderPanel.Margin = new System.Windows.Forms.Padding(0);
            this.TopOrderPanel.Name = "TopOrderPanel";
            this.TopOrderPanel.Size = new System.Drawing.Size(370, 45);
            this.TopOrderPanel.TabIndex = 1;
            // 
            // SortButton
            // 
            this.SortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortButton.FormattingEnabled = true;
            this.SortButton.Items.AddRange(new object[] {
            "date",
            "ID"});
            this.SortButton.Location = new System.Drawing.Point(10, 11);
            this.SortButton.Margin = new System.Windows.Forms.Padding(10);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(68, 24);
            this.SortButton.TabIndex = 2;
            this.SortButton.SelectedIndexChanged += new System.EventHandler(this.SortButton_SelectedIndexChanged);
            // 
            // DeleteOrderButton
            // 
            this.DeleteOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteOrderButton.Location = new System.Drawing.Point(140, 10);
            this.DeleteOrderButton.Margin = new System.Windows.Forms.Padding(10);
            this.DeleteOrderButton.Name = "DeleteOrderButton";
            this.DeleteOrderButton.Size = new System.Drawing.Size(99, 25);
            this.DeleteOrderButton.TabIndex = 1;
            this.DeleteOrderButton.Text = "Delete Order";
            this.DeleteOrderButton.UseVisualStyleBackColor = true;
            this.DeleteOrderButton.Click += new System.EventHandler(this.DeleteOrderButton_Click);
            // 
            // NewOrderButton
            // 
            this.NewOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewOrderButton.Location = new System.Drawing.Point(259, 9);
            this.NewOrderButton.Margin = new System.Windows.Forms.Padding(10);
            this.NewOrderButton.Name = "NewOrderButton";
            this.NewOrderButton.Size = new System.Drawing.Size(101, 25);
            this.NewOrderButton.TabIndex = 0;
            this.NewOrderButton.Text = "New Oreder";
            this.NewOrderButton.UseVisualStyleBackColor = true;
            this.NewOrderButton.Click += new System.EventHandler(this.NewOrderButton_Click);
            // 
            // Contracts
            // 
            this.Contracts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Contracts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ContractsID,
            this.ContractsFullPrice,
            this.ContractsDate,
            this.ContractsTransport});
            this.Contracts.Location = new System.Drawing.Point(0, 44);
            this.Contracts.Margin = new System.Windows.Forms.Padding(0);
            this.Contracts.Name = "Contracts";
            this.Contracts.Size = new System.Drawing.Size(370, 437);
            this.Contracts.TabIndex = 0;
            this.Contracts.UseCompatibleStateImageBehavior = false;
            this.Contracts.View = System.Windows.Forms.View.Details;
            this.Contracts.SelectedIndexChanged += new System.EventHandler(this.Contracts_SelectedIndexChanged);
            // 
            // ContractsID
            // 
            this.ContractsID.Text = "ID";
            // 
            // ContractsFullPrice
            // 
            this.ContractsFullPrice.Text = "FullPrice";
            // 
            // ContractsDate
            // 
            this.ContractsDate.Text = "Date";
            // 
            // ContractsTransport
            // 
            this.ContractsTransport.Text = "Transport";
            // 
            // OrdersScreen
            // 
            this.OrdersScreen.ColumnCount = 3;
            this.OrdersScreen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.OrdersScreen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.OrdersScreen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.OrdersScreen.Controls.Add(this.OrderPanel, 0, 0);
            this.OrdersScreen.Controls.Add(this.ProductPanel, 1, 0);
            this.OrdersScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrdersScreen.Location = new System.Drawing.Point(0, 40);
            this.OrdersScreen.Name = "OrdersScreen";
            this.OrdersScreen.RowCount = 1;
            this.OrdersScreen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.OrdersScreen.Size = new System.Drawing.Size(944, 511);
            this.OrdersScreen.TabIndex = 0;
            // 
            // ProductPanel
            // 
            this.ProductPanel.Controls.Add(this.TopProductPanel);
            this.ProductPanel.Controls.Add(this.Products);
            this.ProductPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ProductPanel.Location = new System.Drawing.Point(415, 15);
            this.ProductPanel.Margin = new System.Windows.Forms.Padding(15);
            this.ProductPanel.Name = "ProductPanel";
            this.ProductPanel.Size = new System.Drawing.Size(370, 481);
            this.ProductPanel.TabIndex = 2;
            // 
            // TopProductPanel
            // 
            this.TopProductPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TopProductPanel.Controls.Add(this.ProductPanelLabel);
            this.TopProductPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopProductPanel.Location = new System.Drawing.Point(0, 0);
            this.TopProductPanel.Margin = new System.Windows.Forms.Padding(0);
            this.TopProductPanel.Name = "TopProductPanel";
            this.TopProductPanel.Size = new System.Drawing.Size(370, 45);
            this.TopProductPanel.TabIndex = 0;
            // 
            // ProductPanelLabel
            // 
            this.ProductPanelLabel.AutoSize = true;
            this.ProductPanelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductPanelLabel.Location = new System.Drawing.Point(153, 11);
            this.ProductPanelLabel.Name = "ProductPanelLabel";
            this.ProductPanelLabel.Size = new System.Drawing.Size(72, 20);
            this.ProductPanelLabel.TabIndex = 0;
            this.ProductPanelLabel.Text = "Products";
            // 
            // Products
            // 
            this.Products.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Products.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductName,
            this.ProductColoer,
            this.ProductWeight,
            this.ProductSize,
            this.ProductCount});
            this.Products.Location = new System.Drawing.Point(0, 44);
            this.Products.Margin = new System.Windows.Forms.Padding(0);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(370, 437);
            this.Products.TabIndex = 1;
            this.Products.UseCompatibleStateImageBehavior = false;
            this.Products.View = System.Windows.Forms.View.Details;
            // 
            // ProductName
            // 
            this.ProductName.Text = "Name";
            this.ProductName.Width = 67;
            // 
            // ProductColoer
            // 
            this.ProductColoer.Text = "Color";
            // 
            // ProductWeight
            // 
            this.ProductWeight.Text = "Weight";
            this.ProductWeight.Width = 55;
            // 
            // ProductSize
            // 
            this.ProductSize.Text = "Size";
            this.ProductSize.Width = 82;
            // 
            // ProductCount
            // 
            this.ProductCount.Text = "Count";
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(944, 551);
            this.Controls.Add(this.OrdersScreen);
            this.Controls.Add(this.TopBar);
            this.Name = "Orders";
            this.Text = "Orders";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClosing);
            this.Load += new System.EventHandler(this.Orders_Load_1);
            this.OrderPanel.ResumeLayout(false);
            this.TopOrderPanel.ResumeLayout(false);
            this.OrdersScreen.ResumeLayout(false);
            this.ProductPanel.ResumeLayout(false);
            this.TopProductPanel.ResumeLayout(false);
            this.TopProductPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopBar;
        private System.Windows.Forms.Panel OrderPanel;
        private System.Windows.Forms.Panel TopOrderPanel;
        private System.Windows.Forms.ListView Contracts;
        private System.Windows.Forms.TableLayoutPanel OrdersScreen;
        private System.Windows.Forms.Button NewOrderButton;
        private System.Windows.Forms.Button DeleteOrderButton;
        private System.Windows.Forms.ComboBox SortButton;
        private System.Windows.Forms.ColumnHeader ContractsID;
        private System.Windows.Forms.ColumnHeader ContractsFullPrice;
        private System.Windows.Forms.ColumnHeader ContractsDate;
        private System.Windows.Forms.ColumnHeader ContractsTransport;
        private System.Windows.Forms.ListView Products;
        private System.Windows.Forms.ColumnHeader ProductName;
        private System.Windows.Forms.ColumnHeader ProductColoer;
        private System.Windows.Forms.ColumnHeader ProductWeight;
        private System.Windows.Forms.ColumnHeader ProductSize;
        private System.Windows.Forms.Panel ProductPanel;
        private System.Windows.Forms.Panel TopProductPanel;
        private System.Windows.Forms.Label ProductPanelLabel;
        private System.Windows.Forms.ColumnHeader ProductCount;
    }
}