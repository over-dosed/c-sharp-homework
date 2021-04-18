
namespace hw9
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonStartCrawl = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxStartUrl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(852, 287);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // buttonStartCrawl
            // 
            this.buttonStartCrawl.Location = new System.Drawing.Point(336, 340);
            this.buttonStartCrawl.Name = "buttonStartCrawl";
            this.buttonStartCrawl.Size = new System.Drawing.Size(201, 69);
            this.buttonStartCrawl.TabIndex = 1;
            this.buttonStartCrawl.Text = "start crawl";
            this.buttonStartCrawl.UseVisualStyleBackColor = true;
            this.buttonStartCrawl.Click += new System.EventHandler(this.buttonStartCrawl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start URL:\r\n";
            // 
            // textboxStartUrl
            // 
            this.textboxStartUrl.Location = new System.Drawing.Point(120, 306);
            this.textboxStartUrl.Name = "textboxStartUrl";
            this.textboxStartUrl.Size = new System.Drawing.Size(732, 25);
            this.textboxStartUrl.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 421);
            this.Controls.Add(this.textboxStartUrl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStartCrawl);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonStartCrawl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxStartUrl;
    }
}

