using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MailSystem
{
    public partial class accounts : UserControl
    {
        private static accounts _instance;
        public static accounts Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new accounts();
                return _instance;

            }

        }

        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;database=mailsystem;username=root;password=");
        public accounts()
        {
            InitializeComponent();
            view();
        }
        public void view()
        {
            try
            {
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT*FROM accounts", connection);
                DataTable data = new DataTable();
                adapter.Fill(data);
                gridview.DataSource = data;
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            
        }
    }
}
