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
    public partial class CreateProject : Form
    {
        DataAccessLayer dal = new DataAccessLayer();
        bool flagEdit = true;
        string code = "";
        public CreateProject()
        {
            InitializeComponent();
        }

        private void CreateProject_Load(object sender, EventArgs e)
        {
            dal.Disconnect();
            dal.connect();
            listBox1.DataSource = dal.select("select id,name from customer");
            listBox1.DisplayMember = "name";
            listBox1.ValueMember = "id";
            dal.Disconnect();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "";

            sql = "INSERT INTO project (name, price, beyane, start_date, end_date,customer_id)" + " VALUES (N'" + textBox1.Text + "', N'" + textBox2.Text + "', N'" + textBox3.Text + "', N'" + dateTimePicker1.Text + "', N'" + dateTimePicker2.Text + "', N'" + listBox1.SelectedValue + "')";

            try
            {
                dal.Disconnect();
                dal.connect();
                dal.docommand(sql);
                dal.Disconnect();
                MessageBox.Show("ثبت پروژه انجام شد");
            }
            catch
            {
                MessageBox.Show("ثبت پروژه با مشکل مواجه شد");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
