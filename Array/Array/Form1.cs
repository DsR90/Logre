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
    public partial class Form1 : Form
    {
       
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dArrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Form2.f2_count == 0)
            {
                Form2 f2 = new Form2();
                f2.MdiParent = this;
                f2.Show();
            }
            
        }


        private void jaggedArrayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Form4.f4_count == 0)
            {
                Form4 f4 = new Form4();
                f4.MdiParent = this;
                f4.Show();
            }
        }

      

        private void dArrayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Form3.f3_count == 0)
            {
                Form3 f3 = new Form3();
                f3.MdiParent = this;
                f3.Show();


            }
        }
   
    }
}






