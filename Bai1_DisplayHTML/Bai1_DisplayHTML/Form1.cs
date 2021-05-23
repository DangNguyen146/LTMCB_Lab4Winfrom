using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1_DisplayHTML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtHTML.Text= getHTML(txtUrl.Text);
        }
        private string getHTML(string szURL)
        {
            // Tạo request URL.
            WebRequest request = WebRequest.Create(szURL);
            // Nhận phản hồi.
            WebResponse response = request.GetResponse();
            // Nhận luồn chứa nội dung trả về từ server.
            Stream dataStream = response.GetResponseStream();
            // Mỡ stream serder để dễ truy cập.
            StreamReader reader = new StreamReader(dataStream);
            // Đọc du liệu.
            string responseFromServer = reader.ReadToEnd();
            // Đóng kết nối.
            response.Close();
            return responseFromServer;
        }
    }
}
