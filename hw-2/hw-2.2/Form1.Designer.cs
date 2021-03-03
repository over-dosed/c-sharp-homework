
namespace hw_2._2
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
            this.arrayInputText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maxNumberLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.minNumberLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.arrNumberLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sumNumberLabel = new System.Windows.Forms.Label();
            this.calculateArrayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // arrayInputText
            // 
            this.arrayInputText.Location = new System.Drawing.Point(339, 111);
            this.arrayInputText.Name = "arrayInputText";
            this.arrayInputText.Size = new System.Drawing.Size(335, 25);
            this.arrayInputText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "please input an array:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "max number of the array:";
            // 
            // maxNumberLabel
            // 
            this.maxNumberLabel.AutoSize = true;
            this.maxNumberLabel.Location = new System.Drawing.Point(339, 156);
            this.maxNumberLabel.Name = "maxNumberLabel";
            this.maxNumberLabel.Size = new System.Drawing.Size(0, 15);
            this.maxNumberLabel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "min number of the array:\r\n";
            // 
            // minNumberLabel
            // 
            this.minNumberLabel.AutoSize = true;
            this.minNumberLabel.Location = new System.Drawing.Point(339, 194);
            this.minNumberLabel.Name = "minNumberLabel";
            this.minNumberLabel.Size = new System.Drawing.Size(0, 15);
            this.minNumberLabel.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "arr number of the array:\r\n";
            // 
            // arrNumberLabel
            // 
            this.arrNumberLabel.AutoSize = true;
            this.arrNumberLabel.Location = new System.Drawing.Point(339, 233);
            this.arrNumberLabel.Name = "arrNumberLabel";
            this.arrNumberLabel.Size = new System.Drawing.Size(0, 15);
            this.arrNumberLabel.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "sum number of the array:\r\n";
            // 
            // sumNumberLabel
            // 
            this.sumNumberLabel.AutoSize = true;
            this.sumNumberLabel.Location = new System.Drawing.Point(339, 269);
            this.sumNumberLabel.Name = "sumNumberLabel";
            this.sumNumberLabel.Size = new System.Drawing.Size(0, 15);
            this.sumNumberLabel.TabIndex = 5;
            // 
            // calculateArrayButton
            // 
            this.calculateArrayButton.Location = new System.Drawing.Point(680, 111);
            this.calculateArrayButton.Name = "calculateArrayButton";
            this.calculateArrayButton.Size = new System.Drawing.Size(108, 26);
            this.calculateArrayButton.TabIndex = 6;
            this.calculateArrayButton.Text = "calculate";
            this.calculateArrayButton.UseVisualStyleBackColor = true;
            this.calculateArrayButton.Click += new System.EventHandler(this.calculateArrayButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calculateArrayButton);
            this.Controls.Add(this.sumNumberLabel);
            this.Controls.Add(this.arrNumberLabel);
            this.Controls.Add(this.minNumberLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maxNumberLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.arrayInputText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox arrayInputText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label maxNumberLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label minNumberLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label arrNumberLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label sumNumberLabel;
        private System.Windows.Forms.Button calculateArrayButton;
    }
}

