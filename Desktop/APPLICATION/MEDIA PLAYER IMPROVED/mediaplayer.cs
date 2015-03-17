using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        String[] files=new string[10], paths=new string[10];
        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfileDialog1 = new OpenFileDialog();
            openfileDialog1.Multiselect = true;

            if (openfileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.textBox1.Text = openfileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = textBox1.Text;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfileDialog1 = new OpenFileDialog();
            openfileDialog1.Multiselect = true;
            for (int i = 0; i < files.Length; i++)
                listBox1.Items.Remove(files[i]);
           if (openfileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
           {
               files=openfileDialog1.SafeFileNames;
               paths=openfileDialog1.FileNames;
               for (int i = 0; i < files.Length;i++ )
                   listBox1.Items.Add(files[i]);
           }
         }
        int i = 0;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = paths[listBox1.SelectedIndex];
            textBox1.Text = files[listBox1.SelectedIndex];
            ch = files[listBox1.SelectedIndex].ToCharArray();
            i = ch.Length;
            timer1.Interval = 100;
            timer1.Start();
        }

        private void Form1_AutoSizeChanged(object sender, EventArgs e)
        {
        }
        char[] ch;
        int d = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = files[listBox1.SelectedIndex].Substring(d, i-d);

            //for (int j = d; j < i; j++)
            //{
            //    textBox1.AppendText(ch[j].ToString());
            //}
            d++;

            if (d > i)
                d = 0;
            
        }
    }
}
