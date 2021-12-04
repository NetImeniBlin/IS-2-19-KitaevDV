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

namespace IS_2_19_KitaevDV
{
    public partial class Z2 : Form
    {
        public Z2()
        {
            InitializeComponent();
        }
        MySqlConnection conn;

        private void Form2_Load(object sender, EventArgs e)
        {
            string connstr = "server=caseum.ru;port=33333;user=test_user;database=db_test;password=test_pass;";
            conn = new MySqlConnection(connstr);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //проверка соединения
            try
            {
                conn.Open();
                MessageBox.Show("Нет проблем :U");
                conn.Close();
            }
            catch (Exception osh)
            {
                MessageBox.Show("Проблема" + osh);
                conn.Close();
            }
        }
    }
}
