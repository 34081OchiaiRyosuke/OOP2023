using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var number = new List<int> { 9, 7, 5, 4, 2, 5, 4, 0, 4, 1, 0, 4 };
            Console.WriteLine(number.Average());

            var books = Books.GetBooks();

            //500円以上の本のタイトルをすべて出力
            var booksObj = books.Where(x => x.Title.Contains("物語")).OrderByDescending(x => x.Price).Average(x => x.Pages);
            Console.WriteLine("平均{0}ページ",booksObj);

            var longTitleBooks = books.OrderByDescending(x => x.Title.Length);

            foreach (var book in longTitleBooks) {
                Console.WriteLine("{0} {1}", book.Title, book.Price);
            }


        }
    }
}
