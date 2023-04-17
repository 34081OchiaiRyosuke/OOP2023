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
            int ans = int.Parse(tbnum1.Text) + int.Parse(tbnum2.Text);
            tbans.Text = ans.ToString();
            this.BackColor = Color.Red;
            btButton.BackColor = Color.Blue;
        }

        private void tbTextArea_TextChanged(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }
    }
}
