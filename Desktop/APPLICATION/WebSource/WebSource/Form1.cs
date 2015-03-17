using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace WebSource
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (urlTextBox.Text == "http://")
            {
                MessageBox.Show(this, "Please Enter Full Website Address\n\nExample: http://www.google.co.in", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string url = urlTextBox.Text;
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                    StreamReader sr = new StreamReader(response.GetResponseStream());
                    richTextBox1.Text = sr.ReadToEnd();
                    sr.Close();
                }
                catch (Exception exp)
                {
                    MessageBox.Show(this, "Connection Not Available\nPlease Check Your Connection and Try Again\n\nOR\n\nWebsite Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            urlTextBox.Text = "http://";
            richTextBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Programming Done By: \nAvinash Kumar Sharma\n(a.k.a CodeGeek)\n\nEmail: avinashonline@yahoo.com", "About Developer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.ShowDialog();
            StreamWriter sw = new StreamWriter(sf.FileName, false);
            sw.WriteLine(richTextBox1.Text);
            sw.Close();
            MessageBox.Show(this, "Congratsss... File Saved", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
