using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Collections;

namespace hw9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStartCrawl_Click(object sender, EventArgs e)
        {
            if(textboxStartUrl.Text == null || textboxStartUrl.Text == "")
            {
                MessageBox.Show("input valid URL");
            }

            Crawler mycrawler = new Crawler();

            string startUrl = textboxStartUrl.Text;
            string headUrl = startUrl.Substring(0, startUrl.IndexOf('/', 8));
            mycrawler.urls.Add(startUrl, false);
            mycrawler.crawl(richTextBox1,headUrl);
        }
    }

    public class Crawler //爬虫类
    {
        public Hashtable urls { set; get; }  //urls 赋值为新哈希表类型
        
        private int count = 0;
        
        public Crawler()
        {
            urls = new Hashtable();
        }

        public void crawl(RichTextBox rtb,string headUrl)//爬行
        {
            rtb.Text += "\n开始爬行了";
            while (true)
            {
                string current = null;
                foreach(string url in urls.Keys) // 找到一个还没下载过的链接
                {
                    if ((bool)urls[url]) continue; //已经下载过的，不再下载
                    current = url;
                }
                if (current == null || count > 100) break; //如果找不到新链接或者数目大于10，

                rtb.Text += "\n爬行" + current + "页面！"; //输出现在爬行状态

                string html = Download(current,rtb); //调用下载函数，下载当前界面

                urls[current] = true; //现在的页面已爬行，置为true
                count++; //爬行数目自增

                Parse(html,headUrl); //解析当前页面
            }
            rtb.Text += "\n爬行结束";
        }

        public string Download(string url,RichTextBox rtb) //根据URL下载页面，并返回为string类型
        {
            try
            {
                WebClient webClient = new WebClient(); //新建web代理对象
                webClient.Encoding = Encoding.UTF8; //设置上载，下载字符串格式为UTF8
                string html = webClient.DownloadString(url);//从url上下载字符

                string fileName = count.ToString();//计数
                File.WriteAllText(fileName, html, Encoding.UTF8); //将html字符串内容写入文件
                return html;
            }

            catch(Exception ex)
            {
                rtb.Text += "\n" + ex.Message;
                return "";
            }
        }

        public void Parse(string html,string headUrl)
        {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+(html|aspx|jsp)[""']";
            
            MatchCollection matches = new Regex(strRef).Matches(html);

            foreach (Match match in matches)
            {
                //if(match.Value.IndexOf())
                strRef = match.Value.Substring(match.Value.IndexOf("=") + 1).Trim('"','\"' ,'#','>' );
                if (strRef.Length == 0) continue;
                if(strRef.Substring(0,2)== "//")
                {
                    strRef = "https:" + strRef;
                }
                else if(strRef.Substring(0,1) == "/")
                {
                    strRef = headUrl + strRef;
                }
                if (urls[strRef] == null) urls[strRef] = false;
            }
        }
    }
}
