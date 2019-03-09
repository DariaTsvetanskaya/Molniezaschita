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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        static public double h = 0.0, hx = 0.0, h0 = 0.0, r0 = 0.0, rx = 0.0;
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
                    //если 0,9
                    if (radioButton1.Checked)
                    {
                        if ((h >= 0) && (h <= 150))
                        {
                            h0 = 0.87 * h;
                            r0 = 1.5 * h;
                            rx = (r0 * (h0 - hx)) / h0;
                            label2.Text = "Резульаты расчёта:\n" + "h0= " + h0.ToString("##.##") + "м" + "\nr0= " +
                            r0.ToString("##.##") + "м" + "\nrx= " + rx.ToString("####.##") + "м";
                        }
                        else
                        {
                            MessageBox.Show("Значение h не попадает в допустимый диапазон");
                        }
                    }                    
                    //если 0,99
                    else if (radioButton2.Checked)
                    {
                        if ((h >= 0) && (h < 30))
                        {
                            h0 = 0.8 * h;
                            r0 = 0.95 * h;
                            rx = (r0 * (h0 - hx)) / h0;
                            label2.Text = "Резульаты расчёта:\n" + "h0= " + h0.ToString("##.##") + "м" + "\nr0= " +
                            r0.ToString("##.##") + "м" + "\nrx= " + rx.ToString("####.##") + "м";
                        }
                        else if ((h >= 30) && (h < 100))
                        {
                            h0 = 0.8 * h;
                            r0 = (0.95 - 7.14 * Math.Pow(10, -4) * (h - 30)) * h;
                            rx = (r0 * (h0 - hx)) / h0;
                            label2.Text = "Резульаты расчёта:\n" + "h0= " + h0.ToString("##.##") + "м" + "\nr0= " +
                            r0.ToString("##.##") + "м" + "\nrx= " + rx.ToString("####.##") + "м";
                        }
                        else if ((h >= 100) && (h <= 150))
                        {
                            h0 = 0.8 * h;
                            r0 = (0.9 - Math.Pow(10, -3) * (h - 100)) * h;
                            rx = (r0 * (h0 - hx)) / h0;
                            label2.Text = "Резульаты расчёта:\n" + "h0= " + h0.ToString("##.##") + "м" + "\nr0= " +
                            r0.ToString("##.##") + "м" + "\nrx= " + rx.ToString("####.##") + "м";
                        }
                        else
                        {
                            MessageBox.Show("Значение h не попадает в допустимый диапазон");
                        }
                    }
                    //если 0,999
                    else if (radioButton3.Checked)
                    {
                        if ((h >= 0) && (h < 30))
                        {
                            h0 = 0.75 * h;
                            r0 = 0.7 * h;
                            rx = (r0 * (h0 - hx)) / h0;
                            label2.Text = "Резульаты расчёта:\n" + "h0= " + h0.ToString("##.##") + "м" + "\nr0= " +
                            r0.ToString("##.##") + "м" + "\nrx= " + rx.ToString("####.##") + "м";
                        }
                        else if ((h >= 30) && (h < 100))
                        {
                            h0 = (0.75 - 4.28 * Math.Pow(10, -4) * (h - 30)) * h;
                            r0 = (0.7 - 1.43 * Math.Pow(10, -3) * (h - 30)) * h;
                            rx = (r0 * (h0 - hx)) / h0;
                            label2.Text = "Резульаты расчёта:\n" + "h0= " + h0.ToString("##.##") + "м" + "\nr0= " +
                            r0.ToString("##.##") + "м" + "\nrx= " + rx.ToString("####.##") + "м";
                        }
                        else if ((h >= 100) && (h <= 150))
                        {
                            h0 = (0.72 - Math.Pow(10, -3) * (h - 100)) * h;
                            r0 = (0.6 - Math.Pow(10, -3) * (h - 100)) * h;
                            rx = (r0 * (h0 - hx)) / h0;
                            label2.Text = "Резульаты расчёта:\n" + "h0= " + h0.ToString("##.##") + "м" + "\nr0= " +
                            r0.ToString("##.##") + "м" + "\nrx= " + rx.ToString("####.##") + "м";
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
            Form5 form5 = new Form5();
            form5.Show();
        }
    }   
}
