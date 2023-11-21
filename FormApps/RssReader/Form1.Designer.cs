
namespace RssReader {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.btGet = new System.Windows.Forms.Button();
            this.lbRssTitle = new System.Windows.Forms.ListBox();
            this.wbBrowser = new System.Windows.Forms.WebBrowser();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.btLike = new System.Windows.Forms.Button();
            this.tbLikeTitle = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbLike = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btClear = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbUrl
            // 
            this.tbUrl.Font = new System.Drawing.Font("ＭＳ 明朝", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbUrl.Location = new System.Drawing.Point(12, 3);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(842, 31);
            this.tbUrl.TabIndex = 0;
            // 
            // btGet
            // 
            this.btGet.Font = new System.Drawing.Font("ＭＳ 明朝", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btGet.Location = new System.Drawing.Point(860, 3);
            this.btGet.Name = "btGet";
            this.btGet.Size = new System.Drawing.Size(111, 31);
            this.btGet.TabIndex = 1;
            this.btGet.Text = "取得";
            this.btGet.UseVisualStyleBackColor = true;
            this.btGet.Click += new System.EventHandler(this.btGet_Click);
            // 
            // lbRssTitle
            // 
            this.lbRssTitle.Font = new System.Drawing.Font("ＭＳ 明朝", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbRssTitle.FormattingEnabled = true;
            this.lbRssTitle.ItemHeight = 12;
            this.lbRssTitle.Location = new System.Drawing.Point(12, 40);
            this.lbRssTitle.Name = "lbRssTitle";
            this.lbRssTitle.Size = new System.Drawing.Size(259, 580);
            this.lbRssTitle.TabIndex = 2;
            this.lbRssTitle.SelectedIndexChanged += new System.EventHandler(this.lbRssTitle_SelectedIndexChanged);
            // 
            // wbBrowser
            // 
            this.wbBrowser.Location = new System.Drawing.Point(277, 40);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(23, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.ScriptErrorsSuppressed = true;
            this.wbBrowser.Size = new System.Drawing.Size(847, 580);
            this.wbBrowser.TabIndex = 3;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("ＭＳ 明朝", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioButton1.Location = new System.Drawing.Point(22, 24);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(57, 24);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "IT";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("ＭＳ 明朝", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioButton2.Location = new System.Drawing.Point(152, 24);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(80, 24);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "科学";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("ＭＳ 明朝", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioButton3.Location = new System.Drawing.Point(22, 64);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(80, 24);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "経済";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("ＭＳ 明朝", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioButton4.Location = new System.Drawing.Point(152, 64);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(129, 24);
            this.radioButton4.TabIndex = 7;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "スポーツ";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // btLike
            // 
            this.btLike.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btLike.Location = new System.Drawing.Point(1132, 181);
            this.btLike.Name = "btLike";
            this.btLike.Size = new System.Drawing.Size(145, 39);
            this.btLike.TabIndex = 8;
            this.btLike.Text = "お気に入り登録";
            this.btLike.UseVisualStyleBackColor = true;
            this.btLike.Click += new System.EventHandler(this.btLike_Click);
            // 
            // tbLikeTitle
            // 
            this.tbLikeTitle.Font = new System.Drawing.Font("ＭＳ 明朝", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbLikeTitle.Location = new System.Drawing.Point(1132, 246);
            this.tbLikeTitle.Multiline = true;
            this.tbLikeTitle.Name = "tbLikeTitle";
            this.tbLikeTitle.Size = new System.Drawing.Size(273, 43);
            this.tbLikeTitle.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Font = new System.Drawing.Font("ＭＳ 明朝", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox1.Location = new System.Drawing.Point(1132, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 109);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "記事";
            // 
            // cbLike
            // 
            this.cbLike.Font = new System.Drawing.Font("ＭＳ 明朝", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbLike.FormattingEnabled = true;
            this.cbLike.Location = new System.Drawing.Point(1132, 333);
            this.cbLike.Name = "cbLike";
            this.cbLike.Size = new System.Drawing.Size(273, 20);
            this.cbLike.TabIndex = 12;
            this.cbLike.SelectedIndexChanged += new System.EventHandler(this.cbLike_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("ＭＳ 明朝", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(1130, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "タイトル";
            // 
            // btClear
            // 
            this.btClear.Font = new System.Drawing.Font("ＭＳ 明朝", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btClear.Location = new System.Drawing.Point(977, 3);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(100, 31);
            this.btClear.TabIndex = 16;
            this.btClear.Text = "クリア";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btDelete
            // 
            this.btDelete.Font = new System.Drawing.Font("ＭＳ 明朝", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btDelete.Location = new System.Drawing.Point(1282, 181);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(121, 39);
            this.btDelete.TabIndex = 17;
            this.btDelete.Text = "お気に入り削除";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 629);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbLike);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbLikeTitle);
            this.Controls.Add(this.btLike);
            this.Controls.Add(this.wbBrowser);
            this.Controls.Add(this.lbRssTitle);
            this.Controls.Add(this.btGet);
            this.Controls.Add(this.tbUrl);
            this.Font = new System.Drawing.Font("ＭＳ 明朝", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "RssReader";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Button btGet;
        private System.Windows.Forms.ListBox lbRssTitle;
        private System.Windows.Forms.WebBrowser wbBrowser;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button btLike;
        private System.Windows.Forms.TextBox tbLikeTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbLike;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btDelete;
    }
}

