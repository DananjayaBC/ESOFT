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
    public partial class Staf : Form
    {
        public Staf()
        {
            InitializeComponent();
        }

        private void jFlatButton4_Click(object sender, EventArgs e)
        {
            ExecutiveHome e1 = new ExecutiveHome();
            e1.Show();
            this.Hide();
        }

        private void jFlatButton1_Click(object sender, EventArgs e)
        {
            panel4.Top = jFlatButton1.Top;
            panel4.Height = jFlatButton1.Height;

            panel3.Visible = true;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
        }

        private void jFlatButton2_Click(object sender, EventArgs e)
        {
            panel4.Top = jFlatButton2.Top;
            panel4.Height = jFlatButton2.Height;

           

            panel5.Visible = true;
            panel3.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;

            String conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ESOFT\esoftDB.mdf;Integrated Security=True;Connect Timeout=30";
            string qry = "SELECT *FROM staff";

            SqlDataAdapter da = new SqlDataAdapter(qry, conString);
            DataSet ds = new DataSet();

            da.Fill(ds, "staff");
            dataGridView2.DataSource = ds.Tables["staff"];



        }

        private void jFlatButton3_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
            panel3.Visible = false;
            panel6.Visible = true;
            panel7.Visible = false;

            panel4.Top = jFlatButton3.Top;
            panel4.Height = jFlatButton3.Height;

            String conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ESOFT\esoftDB.mdf;Integrated Security=True;Connect Timeout=30";
            string qry = "SELECT *FROM staff";

            SqlDataAdapter da = new SqlDataAdapter(qry, conString);
            DataSet ds = new DataSet();

            da.Fill(ds, "staff");
            dataGridView1.DataSource = ds.Tables["staff"];
        }

        private void JFlatButton8_Click(object sender, EventArgs e)
        {
            string FirstName = textBox1.Text;
            string LastName = textBox2.Text;
            string Title = comboBox1.Text;
            string NIC = textBox3.Text;
            string Contact = textBox4.Text;
            string Email = textBox5.Text;
            string Education = textBox6.Text;
            string Experince = textBox7.Text;

            if (FirstName != "" && LastName != "" && Title != "" && Email != "" && Education != "" && Experince != "")
            {
                SqlConnection dana = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ESOFT\esoftDB.mdf;Integrated Security=True;Connect Timeout=30");
                string qry = "INSERT INTO staff VALUES('" + FirstName + "','" + LastName + "','" + Title + "','" + NIC + "','" + Contact + "','" + Email + "','" + Education + "','" + Experince + "')";
                SqlCommand cmd = new SqlCommand(qry, dana);
                try
                {
                    dana.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Saved");

                    textBox1.Text = null;
                    textBox2.Text = null;
                    textBox3.Text = null;
                    textBox4.Text = null;
                    textBox5.Text = null;
                    textBox6.Text = null;
                    textBox7.Text = null;
                    comboBox1.Text = null;
                }
                catch (SqlException da)
                {
                    MessageBox.Show("" + da);
                }
            }
            else
            {
                MessageBox.Show("Fill All Coloums"); 
            }

            


        }

        private void JFlatButton7_Click(object sender, EventArgs e)
        {
            String conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ESOFT\esoftDB.mdf;Integrated Security=True;Connect Timeout=30";
            string qry = "SELECT *FROM staff";

            SqlDataAdapter da = new SqlDataAdapter(qry, conString);
            DataSet ds = new DataSet();

            da.Fill(ds, "staff");
            dataGridView2.DataSource = ds.Tables["staff"];
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void JFlatButton5_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
            textBox7.Text = null;
            comboBox1.Text = null;
        }

        private void JFlatButton6_Click(object sender, EventArgs e)
        {

            string a = textBox8.Text;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ESOFT\esoftDB.mdf;Integrated Security=True;Connect Timeout=30");
            String del = "DELETE FROM staff WHERE NIC='" + a + "' ";
            SqlCommand cmd = new SqlCommand(del, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("DELETE SUCCESSFULL");

                textBox1.Text = null;
            }
            catch (SqlException se)
            {
                MessageBox.Show("" + se);
            }

            String conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ESOFT\esoftDB.mdf;Integrated Security=True;Connect Timeout=30";
            string qry = "SELECT *FROM staff";

            SqlDataAdapter da = new SqlDataAdapter(qry, conString);
            DataSet ds = new DataSet();

            da.Fill(ds, "staff");
            dataGridView2.DataSource = ds.Tables["staff"];
        }

        private void DataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox9.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox10.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

            textBox11.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox12.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox13.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox14.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox15.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            textBox16.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void Panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void JFlatButton7_Click_1(object sender, EventArgs e)
        {
            panel4.Top = jFlatButton7.Top;
            panel4.Height = jFlatButton7.Height;

            
            panel5.Visible = false;
            panel3.Visible = false;
            panel6.Visible = false;
            panel7.Visible = true;

            String conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ESOFT\esoftDB.mdf;Integrated Security=True;Connect Timeout=30";
            string qry = "SELECT *FROM staff";

            SqlDataAdapter da = new SqlDataAdapter(qry, conString);
            DataSet ds = new DataSet();

            da.Fill(ds, "staff");
            dataGridView3.DataSource = ds.Tables["staff"];
        }

        private void JFlatButton9_Click(object sender, EventArgs e)
        {
            
        }

        private void JFlatButton12_Click(object sender, EventArgs e)
        {
            string Fname = textBox17.Text;
            string Lname = textBox18.Text;
            string Title = comboBox2.Text;
            int Nic = int.Parse(textBox19.Text);
            string Number = textBox20.Text;
            string Email = textBox21.Text;
            string Qulification = textBox22.Text;
            string Experience = textBox23.Text;

            SqlConnection dana = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ESOFT\esoftDB.mdf;Integrated Security=True;Connect Timeout=30");
            string update = ("UPDATE staff SET FirstName='" + Fname + "',LastName='" + Lname + "',Title='" + Title + "',PhoneNumber='" + Number + "',Email='" + Email + "',EducationQlification = '" + Qulification + "',WorkingExperience = '" + Experience + "',NIC='" + Nic + "'");
            SqlCommand cmd = new SqlCommand(update, dana);

            try
            {
                dana.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Staf Update Successfull");
            }
            catch (SqlException se)
            {
                MessageBox.Show("" + se);
            }

            String conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ESOFT\esoftDB.mdf;Integrated Security=True;Connect Timeout=30";
            string qry = "SELECT *FROM staff";

            SqlDataAdapter da = new SqlDataAdapter(qry, conString);
            DataSet ds = new DataSet();

            da.Fill(ds, "staff");
            dataGridView3.DataSource = ds.Tables["staff"];


        }

        private void JFlatButton11_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox17.Text = dataGridView3.SelectedRows[0].Cells[0].Value.ToString();
            textBox18.Text = dataGridView3.SelectedRows[0].Cells[1].Value.ToString();
            comboBox2.Text=  dataGridView3.SelectedRows[0].Cells[2].Value.ToString();
            textBox19.Text = dataGridView3.SelectedRows[0].Cells[3].Value.ToString();
            textBox20.Text = dataGridView3.SelectedRows[0].Cells[4].Value.ToString();
            textBox21.Text = dataGridView3.SelectedRows[0].Cells[5].Value.ToString();
            textBox22.Text = dataGridView3.SelectedRows[0].Cells[6].Value.ToString();
            textBox23.Text = dataGridView3.SelectedRows[0].Cells[7].Value.ToString();
          
        }

        private void Label25_Click(object sender, EventArgs e)
        {

        }
    }
}
