using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section07 {
    class Program {
        static void Main(string[] args) {

            var str = "123";

            int heigth;
            if (int.TryParse(str,out heigth)) {
                //heigthには変換された値が入っている
                Console.WriteLine(heigth);
            }
            else {
                //変換が失敗した
                Console.WriteLine("変換できません");
            }
        }
    }
}
