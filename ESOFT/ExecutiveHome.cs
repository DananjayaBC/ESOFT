using ESOFT;
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
    public partial class ExecutiveHome : Form
    {
        public ExecutiveHome()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void JFlatButton1_Click(object sender, EventArgs e)
        {
            Payment e1 = new Payment();
            e1.Show();
            this.Hide();

            Form e2 = new Form();

           
        }

        private void JFlatButton2_Click(object sender, EventArgs e)
        {
            Staf e1 = new Staf();
            e1.Show();
            this.Hide();
        }

        private void BunifuFlatButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void JFlatButton3_Click(object sender, EventArgs e)
        {
            ExecutiveCourses e5 = new ExecutiveCourses();
            e5.Show();
            this.Hide();
        }

        private void JFlatButton4_Click(object sender, EventArgs e)
        {
            First e1 = new First();
            e1.Show();
            this.Hide();
        }
    }
}
