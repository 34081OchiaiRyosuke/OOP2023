﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            if(args.Length < 3) {
                return;
            }

            int start = int.Parse(args[1]);
            int end = int.Parse(args[2]);

            switch (args[0]) {
                case "-tom":
                    PrintInchToMeterList(start, end);
                    break;

                case "-toi":
                    PrintMeterToInchList(start, end);
                    break;
            
            }
           // if (args[0] == "-tom") {
           //     PrintInchToMeterList(int.Parse(args[1]), int.Parse(args[2]));
           // }
           // else if(args[0] == "-toi"){
           //     PrintMeterToInchList(int.Parse(args[1]), int.Parse(args[2]));
           // }
        }

        //インチからメートルへの対応表を出力
        private static void PrintInchToMeterList(int start, int stop) {

            for (int Inch = start; Inch <= stop; Inch++) {
                double meter = InchConverter.ToMeter(Inch);
                Console.WriteLine("{0} inch = {1:0.0000}m", Inch, meter);
            }
        }

        //メートルからインチへの対応表を出力
        private static void PrintMeterToInchList(int start, int stop) {

            for (int meter = start; meter <= stop; meter++) {
                double inch = InchConverter.FromMeter(meter);
                Console.WriteLine("{0} m = {1:0.0000}inch", meter, inch);
            }
        }
    }
}
