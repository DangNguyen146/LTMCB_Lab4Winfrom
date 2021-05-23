using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4_WebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnViewHTML_Click(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Navigate(txtUrl.Text);
        }

        private void btnDowload_Click(object sender, EventArgs e)
        {
            DowloadSource dowloadSource = new DowloadSource(txtUrl.Text);
            dowloadSource.Show();
        }

        private void btnBiewSource_Click(object sender, EventArgs e)
        {
            ViewSource viewSource = new ViewSource(txtUrl.Text);
            viewSource.Show();
        }
    }
}
