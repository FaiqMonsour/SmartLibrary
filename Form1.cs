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
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Library;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter();
        public Form1()
        {
            InitializeComponent();
        }

        //private void login_Click(object sender, EventArgs e)
        //{
        //    //        try {
        //    //            cmd = new SqlCommand("select * from user", con);
        //    //            con.Open();
        //    //            dr = cmd.ExecuteReader();
        //    //            dr.Read();
        //    //            if (txtname.Text == dr["email"].ToString())
        //    //            {
        //    //                MessageBox.Show("login successful");
        //    //            }

        //    //}catch(Exception ex) {
        //    //            MessageBox.Show("error");
        //    //        }

        //    Form2 f2 = new Form2();
        //    f2.Show();
        //}
        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      



        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

    

        //private void guna2Button3_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        con.Open();
        //        cmd = new SqlCommand("SELECT * FROM Users WHERE email=@name AND password=@pass",con);
        //        cmd.Parameters.AddWithValue("@name", txtname.Text);
        //        cmd.Parameters.AddWithValue("@pass", txtpassword.Text);
        //        dr = cmd.ExecuteReader();
        //        if (dr.Read())
        //        {
                  
        //            Form2 f2 = new Form2();
        //            f2.Show();
        //        }
        //        else
        //        {
        //            MessageBox.Show("your username or password is valeid");
        //        }
        //    }
        //    catch (SqlException ex)
        //    {
        //        MessageBox.Show("there is an error");
        //    }
        //    con.Close();
        //}

        private void guna2Button4_Click(object sender, EventArgs e)
        {


            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT * FROM Users WHERE email=@name AND password=@pass", con);
                cmd.Parameters.AddWithValue("@name", txtname.Text);
                cmd.Parameters.AddWithValue("@pass", txtpassword.Text);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    if (dr["role"].ToString()=="admin")
                    {
                        Form2 f2 = new Form2();
                        f2.Show();
                    }
                    else
                    {
                        Home_user f6 = new Home_user();
                        f6.Show();
                    }


                    //Form2 f2 = new Form2();
                    //f2.Show();
                }
                else
                {
                    MessageBox.Show("your username or password is valeid");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("there is an error");
            }
            con.Close();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Borrow_Book f5 = new Borrow_Book();
            f5.Show();
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void lbllogin_MouseHover(object sender, EventArgs e)
        {
            this.lbllogin.ForeColor = Color.Blue;
            this.lbllogin.Font = new Font("Time New Roman",30);
        }

        private void lbllogin_MouseLeave(object sender, EventArgs e)
        {
            this.lbllogin.ForeColor = Color.Black;
            this.lbllogin.Font = new Font("Time New Roman", 24);

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
