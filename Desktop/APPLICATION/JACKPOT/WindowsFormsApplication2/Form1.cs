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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            timer1.Interval = 500;
            timer1.Enabled = true;
            pictureBox1.Image = imageList1.Images[0];
            pictureBox2.Image = imageList1.Images[0];
            pictureBox3.Image = imageList1.Images[0];
        }
        bool a = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (a == true)
            {
                label2.Visible = false;
                a = false;
            }
            else
            {
                label2.Visible = true;
                a = true;
            }
        }
        int a1, a2, a3;
        Random r = new Random();
        public void ret()
        {
            a1 = r.Next(0, 4);
            pictureBox1.Image = imageList1.Images[a1];            
        }
        public void ret1()
        {
            a2 = r.Next(0, 4);
            pictureBox2.Image = imageList2.Images[a2];
        }
        public void ret2()
        {
            a3 = r.Next(0, 4);
            pictureBox3.Image = imageList3.Images[a3];
            if ((a1 == a2) && (a2 == a3))
            {
                label1.Text = "Jackpot";
                timer2.Interval = 500;
                timer2.Start();
            }
            else if ((a1 == a2) || (a2 == a3) || (a3 == a1))
            {
                label1.Text = "Good Try";
                timer2.Interval = 500;
                timer2.Start();
            }
            else
            {
                label1.Text = "Bad Luck";
                timer2.Interval = 500;
                timer2.Start();
            }
            button1.Enabled = false;
            timer1.Enabled = true;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            timer2.Enabled = false;
            button1.Enabled = true;
            label2.Visible = false;
            timer1.Enabled = false;
            timer1.Stop();
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer3.Interval =10;
            timer3.Start();    
        }
        bool b = true;
        private void timer2_Tick(object sender, EventArgs e)
        {
             if (b == true)
            {
                label1.Visible = false;
                b = false;
            }
            else
            {
                label1.Visible = true;
                b = true;
            }
        }
        int q = 60;

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Interval += 5;
            Random r = new Random();
            int a;                
            q--;
            if (q >= 40)
            {
                a = r.Next(4);
                pictureBox1.Image = imageList1.Images[a];            
                ret();
            }            
            if (q >= 20)
            {
                a = r.Next(4);
                pictureBox2.Image = imageList2.Images[a];
                ret1();
            }
            
            if (q >= 0)
            {
                a = r.Next(4);
                pictureBox3.Image = imageList3.Images[a];
                
            }
            if (q == 0)
            {
                q = 60;
                timer3.Stop();
                ret2();
            }
        }
    }
}
