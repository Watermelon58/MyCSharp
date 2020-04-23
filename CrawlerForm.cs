using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework9
{
    public partial class CrawlerForm : Form
    {
        BindingSource resultBindingSource = new BindingSource();
        SimpleCrawler crawler = new SimpleCrawler();
        Thread thread = null;

        public CrawlerForm()
        {
            InitializeComponent();
            res.DataSource = resultBindingSource;
            crawler.Inform += Crawler_PageDownloaded;
        }

        private void Crawler_PageDownloaded(SimpleCrawler crawler, string url, string info)
        {
            var pageInfo = new { Index = resultBindingSource.Count + 1, URL = url, Status = info };
            Action action = () => { resultBindingSource.Add(pageInfo); };
            if (this.InvokeRequired)
            {
                this.Invoke(action);
            }
            else
            {
                action();
            }
        }
        private void btnCrawl_Click(object sender, EventArgs e)
        {
            resultBindingSource.Clear();
            new Thread(crawler.Start).Start();
            lblInfo.Text = "爬虫已经启动";
        }

    }
}
