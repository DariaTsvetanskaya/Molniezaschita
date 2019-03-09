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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            label2.Text = Form6.h.ToString("##.##") + "м";
            label3.Text = Form6.hc.ToString("##.##") + "м";
            label4.Text = Form6.L.ToString("##.##") + "м";
            label5.Text = Form6.h0.ToString("##.##") + "м"; ;
            label6.Text = Form6.hx.ToString("##.##") + "м";
            label7.Text = Form6.r0.ToString("##.##") + "м";
            label8.Text = Form6.Lx.ToString("##.##") + "м";
            label9.Text = Form6.rx.ToString("##.##") + "м";
        }
    }
}
