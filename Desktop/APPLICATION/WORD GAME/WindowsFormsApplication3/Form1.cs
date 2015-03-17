using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Enabled = false;
            label2.Visible  = false;
        }
        int sc=0;
        Random r = new Random();
        int a, b, c, d, x, f, g, h, i, j;
        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible  = true;
            label1.Text = "0";
            richTextBox1.Enabled = true;
            timer1.Interval = 1000;
            timer2.Interval = 2000;
            timer1.Enabled = true;
            timer2.Enabled = true;
            button1.Enabled = false;
            a = r.Next(26);
            b = r.Next(26);
            c = r.Next(26);
            d = r.Next(26);
            x = r.Next(26);
            f = r.Next(26);
            g = r.Next(26);
            h = r.Next(26);
            i = r.Next(26);
            j = r.Next(26);
            pictureBox1.Image = imageList1.Images[a];
            pictureBox2.Image = imageList1.Images[b];
            pictureBox3.Image = imageList1.Images[c];
            pictureBox4.Image = imageList1.Images[d];
            pictureBox5.Image = imageList1.Images[x];
            pictureBox6.Image = imageList1.Images[f];
            pictureBox7.Image = imageList1.Images[g];
            pictureBox8.Image = imageList1.Images[h];
            pictureBox9.Image = imageList1.Images[i];
            pictureBox10.Image = imageList1.Images[j];
            a++;
            b++;
            c++;
            d++;
            x++;
            f++;
            g++;
            h++;
            i++;
            j++;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            char[] k;
            char l;
            k = richTextBox1.Text.ToCharArray();
            l=k[k.Length-1];
            switch (l)
            {
                case 'a':
                case 'A':
                    if (a == 1)
                    {
                        a = r.Next(26);
                        pictureBox1.Image = imageList1.Images[a];
                        sc++;
                        a++;
                    }
                    else if (b == 1)
                    {
                        b = r.Next(26);
                        pictureBox2.Image = imageList1.Images[b];
                        sc++;
                        b++;
                    }
                    else if (c == 1)
                    {
                        c = r.Next(26);
                        pictureBox3.Image = imageList1.Images[c];
                        sc++;
                        c++;
                    }
                    else if (d == 1)
                    {
                        d = r.Next(26);
                        pictureBox4.Image = imageList1.Images[d];
                        sc++;
                        d++;
                    }
                    else if (x == 1)
                    {
                        x = r.Next(26);
                        pictureBox5.Image = imageList1.Images[x];
                        sc++;
                        x++;
                    }
                    else if (f == 1)
                    {
                        f = r.Next(26);
                        pictureBox6.Image = imageList1.Images[f];
                        sc++;
                        f++;
                    }
                    else if (g == 1)
                    {
                        g = r.Next(26);
                        pictureBox7.Image = imageList1.Images[g];
                        sc++;
                        g++;
                    }
                    else if (h == 1)
                    {
                        h = r.Next(26);
                        pictureBox8.Image = imageList1.Images[h];
                        sc++;
                        h++;
                    }
                    else if (i == 1)
                    {
                        i = r.Next(26);
                        pictureBox9.Image = imageList1.Images[i];
                        sc++;
                        i++;
                    }
                    else if (j == 1)
                    {
                        j = r.Next(26);
                        sc++;
                        pictureBox10.Image = imageList1.Images[j];
                        j++;
                    }
                    else 
                    {
                        sc--;
                    }
                    break;
                case 'b':
                case 'B':
                    if (a == 2)
                    {
                        a = r.Next(26);
                        pictureBox1.Image = imageList1.Images[a];
                        sc++;
                        a++;
                    }
                    else if (b == 2)
                    {
                        b = r.Next(26);
                        pictureBox2.Image = imageList1.Images[b];
                        b++;
                        sc++;
                    }
                    else if (c == 2)
                    {
                        c = r.Next(26);
                        pictureBox3.Image = imageList1.Images[c];
                        sc++;
                        c++;
                    }
                    else if (d == 2)
                    {
                        d = r.Next(26);
                        pictureBox4.Image = imageList1.Images[d];
                        sc++;
                        d++;
                    }
                    else if (x == 2)
                    {
                        x = r.Next(26);
                        pictureBox5.Image = imageList1.Images[x];
                        sc++;
                        x++;
                    }
                    else if (f == 2)
                    {
                        f = r.Next(26);
                        pictureBox6.Image = imageList1.Images[f];
                        sc++;
                        f++;
                    }
                    else if (g == 2)
                    {
                        g = r.Next(26);
                        pictureBox7.Image = imageList1.Images[g];
                        sc++;
                        g++;
                    }
                    else if (h == 2)
                    {
                        h = r.Next(26);
                        pictureBox8.Image = imageList1.Images[h];
                        sc++;
                        h++;
                    }
                    else if (i == 2)
                    {
                        i = r.Next(26);
                        pictureBox9.Image = imageList1.Images[i];
                        sc++;
                        i++;
                    }
                    else if (j == 2)
                    {
                        j = r.Next(26);
                        pictureBox10.Image = imageList1.Images[j];
                        sc++;
                        j++;
                    }
                    else
                    {
                        sc--;
                    }
                    break;
                case 'c':
                case 'C':
                    if (a == 3)
                    {
                        a = r.Next(26);
                        pictureBox1.Image = imageList1.Images[a];
                        a++;
                        sc++;
                    }
                    else if (b == 3)
                    {
                        b = r.Next(26);
                        pictureBox2.Image = imageList1.Images[b];
                        sc++;
                        b++;
                    }
                    else if (c == 3)
                    {
                        c = r.Next(26);
                        pictureBox3.Image = imageList1.Images[c];
                        sc++;
                        c++;
                    }
                    else if (d == 3)
                    {
                        d = r.Next(26);
                        pictureBox4.Image = imageList1.Images[d];
                        sc++;
                        d++;
                    }
                    else if (x == 3)
                    {
                        x = r.Next(26);
                        pictureBox5.Image = imageList1.Images[x];
                        sc++;
                        x++;
                    }
                    else if (f == 3)
                    {
                        f = r.Next(26);
                        pictureBox6.Image = imageList1.Images[f];
                        sc++;
                        f++;
                    }
                    else if (g == 3)
                    {
                        g = r.Next(26);
                        pictureBox7.Image = imageList1.Images[g];
                        sc++;
                        g++;
                    }
                    else if (h == 3)
                    {
                        h = r.Next(26);
                        pictureBox8.Image = imageList1.Images[h];
                        sc++;
                        h++;
                    }
                    else if (i == 3)
                    {
                        i = r.Next(26);
                        pictureBox9.Image = imageList1.Images[i];
                        sc++;
                        i++;
                    }
                    else if (j == 3)
                    {
                        j = r.Next(26);
                        pictureBox10.Image = imageList1.Images[j];
                        sc++;
                        j++;
                    }
                    else
                    {
                        sc--;
                    }
                    break;
                case 'd':
                case 'D':
                    if (a == 4)
                    {
                        a = r.Next(26);
                        pictureBox1.Image = imageList1.Images[a];
                        sc++;
                        a++;
                    }
                    else if (b == 4)
                    {
                        b = r.Next(26);
                        pictureBox2.Image = imageList1.Images[b];
                        sc++;
                        b++;
                    }
                    else if (c == 4)
                    {
                        c = r.Next(26);
                        pictureBox3.Image = imageList1.Images[c];
                        sc++;
                        c++;
                    }
                    else if (d == 4)
                    {
                        d = r.Next(26);
                        pictureBox4.Image = imageList1.Images[d];
                        sc++;
                        d++;
                    }
                    else if (x == 4)
                    {
                        x = r.Next(26);
                        pictureBox5.Image = imageList1.Images[x];
                        sc++;
                        x++;
                    }
                    else if (f == 4)
                    {
                        f = r.Next(26);
                        pictureBox6.Image = imageList1.Images[f];
                        sc++;
                        f++;
                    }
                    else if (g == 4)
                    {
                        g = r.Next(26);
                        pictureBox7.Image = imageList1.Images[g];
                        sc++;
                        g++;
                    }
                    else if (h == 4)
                    {
                        h = r.Next(26);
                        pictureBox8.Image = imageList1.Images[h];
                        sc++;
                        h++;
                    }
                    else if (i == 4)
                    {
                        i = r.Next(26);
                        pictureBox9.Image = imageList1.Images[i];
                        sc++;
                        i++;
                    }
                    else if (j == 4)
                    {
                        j = r.Next(26);
                        pictureBox10.Image = imageList1.Images[j];
                        sc++;
                        j++;
                    }
                    else
                    {
                        sc--;
                    }
                    break;
                case 'e':
                case 'E':
                    if (a == 5)
                    {
                        a = r.Next(26);
                        pictureBox1.Image = imageList1.Images[a];
                        sc++;
                        a++;
                    }
                    else if (b == 5)
                    {
                        b = r.Next(26);
                        pictureBox2.Image = imageList1.Images[b];
                        sc++;
                        b++;
                    }
                    else if (c == 5)
                    {
                        c = r.Next(26);
                        pictureBox3.Image = imageList1.Images[c];
                        sc++;
                        c++;
                    }
                    else if (d == 5)
                    {
                        d = r.Next(26);
                        pictureBox4.Image = imageList1.Images[d];
                        sc++;
                        d++;
                    }
                    else if (x == 5)
                    {
                        x = r.Next(26);
                        pictureBox5.Image = imageList1.Images[x];
                        sc++;
                        x++;
                    }
                    else if (f == 5)
                    {
                        f = r.Next(26);
                        pictureBox6.Image = imageList1.Images[f];
                        sc++;
                        f++;
                    }
                    else if (g == 5)
                    {
                        g = r.Next(26);
                        pictureBox7.Image = imageList1.Images[g];
                        sc++;
                        g++;
                    }
                    else if (h == 5)
                    {
                        h = r.Next(26);
                        pictureBox8.Image = imageList1.Images[h];
                        sc++;
                        h++;
                    }
                    else if (i == 5)
                    {
                        i = r.Next(26);
                        pictureBox9.Image = imageList1.Images[i];
                        sc++;
                        i++;
                    }
                    else if (j == 5)
                    {
                        j = r.Next(26);
                        pictureBox10.Image = imageList1.Images[j];
                        sc++;
                        j++;
                    }
                    else
                    {
                        sc--;
                    }
                    break;
                case 'f':
                case 'F':
                    if (a == 6)
                    {
                        a = r.Next(26);
                        pictureBox1.Image = imageList1.Images[a];
                        sc++;
                        a++;
                    }
                    else if (b == 6)
                    {
                        b = r.Next(26);
                        pictureBox2.Image = imageList1.Images[b];
                        sc++;
                        b++;
                    }
                    else if (c == 6)
                    {
                        c = r.Next(26);
                        pictureBox3.Image = imageList1.Images[c];
                        sc++;
                        c++;
                    }
                    else if (d == 6)
                    {
                        d = r.Next(26);
                        pictureBox4.Image = imageList1.Images[d];
                        sc++;
                        d++;
                    }
                    else if (x == 6)
                    {
                        x = r.Next(26);
                        pictureBox5.Image = imageList1.Images[x];
                        sc++;
                        x++;
                    }
                    else if (f == 6)
                    {
                        f = r.Next(26);
                        pictureBox6.Image = imageList1.Images[f];
                        sc++;
                        f++;
                    }
                    else if (g == 6)
                    {
                        g = r.Next(26);
                        pictureBox7.Image = imageList1.Images[g];
                        sc++;
                        g++;
                    }
                    else if (h == 6)
                    {
                        h = r.Next(26);
                        pictureBox8.Image = imageList1.Images[h];
                        sc++;
                        h++;
                    }
                    else if (i == 6)
                    {
                        i = r.Next(26);
                        pictureBox9.Image = imageList1.Images[i];
                        sc++;
                        i++;
                    }
                    else if (j == 6)
                    {
                        j = r.Next(26);
                        pictureBox10.Image = imageList1.Images[j];
                        sc++;
                        j++;
                    }
                    else
                    {
                        sc--;
                    }
                    break;
                case 'g':
                case 'G':
                    if (a == 7)
                    {
                        a = r.Next(26);
                        pictureBox1.Image = imageList1.Images[a];
                        sc++;
                        a++;
                    }
                    else if (b == 7)
                    {
                        b = r.Next(26);
                        pictureBox2.Image = imageList1.Images[b];
                        sc++;
                        b++;
                    }
                    else if (c == 7)
                    {
                        c = r.Next(26);
                        pictureBox3.Image = imageList1.Images[c];
                        sc++;
                        c++;
                    }
                    else if (d == 7)
                    {
                        d = r.Next(26);
                        pictureBox4.Image = imageList1.Images[d];
                        sc++;
                        d++;
                    }
                    else if (x == 7)
                    {
                        x = r.Next(26);
                        pictureBox5.Image = imageList1.Images[x];
                        sc++;
                        x++;
                    }
                    else if (f == 7)
                    {
                        f = r.Next(26);
                        pictureBox6.Image = imageList1.Images[f];
                        sc++;
                        f++;
                    }
                    else if (g == 7)
                    {
                        g = r.Next(26);
                        pictureBox7.Image = imageList1.Images[g];
                        sc++;
                        g++;
                    }
                    else if (h == 7)
                    {
                        h = r.Next(26);
                        pictureBox8.Image = imageList1.Images[h];
                        sc++;
                        h++;
                    }
                    else if (i == 7)
                    {
                        i = r.Next(26);
                        pictureBox9.Image = imageList1.Images[i];
                        sc++;
                        i++;
                    }
                    else if (j == 7)
                    {
                        j = r.Next(26);
                        pictureBox10.Image = imageList1.Images[j];
                        sc++;
                        j++;
                    }
                    else
                    {
                        sc--;
                    }
                    break;
                case 'h':
                case 'H':
                    if (a == 8)
                    {
                        a = r.Next(26);
                        pictureBox1.Image = imageList1.Images[a];
                        sc++;
                        a++;
                    }
                    else if (b == 8)
                    {
                        b = r.Next(26);
                        pictureBox2.Image = imageList1.Images[b];
                        sc++;
                        b++;
                    }
                    else if (c == 8)
                    {
                        c = r.Next(26);
                        pictureBox3.Image = imageList1.Images[c];
                        sc++;
                        c++;
                    }
                    else if (d == 8)
                    {
                        d = r.Next(26);
                        pictureBox4.Image = imageList1.Images[d];
                        sc++;
                        d++;
                    }
                    else if (x == 8)
                    {
                        x = r.Next(26);
                        pictureBox5.Image = imageList1.Images[x];
                        sc++;
                        x++;
                    }
                    else if (f == 8)
                    {
                        f = r.Next(26);
                        pictureBox6.Image = imageList1.Images[f];
                        sc++;
                        f++;
                    }
                    else if (g == 8)
                    {
                        g = r.Next(26);
                        pictureBox7.Image = imageList1.Images[g];
                        sc++;
                        g++;
                    }
                    else if (h == 8)
                    {
                        h = r.Next(26);
                        pictureBox8.Image = imageList1.Images[h];
                        sc++;
                        h++;
                    }
                    else if (i == 8)
                    {
                        i = r.Next(26);
                        sc++;
                        pictureBox9.Image = imageList1.Images[i];
                        i++;
                    }
                    else if (j == 8)
                    {
                        j = r.Next(26);
                        pictureBox10.Image = imageList1.Images[j];
                        sc++;
                        j++;
                    }
                    else
                    {
                        sc--;
                    }
                    break;
                case 'i':
                case 'I':
                    if (a == 9)
                    {
                        a = r.Next(26);
                        pictureBox1.Image = imageList1.Images[a];
                        sc++;
                        a++;
                    }
                    else if (b == 9)
                    {
                        b = r.Next(26);
                        pictureBox2.Image = imageList1.Images[b];
                        sc++;
                        b++;
                    }
                    else if (c == 9)
                    {
                        c = r.Next(26);
                        pictureBox3.Image = imageList1.Images[c];
                        sc++;
                        c++;
                    }
                    else if (d == 9)
                    {
                        d = r.Next(26);
                        pictureBox4.Image = imageList1.Images[d];
                        sc++;
                        d++;
                    }
                    else if (x == 9)
                    {
                        x = r.Next(26);
                        pictureBox5.Image = imageList1.Images[x];
                        sc++;
                        x++;
                    }
                    else if (f == 9)
                    {
                        f = r.Next(26);
                        pictureBox6.Image = imageList1.Images[f];
                        sc++;
                        f++;
                    }
                    else if (g == 9)
                    {
                        g = r.Next(26);
                        pictureBox7.Image = imageList1.Images[g];
                        sc++;
                        g++;
                    }
                    else if (h == 9)
                    {
                        h = r.Next(26);
                        pictureBox8.Image = imageList1.Images[h];
                        sc++;
                        h++;
                    }
                    else if (i == 9)
                    {
                        i = r.Next(26);
                        pictureBox9.Image = imageList1.Images[i];
                        sc++;
                        i++;
                    }
                    else if (j == 9)
                    {
                        j = r.Next(26);
                        pictureBox10.Image = imageList1.Images[j];
                        sc++;
                        j++;
                    }
                    else
                    {
                        sc--;
                    }
                    break;
                case 'j':
                case 'J':
                    if (a == 10)
                    {
                        a = r.Next(26);
                        pictureBox1.Image = imageList1.Images[a];
                        sc++;
                        a++;
                    }
                    else if (b == 10)
                    {
                        b = r.Next(26);
                        pictureBox2.Image = imageList1.Images[b];
                        sc++;
                        b++;
                    }
                    else if (c == 10)
                    {
                        c = r.Next(26);
                        pictureBox3.Image = imageList1.Images[c];
                        sc++;
                        c++;
                    }
                    else if (d == 10)
                    {
                        d = r.Next(26);
                        pictureBox4.Image = imageList1.Images[d];
                        sc++;
                        d++;
                    }
                    else if (x == 10)
                    {
                        x = r.Next(26);
                        pictureBox5.Image = imageList1.Images[x];
                        sc++;
                        x++;
                    }
                    else if (f == 10)
                    {
                        f = r.Next(26);
                        sc++;
                        pictureBox6.Image = imageList1.Images[f];
                        f++;
                    }
                    else if (g == 10)
                    {
                        g = r.Next(26);
                        sc++;
                        pictureBox7.Image = imageList1.Images[g];
                        g++;
                    }
                    else if (h == 10)
                    {
                        h = r.Next(26);
                        sc++;
                        pictureBox8.Image = imageList1.Images[h];
                        h++;
                    }
                    else if (i == 10)
                    {
                        i = r.Next(26);
                        sc++;
                        pictureBox9.Image = imageList1.Images[i];
                        i++;
                    }
                    else if (j == 10)
                    {
                        j = r.Next(26);
                        sc++;
                        pictureBox10.Image = imageList1.Images[j];
                        j++;
                    }
                    else
                    {
                        sc--;
                    }
                    break;
                case 'k':
                case 'K':
                    if (a == 11)
                    {
                        a = r.Next(26);
                        sc++;
                        pictureBox1.Image = imageList1.Images[a]; 
                        a++;
                    }
                    else if (b == 11)
                    {
                        b = r.Next(26);
                        sc++;
                        pictureBox2.Image = imageList1.Images[b];
                        b++;
                    }
                    else if (c == 11)
                    {
                        c = r.Next(26);
                        sc++;
                        pictureBox3.Image = imageList1.Images[c];
                        c++;
                    }
                    else if (d == 11)
                    {
                        d = r.Next(26);
                        sc++;
                        pictureBox4.Image = imageList1.Images[d];
                        d++;
                    }
                    else if (x == 11)
                    {
                        x = r.Next(26);
                        sc++;
                        pictureBox5.Image = imageList1.Images[x];
                        x++;
                    }
                    else if (f == 11)
                    {
                        f = r.Next(26);
                        sc++;
                        pictureBox6.Image = imageList1.Images[f];
                        f++;
                    }
                    else if (g == 11)
                    {
                        g = r.Next(26);
                        sc++;
                        pictureBox7.Image = imageList1.Images[g];
                        g++;
                    }
                    else if (h == 11)
                    {
                        h = r.Next(26);
                        sc++;
                        pictureBox8.Image = imageList1.Images[h];
                        h++;
                    }
                    else if (i == 11)
                    {
                        i = r.Next(26);
                        sc++;
                        pictureBox9.Image = imageList1.Images[i];
                        i++;
                    }
                    else if (j == 11)
                    {
                        j = r.Next(26);
                        sc++;
                        pictureBox10.Image = imageList1.Images[j];
                        j++;
                    }
                    else
                    {
                        sc--;
                    }
                    break;
                case 'l':
                case 'L':
                    if (a == 12)
                    {
                        a = r.Next(26);
                        sc++;
                        pictureBox1.Image = imageList1.Images[a];
                        a++;
                    }
                    else if (b == 12)
                    {
                        b = r.Next(26);
                        sc++;
                        pictureBox2.Image = imageList1.Images[b];
                        b++;
                    }
                    else if (c == 12)
                    {
                        c = r.Next(26);
                        sc++;
                        pictureBox3.Image = imageList1.Images[c];
                        c++;
                    }
                    else if (d == 12)
                    {
                        d = r.Next(26);
                        sc++;
                        pictureBox4.Image = imageList1.Images[d];
                        d++;
                    }
                    else if (x == 12)
                    {
                        x = r.Next(26);
                        sc++;
                        pictureBox5.Image = imageList1.Images[x];
                        x++;
                    }
                    else if (f == 12)
                    {
                        f = r.Next(26);
                        sc++;
                        pictureBox6.Image = imageList1.Images[f];
                        f++;
                    }
                    else if (g == 12)
                    {
                        g = r.Next(26);
                        sc++;
                        pictureBox7.Image = imageList1.Images[g];
                        g++;
                    }
                    else if (h == 12)
                    {
                        h = r.Next(26);
                        sc++;
                        pictureBox8.Image = imageList1.Images[h];
                        h++;
                    }
                    else if (i == 12)
                    {
                        i = r.Next(26);
                        sc++;
                        pictureBox9.Image = imageList1.Images[i];
                        i++;
                    }
                    else if (j == 12)
                    {
                        j = r.Next(26);
                        sc++;
                        pictureBox10.Image = imageList1.Images[j];
                        j++;
                    }
                    else
                    {
                        sc--;
                    }
                    break;
                case 'm':
                case 'M':
                    if (a == 13)
                    {
                        a = r.Next(26);
                        sc++;
                        pictureBox1.Image = imageList1.Images[a];
                        a++;
                    }
                    else if (b == 13)
                    {
                        b = r.Next(26);
                        sc++;
                        pictureBox2.Image = imageList1.Images[b];
                        b++;
                    }
                    else if (c == 13)
                    {
                        c = r.Next(26);
                        sc++;
                        pictureBox3.Image = imageList1.Images[c];
                        c++;
                    }
                    else if (d == 13)
                    {
                        d = r.Next(26);
                        sc++;
                        pictureBox4.Image = imageList1.Images[d];
                        d++;
                    }
                    else if (x == 13)
                    {
                        x = r.Next(26);
                        sc++;
                        pictureBox5.Image = imageList1.Images[x];
                        x++;
                    }
                    else if (f == 13)
                    {
                        f = r.Next(26);
                        sc++;
                        pictureBox6.Image = imageList1.Images[f];
                        f++;
                    }
                    else if (g == 13)
                    {
                        g = r.Next(26);
                        sc++;
                        pictureBox7.Image = imageList1.Images[g];
                        g++;
                    }
                    else if (h == 13)
                    {
                        h = r.Next(26);
                        sc++;
                        pictureBox8.Image = imageList1.Images[h];
                        h++;
                    }
                    else if (i == 13)
                    {
                        i = r.Next(26);
                        sc++;
                        pictureBox9.Image = imageList1.Images[i];
                        i++;
                    }
                    else if (j == 13)
                    {
                        j = r.Next(26);
                        sc++;
                        pictureBox10.Image = imageList1.Images[j];
                        j++;
                    }
                    else
                    {
                        sc--;
                    }
                    break;
                case 'n':
                case 'N':
                    if (a == 14)
                    {
                        a = r.Next(26);
                        sc++;
                        pictureBox1.Image = imageList1.Images[a];
                        a++;
                    }
                    else if (b == 14)
                    {
                        b = r.Next(26);
                        sc++;
                        pictureBox2.Image = imageList1.Images[b];
                        b++;
                    }
                    else if (c == 14)
                    {
                        c = r.Next(26);
                        sc++;
                        pictureBox3.Image = imageList1.Images[c];
                        c++;
                    }
                    else if (d == 14)
                    {
                        d = r.Next(26);
                        sc++;
                        pictureBox4.Image = imageList1.Images[d];
                        d++;
                    }
                    else if (x == 14)
                    {
                        x = r.Next(26);
                        sc++;
                        pictureBox5.Image = imageList1.Images[x];
                        x++;
                    }
                    else if (f == 14)
                    {
                        f = r.Next(26);
                        sc++;
                        pictureBox6.Image = imageList1.Images[f];
                        f++;
                    }
                    else if (g == 14)
                    {
                        g = r.Next(26);
                        sc++;
                        pictureBox7.Image = imageList1.Images[g];
                        g++;
                    }
                    else if (h == 14)
                    {
                        h = r.Next(26);
                        sc++;
                        pictureBox8.Image = imageList1.Images[h];
                        h++;
                    }
                    else if (i == 14)
                    {
                        i = r.Next(26);
                        sc++;
                        pictureBox9.Image = imageList1.Images[i];
                        i++;
                    }
                    else if (j == 14)
                    {
                        j = r.Next(26);
                        sc++;
                        pictureBox10.Image = imageList1.Images[j];
                        j++;
                    }
                    else
                    {
                        sc--;
                    }
                    break;
                case 'o':
                case 'O':
                    if (a == 15)
                    {
                        a = r.Next(26);
                        sc++;
                        pictureBox1.Image = imageList1.Images[a];
                        a++;
                    }
                    else if (b == 15)
                    {
                        b = r.Next(26);
                        sc++;
                        pictureBox2.Image = imageList1.Images[b];
                        b++;
                    }
                    else if (c == 15)
                    {
                        c = r.Next(26);
                        sc++;
                        pictureBox3.Image = imageList1.Images[c];
                        c++;
                    }
                    else if (d == 15)
                    {
                        d = r.Next(26);
                        sc++;
                        pictureBox4.Image = imageList1.Images[d];
                        d++;
                    }
                    else if (x == 15)
                    {
                        x = r.Next(26);
                        sc++;
                        pictureBox5.Image = imageList1.Images[x];
                        x++;
                    }
                    else if (f == 15)
                    {
                        f = r.Next(26);
                        sc++;
                        pictureBox6.Image = imageList1.Images[f];
                        f++;
                    }
                    else if (g == 15)
                    {
                        g = r.Next(26);
                        sc++;
                        pictureBox7.Image = imageList1.Images[g];
                        g++;
                    }
                    else if (h == 15)
                    {
                        h = r.Next(26);
                        sc++;
                        pictureBox8.Image = imageList1.Images[h];
                        h++;
                    }
                    else if (i == 15)
                    {
                        i = r.Next(26);
                        sc++;
                        pictureBox9.Image = imageList1.Images[i];
                        i++;
                    }
                    else if (j == 15)
                    {
                        j = r.Next(26);
                        sc++;
                        pictureBox10.Image = imageList1.Images[j];
                        j++;
                    }
                    else
                    {
                        sc--;
                    }
                    break;
                case 'p':
                case 'P':
                    if (a == 16)
                    {
                        a = r.Next(26);
                        sc++;
                        pictureBox1.Image = imageList1.Images[a];
                        a++;
                    }
                    else if (b == 16)
                    {
                        b = r.Next(26);
                        sc++;
                        pictureBox2.Image = imageList1.Images[b];
                        b++;
                    }
                    else if (c == 16)
                    {
                        c = r.Next(26);
                        sc++;
                        pictureBox3.Image = imageList1.Images[c];
                        c++;
                    }
                    else if (d == 16)
                    {
                        d = r.Next(26);
                        sc++;
                        pictureBox4.Image = imageList1.Images[d];
                        d++;
                    }
                    else if (x == 16)
                    {
                        x = r.Next(26);
                        sc++;
                        pictureBox5.Image = imageList1.Images[x];
                        x++;
                    }
                    else if (f == 16)
                    {
                        f = r.Next(26);
                        sc++;
                        pictureBox6.Image = imageList1.Images[f];
                        f++;
                    }
                    else if (g == 16)
                    {
                        g = r.Next(26);
                        sc++;
                        pictureBox7.Image = imageList1.Images[g];
                        g++;
                    }
                    else if (h == 16)
                    {
                        h = r.Next(26);
                        sc++;
                        pictureBox8.Image = imageList1.Images[h];
                        h++;
                    }
                    else if (i == 16)
                    {
                        i = r.Next(26);
                        sc++;
                        pictureBox9.Image = imageList1.Images[i];
                        i++;
                    }
                    else if (j == 16)
                    {
                        j = r.Next(26);
                        sc++;
                        pictureBox10.Image = imageList1.Images[j];
                        j++;
                    }
                    else
                    {
                        sc--;
                    }
                    break;
                case 'q':
                case 'Q':
                    if (a == 17)
                    {
                        a = r.Next(26);
                        sc++;
                        pictureBox1.Image = imageList1.Images[a];
                        a++;
                    }
                    else if (b == 17)
                    {
                        b = r.Next(26);
                        sc++;
                        pictureBox2.Image = imageList1.Images[b];
                        b++;
                    }
                    else if (c == 17)
                    {
                        c = r.Next(26);
                        sc++;
                        pictureBox3.Image = imageList1.Images[c];
                        c++;
                    }
                    else if (d == 17)
                    {
                        d = r.Next(26);
                        sc++;
                        pictureBox4.Image = imageList1.Images[d];
                        d++;
                    }
                    else if (x == 17)
                    {
                        x = r.Next(26);
                        sc++;
                        pictureBox5.Image = imageList1.Images[x];
                        x++;
                    }
                    else if (f == 17)
                    {
                        f = r.Next(26);
                        sc++;
                        pictureBox6.Image = imageList1.Images[f];
                        f++;
                    }
                    else if (g == 17)
                    {
                        g = r.Next(26);
                        sc++;
                        pictureBox7.Image = imageList1.Images[g];
                        g++;
                    }
                    else if (h == 17)
                    {
                        h = r.Next(26);
                        sc++;
                        pictureBox8.Image = imageList1.Images[h];
                        h++;
                    }
                    else if (i == 17)
                    {
                        i = r.Next(26);
                        sc++;
                        pictureBox9.Image = imageList1.Images[i];
                        i++;
                    }
                    else if (j == 17)
                    {
                        j = r.Next(26);
                        sc++;
                        pictureBox10.Image = imageList1.Images[j];
                        j++;
                    }
                    else
                    {
                        sc--;
                    }
                    break;
                case 'r':
                case 'R':
                    if (a == 18)
                    {
                        a = r.Next(26);
                        sc++;
                        pictureBox1.Image = imageList1.Images[a];
                        a++;
                    }
                    else if (b == 18)
                    {
                        b = r.Next(26);
                        sc++;
                        pictureBox2.Image = imageList1.Images[b];
                        b++;
                    }
                    else if (c == 18)
                    {
                        c = r.Next(26);
                        sc++;
                        pictureBox3.Image = imageList1.Images[c];
                        c++;
                    }
                    else if (d == 18)
                    {
                        d = r.Next(26);
                        sc++;
                        pictureBox4.Image = imageList1.Images[d];
                        d++;
                    }
                    else if (x == 18)
                    {
                        x = r.Next(26);
                        sc++;
                        pictureBox5.Image = imageList1.Images[x];
                        x++;
                    }
                    else if (f == 18)
                    {
                        f = r.Next(26);
                        sc++;
                        pictureBox6.Image = imageList1.Images[f];
                        f++;
                    }
                    else if (g == 18)
                    {
                        g = r.Next(26);
                        sc++;
                        pictureBox7.Image = imageList1.Images[g];
                        g++;
                    }
                    else if (h == 18)
                    {
                        h = r.Next(26);
                        sc++;
                        pictureBox8.Image = imageList1.Images[h];
                        h++;
                    }
                    else if (i == 18)
                    {
                        i = r.Next(26);
                        sc++;
                        pictureBox9.Image = imageList1.Images[i];
                        i++;
                    }
                    else if (j == 18)
                    {
                        j = r.Next(26);
                        sc++;
                        pictureBox10.Image = imageList1.Images[j];
                        j++;
                    }
                    else
                    {
                        sc--;
                    }
                    break;
                case 's':
                case 'S':
                    if (a == 19)
                    {
                        a = r.Next(26);
                        sc++;
                        pictureBox1.Image = imageList1.Images[a];
                        a++;
                    }
                    else if (b == 19)
                    {
                        b = r.Next(26);
                        sc++;
                        pictureBox2.Image = imageList1.Images[b];
                        b++;
                    }
                    else if (c == 19)
                    {
                        c = r.Next(26);
                        sc++;
                        pictureBox3.Image = imageList1.Images[c];
                        c++;
                    }
                    else if (d == 19)
                    {
                        sc++;
                        d = r.Next(26);
                        pictureBox4.Image = imageList1.Images[d];
                        d++;
                    }
                    else if (x == 19)
                    {
                        x = r.Next(26);
                        sc++;
                        pictureBox5.Image = imageList1.Images[x];
                        x++;
                    }
                    else if (f == 19)
                    {
                        f = r.Next(26);
                        sc++;
                        pictureBox6.Image = imageList1.Images[f];
                        f++;
                    }
                    else if (g == 19)
                    {
                        g = r.Next(26);
                        sc++;
                        pictureBox7.Image = imageList1.Images[g];
                        g++;
                    }
                    else if (h == 19)
                    {
                        h = r.Next(26);
                        sc++;
                        pictureBox8.Image = imageList1.Images[h];
                        h++;
                    }
                    else if (i == 19)
                    {
                        i = r.Next(26);
                        sc++;
                        pictureBox9.Image = imageList1.Images[i];
                        i++;
                    }
                    else if (j == 19)
                    {
                        j = r.Next(26);
                        sc++;
                        pictureBox10.Image = imageList1.Images[j];
                        j++;
                    }
                    else
                    {
                        sc--;
                    }
                    break;
                case 't':
                case 'T':
                    if (a == 20)
                    {
                        a = r.Next(26);
                        sc++;
                        pictureBox1.Image = imageList1.Images[a];
                        a++;
                    }
                    else if (b == 20)
                    {
                        b = r.Next(26);
                        sc++;
                        pictureBox2.Image = imageList1.Images[b];
                        b++;
                    }
                    else if (c == 20)
                    {
                        c = r.Next(26);
                        sc++;
                        pictureBox3.Image = imageList1.Images[c];
                        c++;
                    }
                    else if (d == 20)
                    {
                        sc++;
                        d = r.Next(26);
                        pictureBox4.Image = imageList1.Images[d];
                        d++;
                    }
                    else if (x == 20)
                    {
                        x = r.Next(26);
                        sc++;
                        pictureBox5.Image = imageList1.Images[x];
                        x++;
                    }
                    else if (f == 20)
                    {
                        f = r.Next(26);
                        sc++;
                        pictureBox6.Image = imageList1.Images[f];
                        f++;
                    }
                    else if (g == 20)
                    {
                        g = r.Next(26);
                        sc++;
                        pictureBox7.Image = imageList1.Images[g];
                        g++;
                    }
                    else if (h == 20)
                    {
                        h = r.Next(26);
                        sc++;
                        pictureBox8.Image = imageList1.Images[h];
                        h++;
                    }
                    else if (i == 20)
                    {
                        i = r.Next(26);
                        sc++;
                        pictureBox9.Image = imageList1.Images[i];
                        i++;
                    }
                    else if (j == 20)
                    {
                        j = r.Next(26);
                        sc++;
                        pictureBox10.Image = imageList1.Images[j];
                        j++;
                    }
                    else
                    {
                        sc--;
                    }
                    break;
                case 'u':
                case 'U':
                    if (a == 21)
                    {
                        a = r.Next(26);
                        sc++;
                        pictureBox1.Image = imageList1.Images[a];
                        a++;
                    }
                    else if (b == 21)
                    {
                        b = r.Next(26);
                        sc++;
                        pictureBox2.Image = imageList1.Images[b];
                        b++;
                    }
                    else if (c == 21)
                    {
                        c = r.Next(26);
                        sc++;
                        pictureBox3.Image = imageList1.Images[c];
                        c++;
                    }
                    else if (d == 21)
                    {
                        d = r.Next(26);
                        sc++;
                        pictureBox4.Image = imageList1.Images[d];
                        d++;
                    }
                    else if (x == 21)
                    {
                        x = r.Next(26);
                        sc++;
                        pictureBox5.Image = imageList1.Images[x];
                        x++;
                    }
                    else if (f == 21)
                    {
                        f = r.Next(26);
                        sc++;
                        pictureBox6.Image = imageList1.Images[f];
                        f++;
                    }
                    else if (g == 21)
                    {
                        g = r.Next(26);
                        sc++;
                        pictureBox7.Image = imageList1.Images[g];
                        g++;
                    }
                    else if (h == 21)
                    {
                        h = r.Next(26);
                        sc++;
                        pictureBox8.Image = imageList1.Images[h];
                        h++;
                    }
                    else if (i == 21)
                    {
                        i = r.Next(26);
                        sc++;
                        pictureBox9.Image = imageList1.Images[i];
                        i++;
                    }
                    else if (j == 21)
                    {
                        j = r.Next(26);
                        sc++;
                        pictureBox10.Image = imageList1.Images[j];
                        j++;
                    }
                    else
                    {
                        sc--;
                    }
                    break;
                case 'v':
                case 'V':
                    if (a == 22)
                    {
                        a = r.Next(26);
                        pictureBox1.Image = imageList1.Images[a];
                        sc++;
                        a++;
                    }
                    else if (b == 22)
                    {
                        b = r.Next(26);
                        pictureBox2.Image = imageList1.Images[b];
                        sc++;
                        b++;
                    }
                    else if (c == 22)
                    {
                        c = r.Next(26);
                        sc++;
                        pictureBox3.Image = imageList1.Images[c];
                        c++;
                    }
                    else if (d == 22)
                    {
                        d = r.Next(26);
                        sc++;
                        pictureBox4.Image = imageList1.Images[d];
                        d++;
                    }
                    else if (x == 22)
                    {
                        x = r.Next(26);
                        sc++;
                        pictureBox5.Image = imageList1.Images[x];
                        x++;
                    }
                    else if (f == 22)
                    {
                        f = r.Next(26);
                        sc++;
                        pictureBox6.Image = imageList1.Images[f];
                        f++;
                    }
                    else if (g == 22)
                    {
                        g = r.Next(26);
                        sc++;
                        pictureBox7.Image = imageList1.Images[g];
                        g++;
                    }
                    else if (h == 22)
                    {
                        h = r.Next(26);
                        sc++;
                        pictureBox8.Image = imageList1.Images[h];
                        h++;
                    }
                    else if (i == 22)
                    {
                        i = r.Next(26);
                        sc++;
                        pictureBox9.Image = imageList1.Images[i];
                        i++;
                    }
                    else if (j == 22)
                    {
                        j = r.Next(26);
                        sc++;
                        pictureBox10.Image = imageList1.Images[j];
                        j++;
                    }
                    else
                    {
                        sc--;
                    }
                    break;
                case 'w':
                case 'W':
                    if (a == 23)
                    {
                        a = r.Next(26);
                        sc++;
                        pictureBox1.Image = imageList1.Images[a];
                        a++;
                    }
                    else if (b == 23)
                    {
                        b = r.Next(26);
                        sc++;
                        pictureBox2.Image = imageList1.Images[b];
                        b++;
                    }
                    else if (c == 23)
                    {
                        c = r.Next(26);
                        sc++;
                        pictureBox3.Image = imageList1.Images[c];
                        c++;
                    }
                    else if (d == 23)
                    {
                        d = r.Next(26);
                        sc++;
                        pictureBox4.Image = imageList1.Images[d];
                        d++;
                    }
                    else if (x == 23)
                    {
                        x = r.Next(26);
                        sc++;
                        pictureBox5.Image = imageList1.Images[x];
                        x++;
                    }
                    else if (f == 23)
                    {
                        f = r.Next(26);
                        sc++;
                        pictureBox6.Image = imageList1.Images[f];
                        f++;
                    }
                    else if (g == 23)
                    {
                        g = r.Next(26);
                        sc++;
                        pictureBox7.Image = imageList1.Images[g];
                        g++;
                    }
                    else if (h == 23)
                    {
                        h = r.Next(26);
                        sc++;
                        pictureBox8.Image = imageList1.Images[h];
                        h++;
                    }
                    else if (i == 23)
                    {
                        i = r.Next(26);
                        sc++;
                        pictureBox9.Image = imageList1.Images[i];
                        i++;
                    }
                    else if (j == 23)
                    {
                        j = r.Next(26);
                        sc++;
                        pictureBox10.Image = imageList1.Images[j];
                        j++;
                    }
                    else
                    {
                        sc--;
                    }
                    break;
                case 'x':
                case 'X':
                    if (a == 24)
                    {
                        a = r.Next(26);
                        sc++;
                        pictureBox1.Image = imageList1.Images[a];
                        a++;
                    }
                    else if (b == 24)
                    {
                        b = r.Next(26);
                        sc++;
                        pictureBox2.Image = imageList1.Images[b];
                        b++;
                    }
                    else if (c == 24)
                    {
                        c = r.Next(26);
                        sc++;
                        pictureBox3.Image = imageList1.Images[c];
                        c++;
                    }
                    else if (d == 24)
                    {
                        d = r.Next(26);
                        sc++;
                        pictureBox4.Image = imageList1.Images[d];
                        d++;
                    }
                    else if (x == 24)
                    {
                        x = r.Next(26);
                        sc++;
                        pictureBox5.Image = imageList1.Images[x];
                        x++;
                    }
                    else if (f == 24)
                    {
                        f = r.Next(26);
                        sc++;
                        pictureBox6.Image = imageList1.Images[f];
                        f++;
                    }
                    else if (g == 24)
                    {
                        g = r.Next(26);
                        sc++;
                        pictureBox7.Image = imageList1.Images[g];
                        g++;
                    }
                    else if (h == 24)
                    {
                        h = r.Next(26);
                        sc++;
                        pictureBox8.Image = imageList1.Images[h];
                        h++;
                    }
                    else if (i == 24)
                    {
                        i = r.Next(26);
                        sc++;
                        pictureBox9.Image = imageList1.Images[i];
                        i++;
                    }
                    else if (j == 24)
                    {
                        j = r.Next(26);
                        sc++;
                        pictureBox10.Image = imageList1.Images[j];
                        j++;
                    }
                    else
                    {
                        sc--;
                    }
                    break;
                case 'y':
                case 'Y':
                    if (a == 25)
                    {
                        a = r.Next(26);
                        sc++;
                        pictureBox1.Image = imageList1.Images[a];
                        a++;
                    }
                    else if (b == 25)
                    {
                        b = r.Next(26);
                        sc++;
                        pictureBox2.Image = imageList1.Images[b];
                        b++;
                    }
                    else if (c == 25)
                    {
                        c = r.Next(26);
                        sc++;
                        pictureBox3.Image = imageList1.Images[c];
                        c++;
                    }
                    else if (d == 25)
                    {
                        d = r.Next(26);
                        sc++;
                        pictureBox4.Image = imageList1.Images[d];
                        d++;
                    }
                    else if (x == 25)
                    {
                        x = r.Next(26);
                        sc++;
                        pictureBox5.Image = imageList1.Images[x];
                        x++;
                    }
                    else if (f == 25)
                    {
                        f = r.Next(26);
                        sc++;
                        pictureBox6.Image = imageList1.Images[f];
                        f++;
                    }
                    else if (g == 25)
                    {
                        g = r.Next(26);
                        sc++;
                        pictureBox7.Image = imageList1.Images[g];
                        g++;
                    }
                    else if (h == 25)
                    {
                        h = r.Next(26);
                        sc++;
                        pictureBox8.Image = imageList1.Images[h];
                        h++;
                    }
                    else if (i == 25)
                    {
                        i = r.Next(26);
                        sc++;
                        pictureBox9.Image = imageList1.Images[i];
                        i++;
                    }
                    else if (j == 25)
                    {
                        j = r.Next(26);
                        sc++;
                        pictureBox10.Image = imageList1.Images[j];
                        j++;
                    }
                    else
                    {
                        sc--;
                    }
                    break;
                case 'z':
                case 'Z':
                    if (a == 26)
                    {
                        a = r.Next(26);
                        sc++;
                        pictureBox1.Image = imageList1.Images[a];
                        a++;
                    }
                    else if (b == 26)
                    {
                        b = r.Next(26);
                        sc++;
                        pictureBox2.Image = imageList1.Images[b];
                        b++;
                    }
                    else if (c == 26)
                    {
                        c = r.Next(26);
                        sc++;
                        pictureBox3.Image = imageList1.Images[c];
                        c++;
                    }
                    else if (d == 26)
                    {
                        d = r.Next(26);
                        sc++;
                        pictureBox4.Image = imageList1.Images[d];
                        d++;
                    }
                    else if (x == 26)
                    {
                        x = r.Next(26);
                        sc++;
                        pictureBox5.Image = imageList1.Images[x];
                        x++;
                    }
                    else if (f == 26)
                    {
                        f = r.Next(26);
                        sc++;
                        pictureBox6.Image = imageList1.Images[f];
                        f++;
                    }
                    else if (g == 26)
                    {
                        g = r.Next(26);
                        sc++;
                        pictureBox7.Image = imageList1.Images[g];
                        g++;
                    }
                    else if (h == 26)
                    {
                        h = r.Next(26);
                        sc++;
                        pictureBox8.Image = imageList1.Images[h];
                        h++;
                    }
                    else if (i == 26)
                    {
                        i = r.Next(26);
                        sc++;
                        pictureBox9.Image = imageList1.Images[i];
                        i++;
                    }
                    else if (j == 26)
                    {
                        j = r.Next(26);
                        sc++;
                        pictureBox10.Image = imageList1.Images[j];
                        j++;
                    }
                    else
                    {
                        sc--;
                    }
                    break;
                default:
                    break;                  
            }
            label1.Text = sc.ToString();
        }
        int q = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            button2.Text = q.ToString();
            q--;
            if (q == -1)
            {
                timer1.Stop();
                timer2.Stop();
                MessageBox.Show("TIME UP!!!");
                button1.Enabled = true;
                richTextBox1.Text = " ";
                richTextBox1.Enabled = false;
                sc = 0;
                q = 10;
                label1.Text = "0";
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            a = r.Next(26);
            b = r.Next(26);
            c = r.Next(26);
            d = r.Next(26);
            x = r.Next(26);
            f = r.Next(26);
            g = r.Next(26);
            h = r.Next(26);
            i = r.Next(26);
            j = r.Next(26);
            pictureBox1.Image = imageList1.Images[a];
            pictureBox2.Image = imageList1.Images[b];
            pictureBox3.Image = imageList1.Images[c];
            pictureBox4.Image = imageList1.Images[d];
            pictureBox5.Image = imageList1.Images[x];
            pictureBox6.Image = imageList1.Images[f];
            pictureBox7.Image = imageList1.Images[g];
            pictureBox8.Image = imageList1.Images[h];
            pictureBox9.Image = imageList1.Images[i];
            pictureBox10.Image = imageList1.Images[j];
            a++;
            b++;
            c++;
            d++;
            x++;
            f++;
            g++;
            h++;
            i++;
            j++;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
 