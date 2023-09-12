using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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
        Settings settings = Settings.getInstance();

        public Form1() {
            InitializeComponent();
            //dgvCarReports.DataSource = CarReports;
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

            DataRow newRow = infosys202309DataSet.CarReportTable.NewRow();
            newRow[1] = dtpDate.Value;
            newRow[2] = cbAuthor.Text;
            newRow[3] = getSelectedMaker();
            newRow[4] = cbCarName.Text;
            newRow[5] = tbReport.Text;
            newRow[6] = ImageToByteArray(pbCarImage.Image);

            infosys202309DataSet.CarReportTable.Rows.Add(newRow);

            var car = new CarReport {
                Date = dtpDate.Value,
                Author = cbAuthor.Text,
                Maker = getSelectedMaker(),
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

        private void setCbAuther(string auther) {
            if (!cbAuthor.Items.Contains(auther)) {
                cbAuthor.Items.Add(auther);
            }
        }

        private void setCbCarName(string auther) {
            if (!cbCarName.Items.Contains(auther)) {
                cbCarName.Items.Add(auther);
            }
        }

        private CarReport.MakerGroup getSelectedMaker() {
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
        private void setSelectedMaker(string makerGroup) {
            switch (makerGroup) {
                case "トヨタ":
                    rbToyota.Checked = true;
                    break;
                case "日産":
                    rbNissan.Checked = true;
                    break;
                case "ホンダ":
                    rbHonda.Checked = true;
                    break;
                case "スバル":
                    rbSubaru.Checked = true;
                    break;
                case "スズキ":
                    rbSuzuki.Checked = true;
                    break;
                case "ダイハツ":
                    rbDaihatsu.Checked = true;
                    break;
                case "輸入車":
                    rbImported.Checked = true;
                    break;
                case "その他":
                    rbOther.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private void btImageOpen_Click(object sender, EventArgs e) {
            if (ofdImageFileOpen.ShowDialog() == DialogResult.OK) {
                pbCarImage.Image = Image.FromFile(ofdImageFileOpen.FileName);
            }
        }

        private void btDeleteReport_Click(object sender, EventArgs e) {
            dgvCarReports.Rows.RemoveAt(dgvCarReports.CurrentRow.Index);

            carReportTableTableAdapter.Update(infosys202309DataSet.CarReportTable);
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

            dgvCarReports.Columns[6].Visible = false;  //画像項目非表示
            statusLabelDisp(""); //ステータスラベルのテキスト非表示
            tssTimeNow.Text = DateTime.Now.ToString("yyyy年MM月dd日HH時mm分ss秒");
            tmTimeDisp.Start();

            dgvCarReports.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dgvCarReports.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;

            try {
                using (var reader = XmlReader.Create("settings.xml")) {
                    var serializer = new XmlSerializer(typeof(Settings));
                    settings = serializer.Deserialize(reader) as Settings;
                    BackColor = Color.FromArgb(settings.MainFormColor);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        private void tmTimeDisp_Tick(object sender, EventArgs e) {
            tssTimeNow.Text = DateTime.Now.ToString("yyyy年MM月dd日HH時mm分ss秒");
        }

        private void dgvCarReports_Click(object sender, EventArgs e) {
            
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

            dgvCarReports.CurrentRow.Cells[1].Value = dtpDate.Value;
            dgvCarReports.CurrentRow.Cells[2].Value = cbAuthor.Text;
            dgvCarReports.CurrentRow.Cells[3].Value = getSelectedMaker();
            dgvCarReports.CurrentRow.Cells[4].Value = cbCarName.Text;
            dgvCarReports.CurrentRow.Cells[5].Value = tbReport.Text;
            dgvCarReports.CurrentRow.Cells[6].Value = pbCarImage.Image;


            //CarReports[dgvCarReports.CurrentRow.Index].Date = dtpDate.Value;
            //CarReports[dgvCarReports.CurrentRow.Index].Author = cbAuthor.Text;
            //CarReports[dgvCarReports.CurrentRow.Index].Maker = GetSaletedMaker();
            //CarReports[dgvCarReports.CurrentRow.Index].CarName = cbCarName.Text;
            //CarReports[dgvCarReports.CurrentRow.Index].Report = tbReport.Text;

            //dgvCarReports.Refresh();//一覧更新

            this.Validate();
            this.carReportTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202309DataSet);

            
            //dgvCarReports.CurrentRow.Cells[0].Value = dtpDate.Value;
            //dgvCarReports.CurrentRow.Cells[1].Value = cbAuthor.Text;
            //dgvCarReports.CurrentRow.Cells[2].Value = GetSaletedMaker();
            //dgvCarReports.CurrentRow.Cells[3].Value = cbCarName.Text;
            //dgvCarReports.CurrentRow.Cells[4].Value = tbReport.Text;
            //dgvCarReports.CurrentRow.Cells[5].Value = pbCarImage.Image;
        }

        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] b) {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(b);
            return img;
        }

        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img) {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
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

        private void dgvCarReports_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (dgvCarReports.RowCount == 0) return;
            dtpDate.Value = (DateTime)dgvCarReports.CurrentRow.Cells[1].Value;
            cbAuthor.Text = dgvCarReports.CurrentRow.Cells[2].Value.ToString();
            setSelectedMaker(dgvCarReports.CurrentRow.Cells[3].Value.ToString());
            cbCarName.Text = dgvCarReports.CurrentRow.Cells[4].Value.ToString();
            tbReport.Text = dgvCarReports.CurrentRow.Cells[5].Value.ToString();

            pbCarImage.Image = !dgvCarReports.CurrentRow.Cells[6].Value.Equals(DBNull.Value) && ((Byte[])dgvCarReports.CurrentRow.Cells[6].Value).Length != 0 ? ByteArrayToImage((Byte[])dgvCarReports.CurrentRow.Cells[6].Value) : null;

            //if (!dgvCarReports.CurrentRow.Cells[6].Value.Equals(DBNull.Value)) {
            //    pbCarImage.Image = ByteArrayToImage((Byte[])dgvCarReports.CurrentRow.Cells[6].Value);
            //}
            //else {
            //    pbCarImage.Image = null;
            //}

            btModifyReport.Enabled = true;
            btDeleteReport.Enabled = true;
        }

        private void carReportTableBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.carReportTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202309DataSet);

        }

        private void 接続NToolStripMenuItem_Click(object sender, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202309DataSet.CarReportTable' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportTableTableAdapter.Fill(this.infosys202309DataSet.CarReportTable);
            dgvCarReports.ClearSelection();

            foreach (var carReport in infosys202309DataSet.CarReportTable) {
                setCbAuther(carReport.Auther);
                setCbCarName(carReport.CarName);
            }
        }

        private void btAuthorSearch_Click(object sender, EventArgs e) {
            carReportTableTableAdapter.FillByAurhor(this.infosys202309DataSet.CarReportTable, tbAuthorSearch.Text);
        }

        private void btCarNameSearch_Click(object sender, EventArgs e) {
            carReportTableTableAdapter.FillByCarName(this.infosys202309DataSet.CarReportTable, tbCarNamerSearch.Text);
        }

        private void btDateSearch_Click(object sender, EventArgs e) {
            carReportTableTableAdapter.FillByBetweenDate(this.infosys202309DataSet.CarReportTable, dtpDateSearchS.Text, dtpDateSearchE.Text);
        }

        private void btReset_Click(object sender, EventArgs e) {
            
        }
    }
}
