using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            var text = "Cozy lummox gives smart squid who asks for job pen";
            Exercise1_1(text);
            Console.WriteLine();
            Exercise1_2(text);
        }

        private static void Exercise1_1(string text) {
            var dict = new Dictionary<Char, int>();
            
            foreach (var texts in text) {
                var Text = char.ToUpper(texts);
                if ('A' <= Text && Text <= 'Z') {

                }
                if (dict.ContainsKey(Text))
                    dict[Text] += 1;
                else {
                    dict[Text] = 1;
                }
            }
            foreach (var item in dict) {
                Console.Write("'{0}':{1}", item.Key, item.Value);
                Console.Write(" ");
            }
        }

        private static void Exercise1_2(string text) {
            var dict = new SortedDictionary<Char, int>();

            foreach (var texts in text) {
                var Text = char.ToUpper(texts);
                if ('A' <= Text && Text <= 'Z') {

                }
                if (dict.ContainsKey(Text))
                    dict[Text] += 1;
                else {
                    dict[Text] = 1;
                }
            }
            foreach (var item in dict) {
                Console.Write("'{0}':{1}", item.Key, item.Value);
                Console.Write(" ");
            }
        }
    }
}
