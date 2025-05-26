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
    public partial class Register : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Library;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter();
        public Register()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            String gender;
            String country1;


            if (txtCountry.Text == "Yemen")
            {
                country1 = "Yemen";
            }
            else if (txtCountry.Text == "Quter")
            {
                country1 = "Quter";

            }
            else if (txtCountry.Text == "Oman")
            {
                country1 = "Oman";

            }
            else
            {
                country1 = "Egypt";

            }

            try
            {
                if (rfemale.Checked == true)
                {
                    gender = rfemale.Text;
                }
                else
                {
                    gender = rmale.Text;
                }



                var sql = "INSERT INTO Users(name,email,password,gender,country)VALUES('" + txtName.Text + "','" + txtEmail.Text + "','" + txtEmail.Text + "','" + gender + "','cuntry1')";
                cmd = new SqlCommand(sql,con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sign up is Successful", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Home_user f6 = new Home_user();
                f6.Show();


                //MessageBox.Show("Inserted is successfull", "message", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
