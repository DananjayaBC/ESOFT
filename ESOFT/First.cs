using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESOFT
{
    public partial class First : Form
    {
        public First()
        {
            InitializeComponent();
        }

        private void JFlatButton1_Click(object sender, EventArgs e)
        {
            LogIn e1 = new LogIn();
            e1.Show();
            this.Hide();
        }

        private void JFlatButton2_Click(object sender, EventArgs e)
        {
            EXECUTIVElogin e2 = new EXECUTIVElogin();
            e2.Show();
            this.Hide();
        }
    }
}
