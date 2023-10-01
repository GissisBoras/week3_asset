
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Channels;
using System.Threading.Tasks;

using System.Xml.Linq;

using ConsoleApp1_230930;



//namespace Class1; // Referera till product filen genom att lägga till ett using-direktiv
//using AddProducts; // Referera till product filen genom att lägga till ett using-direktiv


class Program

{



    static void Main()

    {
        //Computer asset1 = new Computer("True", "Kalle", office, dateOfPurchase, modelName, endOfLifeDate, priceOfAsset);
        //Computer asset2 = new Computer(computerExists, nameOfUser, office, dateOfPurchase, modelName, endOfLifeDate, priceOfAsset);
        //Computer asset3 = new Computer(computerExists, nameOfUser, office, dateOfPurchase, modelName, endOfLifeDate, priceOfAsset);

        List<Tools> assetItems = new List<Tools>(); // List contining assets

        //assetItem.Add.....

        while (true)
        {

            DisplayMenu();

            string choice = Console.ReadLine();

            switch (choice)
            // Använder switch/case i stället för en if else loops
            // för att hantera användarens val

            {

                case "1":
                    {
                        AddTool(assetItems); // Kalla på metod för att lägga till nytt verktyg
                        break;
                    }

                case "2":
                    {
                        
                        ShowAssets(assetItems); // Kalla på metod för att visa (skriva ut) verkyg
                        break;
                    }

                case "q":

                    return; // Exit the program

                default:
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
                }
            }
        }


        static void DisplayMenu()

        {
            //Skriv ut menyn

            Console.WriteLine("\nMenu");
            Console.WriteLine("\n====");
            Console.WriteLine();
            Console.WriteLine("1. Add asset");
            Console.WriteLine("2. Show assets");
           
            Console.WriteLine("q. Quit");
            Console.Write("Enter your choice: ");

        }


        static void ShowAssets(List<Tools> assetItems)
        {
            //Skriver ut listan 

            Console.WriteLine("Sparade assets");
            Console.WriteLine("==============\n");

            foreach (Computer item in assetItems)
            {
                
                //Console.WriteLine($"{item.GetType()}"); //var en computer
               
                Console.WriteLine($"{item.DateOfPurchase} : {item.Name} : {item.PriceOfAsset} : {item.Office}");
            }

            foreach (Phone item in assetItems)
            {

                Console.WriteLine($"{item.DateOfPurchase} : {item.Name} : {item.PriceOfAsset} : {item.Office}");
            }

        }

        static void AddTool(List<Tools> assetItems)     
        {
            Console.WriteLine("\nEnter asset computer(c) or phone(p):");

            string assetType = Console.ReadLine();
            assetType = assetType.ToLower().Trim();

            if (assetType == "c")
            {
                //skapa nytt computer object i lista
                addNewComputer(assetItems) ;
            }
            else if (assetType == "p")
            {
                //skapa nytt phone object i lista
                //AddnewPhpne();
            }
            else
            {
                Console.WriteLine("error when selecting asset type");
                //break;

            }
        }

    }

    public static void addNewComputer(List<Tools> assetItems)

    {

       Console.Write("asset Name: ");
       string AssetName = Console.ReadLine();
        Console.Write("Office: ");
        string office = Console.ReadLine();

        Console.Write("Brand of computer: ");
        string brandName = Console.ReadLine();

        Console.Write("modellname: ");
        string modelName = Console.ReadLine();

        Console.Write("Datue (only date): ");
        string Dday = Console.ReadLine();
        Console.Write("Month (only month): ");
        string DMonth = Console.ReadLine();
        Console.Write("Year (only year 4 digits): ");
        string Dyear = Console.ReadLine();

        string dateOfPurchase = Dyear + "-" + DMonth + "-" + Dday;

        int TempYear = Int32.Parse(Dyear);
        TempYear = TempYear + 3;
        string DTempYear = TempYear.ToString();

        string endOfLifeDate = (DTempYear + "-" + DMonth + "-" + Dday); // Add 3 years to end of life for product

        try
        {

            DateTime Test2 = Convert.ToDateTime(dateOfPurchase);
        }
        catch (Exception)
        {
            Console.WriteLine("Datumformat felaktigt");
            throw;
        }

        Console.Write("Name of the person using the asset: ");
        string nameOfUser = Console.ReadLine();

        bool computerExists = true;
        bool phoneExists = false;

        Console.Write("Price: ");
        double priceOfAsset = Convert.ToDouble(Console.ReadLine());


        Computer asset = new Computer(computerExists, nameOfUser, office, dateOfPurchase, modelName, endOfLifeDate, priceOfAsset);

        assetItems.Add(asset);
        Console.WriteLine("Computer added successfully.");
    }
}

