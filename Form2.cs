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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            Form3 form3 = new Form3();
           //form3.MdiParent = form2;
            form3.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Borrow_Book borrow_Book = new Borrow_Book();
            //borrow_Book.MdiParent = this;
            borrow_Book.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            //f4.MdiParent = this;
            f4.Show();
        }

        private void guna2Button1_MouseHover(object sender, EventArgs e)
        {
          
            this.Student.ForeColor = Color.Red;

        }

        private void Student_MouseLeave(object sender, EventArgs e)
        {
       
            this.Student.ForeColor = Color.Black;
        }

        private void guna2Button2_MouseHover(object sender, EventArgs e)
        {
            this.Book.ForeColor = Color.Red;
            //this.Student.Font = new Font("Times New Roman",14,FontStyle.Bold);

        }

        private void guna2Button2_MouseLeave(object sender, EventArgs e)
        {
            this.Book.ForeColor = Color.Black;

        }

        private void Borrowing_MouseHover(object sender, EventArgs e)
        {
            this.Borrowing.ForeColor = Color.Red;

        }

        private void Borrowing_MouseLeave(object sender, EventArgs e)
        {
            this.Borrowing.ForeColor = Color.Black;

        }

        private void Library_MouseHover(object sender, EventArgs e)
        {
            this.Library.ForeColor = Color.Red;

        }

        private void Library_MouseLeave(object sender, EventArgs e)
        {
            this.Library.ForeColor = Color.Black;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToLongTimeString() + "||" + Environment.MachineName;

        }

        private void Library_Click(object sender, EventArgs e)
        {

        }
    }
}
