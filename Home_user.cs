using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Library
{
    public partial class Home_user : Form
    {
        public Home_user()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Read_Book read_Book= new Read_Book();
            read_Book.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Home_user home_User = new Home_user();
            home_User.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            View_Borrowing view_Borrowing = new View_Borrowing();
            view_Borrowing.Show();
        }
    }
}
