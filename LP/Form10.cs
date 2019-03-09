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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        static public double h0 = 0.0, s = 0.0, d = 0.0, h = 0.0, A = 0.0, B = 0.0;
        private void button1_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(textBox1.Text)) || (string.IsNullOrEmpty(textBox2.Text)) || (string.IsNullOrEmpty(textBox3.Text)))
            {
                MessageBox.Show("Необходимо заполнить все поля");
            }
            if ((radioButton4.Checked) || (radioButton5.Checked) || (radioButton6.Checked) || (radioButton7.Checked))
            {
                h0 = Convert.ToDouble(textBox1.Text);
                s = Convert.ToDouble(textBox2.Text);
                d = Convert.ToDouble(textBox3.Text);
                if (radioButton2.Checked)
                {
                    A = -0.14 + 0.252 * (d - 5) + (0.127 + 6.4 * Math.Pow(10, -4) * (d - 5)) * Math.Sqrt(s);
                    B = 1.05 + 9.08 * Math.Pow(10, -3) * (d - 5) + (-3.44 * Math.Pow(10, -3) + 5.87 * Math.Pow(10, -5) * (d - 5)) * Math.Sqrt(s);
                }
                else
                {
                    A = -0.08 + 0.324 * (d - 5) + (0.161 + 2.41 * Math.Pow(10, -4) * (d - 5)) * Math.Sqrt(s);
                    B = 1.1 + 0.0115*(d-5)+(-4.25*Math.Pow(10,-3)+1.25*Math.Pow(10,-4)*(d-5))*Math.Sqrt(s);
                }
                h = A + B * h0;
                label2.Text = "Резульаты расчёта:\n" + "A= " + A.ToString("##.##") + "\nB= " +
                            B.ToString("##.##") + "\nh= " + h.ToString("####.##") + "м";
            }
            else
            {
                MessageBox.Show("Значение уровня защиты не выбрано");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.Show();
        }
    }
}
