﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_2_19_KitaevDV
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Z1 Form1 = new Z1();
            Form1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Z2 Form2 = new Z2();
            Form2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Z3 z3 = new Z3();
            z3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Z4 z4 = new Z4();
            z4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Z5 z5 = new Z5();
            z5.ShowDialog();
        }
    }
}
