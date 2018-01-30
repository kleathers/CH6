namespace LB7
{
    partial class ReservationForm
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
            this.lblNightlyRate = new System.Windows.Forms.Label();
            this.lblNightlyRateHeader = new System.Windows.Forms.Label();
            this.txtNightsStayed = new System.Windows.Forms.TextBox();
            this.lblNightsStayed = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblTotalCostHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNightlyRate
            // 
            this.lblNightlyRate.AutoSize = true;
            this.lblNightlyRate.Location = new System.Drawing.Point(223, 32);
            this.lblNightlyRate.Name = "lblNightlyRate";
            this.lblNightlyRate.Size = new System.Drawing.Size(23, 17);
            this.lblNightlyRate.TabIndex = 4;
            this.lblNightlyRate.Text = "---";
            // 
            // lblNightlyRateHeader
            // 
            this.lblNightlyRateHeader.AutoSize = true;
            this.lblNightlyRateHeader.Location = new System.Drawing.Point(223, 11);
            this.lblNightlyRateHeader.Name = "lblNightlyRateHeader";
            this.lblNightlyRateHeader.Size = new System.Drawing.Size(85, 17);
            this.lblNightlyRateHeader.TabIndex = 3;
            this.lblNightlyRateHeader.Text = "Nightly Rate";
            // 
            // txtNightsStayed
            // 
            this.txtNightsStayed.Location = new System.Drawing.Point(12, 30);
            this.txtNightsStayed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNightsStayed.Name = "txtNightsStayed";
            this.txtNightsStayed.Size = new System.Drawing.Size(89, 22);
            this.txtNightsStayed.TabIndex = 1;
            // 
            // lblNightsStayed
            // 
            this.lblNightsStayed.AutoSize = true;
            this.lblNightsStayed.Location = new System.Drawing.Point(9, 11);
            this.lblNightsStayed.Name = "lblNightsStayed";
            this.lblNightsStayed.Size = new System.Drawing.Size(96, 17);
            this.lblNightsStayed.TabIndex = 0;
            this.lblNightsStayed.Text = "Nights Stayed";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(111, 25);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(84, 30);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(327, 32);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(23, 17);
            this.lblTotalCost.TabIndex = 6;
            this.lblTotalCost.Text = "---";
            // 
            // lblTotalCostHeader
            // 
            this.lblTotalCostHeader.AutoSize = true;
            this.lblTotalCostHeader.Location = new System.Drawing.Point(327, 11);
            this.lblTotalCostHeader.Name = "lblTotalCostHeader";
            this.lblTotalCostHeader.Size = new System.Drawing.Size(116, 17);
            this.lblTotalCostHeader.TabIndex = 5;
            this.lblTotalCostHeader.Text = "Total cost of stay";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 85);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblTotalCostHeader);
            this.Controls.Add(this.lblNightlyRate);
            this.Controls.Add(this.lblNightlyRateHeader);
            this.Controls.Add(this.txtNightsStayed);
            this.Controls.Add(this.lblNightsStayed);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "The Carefree Resort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblNightlyRate;
        public System.Windows.Forms.Label lblNightlyRateHeader;
        public System.Windows.Forms.TextBox txtNightsStayed;
        public System.Windows.Forms.Label lblNightsStayed;
        public System.Windows.Forms.Button btnCalculate;
        public System.Windows.Forms.Label lblTotalCost;
        public System.Windows.Forms.Label lblTotalCostHeader;
    }
}

