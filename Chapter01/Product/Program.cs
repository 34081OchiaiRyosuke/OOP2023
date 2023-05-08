using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSample {

    class Program {
        static void Main(string[] args) {

            #region P25のサンプルプログラム
            //インスタンスの生成
            //Product karinto = new Product(123, "かりんとう", 180);
            //Product daifukumoti = new Product(235, "大福もち", 160);
            //Console.WriteLine("税込み価格" + karinto.GetPriceIncludingTax());
            //Console.WriteLine("税込み価格" + daifukumoti.GetPriceIncludingTax());
            #endregion

            
            DateTime date = DateTime.Today;

            //10日後を求める
            DateTime daysAfter10 = date.AddDays(10);

            //10日前を求める
            DateTime daysBefore10 = date.AddDays(-10);


            Console.WriteLine("今日の日付:" + date);
            Console.WriteLine("今日の10日後は" + daysAfter10.ToString(@"yyyy\/MM\/dd") + "日です");
            Console.WriteLine("今日の10日後は" + daysBefore10.ToString(@"yyyy\/MM\/dd") + "日です");


        }
    }
}
