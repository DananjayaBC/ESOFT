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
    public partial class ExecutiveCourses : Form
    {
        public ExecutiveCourses()
        {
            InitializeComponent();
        }

        private void JFlatButton1_Click(object sender, EventArgs e)
        {
            panel4.Top = jFlatButton1.Top;
            panel4.Height = jFlatButton1.Height;

            panel3.Visible = true;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
        }

        private void JFlatButton3_Click(object sender, EventArgs e)
        {
            panel4.Top = jFlatButton3.Top;
            panel4.Height = jFlatButton3.Height;

            panel3.Visible = false;
            panel5.Visible = true;
            panel6.Visible = false;
            panel7.Visible = false;

            String conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ESOFT\esoftDB.mdf;Integrated Security=True;Connect Timeout=30";
            string qry = "SELECT *FROM Courses";

            SqlDataAdapter da = new SqlDataAdapter(qry, conString);
            DataSet ds = new DataSet();

            da.Fill(ds, "Courses");
            dataGridView1.DataSource = ds.Tables["Courses"];
        }

        private void JFlatButton2_Click(object sender, EventArgs e)
        {
            panel4.Top = jFlatButton2.Top;
            panel4.Height = jFlatButton2.Height;

            panel3.Visible = false;
            panel5.Visible = false;
            panel6.Visible = true;
            panel7.Visible = false;

            String conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ESOFT\esoftDB.mdf;Integrated Security=True;Connect Timeout=30";
            string qry = "SELECT *FROM Courses";

            SqlDataAdapter da = new SqlDataAdapter(qry, conString);
            DataSet ds = new DataSet();

            da.Fill(ds, "Courses");
            dataGridView2.DataSource = ds.Tables["Courses"];
        }

        private void JFlatButton5_Click(object sender, EventArgs e)
        {
            panel4.Top = jFlatButton5.Top;
            panel4.Height = jFlatButton5.Height;

            panel3.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = true;

            String conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ESOFT\esoftDB.mdf;Integrated Security=True;Connect Timeout=30";
            string qry = "SELECT *FROM Courses";

            SqlDataAdapter da = new SqlDataAdapter(qry, conString);
            DataSet ds = new DataSet();

            da.Fill(ds, "Courses");
            dataGridView3.DataSource = ds.Tables["Courses"];
        }

        private void JFlatButton4_Click(object sender, EventArgs e)
        {
            ExecutiveHome e1 = new ExecutiveHome();
            e1.Show();
            this.Hide();
        }

        private void JFlatButton8_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text;
            string fee = textBox2.Text;
            string Duration = comboBox1.Text;
            string Lecures = textBox4.Text;
            string Details = textBox5.Text;

            if (Name != "" && fee != "" && Duration != "" && Lecures != "" && Details != "")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ESOFT\esoftDB.mdf;Integrated Security=True;Connect Timeout=30");
                string qry = "INSERT INTO Courses VALUES('" + Name + "','" + fee + "','" + Duration + "','" + Lecures + "','" + Details + "')";
                SqlCommand cmd = new SqlCommand(qry, con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Save Sucssefull ");

                    textBox1.Text = null;
                    textBox2.Text = null;
                    textBox4.Text = null;
                    textBox5.Text = null;
                    comboBox1.Text = null;


                }
                catch (SqlException se)
                {
                    MessageBox.Show("" + se);
                }
            }
            else
            {
                MessageBox.Show("Fill All Coloms");
            }

        }

        private void JFlatButton7_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            comboBox1.Text = null;
        }

        private void DataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox9.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox7.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox8.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void JFlatButton12_Click(object sender, EventArgs e)
        {
            string Name = textBox10.Text;
            string fee = textBox11.Text;
            string Duration = comboBox2.Text;
            string Lectures = textBox12.Text;
            string Detail = textBox13.Text;
           

            SqlConnection dana = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ESOFT\esoftDB.mdf;Integrated Security=True;Connect Timeout=30");
            string update = ("UPDATE Courses SET CourseName='" + Name + "',Fee='" + fee + "',Duraion='" + Duration + "',Lectures='" + Lectures + "',Details='" + Detail + "'");
            SqlCommand cmd = new SqlCommand(update, dana);

            try
            {
                dana.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Successfull");
            }
            catch (SqlException se)
            {
                MessageBox.Show("" + se);
            }

            String conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ESOFT\esoftDB.mdf;Integrated Security=True;Connect Timeout=30";
            string qry = "SELECT *FROM Courses";

            SqlDataAdapter da = new SqlDataAdapter(qry, conString);
            DataSet ds = new DataSet();

            da.Fill(ds, "Courses");
            dataGridView2.DataSource = ds.Tables["Courses"];
        }

        private void DataGridView3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void DataGridView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox10.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            textBox11.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            comboBox2.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
            textBox12.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
            textBox13.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void JFlatButton6_Click(object sender, EventArgs e)
        {
            string a = textBox14.Text;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ESOFT\esoftDB.mdf;Integrated Security=True;Connect Timeout=30");
            String del = "DELETE FROM Courses WHERE CourseName='" + a + "' ";
            SqlCommand cmd = new SqlCommand(del, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("DELETE SUCCESSFULL");

                textBox14.Text = null;
            }
            catch (SqlException se)
            {
                MessageBox.Show("" + se);
            }

            String conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ESOFT\esoftDB.mdf;Integrated Security=True;Connect Timeout=30";
            string qry = "SELECT *FROM Courses";

            SqlDataAdapter da = new SqlDataAdapter(qry, conString);
            DataSet ds = new DataSet();

            da.Fill(ds, "Courses");
            dataGridView3.DataSource = ds.Tables["Courses"];
        }
    }
}
