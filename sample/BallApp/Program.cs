﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class Program :Form {

        private Timer moveTimer;  //タイマー用
        private PictureBox pb;


        private List<Obj> balls = new List<Obj>();//ボールインスタンス格納用
        private List<PictureBox> pbs = new List<PictureBox>();  //表示用
    
        static void Main(string[] args) {

            Application.Run(new Program());

        }
        public Program() {
            this.Size = new Size(800, 600);
            this.BackColor = Color.LawnGreen;
            this.Text = "テニスボールの数:" + TennisBall.Count + "　サッカーボールの数:" + SoccerBall.Count;

            this.MouseClick += Program_MouseClick;
            this.KeyDown += Program_KeyDown;
            
            moveTimer = new Timer();
            moveTimer.Interval = 1; //タイマーのインターバル            
            moveTimer.Tick += MoveTimer_Tick;  //デリゲート登録
            }

        //キーが押された時のイベントハンドラ
        private void Program_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Right)
            {

            }
        }

        //マウスクリック時のイベントハンドラ
        private void Program_MouseClick(object sender, MouseEventArgs e) {

            Obj obj;
            pb = new PictureBox();//画像を表示するコントロール


            if (e.Button == MouseButtons.Right)
            {
                //ボールインスタンス生成
                obj = new TennisBall(e.X - 25, e.Y - 25);
                pb.Size = new Size(25, 25);

            }
            else
            {
                //ボールインスタンス生成
                obj = new SoccerBall(e.X - 25, e.Y - 25);
                pb.Size = new Size(50, 50);

            }

            this.Text = "テニスボールの数:" + TennisBall.Count + "　サッカーボールの数:" + SoccerBall.Count;

            pb.Image = obj.Image;
            pb.Location = new Point((int)obj.PosX, (int)obj.PosY);//画像の位置
            pb.SizeMode = PictureBoxSizeMode.StretchImage;   //画像の表示モード
            pb.Parent = this;

            balls.Add(obj);
            pbs.Add(pb);

            moveTimer.Start();   //タイマースタート
        }

        //タイマータイムアウト時のイベントハンドラ
        private void MoveTimer_Tick(object sender, EventArgs e) {

            for (int i = 0; i < balls.Count; i++)
            {
                balls[i].Move();  //移動
                pbs[i].Location = new Point((int)balls[i].PosX, (int)balls[i].PosY);//画像の位置
            }
        }
    }
}
