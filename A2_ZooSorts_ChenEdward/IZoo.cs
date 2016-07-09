using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2_ZooSorts_ChenEdward
{
    public interface IZoo : IComparable<IZoo>        
        {
            int ID { get; set; }
            string Name { get; set; }
            decimal PurchaseCost { get; set; }
            int CageNumber { get; set; }
            
            string animalType { get; set; }
            
        //    public IZoo GetWeight ()
        //{

        //    return 
        //}
        }
}
