namespace EatKwang
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(561, 368);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "예";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(561, 435);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "아니오";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.question_Click);
            // 
            // question
            // 
            this.question.AutoSize = true;
            this.question.Font = new System.Drawing.Font("맑은 고딕", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.question.Location = new System.Drawing.Point(451, 291);
            this.question.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(330, 38);
            this.question.TabIndex = 2;
            this.question.Text = "매운 것을 좋아하시나요?";
            this.question.Click += new System.EventHandler(this.question_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EatKwang.Properties.Resources.KakaoTalk_20230612_174314315_01;
            this.pictureBox1.Location = new System.Drawing.Point(20, 136);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(377, 380);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(255, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 65);
            this.label2.TabIndex = 4;
            this.label2.Text = "스무고개";
            // 
            // answer
            // 
            this.answer.AutoSize = true;
            this.answer.Font = new System.Drawing.Font("맑은 고딕", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.answer.Location = new System.Drawing.Point(510, 136);
            this.answer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(86, 45);
            this.answer.TabIndex = 5;
            this.answer.Text = "음식";
            // 
            // suggestion
            // 
            this.suggestion.AutoSize = true;
            this.suggestion.Font = new System.Drawing.Font("맑은 고딕", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.suggestion.Location = new System.Drawing.Point(510, 192);
            this.suggestion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.suggestion.Name = "suggestion";
            this.suggestion.Size = new System.Drawing.Size(95, 45);
            this.suggestion.TabIndex = 6;
            this.suggestion.Text = "식당:";
            // 
            // KwangTwenty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 676);
            this.Controls.Add(this.suggestion);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.question);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "KwangTwenty";
            this.Text = "KwangTwenty";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}