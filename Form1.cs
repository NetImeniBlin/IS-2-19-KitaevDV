using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        abstract class HWComponents
        {
            public string cost;
            public string year;
            Form1 f1 = new Form1();
            public HWComponents()
            {
                cost = "null";
                year = "null";
            }
            public virtual void Display()
            {
                f1.listBox1.Items.Add($"{cost}, {year}");
            }
        }

        class CPU: HWComponents
        {
            public string core;
            public string frequency;
            public string threads;
            Form1 f1 = new Form1();
            
            public override void Display()
            {
                f1.listBox1.Items.Add($"{cost}, {year}, {core}, {frequency}, {threads}");
                f1.listBox1.Refresh();
            }
        }

        class GPU: CPU
        {
            public string GPUfrequncy;
            public string perfomance;
            public string VRam;
            Form1 f1 = new Form1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CPU cp = new CPU();
            cp.cost = Convert.ToString(textBox1.Text);
            cp.year = Convert.ToString(textBox2.Text);
            cp.core = Convert.ToString(textBox3.Text);
            cp.frequency = Convert.ToString(textBox4.Text);
            cp.threads = Convert.ToString(textBox5.Text);
            cp.Display();
        }
    }
}
