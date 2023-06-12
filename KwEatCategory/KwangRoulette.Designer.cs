namespace AppSoftwareProject
{
    partial class KwangRoulette
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.minusOptinBtn = new System.Windows.Forms.Button();
            this.plusOptionBtn = new System.Windows.Forms.Button();
            this.optionNumLbl = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.optionPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.resultLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.optionPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // playBtn
            // 
            this.playBtn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.playBtn.Location = new System.Drawing.Point(790, 663);
            this.playBtn.Margin = new System.Windows.Forms.Padding(4);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(445, 144);
            this.playBtn.TabIndex = 8;
            this.playBtn.Text = "Play";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "옵션 개수";
            // 
            // minusOptinBtn
            // 
            this.minusOptinBtn.Location = new System.Drawing.Point(162, 11);
            this.minusOptinBtn.Margin = new System.Windows.Forms.Padding(4);
            this.minusOptinBtn.Name = "minusOptinBtn";
            this.minusOptinBtn.Size = new System.Drawing.Size(52, 53);
            this.minusOptinBtn.TabIndex = 1;
            this.minusOptinBtn.Text = "-";
            this.minusOptinBtn.UseVisualStyleBackColor = true;
            this.minusOptinBtn.Click += new System.EventHandler(this.minusOptinBtn_Click);
            // 
            // plusOptionBtn
            // 
            this.plusOptionBtn.Location = new System.Drawing.Point(300, 11);
            this.plusOptionBtn.Margin = new System.Windows.Forms.Padding(4);
            this.plusOptionBtn.Name = "plusOptionBtn";
            this.plusOptionBtn.Size = new System.Drawing.Size(52, 53);
            this.plusOptionBtn.TabIndex = 3;
            this.plusOptionBtn.Text = "+";
            this.plusOptionBtn.UseVisualStyleBackColor = true;
            this.plusOptionBtn.Click += new System.EventHandler(this.plusOptionBtn_Click);
            // 
            // optionNumLbl
            // 
            this.optionNumLbl.AutoSize = true;
            this.optionNumLbl.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.optionNumLbl.Location = new System.Drawing.Point(239, 23);
            this.optionNumLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.optionNumLbl.Name = "optionNumLbl";
            this.optionNumLbl.Size = new System.Drawing.Size(28, 27);
            this.optionNumLbl.TabIndex = 4;
            this.optionNumLbl.Text = "8";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(313, 95);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(129, 35);
            this.textBox5.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(269, 299);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 24);
            this.label7.TabIndex = 20;
            this.label7.Text = "8";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(313, 161);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(129, 35);
            this.textBox6.TabIndex = 14;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(313, 295);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(129, 35);
            this.textBox8.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(269, 99);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(269, 232);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 24);
            this.label9.TabIndex = 18;
            this.label9.Text = "7";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(269, 165);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 24);
            this.label10.TabIndex = 16;
            this.label10.Text = "6";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(313, 228);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(129, 35);
            this.textBox7.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 95);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 35);
            this.textBox1.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 299);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "4";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(84, 161);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(129, 35);
            this.textBox2.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(84, 295);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(129, 35);
            this.textBox4.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 232);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "2";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(84, 224);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(129, 35);
            this.textBox3.TabIndex = 9;
            // 
            // optionPanel
            // 
            this.optionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.optionPanel.Controls.Add(this.label7);
            this.optionPanel.Controls.Add(this.optionNumLbl);
            this.optionPanel.Controls.Add(this.plusOptionBtn);
            this.optionPanel.Controls.Add(this.textBox5);
            this.optionPanel.Controls.Add(this.minusOptinBtn);
            this.optionPanel.Controls.Add(this.textBox8);
            this.optionPanel.Controls.Add(this.label1);
            this.optionPanel.Controls.Add(this.textBox1);
            this.optionPanel.Controls.Add(this.textBox6);
            this.optionPanel.Controls.Add(this.label10);
            this.optionPanel.Controls.Add(this.label6);
            this.optionPanel.Controls.Add(this.label9);
            this.optionPanel.Controls.Add(this.textBox4);
            this.optionPanel.Controls.Add(this.label8);
            this.optionPanel.Controls.Add(this.label5);
            this.optionPanel.Controls.Add(this.label3);
            this.optionPanel.Controls.Add(this.textBox3);
            this.optionPanel.Controls.Add(this.label4);
            this.optionPanel.Controls.Add(this.textBox2);
            this.optionPanel.Controls.Add(this.textBox7);
            this.optionPanel.Location = new System.Drawing.Point(790, 256);
            this.optionPanel.Margin = new System.Windows.Forms.Padding(4);
            this.optionPanel.Name = "optionPanel";
            this.optionPanel.Size = new System.Drawing.Size(485, 363);
            this.optionPanel.TabIndex = 30;
            this.optionPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.optionPanel_Paint);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.resultLbl);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(790, 855);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 134);
            this.panel2.TabIndex = 7;
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Font = new System.Drawing.Font("굴림", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.resultLbl.Location = new System.Drawing.Point(147, 20);
            this.resultLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(95, 96);
            this.resultLbl.TabIndex = 6;
            this.resultLbl.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(18, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "결과";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::KwEatCategory.Properties.Resources.placeholder;
            this.pictureBox2.Location = new System.Drawing.Point(347, 152);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(91, 93);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(34, 257);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(715, 733);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("맑은 고딕", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(604, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(192, 100);
            this.label11.TabIndex = 31;
            this.label11.Text = "룰렛";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::KwEatCategory.Properties.Resources.KWLogo;
            this.pictureBox3.Location = new System.Drawing.Point(459, 57);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(142, 144);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 32;
            this.pictureBox3.TabStop = false;
            // 
            // KwangRoulette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1314, 1026);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.optionPanel);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KwangRoulette";
            this.Text = "Roullette";
            this.Load += new System.EventHandler(this.KwangRoulette_Load);
            this.optionPanel.ResumeLayout(false);
            this.optionPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button minusOptinBtn;
        private System.Windows.Forms.Button plusOptionBtn;
        private System.Windows.Forms.Label optionNumLbl;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel optionPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

