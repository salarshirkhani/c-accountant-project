using System;
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
    public partial class Form2 : Form
    {
        DataAccessLayer dal = new DataAccessLayer();
        bool flagEdit = true;
        string code = "";
        public Form2()
        {
            InitializeComponent();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "";

            sql = " INSERT INTO customer (name, number, company, description)" +
           " VALUES (N'" + textBox7.Text + "', N'" + textBox8.Text + "', N'" + textBox9.Text + "', N'" + textBox10.Text + "')";

            try
            {
                dal.Disconnect();
                dal.connect();
                dal.docommand(sql);
                dal.Disconnect();
                MessageBox.Show("ثبت شرکت انجام شد");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ثبت شرکت با مشکل مواجه شد");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dal.Disconnect();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
