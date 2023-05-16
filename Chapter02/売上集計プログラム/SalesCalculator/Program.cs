using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalculator {
    class Program {
        static void Main(string[] args) {
            SalesCounter sales = new SalesCounter(@"data\sales.csv");
            Dictionary<string, int> amountParStore = sales.GetParStoreSales();
            foreach (KeyValuePair<string, int> obj in amountParStore) {
                Console.WriteLine("{0} {1:C}", obj.Key, obj.Value);
            }
        }
    }
}
