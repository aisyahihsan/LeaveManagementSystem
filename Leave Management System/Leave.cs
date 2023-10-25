using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leave_Management_System
{
    class Leave
    {
        private string _leaveAddress;
        public string LeaveAddress
        {
            get { return _leaveAddress; }
            set { _leaveAddress = value; }
        }
        private string _dateFrom;
        public string DateFrom
        {
            get { return _dateFrom; }
            set { _dateFrom = value; }
        }
        private string _dateTo;
        public string DateTo
        {
            get { return _dateTo; }
            set { _dateTo = value; }
        }
        private string _leaveReason;
        public string LeaveReason
        {
            get { return _leaveReason; }
            set { _leaveReason = value; }
        }

        private string _status;
        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }

        private int _totalDay;
        public int TotalDay
        {
            get { return _totalDay; }
            set { _totalDay = value; }
        }

        private Employee myEmployee;
        public Employee MyEmployee
        {
            get { return myEmployee; }
           set { myEmployee = value; }
        }

        public Leave() { }

        public int CalculateTotalBalance(int NumOfDays)//receive parameter from class Employee
        {
           int totalBalance = NumOfDays;
           totalBalance = totalBalance - TotalDay; //calculate totalBalance left for employee
           return totalBalance; //return totalbalance value
        }

    }
}
