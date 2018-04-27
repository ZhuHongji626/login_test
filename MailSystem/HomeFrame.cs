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
    public partial class HomeFrame : Form
    {
       MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;database=mailsystem;username=root;password=");
       /*private static home _instance;
       public static home Instance {
           get {
               if (_instance == null)
                   _instance = new home();
               return _instance;
           }
       }*/
        public HomeFrame()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
           //CreateNewMail c = new CreateNewMail();
            //c.Show();
            if (!panel4.Controls.Contains(ComposeMail.Instance))
            {
                panel4.Controls.Add(ComposeMail.Instance);
                ComposeMail.Instance.Dock = DockStyle.Fill;
                ComposeMail.Instance.BringToFront();
            }
            else 
                ComposeMail.Instance.BringToFront();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (!panel4.Controls.Contains(Outbox.Instance))
            {
                panel4.Controls.Add(Outbox.Instance);
                Outbox.Instance.Dock = DockStyle.Fill;
                Outbox.Instance.BringToFront();
            }
            else
                Outbox.Instance.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!panel4.Controls.Contains(Draft.Instance))
            {
                panel4.Controls.Add(Draft.Instance);
                Draft.Instance.Dock = DockStyle.Fill;
                Draft.Instance.BringToFront();
            }
            else
                Draft.Instance.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!panel4.Controls.Contains(Trash.Instance))
            {
                panel4.Controls.Add(Trash.Instance);
                Trash.Instance.Dock = DockStyle.Fill;
                Trash.Instance.BringToFront();
            }
            else
                Trash.Instance.BringToFront();
        }
        private void home_Click(object sender, EventArgs e)
        {
            if (!panel4.Controls.Contains(backhome.Instance))
            {
                panel4.Controls.Add(backhome.Instance);
                backhome.Instance.Dock = DockStyle.Fill;
                backhome.Instance.BringToFront();
            }
            else
                backhome.Instance.BringToFront();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.FlatAppearance.BorderSize = 1;
            button2.FlatAppearance.BorderColor = Color.Red;
        }
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.FlatAppearance.BorderSize = 1;
            button2.FlatAppearance.BorderColor = Color.Red;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Want To Logout?..", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                this.Close();
                Login log = new Login();
                log.Show();
            }
            else if (result == DialogResult.No)
            { }
        }

        private void accounts_MouseHover(object sender, EventArgs e)
        {
            account.BackColor = Color.Red;
        }
        private void accounts_MouseEnter(object sender, EventArgs e)
        {
            //accounts.UseVisualStyleBackColor = false;
            account.BackColor = Color.GhostWhite;
        }
        private void accounts_MouseLeave(object sender, EventArgs e)
        {
           // accounts.UseVisualStyleBackColor = true;
        }

        private void account_Click(object sender, EventArgs e)
        {
            admin a = new admin();
            a.Show();
            /*if (!panel4.Controls.Contains(accounts.Instance))
               {
                   panel4.Controls.Add(accounts.Instance);
                   accounts.Instance.Dock = DockStyle.Fill;
                   accounts.Instance.BringToFront();
               }
               else
                   accounts.Instance.BringToFront(); */ 
        }

        private void time_Click(object sender, EventArgs e)
        {
            timer tm = new timer();
            tm.Show();
        }

        
    }
}
