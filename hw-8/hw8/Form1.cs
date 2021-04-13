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
using System.Xml.Serialization;
using System.IO;

namespace hw8
{

    
    public partial class Form1 : Form
    {
        public OrderService os1 { set; get; }

        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = comboBox1.Items.IndexOf("默认");
            
        }

        private void 增加订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_addOrder addOrderForm = new Form_addOrder();
            DialogResult dialogResult = addOrderForm.ShowDialog();
            if(dialogResult == DialogResult.OK)
            {
                 //将addOrderForm的订单添加到os1中
                bindingSource1.List.Add(addOrderForm.addOrder);
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            dataGridView3.Top = dataGridView1.Location.Y;
            dataGridView3.Left = dataGridView1.Location.X + dataGridView1.Width;
        }

        private void 客户ToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if(客户ToolStripMenuItem.Checked == true)
            {
                dataGridView1.Width = this.Width - dataGridView3.MinimumSize.Width;
                dataGridView3.Left = dataGridView1.Location.X + dataGridView1.Width;
            }
            else
            {
                dataGridView1.Width = this.Width ;
                dataGridView3.Left = dataGridView1.Location.X + dataGridView1.Width;
            }
        }

        private void 订单号ToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if(订单号ToolStripMenuItem.Checked == false)
            {
                dataGridView1.Columns[0].Visible = false;
            }
            else
            {
                dataGridView1.Columns[0].Visible = true;
            }
        }

        private void 下单时间ToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (下单时间ToolStripMenuItem.Checked == false)
            {
                dataGridView1.Columns[1].Visible = false;
            }
            else
            {
                dataGridView1.Columns[1].Visible = true;
            }
        }

        private void 总价ToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (总价ToolStripMenuItem.Checked == false)
            {
                dataGridView1.Columns[2].Visible = false;
            }
            else
            {
                dataGridView1.Columns[2].Visible = true;
            }
        }

        private void 订单地址ToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (订单地址ToolStripMenuItem.Checked == false)
            {
                dataGridView1.Columns[3].Visible = false;
            }
            else
            {
                dataGridView1.Columns[3].Visible = true;
            }
        }


        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // 在选择列出现后，点击列表选择订单
            if(button_delete.Visible == false && button_modify.Visible == false)
            {
                return;
            }
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                //checkbox 勾上
                if ((bool)dataGridView1.Rows[e.RowIndex].Cells[4].EditedFormattedValue == true)
                {
                    //选中改为不选中
                    this.dataGridView1.Rows[e.RowIndex].Cells[4].Value = false;
                }
                else
                {
                    //不选中改为选中
                    this.dataGridView1.Rows[e.RowIndex].Cells[4].Value = true;
                }
                foreach(DataGridViewRow dataGridViewRow in dataGridView1.Rows)
                {
                    if(dataGridViewRow.Cells[4].Value == null)
                    {
                        dataGridViewRow.Cells[4].Value = false;
                    }
                    if((bool)dataGridViewRow.Cells[4].Value == true)
                    {
                        if(button_modify.Visible == true)
                        {
                            button_modify.Enabled = true; //如果可见，则启用
                        }
                        if(button_delete.Visible == true)
                        {
                            button_delete.Enabled = true; //如果有行被选中，按钮生效
                        }
                        return;
                    }
                }
                button_delete.Enabled = false;//如果无行被选中，按钮失效
            }
        }

        private void button_modify_Click(object sender, EventArgs e)  //修改订单
        {
            Form_modifyOrder modifyOrderForm = new Form_modifyOrder();
            DialogResult dialogResult = modifyOrderForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                for(int i = 0;i< dataGridView1.Rows.Count;i++)
                {
                    if (dataGridView1.Rows[i].Cells[4].Value == null)
                    {
                        dataGridView1.Rows[i].Cells[4].Value = false;
                        continue;
                    }
                    if ((bool)dataGridView1.Rows[i].Cells[4].Value == true)
                    {
                        bindingSource1.List.RemoveAt(i);
                        bindingSource1.List.Insert(i, modifyOrderForm.modifyOrder);
                    }
                }
                button_delete.Enabled = false;
                button_delete.Visible = false;
                button_modify.Enabled = false;
                button_modify.Visible = false;
                dataGridView1.Columns[4].Visible = false;
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            deleteOrder(0); //从0开始递归删除list中订单
            button_delete.Enabled = false;
            button_delete.Visible = false;
            button_modify.Enabled = false;
            button_modify.Visible = false;
            dataGridView1.Columns[4].Visible = false;
        }

        private void deleteOrder(int index)
        {
            for(int i = index;i< dataGridView1.Rows.Count;i++)
            {
                if(dataGridView1.Rows[i].Cells[4].Value == null)
                {
                    dataGridView1.Rows[i].Cells[4].Value = false;
                    continue;
                }
                if ((bool)dataGridView1.Rows[i].Cells[4].Value == true)
                {
                    bindingSource1.List.RemoveAt(i);
                    deleteOrder(i);
                    return;
                }
            }
        }//递归删除订单

        private void 修改订单ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            button_modify.Visible = true;
            dataGridView1.Columns[4].Visible = true;
        }

        private void 删除订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_delete.Visible = true;
            dataGridView1.Columns[4].Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem.ToString() == "按订单总价排序")
            {
                if (bindingSource1.List == null)
                {
                    return;
                }

                List<Order> orders = new List<Order>();
                foreach (Order order1 in bindingSource1.List)
                {
                    orders.Add(order1);
                }
                orders.Sort();
                bindingSource1.List.Clear();
                foreach(Order order in orders)
                {
                    if(order != null)
                    {
                        bindingSource1.List.Add(order);
                    }
                }
            }
            if (comboBox1.SelectedItem.ToString() == "按订单ID排序")
            {
                if (bindingSource1.List == null)
                {
                    return;
                }
                List<Order> orders = new List<Order>();
                foreach (Order order1 in bindingSource1.List)
                {
                    orders.Add(order1);
                }
                orders.Sort((p1, p2) => p1.orderNum - p2.orderNum);
                bindingSource1.List.Clear();
                foreach (Order order in orders)
                {
                    if (order != null)
                    {
                        bindingSource1.List.Add(order);
                    }
                }
            }
        }  //排序

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Form_showDetails showDetails = new Form_showDetails(bindingSource1);
            showDetails.ShowDialog();
        }

        // 筛选按钮触发事件
        private void 按订单IDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_search searchOrderForm = new Form_search("订单ID");
            DialogResult dialogResult = searchOrderForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                CurrencyManager cm = (CurrencyManager)BindingContext[dataGridView1.DataSource];
                cm.SuspendBinding(); //挂起数据绑定

                for (int i = 0; i < bindingSource1.List.Count; i++)
                {
                    Order order = (Order)bindingSource1.List[i];
                    if (order.orderNum != int.Parse(searchOrderForm.infomation))
                    {
                        //i 也可以用于表示该订单在哪一行（包括不可见行）
                        dataGridView1.Rows[i].Visible = false;
                    }
                }

                cm.ResumeBinding(); //继续数据绑定
            }
        }

        private void 按客户名称ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            客户ToolStripMenuItem.Checked = true;
            Form_search searchOrderForm = new Form_search("客户名称");
            DialogResult dialogResult = searchOrderForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                CurrencyManager cm = (CurrencyManager)BindingContext[dataGridView1.DataSource];
                cm.SuspendBinding(); //挂起数据绑定

                for (int i = 0;i< bindingSource1.List.Count;i++)
                {
                    Order order = (Order)bindingSource1.List[i];
                    if (order.guest.name != searchOrderForm.infomation)
                    {
                         //i 也可以用于表示该订单在哪一行（包括不可见行）
                        dataGridView1.Rows[i].Visible = false;

                    }
                }
               
                cm.ResumeBinding(); //继续数据绑定
            }
        }

        private void 按订单总价ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_search searchOrderForm = new Form_search("订单总价");
            DialogResult dialogResult = searchOrderForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                CurrencyManager cm = (CurrencyManager)BindingContext[dataGridView1.DataSource];
                cm.SuspendBinding(); //挂起数据绑定

                for (int i = 0; i < bindingSource1.List.Count; i++)
                {
                    Order order = (Order)bindingSource1.List[i];
                    if (order.orderPrice != double.Parse(searchOrderForm.infomation))
                    {
                        //i 也可以用于表示该订单在哪一行（包括不可见行）
                        dataGridView1.Rows[i].Visible = false;
                    }
                }

                cm.ResumeBinding(); //继续数据绑定
            }
        }

        private void 按订单货物ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_search searchOrderForm = new Form_search("订单货物");
            DialogResult dialogResult = searchOrderForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                CurrencyManager cm = (CurrencyManager)BindingContext[dataGridView1.DataSource];
                cm.SuspendBinding(); //挂起数据绑定

                for (int i = 0; i < bindingSource1.List.Count; i++)
                {
                    Order order = (Order)bindingSource1.List[i];
                    if (!order.hasTheCargo(searchOrderForm.infomation))
                    {
                        //i 也可以用于表示该订单在哪一行（包括不可见行）
                        dataGridView1.Rows[i].Visible = false;
                    }
                }

                cm.ResumeBinding(); //继续数据绑定
            }
        }

        private void 重置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow dataGridViewRow in dataGridView1.Rows)
            {
                dataGridViewRow.Visible = true;
            }
        }

        private void 导出文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            // Environment.SpecialFolder.MyDocuments 表示在我的文档中
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);   // 获取文件路径
            saveFileDialog.Filter = "XML文件|*.xml";
            saveFileDialog.DefaultExt = ".xml";   // 默认文件的拓展名
            saveFileDialog.FileName = "orders.xml";   // 文件默认名
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fName = saveFileDialog.FileName;

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
                using (FileStream fs = new FileStream(fName, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite))
                {
                    List<Order> orders = new List<Order>();
                    foreach (Order order in bindingSource1.List)
                    {
                        orders.Add(order);
                    }
                    xmlSerializer.Serialize(fs, orders);
                    fs.Flush();
                };
            }
        }

        private void 导入文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            // Environment.SpecialFolder.MyDocuments 表示在我的文档中
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);   // 获取文件路径
            ofd.Filter = "XML文件|*.xml";
            ofd.DefaultExt = ".xml";   // 默认文件的拓展名
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string fName = ofd.FileName;
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
                using (FileStream fs = new FileStream(fName, FileMode.Open))
                {
                    List<Order> orders2 = (List<Order>)xmlSerializer.Deserialize(fs);                    //逆序列化到orders2中
                    List<Order> orders1 = new List<Order>();
                    foreach (Order order in bindingSource1.List)
                    {
                        orders1.Add(order);
                    }//原本orders放在orders1里

                    orders2.ForEach(p =>
                    {  //双层循环判断是否与原订单列表中订单重复，重复项不添加
                        bool has = false;
                        foreach (Order x in orders1)
                        {
                            if (p.Equals(x))
                            {
                                has = true;
                                break;
                            }
                        }
                        if (!has)
                        {
                            orders1.Add(p);
                        }
                    });

                    bindingSource1.List.Clear();
                    foreach (Order order in orders1)
                    {
                        if (order != null)
                        {
                            bindingSource1.List.Add(order);
                        }
                    }

                }
            }
        }
    }
}
