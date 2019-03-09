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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            label2.Text = Form2.h.ToString("##.##") + "м";
            label3.Text = Form2.h0.ToString("##.##") + "м";
            label4.Text = Form2.hx.ToString("##.##") + "м";
            label5.Text = Form2.rx.ToString("##.##") + "м";
            label6.Text = Form2.r0.ToString("##.##") + "м";
            label7.Text = Form2.rx.ToString("##.##") + "м";
            label8.Text = Form2.r0.ToString("##.##") + "м";
        }
    }
}
