using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerivedClass_ChenEdward
{
    class Manager : Employee
    {
        #region Fields
        private int stock = 0;
        private decimal bonusAmount = 0;

        
        #endregion

        #region Constructors
        public Manager ()
        {
            ID = 000;
            firstName = "Unknown";
            lastName = "Unknown";
            Birthdate = DateTime.MinValue;
            Hiredate = DateTime.MinValue;
            Salary = 1000;
            stock = 30;
            bonusAmount = 0;
        }

        public Manager (int empId, string firstnameInput, string lastNameInput, DateTime birthdateInput, DateTime hiredateInput, decimal currentSalary, int stockOptions, decimal bonusAmt)
        {
            ID = empId;
            firstName = firstnameInput;
            lastName = lastNameInput;
            Birthdate = birthdateInput;
            Hiredate = hiredateInput;
            Salary = currentSalary;
            stock = stockOptions;
            bonusAmount = bonusAmt;
        }
        #endregion

        #region Properties
        public int Stock
        {
            get
            {
                return stock;
            }

            set
            {
                stock = value;
            }
        }

        public decimal BonusAmount
        {
            get
            {
                return bonusAmount;
            }

            set
            {
                bonusAmount = value;
            }
        }

        //Under the assumption we are supposed to ask for user input
        //public Decimal calculateBonus ()
        //{
        //    int number=0;

        //    Console.WriteLine("What percentage of the salary should the manager receive?");
        //    string input = Console.ReadLine();
        //    bool result = Int32.TryParse(input, out number);
        //    if (result)
        //        bonusAmount = Salary * number;
        //    else
        //    {
        //        Console.WriteLine("Please input a number");
        //        calculateBonus();
        //    }
        //    return bonusAmount;
        //}

        public Decimal calculateBonus(decimal userInput)
        {              
            bonusAmount = Salary * userInput;                      
            return bonusAmount;
        }

        public override string ToString()
        {
            return $"{ID,5} {lastName,-25} {firstName,-25}" +
                $"{Hiredate,-11:MM/dd/yyyy} {Birthdate,-11:MM/dd/yyyy}" +
                $"{ Salary,10:C} { bonusAmount,15 } { Stock,15}" ;
        }

        #endregion
    }
}
