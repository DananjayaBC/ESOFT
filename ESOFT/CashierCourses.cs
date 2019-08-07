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
    public partial class CashierCourses : Form
    {
        public CashierCourses()
        {
            InitializeComponent();
        }

        private void JFlatButton4_Click(object sender, EventArgs e)
        {
            CashierHome e6 = new CashierHome();
            e6.Show();
            this.Hide();
        }

        private void JFlatButton1_Click(object sender, EventArgs e)
        {
          

            String conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ESOFT\esoftDB.mdf;Integrated Security=True;Connect Timeout=30";
            string qry = "SELECT *FROM Courses";

            SqlDataAdapter da = new SqlDataAdapter(qry, conString);
            DataSet ds = new DataSet();

            da.Fill(ds, "Courses");
            dataGridView1.DataSource = ds.Tables["Courses"];
        }

        private void DataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
}
