﻿using System;
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

        private void btnHello_Click(object sender, EventArgs e)
        {
            lblHello.Text = "Привет, Мир";
        }

        private void таблицаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2  df= new Form2();
            df.ShowDialog();
        }

        private void присоединенныйВариантToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 bf = new Form3();
            bf.ShowDialog();
        }
    }
}
