﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("نام کاربری یا رمز عبور غیر قابل قبول است");
                return;
            }

            DataAccessLayer dal = new DataAccessLayer();
            dal.connect();
            DataTable dt = dal.select("SELECT username, password FROM login WHERE (username ='" + textBox1.Text + "') AND (password ='" + textBox2.Text + "')");
            dal.Disconnect();

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("نام کاربری یا رمز عبور غیر قابل قبول است");
                return;
            }


            this.Hide();
            new Form1().ShowDialog(this);
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
