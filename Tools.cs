using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_230930
{
    internal class Tools
    {
        public Tools(string type, string brand, string modelName, string office, DateTime dateOfPurchase, double priceOfAsset)
        {
            Type = type;
            Brand = brand;
            ModelName = modelName;
            Office = office;
            DateOfPurchase = dateOfPurchase;
            PriceOfAsset = priceOfAsset;
        }

        public string Type { get; set; }
        public string Brand { get; set; }

        public string ModelName { get; set; }


        public string Office { get; set; }

        public DateTime DateOfPurchase { get; set; }
        

        public double PriceOfAsset { get; set; }


        public static void AddTool(List<Tools> assetItems)

        {

            Console.Write("Type (computer or phone): ");
            string type = Console.ReadLine();

            Console.Write("Brand : ");
            string brand = Console.ReadLine();

            Console.Write("modellname: ");
            string modelName = Console.ReadLine();

            Console.Write("Office: ");
            string office = Console.ReadLine();

            Console.Write("inköpsdatum : ");
            DateTime dateOfPurchase;
            DateTime.TryParse(Console.ReadLine(),out dateOfPurchase );


            Console.Write("Name of the person using the asset: ");
            string nameOfUser = Console.ReadLine();

            Console.Write("Price: ");
            double priceOfAsset = Convert.ToDouble(Console.ReadLine());


            Tools asset = new Tools(type, brand, modelName, office, dateOfPurchase, priceOfAsset);

            assetItems.Add(asset);
            Console.WriteLine("Computer added successfully.");
        }

        public static void ShowAssets(List<Tools> assetItems)
        {
            //Skriver ut listan 

            Console.WriteLine("Sparade assets");
            Console.WriteLine("==============\n");


            foreach (Tools item in assetItems)
            {

                Console.WriteLine($"{item.DateOfPurchase} : {item.Brand} : {item.PriceOfAsset} : {item.Office}");
            }

        }

    }


}
