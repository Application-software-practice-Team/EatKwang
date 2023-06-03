using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Net;
using System.IO;
using System.Windows;

namespace KwangMap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                string qstr = search_box.Text;
                List<MyLocale> mls = KakaoAPI.Search(qstr);

                search_list.Items.Clear();
                foreach (MyLocale locale in mls)
                {
                    search_list.Items.Add(locale);
                }
                search_list.Items.Add(qstr);
            }
            catch (Exception ex)
            {
                ex.ToString();
                MessageBox.Show(ex.Message);
            }
        }
        private void listBox_SelectionChanged(object sender, EventArgs e)
        {
            if(search_list.SelectedIndex == -1)
            {
                return;
            }

            MyLocale ml = search_list.SelectedItem as MyLocale;
            object[] ps = new object[] { ml.Lat, ml.Lng };
            HtmlDocument hdoc = webBrowser1.Document;
            hdoc.InvokeScript("setCenter", ps);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.InvokeScript("zoomIn"); // 줌인
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.InvokeScript("zoomOut"); // 줌아웃
        }
    }
}
