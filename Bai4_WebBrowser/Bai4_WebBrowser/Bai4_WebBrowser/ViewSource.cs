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
    public partial class ViewSource : Form
    {
        public ViewSource(string txtUrl)
        {
            InitializeComponent();


            //Khởi tạo web ảo để load đối tượng web
            HtmlWeb htmlWeb = new HtmlWeb();
            htmlWeb.UserAgent = "Mozilla/5.0 (Linux; {Android Version}; {Build Tag etc.}) AppleWebKit/{WebKit Rev} (KHTML, like Gecko) Chrome/{Chrome Rev} Mobile Safari/{WebKit Rev}";

            string url = txtUrl;
            try
            {
                HtmlAgilityPack.HtmlDocument _htmlDoc = htmlWeb.Load(url);
                txtHTML.Text = _htmlDoc.DocumentNode.InnerHtml;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
