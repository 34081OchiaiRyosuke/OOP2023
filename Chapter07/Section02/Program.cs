using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section02 {
    class Program {
        static void Main(string[] args) {
            var ken = new Dictionary<string, List<CityInfo>>() {
            };
            Console.WriteLine("都市の登録");
            Console.Write("県名:");
            var kenmei = Console.ReadLine();

            while (kenmei != "999") {
                var cityinfo = new CityInfo();
                Console.Write("市町村:");
                cityinfo.City = Console.ReadLine();
                Console.Write("人口を入力");
                cityinfo.Population = int.Parse(Console.ReadLine());
                if (ken.ContainsKey(kenmei)) {
                    //List<Cityinfo>が存在するためaddで市町村データを追加
                    ken[kenmei].Add(cityinfo);
                }
                else {
                    //List<Cityinfo>が存在しないため、Listを作成(new)して市町村データを追加
                    ken[kenmei] = new List<CityInfo> { cityinfo };
                }
                Console.Write("県名:");
                kenmei = Console.ReadLine();
            }
            Console.WriteLine("1:一覧表示,2:県名指定");
            var hyoji = Console.ReadLine();
            if (hyoji == "1") {
                foreach (var item in ken) {
                    foreach (var items in item.Value.OrderByDescending(o => o.Population)) {
                        Console.WriteLine("{0}({1}[{2}])", item.Key, items.City, items.Population);
                    }
                }
            }
            else {
                Console.Write("県名を入力:");
                var Kenmei = Console.ReadLine();
                foreach (var item in ken[Kenmei]) {
                    Console.WriteLine("【{0}(人口:{1}人)】", item.City, item.Population);
                }
                
            }
        }
    }
    class CityInfo {
        public string City { get; set; }　　　//都市
        public int Population { get; set; }   //人口
    }
}

