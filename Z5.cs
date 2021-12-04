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
            //объявления пременной для подключения к бд
            Podklvkl conn = new Podklvkl();
            MySqlConnection connn = new MySqlConnection(conn.Vklpodkl);
            string fio = textBox1.Text;
            string time = textBox2.Text;
            //добавления данных в таблицу
            string sql = $"INSERT INTO t_PraktStud (fioStud, datetimeStud)  VALUES ('{fio}','{time}');";
            int hm = 0;
            try
            {
                connn.Open();
                MySqlCommand command1 = new MySqlCommand(sql, connn);
                hm = command1.ExecuteNonQuery();
            }
            catch
            {
                //ошибка в случае если время указано в не коректном формате
                MessageBox.Show("так не получается");
            }
            finally
            {
                connn.Close();
                if (hm != 0)
                {
                    MessageBox.Show("ну типо");
                }
            }
        }
    }
}
