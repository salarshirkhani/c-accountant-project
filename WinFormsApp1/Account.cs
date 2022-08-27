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
    
    public partial class Account : Form
    {
        DataAccessLayer dal = new DataAccessLayer();
        public Account()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Account_Load(object sender, EventArgs e)
        {
            int price = 0;
            int beyane = 0;
            dal.Disconnect();
            dal.connect();
            dataGridView1.DataSource = dal.select("select * from customer");
            dataGridView2.DataSource = dal.select("select * from project");
            int RowCount = dataGridView2.Rows.Count;
            for (int i =0;i < RowCount; i++)
            {
               price =  price + Convert.ToInt32(dataGridView2.Rows[i].Cells[2].Value.ToString());
            }
            label2.Text = price.ToString();
            for (int i = 0; i < RowCount; i++)
            {
                beyane = beyane + Convert.ToInt32(dataGridView2.Rows[i].Cells[3].Value.ToString());
            }
            label6.Text = beyane.ToString();
            label9.Text = (price - beyane).ToString();
            dal.Disconnect();
        }
    }
}
