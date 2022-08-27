using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void کاربرانToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ساختمشتریجدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog(this);
        }

        private void مدیریتمشتریهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ManageCustomer().ShowDialog(this);
        }

        private void ساختپروژهجدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CreateProject().ShowDialog(this);
        }

        private void مدیریتپروژههاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form3().ShowDialog(this);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}