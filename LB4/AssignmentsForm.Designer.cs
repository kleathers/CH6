namespace LB4
{
    partial class AssignmentsForm
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
            this.btnOldest = new System.Windows.Forms.Button();
            this.btnNewest = new System.Windows.Forms.Button();
            this.lblAssignments = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnView = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOldest
            // 
            this.btnOldest.Location = new System.Drawing.Point(28, 33);
            this.btnOldest.Name = "btnOldest";
            this.btnOldest.Size = new System.Drawing.Size(113, 38);
            this.btnOldest.TabIndex = 0;
            this.btnOldest.Text = "Oldest First";
            this.btnOldest.UseVisualStyleBackColor = true;
            this.btnOldest.Click += new System.EventHandler(this.btnOldest_Click);
            // 
            // btnNewest
            // 
            this.btnNewest.Location = new System.Drawing.Point(158, 33);
            this.btnNewest.Name = "btnNewest";
            this.btnNewest.Size = new System.Drawing.Size(114, 38);
            this.btnNewest.TabIndex = 1;
            this.btnNewest.Text = "Newest First";
            this.btnNewest.UseVisualStyleBackColor = true;
            this.btnNewest.Click += new System.EventHandler(this.btnNewest_Click);
            // 
            // lblAssignments
            // 
            this.lblAssignments.AutoSize = true;
            this.lblAssignments.Location = new System.Drawing.Point(24, 86);
            this.lblAssignments.Name = "lblAssignments";
            this.lblAssignments.Size = new System.Drawing.Size(99, 20);
            this.lblAssignments.TabIndex = 2;
            this.lblAssignments.Text = "assignments";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(28, 286);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 26);
            this.txtNumber.TabIndex = 3;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(146, 278);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(112, 42);
            this.btnView.TabIndex = 4;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(24, 326);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(51, 20);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "label2";
            // 
            // AssignmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 445);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblAssignments);
            this.Controls.Add(this.btnNewest);
            this.Controls.Add(this.btnOldest);
            this.Name = "AssignmentsForm";
            this.Text = "Assignments";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnOldest;
        public System.Windows.Forms.Button btnNewest;
        public System.Windows.Forms.Label lblAssignments;
        public System.Windows.Forms.TextBox txtNumber;
        public System.Windows.Forms.Button btnView;
        public System.Windows.Forms.Label lblResult;
    }
}

