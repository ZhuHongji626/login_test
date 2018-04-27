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
    public partial class Login : Form
       
    {
        public static string logger;
        MySqlConnection con = new MySqlConnection("server=localhost;port=3306;database=mailapp;username=root;password=");
        public Login()
        {
            InitializeComponent();
            logger = txtuser.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            HomeFrame home = new HomeFrame();
            home.Show();
            //try {
            //    //string name = txtuser.Text, pass = txtpass.Text;
            //    string query = "SELECT username,password from accounts WHERE username='" + txtuser.Text + "'and password='" + txtpass.Text + "'";
            //    con.Open();
            //    MySqlCommand command = new MySqlCommand(query, con);
            //    DataTable dt = new DataTable();
            //    MySqlDataAdapter ad = new MySqlDataAdapter(command);
            //    ad.Fill(dt);
            //    if (dt.Rows.Count > 0)
            //    {
            //        string query2 = ("UPDATE session SET username='" + txtuser.Text + "' and password='" + txtpass.Text + "' WHERE id='" + 1 + "'");
            //        MySqlCommand cmd = new MySqlCommand(query2, con);
            //        if (cmd.ExecuteNonQuery() > 0)
            //        {
            //            MessageBox.Show("Successfully Logged in...");
            //            Hide();
            //            HomeFrame home = new HomeFrame();
            //            home.Show();
            //        }

                    /*try {
                        string query2 = ("UPDATE session SET username='" + txtuser.Text + "' and password='" + txtpass.Text + "' WHERE id='" + 1 + "'");
                        MySqlCommand cmd = new MySqlCommand(query2, con);
                        if (cmd.ExecuteNonQuery()>0)
                        {
                            MessageBox.Show("Successfully Logged in...");
                            Hide();
                            HomeFrame home = new HomeFrame();
                            home.Show();
                        }
                    }
                    catch (Exception c) { MessageBox.Show(c.Message); }*/
                    //MessageBox.Show("Successfully Loged in...");
            //    }
            //    else {
            //        MessageBox.Show("INVALID Username and Password, Try Again!");
            //        txtpass.Text = "";
            //    }
            //    con.Close();
            //}
            //catch (Exception v) { MessageBox.Show(v.Message); }
            /*if (string.IsNullOrEmpty(txtuser.Text) || string.IsNullOrEmpty(txtpass.Text)) {
                MessageBox.Show("provide UserName and Password.");     
            }
            else
            {
                string name = txtuser.Text, pass = txtpass.Text;
                string query = "SELECT username,password from accounts WHERE username='"+name+"'and password='"+pass+"'";
                con.Open();
                MySqlCommand command = new MySqlCommand(query,con);
                DataTable dt = new DataTable();
                MySqlDataAdapter ad = new MySqlDataAdapter(command);
                ad.Fill(dt);
                try {
                    //if (command.ExecuteNonQuery() == 1)
                    if(dt.Rows.Count>0)
                    {
                        string query2 = "UPDATE session SET username='"+name+"' and password='"+pass+"' WHERE id='"+1+"'";
                        MySqlCommand cmd = new MySqlCommand(query2, con);
                        try {
                            if (cmd.ExecuteNonQuery() == 1) {
                                MessageBox.Show("Successfully Loged in...");
                                Hide();
                                HomeFrame home = new HomeFrame();
                                home.Show();
                            }
                        }
                        catch (Exception exx) { 
                            MessageBox.Show(exx.Message); }
                        
                    }
                    else {
                        MessageBox.Show("INVALID Username and Password, Try Again!");
                    }

                }
                catch(Exception exx){
                    MessageBox.Show(exx.Message);
                }
                con.Close();
            }*/
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            CreateAccount account = new CreateAccount();
            account.Show();
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {
            //txtuser.Text = "email@server.com";
        }
    }
}
