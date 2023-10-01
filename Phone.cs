using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_230930
{
    internal class Phone : Tools
    { 
        //public bool Computer { get; set; }
        //public bool Phone { get; set; }
        //public string Office { get; set; }
        //public string DateOfPurchase { get; set; }
        public string ModelName { get; set; }
        public string EndOfLifeDate { get; set; }
        public Phone(bool computerExists, bool phoneExists, string name, string office, string modelName, string endOfLifeDate)
        {

            ModelName = modelName;
            EndOfLifeDate = endOfLifeDate;
        }
    }
}
