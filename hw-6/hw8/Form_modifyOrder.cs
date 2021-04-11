using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace hw8
{
    public partial class Form_modifyOrder : Form
    {
        public Form_modifyOrder()
        {
            InitializeComponent();
        }

        public Order modifyOrder { get; set; } = new Order();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string guestName = textBox1.Text;
                if (guestName == "")  //若未输入客户名称
                {
                    throw new NullReferenceException("未输入客户名称！");
                }
                Guest guest = new Guest(guestName);

                string address = textBox2.Text;
                if (address == "")  //若未输入地址
                {
                    throw new NullReferenceException("未输入配送地址！");
                }

                Dictionary<Cargo, uint> goods = new Dictionary<Cargo, uint>();
                //建立货物的字典

                foreach (DataGridViewRow row in dataGridView1.Rows) //遍历数据表单中的行
                {
                    if (row.IsNewRow) break;
                    string cargoName = (string)row.Cells[0].Value;
                    if (cargoName == "")  //若未输入商品名称
                    {
                        throw new IOException("未输入商品名称！");
                    }

                    uint cargoCount = uint.Parse((string)row.Cells[1].Value);
                    if (cargoCount == 0)  //若数量为0
                    {
                        throw new IOException("商品数量为0！");
                    }

                    if(row.Cells[2].Value == null)
                    {
                        row.Cells[2].Value = 0;
                    }
                    double cargoPrice = double.Parse(row.Cells[2].Value.ToString());
                    if (cargoPrice == 0)  //若单价为0
                    {
                        throw new IOException("商品单价错误！");
                    }

                    Cargo cargo = new Cargo(cargoName, cargoPrice);
                    try   //尝试添加货物进入dictionary
                    {
                        goods.Add(cargo, cargoCount);
                    }
                    catch (ArgumentException)
                    {
                        goods[cargo] += cargoCount;
                    }
                    // 这里如果商品相同会抛出ArgumentException
                }

                modifyOrder = new OrderService().CreateAOrder(guest, goods, address);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (NullReferenceException)
            {
                System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
                messageBoxCS.AppendFormat("生成失败");
                messageBoxCS.AppendLine();
                messageBoxCS.AppendFormat("原因：" + " 无效的客户名称或配送地址");
                messageBoxCS.AppendLine();
                MessageBox.Show(messageBoxCS.ToString());
            }
            catch (IOException)
            {
                System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
                messageBoxCS.AppendFormat("生成失败");
                messageBoxCS.AppendLine();
                messageBoxCS.AppendFormat("原因：" + " 无效的商品名称/商品单价/商品数量");
                messageBoxCS.AppendLine();
                MessageBox.Show(messageBoxCS.ToString());
            }
        }

        private void txtDotNumber(object sender, KeyPressEventArgs e)
        {
            //运用正则表达式，限制输入框内只能输入带小数点的数字

            Regex rg = new Regex(@"^\d*[.]?\d*$");
            if (!rg.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void txtNumber(object sender, KeyPressEventArgs e)
        {
            //运用正则表达式，限制输入框内只能输入数字

            Regex rg = new Regex(@"^\d*$");
            if (!rg.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        public DataGridViewTextBoxEditingControl cellEdit = null;
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //将输入限制绑定到对应的列上
            if (dataGridView1.CurrentCell.ColumnIndex == 0)
            {
                if (cellEdit != null)
                {
                    cellEdit.KeyPress -= txtNumber;
                    cellEdit.KeyPress -= txtDotNumber;
                }
            }
            if (dataGridView1.CurrentCell.ColumnIndex == 1)
            {
                //转化为textbox控件
                cellEdit = (DataGridViewTextBoxEditingControl)e.Control;
                //选中文本框中所有文本
                cellEdit.SelectAll();
                cellEdit.KeyPress -= txtDotNumber;
                cellEdit.KeyPress += txtNumber;
            }
            if (dataGridView1.CurrentCell.ColumnIndex == 2)
            {
                //转化为textbox控件
                cellEdit = (DataGridViewTextBoxEditingControl)e.Control;
                //选中文本框中所有文本
                cellEdit.SelectAll();
                cellEdit.KeyPress -= txtNumber;
                cellEdit.KeyPress += txtDotNumber;
            }
        }
    }
}
