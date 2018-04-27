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
    public partial class admin : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;port=3306;database=mailsystem;username=root;password=");
        public admin()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(user.Text) || string.IsNullOrEmpty(pass.Text)) { MessageBox.Show("Kindly Provide the Credentials..!"); }
            string query = "select username, password from accounts where username='"+user.Text+"' and password='"+pass.Text+"'";
            con.Open();
             MySqlCommand command = new MySqlCommand(query, con);
                DataTable dt = new DataTable();
                MySqlDataAdapter ad = new MySqlDataAdapter(command);
                ad.Fill(dt);
                if (dt.Rows.Count > 0) {
                    MessageBox.Show("yes....");
                    /*try {
                        if (!panel4.Controls.Contains(accounts.Instance))
                        {
                            panel4.Controls.Add(accounts.Instance);
                            accounts.Instance.Dock = DockStyle.Fill;
                            accounts.Instance.BringToFront();
                        }
                        else
                            accounts.Instance.BringToFront();
                    }
                    catch (Exception x) { MessageBox.Show("lll"); }*/
                }
                con.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            user.Text = "";
            pass.Text = "";
            Close();
        }
    }
}
