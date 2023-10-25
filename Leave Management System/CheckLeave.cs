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
    public partial class CheckLeave : Form
    {
        string filepath = @"C:\Users\User\Documents\Visual Studio 2015\Projects\Leave Management System\LeaveReport.txt";
        string filepath2= @"C:\Users\User\Documents\Visual Studio 2015\Projects\Leave Management System\EmployeeInfo.txt";
        //Employee aEmployee;
        Leave aLeave = new Leave();

        public CheckLeave()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtEmployeeID.Text;
            string line;
            if (System.IO.File.Exists(filepath) == true)
            {
                using (StreamReader reader = new StreamReader(filepath))
                {
                    while (!reader.EndOfStream)
                    {
                        line = reader.ReadLine();

                        Employee aEmployee;
                        ParseLeave(line, out aEmployee);
                        if (search == aEmployee.EmployeeID)
                        {

                            lstInfo.Items.Add(aEmployee.EmployeeID + "\t" + aEmployee.EmployeeName + "\t"
                                + aLeave.LeaveAddress + "\t" +
                       aLeave.TotalDay + "\t" + aLeave.DateFrom + "\t" + aLeave.DateTo
                       + "\t" + aLeave.LeaveReason + "\t" + aLeave.Status);
                        }
                        else MessageBox.Show("ID doesn't exist. Please re-enter.");
                    } 
                }
            }
            else
                MessageBox.Show("File" + filepath + "doesn't exist");
        }

        bool ParseLeave(string Text, out Employee aEmployee)//utk splitkan data by bar
        {
            aEmployee = new Employee();
            string[] arr = Text.Split('|');
            if (arr.Length != 8)
                return false;
            aEmployee.EmployeeID = (arr[0]);
            aEmployee.EmployeeName = arr[1];
            aLeave.LeaveAddress = arr[2];
            aLeave.TotalDay = Convert.ToInt32(arr[3]);
            aLeave.DateFrom = arr[4];
            aLeave.DateTo = arr[5];
            aLeave.LeaveReason = arr[6];
            aLeave.Status = arr[7];
            return true;
        }
        //Save search data yg user masukkan dlm text box
        //If jumpa record yg di search dalam text file, keluarkan details dlm textbox

    private void btnBack_Click(object sender, EventArgs e)
        {
            ApplyandCheckLeave applyAndCheck = new ApplyandCheckLeave();
            applyAndCheck.Show();
            this.Hide();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string search = txtEmployeeID.Text;
            string line;
            if (System.IO.File.Exists(filepath2) == true)
            {
                using (StreamReader reader = new StreamReader(filepath2))
                {
                    while (!reader.EndOfStream)
                    {
                        line = reader.ReadLine();

                        Employee aEmployee;
                        ParseEmployee(line, out aEmployee);
                        if (search == aEmployee.EmployeeID)
                        {
                            lstInfo.Items.Add(aEmployee.EmployeeID + "\t" + aEmployee.EmployeeName + "\t"
                               + aEmployee.Position + "\t" +
                      aEmployee.Address + "\t" + "\t" + aEmployee.NumOfDays);
                        }
                        else MessageBox.Show("ID doesn't exist. Please re-enter.");
                    }
                }
            }
            else
                MessageBox.Show("File" + filepath2 + "doesn't exist");
        }

        bool ParseEmployee(string Text, out Employee aEmployee)//utk splitkan data by bar
        {
            aEmployee = new Employee();
            string[] arr = Text.Split('|');
            if (arr.Length != 5)
                return false;
            aEmployee.EmployeeID = (arr[0]);
            aEmployee.EmployeeName = arr[1];
            aEmployee.Position = arr[2];
            aEmployee.Address = arr[3];
            aEmployee.NumOfDays = int.Parse(arr[4]);
            return true;
        }
    }
    }

