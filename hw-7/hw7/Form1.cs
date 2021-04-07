using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Graphics graphics;

        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = this.CreateGraphics();
            int n = int.Parse(textBox1.Text);
            double x0 = 500;double y0 = 400;
            double leng = double.Parse(textBox2.Text);
            double th = -Math.PI / 2;
            double th1 = double.Parse(textBox4.Text);
            double th2 = double.Parse(textBox6.Text);
            double per1 = double.Parse(textBox3.Text);
            double per2 = double.Parse(textBox5.Text);
            String color = comboBox1.Text;

            drawCayleyTree(n, x0, y0, leng, th, th1, th2, per1, per2, color);
        }

        void drawLine(double x0, double y0,double x1,double y1,String color)
        {
            Color color1 = Color.FromName(color);
            Pen pen = new Pen(color1);
            graphics.DrawLine(pen, (int)x0, (int)y0, (int)x1, (int)y1);
        }
        void drawCayleyTree(int n,double x0,double y0,double leng,double th,
            double th1,double th2,double per1,double per2,String color)
        {
            if (n == 0) return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1, color);

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1,
                th1,th2,per1,per2,color);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2,
                th1, th2, per1, per2, color);
        }

        private void comboBox1_Layout(object sender, LayoutEventArgs e)
        {
            Type ColorCollection = typeof(System.Drawing.KnownColor);
           
            foreach (string colorName in Enum.GetNames(ColorCollection))
            {
                comboBox1.Items.Add(colorName);
            }
        }
    }
}
