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

namespace Bai2_HTTPPost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPOST_Click(object sender, EventArgs e)
        {
            txtHTML.Text = getHTML(txtUrl.Text, txtContent.Text);
        }
        private string getHTML(string szURL, string content)
        {
            // Tạo request URL.
            WebRequest request = WebRequest.Create(szURL);
            // Đặt thuộc tính là POST
            request.Method = "POST";
            // Chuyển đổi content thành một mảng byte.
            byte[] byteArray = Encoding.UTF8.GetBytes(content);
            // Đặt thuộc tính ContentType của WebRequest.
            request.ContentType = "application/x-www-form-urlencoded";
            // Đặt thuộc tính ContentLength của WebRequest.
            request.ContentLength = byteArray.Length;
            // Nhan request yêu cầu.
            Stream dataStream = request.GetRequestStream();
            // Write the data to the request stream.
            dataStream.Write(byteArray, 0, byteArray.Length);
            // Close the Stream object.
            dataStream.Close();
            // Get the response.
            WebResponse response = request.GetResponse();
            string responseFromServer;
            using (dataStream = response.GetResponseStream())
            {
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                responseFromServer = reader.ReadToEnd();
            }
            // Đóng kết nối.
            response.Close();
            return responseFromServer;
        }
    }
}
