namespace KwangMap
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
            this.foodname = new System.Windows.Forms.Label();
            this.search_box = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.search_list = new System.Windows.Forms.ListBox();
            this.plus_btn = new System.Windows.Forms.Button();
            this.minus_btn = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // foodname
            // 
            this.foodname.AutoSize = true;
            this.foodname.Location = new System.Drawing.Point(40, 33);
            this.foodname.Name = "foodname";
            this.foodname.Size = new System.Drawing.Size(114, 24);
            this.foodname.TabIndex = 0;
            this.foodname.Text = "음식점명:";
            // 
            // search_box
            // 
            this.search_box.Location = new System.Drawing.Point(158, 27);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(893, 35);
            this.search_box.TabIndex = 1;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(1074, 19);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(155, 51);
            this.search_btn.TabIndex = 2;
            this.search_btn.Text = "검색";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // search_list
            // 
            this.search_list.FormattingEnabled = true;
            this.search_list.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.search_list.ItemHeight = 24;
            this.search_list.Location = new System.Drawing.Point(44, 85);
            this.search_list.Name = "search_list";
            this.search_list.Size = new System.Drawing.Size(253, 460);
            this.search_list.TabIndex = 3;
            this.search_list.SelectedValueChanged += new System.EventHandler(this.listBox_SelectionChanged);
            // 
            // plus_btn
            // 
            this.plus_btn.Location = new System.Drawing.Point(44, 565);
            this.plus_btn.Name = "plus_btn";
            this.plus_btn.Size = new System.Drawing.Size(105, 38);
            this.plus_btn.TabIndex = 4;
            this.plus_btn.Text = "+";
            this.plus_btn.UseVisualStyleBackColor = true;
            this.plus_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // minus_btn
            // 
            this.minus_btn.Location = new System.Drawing.Point(189, 565);
            this.minus_btn.Name = "minus_btn";
            this.minus_btn.Size = new System.Drawing.Size(108, 38);
            this.minus_btn.TabIndex = 5;
            this.minus_btn.Text = "-";
            this.minus_btn.UseVisualStyleBackColor = true;
            this.minus_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(328, 85);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(901, 518);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("http://ehpub.co.kr/kakaomap.html", System.UriKind.Absolute);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 637);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.minus_btn);
            this.Controls.Add(this.plus_btn);
            this.Controls.Add(this.search_list);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.foodname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label foodname;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button plus_btn;
        private System.Windows.Forms.Button minus_btn;
        private System.Windows.Forms.WebBrowser webBrowser1;
        public System.Windows.Forms.ListBox search_list;
    }
}

