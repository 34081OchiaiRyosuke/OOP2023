using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            tbTimeNow.Text = DateTime.Now.ToString("yyyy年MM月dd日HH時mm分ss秒");
            tmTimeDisp.Start();
        }
        private void btDayCalc_Click(object sender, EventArgs e) {
            var dtp = dtpDate.Value;
            var now = DateTime.Now;

            tbMessage.Text = "入力した日にちから" + (now - dtp).Days + "日経過";
        }

        private void btAge_Click(object sender, EventArgs e) {
            var age =  GetAge(dtpDate.Value, DateTime.Now);
            tbMessage.Text = "あなたの年齢は" + age + "です";
            //var dtp = dtpDate.Value;
            //var now = DateTime.Now;

            //tbMessage.Text = ((now - dtp ).Days / 365) + "才です";
        }
        public static int GetAge (DateTime birthday, DateTime targetDay) {
            var age = targetDay.Year - birthday.Year;
            if(targetDay < birthday.AddYears(age)) {
                age--;
            }
            return age;
        }

        //タイマーイベントハンドラー
        private void tmTimeDisp_Tick(object sender, EventArgs e) {
            tbTimeNow.Text = DateTime.Now.ToString("yyyy年MM月dd日HH時mm分ss秒");
        }

        
    }
}