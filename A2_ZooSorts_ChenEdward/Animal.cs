using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2_ZooSorts_ChenEdward
{
    public class Animal
    {
        private int weight;
        private DateTime dob;

        public int Weight
        {
            get
            {
                return weight;
            }

            set
            {
                if (value > 0)
                    weight = value;
                else
                    weight = 0;
            }
        }

        public DateTime DOB
        {
            get
            {
                return dob;
            }
            set
            {
                if (value < DateTime.Now)
                    dob = value;
                else
                    dob = DateTime.MinValue; // signals unknown value
            }
        }

        public int GetAge()
        {
            DateTime currentDate = DateTime.Now;

            int years = currentDate.Year - DOB.Year;
            if ((currentDate.Month < DOB.Month) || ((currentDate.Month == DOB.Month) && (currentDate.Day < DOB.Day)))
                {
                    --years;
                }
            return years;
        }

        public override string ToString()
        {
            return $"{Weight,7} {GetAge(),4}";
        }
    }
}
