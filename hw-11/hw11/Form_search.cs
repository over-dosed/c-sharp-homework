using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw8
{
    public partial class Form_search : Form
    {
        public string infomation;
        public string searchType { set; get; }
        public Form_search(String type)
        {
            InitializeComponent();
            searchType = type;
            label1.Text = "请输入筛选的" + type;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("请输入有效信息");
                    return;
                }
                if (searchType == "订单ID")
                {
                    int ID;
                    if (!int.TryParse(textBox1.Text,out ID)) //如果转换不成功
                    {
                        throw new Exception();
                    }
                    else
                    {
                        this.infomation = textBox1.Text;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                if(searchType == "订单总价")
                {
                    double price;
                    if (!double.TryParse(textBox1.Text, out price)) //如果转换不成功
                    {
                        throw new Exception();
                    }
                    else
                    {
                        this.infomation = textBox1.Text;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                this.infomation = textBox1.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("请输入有效信息");
                return;
            }
            
        }
    }
}
