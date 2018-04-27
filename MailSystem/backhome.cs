using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailSystem
{
    public partial class backhome : UserControl
    {
        private static backhome _instance;
        public static backhome Instance{
            get {
                if (_instance == null)
                    _instance = new backhome();
                return _instance;
            }
        }
        public backhome()
        {
            InitializeComponent();
        }

        private void home_Load(object sender, EventArgs e)
        {

        }
    }
}
