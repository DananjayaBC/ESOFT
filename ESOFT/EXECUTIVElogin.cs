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
    public partial class EXECUTIVElogin : Form
    {
        public EXECUTIVElogin()
        {
            InitializeComponent();
        }

        private void JThinButton2_Click(object sender, EventArgs e)
        {
            string UserName = jMetroTextBox1.TextName;
            string Password = jMetroTextBox2.TextName;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ESOFT\esoftDB.mdf;Integrated Security=True;Connect Timeout=30");
            string qry = "SELECT * FROM Executive WHERE UserName='" + UserName + "' AND Password='" + Password + "'";
            SqlCommand cmd = new SqlCommand(qry, con);

            try
            {
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                if (sdr.Read())
                {
                    ExecutiveHome e1 = new ExecutiveHome();
                    e1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorect User Name or Password");

                    jMetroTextBox1.TextName = null;
                    jMetroTextBox2.TextName = null;
                }
            }
            catch (SqlException se)
            {
                MessageBox.Show("" + se);
            }
        }

        private void EXECUTIVElogin_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
