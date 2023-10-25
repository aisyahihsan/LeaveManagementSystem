using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leave_Management_System
{
    class Employee
    {
        private string _employeeName;
        public string EmployeeName
        {
            get { return _employeeName; }
            set { _employeeName = value; }
        }

        private string _employeeID;
        public string EmployeeID
        {
            get { return _employeeID; }
            set { _employeeID = value; }
        }

        private string _address;
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        private int _numOfDays;
        public int NumOfDays
        {
            get { return _numOfDays; }
            set { _numOfDays = value; }
        }

        private string _position;
        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }

        private Leave myLeave;
        public Leave MyLeave
        {
            get { return myLeave; }
            set { myLeave = value; }
        }
        public Employee() { }

        public void ApplyLeave(Leave application)
        {
            myLeave = application;
        }

        public int GetTotalBalance()
        {
            return myLeave.CalculateTotalBalance(NumOfDays); //calling method
        }
    }
}
