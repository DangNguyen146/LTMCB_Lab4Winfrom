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
            string filePtachIMG = @"F:\UIT_HK2\LapTrinhMangCanBan\ThucHanh\19521317-NguyenKhaiDang-lab4\Bai4_WebBrowser\web\index.txt";
            FileStream fs = new FileStream(filePtach, FileMode.Create);
            StreamWriter fw = new StreamWriter(fs, Encoding.UTF8);
            fw.WriteLine(downloadString.Trim());
            fw.Flush();
            fw.Close();
            fs.Close();

            HtmlWeb htmlWeb = new HtmlWeb()
            {
                AutoDetectEncoding = false,
                OverrideEncoding = Encoding.UTF8  //Set UTF8 để hiển thị tiếng Việt
            };
            HtmlAgilityPack.HtmlDocument document = htmlWeb.Load(url);
            string img = "";
            for (int i = 1; i <= 12; i++)
                img += document.DocumentNode.SelectSingleNode("//div[@class='reading-detail box_doc']//div["+i+"]//img").Attributes["src"].Value + "\n";

            fs = new FileStream(filePtachIMG, FileMode.Create);
            fw = new StreamWriter(fs, Encoding.UTF8);
            fw.WriteLine(img.Trim());
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
