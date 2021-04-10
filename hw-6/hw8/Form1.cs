using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hw6_framework;

namespace hw8
{
    public partial class Form1 : Form
    {
        public OrderService os1 { set; get; }
        public Form1()
        {
            InitializeComponent();
            os1 = new OrderService();

            comboBox1.SelectedIndex = comboBox1.Items.IndexOf("默认");

        }

        private void 增加订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form_addOrder().ShowDialog();
        }
    }
}
