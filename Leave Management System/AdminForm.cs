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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        { }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            EmployeeInfoForm EmployeeInfo = new EmployeeInfoForm();
            EmployeeInfo.Show();
            this.Hide();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            ApprovalForm AprroveReject = new ApprovalForm();
            AprroveReject.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHelpAdmin_Click(object sender, EventArgs e)
        {
            Help_Admin HelpAdminForm = new Help_Admin();
            HelpAdminForm.Show();
        }
    }
}
