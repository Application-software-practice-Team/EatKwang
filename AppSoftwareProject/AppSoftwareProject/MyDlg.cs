﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSoftwareProject
{
    public partial class MyDlg : Form
    {   
        public MyDlg()
        {
            InitializeComponent();
        }

        public void wrtieResult(string result)
        {
            resultLbl.Text = result;
        }
    }
}
