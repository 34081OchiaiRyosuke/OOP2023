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

            #region 0508演習1
            //DateTime date = DateTime.Today;

            //10日後を求める
            //DateTime daysAfter10 = date.AddDays(10);

            //10日前を求める
            //DateTime daysBefore10 = date.AddDays(-10);


            //Console.WriteLine("今日の日付:" + date);
            //Console.WriteLine("今日の10日後は" + date.AddDays(10).Year + "年" + date.AddDays(10).Month + "月" + date.AddDays(10).Day + "日です");
            //Console.WriteLine("今日の10日後は" + date.AddDays(-10).Year + "年" + date.AddDays(-10).Month + "月" + date.AddDays(-10).Day + "日です");
            #endregion

            string[] DayOfWeekJP = { "日曜日", "月曜日", "火曜日", "水曜日", "木曜日", "金曜日", "土曜日" };

            Console.WriteLine("誕生日を入力");
            Console.Write("西暦:");
            int seireki = int.Parse(Console.ReadLine());
            Console.Write("月:");
            int thuki = int.Parse(Console.ReadLine());
            Console.Write("日:");
            int nichi = int.Parse(Console.ReadLine());

            DateTime date1 = new DateTime(seireki, thuki, nichi);
            DateTime date2 = DateTime.Today;

            TimeSpan interval = date2 - date1;

            Console.WriteLine("あなたが生まれてから今日まで{0}",interval.TotalDays + "日");

            Console.WriteLine(DayOfWeekJP[(int)date1.DayOfWeek]);
        }
    }
}
