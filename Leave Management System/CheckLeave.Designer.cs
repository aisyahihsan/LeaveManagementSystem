namespace Leave_Management_System
{
    partial class CheckLeave
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstInfo = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Employee ID:";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(192, 33);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(183, 22);
            this.txtEmployeeID.TabIndex = 21;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(394, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(216, 37);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "CHECK STATUS";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lstInfo
            // 
            this.lstInfo.FormattingEnabled = true;
            this.lstInfo.ItemHeight = 16;
            this.lstInfo.Location = new System.Drawing.Point(12, 75);
            this.lstInfo.Name = "lstInfo";
            this.lstInfo.Size = new System.Drawing.Size(1045, 292);
            this.lstInfo.TabIndex = 23;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 373);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 37);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(648, 18);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(227, 37);
            this.btnCheck.TabIndex = 25;
            this.btnCheck.Text = "CHECK BALANCE";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // CheckLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 415);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lstInfo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.label1);
            this.Name = "CheckLeave";
            this.Text = "Check Leave Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lstInfo;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCheck;
    }
}