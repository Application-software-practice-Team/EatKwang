namespace KwEatCategory
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.koreanButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.chineseButton = new System.Windows.Forms.Button();
            this.japaneseButton = new System.Windows.Forms.Button();
            this.westernButton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.randomButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.below20000 = new System.Windows.Forms.Button();
            this.below15000 = new System.Windows.Forms.Button();
            this.below10000 = new System.Windows.Forms.Button();
            this.below5000 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold);
            this.title.Location = new System.Drawing.Point(243, 85);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(280, 34);
            this.title.TabIndex = 0;
            this.title.Text = "오늘 뭐 먹을 광?";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(134, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // koreanButton
            // 
            this.koreanButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.koreanButton.Cursor = System.Windows.Forms.Cursors.No;
            this.koreanButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.koreanButton.Location = new System.Drawing.Point(143, 30);
            this.koreanButton.Name = "koreanButton";
            this.koreanButton.Size = new System.Drawing.Size(99, 54);
            this.koreanButton.TabIndex = 2;
            this.koreanButton.Text = "한식";
            this.koreanButton.UseVisualStyleBackColor = true;
            this.koreanButton.Click += new System.EventHandler(this.koreanButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("굴림", 55F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 92;
            this.listBox1.Location = new System.Drawing.Point(134, 358);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(509, 96);
            this.listBox1.TabIndex = 7;
            // 
            // chineseButton
            // 
            this.chineseButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chineseButton.Cursor = System.Windows.Forms.Cursors.No;
            this.chineseButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chineseButton.Location = new System.Drawing.Point(268, 30);
            this.chineseButton.Name = "chineseButton";
            this.chineseButton.Size = new System.Drawing.Size(99, 54);
            this.chineseButton.TabIndex = 8;
            this.chineseButton.Text = "중식";
            this.chineseButton.UseVisualStyleBackColor = true;
            this.chineseButton.Click += new System.EventHandler(this.chineseButton_Click);
            // 
            // japaneseButton
            // 
            this.japaneseButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.japaneseButton.Cursor = System.Windows.Forms.Cursors.No;
            this.japaneseButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.japaneseButton.Location = new System.Drawing.Point(388, 30);
            this.japaneseButton.Name = "japaneseButton";
            this.japaneseButton.Size = new System.Drawing.Size(99, 54);
            this.japaneseButton.TabIndex = 9;
            this.japaneseButton.Text = "일식";
            this.japaneseButton.UseVisualStyleBackColor = true;
            this.japaneseButton.Click += new System.EventHandler(this.japaneseButton_Click);
            // 
            // westernButton
            // 
            this.westernButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.westernButton.Cursor = System.Windows.Forms.Cursors.No;
            this.westernButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.westernButton.Location = new System.Drawing.Point(510, 30);
            this.westernButton.Name = "westernButton";
            this.westernButton.Size = new System.Drawing.Size(99, 54);
            this.westernButton.TabIndex = 10;
            this.westernButton.Text = "양식";
            this.westernButton.UseVisualStyleBackColor = true;
            this.westernButton.Click += new System.EventHandler(this.westernButton_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearbutton.Cursor = System.Windows.Forms.Cursors.No;
            this.clearbutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clearbutton.Location = new System.Drawing.Point(561, 460);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(82, 41);
            this.clearbutton.TabIndex = 11;
            this.clearbutton.Text = "초기화";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.randomButton);
            this.groupBox1.Controls.Add(this.westernButton);
            this.groupBox1.Controls.Add(this.chineseButton);
            this.groupBox1.Controls.Add(this.koreanButton);
            this.groupBox1.Controls.Add(this.japaneseButton);
            this.groupBox1.Location = new System.Drawing.Point(134, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 100);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "나라 별 식당";
            // 
            // randomButton
            // 
            this.randomButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.randomButton.Cursor = System.Windows.Forms.Cursors.No;
            this.randomButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.randomButton.Location = new System.Drawing.Point(17, 30);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(99, 54);
            this.randomButton.TabIndex = 11;
            this.randomButton.Text = "아무거나";
            this.randomButton.UseVisualStyleBackColor = true;
            this.randomButton.Click += new System.EventHandler(this.randomButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.below20000);
            this.groupBox2.Controls.Add(this.below15000);
            this.groupBox2.Controls.Add(this.below10000);
            this.groupBox2.Controls.Add(this.below5000);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(134, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(626, 107);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "금액 별 식당";
            // 
            // below20000
            // 
            this.below20000.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.below20000.Cursor = System.Windows.Forms.Cursors.No;
            this.below20000.ForeColor = System.Drawing.SystemColors.ControlText;
            this.below20000.Location = new System.Drawing.Point(510, 33);
            this.below20000.Name = "below20000";
            this.below20000.Size = new System.Drawing.Size(99, 54);
            this.below20000.TabIndex = 16;
            this.below20000.Text = "이만원 이하";
            this.below20000.UseVisualStyleBackColor = true;
            this.below20000.Click += new System.EventHandler(this.below20000_Click);
            // 
            // below15000
            // 
            this.below15000.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.below15000.Cursor = System.Windows.Forms.Cursors.No;
            this.below15000.Font = new System.Drawing.Font("굴림", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.below15000.ForeColor = System.Drawing.SystemColors.ControlText;
            this.below15000.Location = new System.Drawing.Point(388, 33);
            this.below15000.Name = "below15000";
            this.below15000.Size = new System.Drawing.Size(99, 54);
            this.below15000.TabIndex = 15;
            this.below15000.Text = "만오천원 이하";
            this.below15000.UseVisualStyleBackColor = true;
            this.below15000.Click += new System.EventHandler(this.below15000_Click);
            // 
            // below10000
            // 
            this.below10000.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.below10000.Cursor = System.Windows.Forms.Cursors.No;
            this.below10000.ForeColor = System.Drawing.SystemColors.ControlText;
            this.below10000.Location = new System.Drawing.Point(268, 33);
            this.below10000.Name = "below10000";
            this.below10000.Size = new System.Drawing.Size(99, 54);
            this.below10000.TabIndex = 14;
            this.below10000.Text = "만원 이하";
            this.below10000.UseVisualStyleBackColor = true;
            this.below10000.Click += new System.EventHandler(this.below10000_Click);
            // 
            // below5000
            // 
            this.below5000.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.below5000.Cursor = System.Windows.Forms.Cursors.No;
            this.below5000.ForeColor = System.Drawing.SystemColors.ControlText;
            this.below5000.Location = new System.Drawing.Point(143, 33);
            this.below5000.Name = "below5000";
            this.below5000.Size = new System.Drawing.Size(99, 54);
            this.below5000.TabIndex = 13;
            this.below5000.Text = "오천원 이하";
            this.below5000.UseVisualStyleBackColor = true;
            this.below5000.Click += new System.EventHandler(this.below5000_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.No;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(17, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 54);
            this.button1.TabIndex = 12;
            this.button1.Text = "아무거나";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(661, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 32);
            this.button2.TabIndex = 13;
            this.button2.Text = "스무고개";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(661, 410);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 35);
            this.button3.TabIndex = 14;
            this.button3.Text = "지도";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(661, 451);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 35);
            this.button4.TabIndex = 15;
            this.button4.Text = "룰렛";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 504);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button koreanButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button chineseButton;
        private System.Windows.Forms.Button japaneseButton;
        private System.Windows.Forms.Button westernButton;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button randomButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button below20000;
        private System.Windows.Forms.Button below15000;
        private System.Windows.Forms.Button below10000;
        private System.Windows.Forms.Button below5000;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

