using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            var names = new List<string> {
                 "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
            };
            Exercise2_1(names);
            Console.WriteLine();
            Exercise2_2(names);
            Console.WriteLine();
            Exercise2_3(names);
            Console.WriteLine();
            Exercise2_4(names);
        }

        private static void Exercise2_1(List<string> names) {
            Console.Write("都市名を入力、空白で終了:");
            do {
                var city = Console.ReadLine();
                if (string.IsNullOrEmpty(city)){
                    break;
                }
                var list = names.FindIndex(n => n == city);
                Console.WriteLine(list);
            } while (true);
             
        }

        private static void Exercise2_2(List<string> names) {
            var city = names.Count(n => n.Contains("o"));
            Console.WriteLine(city);
        }

        private static void Exercise2_3(List<string> names) {
            names.Where(n => n.Contains("o")).ToList().ForEach(Console.WriteLine);
        }

        private static void Exercise2_4(List<string> names) {
            
        }
    }
}
