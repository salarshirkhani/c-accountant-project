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
    public partial class Form3 : Form
    {
        DataAccessLayer dal = new DataAccessLayer();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dal.Disconnect();
            dal.connect();
            dataGridView1.DataSource = dal.select("select * from project");
            dal.Disconnect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0)
                return;
            if (MessageBox.Show("آیا برای حذف مطمئن هستید؟", "اخطار", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            try
            {
                dal.Disconnect();
                dal.connect();
                dal.docommand("DELETE FROM project WHERE (id = " + dataGridView1.CurrentRow.Cells[0].Value.ToString() + ")");
                dal.Disconnect();
                Form3_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("پاک کردن پروژه با مشکل مواجه شد");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0)
                return;
            if (MessageBox.Show("آیا برای ویرایش مطمئن هستید؟", "اخطار", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            try
            {
                dal.Disconnect();
                dal.connect();
                dal.docommand("UPDATE project SET name = N'" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "', price = N'" + dataGridView1.CurrentRow.Cells[2].Value.ToString() + "',beyane = N'" + dataGridView1.CurrentRow.Cells[3].Value.ToString() + "', start_date = N'" + dataGridView1.CurrentRow.Cells[4].Value.ToString() + "', end_date = N'" + dataGridView1.CurrentRow.Cells[5].Value.ToString() + "' WHERE (id = " + dataGridView1.CurrentRow.Cells[0].Value.ToString() + ")");
                dal.Disconnect();
                MessageBox.Show(".ویرایش کردن پروژه با موفقیت شد");
                Form3_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(".ویرایش کردن پروژه با مشکل مواجه شد");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
