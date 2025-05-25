using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Library
{
    public partial class Form4 : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Library;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        SqlDataAdapter da;
        SqlDataReader dr;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        bool isButtonCliecked;
        public Form4()
        {
            InitializeComponent();
            showData();
        }


        void showData()
        {
            try
            {
                con.Open();
                dt.Clear(); // تفريغ البيانات القديمة لمنع التكرار
                string sql = "SELECT DISTINCT isbn, title,auther, publisher FROM Book";
                da = new SqlDataAdapter(sql, con);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            if (txtbookid.Text == "" || txtbookname.Text == "" || txtbookauther.Text == "" || txtbookpublisher.Text == "")
            {
                MessageBox.Show("fill to all fileds");
            }
            else
            {
                try
                {
                    var sql = "INSERT INTO Book(isbn,title,auther,publisher)VALUES('" + txtbookid.Text + "','" + txtbookname.Text + "','" + txtbookauther.Text + "','" + txtbookpublisher.Text + "')";
                    cmd = new SqlCommand(sql, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Inserted is Successful", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form form = new BRM_DADD();
                    form.Show();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();

                }
            }
            showData();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            try
            {
                var sql = "Update Book Set title='" + txtbookname.Text + "',auther='" + txtbookauther.Text + "',publisher='" + txtbookpublisher.Text + "' WHERE isbn='" + txtbookid.Text + "'";
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Updated is Successful", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form form = new BRM_UPDAT();
                form.Show();
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
            try
            {
                var sql = "DELETE FROM Book WHERE isbn='" + txtbookid.Text + "'";
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted is Successful", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);


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
                var sql = " SELECT COUNT(*)from Book";

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

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            try
            {
                var sql = " SELECT COUNT(*)from Book";

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

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (WindowState==FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("are you sure to cancel this page", "cancel", MessageBoxButtons.OK, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                //e.Cancel= false;
                this.Close();
            }
            else
            {

            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToLongTimeString() + "||" + Environment.MachineName;

        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            if (WindowState==FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void guna2ImageButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
