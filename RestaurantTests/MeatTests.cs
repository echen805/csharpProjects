using Microsoft.VisualStudio.TestTools.UnitTesting;
using Restaurant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Tests
{
    [TestClass()]
    public class MeatTests
    {
        static Random random = new Random();
        [TestMethod()]
        public void MeatTest()
        {
            Meat testMeat = new Meat();
            Assert.IsTrue(testMeat.ItemID == -1 && testMeat.Name == "Meat based substance" && testMeat.Cost==0.00 && testMeat.Quantity==000);
        }

        [TestMethod()]
        public void MeatTest1()
        {
            int itemID = random.Next();
            string name = "test";
            int cost = random.Next() * 100;
            int quant = random.Next() * 123;
            Meat testMeat = new Meat(itemID, name, cost, quant);
            Assert.IsTrue(testMeat.ItemID == itemID && testMeat.Name == name && testMeat.Cost == cost && testMeat.Quantity == quant);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            int itemID = random.Next();
            string name = "test";
            int cost = random.Next() * 100;
            int quant = random.Next() * 123;
            Meat testMeat = new Meat(itemID, name, cost, quant);
            string test = testMeat.ToString();
            string actual = $"{testMeat.ItemID,-7} {testMeat.Name,-4} {testMeat.Cost,0} {testMeat.Quantity,10}";
            Assert.AreEqual(actual,test);
        }
    }
}