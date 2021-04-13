﻿using System;
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
    public partial class Form_showDetails : Form
    {
        public Form_showDetails(BindingSource binding)
        {
            InitializeComponent();
            bindingSourceDetails = new BindingSource();
            bindingSourceDetails.DataSource = binding;
            bindingSourceDetails.DataMember = "orderDetails";
            dataGridView2.DataSource = bindingSourceDetails;
            dataGridView2.DataMember = "cargo";
            dataGridView1.DataSource = bindingSourceDetails;

            
            //数据绑定

            DataGridViewTextBoxColumn colCargoName = new DataGridViewTextBoxColumn();
            colCargoName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCargoName.Name = "cargoName";
            colCargoName.DataPropertyName = "name";
            colCargoName.Visible = true;
            colCargoName.Frozen = false;
            colCargoName.Resizable = DataGridViewTriState.False;
            colCargoName.HeaderText = "商品名称";
            this.dataGridView2.Columns.Add(colCargoName);

            DataGridViewTextBoxColumn colCargoPrice = new DataGridViewTextBoxColumn();
            colCargoPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCargoPrice.Name = "cargoPrice";
            colCargoPrice.DataPropertyName = "price";
            colCargoPrice.Visible = true;
            colCargoPrice.Frozen = false;
            colCargoPrice.Resizable = DataGridViewTriState.False;
            colCargoPrice.HeaderText = "商品单价";
            this.dataGridView2.Columns.Add(colCargoPrice);

            DataGridViewTextBoxColumn colDetailCount = new DataGridViewTextBoxColumn();
            colDetailCount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDetailCount.Name = "detailCount";
            colDetailCount.DataPropertyName = "count";
            colDetailCount.Visible = true;
            colDetailCount.Frozen = false;
            colDetailCount.Resizable = DataGridViewTriState.False;
            colDetailCount.HeaderText = "商品数量";
            this.dataGridView1.Columns.Add(colDetailCount);

            DataGridViewTextBoxColumn colDetailPrice = new DataGridViewTextBoxColumn();
            colDetailPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDetailPrice.Name = "detailPrice";
            colDetailPrice.DataPropertyName = "orderDetailsPrice";
            colDetailPrice.Visible = true;
            colDetailPrice.Frozen = false;
            colDetailPrice.Resizable = DataGridViewTriState.False;
            colDetailPrice.HeaderText = "商品总价";
            this.dataGridView1.Columns.Add(colDetailPrice);
        }
    }
}
