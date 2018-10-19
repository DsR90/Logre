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
    public partial class Form2 : Form
      
    {
        int[] a;
        int n;
        int i = 0;
        public static int f2_count = 0;
        public Form2()
        {
            InitializeComponent();
            f2_count++;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            groupBox2.Hide();
            groupBox3.Hide();
           
          
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            i = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt16(textBox1.Text);
            a = new int[n];
            label12.Text = "Array is Created of Size " + a.Length.ToString();
            groupBox2.Show();
            groupBox2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
              a[i] = Convert.ToInt16(textBox2.Text);
            i++;
            if (i <= a.GetUpperBound(0))
            {
                textBox2.Clear();
                textBox2.Focus();
                label2.Text = " For Element:" + (i + 1).ToString();
            }
            else
            {
                label12.Text = "Array is Filled";
                label2.Text = "";
                textBox2.Clear();
                groupBox2.Enabled = false;
                groupBox3.Show();
                groupBox3.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            label12.Text = "Summary Is Displayed";
            long min, max, sum, avg;
            sum = 0;
            max = min = a[0];
            for (int i = 0; i < n; i++)
            {
                sum += a[i];
                if (a[i] > max)
                {
                    max = a[i];

                }
                if (a[i] < min)
                {
                    min = a[i];

                }


            }
            avg = sum / n;

            label8.Text = min.ToString();
            label9.Text = max.ToString();
            label10.Text = sum.ToString();
            label11.Text = avg.ToString();
            label3.Text = "";
            for (int i = 0; i < a.Length; i++)
            {
                label3.Text += " " + a[i].ToString() + "  ";
            }
           
        }

        private void dArrayToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            f2_count = 0;
        }
        
    }
}
