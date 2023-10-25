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
    public partial class ApprovalForm : Form
    {
        string filepath = @"C:\Users\User\Documents\Visual Studio 2015\Projects\Leave Management System\LeaveReport.txt";
        string filepath2 = @"C:\Users\User\Documents\Visual Studio 2015\Projects\Leave Management System\EmployeeInfo.txt";
        //textfile

        Employee emp;
        Leave apply;
        //declare global
        public ApprovalForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminForm backToAdmin = new AdminForm();
            backToAdmin.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtID.Text;
            string line;
            if (System.IO.File.Exists(filepath) == true)
            {
                using (StreamReader reader = new StreamReader(filepath))
                {
                    while (!reader.EndOfStream)
                    {
                        line = reader.ReadLine();
                        Leave apply;
                        ParseLeave(line, out apply);
                        if (search == emp.EmployeeID)
                        {
                            txtName.Text = emp.EmployeeName;
                            txtAddLeave.Text = apply.LeaveAddress;
                            txtTotalDay.Text = apply.TotalDay.ToString();
                            txtDateFrom.Text = apply.DateFrom;
                            txtDateTo.Text = apply.DateTo;
                            txtReason.Text = apply.LeaveReason; //to display attributes of the object into the textboxes
                        }
                        else MessageBox.Show("ID doesn't exist. Please re-enter.");
                    }
                }
            }
            else
                MessageBox.Show("File" + filepath + "doesn't exist");
        }

        bool ParseLeave(string Text, out Leave apply)//utk splitkan data by bar
        {
            apply = new Leave();
            emp = new Employee();
            string[] arr = Text.Split('|');
            if (arr.Length != 8)
                return false;
            emp.EmployeeID = (arr[0]);
            emp.EmployeeName = arr[1];
            apply.LeaveAddress = arr[2];
            apply.TotalDay = int.Parse(arr[3]);
            apply.DateFrom = arr[4];
            apply.DateTo = arr[5];
            apply.LeaveReason = arr[6];
            apply.Status = arr[7];
            return true;
        }
        //Save search data yg user masukkan dlm text box
        //If jumpa record yg di search dalam text file, keluarkan details dlm textbox

        private void btnApprove_Click(object sender, EventArgs e)
        {
            apply = new Leave();//create new object
            emp.EmployeeID = txtID.Text;
            emp.EmployeeName = txtName.Text;
            apply.LeaveAddress = txtAddLeave.Text;
            apply.TotalDay =int.Parse (txtTotalDay.Text);
            apply.DateFrom = txtDateFrom.Text;
            apply.DateTo = txtDateTo.Text;
            apply.LeaveReason = txtReason.Text;

            if (cboStatus.Text == "APPROVE")
            {
                apply.Status = "APPROVED"; // assign new status
            }
            else
                apply.Status = "REJECTED";
            SaveToFile(filepath);// call method savetofile

            string search = txtID.Text;
            string line;
            if (System.IO.File.Exists(filepath2) == true)
            {
                using (StreamReader reader = new StreamReader(filepath2))
                {
                    while (!reader.EndOfStream)
                    {
                        line = reader.ReadLine();
                        Employee searchedEmp;
                        ParseEmployee(line, out searchedEmp);
                        if (search == searchedEmp.EmployeeID)
                        {
                            if (cboStatus.Text== "APPROVE")
                            {
                                emp.EmployeeID = searchedEmp.EmployeeID;
                                emp.EmployeeName = searchedEmp.EmployeeName;
                                emp.Position = searchedEmp.Position;
                                emp.Address = searchedEmp.Address;
                                emp.NumOfDays = searchedEmp.NumOfDays;
                                emp.ApplyLeave(apply);//call method22225
                                emp.NumOfDays = emp.GetTotalBalance();//call method
                            }
                            else
                            {
                                emp.EmployeeID = searchedEmp.EmployeeID;
                                emp.EmployeeName = searchedEmp.EmployeeName;
                                emp.Position = searchedEmp.Position;
                                emp.Address = searchedEmp.Address;
                                emp.NumOfDays = searchedEmp.NumOfDays;
                                emp.ApplyLeave(apply);//call method
                            }
                            
                        }
                        
                    }
                }
            }
            else
                MessageBox.Show("File" + filepath2 + "doesn't exist");

            SaveToFile2(filepath2);//call method savetofile with passing parameter filepath to update numOfDays in textfile Employee
            MessageBox.Show("The approval is saved!");
        }

        bool SaveToFile(string Filepath) //receive filepath //to write data into texfile
        {
            if (!File.Exists(filepath))
            {
                // Create a file to write to.
                using (StreamWriter file = File.CreateText(filepath))
                {
                    string Line = LeaveToLine(apply);
                    file.WriteLine(Line);//write to file
                }
            }
            else
                // This text is always added, making the file longer over time
                // if it is not deleted.
                using (StreamWriter file = File.AppendText(filepath))
                {
                    string Line = LeaveToLine(apply);
                    file.WriteLine(Line);
                }
            //file.Close();
            return true;
        }

        string LeaveToLine(Leave apply)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(emp.EmployeeID);
            sb.Append('|');
            sb.Append(emp.EmployeeName);
            sb.Append('|');
            sb.Append(apply.LeaveAddress);
            sb.Append('|');
            sb.Append(apply.TotalDay);
            sb.Append('|');
            sb.Append(apply.DateFrom);
            sb.Append('|');
            sb.Append(apply.DateTo);
            sb.Append('|');
            sb.Append(apply.LeaveReason);
            sb.Append('|');
            sb.Append(apply.Status);
            return sb.ToString();
        }

       //untuk update textfile employee
        bool SaveToFile2(string Filepath2)
        {
            if (!File.Exists(filepath2))
            {
                // Create a file to write to.
                using (StreamWriter file = File.CreateText(filepath2))
                {
                    string Line = EmployeeToLine(emp);
                    file.WriteLine(Line);//write to file
                }
            }
            else
                // This text is always added, making the file longer over time
                // if it is not deleted.
                using (StreamWriter file = File.AppendText(filepath2))
                {
                    string Line = EmployeeToLine(emp);
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
        
            return sb.ToString();
        }
        bool ParseEmployee(string Text, out Employee emp)//utk splitkan data by bar
        {
            emp = new Employee();
            string[] arr = Text.Split('|');
            if (arr.Length != 5)
                return false;
            emp.EmployeeID = (arr[0]);
            emp.EmployeeName = arr[1];
            emp.Position = arr[2];
            emp.Address = arr[3];
            emp.NumOfDays = int.Parse(arr[4]);
            return true;
        }
        //Save search data yg user masukkan dlm text box
        //If jumpa record yg di search dalam text file, keluarkan details dlm textbox
       
    }

    }





