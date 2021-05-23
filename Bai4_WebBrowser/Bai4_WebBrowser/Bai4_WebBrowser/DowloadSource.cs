using Fizzler.Systems.HtmlAgilityPack;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4_WebBrowser
{
    public partial class DowloadSource : Form
    {
        public DowloadSource(string url)
        {
            InitializeComponent();

            WebClient client = new WebClient();
            string downloadString = client.DownloadString(url);
            string filePtach = @"F:\UIT_HK2\LapTrinhMangCanBan\ThucHanh\19521317-NguyenKhaiDang-lab4\Bai4_WebBrowser\web\index.html";
            FileStream fs = new FileStream(filePtach, FileMode.Create);
            StreamWriter fw = new StreamWriter(fs, Encoding.UTF8);
            fw.WriteLine(downloadString.Trim());
            fw.Flush();
            fw.Close();
            fs.Close();


            MessageBox.Show("Success");

            FileStream fsOpen = new FileStream(filePtach, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fsOpen);
            string content = sr.ReadToEnd();
            richTextBox1.Text = content;
            fsOpen.Close();
        }
    }
}
