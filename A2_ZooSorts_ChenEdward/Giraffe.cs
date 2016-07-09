using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2_ZooSorts_ChenEdward
{
    public class Giraffe : Animal, IZoo
    {
        private int id;
        private decimal purchaseCost;
        private int cageNumber;

        public Giraffe (string inName, DateTime dob, decimal cost, int weight, int number, int cageNumber)
        {
            Name = inName;
            DOB = dob;
            PurchaseCost = cost;
            Weight = weight;
            ID = number;
            CageNumber = cageNumber;
        }

        public string GetClassName()
        {
            return "Giraffe";
        }
        public string Name { get; set; }
        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                if (value > 0)
                    id = value;
                else
                    id = 0;
            }
        }
        public decimal PurchaseCost
        {
            get
            {
                return purchaseCost;
            }
            set
            {
                if (value > 0.0M)
                    purchaseCost = value;
                else
                    purchaseCost = 0.0M;
            }
        }
        public int CageNumber
        {
            get
            {
                return cageNumber;
            }
            set
            {
                if (value > 0)
                    cageNumber = value;
                else
                    cageNumber = 0;
            }
        }

        public string animalType
        {
            get
            {
                return "Giraffe";
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override string ToString()
        {
            return $"{ID,-4} {"Giraffe",-15} {Name,-14} {base.ToString()} " +
            $"{PurchaseCost,15:C} {CageNumber,11:####}";
        }

        public DateTime GetDOB ()
        {
            return DOB;
        }

        public int GetWeight()
        {
            return Weight;
        }

        

        public int CompareTo(IZoo other)
        {
            // return -1 if this is less than other
            // return 0 if this == other
            // return 1 if this > other

            // note that other can never be null because we
            // are using an instance method. Thus you must test for a null conidtion

            // Note: most developers treat a null other condition as this > other

            if (other == null)
            {
                return 1; // i.e. this is greater than other (null)
            }

            int compareValue = 0;

            // Next determine your logical sort variables for your application
            // For this application ID could be used as the first sort variable

            compareValue = PurchaseCost.CompareTo(other.PurchaseCost);
            if (compareValue == 0)
            {
                // Nest another sort comparison based on your application needs...
                // For this application you could use cage number or maybe cost. Choose based
                // on your needs for the application
                compareValue = CageNumber.CompareTo(other.CageNumber);
                if (compareValue == 0)
                    compareValue = PurchaseCost.CompareTo(other.PurchaseCost);
                    if (compareValue == 0)
                    {
                        compareValue = Name.CompareTo(other.Name);
                    }
            }
            return compareValue;
        }
    }
}
