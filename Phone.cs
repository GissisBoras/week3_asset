using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_230930
{
    internal class Phone : Tools
    { 

        public string ModelName { get; set; }
        public string EndOfLifeDate { get; set; }

        public Phone(bool phoneExists, string nameOfUser, string office, string dateOfPurchase, string modelName, string endOfLifeDate, double priceOfAsset)

        {

            ModelName = modelName;
            EndOfLifeDate = endOfLifeDate;
        }
    }
}
