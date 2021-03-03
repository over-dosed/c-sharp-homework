using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw_2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void calculateArrayButton_Click(object sender, EventArgs e)
        {
            const int arrayNum = 20;//定义数组最大数为20
            int[] num = new int[arrayNum];
            string[] sArray = arrayInputText.Text.Split(new char[3] { ' ', ',','，' }); //将用户输入的字符串以空格和逗号区分
            for (int i = 0; i < sArray.Length; i++)
            {
                num[i] = int.Parse(sArray[i]);
            }
            int max = num[0], min = num[0], arr = 0, sum = 0;
            int arrayNumCount = 0;//用于计数-数组中多少个元素
            for(arrayNumCount = 0; arrayNumCount < arrayNum && num[arrayNumCount] != 0; arrayNumCount++)
            {
                max = num[arrayNumCount] > max ? num[arrayNumCount] : max;
                min = num[arrayNumCount] < min ? num[arrayNumCount] : min;
                sum += num[arrayNumCount];
            }
            arr = sum / arrayNumCount;

            maxNumberLabel.Text = max.ToString();
            minNumberLabel.Text = min.ToString();
            arrNumberLabel.Text = arr.ToString();
            sumNumberLabel.Text = sum.ToString();
        }
    }
}
