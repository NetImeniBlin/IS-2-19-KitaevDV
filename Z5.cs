using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ClassLibrary1;

namespace IS_2_19_KitaevDV
{
    public partial class Z5 : Form
    {
        public Z5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Podklvkl conn = new Podklvkl();
            MySqlConnection connn = new MySqlConnection(conn.Vklpodkl);
            string fio = textBox1.Text;
            string time = textBox2.Text;
            string sql = $"INSERT INTO t_PraktStud (fioStud, datetimeStud)  VALUES ('{fio}','{time}');";
            
        }
    }
}
