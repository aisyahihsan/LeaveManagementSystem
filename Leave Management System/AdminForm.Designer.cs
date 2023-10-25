namespace Leave_Management_System
{
    partial class AdminForm
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
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnHelpAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.Color.Pink;
            this.btnApprove.Location = new System.Drawing.Point(83, 140);
            this.btnApprove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(210, 55);
            this.btnApprove.TabIndex = 3;
            this.btnApprove.Text = "APPROVAL LEAVE";
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnInfo.Location = new System.Drawing.Point(83, 56);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(210, 55);
            this.btnInfo.TabIndex = 2;
            this.btnInfo.Text = "EMPLOYEE INFO";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.HotPink;
            this.btnBack.Location = new System.Drawing.Point(135, 223);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 44);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "Log Out";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnHelpAdmin
            // 
            this.btnHelpAdmin.Location = new System.Drawing.Point(342, 12);
            this.btnHelpAdmin.Name = "btnHelpAdmin";
            this.btnHelpAdmin.Size = new System.Drawing.Size(77, 25);
            this.btnHelpAdmin.TabIndex = 26;
            this.btnHelpAdmin.Text = "help";
            this.btnHelpAdmin.UseVisualStyleBackColor = true;
            this.btnHelpAdmin.Click += new System.EventHandler(this.btnHelpAdmin_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 293);
            this.Controls.Add(this.btnHelpAdmin);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.btnInfo);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdminForm";
            this.Text = "Admin Form";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnHelpAdmin;
    }
}