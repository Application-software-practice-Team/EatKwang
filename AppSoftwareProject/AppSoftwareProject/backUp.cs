/*
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Numerics;

namespace AppSoftwareProject
{
    public partial class Form1 : Form
    {
        private Bitmap originalImage;
        private float rotationAngle = 0.0f;
        private int rotateTime;
        private List<int> roulletteNum;
        private int roulletteSize = 8;
        private int currentRoulletteNum;

        private const int maxRoulletteSize = 8;
        private const int minRoulletteSize = 2;
        private bool rotateActive = false;
        private bool resultActive = false;

        private List<string> rouletteOptions;

        public Form1()
        {
            InitializeComponent();

            // 룻렛 넘버 설정
            roulletteNum = new List<int>();
            for (int i = roulletteSize; i >= 1; i--)
            {
                roulletteNum.Add(i);
            }

            // 이미지 로드
            setOriginalImage(roulletteSize);
            pictureBox1.Image = originalImage;

            // Timer 설정
            timer1.Interval = 10; // 회전 속도를 조정할 수 있는 간격을 설정한다.
            timer1.Tick += Timer_Tick;
        }

        private void setOriginalImage(int num)
        {
            if (originalImage != null)
            {
                originalImage.Dispose();
            }

            if (num == 8)
            {
                originalImage = new Bitmap(Properties.Resources.roullette8);
            }
            else if (num == 7)
            {
                originalImage = new Bitmap(Properties.Resources.roullette2);
            }
            else if (num == 6)
            {
                originalImage = new Bitmap(Properties.Resources.roullette6);
            }
            else if (num == 5)
            {
                originalImage = new Bitmap(Properties.Resources.roullette2);
            }
            else if (num == 4)
            {
                originalImage = new Bitmap(Properties.Resources.roullette4);
            }
            else if (num == 3)
            {
                originalImage = new Bitmap(Properties.Resources.roullette2);
            }
            else if (num == 2)
            {
                originalImage = new Bitmap(Properties.Resources.roullette2);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (rotateTime > 0 && rotateActive)
            {
                float rotationSpeed = rotateTime / 10; // 회전 속도
                if (rotationSpeed >= 20) rotationSpeed = 20;

                rotationAngle += rotationSpeed; // 회전 각도 업데이트
                rotationAngle = rotationAngle % 360;
                RotateImage(pictureBox1, rotationAngle);
                rotateTime--;
            }
            else
            {
                rotateActive = false;

                if (resultActive >= 1000000000) resultActive = 2; // overflow 방지
                resultActive++;

                // reulstActive의 값이 1이면 Modal창 생성 
                if (resultActive == 1)
                {
                    resultDialog();
                }
            }

            currentRoulletteNum = Convert.ToInt32(Math.Ceiling(rotationAngle / (360 / roulletteSize)));

            // 최종 result 값을 출력
            if (currentRoulletteNum == 0)
            {
                currentRoulletteNum = 0;
            }
            else
            {
                currentRoulletteNum--;
            }

            resultLbl.Text = roulletteNum[currentRoulletteNum].ToString();
        }

        private void SpinButton_Click(object sender, EventArgs e)
        {
            // 룰렛을 회전시키는 로직을 구현합니다.
            // ...

            // 룰렛이 멈추면 모달 창을 띄웁니다.
            if (resultActive)
            {
                // 모달 창을 생성하고 표시합니다.
                using (ModalForm modalForm = new ModalForm())
                {
                    modalForm.ShowDialog(); // 모달 창을 띄웁니다.
                }
            }
        }

        private void RotateImage(PictureBox pictureBox, float angle)
        {
            if (originalImage == null || pictureBox.Image == null)
                return;

            Bitmap rotatedImage = new Bitmap(originalImage.Width, originalImage.Height);

            using (Graphics graphics = Graphics.FromImage(rotatedImage))
            {
                // 회전을 적용하기 위해 그래픽 변환을 설정한다. 
                graphics.TranslateTransform((float)originalImage.Width / 2, (float)originalImage.Height / 2);
                graphics.RotateTransform(angle);
                graphics.TranslateTransform(-(float)originalImage.Width / 2, -(float)originalImage.Height / 2);

                // 회전된 이미지를 그린다.
                graphics.DrawImage(originalImage, new Point(0, 0));

                // graphics.Dispose(); // 그린 Image object를 제거(가비지 콜렉터를 믿고 일단은 사용 X)
            }

            // 이전 프레임의 Image를 제거한다.(메모리 관리를 위해)
            Image oldImage = pictureBox.Image;
            pictureBox.Image = rotatedImage;
            if (oldImage != null)
            {
                oldImage.Dispose();
            }
            // Image를 제거하면 originalImage도 삭제 되므로(원인 모름) originalImage를 재생성한다.
            setOriginalImage(roulletteSize);
        }

        private void minusOptinBtn_Click(object sender, EventArgs e)
        {
            if (roulletteSize > minRoulletteSize && !rotateActive)
            {
                roulletteSize--;
                roulletteNum.RemoveAt(0);

                string textBoxName = "textBox" + (roulletteSize + 1);

                Control[] textBoxControls = Controls.Find(textBoxName, true);

                Controls.Remove(textBoxControls[0]);
                textBoxControls[0].Dispose();
            }
            optionNumLbl.Text = roulletteSize.ToString();
            setOriginalImage(roulletteSize);
            pictureBox1.Image = originalImage;
        }

        private void plusOptionBtn_Click(object sender, EventArgs e)
        {
            if (roulletteSize < maxRoulletteSize && !rotateActive)
            {
                roulletteSize++;
                roulletteNum.Insert(0, roulletteSize);


                string textBoxName = "textBox" + (roulletteSize);

                TextBox textBox = new TextBox();
                textBox.Name = textBoxName;
                textBox.Size = new Size(72, 28);


                if (roulletteSize <= 4)
                {
                    textBox.Location = new Point(45, 47 + (roulletteSize - 1) * 33);
                }
                else
                {
                    textBox.Location = new Point(170, 47 + (roulletteSize - 5) * 33);
                }
                optionPanel.Controls.Add(textBox);
            }
            optionNumLbl.Text = roulletteSize.ToString();
            setOriginalImage(roulletteSize);
            pictureBox1.Image = originalImage;
        }

        private void resultDialog()
        {
            MyDlg md = new MyDlg();
            string resString = (roulletteSize - currentRoulletteNum).ToString();
            resString += ", ";
            resString += rouletteOptions[roulletteSize - currentRoulletteNum - 1];
            resString += "!!!";
            md.wrtieResult(resString);

            DialogResult result = md.ShowDialog();
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            rotateTime = random.Next(150, 200);
            // resultActive = 0;
            resultActive = false;

            // 타이머 시작
            timer1.Start();
            rotateActive = true;

            // 사용자가 입력한 옵션 저장
            rouletteOptions = new List<string>();
            for (int i = 1; i <= roulletteSize; i++)
            {
                string textBoxName = "textBox" + i;

                Control[] textBoxControls = Controls.Find(textBoxName, true);

                rouletteOptions.Add(textBoxControls[0].Text);
            }
        }

    }
}*/
