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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        static public double h = 0.0, hx = 0.0, Lmax = 0.0, Lc = 0.0, Lx = 0.0, h0 = 0.0, 
            hc = 0.0, L = 200.0, r0 = 0.0, rx = 0.0, rcx = 0.0;
        private void button1_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(textBox1.Text)) || (string.IsNullOrEmpty(textBox2.Text)))
            {
                MessageBox.Show("Необходимо ввести значения h и hx");
            }
            else
            {
                h = Convert.ToDouble(textBox1.Text);
                hx = Convert.ToDouble(textBox2.Text);
                //уровень защиты
                if ((radioButton4.Checked) || (radioButton5.Checked) || (radioButton6.Checked) || (radioButton7.Checked))
                {
                    //0,9
                    if (radioButton1.Checked)
                    {
                        if ((h >= 0) && (h < 30))
                        {
                            Lmax = 5.75 * h;
                            Lc = 2.5 * h;
                            //h0 ?
                            h0 = 0.85 * h;
                            hc = ((Lmax - L) / (Lmax - Lc)) * h0;
                            r0 = 1.2 * h;
                            rx = (r0 * (h0 - hx)) / h0;
                            Lx = (L * (h0 - hx)) / (2 * (h0 - hc));
                            rcx = (r0 * (hc - hx)) / hc;
                            label2.Text = "Резульаты расчёта:\n" + "Lmax= " + Lmax.ToString("##.##") + "м" + "\nLc= " +
                            Lc.ToString("##.##") + "м" + "\nrx= " + rx.ToString("####.##") + "м" +
                            "\nlx= " + Lx.ToString("####.##") + "м" + "\nhc= " + hc.ToString("####.##") + "м";
                        }
                        else if ((h >= 30) && (h < 100))
                        {
                            Lmax = (5.75 - 3.57 * Math.Pow(10, -3) * (h - 30)) * h;
                            Lc = 2.5 * h;
                            h0 = 0.85 * h;
                            hc = ((Lmax - L) / (Lmax - Lc)) * h0;
                            r0 = 1.2 * h;
                            rx = (r0 * (h0 - hx)) / h0;
                            Lx = (L * (h0 - hx)) / (2 * (h0 - hc));
                            rcx = (r0 * (hc - hx)) / hc;
                            label2.Text = "Резульаты расчёта:\n" + "Lmax= " + Lmax.ToString("##.##") + "м" + "\nLc= " +
                            Lc.ToString("##.##") + "м" + "\nrx= " + rx.ToString("####.##") + "м" + 
                            "\nlx= " + Lx.ToString("####.##") + "м" + "\nhc= " + hc.ToString("####.##") + "м";
                        }
                        else if ((h >= 100) && (h < 150))
                        {
                            Lmax = 5.5 * h;
                            Lc = 2.5 * h;
                            h0 = 0.85 * h;
                            hc = ((Lmax - L) / (Lmax - Lc)) * h0;
                            r0 = (1.2 - Math.Pow(10, -3) * (h - 100)) * h;
                            rx = (r0 * (h0 - hx)) / h0;
                            Lx = (L * (h0 - hx)) / (2 * (h0 - hc));
                            rcx = (r0 * (hc - hx)) / hc;
                            label2.Text = "Резульаты расчёта:\n" + "Lmax= " + Lmax.ToString("##.##") + "м" + "\nLc= " +
                            Lc.ToString("##.##") + "м" + "\nrx= " + rx.ToString("####.##") + "м" +
                            "\nlx= " + Lx.ToString("####.##") + "м" + "\nhc= " + hc.ToString("####.##") + "м";
                        }
                        else
                        {
                            MessageBox.Show("Значение h не попадает в допустимый диапазон");
                        }
                    }
                    //0,99
                    if (radioButton2.Checked)
                    {
                        if ((h >= 0) && (h < 30))
                        {
                            Lmax = 4.75 * h;
                            Lc = 2.25 * h;
                            //h0 ?
                            h0 = 0.8 * h;
                            hc = ((Lmax - L) / (Lmax - Lc)) * h0;
                            r0 = 0.8 * h;
                            rx = (r0 * (h0 - hx)) / h0;
                            Lx = (L * (h0 - hx)) / (2 * (h0 - hc));
                            rcx = (r0 * (hc - hx)) / hc;
                            label2.Text = "Резульаты расчёта:\n" + "Lmax= " + Lmax.ToString("##.##") + "м" + "\nLc= " +
                            Lc.ToString("##.##") + "м" + "\nrx= " + rx.ToString("####.##") + "м" +
                            "\nlx= " + Lx.ToString("####.##") + "м" + "\nhc= " + hc.ToString("####.##") + "м";
                        }
                        else if ((h >= 30) && (h < 100))
                        {
                            Lmax = (4.75 - 3.57 * Math.Pow(10, -3) * (h - 30)) * h;
                            Lc = (2.25 - 0.00107*(h-30))*h;
                            h0 = 0.8 * h;
                            hc = ((Lmax - L) / (Lmax - Lc)) * h0;
                            r0 = (0.8-1.43*Math.Pow(10,-3)*(h-30))*h;
                            rx = (r0 * (h0 - hx)) / h0;
                            Lx = (L * (h0 - hx)) / (2 * (h0 - hc));
                            rcx = (r0 * (hc - hx)) / hc;
                            label2.Text = "Резульаты расчёта:\n" + "Lmax= " + Lmax.ToString("##.##") + "м" + "\nLc= " +
                            Lc.ToString("##.##") + "м" + "\nrx= " + rx.ToString("####.##") + "м" +
                            "\nlx= " + Lx.ToString("####.##") + "м" + "\nhc= " + hc.ToString("####.##") + "м";
                        }
                        else if ((h >= 100) && (h < 150))
                        {
                            Lmax = 4.5 * h;
                            Lc = 1.5 * h;
                            h0 = (0.8 - Math.Pow(10,-3)*(h-100))*h;
                            hc = ((Lmax - L) / (Lmax - Lc)) * h0;
                            r0 = 0.7;
                            rx = (r0 * (h0 - hx)) / h0;
                            Lx = (L * (h0 - hx)) / (2 * (h0 - hc));
                            rcx = (r0 * (hc - hx)) / hc;
                            label2.Text = "Резульаты расчёта:\n" + "Lmax= " + Lmax.ToString("##.##") + "м" + "\nLc= " +
                            Lc.ToString("##.##") + "м" + "\nrx= " + rx.ToString("####.##") + "м" +
                            "\nlx= " + Lx.ToString("####.##") + "м" + "\nhc= " + hc.ToString("####.##") + "м";
                        }
                        else
                        {
                            MessageBox.Show("Значение h не попадает в допустимый диапазон");
                        }
                    }
                    //0,999
                    if (radioButton3.Checked)
                    {
                        if ((h >= 0) && (h < 30))
                        {
                            Lmax = 4.25 * h;
                            Lc = 2.25 * h;
                            //h0 ?
                            h0 = 0.7 * h;
                            hc = ((Lmax - L) / (Lmax - Lc)) * h0;
                            r0 = 0.6 * h;
                            rx = (r0 * (h0 - hx)) / h0;
                            Lx = (L * (h0 - hx)) / (2 * (h0 - hc));
                            rcx = (r0 * (hc - hx)) / hc;
                            label2.Text = "Резульаты расчёта:\n" + "Lmax= " + Lmax.ToString("##.##") + "м" + "\nLc= " +
                            Lc.ToString("##.##") + "м" + "\nrx= " + rx.ToString("####.##") + "м" +
                            "\nlx= " + Lx.ToString("####.##") + "м" + "\nhc= " + hc.ToString("####.##") + "м";
                        }
                        else if ((h >= 30) && (h < 100))
                        {
                            Lmax = (4.25 - 3.57 * Math.Pow(10, -3) * (h - 30)) * h;
                            Lc = (2.25 - 0.00107 * (h - 30)) * h;
                            h0 = (0.7-7.14*Math.Pow(10,-4)*(h-30))*h;
                            hc = ((Lmax - L) / (Lmax - Lc)) * h0;
                            r0 = (0.6 - 1.43 * Math.Pow(10, -4) * (h - 30)) * h;
                            rx = (r0 * (h0 - hx)) / h0;
                            Lx = (L * (h0 - hx)) / (2 * (h0 - hc));
                            rcx = (r0 * (hc - hx)) / hc;
                            label2.Text = "Резульаты расчёта:\n" + "Lmax= " + Lmax.ToString("##.##") + "м" + "\nLc= " +
                            Lc.ToString("##.##") + "м" + "\nrx= " + rx.ToString("####.##") + "м" +
                            "\nlx= " + Lx.ToString("####.##") + "м" + "\nhc= " + hc.ToString("####.##") + "м";
                        }
                        else if ((h >= 100) && (h < 150))
                        {
                            Lmax = 4.0 * h;
                            Lc = 1.5 * h;
                            h0 = (0.65-Math.Pow(10,-3)*(h-100))*h;
                            hc = ((Lmax - L) / (Lmax - Lc)) * h0;
                            r0 = (0.5 - 2*Math.Pow(10, -3) * (h - 100)) * h;
                            rx = (r0 * (h0 - hx)) / h0;
                            Lx = (L * (h0 - hx)) / (2 * (h0 - hc));
                            rcx = (r0 * (hc - hx)) / hc;
                            label2.Text = "Резульаты расчёта:\n" + "Lmax= " + Lmax.ToString("##.##") + "м" + "\nLc= " +
                            Lc.ToString("##.##") + "м" + "\nrx= " + rx.ToString("####.##") + "м" +
                            "\nlx= " + Lx.ToString("####.##") + "м" + "\nhc= " + hc.ToString("####.##") + "м";
                        }
                        else
                        {
                            MessageBox.Show("Значение h не попадает в допустимый диапазон");
                        }
                    }  
                }
                else
                {
                    MessageBox.Show("Значение уровня защиты не выбрано");
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
        }
    }
}       
