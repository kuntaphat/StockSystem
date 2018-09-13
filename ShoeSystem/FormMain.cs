using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ShoeSystem
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }


        private void ออกจากระบบToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ต้องการออกจากระบบใช่หรือไม่?", "ตรวจสอบ", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                FormLogin form = new FormLogin();
                form.ShowDialog();
            }
            else
            {
                return;
            }
        }

        private void จดการสนคาToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormProduct form = new FormProduct();
            form.ShowDialog();
        }

        private void จดการประเภทสนคาToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormType form = new FormType();
            form.ShowDialog();
        }

        private void ซอสนคาToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBuy form = new FormBuy();
            form.ShowDialog();
        }

        private void ขายสนคาToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSale form = new FormSale();
            form.ShowDialog();
        }

        private void จดการพนกงานToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmployee form = new FormEmployee();
            form.ShowDialog();
        }

        private void การขายToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReportSale form = new FormReportSale();
            form.ShowDialog();
        }

        private void การซอToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReportBuy form = new FormReportBuy();
            form.ShowDialog();
        }

        private void เชคสตอกToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReportStock form = new FormReportStock();
            form.ShowDialog();
        }
    }
}
