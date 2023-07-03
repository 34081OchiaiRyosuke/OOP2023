﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            
            foreach (var dayofweek in Enum.GetValues(typeof(DayOfWeek))) {
                DateTime nextweek = NextWeek(DateTime.Today, (DayOfWeek)dayofweek);
                Console.WriteLine("{0}の次週の{1}:{2}",DateTime.Today.ToString("yyyy年MM月dd日"),nextweek.DayOfWeek,nextweek.ToString("yyyy年MM月dd日（dddd）"));
            }
        }

        public static DateTime NextWeek(DateTime date, DayOfWeek dayOfWeek) {
            var days = (int)dayOfWeek - (int)(date.DayOfWeek);
            if (days >= -1)
                days += 7;
            return date.AddDays(days);
        }
    }
}
