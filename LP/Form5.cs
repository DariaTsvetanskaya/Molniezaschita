﻿using System;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            label2.Text = Form4.h.ToString("##.##") + "м";
            label3.Text = Form4.hx.ToString("##.##") + "м";
            label4.Text = Form4.h0.ToString("##.##") + "м";
            label5.Text = Form4.rx.ToString("##.##") + "м"; ;
            label6.Text = Form4.r0.ToString("##.##") + "м";
            label7.Text = Form4.hx.ToString("##.##") + "м";
            label8.Text = Form4.rx.ToString("##.##") + "м";
        }
    }
}
