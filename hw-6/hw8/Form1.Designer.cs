
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
            this.orderNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.choose = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.订单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.增加订单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改订单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改订单ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.订单号ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下单时间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.总价ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.订单地址ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.客户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_modify = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNumDataGridViewTextBoxColumn,
            this.orderTimeDataGridViewTextBoxColumn,
            this.orderPriceDataGridViewTextBoxColumn,
            this.orderAddressDataGridViewTextBoxColumn,
            this.choose});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 58);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(431, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(554, 393);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // orderNumDataGridViewTextBoxColumn
            // 
            this.orderNumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.orderNumDataGridViewTextBoxColumn.DataPropertyName = "orderNum";
            this.orderNumDataGridViewTextBoxColumn.HeaderText = "订单ID";
            this.orderNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderNumDataGridViewTextBoxColumn.Name = "orderNumDataGridViewTextBoxColumn";
            this.orderNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderTimeDataGridViewTextBoxColumn
            // 
            this.orderTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.orderTimeDataGridViewTextBoxColumn.DataPropertyName = "orderTime";
            this.orderTimeDataGridViewTextBoxColumn.HeaderText = "订单时间";
            this.orderTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderTimeDataGridViewTextBoxColumn.Name = "orderTimeDataGridViewTextBoxColumn";
            this.orderTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderPriceDataGridViewTextBoxColumn
            // 
            this.orderPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.orderPriceDataGridViewTextBoxColumn.DataPropertyName = "orderPrice";
            this.orderPriceDataGridViewTextBoxColumn.HeaderText = "订单总价";
            this.orderPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderPriceDataGridViewTextBoxColumn.Name = "orderPriceDataGridViewTextBoxColumn";
            this.orderPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderAddressDataGridViewTextBoxColumn
            // 
            this.orderAddressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.orderAddressDataGridViewTextBoxColumn.DataPropertyName = "orderAddress";
            this.orderAddressDataGridViewTextBoxColumn.HeaderText = "配送地址";
            this.orderAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderAddressDataGridViewTextBoxColumn.Name = "orderAddressDataGridViewTextBoxColumn";
            this.orderAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // choose
            // 
            this.choose.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.choose.FalseValue = "false";
            this.choose.HeaderText = "选择";
            this.choose.IndeterminateValue = "false";
            this.choose.MinimumWidth = 6;
            this.choose.Name = "choose";
            this.choose.ReadOnly = true;
            this.choose.TrueValue = "true";
            this.choose.Visible = false;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Order);
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
            this.menuStrip1.Size = new System.Drawing.Size(495, 28);
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
            this.修改订单ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.修改订单ToolStripMenuItem.Text = "删除订单";
            this.修改订单ToolStripMenuItem.Click += new System.EventHandler(this.删除订单ToolStripMenuItem_Click);
            // 
            // 修改订单ToolStripMenuItem1
            // 
            this.修改订单ToolStripMenuItem1.Name = "修改订单ToolStripMenuItem1";
            this.修改订单ToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.修改订单ToolStripMenuItem1.Text = "修改订单";
            this.修改订单ToolStripMenuItem1.Click += new System.EventHandler(this.修改订单ToolStripMenuItem1_Click);
            // 
            // 显示ToolStripMenuItem
            // 
            this.显示ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.订单号ToolStripMenuItem,
            this.下单时间ToolStripMenuItem,
            this.总价ToolStripMenuItem,
            this.订单地址ToolStripMenuItem,
            this.客户ToolStripMenuItem});
            this.显示ToolStripMenuItem.Name = "显示ToolStripMenuItem";
            this.显示ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.显示ToolStripMenuItem.Text = "显示";
            // 
            // 订单号ToolStripMenuItem
            // 
            this.订单号ToolStripMenuItem.Checked = true;
            this.订单号ToolStripMenuItem.CheckOnClick = true;
            this.订单号ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.订单号ToolStripMenuItem.Name = "订单号ToolStripMenuItem";
            this.订单号ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.订单号ToolStripMenuItem.Text = "订单ID";
            this.订单号ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.订单号ToolStripMenuItem_CheckedChanged);
            // 
            // 下单时间ToolStripMenuItem
            // 
            this.下单时间ToolStripMenuItem.Checked = true;
            this.下单时间ToolStripMenuItem.CheckOnClick = true;
            this.下单时间ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.下单时间ToolStripMenuItem.Name = "下单时间ToolStripMenuItem";
            this.下单时间ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.下单时间ToolStripMenuItem.Text = "订单时间";
            this.下单时间ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.下单时间ToolStripMenuItem_CheckedChanged);
            // 
            // 总价ToolStripMenuItem
            // 
            this.总价ToolStripMenuItem.Checked = true;
            this.总价ToolStripMenuItem.CheckOnClick = true;
            this.总价ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.总价ToolStripMenuItem.Name = "总价ToolStripMenuItem";
            this.总价ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.总价ToolStripMenuItem.Text = "订单总价";
            this.总价ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.总价ToolStripMenuItem_CheckedChanged);
            // 
            // 订单地址ToolStripMenuItem
            // 
            this.订单地址ToolStripMenuItem.Checked = true;
            this.订单地址ToolStripMenuItem.CheckOnClick = true;
            this.订单地址ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.订单地址ToolStripMenuItem.Name = "订单地址ToolStripMenuItem";
            this.订单地址ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.订单地址ToolStripMenuItem.Text = "配送地址";
            this.订单地址ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.订单地址ToolStripMenuItem_CheckedChanged);
            // 
            // 客户ToolStripMenuItem
            // 
            this.客户ToolStripMenuItem.CheckOnClick = true;
            this.客户ToolStripMenuItem.Name = "客户ToolStripMenuItem";
            this.客户ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.客户ToolStripMenuItem.Text = "客户姓名";
            this.客户ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.客户ToolStripMenuItem_CheckedChanged);
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导入文件ToolStripMenuItem,
            this.导出文件ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
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
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "默认",
            "按订单总价排序",
            "按订单ID排序"});
            this.comboBox1.Location = new System.Drawing.Point(0, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(94, 23);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.筛选ToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(495, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(59, 451);
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
            this.筛选ToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
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
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView3.DataMember = "guest";
            this.dataGridView3.DataSource = this.bindingSource1;
            this.dataGridView3.Location = new System.Drawing.Point(566, 58);
            this.dataGridView3.MinimumSize = new System.Drawing.Size(130, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 27;
            this.dataGridView3.Size = new System.Drawing.Size(136, 393);
            this.dataGridView3.TabIndex = 5;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "客户姓名";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // button_delete
            // 
            this.button_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_delete.Enabled = false;
            this.button_delete.Location = new System.Drawing.Point(422, 31);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(125, 23);
            this.button_delete.TabIndex = 6;
            this.button_delete.Text = "选中删除";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Visible = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_modify
            // 
            this.button_modify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_modify.Enabled = false;
            this.button_modify.Location = new System.Drawing.Point(282, 31);
            this.button_modify.Name = "button_modify";
            this.button_modify.Size = new System.Drawing.Size(129, 23);
            this.button_modify.TabIndex = 7;
            this.button_modify.Text = "选中修改";
            this.button_modify.UseVisualStyleBackColor = true;
            this.button_modify.Visible = false;
            this.button_modify.Click += new System.EventHandler(this.button_modify_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 451);
            this.Controls.Add(this.button_modify);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_modify;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn choose;
    }
}

