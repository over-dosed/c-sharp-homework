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

            Guest guest1 = new Guest("aaa");
            Guest guest2 = new Guest("bbb");
            Guest guest3 = new Guest("ccc");

            Cargo notebook = new Cargo("notebook", 10.0);
            Cargo ipad = new Cargo("ipad", 4000.0);
            Cargo pencil = new Cargo("pencil", 2.0);
            Cargo juice = new Cargo("juice", 8.0);

            Dictionary<Cargo, uint> goods1 = new Dictionary<Cargo, uint>();
            Dictionary<Cargo, uint> goods2 = new Dictionary<Cargo, uint>();
            Dictionary<Cargo, uint> goods3 = new Dictionary<Cargo, uint>();

            goods1.Add(juice, 5); goods1.Add(notebook, 2500); goods1.Add(ipad, 1);
            goods2.Add(notebook, 5); goods2.Add(juice, 25); goods2.Add(ipad, 1);
            goods3.Add(notebook, 5); goods3.Add(pencil, 25); goods3.Add(juice, 1);

            Order order1 = os1.CreateAOrder(guest1, goods1, "BeiJing");
            Order order2 = os1.CreateAOrder(guest2, goods2, "ShangHai");
            Order order3 = os1.CreateAOrder(guest3, goods3, "GuangZhou");
            bindingSource1.List.Add(order1);
            bindingSource1.List.Add(order2);
            bindingSource1.List.Add(order3);

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
                
                Order[] orders = new Order[9999];
                bindingSource1.List.CopyTo(orders, 0);
                Array.Sort(orders);
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
                Order[] orders = new Order[9999];
                bindingSource1.List.CopyTo(orders, 0);

                Array.Sort<Order>(orders, (p1, p2) => {
                    if(p1 == null)
                    {
                        if (p2 == null) return 0;
                        else return -1;
                    }
                    else
                    {
                        if (p2 == null) return 1;
                        else return p1.orderNum - p2.orderNum;
                    }
                });
                bindingSource1.List.Clear();
                foreach (Order order in orders)
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
