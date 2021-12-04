using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;
using MySql.Data.MySqlClient;

namespace IS_2_19_KitaevDV
{
    public partial class Z4 : Form
    {
        public Z4()
        {
            InitializeComponent();
        }

        private void Z4_Load(object sender, EventArgs e)
        {
            //объявление переменной для подключения к бд
            Podklvkl conn = new Podklvkl();
            MySqlConnection connn = new MySqlConnection(conn.Vklpodkl);
            //поля для вывода данных из бд
            string sql = $"SELECT idStud, fioStud, drStud FROM t_datetime";
            //запрос на вывод данных в датагрид
            try
            {
                connn.Open();
                MessageBox.Show("Подключение");
                MySqlDataAdapter IDataAdapter = new MySqlDataAdapter(sql, connn);
                DataSet dataset = new DataSet();
                IDataAdapter.Fill(dataset);
                dataGridView1.DataSource = dataset.Tables[0];
                connn.Close();
            }
            catch (Exception oi)
            {
                MessageBox.Show("ProblemA" + oi);
                connn.Close();
            }
        }
        string id_rows5 = "0";
        //вывод данных в датагрид
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!e.RowIndex.Equals(-1) && !e.ColumnIndex.Equals(-1) && e.Button.Equals(MouseButtons.Left))
            {
                dataGridView1.CurrentCell = dataGridView1[e.ColumnIndex, e.RowIndex];
                dataGridView1.CurrentRow.Selected = true;
                string row5;
                row5 = dataGridView1.SelectedCells[0].RowIndex.ToString();

                id_rows5 = dataGridView1.Rows[Convert.ToInt32(row5)].Cells[2].Value.ToString();
                DateTime x = DateTime.Today;
                DateTime y = Convert.ToDateTime(dataGridView1.Rows[Convert.ToInt32(row5)].Cells[2].Value.ToString());
                string resultDays = (x - y).ToString();
                MessageBox.Show("Со дня рождения прошло " + resultDays.Substring(0, resultDays.Length - 9) + " дней");
            }
        }
    }
}
