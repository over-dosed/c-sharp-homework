
namespace hw8
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.订单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.增加订单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改订单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改订单ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.订单号ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.客户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.总价ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.订单详细ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下单时间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.订单地址ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.筛选ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按订单IDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按订单货物ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按客户名称ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按订单总价ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNumDataGridViewTextBoxColumn,
            this.guestDataGridViewTextBoxColumn,
            this.orderTimeDataGridViewTextBoxColumn,
            this.orderPriceDataGridViewTextBoxColumn,
            this.orderAddressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(900, 383);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.订单ToolStripMenuItem,
            this.显示ToolStripMenuItem,
            this.文件ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(900, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 订单ToolStripMenuItem
            // 
            this.订单ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.增加订单ToolStripMenuItem,
            this.修改订单ToolStripMenuItem,
            this.修改订单ToolStripMenuItem1});
            this.订单ToolStripMenuItem.Name = "订单ToolStripMenuItem";
            this.订单ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.订单ToolStripMenuItem.Text = "订单";
            // 
            // 增加订单ToolStripMenuItem
            // 
            this.增加订单ToolStripMenuItem.AutoSize = false;
            this.增加订单ToolStripMenuItem.Name = "增加订单ToolStripMenuItem";
            this.增加订单ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.增加订单ToolStripMenuItem.Text = "增加订单";
            this.增加订单ToolStripMenuItem.Click += new System.EventHandler(this.增加订单ToolStripMenuItem_Click);
            // 
            // 修改订单ToolStripMenuItem
            // 
            this.修改订单ToolStripMenuItem.Name = "修改订单ToolStripMenuItem";
            this.修改订单ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.修改订单ToolStripMenuItem.Text = "删除订单";
            // 
            // 修改订单ToolStripMenuItem1
            // 
            this.修改订单ToolStripMenuItem1.Name = "修改订单ToolStripMenuItem1";
            this.修改订单ToolStripMenuItem1.Size = new System.Drawing.Size(152, 26);
            this.修改订单ToolStripMenuItem1.Text = "修改订单";
            // 
            // 显示ToolStripMenuItem
            // 
            this.显示ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.订单号ToolStripMenuItem,
            this.客户ToolStripMenuItem,
            this.总价ToolStripMenuItem,
            this.订单详细ToolStripMenuItem,
            this.下单时间ToolStripMenuItem,
            this.订单地址ToolStripMenuItem});
            this.显示ToolStripMenuItem.Name = "显示ToolStripMenuItem";
            this.显示ToolStripMenuItem.Size = new System.Drawing.Size(53, 26);
            this.显示ToolStripMenuItem.Text = "显示";
            // 
            // 订单号ToolStripMenuItem
            // 
            this.订单号ToolStripMenuItem.Checked = true;
            this.订单号ToolStripMenuItem.CheckOnClick = true;
            this.订单号ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.订单号ToolStripMenuItem.Name = "订单号ToolStripMenuItem";
            this.订单号ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.订单号ToolStripMenuItem.Text = "订单号";
            // 
            // 客户ToolStripMenuItem
            // 
            this.客户ToolStripMenuItem.Checked = true;
            this.客户ToolStripMenuItem.CheckOnClick = true;
            this.客户ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.客户ToolStripMenuItem.Name = "客户ToolStripMenuItem";
            this.客户ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.客户ToolStripMenuItem.Text = "客户姓名";
            // 
            // 总价ToolStripMenuItem
            // 
            this.总价ToolStripMenuItem.Checked = true;
            this.总价ToolStripMenuItem.CheckOnClick = true;
            this.总价ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.总价ToolStripMenuItem.Name = "总价ToolStripMenuItem";
            this.总价ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.总价ToolStripMenuItem.Text = "总价";
            // 
            // 订单详细ToolStripMenuItem
            // 
            this.订单详细ToolStripMenuItem.CheckOnClick = true;
            this.订单详细ToolStripMenuItem.Name = "订单详细ToolStripMenuItem";
            this.订单详细ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.订单详细ToolStripMenuItem.Text = "订单详细";
            // 
            // 下单时间ToolStripMenuItem
            // 
            this.下单时间ToolStripMenuItem.CheckOnClick = true;
            this.下单时间ToolStripMenuItem.Name = "下单时间ToolStripMenuItem";
            this.下单时间ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.下单时间ToolStripMenuItem.Text = "下单时间";
            // 
            // 订单地址ToolStripMenuItem
            // 
            this.订单地址ToolStripMenuItem.CheckOnClick = true;
            this.订单地址ToolStripMenuItem.Name = "订单地址ToolStripMenuItem";
            this.订单地址ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.订单地址ToolStripMenuItem.Text = "订单地址";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导入文件ToolStripMenuItem,
            this.导出文件ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(53, 26);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 导入文件ToolStripMenuItem
            // 
            this.导入文件ToolStripMenuItem.Name = "导入文件ToolStripMenuItem";
            this.导入文件ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.导入文件ToolStripMenuItem.Text = "导入文件";
            // 
            // 导出文件ToolStripMenuItem
            // 
            this.导出文件ToolStripMenuItem.Name = "导出文件ToolStripMenuItem";
            this.导出文件ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.导出文件ToolStripMenuItem.Text = "导出文件";
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "默认",
            "按订单总价排序",
            "按订单ID排序"});
            this.comboBox1.Location = new System.Drawing.Point(0, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 23);
            this.comboBox1.TabIndex = 2;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.筛选ToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(839, 28);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(61, 28);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // 筛选ToolStripMenuItem
            // 
            this.筛选ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.按订单IDToolStripMenuItem,
            this.按订单货物ToolStripMenuItem,
            this.按客户名称ToolStripMenuItem,
            this.按订单总价ToolStripMenuItem,
            this.重置ToolStripMenuItem});
            this.筛选ToolStripMenuItem.Name = "筛选ToolStripMenuItem";
            this.筛选ToolStripMenuItem.Size = new System.Drawing.Size(53, 26);
            this.筛选ToolStripMenuItem.Text = "筛选";
            // 
            // 按订单IDToolStripMenuItem
            // 
            this.按订单IDToolStripMenuItem.Name = "按订单IDToolStripMenuItem";
            this.按订单IDToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.按订单IDToolStripMenuItem.Text = "按订单ID";
            // 
            // 按订单货物ToolStripMenuItem
            // 
            this.按订单货物ToolStripMenuItem.Name = "按订单货物ToolStripMenuItem";
            this.按订单货物ToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.按订单货物ToolStripMenuItem.Text = "按订单货物";
            // 
            // 按客户名称ToolStripMenuItem
            // 
            this.按客户名称ToolStripMenuItem.Name = "按客户名称ToolStripMenuItem";
            this.按客户名称ToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.按客户名称ToolStripMenuItem.Text = "按客户姓名";
            // 
            // 按订单总价ToolStripMenuItem
            // 
            this.按订单总价ToolStripMenuItem.Name = "按订单总价ToolStripMenuItem";
            this.按订单总价ToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.按订单总价ToolStripMenuItem.Text = "按订单总价";
            // 
            // 重置ToolStripMenuItem
            // 
            this.重置ToolStripMenuItem.Name = "重置ToolStripMenuItem";
            this.重置ToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.重置ToolStripMenuItem.Text = "重置";
            // 
            // orderNumDataGridViewTextBoxColumn
            // 
            this.orderNumDataGridViewTextBoxColumn.DataPropertyName = "orderNum";
            this.orderNumDataGridViewTextBoxColumn.HeaderText = "订单ID";
            this.orderNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderNumDataGridViewTextBoxColumn.Name = "orderNumDataGridViewTextBoxColumn";
            this.orderNumDataGridViewTextBoxColumn.Width = 125;
            // 
            // guestDataGridViewTextBoxColumn
            // 
            this.guestDataGridViewTextBoxColumn.DataPropertyName = "guest";
            this.guestDataGridViewTextBoxColumn.HeaderText = "客户姓名";
            this.guestDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.guestDataGridViewTextBoxColumn.Name = "guestDataGridViewTextBoxColumn";
            this.guestDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderTimeDataGridViewTextBoxColumn
            // 
            this.orderTimeDataGridViewTextBoxColumn.DataPropertyName = "orderTime";
            this.orderTimeDataGridViewTextBoxColumn.HeaderText = "订单时间";
            this.orderTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderTimeDataGridViewTextBoxColumn.Name = "orderTimeDataGridViewTextBoxColumn";
            this.orderTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderPriceDataGridViewTextBoxColumn
            // 
            this.orderPriceDataGridViewTextBoxColumn.DataPropertyName = "orderPrice";
            this.orderPriceDataGridViewTextBoxColumn.HeaderText = "订单总价";
            this.orderPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderPriceDataGridViewTextBoxColumn.Name = "orderPriceDataGridViewTextBoxColumn";
            this.orderPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderAddressDataGridViewTextBoxColumn
            // 
            this.orderAddressDataGridViewTextBoxColumn.DataPropertyName = "orderAddress";
            this.orderAddressDataGridViewTextBoxColumn.HeaderText = "配送地址";
            this.orderAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderAddressDataGridViewTextBoxColumn.Name = "orderAddressDataGridViewTextBoxColumn";
            this.orderAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Order);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 445);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 订单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 增加订单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改订单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改订单ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 显示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 订单号ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 客户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 总价ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 订单详细ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下单时间ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 订单地址ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出文件ToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 筛选ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按订单IDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按订单货物ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按客户名称ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按订单总价ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重置ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderAddressDataGridViewTextBoxColumn;
    }
}

