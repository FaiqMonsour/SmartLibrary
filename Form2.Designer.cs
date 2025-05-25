namespace Smart_Library
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Library = new Guna.UI2.WinForms.Guna2Button();
            this.Borrowing = new Guna.UI2.WinForms.Guna2Button();
            this.Book = new Guna.UI2.WinForms.Guna2Button();
            this.Student = new Guna.UI2.WinForms.Guna2Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbltime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1921, 86);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(741, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Smart Library";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.guna2CirclePictureBox2);
            this.panel2.Controls.Add(this.Library);
            this.panel2.Controls.Add(this.Borrowing);
            this.panel2.Controls.Add(this.Book);
            this.panel2.Controls.Add(this.Student);
            this.panel2.Location = new System.Drawing.Point(2, 96);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 866);
            this.panel2.TabIndex = 5;
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2CirclePictureBox2.Image = global::Smart_Library.Properties.Resources.download__1_2;
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(13, 349);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(224, 224);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.guna2CirclePictureBox2.TabIndex = 1;
            this.guna2CirclePictureBox2.TabStop = false;
            // 
            // Library
            // 
            this.Library.BorderRadius = 20;
            this.Library.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Library.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Library.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Library.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Library.FillColor = System.Drawing.Color.White;
            this.Library.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Library.ForeColor = System.Drawing.Color.Black;
            this.Library.Location = new System.Drawing.Point(13, 260);
            this.Library.Name = "Library";
            this.Library.Size = new System.Drawing.Size(261, 45);
            this.Library.TabIndex = 7;
            this.Library.Text = "Librarian";
            this.Library.Click += new System.EventHandler(this.Library_Click);
            this.Library.MouseLeave += new System.EventHandler(this.Library_MouseLeave);
            this.Library.MouseHover += new System.EventHandler(this.Library_MouseHover);
            // 
            // Borrowing
            // 
            this.Borrowing.BorderRadius = 20;
            this.Borrowing.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Borrowing.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Borrowing.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Borrowing.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Borrowing.FillColor = System.Drawing.Color.White;
            this.Borrowing.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Borrowing.ForeColor = System.Drawing.Color.Black;
            this.Borrowing.Location = new System.Drawing.Point(10, 187);
            this.Borrowing.Name = "Borrowing";
            this.Borrowing.Size = new System.Drawing.Size(261, 45);
            this.Borrowing.TabIndex = 6;
            this.Borrowing.Text = "Borrowing";
            this.Borrowing.Click += new System.EventHandler(this.guna2Button3_Click);
            this.Borrowing.MouseLeave += new System.EventHandler(this.Borrowing_MouseLeave);
            this.Borrowing.MouseHover += new System.EventHandler(this.Borrowing_MouseHover);
            // 
            // Book
            // 
            this.Book.BorderRadius = 20;
            this.Book.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Book.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Book.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Book.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Book.FillColor = System.Drawing.Color.White;
            this.Book.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book.ForeColor = System.Drawing.Color.Black;
            this.Book.Location = new System.Drawing.Point(13, 109);
            this.Book.Name = "Book";
            this.Book.Size = new System.Drawing.Size(261, 45);
            this.Book.TabIndex = 5;
            this.Book.Text = "Book";
            this.Book.Click += new System.EventHandler(this.guna2Button2_Click);
            this.Book.MouseLeave += new System.EventHandler(this.guna2Button2_MouseLeave);
            this.Book.MouseHover += new System.EventHandler(this.guna2Button2_MouseHover);
            // 
            // Student
            // 
            this.Student.BorderRadius = 20;
            this.Student.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Student.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Student.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Student.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Student.FillColor = System.Drawing.Color.White;
            this.Student.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student.ForeColor = System.Drawing.Color.Black;
            this.Student.Location = new System.Drawing.Point(13, 38);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(261, 45);
            this.Student.TabIndex = 4;
            this.Student.Text = "Student";
            this.Student.Click += new System.EventHandler(this.guna2Button1_Click);
            this.Student.MouseLeave += new System.EventHandler(this.Student_MouseLeave);
            this.Student.MouseHover += new System.EventHandler(this.guna2Button1_MouseHover);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbltime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 876);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1924, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbltime
            // 
            this.lbltime.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(0, 16);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Smart_Library.Properties.Resources.download__1_3;
            this.pictureBox1.Image = global::Smart_Library.Properties.Resources.Home;
            this.pictureBox1.Location = new System.Drawing.Point(302, 96);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1621, 909);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CirclePictureBox1.Image = global::Smart_Library.Properties.Resources.download__1_;
            this.guna2CirclePictureBox1.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Vertical;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(1924, 898);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.guna2CirclePictureBox1.TabIndex = 6;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 898);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.IsMdiContainer = true;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button Student;
        private Guna.UI2.WinForms.Guna2Button Library;
        private Guna.UI2.WinForms.Guna2Button Borrowing;
        private Guna.UI2.WinForms.Guna2Button Book;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel lbltime;
    }
}