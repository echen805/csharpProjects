using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Item : IMenu
    {
        int itemID;
        string name;
        double cost;
        int quantity;

        public Item()
        {
            itemID = -1;
            Name = "Default Item";
            Cost = 0.00;
            Quantity = 0;
        }

        public Item(int IDInput, string ItemName, double ItemCost, int ItemQuantity)
        {
            itemID = IDInput;
            Name = ItemName;
            Cost = ItemCost;
            Quantity = ItemQuantity;
        }

        #region Properties
        public double Cost
        {
            get
            {
                return cost;
            }

            set
            {
                cost = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int ItemID
        {
            get
            {
                return itemID;
            }

            set
            {
                itemID = value;
            }
        }

        #endregion


        public void UpdateInventory(int amount)
        {
            Item userOrder = new Item();
            userOrder.quantity = amount;
            if (this.Quantity > userOrder.Quantity)
                this.Quantity -= userOrder.Quantity;
            else
                Console.WriteLine("I'm sorry, we only have {0} of that item left",Quantity);
        }

        public void printMenu()
        {
            Console.WriteLine($"{ItemID,-10} {Name,-7} {Quantity,9} {Cost,20}");
        }

        public double GetTotal()
        {
            return (this.Cost * this.Quantity);
        }

        public override string ToString()
        {
            return $"{Name,-7} {Quantity,16} {GetTotal(),20}";            
        }
    }
}
