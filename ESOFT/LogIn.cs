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
using System.Net.Mail;

namespace ESOFT
{
    public partial class LogIn : Form
    {
        
        public LogIn()
        {
            InitializeComponent();
        }

        private void JThinButton1_Click(object sender, EventArgs e)
        {


        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void JThinButton2_Click(object sender, EventArgs e)
        {

            string UserName = jMetroTextBox3.TextName;
            string Password = jMetroTextBox4.TextName;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ESOFT\esoftDB.mdf;Integrated Security=True;Connect Timeout=30");
            string qry = "SELECT * FROM SignIn WHERE UserNAme='" + UserName + "' AND Password='" + Password + "'";
            SqlCommand cmd = new SqlCommand(qry, con);

            try
            {
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                if (sdr.Read())
                {
                   

                    CashierHome e4 = new CashierHome();
                    e4.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorect User Name or Password");

                    jMetroTextBox3.TextName = null;
                    jMetroTextBox4.TextName = null;
                }
            }
            catch (SqlException se)
            {
                MessageBox.Show("" + se);
            }
        }
    }
}
