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
             string connstr = "server=caseum.ru;port=33333;user=test_user;database=db_test;password=test_pass;";
             conn = new MySqlConnection(connstr);
        }

    }
}
