using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leave_Management_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" && txtPassword.Text != "")
            {

                //Admin//

                if (txtID.Text == "admin" && txtPassword.Text == "qwerty890" && cboType.Text=="Admin")
                {
                        MessageBox.Show("Welcome to Leave Management System");
                        AdminForm Admin = new AdminForm();
                        Admin.Show();
                        this.Hide();
                }

                //Employee One//
                if (txtID.Text == "employ01" && txtPassword.Text == "abcd123" && cboType.Text == "Employee")
                {
                        MessageBox.Show("Welcome to Leave Management System");
                        ApplyandCheckLeave ApplyLeaveForm = new ApplyandCheckLeave();
                        ApplyLeaveForm.Show();
                        this.Hide();
                }

                //Employee Two//
                if (txtID.Text == "employ02" && txtPassword.Text == "efgh123" && cboType.Text == "Employee")
                {
                        MessageBox.Show("Welcome to Leave Management System");
                        ApplyandCheckLeave ApplyLeaveForm = new ApplyandCheckLeave();
                        ApplyLeaveForm.Show();
                        this.Hide();
                }

                //Employee Three//
                if (txtID.Text == "employ03" && txtPassword.Text == "abcd890" && cboType.Text == "Employee")
                {
                        MessageBox.Show("Welcome to Leave Management System");
                        ApplyandCheckLeave ApplyLeaveForm = new ApplyandCheckLeave();
                        ApplyLeaveForm.Show();
                        this.Hide();
                }

                else MessageBox.Show("Wrong User ID, Password and User Type. Please re-enter!");
            }
            else MessageBox.Show("Please enter User ID, Password and User Type!");
        }
      }
 }