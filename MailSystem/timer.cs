using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailSystem
{
    public partial class timer : Form
    {
        public timer()
        {
            InitializeComponent();
        }
        //int value;
        int duration = 20;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show("Sent");
            //string dura = txtbox.Text;
            duration--;
            txtbox.Text = duration.ToString();
            if (duration == 0) { 
                timer1.Stop();
                MessageBox.Show("Sent");
            }
            
        }

        private void start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
