using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KwEatCategory
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {

            InitializeComponent();
            
        }

        private void koreanButton_Click(object sender, EventArgs e)
        {
            string[] korean = {"꽃제비 칼국수", "놀부부대찌개", "끝집", "무등산순대국","미가추어탕",
                "밥은화","여우곱창","여자만아구찜","천년초칼국수","큰맘할매순대국","윤스쿡",
                "신전떡볶이","싸다김밥","장수국수","또봉이파닭","맛닭꼬","썬더치킨","오마이치킨"
                ,"치킨플러스","돈장군","마포연탄불고기","맛나고고깃간","월계숯불갈비","화로상회",
                "수유리우동","김밥천국 ","마루컵밥","경대컵밥"};
            Random random = new Random();
            int index = random.Next(korean.Length);
            listBox1.Items.Clear();
            listBox1.Items.Add(korean[index]);
        }

        private void chineseButton_Click(object sender, EventArgs e)
        {
            string[] chinese = { "더원", "미식성", "진짜루", "친친" };
            Random random = new Random();
            int index = random.Next(chinese.Length);
            listBox1.Items.Clear();
            listBox1.Items.Add(chinese[index]);
        }

        
        private void clearbutton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void westernButton_Click(object sender, EventArgs e)
        {
            string[] western = { "서브웨어", "오네스토테이블", "프랭크버거" };
            Random random = new Random();
            int index = random.Next(western.Length);
            listBox1.Items.Clear();
            listBox1.Items.Add(western[index]);
        }

        private void japaneseButton_Click(object sender, EventArgs e)
        {
            string[] japanese = { "착한초밥", "푸른스시" };
            Random random = new Random();
            int index = random.Next(japanese.Length);
            listBox1.Items.Clear();
            listBox1.Items.Add(japanese[index]);
        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            string[] randomAll = {"꽃제비 칼국수", "놀부부대찌개", "끝집", "무등산순대국","미가추어탕",
                "밥은화","여우곱창","여자만아구찜","천년초칼국수","큰맘할매순대국","윤스쿡",
                "신전떡볶이","싸다김밥","장수국수","또봉이파닭","맛닭꼬","썬더치킨","오마이치킨"
                ,"치킨플러스","돈장군","마포연탄불고기","맛나고고깃간","월계숯불갈비","화로상회",
                "수유리우동", "착한초밥", "푸른스시","서브웨이", "오네스토테이블", "프랭크버거","더원", "미식성", "진짜루", "친친","김밥천국","마루컵밥","경대컵밥"};
            Random random = new Random();
            int index = random.Next(randomAll.Length);
            listBox1.Items.Clear();
            listBox1.Items.Add(randomAll[index]);
        }

        private void below5000_Click(object sender, EventArgs e)
        {
            string[] below5000 = { "김밥천국","마루컵밥","경대컵밥" };
            Random random = new Random();
            int index = random.Next(below5000.Length);
            listBox1.Items.Clear();
            listBox1.Items.Add(below5000[index]);
        }

        private void below10000_Click(object sender, EventArgs e)
        {
            string[] below10000 = {"꽃제비 칼국수", "끝집", "무등산순대국","미가추어탕",
                "밥은화","천년초칼국수","큰맘할매순대국",
                "싸다김밥","장수국수", "착한초밥","서브웨이", "오네스토테이블", "프랭크버거","더원", "미식성", "진짜루", "친친","김밥천국"};
            Random random = new Random();
            int index = random.Next(below10000.Length);
            listBox1.Items.Clear();
            listBox1.Items.Add(below10000[index]);
        }

        private void below15000_Click(object sender, EventArgs e)
        {
            string[] below15000 = { "끝집", "무등산순대국",
                "여자만아구찜","윤스쿡",
                "신전떡볶이","싸다김밥","장수국수","또봉이파닭","맛닭꼬","썬더치킨","오마이치킨"
                ,
                "수유리우동", "착한초밥", "푸른스시","서브웨이", "오네스토테이블", "프랭크버거","더원", "미식성", "진짜루", "친친",};
            Random random = new Random();
            int index = random.Next(below15000.Length);
            listBox1.Items.Clear();
            listBox1.Items.Add(below15000[index]);
        }

        private void below20000_Click(object sender, EventArgs e)
        {
            string[] below20000 = {"꽃제비 칼국수", "놀부부대찌개", "끝집", "무등산순대국","미가추어탕",
                "밥은화","여우곱창","여자만아구찜","천년초칼국수","큰맘할매순대국","윤스쿡",
                "신전떡볶이","싸다김밥","장수국수","또봉이파닭","맛닭꼬","썬더치킨","오마이치킨"
                ,"치킨플러스","돈장군","마포연탄불고기","맛나고고깃간","월계숯불갈비","화로상회",
                "수유리우동", "착한초밥", "푸른스시","서브웨이", "오네스토테이블", "프랭크버거","더원", "미식성", "진짜루", "친친","김밥천국","마루컵밥","경대컵밥"};
            Random random = new Random();
            int index = random.Next(below20000.Length);
            listBox1.Items.Clear();
            listBox1.Items.Add(below20000[index]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] below20000 = {"꽃제비 칼국수", "놀부부대찌개", "끝집", "무등산순대국","미가추어탕",
                "밥은화","여우곱창","여자만아구찜","천년초칼국수","큰맘할매순대국","윤스쿡",
                "신전떡볶이","싸다김밥","장수국수","또봉이파닭","맛닭꼬","썬더치킨","오마이치킨"
                ,"치킨플러스","돈장군","마포연탄불고기","맛나고고깃간","월계숯불갈비","화로상회",
                "수유리우동", "착한초밥", "푸른스시","서브웨이", "오네스토테이블", "프랭크버거","더원", "미식성", "진짜루", "친친","김밥천국","마루컵밥","경대컵밥"};
            Random random = new Random();
            int index = random.Next(below20000.Length);
            listBox1.Items.Clear();
            listBox1.Items.Add(below20000[index]);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
    
}
