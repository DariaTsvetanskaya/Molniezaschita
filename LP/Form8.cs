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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        static public double h = 0.0, hx = 0.0, Lmax = 0.0, Lc = 0.0, Lx = 0.0, h0 = 0.0,
            hc = 0.0, L = 250.0, r0 = 0.0, rx = 0.0, rcx = 0.0;
        private void button1_Click_1(object sender, EventArgs e)
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
                        if ((h >= 0) && (h <= 150))
                        {
                            Lmax = 6.0 * h;
                            Lc = 3.0 * h;
                            //h0 ?
                            h0 = 0.87 * h;
                            hc = ((Lmax - L) / (Lmax - Lc)) * h0;
                            r0 = 1.5 * h;
                            rx = (r0 * (h0 - hx)) / h0;
                            if (hc >= hx)
                            {
                                Lx = L / 2;
                            }
                            else
                            {
                                Lx = (L * (h0 - hx)) / (2 * (h0 - hc));
                            }
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
                            Lmax = 5.0 * h;
                            Lc = 2.5 * h;
                            //h0 ?
                            h0 = 0.8 * h;
                            hc = ((Lmax - L) / (Lmax - Lc)) * h0;
                            r0 = 0.95 * h;
                            rx = (r0 * (h0 - hx)) / h0;
                            if (hc >= hx)
                            {
                                Lx = L / 2;
                            }
                            else
                            {
                                Lx = (L * (h0 - hx)) / (2 * (h0 - hc));
                            }
                            rcx = (r0 * (hc - hx)) / hc;
                            label2.Text = "Резульаты расчёта:\n" + "Lmax= " + Lmax.ToString("##.##") + "м" + "\nLc= " +
                            Lc.ToString("##.##") + "м" + "\nrx= " + rx.ToString("####.##") + "м" +
                            "\nlx= " + Lx.ToString("####.##") + "м" + "\nhc= " + hc.ToString("####.##") + "м";
                        }
                        if ((h >= 30) && (h < 100))
                        {
                            Lmax = 5.0 * h;
                            Lc = (2.5 - 5.0 * Math.Pow(10, -3) * (h - 100)) * h;
                            //h0 ?
                            h0 = 0.8 * h;
                            hc = ((Lmax - L) / (Lmax - Lc)) * h0;
                            r0 = (0.95 - 7.14 * Math.Pow(10, -4) * (h - 30)) * h; ;
                            rx = (r0 * (h0 - hx)) / h0;
                            if (hc >= hx)
                            {
                                Lx = L / 2;
                            }
                            else
                            {
                                Lx = (L * (h0 - hx)) / (2 * (h0 - hc));
                            }
                            rcx = (r0 * (hc - hx)) / hc;
                            label2.Text = "Резульаты расчёта:\n" + "Lmax= " + Lmax.ToString("##.##") + "м" + "\nLc= " +
                            Lc.ToString("##.##") + "м" + "\nrx= " + rx.ToString("####.##") + "м" +
                            "\nlx= " + Lx.ToString("####.##") + "м" + "\nhc= " + hc.ToString("####.##") + "м";
                        }
                        if ((h >= 100) && (h <= 150))
                        {
                            Lmax = (5.0 - 5 * Math.Pow(10, -3) * (h - 100)) * h; ;
                            Lc = (2.0 - 5.0 * Math.Pow(10, -3) * (h - 100)) * h;
                            //h0 ?
                            h0 = 0.8 * h;
                            hc = ((Lmax - L) / (Lmax - Lc)) * h0;
                            r0 = (0.9 - Math.Pow(10, -3) * (h - 100)) * h; ;
                            rx = (r0 * (h0 - hx)) / h0;
                            if (hc >= hx)
                            {
                                Lx = L / 2;
                            }
                            else
                            {
                                Lx = (L * (h0 - hx)) / (2 * (h0 - hc));
                            }
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
                            Lmax = 4.75 * h;
                            Lc = 2.25 * h;
                            //h0 ?
                            h0 = 0.75 * h;
                            hc = ((Lmax - L) / (Lmax - Lc)) * h0;
                            r0 = 0.7 * h;
                            rx = (r0 * (h0 - hx)) / h0;
                            if (hc >= hx)
                            {
                                Lx = L / 2;
                            }
                            else
                            {
                                Lx = (L * (h0 - hx)) / (2 * (h0 - hc));
                            }
                            rcx = (r0 * (hc - hx)) / hc;
                            label2.Text = "Резульаты расчёта:\n" + "Lmax= " + Lmax.ToString("##.##") + "м" + "\nLc= " +
                            Lc.ToString("##.##") + "м" + "\nrx= " + rx.ToString("####.##") + "м" +
                            "\nlx= " + Lx.ToString("####.##") + "м" + "\nhc= " + hc.ToString("####.##") + "м";
                        }
                        if ((h >= 30) && (h < 100))
                        {
                            Lmax = (4.75 - 3.57 * Math.Pow(10, -3) * (h - 30)) * h; ;
                            Lc = (2.25 - 3.57 * Math.Pow(10, -3) * (h - 30)) * h;
                            //h0 ?
                            h0 = (0.75 - 4.28 * Math.Pow(10, -4) * (h - 30)) * h; ;
                            hc = ((Lmax - L) / (Lmax - Lc)) * h0;
                            r0 = (0.7 - 1.43 * Math.Pow(10, -4) * (h - 30)) * h; ;
                            rx = (r0 * (h0 - hx)) / h0;
                            if (hc >= hx)
                            {
                                Lx = L / 2;
                            }
                            else
                            {
                                Lx = (L * (h0 - hx)) / (2 * (h0 - hc));
                            }
                            rcx = (r0 * (hc - hx)) / hc;
                            label2.Text = "Резульаты расчёта:\n" + "Lmax= " + Lmax.ToString("##.##") + "м" + "\nLc= " +
                            Lc.ToString("##.##") + "м" + "\nrx= " + rx.ToString("####.##") + "м" +
                            "\nlx= " + Lx.ToString("####.##") + "м" + "\nhc= " + hc.ToString("####.##") + "м";
                        }
                        if ((h >= 100) && (h <= 150))
                        {
                            Lmax = (4.5 - 5 * Math.Pow(10, -3) * (h - 100)) * h; ;
                            Lc = (2.0 - 5.0 * Math.Pow(10, -3) * (h - 100)) * h;
                            //h0 ?
                            h0 = (0.72 - Math.Pow(10, -3) * (h - 100)) * h;
                            hc = ((Lmax - L) / (Lmax - Lc)) * h0;
                            r0 = (0.6 - Math.Pow(10, -3) * (h - 100)) * h; ;
                            rx = (r0 * (h0 - hx)) / h0;
                            if (hc >= hx)
                            {
                                Lx = L / 2;
                            }
                            else
                            {
                                Lx = (L * (h0 - hx)) / (2 * (h0 - hc));
                            }
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
        private void button2_Click_1(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
        }
    }
}
