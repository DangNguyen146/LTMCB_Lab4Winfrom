using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3_DowloadHTML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dowHTML(txtUrl.Text, txtLocal.Text);
        }
        private void dowHTML(string szURL, string szURLlocal)
        {
            WebClient client = new WebClient();
            string downloadString = client.DownloadString(szURL);
            FileStream fs = new FileStream(szURLlocal, FileMode.Create);
            StreamWriter fw = new StreamWriter(fs, Encoding.UTF8);
            fw.WriteLine(downloadString.Trim());
            fw.Flush();
            fw.Close();
            fs.Close();

            MessageBox.Show("Success");

            FileStream fsOpen = new FileStream(szURLlocal, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fsOpen);
            string content = sr.ReadToEnd();
            txtHTML.Text = content;
            fsOpen.Close();
            
        }
    }
}
