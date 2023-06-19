using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _score = ReadScore(filePath);
        }


        //メソッドの概要： 
        private static IEnumerable<Student> ReadScore(string filePath) {
            var scores = new List<Student>();//点数データを格納する
            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines) {
                var items = line.Split(',');
                var sale = new Student {
                    Name = items[0],
                    Subject = items[1],
                    Score = int.Parse(items[2])
                };
                scores.Add(sale);
            }
            return scores;
        }

        //メソッドの概要： 
        public IDictionary<string, int> GetPerStudentScore() {
            var dict = new Dictionary<string, int>();

            foreach (var score in _score) {

                if (dict.ContainsKey(score.Subject))
                    dict[score.Subject] += score.Score;//科目名が既に存在する
                else {
                    dict[score.Subject] = score.Score; //科目名が存在しない
                }
            }
            return dict;
        }
    }
}

