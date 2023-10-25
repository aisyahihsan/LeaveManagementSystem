using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Leave_Management_System
{
    public partial class ApplyLeaveForm : Form
    {
        string filepath = @"C:\Users\User\Documents\Visual Studio 2015\Projects\Leave Management System\LeaveReport.txt";
        Employee aEmployee;
        Leave aLeave = new Leave();
        public ApplyLeaveForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {}

        private void btnBack_Click(object sender, EventArgs e)
        {
            ApplyandCheckLeave applyAndCheck = new ApplyandCheckLeave();
            applyAndCheck.Show();
            this.Hide();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            aEmployee = new Employee();
            aLeave = new Leave();
            aEmployee.EmployeeID = txtID.Text;
            aEmployee.EmployeeName = txtName.Text;
            aLeave.LeaveAddress = txtAddLeave.Text;
            aLeave.TotalDay = int.Parse(txtTotalDay.Text);
            aLeave.DateFrom = txtDateFrom.Text;
            aLeave.DateTo = txtDateTo.Text;
            aLeave.LeaveReason = txtReason.Text;
            aLeave.Status = "Pending";

            SaveToFile(filepath);
            MessageBox.Show("Your apply is saved!");
        }
        bool SaveToFile(string Filepath)
        {
            if (!File.Exists(filepath))
            {
                // Create a file to write to.
                using (StreamWriter file = File.CreateText(filepath))
                {
                    string Line = StudentToLine(aEmployee);
                    file.WriteLine(Line);//write to file
                }
            }
            else
                // This text is always added, making the file longer over time
                // if it is not deleted.
                using (StreamWriter file = File.AppendText(filepath))
                {
                    string Line = StudentToLine(aEmployee);
                    file.WriteLine(Line);
                }
            //file.Close();
            return true;
        }
        string StudentToLine(Employee aEmployee)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(aEmployee.EmployeeID);
            sb.Append('|');
            sb.Append(aEmployee.EmployeeName);
            sb.Append('|');
            sb.Append(aLeave.LeaveAddress);
            sb.Append('|');
            sb.Append(aLeave.TotalDay);
            sb.Append('|');
            sb.Append(aLeave.DateFrom);
            sb.Append('|');
            sb.Append(aLeave.DateTo);
            sb.Append('|');
            sb.Append(aLeave.LeaveReason);
            sb.Append('|');
            sb.Append(aLeave.Status);
            Debug.WriteLine(sb.ToString());
            return sb.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            InitializeComponent();
        }
    }
}
