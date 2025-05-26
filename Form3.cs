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

namespace Smart_Library
{
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Library;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        SqlDataAdapter da;
        SqlDataReader dr;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        bool isButtonCliecked;
        public Form3()
        {
            InitializeComponent();
            showData();

        }



        public void showData()
        {
            this.Refresh();
            this.Invalidate();
            try
            {
                con.Open();
                dt.Clear(); // تفريغ البيانات القديمة لمنع التكرار
                string sql = "SELECT DISTINCT student_id, student_name, email, address FROM Student";
                da = new SqlDataAdapter(sql, con);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void insert1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            isButtonCliecked = true;
            try
            {
                var sql = "INSERT INTO Student(student_id,student_name,email,address)VALUES('" + txtid.Text + "','" + txtname.Text + "','" + txtemail.Text + "','" + txtaddress.Text + "')";
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserted is Successful", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();

            }
            showData();

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            isButtonCliecked = true;
            try
            {
                var sql = "Update Student Set student_name='" + txtname.Text + "',email='" + txtemail.Text + "',address='" + txtaddress.Text + "' WHERE student_id='" + txtid.Text + "'";
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated is Successful", "message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                con.Close();

            }

            showData();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            isButtonCliecked = true;
            try
            {
                var sql = "DELETE FROM Student WHERE student_id='" + txtid.Text + "'";
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted is Successful", "message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            showData();
        }

        private void totals_Click(object sender, EventArgs e)
        {
            try
            {
                var sql = " SELECT COUNT(*)from Student";

                cmd = new SqlCommand(sql, con);
                con.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                txtTotal.Text = dr[0].ToString();
                con.Close();
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            showData();
        }

        private void totals_Click_1(object sender, EventArgs e)
        {
            try
            {
                var sql = " SELECT COUNT(*)from Student";

                cmd = new SqlCommand(sql, con);
                con.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                txtTotal.Text = dr[0].ToString();
                con.Close();
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime1.Text = DateTime.Now.ToLongTimeString() + "||" + Environment.MachineName;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
