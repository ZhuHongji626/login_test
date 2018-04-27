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

namespace MailSystem
{
    public partial class draftform : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;port=3306;database=mailsystem;username=root;paswword=");
        public draftform()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string query = "delete from draft where sender='" + this.from.Text + "';";
            con.Open();
            MySqlCommand command = new MySqlCommand(query, con);
            MySqlDataReader reader;
            try
            {

                DialogResult result = MessageBox.Show("Confirm deletion", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                    }
                    MessageBox.Show("successfully deleted");
                    Close();
                }
                else if (result == DialogResult.No)
                {
                    //viewform f = new viewform();
                    //f.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
    }
}
