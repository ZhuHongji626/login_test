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
    public partial class Outbox : UserControl
    {
        MySqlConnection con = new MySqlConnection("server=localhost;port=3306;database=mailapp;username=root;paswword=");
        private static Outbox _instance;
        public static Outbox Instance {
            get
            { 
             if(_instance==null)
                _instance = new Outbox();
                return _instance;
                    
            }
            
        }

        public Outbox()
        {
            InitializeComponent();
            viewdet();
            datagrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        private void SentMails_Load(object sender, EventArgs e)
        {

        }
        public void viewdet() {
            try {
                string loggernow = Login.logger;
                con.Open();
                //where sender = '" + loggernow + "'
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT sender,recipient,subject,message,attachment FROM outbox ", con);
                DataTable data = new DataTable();
                adapter.Fill(data);
                datagrid.DataSource = data;
                con.Close();
            }
            catch(Exception e){
                MessageBox.Show(e.Message);
            }
        }


        private void datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //viewdet();
            //Outbox r = new Outbox();
            outbxform v = new outbxform();
            v.Show();
            v.subject.Text = this.datagrid.CurrentRow.Cells[2].Value.ToString();
            v.from.Text = this.datagrid.CurrentRow.Cells[0].Value.ToString();
            v.to.Text = this.datagrid.CurrentRow.Cells[1].Value.ToString();
            v.message.Text = this.datagrid.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
