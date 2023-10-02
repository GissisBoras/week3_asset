
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Channels;
using System.Threading.Tasks;

using System.Xml.Linq;

namespace ConsoleApp1_230930
{
    class Program

    {



        static void Main()

        {
            //Computer asset1 = new Computer("True" + "-" + "Kalle" + "-" + "Borås" + "-" + "02-02-2023" + "-" + "M121" + "-" + "02-02-2026" + "-" + "1234");
            //Computer asset2 = new Computer(computerExists, nameOfUser, office, dateOfPurchase, modelName, endOfLifeDate, priceOfAsset);
            //Computer asset3 = new Computer(computerExists, nameOfUser, office, dateOfPurchase, modelName, endOfLifeDate, priceOfAsset);

            List<Tools> assetItems = new List<Tools>(); // List contining assets

            //assetItem.Add(asset1).....3St

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
                            Tools.AddTool(assetItems); // Kalla på metod för att lägga till nytt verktyg
                            break;
                        }

                    case "2":
                        {

                            Tools.ShowAssets(assetItems); // Kalla på metod för att visa (skriva ut) verkyg
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

        }

    }


}




