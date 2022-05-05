// See https://aka.ms/new-console-template for more information
using JSON;
using Newtonsoft.Json;

Console.WriteLine("Welcome to JSON Inventory Data Management of Rice, Pulses and Wheats");
//Taking Input from the JSON file
string filePath = @"C:\Users\santo\OneDrive\Desktop\CSharpCodes\OOPs-JSON\JSON\jsconfig1.json";

while(true)
{
    Console.WriteLine("Please choose the correct option : \n1) uc1");
    int option = Convert.ToInt32(Console.ReadLine());
    switch(option)
    {
        case 1:
            //Deserializing the data in JSON file to Collection
            List<Inventory> InList = JsonConvert.DeserializeObject<List<Inventory>>(File.ReadAllText(filePath));
            Console.WriteLine("The Inventory details are :");
            foreach (Inventory data in InList)
            {
                Console.WriteLine("Name :" + data.name + " Weight :" + data.weight + " Cost :" + data.cost);
            }
            //SErialize to JSON string
            string json1 = JsonConvert.SerializeObject(InList);
            Console.WriteLine("The output as JSON string :\n "+json1);
            break;
        default:
            Console.WriteLine("Please choose correct option !");
            break;
    }
}


/*uc2
//Calculating the Inventory cost of each item
InventoryManager Price = new();

foreach(var item in InList)
{
    Price.CalculatingPrice(item.weight, item.cost, item.name);
}
*/


