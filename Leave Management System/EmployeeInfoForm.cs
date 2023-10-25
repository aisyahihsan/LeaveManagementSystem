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
    public partial class EmployeeInfoForm : Form
    {
        string filepath = @"C:\Users\User\Documents\Visual Studio 2015\Projects\Leave Management System\EmployeeInfo.txt";
        Employee aEmployee;
        public EmployeeInfoForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            aEmployee = new Employee();
            aEmployee.EmployeeID = txtID.Text;
            aEmployee.EmployeeName = txtName.Text;
            aEmployee.Position = cboPosition.Text;
            aEmployee.Address = txtAddress.Text;
            aEmployee.NumOfDays = int.Parse(txtDay.Text);
            MessageBox.Show("Your info is saved!");
            SaveToFile(filepath);
        }
        bool SaveToFile(string Filepath)
        {
            if (!File.Exists(filepath))
            {
                // Create a file to write to.
                using (StreamWriter file = File.CreateText(filepath))
                {
                    string Line = EmployeeToLine(aEmployee);
                    file.WriteLine(Line);//write to file
                }
            }
            else
                // This text is always added, making the file longer over time
                // if it is not deleted.
                using (StreamWriter file = File.AppendText(filepath))
                {
                    string Line = EmployeeToLine(aEmployee);
                    file.WriteLine(Line);
                }
            //file.Close();
            return true;
        }
        string EmployeeToLine(Employee aEmployee)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(aEmployee.EmployeeID);
            sb.Append('|');
            sb.Append(aEmployee.EmployeeName);
            sb.Append('|');
            sb.Append(aEmployee.Position);
            sb.Append('|');
            sb.Append(aEmployee.Address);
            sb.Append('|');
            sb.Append(aEmployee.NumOfDays);
            Debug.WriteLine(sb.ToString());
            return sb.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminForm backToAdmin = new AdminForm();
            backToAdmin.Show();
            this.Hide();
        }
    }
}
