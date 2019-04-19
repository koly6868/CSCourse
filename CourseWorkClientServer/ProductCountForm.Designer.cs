namespace CourseWorkClientServer
{
    partial class ProductCountForm
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
            this.CountBox = new System.Windows.Forms.TextBox();
            this.CountLabel = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CountBox
            // 
            this.CountBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountBox.Location = new System.Drawing.Point(99, 24);
            this.CountBox.Margin = new System.Windows.Forms.Padding(15);
            this.CountBox.Name = "CountBox";
            this.CountBox.Size = new System.Drawing.Size(160, 23);
            this.CountBox.TabIndex = 0;
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountLabel.Location = new System.Drawing.Point(24, 24);
            this.CountLabel.Margin = new System.Windows.Forms.Padding(15);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(45, 17);
            this.CountLabel.TabIndex = 1;
            this.CountLabel.Text = "Count";
            // 
            // OkButton
            // 
            this.OkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OkButton.Location = new System.Drawing.Point(100, 127);
            this.OkButton.Margin = new System.Windows.Forms.Padding(0);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(100, 25);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // PriceBox
            // 
            this.PriceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceBox.Location = new System.Drawing.Point(99, 74);
            this.PriceBox.Margin = new System.Windows.Forms.Padding(15);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(160, 23);
            this.PriceBox.TabIndex = 3;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceLabel.Location = new System.Drawing.Point(29, 77);
            this.PriceLabel.Margin = new System.Windows.Forms.Padding(15);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(40, 17);
            this.PriceLabel.TabIndex = 4;
            this.PriceLabel.Text = "Price";
            // 
            // ProductCountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.CountBox);
            this.MinimumSize = new System.Drawing.Size(200, 150);
            this.Name = "ProductCountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductCountForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CountBox;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.Label PriceLabel;
    }
}