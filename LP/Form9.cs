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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            label2.Text = Form8.hx.ToString("##.##") + "м";
            label3.Text = Form8.hc.ToString("##.##") + "м";
            label4.Text = Form8.L.ToString("##.##") + "м";
            label5.Text = Form8.h.ToString("##.##") + "м"; ;
            label6.Text = Form8.hx.ToString("##.##") + "м";
            label7.Text = Form8.rx.ToString("##.##") + "м";
            label8.Text = Form8.Lx.ToString("##.##") + "м";
            label9.Text = Form8.r0.ToString("##.##") + "м";
        }
    }
}
