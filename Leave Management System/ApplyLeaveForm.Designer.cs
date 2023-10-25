namespace Leave_Management_System
{
    partial class ApplyLeaveForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddLeave = new System.Windows.Forms.TextBox();
            this.txtTotalDay = new System.Windows.Forms.TextBox();
            this.txtDateFrom = new System.Windows.Forms.TextBox();
            this.txtDateTo = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Leave Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date To";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date From";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total Day Leave";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(198, 45);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(178, 22);
            this.txtID.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(198, 84);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(178, 22);
            this.txtName.TabIndex = 7;
            // 
            // txtAddLeave
            // 
            this.txtAddLeave.Location = new System.Drawing.Point(198, 122);
            this.txtAddLeave.Name = "txtAddLeave";
            this.txtAddLeave.Size = new System.Drawing.Size(178, 22);
            this.txtAddLeave.TabIndex = 8;
            // 
            // txtTotalDay
            // 
            this.txtTotalDay.Location = new System.Drawing.Point(198, 160);
            this.txtTotalDay.Name = "txtTotalDay";
            this.txtTotalDay.Size = new System.Drawing.Size(178, 22);
            this.txtTotalDay.TabIndex = 9;
            // 
            // txtDateFrom
            // 
            this.txtDateFrom.Location = new System.Drawing.Point(198, 233);
            this.txtDateFrom.Name = "txtDateFrom";
            this.txtDateFrom.Size = new System.Drawing.Size(178, 22);
            this.txtDateFrom.TabIndex = 10;
            // 
            // txtDateTo
            // 
            this.txtDateTo.Location = new System.Drawing.Point(198, 200);
            this.txtDateTo.Name = "txtDateTo";
            this.txtDateTo.Size = new System.Drawing.Size(178, 22);
            this.txtDateTo.TabIndex = 11;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(174, 366);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(115, 33);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(324, 366);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(115, 33);
            this.btnApply.TabIndex = 13;
            this.btnApply.Text = "APPLY";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(33, 366);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 33);
            this.btnBack.TabIndex = 31;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 17);
            this.label7.TabIndex = 32;
            this.label7.Text = "Leave Reason";
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(198, 276);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(178, 22);
            this.txtReason.TabIndex = 33;
            // 
            // ApplyLeaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 426);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnReset);
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
            this.Name = "ApplyLeaveForm";
            this.Text = "Apply Leave Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddLeave;
        private System.Windows.Forms.TextBox txtTotalDay;
        private System.Windows.Forms.TextBox txtDateFrom;
        private System.Windows.Forms.TextBox txtDateTo;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtReason;
    }
}