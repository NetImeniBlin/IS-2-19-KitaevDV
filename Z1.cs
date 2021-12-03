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
    public partial class Z1 : Form
    {
        public Z1()
        {
            InitializeComponent();
        }

        abstract class HWComponents<o>
        {
            protected string cost;
            protected string year;
            public HWComponents(string Cost, string Year)
            {
                cost = Cost;
                year = Year;
            }
            public abstract void Display(ListBox listBox1);
            
        }

        class CPU: HWComponents<string>
        {
            public string core1;
            public string frequency1;
            public string threads1;
            public CPU(string Cost, string Year, string Core, string Frequency, string Threads)
                :base(Cost, Year)
            {
                core = Core;
                frequency = Frequency;
                threads = Threads;
            }
                  public string core { get { return core1; } set { core1= value;}}
                  public string frequency { get { return frequency1; } set { frequency1 = value; } }
                  public string threads { get { return threads1; } set { threads1 = value; } }
            public override void Display(ListBox listBox1)
            {
                listBox1.Items.Add($"цена {cost}, год выпуска {year}, количество ядер {core}, частота {frequency}, количество потоков {threads}");
            }
        }

        class GPU: HWComponents<string>
        {
            public string GPUfrequncy1;
            public string perfomance1;
            public string VRam1;
            public GPU(string Cost, string Year, string gPUfrequncy, string Perfomance, string vRam)
                :base(Cost, Year)
            {
                GPUfrequncy = gPUfrequncy;
                perfomance = Perfomance;
                VRam = vRam;
            }
                  public string GPUfrequncy { get { return GPUfrequncy1; } set { GPUfrequncy1= value;}}
                  public string perfomance { get { return perfomance1; } set { perfomance1 = value; } }
                  public string VRam { get { return VRam1; } set { VRam1 = value; } }
            public override void Display(ListBox listBox1)
            {
                listBox1.Items.Add($"цена {cost}, год выпуска {year}, частоа ГП {GPUfrequncy}, производительность {perfomance}, объём видео памяти {VRam}");
            }
    }

        private void button1_Click(object sender, EventArgs e)
        {
            string cost = Convert.ToString(textBox1.Text);
            string year = Convert.ToString(textBox2.Text);
            string frequency = Convert.ToString(textBox3.Text);
            string core = Convert.ToString(textBox4.Text);
            string threads = Convert.ToString(textBox5.Text);
            CPU cp = new CPU(cost, year, frequency, core, threads);
            cp.Display(listBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cost = Convert.ToString(textBox1.Text);
            string year = Convert.ToString(textBox2.Text);
            string GPUfrequncy = Convert.ToString(textBox3.Text);
            string perfomance = Convert.ToString(textBox4.Text);
            string VRam = Convert.ToString(textBox5.Text);
            GPU gp = new GPU(cost, year, GPUfrequncy, perfomance, VRam);
            gp.Display(listBox1);
        }
    }
}
