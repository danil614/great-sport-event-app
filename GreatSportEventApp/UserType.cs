using GreatSportEventApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatSportEventApp
{
    public enum UserType
    {
        Null = 0, Admin = 1, Seller = 2, Organizer = 3, HR = 4
    }

    public class CurrentUser
    {
        public UserType UserType { get; private set; }

        public int EmployeeId
        {
            get => employeeId;
            private set 
            { 
                if (value > 0)
                {
                    employeeId = value;
                }
                else
                {
                    employeeId = -1;
                }
            } 
        }

        private int employeeId;

        public CurrentUser()
        {
            UserType = UserType.Null;
            EmployeeId = -1;
        }

        public CurrentUser(UserType _userType, int _employeeId)
        {
            UserType = _userType;
            EmployeeId = _employeeId;
        }
    }
}
