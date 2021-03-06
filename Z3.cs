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
    public partial class Z3 : Form
    {
        public Z3()
        {
            InitializeComponent();
        }

        MySqlConnection conn;

        private void Form3_Load(object sender, EventArgs e)
        {
             //объявление переменной для подключения к бд
             Program.Podkl conn = new Program.Podkl();
             MySqlConnection connn = new MySqlConnection(conn.Connstring);
            //поля для вывода данных из бд
             string sql = $"SELECT id, fio, theme_kurs FROM t_stud";
            //запрос на вывод данных
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
             catch (Exception osh)
             {
                 MessageBox.Show("Problem" + osh);
                 connn.Close();
             }

        }
        //вывод данных в датагрид
         string id_rows = "0";

         private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
         {
             if (!e.RowIndex.Equals(-1) && !e.ColumnIndex.Equals(-1) && e.Button.Equals(MouseButtons.Left))
             {
                 dataGridView1.CurrentCell = dataGridView1[e.ColumnIndex, e.RowIndex];
                 dataGridView1.CurrentRow.Selected = true;
                 string row;
                 row = dataGridView1.SelectedCells[0].RowIndex.ToString();
                 id_rows = dataGridView1.Rows[Convert.ToInt32(row)].Cells[1].Value.ToString();
                 MessageBox.Show(id_rows);
             }
         }

    }
}
