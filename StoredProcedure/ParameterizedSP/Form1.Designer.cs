namespace ParameterizedSP
{
    partial class Form1
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
            this.lbStoredProcedure = new System.Windows.Forms.Label();
            this.CustomerIdTextBox = new System.Windows.Forms.TextBox();
            this.GetTotalSalesButton = new System.Windows.Forms.Button();
            this.TotalSalesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbStoredProcedure
            // 
            this.lbStoredProcedure.AutoSize = true;
            this.lbStoredProcedure.Location = new System.Drawing.Point(90, 40);
            this.lbStoredProcedure.Name = "lbStoredProcedure";
            this.lbStoredProcedure.Size = new System.Drawing.Size(87, 17);
            this.lbStoredProcedure.TabIndex = 0;
            this.lbStoredProcedure.Text = "Customer Id:";
            // 
            // CustomerIdTextBox
            // 
            this.CustomerIdTextBox.Location = new System.Drawing.Point(200, 37);
            this.CustomerIdTextBox.Name = "CustomerIdTextBox";
            this.CustomerIdTextBox.Size = new System.Drawing.Size(357, 22);
            this.CustomerIdTextBox.TabIndex = 1;
            this.CustomerIdTextBox.Text = "To controle";
            // 
            // GetTotalSalesButton
            // 
            this.GetTotalSalesButton.Location = new System.Drawing.Point(93, 113);
            this.GetTotalSalesButton.Name = "GetTotalSalesButton";
            this.GetTotalSalesButton.Size = new System.Drawing.Size(131, 23);
            this.GetTotalSalesButton.TabIndex = 2;
            this.GetTotalSalesButton.Text = "Get Total Sales";
            this.GetTotalSalesButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GetTotalSalesButton.UseVisualStyleBackColor = true;
            this.GetTotalSalesButton.Click += new System.EventHandler(this.GetTotalSalesButton_Click);
            // 
            // TotalSalesLabel
            // 
            this.TotalSalesLabel.AutoSize = true;
            this.TotalSalesLabel.Location = new System.Drawing.Point(90, 198);
            this.TotalSalesLabel.Name = "TotalSalesLabel";
            this.TotalSalesLabel.Size = new System.Drawing.Size(111, 17);
            this.TotalSalesLabel.TabIndex = 3;
            this.TotalSalesLabel.Text = "Total Sale Label";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TotalSalesLabel);
            this.Controls.Add(this.GetTotalSalesButton);
            this.Controls.Add(this.CustomerIdTextBox);
            this.Controls.Add(this.lbStoredProcedure);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbStoredProcedure;
        private System.Windows.Forms.TextBox CustomerIdTextBox;
        private System.Windows.Forms.Button GetTotalSalesButton;
        private System.Windows.Forms.Label TotalSalesLabel;
    }
}

