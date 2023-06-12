using System;
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
    public partial class RouletteDlg : Form
    {   
        public RouletteDlg()
        {
            InitializeComponent();
        }

        public void wrtieResult(string result)
        {
            resultLbl.Text = result;
        }
    }
}
