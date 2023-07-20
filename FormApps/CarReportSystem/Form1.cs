using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace CarReportSystem {
    public partial class Form1 : Form {
        //管理用データ
        BindingList<CarReport> CarReports = new BindingList<CarReport>();
        private uint mode;

        //設定情報保存用オブジェクト
        Settings settings = new Settings();

        public Form1() {
            InitializeComponent();
            dgvCarReports.DataSource = CarReports;
        }

        private void statusLabelDisp(string msg) {
            tsInfoText.Text = msg;
        }

        //追加ボタンがクリックされた時のイベントハンドラー
        private void btAddReport_Click(object sender, EventArgs e) {
            if(cbAuthor.Text.Equals("")) {
                statusLabelDisp("記録者を入力してください");
                return;
            }else if(cbCarName.Text.Equals("")) {
                statusLabelDisp("車名を入力してください");
                return;
            }
            
            var car = new CarReport {
                Date = dtpDate.Value,
                Author = cbAuthor.Text,
                Maker = GetSaletedMaker(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                CarImage = pbCarImage.Image,
            };
            CarReports.Add(car);
            if (!cbAuthor.Items.Contains(cbAuthor.Text)) cbAuthor.Items.Add(cbAuthor.Text);
            if (!cbCarName.Items.Contains(cbCarName.Text)) cbCarName.Items.Add(cbCarName.Text);
            Clear();
            dgvCarReports.CurrentRow.Selected = false;
            
        }

        private void Clear() {
            dtpDate.ResetText();
            cbAuthor.Text = "";
            foreach (var item in gbMaker.Controls) {
                if (((RadioButton)item).Checked) {
                    ((RadioButton)item).Checked = false;
                }
            }
            cbCarName.Text = "";
            tbReport.Text = "";
            pbCarImage.Image = null;
        }

        private CarReport.MakerGroup GetSaletedMaker() {
            foreach (var item in gbMaker.Controls) {
                if (((RadioButton)item).Checked) {
                    return (CarReport.MakerGroup)int.Parse(((RadioButton)item).Tag.ToString());
                }
            }
            return CarReport.MakerGroup.その他;
            //if (rbToyota.Checked) {
            //    return CarReport.MakerGroup.トヨタ;
            //}else if (rbNissan.Checked) {
            //    return CarReport.MakerGroup.日産;
            //}else if (rbHonda.Checked) {
            //    return CarReport.MakerGroup.ホンダ;
            //}else if (rbSubaru.Checked) {
            //    return CarReport.MakerGroup.スバル;
            //}else if (rbSuzuki.Checked) {
            //    return CarReport.MakerGroup.スズキ;
            //}else if (rbDaihatsu.Checked) {
            //    return CarReport.MakerGroup.ダイハツ;
            //}else if (rbImported.Checked) {
            //    return CarReport.MakerGroup.輸入車;
            //}
            //return CarReport.MakerGroup.その他;
        }

        //指定したメーカーのラジオボタンをセット
        private void setSelectedMaker(CarReport.MakerGroup makerGroup) {
            switch (makerGroup) {
                case CarReport.MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.日産:
                    rbNissan.Checked = true;
                    break;
                case CarReport.MakerGroup.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case CarReport.MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case CarReport.MakerGroup.スズキ:
                    rbSuzuki.Checked = true;
                    break;
                case CarReport.MakerGroup.ダイハツ:
                    rbDaihatsu.Checked = true;
                    break;
                case CarReport.MakerGroup.輸入車:
                    rbImported.Checked = true;
                    break;
                case CarReport.MakerGroup.その他:
                    rbOther.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private void btImageOpen_Click(object sender, EventArgs e) {
            ofdImageFileOpen.ShowDialog();
            pbCarImage.Image = Image.FromFile(ofdImageFileOpen.FileName);
        }

        private void btDeleteReport_Click(object sender, EventArgs e) {
            CarReports.RemoveAt(dgvCarReports.CurrentRow.Index);
            if (dgvCarReports.Rows.Count == 0) {
                btDeleteReport.Enabled = false;
                btModifyReport.Enabled = false;
            }
            Clear();
            //DataGridViewSelectedRowCollection src = dgvCarReports.SelectedRows;
            //for (int i = src.Count - 1; i >= 0; i--) {
            //    dgvCarReports.Rows.RemoveAt(src[i].Index);
            //}
        }

        private void Form1_Load(object sender, EventArgs e) {
            dgvCarReports.Columns[5].Visible = false;  //画像項目非表示
            statusLabelDisp(""); //ステータスラベルのテキスト非表示

            using (var reader = XmlReader.Create("settings.xml")) {
                var serializer = new XmlSerializer(typeof(Settings));
                settings = serializer.Deserialize(reader) as Settings;
                BackColor = Color.FromArgb(settings.MainFormColor);
            }
            

            tssTimeNow.Text = DateTime.Now.ToString("yyyy年MM月dd日HH時mm分ss秒");
            tmTimeDisp.Start();
        }
        private void tmTimeDisp_Tick(object sender, EventArgs e) {
            tssTimeNow.Text = DateTime.Now.ToString("yyyy年MM月dd日HH時mm分ss秒");
        }

        private void dgvCarReports_Click(object sender, EventArgs e) {
            if (dgvCarReports.RowCount == 0) return;
            dtpDate.Value = (DateTime)dgvCarReports.CurrentRow.Cells[0].Value;
            cbAuthor.Text = dgvCarReports.CurrentRow.Cells[1].Value.ToString();
            setSelectedMaker((CarReport.MakerGroup)dgvCarReports.CurrentRow.Cells[2].Value);
            cbCarName.Text = dgvCarReports.CurrentRow.Cells[3].Value.ToString();
            tbReport.Text = dgvCarReports.CurrentRow.Cells[4].Value.ToString();
            pbCarImage.Image = (Image)dgvCarReports.CurrentRow.Cells[5].Value;

            btModifyReport.Enabled = true;
            btDeleteReport.Enabled = true;
        }

        private void btModifyReport_Click(object sender, EventArgs e) {
            if (dgvCarReports.Rows.Count == 0) btModifyReport.Enabled = false;

            if (cbAuthor.Text.Equals("")) {
                statusLabelDisp("記録者を入力してください");
                return;
            }
            else if (cbCarName.Text.Equals("")) {
                statusLabelDisp("車名を入力してください");
                return;
            }
            CarReports[dgvCarReports.CurrentRow.Index].Date = dtpDate.Value;
            CarReports[dgvCarReports.CurrentRow.Index].Author = cbAuthor.Text;
            CarReports[dgvCarReports.CurrentRow.Index].Maker = GetSaletedMaker();
            CarReports[dgvCarReports.CurrentRow.Index].CarName = cbCarName.Text;
            CarReports[dgvCarReports.CurrentRow.Index].Report = tbReport.Text;

            dgvCarReports.Refresh();//一覧更新

            
            //dgvCarReports.CurrentRow.Cells[0].Value = dtpDate.Value;
            //dgvCarReports.CurrentRow.Cells[1].Value = cbAuthor.Text;
            //dgvCarReports.CurrentRow.Cells[2].Value = GetSaletedMaker();
            //dgvCarReports.CurrentRow.Cells[3].Value = cbCarName.Text;
            //dgvCarReports.CurrentRow.Cells[4].Value = tbReport.Text;
            //dgvCarReports.CurrentRow.Cells[5].Value = pbCarImage.Image;
        }

        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void バージョン情報ToolStripMenuItem_Click(object sender, EventArgs e) {
            var vf = new VersionForm();
            vf.ShowDialog();  //モーダルダイアログとして表示
        }

        private void btImageDelete_Click(object sender, EventArgs e) {
            pbCarImage.Image = null;
        }

        private void カラーToolStripMenuItem_Click(object sender, EventArgs e) {
            if(cdColor.ShowDialog() == DialogResult.OK) {
                BackColor = cdColor.Color;
                settings.MainFormColor = cdColor.Color.ToArgb();
            }
            //cdColor.ShowDialog();
            //this.BackColor = cdColor.Color;
        }

        private void btScaleChange_Click(object sender, EventArgs e) {
            mode = mode < 4 ? ((mode == 1) ? 3 : ++mode) : 0; //AutoSize(2)を除外
            pbCarImage.SizeMode = (PictureBoxSizeMode)mode;
        }

        private void tmTimeDisp_Tick_1(object sender, EventArgs e) {
            tssTimeNow.Text = DateTime.Now.ToString("yyyy年MM月dd日HH時mm分ss秒");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {

            //設定ファイルのシリアル化
            using(var writer = XmlWriter.Create("settings.xml")) {
                var serializer = new XmlSerializer(settings.GetType());
                serializer.Serialize(writer, settings);
            }
        }
    }
}
