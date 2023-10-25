namespace Leave_Management_System
{
    partial class ApplyandCheckLeave
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
            this.btnLeave = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHelpEmp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLeave
            // 
            this.btnLeave.BackColor = System.Drawing.Color.Lavender;
            this.btnLeave.Location = new System.Drawing.Point(76, 51);
            this.btnLeave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(210, 55);
            this.btnLeave.TabIndex = 0;
            this.btnLeave.Text = "APPLY LEAVE";
            this.btnLeave.UseVisualStyleBackColor = false;
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCheck.Location = new System.Drawing.Point(76, 135);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(210, 55);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "CHECK STATUS AND BALANCE";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.AliceBlue;
            this.btnExit.Location = new System.Drawing.Point(128, 216);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(103, 44);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "Log Out";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHelpEmp
            // 
            this.btnHelpEmp.Location = new System.Drawing.Point(321, 14);
            this.btnHelpEmp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHelpEmp.Name = "btnHelpEmp";
            this.btnHelpEmp.Size = new System.Drawing.Size(77, 30);
            this.btnHelpEmp.TabIndex = 25;
            this.btnHelpEmp.Text = "help";
            this.btnHelpEmp.UseVisualStyleBackColor = true;
            this.btnHelpEmp.Click += new System.EventHandler(this.btnHelpEmp_Click);
            // 
            // ApplyandCheckLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 310);
            this.Controls.Add(this.btnHelpEmp);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnLeave);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ApplyandCheckLeave";
            this.Text = "Apply and Check Leave";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLeave;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHelpEmp;
    }
}