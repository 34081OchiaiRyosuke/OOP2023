using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class Bar : Obj {
        //コンストラクタ
        public Bar(double xp, double yp) : base(xp, yp, @"pic\bar.png") {

            MoveX = 10;
            MoveY = 0;
                      
        }

        //メソッド
        public override void Move(PictureBox pbBar, PictureBox pbBall) {

        }
        public override void Move(Keys direction) {
            if(PosX < 635)
            {
                if (direction == Keys.Right)
                {
                    PosX += 20;
                }
            }
            if(PosX > 0)
            {
                if (direction == Keys.Left)
                {
                    PosX -= 20;
                }
            }
        }
    }
}
