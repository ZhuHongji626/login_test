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
    public partial class Draft : UserControl
    {
        MySqlConnection con = new MySqlConnection("server=localhost;port=3306;database=mailapp;username=root;password=");
        private static Draft _instance;
        public static Draft Instance {
            get {
                if (_instance == null)
                    _instance = new Draft();
                return _instance;
            }
        }
        public Draft()
        {
            InitializeComponent();
            view();
        }

        public void view()
        {
            try
            {
                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT*FROM draft", con);
                DataTable data = new DataTable();
                adapter.Fill(data);
                datagrid.DataSource = data;
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
        }

        private void datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            draftform v = new draftform();
            v.Show();
            v.subject.Text = this.datagrid.CurrentRow.Cells[3].Value.ToString();
            v.from.Text = this.datagrid.CurrentRow.Cells[1].Value.ToString();
            v.to.Text = this.datagrid.CurrentRow.Cells[2].Value.ToString();
            v.message.Text = this.datagrid.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
