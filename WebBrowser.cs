﻿using System;
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
    public partial class WebBrowser : Form
    {
        public WebBrowser()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtUrl.Text);
           
        }

        private void txtUrl_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
