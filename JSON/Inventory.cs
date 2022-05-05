using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JSON
{
    public class Inventory
    {
        public string name { get; set; }
        public int weight { get; set; }
        public int cost { get; set; }
        
        public List<Inventory> InventoryItem()
        {
            return new List<Inventory>()
            {
                 new Inventory{ name= "Rice", weight = 20, cost = 100 },
                 new Inventory{ name="Wheat", weight = 30, cost = 80 },
                 new Inventory{ name="Pulses",weight = 10 , cost =70 }
            };
        }
        
    } 
    public class InventoryManager : Inventory
    {
        public int price { get; set; }
        public void CalculatingPrice(int weight, int cost, string name)
        {
            price = cost * weight;
            Console.WriteLine("The Price for {0} of Weight {1}Kgs and Cost {2} Rs/Kg is {3}Rs",name,weight,cost,price);
        }
    }
}
