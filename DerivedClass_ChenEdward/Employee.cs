using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerivedClass_ChenEdward
{
    class Employee
    {
        #region Fields
        private int _ID = 0;
        private DateTime birthdate = DateTime.MinValue;
        private DateTime hiredate = DateTime.MinValue;
        private decimal salary = 0;

        private static int empCount = 0;
        #endregion

        #region Constructors
        public Employee() : this(0, "Unknown", "Unknown", DateTime.MinValue, DateTime.MinValue, 0) { }
        public Employee(int empId, string firstnameInput, string lastNameInput, DateTime birthdateInput, DateTime hiredateInput, decimal currentSalary)
        {
            this._ID = empId;
            this.firstName = firstnameInput;
            this.lastName = lastNameInput;
            this.Birthdate = birthdateInput;
            this.Hiredate = hiredateInput;
            salary = currentSalary;

            empCount++;
        }
        #endregion

        #region Properties
        public int ID
        {
            get
            {
                return _ID;
            }

            set
            {
                this._ID = value;
            }
        }

        public DateTime Birthdate
        {
            get
            {
                return birthdate;
            }

            set
            {
                if (value <= DateTime.Now)
                    birthdate = value;
                else
                    throw new ArgumentOutOfRangeException("DOB","The date of birth must be less than the current date. ");
            }
        }

        public DateTime Hiredate
        {
            get
            {
                return hiredate;
            }

            set
            {
                if (value <= DateTime.Now)
                    hiredate = value;
                else
                    throw new ArgumentOutOfRangeException("Hire Date", "The hire date must be less than the current date. ");
                
            }
        }

        public decimal Salary
        {
            get
            {
                return salary;
            }

            set
            {
                if (value >= 0)
                    salary = value;
                else
                    throw new ArgumentOutOfRangeException("Salary", "The salary must be greater than 0. ");
                

            }
        }


        public string firstName { get; set; } = String.Empty;
        public string lastName { get; set; } = String.Empty;


        #endregion

        #region Methods

        public int DaysEmployed()
        {
            DateTime oldDate = Hiredate;
            DateTime currentDate = DateTime.Now;

            //Difference in days, hours and minutes 
            TimeSpan ts = currentDate - oldDate;

            int differenceDays = ts.Days;

            return differenceDays;
        }

        public int YearsEmployed()
        {
            DateTime currentDate = DateTime.Now;
            int years = currentDate.Year - Hiredate.Year;

            if((currentDate.Month == Hiredate.Month) || 
                (currentDate.Month == Hiredate.Month) && (currentDate.Day < Hiredate.Day))
            {
                --years;
            }
            return years;
        }

        public static string ReportHeader()
        {
            Console.SetWindowSize(150, 20);
            return $"Employee EIS\n" +
                $"{"ID", 5} {"Last Name", -25} { "First Name", -25} {"DOB", -13}" +
                $"{ "Hire Date", -11} {"Salary", 8} {"Bonus", 15} {"Stock/Sales", 15}" ;
        }

        public override string ToString()
        {
            return $"{ID,5} {lastName, -25} {firstName,-25}" + 
                $"{Hiredate,-11:MM/dd/yyyy} {Birthdate,-11:MM/dd/yyyy}" +
                $"{ Salary,10:C} { empCount,15}";
        }

        #endregion


    }
}


