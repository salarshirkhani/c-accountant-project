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
    public partial class ManageCustomer : Form
    {
        DataAccessLayer dal = new DataAccessLayer();
        public ManageCustomer()
        {
            InitializeComponent();
        }


        private void ManageCustomer_Load_2(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView7.RowCount == 0)
                return;
            if (MessageBox.Show("آیا برای حذف مطمئن هستید؟", "اخطار", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            try
            {
                dal.Disconnect();
                dal.connect();
                dal.docommand("DELETE FROM customer WHERE (id = " + dataGridView7.CurrentRow.Cells[0].Value.ToString() + ")");
                dal.Disconnect();
                ManageCustomer_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("پاک کردن شرکت با مشکل مواجه شد");
            }
        }

        private void ManageCustomer_Load(object sender, EventArgs e)
        {
            dal.Disconnect();
            dal.connect();
            dataGridView7.DataSource = dal.select("select * from customer");
            dal.Disconnect();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView7.RowCount == 0)
                return;
            if (MessageBox.Show("آیا برای ویرایش مطمئن هستید؟", "اخطار", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            try
            {
                dal.Disconnect();
                dal.connect();
                dal.docommand("UPDATE customer SET name = N'" + dataGridView7.CurrentRow.Cells[1].Value.ToString() +"', number = N'" + dataGridView7.CurrentRow.Cells[2].Value.ToString() + "',company = N'" + dataGridView7.CurrentRow.Cells[3].Value.ToString() + "', description = N'" + dataGridView7.CurrentRow.Cells[4].Value.ToString() + "' WHERE (id = " + dataGridView7.CurrentRow.Cells[0].Value.ToString() + ")");
                dal.Disconnect();
                ManageCustomer_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(".ویرایش کردن شرکت با مشکل مواجه شد");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
