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
    public partial class Borrow_Book : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Library;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter();
        public Borrow_Book()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string bookId = txtBookId.Text.Trim();
            string memberId = txtStudentId.Text.Trim();
            DateTime issueDate = dtpIssueDate.Value;
            DateTime dueDate = dtpDueDate.Value;

            if (string.IsNullOrEmpty(bookId) || string.IsNullOrEmpty(memberId))
            {
                MessageBox.Show("يرجى إدخال معرف الكتاب والعضو.");
                return;
            }


            try
            {
                string checkAvailabilityQuery = "SELECT availability FROM books WHERE book_id = @book_id";
                SqlCommand checkCmd = new SqlCommand(checkAvailabilityQuery, con);
                checkCmd.Parameters.AddWithValue("@book_id", bookId);


                object result = checkCmd.ExecuteScalar();
                if (result == null)
                {
                    MessageBox.Show("الكتاب غير موجود.");
                    return;
                }

                bool isAvailable = Convert.ToBoolean(result);
                if (!isAvailable)
                {
                    MessageBox.Show("الكتاب غير متاح حالياً للإعارة.");
                    return;
                }

                string insertBorrowingQuery = @"
                INSERT INTO borrowing (book_id, user_id, borrow_date, return_date, status)
                VALUES (@book_id, @member_id, @issue_date, @due_date, 'Borrowed')";

                SqlCommand insertCmd = new SqlCommand(insertBorrowingQuery, con);
                insertCmd.Parameters.AddWithValue("@book_id", bookId);
                insertCmd.Parameters.AddWithValue("@member_id", memberId);
                insertCmd.Parameters.AddWithValue("@issue_date", issueDate);
                insertCmd.Parameters.AddWithValue("@due_date", dueDate);
                insertCmd.ExecuteNonQuery();

                // تحديث حالة الكتاب
                string updateBookQuery = "UPDATE books SET availability = 0 WHERE book_id = @book_id";
                SqlCommand updateCmd = new SqlCommand(updateBookQuery, con);
                updateCmd.Parameters.AddWithValue("@book_id", bookId);
                updateCmd.ExecuteNonQuery();

                MessageBox.Show("تمت عملية الإعارة بنجاح.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ: " + ex.Message);
            }
        }

    }
}

