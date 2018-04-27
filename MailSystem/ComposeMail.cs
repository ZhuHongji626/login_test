using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using MySql.Data.MySqlClient;

namespace MailSystem
{
    public partial class ComposeMail : UserControl
    {
        MySqlConnection con = new MySqlConnection("server=localhost;port=3306;database=mailapp;username=root;password=");
        private static ComposeMail _instance;
        public static ComposeMail Instance {
            get {
                if(_instance==null)
                _instance = new ComposeMail();
                return _instance;
            }
        }

        public ComposeMail()
        {
            InitializeComponent();
        }
        private void btnsend_Click(object sender, EventArgs e)
        {
            if (from.Text == "") { MessageBox.Show("Kindly Provide Senders' Address.");
                //error1.Text = "sender's address required"; 
            }
            else if (to.Text == "") { MessageBox.Show("Kindly Provide Recipients' Address."); }
            //else if (from.Text == ""||to.Text == "") { MessageBox.Show("Kindly Provide Sender & Recipients' Address."); }
            else
            {
                try
                {
                    MailMessage mail = new MailMessage(from.Text, to.Text, subject.Text, message.Text);
                    SmtpClient client = new SmtpClient(server.Text);
                    client.Port = 587;
                    client.UseDefaultCredentials = false;
                    client.EnableSsl = true;
                    //for sending mail to multiple recipients
                    string t = to.Text;
                    string[] r = t.Split(',');
                    for (int i = 0; i < r.Count(); i++)
                    {
                        mail.Bcc.Add(r[i]);
                        // mail.CC.Add(r[i]);
                    }
                    //end

                    if (attach.Text != "")
                    {
                        mail.Attachments.Add(new Attachment(attach.Text));
                    }

                    client.Credentials = new System.Net.NetworkCredential(from.Text, password.Text);
                    client.Send(mail);
                    MessageBox.Show("Mail Sent Successfully...");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(" " + ex.Message);

                }
                finally
                {
                    String sql = "INSERT INTO outbox (sender,recipient,subject,message,attachment,time,smtp) VALUES ('" + this.from.Text + "','" + this.to.Text + "','" + this.subject.Text + "','" + this.message.Text + "','" + this.attach.Text + "','" + this.scheduletime.Text + "','" + this.server.Text + "')";
                    con.Open();
                    MySqlCommand command = new MySqlCommand(sql, con);
                    try
                    {
                        if (command.ExecuteNonQuery() == 1)
                        {
                            //MessageBox.Show("saved");
                            from.Text = String.Empty;
                            password.Text = String.Empty;
                            to.Text = String.Empty;
                            subject.Text = String.Empty;
                            message.Text = String.Empty;
                            attach.Text = String.Empty;
                            scheduletime.Text = String.Empty;
                            server.Text = String.Empty;
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

        private void btncancel_Click(object sender, EventArgs e)
        {
            //from.Text = String.Empty;
            from.Text ="";
            to.Text = String.Empty;
            subject.Text = String.Empty;
            message.Text = String.Empty;
            attach.Text = String.Empty;
            server.Text = String.Empty;
            password.Text = String.Empty;
        }

        private void attch_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                attach.Text = openFileDialog1.FileName.ToString();
            }
        }
        int duration = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            duration--;
            timecount.Text = duration.ToString();
            if (duration == 0)
            {
                timer1.Stop();
                try {
                    if (from.Text == "")
                    {
                        MessageBox.Show("Kindly Provide Senders' Address."); 
                    }
                    else if (to.Text == "") { MessageBox.Show("Kindly Provide Recipients' Address."); }
                    else
                    {
                        //duration--;
                        //timecount.Text = duration.ToString();
                        //if (duration == 0)
                        //{
                        //timer1.Stop();
                        try
                        {
                            MailMessage mail = new MailMessage(from.Text, to.Text, subject.Text, message.Text);
                            SmtpClient client = new SmtpClient(server.Text);
                            client.Port = 587;
                            client.UseDefaultCredentials = false;
                            client.EnableSsl = true;
                            //for sending mail to multiple recipients
                            string t = to.Text;
                            string[] r = t.Split(',');
                            for (int i = 0; i < r.Count(); i++)
                            {
                                mail.Bcc.Add(r[i]);
                                // mail.CC.Add(r[i]);
                            }
                            //end

                            if (attach.Text != "")
                            {
                                mail.Attachments.Add(new Attachment(attach.Text));
                            }

                            client.Credentials = new System.Net.NetworkCredential(from.Text, password.Text);
                            client.Send(mail);
                            MessageBox.Show("Mail Sent Successfully...");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(" " + ex.Message);

                        }
                        finally
                        {
                            String sql = "INSERT INTO outbox (sender,recipient,subject,message,attachment,time,smtp) VALUES ('" + this.from.Text + "','" + this.to.Text + "','" + this.subject.Text + "','" + this.message.Text + "','" + this.attach.Text + "','" + this.scheduletime.Text + "','" + this.server.Text + "')";
                            con.Open();
                            MySqlCommand command = new MySqlCommand(sql, con);
                            try
                            {
                                if (command.ExecuteNonQuery() == 1)
                                {
                                    //MessageBox.Show("saved");
                                    from.Text = String.Empty;
                                    password.Text = String.Empty;
                                    to.Text = String.Empty;
                                    subject.Text = String.Empty;
                                    message.Text = String.Empty;
                                    attach.Text = String.Empty;
                                    scheduletime.Text = String.Empty;
                                    server.Text = String.Empty;
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
                catch (Exception xe) { MessageBox.Show(xe.Message); }
            }
        }
        
       /* private void timer1_Tick(object sender, EventArgs e)
        {
            int duration;
            duration = int.Parse(txtDuration.Text);
            duration--;
            timecount.Text = duration.ToString();
            if (duration == 0)
            {
                timer1.Stop();
                try
                {
                    if (from.Text == "")
                    {
                        MessageBox.Show("Kindly Provide Senders' Address.");
                    }
                    else if (to.Text == "") { MessageBox.Show("Kindly Provide Recipients' Address."); }
                    else
                    {
                        //duration--;
                        //timecount.Text = duration.ToString();
                        //if (duration == 0)
                        //{
                        //timer1.Stop();
                        try
                        {
                            MailMessage mail = new MailMessage(from.Text, to.Text, subject.Text, message.Text);
                            SmtpClient client = new SmtpClient(server.Text);
                            client.Port = 587;
                            client.UseDefaultCredentials = false;
                            client.EnableSsl = true;
                            //for sending mail to multiple recipients
                            string t = to.Text;
                            string[] r = t.Split(',');
                            for (int i = 0; i < r.Count(); i++)
                            {
                                mail.Bcc.Add(r[i]);
                                // mail.CC.Add(r[i]);
                            }
                            //end

                            if (attach.Text != "")
                            {
                                mail.Attachments.Add(new Attachment(attach.Text));
                            }

                            client.Credentials = new System.Net.NetworkCredential(from.Text, password.Text);
                            client.Send(mail);
                            MessageBox.Show("Mail Sent Successfully...");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(" " + ex.Message);

                        }
                        finally
                        {
                            String sql = "INSERT INTO outbox (sender,recipient,subject,message,attachment,time,smtp) VALUES ('" + this.from.Text + "','" + this.to.Text + "','" + this.subject.Text + "','" + this.message.Text + "','" + this.attach.Text + "','" + this.scheduletime.Text + "','" + this.server.Text + "')";
                            con.Open();
                            MySqlCommand command = new MySqlCommand(sql, con);
                            try
                            {
                                if (command.ExecuteNonQuery() == 1)
                                {
                                    //MessageBox.Show("saved");
                                    from.Text = String.Empty;
                                    password.Text = String.Empty;
                                    to.Text = String.Empty;
                                    subject.Text = String.Empty;
                                    message.Text = String.Empty;
                                    attach.Text = String.Empty;
                                    scheduletime.Text = String.Empty;
                                    server.Text = String.Empty;
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
                catch (Exception xe) { MessageBox.Show(xe.Message); }
            }
        }*/
        private void sch_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        } 
    }
}
