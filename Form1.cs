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
            public HWComponents(string cost, string year)
            {
                cost = "null";
                year = "null";
            }
            public virtual void Display()
            {
                listBox1.Items.Add("");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
