using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string function;
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            function = comboBox1.SelectedItem.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtBoxA.Text);
            double b = Convert.ToDouble(txtBoxB.Text);
            double x = a;
            double y;
            if (chart1.Series.Count > 0) chart1.Series.Clear();
            chart1.Series.Add(function);
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series[0].Color = Color.Red;
            chart1.Series[0].BorderWidth = 2;


            switch (function)
            {
                case "f(x) = 2^x":
                        do
                        {
                            y = Math.Pow(2, x);
                            chart1.Series[0].Points.AddXY(x, y);
                            x += 0.1;
                        } while (x <= b);
                    break;
                case "f(x) = logx":
                    do
                    {
                        y = Math.Log10(x);
                        chart1.Series[0].Points.AddXY(x, y);
                        x += 0.1;
                    } while (x <= b);
                    break;
                case "f(x) = e^x":
                    do
                    {
                        y = Math.Pow(Math.E, x);
                        chart1.Series[0].Points.AddXY(x, y);
                        x += 0.1;
                    } while (x <= b);
                    break;
                case "f(x) = sinx":
                    do
                    {
                        y = Math.Sin(x);
                        chart1.Series[0].Points.AddXY(x, y);
                        x += 0.1;
                    } while (x <= b);
                    break;
                case "f(x) = cosx":
                    do
                    {
                        y = Math.Cos(x);
                        chart1.Series[0].Points.AddXY(x, y);
                        x += 0.1;
                    } while (x <= b);
                    break;
                case "f(x) = tgx":
                    do
                    {
                        y = Math.Tan(x);
                        chart1.Series[0].Points.AddXY(x, y);
                        x += 0.1;
                    } while (x <= b);
                    break;
                case "f(x) = ctgx":
                    do
                    {
                        y = 1 / (Math.Tan(x));
                        chart1.Series[0].Points.AddXY(x, y);
                        x += 0.1;
                    } while (x <= b);
                    break;
            }
        }
    }
}
