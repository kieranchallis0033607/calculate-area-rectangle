﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int w, h;
                w = int.Parse(textBox1.Text);
                h = int.Parse(textBox2.Text);
                int area = w * h;
                textBox3.Text = area.ToString();
            }
            catch
            {
                MessageBox.Show("nah u wrong");
            }
        }
    }
}
