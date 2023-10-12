using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();

        }

        private static void Exercise1_2() {
            foreach (var maxbook in Library.Books.Where(b => b.Price ==  Library.Books.Max(m => m.Price))) {
                Console.WriteLine(maxbook);
            } 
        }

        private static void Exercise1_3() {
            var group = Library.Books.GroupBy(b => b.PublishedYear).OrderBy(g => g.Key);
            foreach (var g in group) {
                Console.WriteLine("{0}年 {1}冊",g.Key,g.Count());
            }
        }

        private static void Exercise1_4() {
            var books = Library.Books
                                 .Join(Library.Categories, book =>book.CategoryId, category => category.Id, (book, category) => new {
                                     book.PublishedYear,
                                     book.Price,
                                     book.Title,
                                     CategoryName = category.Name,
                                 })
                                 .OrderByDescending(x => x.PublishedYear)
                                 .ThenByDescending(x => x.Price);

            foreach (var item in books) {
                Console.WriteLine("{0}年 {1}円 {2} ({3})",
                                    item.PublishedYear,
                                    item.Price,
                                    item.Title,
                                    item.CategoryName
                                    );
            }
        }

        private static void Exercise1_5() {
            var names = Library.Books
                               .Where(b => b.PublishedYear == 2016)
                               .Join(Library.Categories,
                                        book => book.CategoryId,
                                        category => category.Id,
                                        (book, category) => category.Name)
                               .Distinct();
            foreach (var name in names) {
                Console.WriteLine(name);
            }                        
        }       

        private static void Exercise1_6() {
            var books = Library.Books
                                 .Join(Library.Categories, book => book.CategoryId, category => category.Id, (book, category) => new {
                                     book.PublishedYear,
                                     book.Price,
                                     book.Title,
                                     CategoryName = category.Name,
                                 })
                                 .GroupBy(x => x.CategoryName)
                                 .OrderBy(x => x.Key);

            foreach (var group in books) {
                Console.WriteLine("#{0}", group.Key);
                foreach (var item in group) {
                    Console.WriteLine(" {0} ", item.Title);
                }
            }
        }

        private static void Exercise1_7() {
            
        }

        private static void Exercise1_8() {
            
        }
    }
}
