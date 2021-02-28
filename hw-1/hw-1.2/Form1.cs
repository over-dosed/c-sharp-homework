using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw_1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            string sign;
            InitializeComponent();
            this.comboBox2.Items.AddRange(new string[4] { "+", "-", "*", "/" });
            this.textBox3.Text = "0";
            this.textBox4.Text = "0";
            this.label2.Text = "0";
            this.label3.Text = "=";//默认显示“ = ”
            this.button2.Text = "calculate";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b, c = 0;
            string sign;
            a = int.Parse(textBox3.Text);
            b = int.Parse(textBox4.Text);
            sign = comboBox2.SelectedItem.ToString();
            switch (sign)
            {
                case "+": c = a + b;break;
                case "-": c = a - b; break;
                case "*": c = a * b; break;
                case "/": c = a / b; break;
            }
            label2.Text = c.ToString();
        }
    }
}
