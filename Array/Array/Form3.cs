using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Array
{
    public partial class Form3 : Form
    {
        int r, c;
        int i = 0, j = 0;
        int[,] a;
        public static int f3_count = 0;
        public Form3()
        {
            InitializeComponent();
            f3_count++;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            r = Convert.ToInt16(textBox1.Text);
            c = Convert.ToInt16(textBox2.Text);
            a = new int[r, c];
            label1.Text = "Array is Created and has" + r.ToString() + " Rows and " + c.ToString() + "colomns";
            groupBox1.Enabled = false;
            groupBox2.Enabled = true;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            a[i,j] = Convert.ToInt16(textBox3.Text);
            j++;
            if (j >= c)
            {

                i++;
                j = 0;
            }
            label4.Text = "Row " + (i + 1).ToString();
            label5.Text = "Col " + (j + 1).ToString();
            textBox3.Clear();
            textBox3.Focus();
            if (i >= r)
            {
                label1.Text = "Array is Filled ";
                groupBox2.Enabled = false;
                groupBox3.Enabled = true;
                label4.Text = "";
                label5.Text = "";

            }
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            f3_count = 0;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = "";
            int min, max, sum, avg;
            sum = 0;
            min = a[0, 0];
            max = a[0, 0];
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    label6.Text += "    " + a[i, j].ToString() + "   ";
                    sum += a[i, j];
                    if (a[i, j] > max)
                    {
                        max = a[i, j];

                    }
                    if (a[i, j] < min)
                    {
                        min = a[i, j];

                    }
                }
                label6.Text += "\n\n";
            }
            avg = sum / (r * c);
            label27.Text = min.ToString();
            label28.Text = max.ToString();
            label29.Text = sum.ToString();
            label30.Text = avg.ToString();
            //process row summary
            int[] rmin = new int[r];
            int[] rmax = new int[r];
            int[] rsum = new int[r];
            int[] ravg = new int[r];

            for (int i = 0; i < r; i++)
            {
                rsum[i] = 0;
                rmin[i] = a[i, 0];
                rmax[i] = a[i, 0];
            }

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if(a[i,j]>rmax[i])
                    {
                        rmax[i] = a[i, j];
                                               
                    }
                    if(a[i,j]<rmin[i])
                    {
                        rmin[i] = a[i, j];
                    }
                    rsum[i]+=a[i,j];
                }

                ravg[i] = rsum[i] / c;
            }
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";
            label18.Text = "";
            for (int i = 0; i < r; i++)
            {
                label15.Text += rmin[i].ToString() + "\n\n";
                label16.Text += rmax[i].ToString() + "\n\n";
                label17.Text += rsum[i].ToString() + "\n\n";
                label18.Text += ravg[i].ToString() + "\n\n";
            }

            //process colomn summary
            int[] cmin = new int[c];
            int[] cmax = new int[c];
            int[] csum = new int[c];
            int[] cavg = new int[c];

            for (int j = 0; j < c; j++)
            {
                csum[j] = 0;
                cmin[j] = a[0, j];
                cmax[j] = a[0, j];
            }
            for (int j = 0; j < c; j++)
            {
                for (int i = 0; i < r; i++)
                {
                    if (a[i, j] > cmax[j])
                    {
                        cmax[j] = a[i, j];

                    }
                    if (a[i, j] < cmin[j])
                    {
                        cmin[j] = a[i, j];
                    }
                    csum[j] += a[i, j];
                }

                cavg[j] = csum[j] / r;
            }
            label19.Text = "";
            label20.Text = "";
            label21.Text = "";
            label22.Text = "";
            for (int j = 0; j <c; j++)
            {
                label19.Text += "    " + cmin[j].ToString() + "   ";
                label20.Text += "    " + cmax[j].ToString() + "   ";
                label21.Text += "    " + csum[j].ToString() + "   ";
                label22.Text += "    " + cavg[j].ToString() + "   ";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    int t = a[i, j];
                    a[i, j] = a[j, i];
                    a[j, i] = t;
                }
            }
        }
    }
}
