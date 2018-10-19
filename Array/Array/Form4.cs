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
    public partial class Form4 : Form
    {
        int count = 0;
        int r;
        int[][] a;
        int i = 0;
        int j = 0;
        int x = 0, y = 0;
        public static int f4_count = 0;
        public Form4()
        {
            InitializeComponent();
            f4_count++;
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            f4_count = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            r = Convert.ToInt16(textBox1.Text);
            a = new int[r][];
            label31.Text = " Array has " + r.ToString() + " Rows";
            label31.Text += "\n lower Bound of Rows=" + a.GetLowerBound(0).ToString();
            label31.Text += "\n Upper Bound of Rows=" + a.GetUpperBound(0).ToString();
            groupBox1.Enabled = false;
            groupBox5.Enabled = true;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;
            groupBox5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int c;
            c = Convert.ToInt16(textBox2.Text);
            a[i] = new int[c];
            i++;
            label3.Text = "# col in Row :" + (i + 1).ToString();
            textBox2.Clear();
            textBox2.Focus();
            if (i >= r)
            {

                label31.Text = "All rows are Define";
                label3.Text = "";
                groupBox2.Enabled = true;
                groupBox5.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a[x][y] = Convert.ToInt16(textBox3.Text);
            y++;
            if (y > a[x].GetUpperBound(0))
            {
                x++;
                y = 0;
            }
            label4.Text = "Row " + (x + 1).ToString();
            label5.Text = "col " + (y + 1).ToString();
            textBox3.Clear();
            textBox3.Focus();
            if (x >= r)
            {
                groupBox2.Enabled = false;
                label31.Text = " All Cells Have Value";
                groupBox3.Enabled = true;
                label4.Text = "";
                label5.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int min, max, sum;
            float avg;
            sum = 0;
            min = a[0][0];
            max = a[0][0];
            label31.Text = "Summary Is Displayed";
            label6.Text = "";
            for (int i = 0; i <= a.GetUpperBound(0); i++)
            {

                for (int j = 0; j <= a[i].GetUpperBound(0); j++)
                {
                    count++;
                    sum += a[i][j];
                    if (min > a[i][j])
                    {
                        min = a[i][j];

                    }
                    if (max < a[i][j])
                    {
                        max = a[i][j];
                    }

                    label6.Text += "  " + a[i][j].ToString() + "     ";
                }

                label6.Text += "\n\n";

            }
            avg = (float)sum / count;
            label27.Text = min.ToString();
            label28.Text = max.ToString();
            label29.Text = sum.ToString();
            label30.Text = avg.ToString();

            // process row summary
            int[] rmin = new int[r];
            int[] rmax = new int[r];
            int[] rsum = new int[r];
            float[] ravg = new float[r];
            for (int i = 0; i <= a.GetUpperBound(0); i++)
            {
                rsum[i] = 0;
                rmin[i] = a[i][0];
                rmax[i] = a[i][0];
            }
            for (int i = 0; i <= a.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= a[i].GetUpperBound(0); j++)
                {
                    rsum[i] += a[i][j];
                    if (rmin[i] > a[i][j])
                    {
                        rmin[i] = a[i][j];
                    }
                    if (rmax[i] < a[i][j])
                    {
                        rmax[i] = a[i][j];
                    }
                }
                ravg[i] = (float)rsum[i] / (1 + a[i].GetUpperBound(0));
            }
            for (int i = 0; i <= a.GetUpperBound(0); i++)
            {
                label15.Text += rmin[i].ToString() + "\n\n";
                label16.Text += rmax[i].ToString() + "\n\n";
                label17.Text += rsum[i].ToString() + "\n\n";
                label18.Text += ravg[i].ToString() + "\n\n";
            }
            //colomn summary

           
        }

    }
}