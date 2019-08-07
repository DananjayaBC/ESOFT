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
    public partial class Payment : Form
    {
        double balence = 0;
        public Payment()
        {
            InitializeComponent();
        }

        private void JFlatButton1_Click(object sender, EventArgs e)
        {
            panel4.Top = jFlatButton1.Top;
            panel4.Height = jFlatButton1.Height;

            panel5.Visible = true;
            panel3.Visible = false;
            panel6.Visible = false;


        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void JFlatButton4_Click(object sender, EventArgs e)
        {
           
        }

        private void JFlatButton5_Click(object sender, EventArgs e)
        {
           

        }

        private void JFlatButton6_Click(object sender, EventArgs e)
        {

           
        }

        private void JFlatButton2_Click(object sender, EventArgs e)
        {
            panel4.Top = jFlatButton2.Top;
            panel4.Height = jFlatButton2.Height;

            panel5.Visible = false;
            panel3.Visible = false;
            panel6.Visible = true;

            String conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ESOFT\esoftDB.mdf;Integrated Security=True;Connect Timeout=30";
            string qry = "SELECT *FROM payment";

            SqlDataAdapter da = new SqlDataAdapter(qry, conString);
            DataSet ds = new DataSet();

            da.Fill(ds, "payment");
            dataGridView2.DataSource = ds.Tables["payment"];

            

        }

        private void JFlatButton3_Click(object sender, EventArgs e)
        {
            panel4.Top = jFlatButton3.Top;
            panel4.Height = jFlatButton3.Height;

            panel5.Visible = false;
            panel3.Visible = true;
            panel6.Visible = false;

            String conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ESOFT\esoftDB.mdf;Integrated Security=True;Connect Timeout=30";
            string qry = "SELECT *FROM payment";

            SqlDataAdapter da = new SqlDataAdapter(qry, conString);
            DataSet ds = new DataSet();

            da.Fill(ds, "payment");
            dataGridView1.DataSource = ds.Tables["payment"];

        }

        private void JFlatButton9_Click(object sender, EventArgs e)
        {
            double Fee, Money;

            Fee = double.Parse(textBox6.Text);
            Money = double.Parse(textBox5.Text);

            balence = Money - Fee;

            label13.Text = "" + balence.ToString();
        }

        private void JFlatButton4_Click_1(object sender, EventArgs e)
        {
           
        }

        private void JFlatButton6_Click_1(object sender, EventArgs e)
        {

            string a = textBox1.Text;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ESOFT\esoftDB.mdf;Integrated Security=True;Connect Timeout=30");
            String del = "DELETE FROM payment WHERE Id='" + a + "' ";
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
            string qry = "SELECT *FROM payment";

            SqlDataAdapter da = new SqlDataAdapter(qry, conString);
            DataSet ds = new DataSet();

            da.Fill(ds, "payment");
            dataGridView2.DataSource = ds.Tables["payment"];
        }

        private void JFlatButton5_Click_1(object sender, EventArgs e)
        {
            String conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ESOFT\esoftDB.mdf;Integrated Security=True;Connect Timeout=30";
            string qry = "SELECT *FROM payment";

            SqlDataAdapter da = new SqlDataAdapter(qry, conString);
            DataSet ds = new DataSet();

            da.Fill(ds, "payment");
            dataGridView2.DataSource = ds.Tables["payment"];
        }

        private void JFlatButton8_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox8.Text);
            string b = textBox7.Text;

            string c = comboBox6.Text;
            string d = comboBox5.Text;
            string E = comboBox4.Text;
            string f = textBox6.Text;

            if (b != "" && c != "" && d != "" && E != "" && f != "")
            {

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ESOFT\esoftDB.mdf;Integrated Security=True;Connect Timeout=30");
                string qry = "INSERT INTO payment VALUES('" + a + "','" + b + "','" + c + "','" + d + "','" + E + "','" + f + "')";
                SqlCommand cmd = new SqlCommand(qry, con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Payment Sucssefull ");

                    textBox8.Text = null;
                    textBox7.Text = null;
                    textBox6.Text = null;
                    textBox5.Text = null;
                    comboBox6.Text = null;
                    comboBox5.Text = null;
                    comboBox4.Text = null;
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

        private void Label13_Click(object sender, EventArgs e)
        {

        }

        private void Label14_Click(object sender, EventArgs e)
        {

        }

        private void JFlatButton7_Click(object sender, EventArgs e)
        {
            textBox8.Text = null;
            textBox7.Text = null;
            textBox6.Text = null;
            textBox5.Text = null;
            comboBox6.Text = null;
            comboBox5.Text = null;
            comboBox4.Text = null;
        }

        private void Label20_Click(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label15_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label16_Click(object sender, EventArgs e)
        {

        }

        private void Label17_Click(object sender, EventArgs e)
        {

        }

        private void Label18_Click(object sender, EventArgs e)
        {

        }

        private void Label19_Click(object sender, EventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void Label21_Click(object sender, EventArgs e)
        {

        }

        private void Label22_Click(object sender, EventArgs e)
        {

        }

        private void jFlatButton4_Click_2(object sender, EventArgs e)
        {
            ExecutiveHome e3 = new ExecutiveHome();
            e3.Show();
            this.Hide();
        }

        private void Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

            textBox4.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox9.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox10.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox11.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
