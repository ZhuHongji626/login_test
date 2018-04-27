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
    public partial class trashform : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;port=3306;database=mailsystem;username=root;password=");
        public trashform()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string query = "delete from trash where sender='" + this.from.Text + "' and message='" + this.message.Text + "'";
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


                    MessageBox.Show("Cleared");
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
