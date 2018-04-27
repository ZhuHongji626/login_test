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
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace MailSystem
{
    public partial class CreateAccount : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;port=3306;database=mailapp;username=root;password=");
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Hide();
            Login log = new Login();
            log.Show();
        }
        public static bool isValidEmail(string email) {                                                                                                                                                                                                                                                                                             
            Regex regex= new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" + @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" + @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            Match match = regex.Match(email);
            if (match.Success)
                return true;
            else
                return false;
        
        }
        public static bool validateName(string fname) {
            Regex r = new Regex("[a-zA-Z]");
            Match ma = r.Match(fname);
            if (ma.Success)
                return true;
            else
                return false;
        }
        public static bool vaName(string lname)
        {
            Regex r = new Regex("[a-zA-Z]");
            Match ma = r.Match(lname);
            if (ma.Success)
                return true;
            else
                return false;
        }
       
        private void btncreate_Click(object sender, EventArgs e)
        {
            string ee=email.Text;
            string eee=fname.Text;
            string eeee = lname.Text;
            if (string.IsNullOrEmpty(email.Text) || string.IsNullOrEmpty(fname.Text) || string.IsNullOrEmpty(lname.Text)||
                string.IsNullOrEmpty(pass.Text) || string.IsNullOrEmpty(passconfirm.Text))
            {
                MessageBox.Show("Kindly All Fields Are Required","Notice",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }
                //validating mail contact
            else if (!(isValidEmail(ee))) { MessageBox.Show("The Email Format is Invalid..! Try Again"); }
            else if (!(validateName(eee))) { MessageBox.Show("ERROR..! Kindly Provide a Valid FirstName"); fname.Text = ""; }
            else if (!(vaName(eeee))) { MessageBox.Show("ERROR..! Kindly Provide a Valid LastName"); lname.Text = ""; }
            else if(!(pass.Text.Equals(passconfirm.Text))){
                MessageBox.Show("SORRY!!..PASSWORD DO NOT MATCH", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                pass.Text = string.Empty;
                passconfirm.Text = string.Empty;
            }
            else{
            string sqlquery = "INSERT INTO accounts(username,fname,lname,password) VALUES('"+email.Text+"','"+fname.Text+"','"+lname.Text+"','"+pass.Text+"')";
            con.Open();
            MySqlCommand command = new MySqlCommand(sqlquery,con);
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Account Created Successfully...");
                    email.Text = string.Empty;
                    fname.Text = string.Empty;
                    lname.Text = string.Empty;
                    pass.Text = string.Empty;
                    passconfirm.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Account Not Created");
                }
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        }
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
            Login lg = new Login();
            lg.Show();
        }
        private void lg_Click(object sender, EventArgs e)
        {
            this.Close();
            Login lg = new Login();
            lg.Show();
        }
    }
}
