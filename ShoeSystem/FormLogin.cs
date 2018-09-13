using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ShoeSystem
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "")
            {
               textBoxUsername.Focus();
                return;
            }
            else if (textBoxPassword.Text == "")
            {   
                textBoxPassword.Focus();
                return;
            }
         
            ClassConnection.connectionDatabase();
            string sql = @"SELECT * FROM tbemployee WHERE username = @username AND password = @password";
            ClassConnection.command = new OleDbCommand(sql, ClassConnection.connection);
            ClassConnection.command.Parameters.AddWithValue("username", textBoxUsername.Text);
            ClassConnection.command.Parameters.AddWithValue("password", textBoxPassword.Text);

            OleDbDataReader DataReader = ClassConnection.command.ExecuteReader();//รับค่าcommand 
            DataReader.Read();
            if (DataReader.HasRows)//hasrow มีค่าซ้ำ
            {
                FormMain form = new FormMain();//เชื่อมไปอีกฟอม
                MessageBox.Show("ยินดีต้อนรับเข้าสู่ระบบ", "ตรวจสอบ", MessageBoxButtons.OK);
                this.Hide();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("username หรือ password ไม่ถูกต้อง", "ตรวจสอบ", MessageBoxButtons.OK);
            }
            ClearData();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(this, "คุณต้องการออกจากโปรแกรมใช่หรือไม่? ", "ตรวจสอบ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void ClearData()//clear data
        {
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            textBoxUsername.Focus();
        }

    }
}
