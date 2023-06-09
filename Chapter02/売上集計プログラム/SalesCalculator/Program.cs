﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalculator {
    class Program {
        static void Main(string[] args) {
            var sales = new SalesCounter(@"data\sales.csv");
            var amountParStore = sales.GetParStoreSales();
            foreach (var obj in amountParStore) {
                Console.WriteLine("{0} {1:C}", obj.Key, obj.Value);
            }
        }
    }
}
