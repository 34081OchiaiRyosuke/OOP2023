using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section03 {
    class Program {
        static void Main(string[] args) {
            var abbs = new Abbreviations();

            //Addメソッドの呼び出し
            abbs.Add("IOC", "国際オリンピック委員会");
            abbs.Add("NPT", "核兵器不拡散条約");

            //インデクサの利用例
            var names = new[] { "WHO", "FIFA", "NPT", };
            foreach (var name in names) {
                var fullname = abbs[name];
                if(fullname == null) {
                    Console.WriteLine("{0}は見つかりません", name);
                }
                else {
                    Console.WriteLine("{0}={1}", name, fullname);
                }
            }
            Console.WriteLine();//改行

            //ToAbbreviationメソッドの利用例
            var japanesse = "東南アジア諸国連合";
            var abbreviation = abbs.ToAbbreviation(japanesse);
            if (abbreviation == null) {
                Console.WriteLine("{0}は見つかりません", japanesse);
            }
            else {
                Console.WriteLine("{0}={1}", japanesse, abbreviation);
            }

            //FillAllメソッドの利用例
            foreach (var item in abbs.FindAll("国際")) {
                Console.WriteLine("{0}={1}", item.Key, item.Value);
            }
            Console.WriteLine();
        }
    }
}
