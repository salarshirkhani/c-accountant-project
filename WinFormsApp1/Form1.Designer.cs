namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.ورود = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.پروژههاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ساختپروژهجدیدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مدیریتپروژههاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.کاربرانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.وضعیتحسابهاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مشتریهاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ساختمشتریجدیدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مدیریتمشتریهاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.خروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(0, 0);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(100, 27);
            this.txtuser.TabIndex = 0;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(0, 0);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(100, 27);
            this.txtpass.TabIndex = 0;
            // 
            // ورود
            // 
            this.ورود.Location = new System.Drawing.Point(0, 0);
            this.ورود.Name = "ورود";
            this.ورود.Size = new System.Drawing.Size(75, 23);
            this.ورود.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.menuStrip1.Font = new System.Drawing.Font("KalamehWeb Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.پروژههاToolStripMenuItem,
            this.کاربرانToolStripMenuItem,
            this.مشتریهاToolStripMenuItem,
            this.خروجToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(640, 37);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // پروژههاToolStripMenuItem
            // 
            this.پروژههاToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ساختپروژهجدیدToolStripMenuItem,
            this.مدیریتپروژههاToolStripMenuItem});
            this.پروژههاToolStripMenuItem.Name = "پروژههاToolStripMenuItem";
            this.پروژههاToolStripMenuItem.Size = new System.Drawing.Size(77, 33);
            this.پروژههاToolStripMenuItem.Text = "پروژه ها";
            // 
            // ساختپروژهجدیدToolStripMenuItem
            // 
            this.ساختپروژهجدیدToolStripMenuItem.Name = "ساختپروژهجدیدToolStripMenuItem";
            this.ساختپروژهجدیدToolStripMenuItem.Size = new System.Drawing.Size(224, 34);
            this.ساختپروژهجدیدToolStripMenuItem.Text = "ساخت پروژه جدید";
            this.ساختپروژهجدیدToolStripMenuItem.Click += new System.EventHandler(this.ساختپروژهجدیدToolStripMenuItem_Click);
            // 
            // مدیریتپروژههاToolStripMenuItem
            // 
            this.مدیریتپروژههاToolStripMenuItem.Name = "مدیریتپروژههاToolStripMenuItem";
            this.مدیریتپروژههاToolStripMenuItem.Size = new System.Drawing.Size(224, 34);
            this.مدیریتپروژههاToolStripMenuItem.Text = "مدیریت پروژه ها";
            this.مدیریتپروژههاToolStripMenuItem.Click += new System.EventHandler(this.مدیریتپروژههاToolStripMenuItem_Click);
            // 
            // کاربرانToolStripMenuItem
            // 
            this.کاربرانToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.وضعیتحسابهاToolStripMenuItem});
            this.کاربرانToolStripMenuItem.Name = "کاربرانToolStripMenuItem";
            this.کاربرانToolStripMenuItem.Size = new System.Drawing.Size(89, 33);
            this.کاربرانToolStripMenuItem.Text = "حسابداری";
            this.کاربرانToolStripMenuItem.Click += new System.EventHandler(this.کاربرانToolStripMenuItem_Click);
            // 
            // وضعیتحسابهاToolStripMenuItem
            // 
            this.وضعیتحسابهاToolStripMenuItem.Name = "وضعیتحسابهاToolStripMenuItem";
            this.وضعیتحسابهاToolStripMenuItem.Size = new System.Drawing.Size(247, 34);
            this.وضعیتحسابهاToolStripMenuItem.Text = "وضعیت پرداخت پروژه ها";
            // 
            // مشتریهاToolStripMenuItem
            // 
            this.مشتریهاToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ساختمشتریجدیدToolStripMenuItem,
            this.مدیریتمشتریهاToolStripMenuItem});
            this.مشتریهاToolStripMenuItem.Name = "مشتریهاToolStripMenuItem";
            this.مشتریهاToolStripMenuItem.Size = new System.Drawing.Size(90, 33);
            this.مشتریهاToolStripMenuItem.Text = "مشتری ها";
            // 
            // ساختمشتریجدیدToolStripMenuItem
            // 
            this.ساختمشتریجدیدToolStripMenuItem.Name = "ساختمشتریجدیدToolStripMenuItem";
            this.ساختمشتریجدیدToolStripMenuItem.Size = new System.Drawing.Size(224, 34);
            this.ساختمشتریجدیدToolStripMenuItem.Text = "ساخت مشتری جدید";
            this.ساختمشتریجدیدToolStripMenuItem.Click += new System.EventHandler(this.ساختمشتریجدیدToolStripMenuItem_Click);
            // 
            // مدیریتمشتریهاToolStripMenuItem
            // 
            this.مدیریتمشتریهاToolStripMenuItem.Name = "مدیریتمشتریهاToolStripMenuItem";
            this.مدیریتمشتریهاToolStripMenuItem.Size = new System.Drawing.Size(224, 34);
            this.مدیریتمشتریهاToolStripMenuItem.Text = "مدیریت مشتری ها";
            this.مدیریتمشتریهاToolStripMenuItem.Click += new System.EventHandler(this.مدیریتمشتریهاToolStripMenuItem_Click);
            // 
            // خروجToolStripMenuItem
            // 
            this.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
            this.خروجToolStripMenuItem.Size = new System.Drawing.Size(61, 33);
            this.خروجToolStripMenuItem.Text = "خروج";
            this.خروجToolStripMenuItem.Click += new System.EventHandler(this.خروجToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(557, 155);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(640, 374);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtuser;
        private TextBox txtpass;
        private Button ورود;
        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem پروژههاToolStripMenuItem;
        private ToolStripMenuItem ساختپروژهجدیدToolStripMenuItem;
        private ToolStripMenuItem مدیریتپروژههاToolStripMenuItem;
        private ToolStripMenuItem کاربرانToolStripMenuItem;
        private ToolStripMenuItem وضعیتحسابهاToolStripMenuItem;
        private ToolStripMenuItem مشتریهاToolStripMenuItem;
        private ToolStripMenuItem ساختمشتریجدیدToolStripMenuItem;
        private ToolStripMenuItem مدیریتمشتریهاToolStripMenuItem;
        private ToolStripMenuItem خروجToolStripMenuItem;
        private PictureBox pictureBox1;
    }
}