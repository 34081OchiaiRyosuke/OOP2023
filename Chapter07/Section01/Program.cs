using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var ken = new Dictionary<string, CityInfo>() {
            };
            Console.Write("県名:");
            var kenmei = Console.ReadLine();

            while (kenmei != "999") {
                var cityinfo = new CityInfo();
                Console.Write("所在地:");
                cityinfo.City = Console.ReadLine();
                Console.Write("人口を入力");
                cityinfo.Population = int.Parse(Console.ReadLine());
                ken[kenmei] = new CityInfo { City = cityinfo.City, Population = cityinfo.Population };
                Console.Write("県名:");
                kenmei = Console.ReadLine();
                if (ken.ContainsKey(kenmei)) {
                    Console.WriteLine("重複しています、上書きしますか yes/no");
                    var uwagaki = Console.ReadLine();
                    if(uwagaki == "no") {
                        Console.Write("県名:");
                        kenmei = Console.ReadLine();
                    }
                }
            }
            Console.WriteLine("1:一覧表示,2:県名指定");
            var hyoji = Console.ReadLine();
            if (hyoji == "1") {
                foreach (var item in ken) {
                    Console.WriteLine("{0}({1}[{2}])",item.Key, item.Value.City,item.Value.Population);
                }
            }
            else {
                Console.Write("県名を入力:");
                var Kenmei = Console.ReadLine();
                Console.WriteLine("{0}です。", ken[Kenmei]);
            }
        }
    }
    class CityInfo {
        public string City { get; set; }　　　//都市
        public int Population { get; set; }   //人口
    }
}
