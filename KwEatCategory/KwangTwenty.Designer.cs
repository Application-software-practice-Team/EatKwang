namespace KwEatCategory
{
    partial class KwangTwenty
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.question = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.Label();
            this.suggestion = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(556, 519);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "예";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(556, 608);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 63);
            this.button2.TabIndex = 1;
            this.button2.Text = "아니오";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.question_Click);
            // 
            // question
            // 
            this.question.AutoSize = true;
            this.question.Font = new System.Drawing.Font("맑은 고딕", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.question.Location = new System.Drawing.Point(547, 416);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(435, 50);
            this.question.TabIndex = 2;
            this.question.Text = "매운 것을 좋아하시나요?";
            this.question.Click += new System.EventHandler(this.question_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KwEatCategory.Properties.Resources.KWeat;
            this.pictureBox1.Location = new System.Drawing.Point(26, 181);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(490, 506);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(507, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 100);
            this.label2.TabIndex = 4;
            this.label2.Text = "스무고개";
            // 
            // answer
            // 
            this.answer.AutoSize = true;
            this.answer.Font = new System.Drawing.Font("맑은 고딕", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.answer.Location = new System.Drawing.Point(546, 192);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(111, 59);
            this.answer.TabIndex = 5;
            this.answer.Text = "음식";
            // 
            // suggestion
            // 
            this.suggestion.AutoSize = true;
            this.suggestion.Font = new System.Drawing.Font("맑은 고딕", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.suggestion.Location = new System.Drawing.Point(546, 268);
            this.suggestion.Name = "suggestion";
            this.suggestion.Size = new System.Drawing.Size(122, 59);
            this.suggestion.TabIndex = 6;
            this.suggestion.Text = "식당:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(745, 519);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 152);
            this.button3.TabIndex = 7;
            this.button3.Text = "다시하기";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.reset_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::KwEatCategory.Properties.Resources.KWLogo;
            this.pictureBox2.Location = new System.Drawing.Point(374, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(126, 121);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // KwangTwenty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1267, 713);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.suggestion);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.question);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "KwangTwenty";
            this.Text = "KwangTwenty";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label question;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label answer;
        private System.Windows.Forms.Label suggestion;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}