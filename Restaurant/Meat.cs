using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Meat : Item, IMenu
    {
        //Custom attribute to describe category and date this section was updated
        public Meat()
        {
            ItemID = -1;
            Name = "Meat based substance";
            Cost = 0.00;
            Quantity = 000;
        }

        public Meat(int IDInput, string MeatName, double MeatCost, int MeatQuantity)
        {
            ItemID = IDInput;
            Name = MeatName;
            Cost = MeatCost;
            Quantity = MeatQuantity;
        }

        public override string ToString()
        {
            return $"{ItemID,-7} {Name,-4} {Cost,0} {Quantity,10}";
        }

    }
}
