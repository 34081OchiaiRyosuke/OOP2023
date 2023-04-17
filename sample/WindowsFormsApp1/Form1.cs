using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void btButton_Click(object sender, EventArgs e) {
            //int ans = int.Parse(tbnum1.Text) + int.Parse(tbnum2.Text);
            //tbans.Text = ans.ToString();
            //this.BackColor = Color.Red;

            int num1 = int.Parse(tbnum1.Text);
            int num2 = int.Parse(tbnum2.Text);
            int sum = num1 + num2;
            tbans.Text = sum.ToString();
        }

        private void tbTextArea_TextChanged(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e) {

        }

        //イベントハンドラ
        private void btPow_Click(object sender, EventArgs e) {

            double result = Math.Pow((double)x.Value, (double)y.Value);
            tbResult.Text = result.ToString();
            
            //一行で書く場合
            //tbResult.Text = (Math.Pow((double)x.Value, (double)y.Value)).ToString();
        }
    }
}
