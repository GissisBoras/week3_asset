﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_230930
{
    internal class Computer : Tools
    {

        public string ModelName { get; set; }
        public string EndOfLifeDate { get; set; }

        //public bool ComputerExists { get; set; }
        //public bool PhoneExists { get; set; }
        //public string Office { get; set; }
        //public string DateOfPurchase { get; set; }
        //public string Name { get; set; }
        //public string PriceOfAsset { get; set; }
        public Computer(bool computerExists, string nameOfUser, string office, string dateOfPurchase,string modelName, string endOfLifeDate, double priceOfAsset)
        {

            ModelName = modelName;
            EndOfLifeDate = endOfLifeDate;
        }
    }
}