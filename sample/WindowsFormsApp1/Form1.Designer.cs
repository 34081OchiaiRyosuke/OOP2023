﻿
namespace WindowsFormsApp1 {
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
            if (disposing && (components != null))
            {
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
            this.btButton = new System.Windows.Forms.Button();
            this.tbnum1 = new System.Windows.Forms.TextBox();
            this.tbnum2 = new System.Windows.Forms.TextBox();
            this.tbans = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btButton
            // 
            this.btButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btButton.Location = new System.Drawing.Point(500, 104);
            this.btButton.Name = "btButton";
            this.btButton.Size = new System.Drawing.Size(112, 66);
            this.btButton.TabIndex = 0;
            this.btButton.Text = "計算";
            this.btButton.UseVisualStyleBackColor = false;
            this.btButton.Click += new System.EventHandler(this.btButton_Click);
            // 
            // tbnum1
            // 
            this.tbnum1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbnum1.Location = new System.Drawing.Point(98, 33);
            this.tbnum1.Name = "tbnum1";
            this.tbnum1.Size = new System.Drawing.Size(178, 34);
            this.tbnum1.TabIndex = 1;
            this.tbnum1.TextChanged += new System.EventHandler(this.tbTextArea_TextChanged);
            // 
            // tbnum2
            // 
            this.tbnum2.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbnum2.Location = new System.Drawing.Point(314, 33);
            this.tbnum2.Name = "tbnum2";
            this.tbnum2.Size = new System.Drawing.Size(140, 34);
            this.tbnum2.TabIndex = 1;
            this.tbnum2.TextChanged += new System.EventHandler(this.tbTextArea_TextChanged);
            // 
            // tbans
            // 
            this.tbans.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbans.Location = new System.Drawing.Point(500, 33);
            this.tbans.Name = "tbans";
            this.tbans.Size = new System.Drawing.Size(483, 34);
            this.tbans.TabIndex = 1;
            this.tbans.TextChanged += new System.EventHandler(this.tbTextArea_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(282, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "+";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(472, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "=";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1164, 518);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbans);
            this.Controls.Add(this.tbnum2);
            this.Controls.Add(this.tbnum1);
            this.Controls.Add(this.btButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btButton;
        private System.Windows.Forms.TextBox tbnum1;
        private System.Windows.Forms.TextBox tbnum2;
        private System.Windows.Forms.TextBox tbans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

