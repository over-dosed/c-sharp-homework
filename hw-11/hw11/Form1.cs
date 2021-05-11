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
using hw8.Properties;

namespace hw8
{

    
    public partial class Form1 : Form
    {
        public OrderService os1 { set; get; }

        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = comboBox1.Items.IndexOf("默认");
            using (var db = new OrderModel())
            {
                bindingSource1.DataSource = db.Orders.ToList<Order>();
            }
        }

        private void 增加订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_addOrder addOrderForm = new Form_addOrder();
            DialogResult dialogResult = addOrderForm.ShowDialog();
            if(dialogResult == DialogResult.OK)
            {
                using(var db = new OrderModel())
                {
                    db.Orders.Add(addOrderForm.addOrder);
                    db.SaveChanges();
                    bindingSource1.DataSource = db.Orders.ToList<Order>();
                }

                 //将addOrderForm的订单添加到os1中
                 // bindingSource1.List.Add(addOrderForm.addOrder);
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
                        int num = (int)dataGridView1.Rows[i].Cells[0].Value;
                        using (var db = new OrderModel())
                        {
                            var order = db.Orders.Include("OrderDetails").First(p => p.orderNumber == num); //在数据库中找到一个订单num对应的订单
                            if (order != null)
                            {
                                order.guest = modifyOrderForm.modifyOrder.guest;
                                order.orderAddress = modifyOrderForm.modifyOrder.orderAddress;
                                
                                var orderdetails = db.OrderDetails.Where(p => p.Order.orderNumber == order.orderNumber);
                                foreach(OrderDetails orderDetails1 in orderdetails)
                                {
                                    db.OrderDetails.Remove(orderDetails1);
                                }
                                
                                db.SaveChanges();
                                //order.orderDetails.Clear();
                                int cou = 1;
                                foreach (var good in modifyOrderForm.goods) //遍历字典，将所有商品及数量添加到订单中
                                {
                                    OrderDetails orderDetails = new OrderDetails(good.Key, good.Value);
                                    orderDetails.OrderId = order.orderNumber;
                                    orderDetails.Order = order;
                                    orderDetails.OrderDetailsId = int.Parse(order.orderTime.Day + "" + cou++);
                                    order.orderDetails.Add(orderDetails);
                                }
                                order.reCalculatePrice();
                                db.SaveChanges();
                            }
                        }
                        //bindingSource1.List.Insert(i, modifyOrderForm.modifyOrder);
                    }
                }

                using (var db = new OrderModel())
                {
                    bindingSource1.DataSource = db.Orders.ToList<Order>();
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
            using (var db = new OrderModel())
            {
                bindingSource1.DataSource = db.Orders.ToList<Order>();
            }
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
                    int num = (int)dataGridView1.Rows[i].Cells[0].Value;
                    using (var db = new OrderModel())
                    {
                        var order = db.Orders.Include("OrderDetails").First(p => p.orderNumber == num); //在数据库中找到一个订单num对应的订单
                        if(order != null)
                        {
                            db.Orders.Remove(order);
                            db.SaveChanges();
                        }
                    }
                    // bindingSource1.List.RemoveAt(i);
                    //deleteOrder(i);
                }
            }
            return;
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

                using (var db = new OrderModel())
                {
                    var ordersort = db.Orders.OrderBy(p => p.orderPrice);
                    db.SaveChanges();
                    bindingSource1.DataSource = ordersort.ToList<Order>();
                }

            }
            if (comboBox1.SelectedItem.ToString() == "按订单ID排序")
            {
                if (bindingSource1.List == null)
                {
                    return;
                }
                using (var db = new OrderModel())
                {
                    var ordersort = db.Orders.OrderBy(p => p.orderNumber);
                    db.SaveChanges();
                    bindingSource1.DataSource = ordersort.ToList<Order>();
                }
            }
        }  //排序

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Form_showDetails showDetails = new Form_showDetails((int)dataGridView1.Rows[e.RowIndex].Cells[0].Value);
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

                foreach (DataGridViewRow dataGridViewRow in dataGridView1.Rows)
                {
                    if((int)dataGridViewRow.Cells[0].Value != int.Parse(searchOrderForm.infomation))
                    dataGridViewRow.Visible = false;
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

                using (var db = new OrderModel())
                {
                    var orders = db.Orders.Where(p => p.guest.name == searchOrderForm.infomation);
                    foreach (DataGridViewRow dataGridViewRow in dataGridView1.Rows) // 对每一行判断
                    {
                        dataGridViewRow.Visible = false;
                        foreach (Order order in orders)//对每一个符合要求的订单号判断
                        {
                            if ((int)dataGridViewRow.Cells[0].Value == order.orderNumber)
                            {
                                dataGridViewRow.Visible = true;
                                break;
                            }
                        }
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

                using (var db = new OrderModel())
                {
                    double price = double.Parse(searchOrderForm.infomation);
                    var orders = db.Orders.Where(p => p.orderPrice == price);
                    foreach (DataGridViewRow dataGridViewRow in dataGridView1.Rows) // 对每一行判断
                    {
                        dataGridViewRow.Visible = false;
                        foreach (Order order in orders)//对每一个符合要求的订单号判断
                        {
                            if ((int)dataGridViewRow.Cells[0].Value == order.orderNumber)
                            {
                                dataGridViewRow.Visible = true;
                                break;
                            }
                        }
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

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            dataGridView1.Refresh();
        }
    }
}
