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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Form2 form2 = new Form2();
                form2.Show();
            }
            else if (radioButton2.Checked)
            {
                Form4 form4 = new Form4();
                form4.Show();
            }
            else if (radioButton3.Checked)
            {
                Form6 form6 = new Form6();
                form6.Show();
            }
            else if (radioButton4.Checked)
            {
                Form8 form8 = new Form8();
                form8.Show();
            }
            else if (radioButton5.Checked)
            {
                Form10 form10 = new Form10();
                form10.Show();
            }
        }

        private void информацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12();
            form12.Show();
        }
    }
}
