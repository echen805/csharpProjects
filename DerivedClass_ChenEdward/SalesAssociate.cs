using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerivedClass_ChenEdward
{
    class SalesAssociate : Employee
    {
        #region Fields
        private int sales = 0;
        private decimal bonusAmount = 0;


        #endregion

        #region Constructors
        public SalesAssociate()
        {
            ID = 999;
            firstName = "Unknown";
            lastName = "Unknown";
            Birthdate = DateTime.MinValue;
            Hiredate = DateTime.MinValue;
            Salary = 500;
            sales = 1;
        }

        public SalesAssociate(int empId, string firstnameInput, string lastNameInput, DateTime birthdateInput, DateTime hiredateInput, decimal currentSalary, int salesOptions)
        {
            ID = empId;
            firstName = firstnameInput;
            lastName = lastNameInput;
            Birthdate = birthdateInput;
            Hiredate = hiredateInput;
            Salary = currentSalary;
            sales = salesOptions;
        }
        #endregion

        #region Properties
        public int Sales
        {
            get
            {
                return sales;
            }

            set
            {
                sales = value;
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

        public Decimal calculateBonus()
        {
            if (sales > 10)
            {
                bonusAmount = Salary * 0.05M;
                return bonusAmount;
            }
            else
                if (sales > 20)
            {
                bonusAmount = Salary * 0.10M;
                return bonusAmount;
            }

            else
            {
                if (sales > 30)
                {
                    bonusAmount = Salary * 0.20M;
                    return bonusAmount;
                }

                else
                    return bonusAmount;
            }
        }

        public override string ToString()
        {
            return $"{ID,5} {lastName,-25} {firstName,-25}" +
                $"{Hiredate,-11:MM/dd/yyyy} {Birthdate,-11:MM/dd/yyyy}" +
                $"{ Salary,10:C} { BonusAmount,15 } { Sales,15}";
        }

        #endregion
    }
}
