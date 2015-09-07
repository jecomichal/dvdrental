using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClasses
{
    [Serializable]
    public class Employee : Person
    {
        protected int empID;
        protected string username;
        protected string password;
        protected char userType;
        protected DateTime dateHired;
        protected string pps;
        protected string email;

        public Employee(int newEmpID, string newFirstName, string newSurname, string newAddress, int newAge, string newMobile,
                        string newUsername, string newPassword, char newUserType, string newPps, string newEmail)
            : base(newFirstName, newSurname, newAddress, newAge, newMobile)
        {
            empID = newEmpID;
            username = newUsername;
            password = newPassword;
            userType = newUserType;
            dateHired = DateTime.Today;
            pps = newPps;
            email = newEmail;
        }

        public int EmpID
        {
            get { return empID; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public char UserType
        {
            get { return userType; }
            set { userType = value; }
        }

        public DateTime DateHired
        {
            get { return dateHired; }
        }

        public string Pps
        {
            get { return pps; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public bool HasEmpID(int searchEmpId)
        {
            return searchEmpId == this.empID ? true : false;
        }

        public bool HasPPS(string searchPps)
        {
            return searchPps == this.pps ? true : false;
        }

        public bool HasUsernameAndPassword(string searchUsername, string searchPass)
        {
            return searchUsername == this.username && searchPass == this.password ? true : false;
        }

    }
}
