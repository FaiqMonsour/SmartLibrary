using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Library
{
    public partial class Read_Book : Form
    {
        public Read_Book()
        {
            InitializeComponent();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
          
            if (File.Exists("C:\\"+txtfile.Text+""))
            {
               
                    richfile1.Lines = File.ReadAllLines("C:\\"+txtfile.Text+"");
              
            }
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richfile.Text,new Font("Tahoma",18),Brushes.Blue,10,20);

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
                pageSetupDialog1.ShowDialog();


        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }
    }
}
