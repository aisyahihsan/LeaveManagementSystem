namespace Leave_Management_System
{
    partial class ApprovalForm
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDateTo = new System.Windows.Forms.TextBox();
            this.txtDateFrom = new System.Windows.Forms.TextBox();
            this.txtTotalDay = new System.Windows.Forms.TextBox();
            this.txtAddLeave = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(407, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(103, 37);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(39, 337);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 37);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.Location = new System.Drawing.Point(407, 337);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(103, 37);
            this.btnApprove.TabIndex = 25;
            this.btnApprove.Text = "SAVE";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(191, 253);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(178, 22);
            this.txtReason.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 17);
            this.label7.TabIndex = 46;
            this.label7.Text = "Leave Reason";
            // 
            // txtDateTo
            // 
            this.txtDateTo.Location = new System.Drawing.Point(191, 213);
            this.txtDateTo.Name = "txtDateTo";
            this.txtDateTo.Size = new System.Drawing.Size(178, 22);
            this.txtDateTo.TabIndex = 45;
            // 
            // txtDateFrom
            // 
            this.txtDateFrom.Location = new System.Drawing.Point(191, 177);
            this.txtDateFrom.Name = "txtDateFrom";
            this.txtDateFrom.Size = new System.Drawing.Size(178, 22);
            this.txtDateFrom.TabIndex = 44;
            // 
            // txtTotalDay
            // 
            this.txtTotalDay.Location = new System.Drawing.Point(191, 137);
            this.txtTotalDay.Name = "txtTotalDay";
            this.txtTotalDay.Size = new System.Drawing.Size(178, 22);
            this.txtTotalDay.TabIndex = 43;
            // 
            // txtAddLeave
            // 
            this.txtAddLeave.Location = new System.Drawing.Point(191, 99);
            this.txtAddLeave.Name = "txtAddLeave";
            this.txtAddLeave.Size = new System.Drawing.Size(178, 22);
            this.txtAddLeave.TabIndex = 42;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(191, 61);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(178, 22);
            this.txtName.TabIndex = 41;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(191, 22);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(178, 22);
            this.txtID.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 17);
            this.label6.TabIndex = 39;
            this.label6.Text = "Total Day Leave";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "Date From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Date To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Leave Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Employee Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Employee ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 48;
            this.label8.Text = "Status";
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "APPROVE",
            "REJECT"});
            this.cboStatus.Location = new System.Drawing.Point(195, 294);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(173, 24);
            this.cboStatus.TabIndex = 49;
            // 
            // ApprovalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 386);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDateTo);
            this.Controls.Add(this.txtDateFrom);
            this.Controls.Add(this.txtTotalDay);
            this.Controls.Add(this.txtAddLeave);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearch);
            this.Name = "ApprovalForm";
            this.Text = "Approval Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDateTo;
        private System.Windows.Forms.TextBox txtDateFrom;
        private System.Windows.Forms.TextBox txtTotalDay;
        private System.Windows.Forms.TextBox txtAddLeave;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboStatus;
    }
}