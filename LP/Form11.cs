using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
            label2.Text = Form10.h.ToString("##.##") + "м";
            label3.Text = Form10.h0.ToString("##.##") + "м";
            label4.Text = Form10.d.ToString("##.##") + "м";
        }
    }
}
