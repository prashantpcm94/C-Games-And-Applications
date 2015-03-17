using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[9];
            pictureBox2.Image = imageList1.Images[9];
            pictureBox3.Image = imageList1.Images[9];
            pictureBox4.Image = imageList1.Images[9];
            pictureBox5.Image = imageList1.Images[9];
            pictureBox6.Image = imageList1.Images[9];
            pictureBox7.Image = imageList1.Images[9];
            pictureBox8.Image = imageList1.Images[9];
            timer2.Interval = 1500;
            timer3.Interval = 1000;
            timer4.Interval = 1000;
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;
            pictureBox5.Enabled = false;
            pictureBox6.Enabled = false;
            pictureBox7.Enabled = false;
            pictureBox8.Enabled = false;
        }
        public void ret()
        {
            pictureBox1.Image = imageList1.Images[9];
            pictureBox2.Image = imageList1.Images[9];
            pictureBox3.Image = imageList1.Images[9];
            pictureBox4.Image = imageList1.Images[9];
            pictureBox5.Image = imageList1.Images[9];
            pictureBox6.Image = imageList1.Images[9];
            pictureBox7.Image = imageList1.Images[9];
            pictureBox8.Image = imageList1.Images[9];
            timer2.Interval = 1500;
            timer3.Interval = 1000;
            timer4.Interval = 1000;
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;
            pictureBox5.Enabled = false;
            pictureBox6.Enabled = false;
            pictureBox7.Enabled = false;
            pictureBox8.Enabled = false;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible  = true;
            pictureBox7.Visible  = true;
            pictureBox8.Visible  = true;
        }
        Random r = new Random();
        int a, b, c, d, t = 0, h = 0, i = 0, g = 0, k = 0;
        int l, x, y, z,x1,y1,z1;
        int[] j = new int[8];
        private void button1_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            ret();
            k = 0;
            timer2.Interval = 1500;
            timer3.Interval = 1000;
            timer4.Interval = 1000;
            timer5.Stop();
            timer4.Stop();
            a = r.Next(78);
            b = r.Next(78);
            c = r.Next(78);
            d = r.Next(78);
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox8.Enabled = true;
            l = r.Next(2,9);
         l1:   x = r.Next(2,9);
            if (x == l)
                goto l1;
         l2:   y = r.Next(2,9);
            if ((y == x) || (y == l))
                goto l2;
         l3:   z = r.Next(2,9);
            if ((y == z) || (z == x) || (z == l))
                goto l3;
         l4: x1 = r.Next(2, 9);
         if ((y == x1) || (z == x1) || (x1 == l)||(x1==x))
                goto l4;
         l5: y1 = r.Next(2, 9);
         if ((y == y1) || (z == y1) || (y1 == l) || (y1 == x)||(y1==x1))
                goto l5;
         l6: z1 = r.Next(2, 9);
         if ((y == z1) || (z == z1) || (z1 == l) || (z1 == x) || (z1 == x1)||(z1==y1))
                goto l6; 

            pictureBox1.Image = imageList1.Images[a];
            switch (l)
            {
                case 2:
                    pictureBox2.Image = imageList1.Images[a];
                    l = 2;
                    break;
                case 3:
                    pictureBox3.Image = imageList1.Images[a];
                    l = 3;
                    break;
                case 4:
                    pictureBox4.Image = imageList1.Images[a];
                    l = 4;
                    break;
                case 5:
                    pictureBox5.Image = imageList1.Images[a];
                    l = 5;
                    break;
                case 6:
                    pictureBox6.Image = imageList1.Images[a];
                    l = 6;
                    break;
                case 7:
                    pictureBox7.Image = imageList1.Images[a];
                    l = 7;
                    break;
                case 8:
                    pictureBox8.Image = imageList1.Images[a];
                    l = 8;
                    break;
                default:
                    break;
            }
            switch (x)
            {
                case 2:
                    pictureBox2.Image = imageList1.Images[b];
                    break;
                case 3:
                    pictureBox3.Image = imageList1.Images[b];
                    break;
                case 4:
                    pictureBox4.Image = imageList1.Images[b];
                    break;
                case 5:
                    pictureBox5.Image = imageList1.Images[b];
                    break;
                case 6:
                    pictureBox6.Image = imageList1.Images[b];
                    break;
                case 7:
                    pictureBox7.Image = imageList1.Images[b];
                    break;
                case 8:
                    pictureBox8.Image = imageList1.Images[b];
                    break;
                default:
                    break;
            }
            switch (x1)
            {
                case 2:
                    pictureBox2.Image = imageList1.Images[b];
                    break;
                case 3:
                    pictureBox3.Image = imageList1.Images[b];
                    break;
                case 4:
                    pictureBox4.Image = imageList1.Images[b];
                    break;
                case 5:
                    pictureBox5.Image = imageList1.Images[b];
                    break;
                case 6:
                    pictureBox6.Image = imageList1.Images[b];
                    break;
                case 7:
                    pictureBox7.Image = imageList1.Images[b];
                    break;
                case 8:
                    pictureBox8.Image = imageList1.Images[b];
                    break;
                default:
                    break;
            }
            switch (y)
            {
                case 2:
                    pictureBox2.Image = imageList1.Images[c];
                    break;
                case 3:
                    pictureBox3.Image = imageList1.Images[c];
                    break;
                case 4:
                    pictureBox4.Image = imageList1.Images[c];
                    break;
                case 5:
                    pictureBox5.Image = imageList1.Images[c];
                    break;
                case 6:
                    pictureBox6.Image = imageList1.Images[c];
                    break;
                case 7:
                    pictureBox7.Image = imageList1.Images[c];
                    break;
                case 8:
                    pictureBox8.Image = imageList1.Images[c];
                    break;
                default:
                    break;
            }
            switch (y1)
            {
                case 2:
                    pictureBox2.Image = imageList1.Images[c];
                    break;
                case 3:
                    pictureBox3.Image = imageList1.Images[c];
                    break;
                case 4:
                    pictureBox4.Image = imageList1.Images[c];
                    break;
                case 5:
                    pictureBox5.Image = imageList1.Images[c];
                    break;
                case 6:
                    pictureBox6.Image = imageList1.Images[c];
                    break;
                case 7:
                    pictureBox7.Image = imageList1.Images[c];
                    break;
                case 8:
                    pictureBox8.Image = imageList1.Images[c];
                    break;
                default:
                    break;
            }
            switch (z)
            {
                case 2:
                    pictureBox2.Image = imageList1.Images[d];
                    break;
                case 3:
                    pictureBox3.Image = imageList1.Images[d];
                    break;
                case 4:
                    pictureBox4.Image = imageList1.Images[d];
                    break;
                case 5:
                    pictureBox5.Image = imageList1.Images[d];
                    break;
                case 6:
                    pictureBox6.Image = imageList1.Images[d];
                    break;
                case 7:
                    pictureBox7.Image = imageList1.Images[d];
                    break;
                case 8:
                    pictureBox8.Image = imageList1.Images[d];
                    break;
                default:
                    break;
            }
            switch (z1)
            {
                case 2:
                    pictureBox2.Image = imageList1.Images[d];
                    break;
                case 3:
                    pictureBox3.Image = imageList1.Images[d];
                    break;
                case 4:
                    pictureBox4.Image = imageList1.Images[d];
                    break;
                case 5:
                    pictureBox5.Image = imageList1.Images[d];
                    break;
                case 6:
                    pictureBox6.Image = imageList1.Images[d];
                    break;
                case 7:
                    pictureBox7.Image = imageList1.Images[d];
                    break;
                case 8:
                    pictureBox8.Image = imageList1.Images[d];
                    break;
                default:
                    break;
            }  
            timer1.Interval = 2000;
            timer1.Start();
            button1.Enabled = false;
            timer4.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[a];
            pictureBox1.Enabled = false;
            t++;
            if (t == 2)
            {
                t = 0;
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
                pictureBox5.Enabled = false;
                pictureBox6.Enabled = false;
                pictureBox7.Enabled = false;
                pictureBox8.Enabled = false;
                if (h == a)
                {
                    g = 1;
                    timer3.Start();                    
                }
                timer2.Start(); 
            }
            if (t == 1)
            {
                h = a;
                i = 1;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int p = 0;
            if (l == 2)
            {
                pictureBox2.Image = imageList1.Images[a];
                p = a;
            }
            if (x == 2)
            {
                pictureBox2.Image = imageList1.Images[b];
                p = b;
            }
            if (x1 == 2)
            {
                pictureBox2.Image = imageList1.Images[b];
                p = b;
            }
            if (y == 2)
            {
                pictureBox2.Image = imageList1.Images[c];
                p = c;
            }
            if (y1 == 2)
            {
                pictureBox2.Image = imageList1.Images[c];
                p = c;
            }
            if (z == 2)
            {
                pictureBox2.Image = imageList1.Images[d];
                p = d;
            }
            if (z1 == 2)
            {
                pictureBox2.Image = imageList1.Images[d];
                p = d;
            }
            
            pictureBox2.Enabled = false;
            t++;
            if (t == 2)
            {
                t = 0;
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
                pictureBox5.Enabled = false;
                pictureBox6.Enabled = false;
                pictureBox7.Enabled = false;
                pictureBox8.Enabled = false;
                if (h == p)
                {
                    g = 2;
                    timer3.Start();
                }
                timer2.Start(); 
            }
            if (t == 1)
            {
                h = p;
                i = 2;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            int p = 0;
            if (l == 3)
            {
                pictureBox3.Image = imageList1.Images[a];
                p = a;
            }
            if (x == 3)
            {
                pictureBox3.Image = imageList1.Images[b];
                p = b;
            }
            if (x1 == 3)
            {
                pictureBox3.Image = imageList1.Images[b];
                p = b;
            }
            if (y == 3)
            {
                pictureBox3.Image = imageList1.Images[c];
                p = c;
            }
            if (y1 == 3)
            {
                pictureBox3.Image = imageList1.Images[c];
                p = c;
            }
            if (z == 3)
            {
                pictureBox3.Image = imageList1.Images[d];
                p = d;
            }
            if (z1 == 3)
            {
                pictureBox3.Image = imageList1.Images[d];
                p = d;
            }
            pictureBox3.Enabled = false;
            t++;
            if (t == 2)
            {
                t = 0;
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
                pictureBox5.Enabled = false;
                pictureBox6.Enabled = false;
                pictureBox7.Enabled = false;
                pictureBox8.Enabled = false;
                if (h == p)
                {
                    g = 3;
                    timer3.Start();
                }
                timer2.Start(); 
            }
            if (t == 1)
            {
                h = p;
                i = 3;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            int p = 0;
            if (l == 4)
            {
                pictureBox4.Image = imageList1.Images[a];
                p = a;
            }
            if (x == 4)
            {
                pictureBox4.Image = imageList1.Images[b];
                p = b;
            }
            if (x1 == 4)
            {
                pictureBox4.Image = imageList1.Images[b];
                p = b;
            }
            if (y == 4)
            {
                pictureBox4.Image = imageList1.Images[c];
                p = c;
            }
            if (y1 == 4)
            {
                pictureBox4.Image = imageList1.Images[c];
                p = c;
            }
            if (z == 4)
            {
                pictureBox4.Image = imageList1.Images[d];
                p = d;
            }
            if (z1 == 4)
            {
                pictureBox4.Image = imageList1.Images[d];
                p = d;
            }
            pictureBox4.Enabled = false;
            t++;
            if (t == 2)
            {
                t = 0;
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
                pictureBox5.Enabled = false;
                pictureBox6.Enabled = false;
                pictureBox7.Enabled = false;
                pictureBox8.Enabled = false;
                if (h == p)
                {
                    g = 4;
                    timer3.Start();
                }
                timer2.Start(); 
            }
            if (t == 1)
            {
                h = p;
                i = 4;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            int p = 0;
            if (l == 5)
            {
                pictureBox5.Image = imageList1.Images[a];
                p = a;
            }
            if (x == 5)
            {
                pictureBox5.Image = imageList1.Images[b];
                p = b;
            }
            if (x1 == 5)
            {
                pictureBox5.Image = imageList1.Images[b];
                p = b;
            }
            if (y == 5)
            {
                pictureBox5.Image = imageList1.Images[c];
                p = c;
            }
            if (y1 == 5)
            {
                pictureBox5.Image = imageList1.Images[c];
                p = c;
            }
            if (z == 5)
            {
                pictureBox5.Image = imageList1.Images[d];
                p = d;
            }
            if (z1 == 5)
            {
                pictureBox5.Image = imageList1.Images[d];
                p = d;
            }
            pictureBox5.Enabled = false;
            t++;
            if (t == 2)
            {
                t = 0;
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
                pictureBox5.Enabled = false;
                pictureBox6.Enabled = false;
                pictureBox7.Enabled = false;
                pictureBox8.Enabled = false;
                if (h == p)
                {
                    g = 5;
                    timer3.Start();
                }
                timer2.Start(); 
            }
            if (t == 1)
            {
                h = p;
                i = 5;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            int p = 0;
            if (l == 6)
            {
                pictureBox6.Image = imageList1.Images[a];
                p = a;
            }
            if (x == 6)
            {
                pictureBox6.Image = imageList1.Images[b];
                p = b;
            }
            if (x1 == 6)
            {
                pictureBox6.Image = imageList1.Images[b];
                p = b;
            }
            if (y == 6)
            {
                pictureBox6.Image = imageList1.Images[c];
                p = c;
            }
            if (y1 == 6)
            {
                pictureBox6.Image = imageList1.Images[c];
                p = c;
            }
            if (z == 6)
            {
                pictureBox6.Image = imageList1.Images[d];
                p = d;
            }
            if (z1 == 6)
            {
                pictureBox6.Image = imageList1.Images[d];
                p = d;
            }
            pictureBox6.Enabled = false;
            t++;
            if (t == 2)
            {
                t = 0;
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
                pictureBox5.Enabled = false;
                pictureBox6.Enabled = false;
                pictureBox7.Enabled = false;
                pictureBox8.Enabled = false;
                if (h == p)
                {
                    g = 6;
                    timer3.Start();
                }
                timer2.Start(); 
            }
            if (t == 1)
            {
                h = p;
                i = 6;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            int p=0;
            if (l == 7)
            {
                pictureBox7.Image = imageList1.Images[a];
                p = a;
            }
            if (x == 7)
            {
                pictureBox7.Image = imageList1.Images[b];
                p = b;
            }
            if (x1 == 7)
            {
                pictureBox7.Image = imageList1.Images[b];
                p = b;
            }
            if (y == 7)
            {
                pictureBox7.Image = imageList1.Images[c];
                p = c;
            }
            if (y1 == 7)
            {
                pictureBox7.Image = imageList1.Images[c];
                p = c;
            }
            if (z == 7)
            {
                pictureBox7.Image = imageList1.Images[d];
                p = d;
            }
            if (z1 == 7)
            {
                pictureBox7.Image = imageList1.Images[d];
                p = d;
            }
            pictureBox7.Enabled = false;
            t++;
            if (t == 2)
            {
                t = 0;
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
                pictureBox5.Enabled = false;
                pictureBox6.Enabled = false;
                pictureBox7.Enabled = false;
                pictureBox8.Enabled = false;
                if (h == p)
                {
                    g = 7;
                    timer3.Start();
                }
                timer2.Start(); 
            }
            if (t == 1)
            {
                h = p;
                i = 7;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            int p=0;
            if (l == 8)
            {
                pictureBox8.Image = imageList1.Images[a];
                p = a;
            }
            if (x == 8)
            {
                pictureBox8.Image = imageList1.Images[b];
                p = b;
            }
            if (x1 == 8)
            {
                pictureBox8.Image = imageList1.Images[b];
                p = b;
            }
            if (y == 8)
            {
                pictureBox8.Image = imageList1.Images[c];
                p = c;
            }
            if (y1 == 8)
            {
                pictureBox8.Image = imageList1.Images[c];
                p = c;
            }
            if (z == 8)
            {
                pictureBox8.Image = imageList1.Images[d];
                p = d;
            }
            if (z1 == 8)
            {
                pictureBox8.Image = imageList1.Images[d];
                p = d;
            }
            pictureBox8.Enabled = false;
            t++;
            if (t == 2)
            {
                t = 0;
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
                pictureBox5.Enabled = false;
                pictureBox6.Enabled = false;
                pictureBox7.Enabled = false;
                pictureBox8.Enabled = false;
                if (h == p)
                {
                    g = 8;
                    timer3.Start();
                }
                timer2.Start(); 
            }
            if (t == 1)
            {
                h = p;
                i = 8;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            pictureBox1.Image = imageList1.Images[9];
            pictureBox2.Image = imageList1.Images[9];
            pictureBox3.Image = imageList1.Images[9];
            pictureBox4.Image = imageList1.Images[9];
            pictureBox5.Image = imageList1.Images[9];
            pictureBox6.Image = imageList1.Images[9];
            pictureBox7.Image = imageList1.Images[9];
            pictureBox8.Image = imageList1.Images[9];
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[9];
            pictureBox2.Image = imageList1.Images[9];
            pictureBox3.Image = imageList1.Images[9];
            pictureBox4.Image = imageList1.Images[9];
            pictureBox5.Image = imageList1.Images[9];
            pictureBox6.Image = imageList1.Images[9];
            pictureBox7.Image = imageList1.Images[9];
            pictureBox8.Image = imageList1.Images[9];
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox8.Enabled = true;
            timer2.Stop();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            switch (i)
            {
                case 1:
                    pictureBox1.Visible = false;
                    break;
                case 2:
                    pictureBox2.Visible = false;
                    break;
                case 3:
                    pictureBox3.Visible = false;
                    break;
                case 4:
                    pictureBox4.Visible = false;
                    break;
                case 5:
                    pictureBox5.Visible = false;
                    break;
                case 6:
                    pictureBox6.Visible = false;
                    break;
                case 7:
                    pictureBox7.Visible = false;
                    break;
                case 8:
                    pictureBox8.Visible = false;
                    break;
                default:
                    break;
            }
            switch (g)
            {
                case 1:
                    pictureBox1.Visible = false;
                    break;
                case 2:
                    pictureBox2.Visible = false;
                    break;
                case 3:
                    pictureBox3.Visible = false;
                    break;
                case 4:
                    pictureBox4.Visible = false;
                    break;
                case 5:
                    pictureBox5.Visible = false;
                    break;
                case 6:
                    pictureBox6.Visible = false;
                    break;
                case 7:
                    pictureBox7.Visible = false;
                    break;
                case 8:
                    pictureBox8.Visible = false;
                    break;
                default:
                    break;
            }
            if ((pictureBox1.Visible == false) && (pictureBox2.Visible == false) && (pictureBox3.Visible == false) && (pictureBox4.Visible == false) && (pictureBox5.Visible == false) && (pictureBox6.Visible == false) && (pictureBox7.Visible == false) && (pictureBox8.Visible == false))
            {
                label3.Text = "You Won The Game";
                button1.Enabled = true;
                timer5.Interval = 500;
                timer5.Start();
                timer3.Stop();
                timer4.Stop();
                timer2.Stop();
                timer1.Stop();
                u = false;
                this.Form1_Load(sender, e);
            }
            if(u==true)
            timer2.Start();
            timer3.Stop();
        }
        bool u = true;

        private void timer4_Tick(object sender, EventArgs e)
        {
            label2.Text = k.ToString();
            k++;
            if ((k == 30)&&(u==true)) 
            {
                button1.Enabled = true;
                k = 0;
                label2.Text = "0000";
                timer4.Stop();
                MessageBox.Show("Times Up!!!");
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
                pictureBox5.Enabled = false;
                pictureBox6.Enabled = false;
                pictureBox7.Enabled = false;
                pictureBox8.Enabled = false;

            }
            
        }
        bool n = true,o=true;

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (n == true)
            {
                label3.Visible = false;
                n = false;
            }
            else
            {
                label3.Visible = true;
                n = true;
                if (o == true)
                {
                    label3.ForeColor = Color.Blue;
                    o = false;
                }
                else 
                {

                    label3.ForeColor = Color.Red;
                    o = true;
 
                }
            }
        }
    }
}
