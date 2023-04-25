using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class Program :Form {

        private Timer moveTimer;  //タイマー用
        private SoccerBall soccerball;
        private TennisBall tennisball;
        private PictureBox pb;   //画像を表示するコントロール
        private PictureBox pd;

        private List<SoccerBall> balls = new List<SoccerBall>();//ボールインスタンス格納用
        private List<PictureBox> pbs = new List<PictureBox>();  //表示用
        private List<TennisBall> tennis = new List<TennisBall>();
        private List<PictureBox> pbt = new List<PictureBox>();  //表示用

        int cnt = 0;
        static void Main(string[] args) {

            Application.Run(new Program());

        }
        public Program() {
            this.Size = new Size(800, 600);
            this.BackColor = Color.LawnGreen;
            this.Text = "ボールの数:" + cnt;
            this.MouseClick += Program_MouseClick;

            
            moveTimer = new Timer();
            moveTimer.Interval = 1; //タイマーのインターバル            
            moveTimer.Tick += MoveTimer_Tick;  //デリゲート登録
            }

        //マウスクリック時のイベントハンドラ
        private void Program_MouseClick(object sender, MouseEventArgs e) {

            if(e.Button == MouseButtons.Right)
            {
                //ボールインスタンス生成
                tennisball = new TennisBall(e.X - 25, e.Y - 25);
                pd = new PictureBox();//画像を表示するコントロール
                pd.Image = tennisball.Image;
                pd.Location = new Point((int)tennisball.PosX, (int)tennisball.PosY);//画像の位置
                pd.Size = new Size(500, 50);   //画像の表示サイズ
                pd.SizeMode = PictureBoxSizeMode.StretchImage;   //画像の表示モード
                pd.Parent = this;

                tennis.Add(tennisball);
                pbt.Add(pd);
            }
            else
            {
                //ボールインスタンス生成
                soccerball = new SoccerBall(e.X - 25, e.Y - 25);
                pb = new PictureBox();//画像を表示するコントロール
                pb.Image = soccerball.Image;
                pb.Location = new Point((int)soccerball.PosX, (int)soccerball.PosY);//画像の位置
                pb.Size = new Size(50, 500);   //画像の表示サイズ
                pb.SizeMode = PictureBoxSizeMode.StretchImage;   //画像の表示モード
                pb.Parent = this;

                balls.Add(soccerball);
                pbs.Add(pb);
            }

            this.Text = "ボールの数:" + (++cnt);

            moveTimer.Start();   //タイマースタート
        }

        //タイマータイムアウト時のイベントハンドラ
        private void MoveTimer_Tick(object sender, EventArgs e) {

            for (int i = 0; i < balls.Count; i++)
            {
                balls[i].Move();  //移動
                pbs[i].Location = new Point((int)balls[i].PosX, (int)balls[i].PosY);//画像の位置
            }

            for (int j = 0; j < tennis.Count; j++)
            {
                tennis[j].Move();  //移動
                pbt[j].Location = new Point((int)tennis[j].PosX, (int)tennis[j].PosY);//画像の位置
            }
        }
    }
}
