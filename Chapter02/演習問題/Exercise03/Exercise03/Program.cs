using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        public static int num { get; internal set; }

        static void Main(string[] args) {

            Console.Write("店舗別は１、商品別は２:");

            var sales = new SalesCounter(@"data\sales.csv");
            var amountParStore = sales.GetParStoreSales();
            foreach (var obj in amountParStore) {
                Console.WriteLine("{0} {1:C}", obj.Key, obj.Value);
            }
        }
    }
}
