using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ESOFT
{
    public partial class CashierHome : Form
    {
        public CashierHome()
        {
            InitializeComponent();
        }

        private void JFlatButton1_Click(object sender, EventArgs e)
        {
            CashierPayments e1 = new CashierPayments();
            e1.Show();
            this.Hide();
        }

        private void JFlatButton3_Click(object sender, EventArgs e)
        {
            CashierCourses e5 = new CashierCourses();
            e5.Show();
            this.Hide();

           
        }

        private void JFlatButton2_Click(object sender, EventArgs e)
        {
            First e1 = new First();
            e1.Show();
            this.Hide();
        }
    }
}
