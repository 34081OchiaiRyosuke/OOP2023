using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            var dateTime = new DateTime(2019, 1, 15, 19, 48, 32);
            DisplayDatePattern1(dateTime);
            DisplayDatePattern2(dateTime);
            DisplayDatePattern3(dateTime);
            DisplayDatePattern3_2(dateTime);
        }

        private static void DisplayDatePattern1(DateTime dateTime) {
            // 2019/1/15 19:48
            var year = dateTime.Year;
            var month = dateTime.Month;
            var day = dateTime.Day;
            var hour = dateTime.Hour;
            var minute = dateTime.Minute;
            Console.WriteLine("{0}/{1}/{2} {3}:{4}",year,month,day,hour,minute);
        }

        private static void DisplayDatePattern2(DateTime dateTime) {
            // 2019年01月15日　19時48分32秒
            var year = dateTime.Year;
            var month = dateTime.Month;
            var day = dateTime.Day;
            var hour = dateTime.Hour;
            var minute = dateTime.Minute;
            var second = dateTime.Second;
            Console.WriteLine("{0}年{1}月{2}日　{3}時{4}分{5}秒", year, month, day, hour, minute,second);
        }

        private static void DisplayDatePattern3(DateTime dateTime) {
            //　平成31年　1月15日（火曜日）
            var culture = new  CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            DayOfWeek dayOfWeek = dateTime.DayOfWeek;
            var str = dateTime.ToString("ggyy年　M月d日", culture);
            
            Console.Write(str);
            if (dayOfWeek == DayOfWeek.Tuesday)
                Console.WriteLine("(火曜日)");
        }

        private static void DisplayDatePattern3_2(DateTime dateTime) {
            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();

            var dateStr = dateTime.ToString("ggyy年MM月dd日(dddd)", culture);
            var str = Regex.Replace(dateStr, @"0(\d)", "$1");
            Console.WriteLine(str);
        }
    }
}
