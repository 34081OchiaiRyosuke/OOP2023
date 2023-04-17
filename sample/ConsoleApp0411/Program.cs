using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0411 {
    class Program {
        static void Main(string[] args) {

            string[] monayString = { "一万円札", "五千円札", "二千円札", "千円札", "五百円玉", "百円玉", "五十円玉", "十円玉", "五円玉", "一円玉" };
            int[] moneyInteger = { 10000, 5000, 2000, 1000, 500, 100, 50, 10, 5, 1 };
            
            Console.Write("請求金額:");
            int okaikei = int.Parse(Console.ReadLine());
            Console.Write("支払金額:");
            int shiharai = int.Parse(Console.ReadLine());
            int otsuri = shiharai - okaikei;
            Console.WriteLine("おつりは" + otsuri);

            for (int i = 0; i < monayString.Length; i++)
            {
                Console.WriteLine(monayString[i] + ":{0}枚", otsuri / moneyInteger[i]);
                astOut(otsuri / moneyInteger[i]);
                otsuri %= moneyInteger[i];
            }

            
            //int man = otsuri / 10000;
            //int gosen = otsuri % 10000 / 5000;
            //int nisen = otsuri % 10000 % 5000 / 2000;
            //int sen = otsuri % 10000 % 5000 % 2000 / 1000;
            //int gohyaku = otsuri % 10000 % 5000 % 2000 % 1000 / 500;
            //int hyaku = otsuri % 10000 % 5000 % 2000 % 1000 % 500 / 100;
            //int goju = otsuri % 10000 % 5000 % 2000 % 1000 % 500 % 100 / 50;
            //int ju = otsuri % 10000 % 5000 % 2000 % 1000 % 500 % 100 % 50 /10;
            //int iti = otsuri % 10000 % 5000 % 2000 % 1000 % 500 % 100 % 50 % 10;

            //Console.Write("一万円札が");
            //for (int i = 0; i < man; i++)
            //{
            // Console.Write("*");
            //}
            //Console.WriteLine();
            //Console.Write("五千円札が");
            //for (int i = 0; i < gosen; i++)
            //{
            //Console.Write("*");
            //}
            // Console.WriteLine();
            //  Console.Write("二千円札が");
            //  for (int i = 0; i < nisen; i++)
            //  {
            // Console.Write("*");
            //  }
            //   Console.WriteLine();
            //   Console.Write("千円札が");
            //   for (int i = 0; i < sen; i++)
            //   {
            // Console.Write("*");
            // }
            //     Console.WriteLine();
            //     Console.Write("五百円が");
            //    for (int i = 0; i < gohyaku; i++)
            //    {
            //Console.Write("*");
            // }
            //    Console.WriteLine();
            //Console.Write("百円が");
            //for (int i = 0; i < hyaku; i++)
            //{
            //Console.Write("*");
            //}
            //Console.WriteLine();
            //Console.Write("五十円が");
            //for (int i = 0; i < goju; i++)
            //{
            //Console.Write("*");
            //}
            //     Console.WriteLine();
            //Console.Write("十円が");
            //for (int i = 0; i < ju; i++)
            //{
            //Console.Write("*");
            //}
            //Console.WriteLine();
            //Console.Write("一円が");
            //for (int i = 0; i < iti; i++)
            //{
            //Console.Write("*");
            //}
        }
        private static void astOut(int count) {
            for (int i = 0; i < count; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
