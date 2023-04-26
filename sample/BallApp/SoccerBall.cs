using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallApp {
    class SoccerBall : Obj {
               
        private static int count;
        public Random rnd = new Random();
        
        public static int Count { get => count; set => count = value; }

        //コンストラクタ
        public SoccerBall(double xp, double yp) :base(xp,yp, @"pic\soccer_ball.png") {
                      
            int rndX = rnd.Next(-15, 15);
            MoveX = (rndX != 0 ? rndX : 1);//乱数で移動量を設定

            int rndY = rnd.Next(-15, 15);
            MoveY = (rndY != 0 ? rndY : 1);//乱数で移動量を設定

            Count++;
        }

        //メソッド
        public override void Move() {

            PosX += MoveX;
            PosY += MoveY;

            if (PosX > 740 || PosX < 0)
            {
                MoveX *= -1;
            }
            else if (PosY > 520 || PosY < 0)
            {
                MoveY *= -1;
            }
        }
    }
}
