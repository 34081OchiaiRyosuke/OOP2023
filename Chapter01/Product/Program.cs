using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSample {
    //商品クラス
    class Program {
        static void Main(string[] args) {
            //インスタンスの生成
            Product karinto = new Product(123, "かりんとう", 180);
            Product daifukumoti = new Product(235, "大福もち", 160);
            Console.WriteLine("税込み価格" + karinto.GetPriceIncludingTax());
            Console.WriteLine("税込み価格" + daifukumoti.GetPriceIncludingTax());


        }
    }
}
