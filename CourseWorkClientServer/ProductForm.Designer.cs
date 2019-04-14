﻿namespace CourseWorkClientServer
{
    partial class ProductForm
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
            this.CartPanel = new System.Windows.Forms.Panel();
            this.CartList = new System.Windows.Forms.ListView();
            this.CartName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CartColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CartWeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CartSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CartCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CartTopPaanel = new System.Windows.Forms.Panel();
            this.CartLabel = new System.Windows.Forms.Label();
            this.ProductsPanel = new System.Windows.Forms.Panel();
            this.Products = new System.Windows.Forms.ListView();
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductColoer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductWeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TopProductsPanel = new System.Windows.Forms.Panel();
            this.ProductsLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.CartPanel.SuspendLayout();
            this.CartTopPaanel.SuspendLayout();
            this.ProductsPanel.SuspendLayout();
            this.TopProductsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 360F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 360F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.CartPanel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ProductsPanel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(944, 551);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // CartPanel
            // 
            this.CartPanel.Controls.Add(this.CartList);
            this.CartPanel.Controls.Add(this.CartTopPaanel);
            this.CartPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CartPanel.Location = new System.Drawing.Point(375, 15);
            this.CartPanel.Margin = new System.Windows.Forms.Padding(15);
            this.CartPanel.Name = "CartPanel";
            this.CartPanel.Size = new System.Drawing.Size(330, 521);
            this.CartPanel.TabIndex = 1;
            // 
            // CartList
            // 
            this.CartList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.CartList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CartName,
            this.CartColor,
            this.CartWeight,
            this.CartSize,
            this.CartCount});
            this.CartList.Location = new System.Drawing.Point(0, 45);
            this.CartList.Margin = new System.Windows.Forms.Padding(0);
            this.CartList.Name = "CartList";
            this.CartList.Size = new System.Drawing.Size(330, 476);
            this.CartList.TabIndex = 2;
            this.CartList.UseCompatibleStateImageBehavior = false;
            this.CartList.View = System.Windows.Forms.View.Details;
            this.CartList.DoubleClick += new System.EventHandler(this.CartList_DoubleClick);
            // 
            // CartName
            // 
            this.CartName.Text = "Name";
            this.CartName.Width = 67;
            // 
            // CartColor
            // 
            this.CartColor.Text = "Color";
            this.CartColor.Width = 46;
            // 
            // CartWeight
            // 
            this.CartWeight.Text = "Weight";
            this.CartWeight.Width = 55;
            // 
            // CartSize
            // 
            this.CartSize.Text = "Size";
            this.CartSize.Width = 81;
            // 
            // CartCount
            // 
            this.CartCount.Text = "Count";
            // 
            // CartTopPaanel
            // 
            this.CartTopPaanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CartTopPaanel.Controls.Add(this.CartLabel);
            this.CartTopPaanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CartTopPaanel.Location = new System.Drawing.Point(0, 0);
            this.CartTopPaanel.Margin = new System.Windows.Forms.Padding(0);
            this.CartTopPaanel.Name = "CartTopPaanel";
            this.CartTopPaanel.Size = new System.Drawing.Size(330, 45);
            this.CartTopPaanel.TabIndex = 0;
            // 
            // CartLabel
            // 
            this.CartLabel.AutoSize = true;
            this.CartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CartLabel.Location = new System.Drawing.Point(135, 13);
            this.CartLabel.Name = "CartLabel";
            this.CartLabel.Size = new System.Drawing.Size(39, 20);
            this.CartLabel.TabIndex = 0;
            this.CartLabel.Text = "Cart";
            // 
            // ProductsPanel
            // 
            this.ProductsPanel.Controls.Add(this.Products);
            this.ProductsPanel.Controls.Add(this.TopProductsPanel);
            this.ProductsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductsPanel.Location = new System.Drawing.Point(15, 15);
            this.ProductsPanel.Margin = new System.Windows.Forms.Padding(15);
            this.ProductsPanel.Name = "ProductsPanel";
            this.ProductsPanel.Size = new System.Drawing.Size(330, 521);
            this.ProductsPanel.TabIndex = 0;
            // 
            // Products
            // 
            this.Products.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Products.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductName,
            this.ProductColoer,
            this.ProductWeight,
            this.ProductSize});
            this.Products.Location = new System.Drawing.Point(0, 45);
            this.Products.Margin = new System.Windows.Forms.Padding(0);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(330, 476);
            this.Products.TabIndex = 2;
            this.Products.UseCompatibleStateImageBehavior = false;
            this.Products.View = System.Windows.Forms.View.Details;
            this.Products.DoubleClick += new System.EventHandler(this.Products_DoubleClick);
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
            this.ProductSize.Width = 132;
            // 
            // TopProductsPanel
            // 
            this.TopProductsPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TopProductsPanel.Controls.Add(this.ProductsLabel);
            this.TopProductsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopProductsPanel.Location = new System.Drawing.Point(0, 0);
            this.TopProductsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.TopProductsPanel.Name = "TopProductsPanel";
            this.TopProductsPanel.Size = new System.Drawing.Size(330, 45);
            this.TopProductsPanel.TabIndex = 0;
            // 
            // ProductsLabel
            // 
            this.ProductsLabel.AutoSize = true;
            this.ProductsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductsLabel.Location = new System.Drawing.Point(124, 13);
            this.ProductsLabel.Name = "ProductsLabel";
            this.ProductsLabel.Size = new System.Drawing.Size(72, 20);
            this.ProductsLabel.TabIndex = 0;
            this.ProductsLabel.Text = "Products";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(944, 551);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.CartPanel.ResumeLayout(false);
            this.CartTopPaanel.ResumeLayout(false);
            this.CartTopPaanel.PerformLayout();
            this.ProductsPanel.ResumeLayout(false);
            this.TopProductsPanel.ResumeLayout(false);
            this.TopProductsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel ProductsPanel;
        private System.Windows.Forms.Panel TopProductsPanel;
        private System.Windows.Forms.Label ProductsLabel;
        private System.Windows.Forms.ListView Products;
        private System.Windows.Forms.ColumnHeader ProductName;
        private System.Windows.Forms.ColumnHeader ProductColoer;
        private System.Windows.Forms.ColumnHeader ProductWeight;
        private System.Windows.Forms.ColumnHeader ProductSize;
        private System.Windows.Forms.Panel CartPanel;
        private System.Windows.Forms.ListView CartList;
        private System.Windows.Forms.ColumnHeader CartName;
        private System.Windows.Forms.ColumnHeader CartColor;
        private System.Windows.Forms.ColumnHeader CartWeight;
        private System.Windows.Forms.ColumnHeader CartSize;
        private System.Windows.Forms.Panel CartTopPaanel;
        private System.Windows.Forms.Label CartLabel;
        private System.Windows.Forms.ColumnHeader CartCount;
    }
}