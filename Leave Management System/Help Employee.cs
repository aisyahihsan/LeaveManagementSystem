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
    public partial class Help_Employee : Form
    {
        public Help_Employee()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ApplyandCheckLeave empForm = new ApplyandCheckLeave();
            empForm.Show();
            this.Hide();
        }

    }
}
