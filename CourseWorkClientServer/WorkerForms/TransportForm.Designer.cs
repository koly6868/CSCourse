namespace CourseWorkClientServer.WorkerForms
{
    partial class TransportFrom
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
            this.NameTransportBox = new System.Windows.Forms.TextBox();
            this.NameTransportLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TransportPanel = new System.Windows.Forms.Panel();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.TimeOfDeliveryLabel = new System.Windows.Forms.Label();
            this.TimeOfDeliveryBox = new System.Windows.Forms.TextBox();
            this.MaxWeightLabel = new System.Windows.Forms.Label();
            this.MaxWeightBox = new System.Windows.Forms.TextBox();
            this.NewTransportLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.TransportPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameTransportBox
            // 
            this.NameTransportBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTransportBox.Location = new System.Drawing.Point(154, 108);
            this.NameTransportBox.Margin = new System.Windows.Forms.Padding(15);
            this.NameTransportBox.Name = "NameTransportBox";
            this.NameTransportBox.Size = new System.Drawing.Size(176, 23);
            this.NameTransportBox.TabIndex = 0;
            // 
            // NameTransportLabel
            // 
            this.NameTransportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTransportLabel.Location = new System.Drawing.Point(15, 108);
            this.NameTransportLabel.Margin = new System.Windows.Forms.Padding(15);
            this.NameTransportLabel.Name = "NameTransportLabel";
            this.NameTransportLabel.Size = new System.Drawing.Size(51, 21);
            this.NameTransportLabel.TabIndex = 1;
            this.NameTransportLabel.Text = "Name";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.TransportPanel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(944, 551);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // TransportPanel
            // 
            this.TransportPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TransportPanel.Controls.Add(this.ErrorLabel);
            this.TransportPanel.Controls.Add(this.SaveButton);
            this.TransportPanel.Controls.Add(this.PriceLabel);
            this.TransportPanel.Controls.Add(this.PriceBox);
            this.TransportPanel.Controls.Add(this.TimeOfDeliveryLabel);
            this.TransportPanel.Controls.Add(this.TimeOfDeliveryBox);
            this.TransportPanel.Controls.Add(this.MaxWeightLabel);
            this.TransportPanel.Controls.Add(this.MaxWeightBox);
            this.TransportPanel.Controls.Add(this.NewTransportLabel);
            this.TransportPanel.Controls.Add(this.NameTransportLabel);
            this.TransportPanel.Controls.Add(this.NameTransportBox);
            this.TransportPanel.Location = new System.Drawing.Point(287, 15);
            this.TransportPanel.Margin = new System.Windows.Forms.Padding(15);
            this.TransportPanel.Name = "TransportPanel";
            this.TransportPanel.Size = new System.Drawing.Size(370, 521);
            this.TransportPanel.TabIndex = 2;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.LightPink;
            this.ErrorLabel.Location = new System.Drawing.Point(136, 430);
            this.ErrorLabel.Margin = new System.Windows.Forms.Padding(15);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(109, 21);
            this.ErrorLabel.TabIndex = 12;
            this.ErrorLabel.Text = "Incorrect data";
            this.ErrorLabel.Visible = false;
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(147, 481);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(15);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 25);
            this.SaveButton.TabIndex = 11;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // PriceLabel
            // 
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceLabel.Location = new System.Drawing.Point(15, 321);
            this.PriceLabel.Margin = new System.Windows.Forms.Padding(15);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(109, 21);
            this.PriceLabel.TabIndex = 8;
            this.PriceLabel.Text = "Price";
            // 
            // PriceBox
            // 
            this.PriceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceBox.Location = new System.Drawing.Point(154, 321);
            this.PriceBox.Margin = new System.Windows.Forms.Padding(15);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(176, 23);
            this.PriceBox.TabIndex = 7;
            // 
            // TimeOfDeliveryLabel
            // 
            this.TimeOfDeliveryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeOfDeliveryLabel.Location = new System.Drawing.Point(15, 268);
            this.TimeOfDeliveryLabel.Margin = new System.Windows.Forms.Padding(15);
            this.TimeOfDeliveryLabel.Name = "TimeOfDeliveryLabel";
            this.TimeOfDeliveryLabel.Size = new System.Drawing.Size(109, 21);
            this.TimeOfDeliveryLabel.TabIndex = 6;
            this.TimeOfDeliveryLabel.Text = "Time of delivery";
            // 
            // TimeOfDeliveryBox
            // 
            this.TimeOfDeliveryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeOfDeliveryBox.Location = new System.Drawing.Point(154, 268);
            this.TimeOfDeliveryBox.Margin = new System.Windows.Forms.Padding(15);
            this.TimeOfDeliveryBox.Name = "TimeOfDeliveryBox";
            this.TimeOfDeliveryBox.Size = new System.Drawing.Size(176, 23);
            this.TimeOfDeliveryBox.TabIndex = 5;
            // 
            // MaxWeightLabel
            // 
            this.MaxWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaxWeightLabel.Location = new System.Drawing.Point(15, 215);
            this.MaxWeightLabel.Margin = new System.Windows.Forms.Padding(15);
            this.MaxWeightLabel.Name = "MaxWeightLabel";
            this.MaxWeightLabel.Size = new System.Drawing.Size(82, 21);
            this.MaxWeightLabel.TabIndex = 4;
            this.MaxWeightLabel.Text = "Max weight";
            // 
            // MaxWeightBox
            // 
            this.MaxWeightBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaxWeightBox.Location = new System.Drawing.Point(154, 215);
            this.MaxWeightBox.Margin = new System.Windows.Forms.Padding(15);
            this.MaxWeightBox.Name = "MaxWeightBox";
            this.MaxWeightBox.Size = new System.Drawing.Size(176, 23);
            this.MaxWeightBox.TabIndex = 3;
            // 
            // NewTransportLabel
            // 
            this.NewTransportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewTransportLabel.Location = new System.Drawing.Point(135, 15);
            this.NewTransportLabel.Margin = new System.Windows.Forms.Padding(15);
            this.NewTransportLabel.Name = "NewTransportLabel";
            this.NewTransportLabel.Size = new System.Drawing.Size(100, 25);
            this.NewTransportLabel.TabIndex = 2;
            this.NewTransportLabel.Text = "Transport";
            // 
            // TransportFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(944, 551);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TransportFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Transport";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.TransportPanel.ResumeLayout(false);
            this.TransportPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox NameTransportBox;
        private System.Windows.Forms.Label NameTransportLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel TransportPanel;
        private System.Windows.Forms.Label NewTransportLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.Label TimeOfDeliveryLabel;
        private System.Windows.Forms.TextBox TimeOfDeliveryBox;
        private System.Windows.Forms.Label MaxWeightLabel;
        private System.Windows.Forms.TextBox MaxWeightBox;
        private System.Windows.Forms.Label ErrorLabel;
    }
}