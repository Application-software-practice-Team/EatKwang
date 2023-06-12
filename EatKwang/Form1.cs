using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EatKwang
{
    public partial class KwangTwenty : Form
    {
        int yes_call = 0;
        int no_call = 0;
        int question_num = 0;  // 첫 분기
        int question_num_china = 0;
        int question_num_japan = 0;
        int question_num_korea = 0;
        int question_num_street = 0;      // 분식
        int question_num_nothing = 0;
        public KwangTwenty()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {     // 아무거나

            answer.Text = " 당신의 선택은..? ";

            twenty_mountain_start();
        }

        public void question_reset()
        {
            yes_call = 0;
            no_call = 0;
            question_num = 0;  // 첫 분기
            question_num_china = 0;
            question_num_japan = 0;
            question_num_korea = 0;
            question_num_street = 0;      // 분식
            question_num_nothing = 0;     // 아무거나

            answer.Text = " 당신의 선택은..? ";

            twenty_mountain_start();
        }

        public void suggestion_innerText_reset()
        {
            suggestion.Text = "  ";
        }
        public void twenty_mountain_start()
        {
            question.Text = " 한식을 드시고 싶나요? ";
            if (yes_call == 1)
            {
                question_num = 1;
                twenty_mountain_korea();
            }
            else if (no_call == 1)
            {
                question_num = 2;
                twenty_mountain_china();
            }
        }

        public void twenty_mountain_korea()
        {
            if (question_num_korea == 0)
            {
                question.Text = "매콤한 음식이 드시고 싶으신가요?";
            }
            else if (question_num_korea == 1)
            {
                question.Text = "국물이 있는 음식을 드시고 싶나요? ";
            }
            else if (question_num_korea == 2)
            {
                question.Text = "국물이 있는 음식을 드시고 싶나요?";
            }
            else if (question_num_korea == 3)
            {
                question.Text = "고기를 드시고 싶나요?";
            }
            else if (question_num_korea == 4)
            {
                question.Text = "고기를 드시고 싶나요?";
            }
            else if (question_num_korea == 5)
            {
                question.Text = "면을 드시고 싶나요?";
            }
            else if (question_num_korea == 6)
            {
                question.Text = "다양한 재료가 들어간 음식은 어떠신가요?";
            }
            else if (question_num_korea == 7)
            {
                question.Text = "닭고기 어떠세요?";
            }
            else if (question_num_korea == 8)
            {
                question.Text = "밥 말아먹는거 좋아하세요?";
            }
            else if (question_num_korea == 9)
            {
                question.Text = "감사합니다.";
                answer.Text = "제육볶음";
                suggestion.Text = "식당 : 김밥천국, 뚝배기";
            }
            else if (question_num_korea == 10)
            {
                question.Text = "감사합니다.";
                answer.Text = "아구찜";
                suggestion.Text = "식당 : 여자만아구찜 ";
            }
            else if (question_num_korea == 11)
            {
                question.Text = "감사합니다.";
                answer.Text = "칼국수";
                suggestion.Text = "식당 : 꽃제비칼국수, 천년초칼국수, 끝집";
            }
            else if (question_num_korea == 12)
            {
                question.Text = "감사합니다.";
                answer.Text = "국밥";
                suggestion.Text = "식당 : 더 진국, 큰맘할매순대국";
            }
            else if (question_num_korea == 13)
            {
                question.Text = "비벼먹는걸 좋아하시나요?";
            }
            else if (question_num_korea == 14)
            {
                question.Text = "감사합니다.";
                answer.Text = "덮밥";
                suggestion.Text = "식당 : 밥은화, 마루";
            }
            else if (question_num_korea == 15)
            {
                question.Text = "감사합니다.";
                answer.Text = "닭볶음탕";
                suggestion.Text = "식당 : 꽃제비칼국수";
            }
            else if (question_num_korea == 16)
            {
                question.Text = "감사합니다.";
                answer.Text = "뼈해장국";
                suggestion.Text = "식당 : 더진국, 큰맘할매순대국";
            }
            else if (question_num_korea == 17)
            {
                question.Text = "감사합니다.";
                answer.Text = "부대찌개";
                suggestion.Text = "식당 : 놀부 부대찌개, 이층집";
            }
            else if (question_num_korea == 18)
            {
                question.Text = "감사합니다.";
                answer.Text = "라면";
                suggestion.Text = "식당 : 김밥천국, 싸다김밥";
            }
            else if (question_num_korea == 19)
            {
                question.Text = "감사합니다.";
                answer.Text = "비빔밥";
                suggestion.Text = "식당 : 후문식당, 본죽&비빔밥";
            }
            else if (question_num_korea == 20)
            {
                question.Text = "감사합니다.";
                answer.Text = "김밥";
                suggestion.Text = "식당 : 싸다김밥, 김밥천국";
            }
        }
        public void twenty_mountain_china()
        {
            if (question_num_china == 0)
            {
                question.Text = " 중식을 드시고 싶나요? ";
                if (no_call >= 2)
                {
                    question_num = 3;
                    twenty_mountain_japan();
                }
            }
            else if (question_num_china == 1)
            {
                question.Text = "국물이 있는 음식을 드시고 싶나요? ";
            }
            else if (question_num_china == 2)
            {
                question.Text = "면을 드시고 싶나요?";
            }
            else if (question_num_china == 3)
            {
                question.Text = "튀김을 드시고 싶나요?";
            }
            else if (question_num_china == 4)
            {
                question.Text = "감사합니다.";
                answer.Text = "짬뽕";
                suggestion.Text = "식당 : 미식성, 친친";
            }
            else if (question_num_china == 5)
            {
                question.Text = "감사합니다.";
                answer.Text = "짬뽕밥";
                suggestion.Text = "식당 : 미식성, 친친";
            }
            else if (question_num_china == 6)
            {
                question.Text = "고기를 드시고 싶나요?";
            }
            else if (question_num_china == 7)
            {
                question.Text = "면을 드시고 싶나요?";
            }
            else if (question_num_china == 8)
            {
                question.Text = "감사합니다.";
                answer.Text = "탕수육";
                suggestion.Text = "식당 : 미식성, 친친";
            }
            else if (question_num_china == 9)
            {
                question.Text = "감사합니다.";
                answer.Text = "깐풍기";
                suggestion.Text = "식당 : 미식성, 친친";
            }
        }
        public void twenty_mountain_japan()
        {
            if (question_num_japan == 0)
            {
                question.Text = " 일식을 드시고 싶나요? ";
                if (no_call >= 3)
                {
                    question_num = 4;
                    twenty_mountain_street();
                }
            }
            else if (question_num_japan == 1)
            {
                question.Text = "튀김을 좋아하시나요?";
            }
            else if (question_num_japan == 2)
            {
                question.Text = "감사합니다.";
                answer.Text = "돈까스";
                suggestion.Text = "식당 : 카츠3.3, 윤스쿡";
            }
            else if (question_num_japan == 3)
            {
                question.Text = "비벼먹는걸 좋아하시나요?";
            }
            else if (question_num_japan == 4)
            {
                question.Text = "감사합니다.";
                answer.Text = "회덮밥";
                suggestion.Text = "식당 : 푸른스시";
            }
            else if (question_num_japan == 5)
            {
                question.Text = "감사합니다.";
                answer.Text = "초밥";
                suggestion.Text = "식당 : 푸른스시";
            }
        }

        public void twenty_mountain_street()
        {
            if (question_num_street == 0)
            {
                question.Text = " 분식을 드시고 싶나요? ";
                if (no_call >= 4)
                {
                    question_num = 5;
                    twenty_mountain_nothing();
                }
            }
            else if (question_num_street == 1)
            {
                question.Text = "매운음식을 좋아하시나요?";
            }
            else if (question_num_street == 2)
            {
                question.Text = "국물이 있는 음식을 드시고 싶나요?";
            }
            else if (question_num_street == 3)
            {
                question.Text = "쌀이 들어간 음식 좋아하시나요?";
            }
            else if (question_num_street == 4)
            {
                question.Text = "감사합니다.";
                answer.Text = "라면";
                suggestion.Text = "식당 : 김밥천국, 싸다김밥";
            }
            else if (question_num_street == 5)
            {
                question.Text = "감사합니다.";
                answer.Text = "떡볶이";
                suggestion.Text = "식당 : 신전떡볶이";
            }
            else if (question_num_street == 6)
            {
                question.Text = "감사합니다.";
                answer.Text = "김밥";
                suggestion.Text = "식당 : 김밥천국, 싸다김밥";
            }
            else if (question_num_street == 7)
            {
                question.Text = "밀가루 들어간 음식이 떙기시나요?";
            }
            else if (question_num_street == 8)
            {
                question.Text = "감사합니다.";
                answer.Text = "튀김";
                suggestion.Text = "식당 : 신전떡볶이, 싸다김밥";
            }
            else if (question_num_street == 9)
            {
                question.Text = "감사합니다.";
                answer.Text = "순대";
                suggestion.Text = "식당 : 신전떡볶이, 싸다김밥";
            }
        }
        public void twenty_mountain_nothing()
        {
            if (question_num_nothing == 0)
            {
                question.Text = "고깃집 어떠세요?";
            }
            else if (question_num_nothing == 1)
            {
                question.Text = "돼지고기 어떠신가요?";
            }
            else if (question_num_nothing == 2)
            {
                question.Text = "감사합니다.";
                answer.Text = "치킨";
                suggestion.Text = "식당 : 치킨플러스, 썬더치킨";
            }
            else if (question_num_nothing == 3)
            {
                question.Text = "감사합니다.";
                answer.Text = "돼지고기";
                suggestion.Text = "식당 : 화로상회";
            }
            else if (question_num_nothing == 4)
            {
                question.Text = "감사합니다.";
                answer.Text = "소고기";
                suggestion.Text = "식당 : 맛나고소고깃간";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yes_call = yes_call + 1;

            if (question_num == 0)
            {
                twenty_mountain_start();
            }
            else if (question_num == 1)   // 한식
            {
                if (question_num_korea == 0)
                {
                    question_num_korea = 1;
                }
                else if (question_num_korea == 1)
                {
                    question_num_korea = 3;
                }
                else if (question_num_korea == 2)
                {
                    question_num_korea = 5;
                }
                else if (question_num_korea == 3)
                {
                    question_num_korea = 5;
                }
                else if (question_num_korea == 4)
                {
                    question_num_korea = 9;
                }
                else if (question_num_korea == 5)
                {
                    question_num_korea = 11;
                }
                else if (question_num_korea == 6)
                {
                    question_num_korea = 13;
                }
                else if (question_num_korea == 7)
                {
                    question_num_korea = 15;
                }
                else if (question_num_korea == 8)
                {
                    question_num_korea = 17;
                }
                else if (question_num_korea == 13)
                {
                    question_num_korea = 19;
                }
                twenty_mountain_korea();
            }
            else if (question_num == 2)
            {
                if (question_num_china == 0)
                {
                    question_num_china = 1;
                }
                else if (question_num_china == 1)
                {
                    question_num_china = 2;
                }
                else if (question_num_china == 2)
                {
                    question_num_china = 4;
                }
                else if (question_num_china == 3)
                {
                    question_num_china = 6;
                }
                else if (question_num_china == 6)
                {
                    question_num_china = 8;
                }
                else if (question_num_china == 7)
                {
                    question_num_china = 10;
                }
                twenty_mountain_china();
            }
            else if (question_num == 3)
            {
                if (question_num_japan == 0)
                {
                    question_num_japan = 1;
                }
                else if (question_num_japan == 1)
                {
                    question_num_japan = 2;
                }
                else if (question_num_japan == 3)
                {
                    question_num_japan = 4;
                }
                twenty_mountain_japan();
            }
            else if (question_num == 4)
            {
                if (question_num_street == 0)
                {
                    question_num_street = 1;
                }
                else if (question_num_street == 1)
                {
                    question_num_street = 2;
                }
                else if (question_num_street == 2)
                {
                    question_num_street = 4;
                }
                else if (question_num_street == 3)
                {
                    question_num_street = 6;
                }
                else if (question_num_street == 7)
                {
                    question_num_street = 8;
                }
                twenty_mountain_street();
            }
            else if (question_num == 5)
            {
                if (question_num_nothing == 0)
                {
                    question_num_nothing = 1;
                }
                else if (question_num_nothing == 1)
                {
                    question_num_nothing = 3;
                }
                twenty_mountain_nothing();
            }
        }

        private void question_Click(object sender, EventArgs e)
        {
            no_call = no_call + 1;

            if (question_num == 0)
            {
                twenty_mountain_start();
            }
            else if (question_num == 1)   // 한식
            {
                if (question_num_korea == 0)
                {
                    question_num_korea = 2;
                }
                else if (question_num_korea == 1)
                {
                    question_num_korea = 4;
                }
                else if (question_num_korea == 2)
                {
                    question_num_korea = 6;
                }
                else if (question_num_korea == 3)
                {
                    question_num_korea = 8;
                }
                else if (question_num_korea == 4)
                {
                    question_num_korea = 10;
                }
                else if (question_num_korea == 5)
                {
                    question_num_korea = 12;
                }
                else if (question_num_korea == 6)
                {
                    question_num_korea = 14;
                }
                else if (question_num_korea == 7)
                {
                    question_num_korea = 16;
                }
                else if (question_num_korea == 8)
                {
                    question_num_korea = 18;
                }
                else if (question_num_korea == 13)
                {
                    question_num_korea = 20;
                }
                twenty_mountain_korea();
            }
            else if (question_num == 2)
            {

                if (question_num_china == 1)
                {
                    question_num_china = 3;
                }
                else if (question_num_china == 2)
                {
                    question_num_china = 5;
                }
                else if (question_num_china == 3)
                {
                    question_num_china = 7;
                }
                else if (question_num_china == 6)
                {
                    question_num_china = 9;
                }
                else if (question_num_china == 7)
                {
                    question_num_china = 11;
                }
                twenty_mountain_china();
            }
            else if (question_num == 3)
            {
                if (question_num_japan == 0)
                {
                    if (no_call >= 3)
                    {
                        question_num = 4;
                        twenty_mountain_street();
                    }
                    else
                        question_num_japan = 1;
                }
                else if (question_num_japan == 1)
                {
                    question_num_japan = 3;
                }
                else if (question_num_japan == 3)
                {
                    question_num_japan = 5;
                }
                twenty_mountain_japan();
            }
            else if (question_num == 4)
            {
                if (question_num_street == 0)
                {
                    if (no_call >= 4)
                    {
                        question_num = 5;
                        twenty_mountain_nothing();
                    }
                    else
                        question_num_street = 1;
                }
                else if (question_num_street == 1)
                {
                    question_num_street = 3;
                }
                else if (question_num_street == 2)
                {
                    question_num_street = 5;
                }
                else if (question_num_street == 3)
                {
                    question_num_street = 7;
                }
                else if (question_num_street == 7)
                {
                    question_num_street = 9;
                }
                twenty_mountain_street();
            }
            else if (question_num == 5)
            {
                if (question_num_nothing == 0)
                {
                    question_num_nothing = 2;
                }
                else if (question_num_nothing == 1)
                {
                    question_num_nothing = 4;
                }
                twenty_mountain_nothing();
            }
        }
    }
}
