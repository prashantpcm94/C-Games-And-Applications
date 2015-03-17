using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class MINDREADER : Form
    {
        public MINDREADER()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[6];
            button1.Visible = false;
            button2.Visible = false;
            button3.Text = "PLAY";
        }
        int i = 0, k = 5;
        int[] a = new int[6];
        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = "RESTART";
            button1.Visible = true;
            button2.Visible = true;
            i = 0;
            k = 5;
            pictureBox1.Image = imageList1.Images[i++];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            a[k--] = 1;
            if(i==6)
            {
                int j = 0;
                int x=32;
                for(int l=0;l<6;l++)
                {
                    j = j + a[l] * x;
                    x = x / 2;
                }
                pictureBox1.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
                button3.Text = "PLAY";
                MessageBox.Show("YOUR NUMBER IS " + j);
                pictureBox1.Visible = true;
                pictureBox1.Image = imageList1.Images[6];
                k = 5;                
            }
            if(i<6)
            pictureBox1.Image = imageList1.Images[i++];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a[k--] = 0;
           
            if (i == 6)
            {
                int j = 0;
                int x = 32;
                for (int l = 0; l < 6; l++)
                {
                    j = j + a[l] * x;
                    x = x / 2;
                }
                pictureBox1.Visible = false;
                pictureBox1.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
                button3.Text = "PLAY";
                MessageBox.Show("YOUR NUMBER IS " + j);
                pictureBox1.Visible = true;
                pictureBox1.Image = imageList1.Images[6];
                k = 5;             
            }
            if(i<6)
            pictureBox1.Image = imageList1.Images[i++];
        }
    }
}
