using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {
        //取得データ保存用
        List<ItemData> itemdatas = new List<ItemData>();
        List<LikeData> likedatas = new List<LikeData>();

        public Form1() {
            InitializeComponent();
        }
        private void btGet_Click(object sender, EventArgs e) {
            try {
                if (tbUrl.Text == "")
                    return;

                lbRssTitle.Items.Clear();

                using (var wc = new WebClient()) {
                    var url = wc.OpenRead(tbUrl.Text);
                    XDocument xdoc = XDocument.Load(url);

                    itemdatas = xdoc.Root.Descendants("item")
                                            .Select(x => new ItemData {
                                                Title = (string)x.Element("title"),
                                                Link = (string)x.Element("link"),
                                            }).ToList();

                    foreach (var node in itemdatas) {
                        lbRssTitle.Items.Add(node.Title);
                    }
                }
            }
            catch (ArgumentException) {
                return;
            }
        }

        private void lbRssTitle_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                wbBrowser.Navigate(itemdatas[lbRssTitle.SelectedIndex].Link);
            }
            catch (ArgumentOutOfRangeException) {
                return;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/topics/it.xml";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/topics/science.xml";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/topics/business.xml";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/topics/sports.xml";
        }

        private void btLike_Click(object sender, EventArgs e) {
            try {
                if (tbLikeTitle.Text == "") {
                    var er = new Error();
                    er.ShowDialog();
                }
                else {
                    LikeData likedata = new LikeData(tbLikeTitle.Text, itemdatas[lbRssTitle.SelectedIndex].Link.ToString());
                    likedatas.Add(likedata);
                    cbLike.Items.Add(likedata.Title);
                    tbLikeTitle.Text = "";
                }
            }
            catch (ArgumentOutOfRangeException) {
                return;
            }
            
        }

        private void cbLike_SelectedIndexChanged(object sender, EventArgs e) {
            wbBrowser.Navigate(likedatas[cbLike.SelectedIndex].Link);
        }

        private void btClear_Click(object sender, EventArgs e) {
            tbUrl.Text = "";
            tbLikeTitle.Text = "";
            lbRssTitle.Items.Clear();
            wbBrowser.DocumentText = "";
        }

        private void btDelete_Click(object sender, EventArgs e) {
            try {
                cbLike.Items.RemoveAt(cbLike.SelectedIndex);
            }
            catch (ArgumentOutOfRangeException) {
                return;
            }
        }
    }
}