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
    public partial class FormBuy : Form
    {
        public FormBuy()
        {
            InitializeComponent();
        }

        private void FormImport_Load(object sender, EventArgs e)
        {
            ClassConnection.connectionDatabase();
            ClearData();
            EnabledFalse();
            ButtonOpen.Enabled = true;
            ButtonAdd.Enabled = false;
            ButtonDelete.Enabled = false;
            ButtonCancel.Enabled = false;
            ButtonSave.Enabled = false;
        }

        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            ClassConnection.count = 1;
            ButtonOpen.Enabled = false;
            ButtonAdd.Enabled = true;
            ButtonDelete.Enabled = true;
            ButtonCancel.Enabled = true;
            ButtonSave.Enabled = true;
            ClearData();
            EnabledTrue();
            MaxID();
            //ListViewDetail();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            try
            {
                ClassConnection.connectionDatabase();
                string sqls = "";
                sqls = "INSERT INTO tbbuy(buyid,buytotal,buydate)";
                sqls += " VALUES(@a,@b,@c)";
                OleDbCommand yourCommands = new OleDbCommand(sqls, ClassConnection.connection);
                yourCommands.Parameters.AddWithValue("a", txtID.Text);
                yourCommands.Parameters.AddWithValue("b", Convert.ToDouble(lblTotal.Text));
                yourCommands.Parameters.AddWithValue("c", dateTimepicker1.Value.ToShortDateString());
                yourCommands.ExecuteNonQuery();

                for (int i = 0; i <= listView1.Items.Count - 1; i++)
                {

                    ClassConnection.connectionDatabase();
                    string Sql = @"INSERT INTO tbbuyitem(buyid,Id_product,buyitempricebuy,buyitemqty,buyitemtotal) VALUES(@a,@b,@c,@d,@e)";
                    ClassConnection.command = new OleDbCommand(Sql, ClassConnection.connection);
                    ClassConnection.command.Parameters.AddWithValue("a", txtID.Text);
                    ClassConnection.command.Parameters.AddWithValue("b", Convert.ToString(listView1.Items[i].SubItems[0].Text));
                    ClassConnection.command.Parameters.AddWithValue("c", Convert.ToInt32(listView1.Items[i].SubItems[3].Text));
                    ClassConnection.command.Parameters.AddWithValue("d", Convert.ToDouble(listView1.Items[i].SubItems[2].Text));
                    ClassConnection.command.Parameters.AddWithValue("e", Convert.ToDouble(listView1.Items[i].SubItems[4].Text));
                    ClassConnection.command.ExecuteNonQuery();

                    string sqlStrings = "";

                    sqlStrings = "UPDATE tbproduct SET unit = unit + @a WHERE Id_product= @id";
                    OleDbCommand myCommands = new OleDbCommand(sqlStrings, ClassConnection.connection);
                    myCommands.Parameters.AddWithValue("a", Convert.ToInt32(listView1.Items[i].SubItems[2].Text));
                    myCommands.Parameters.AddWithValue("id", listView1.Items[i].SubItems[0].Text);
                    myCommands.ExecuteNonQuery();
                }

                MessageBox.Show("บันทึกเรียบร้อยแล้ว", "ตรวจสอบ", MessageBoxButtons.OK);
                //ClassSale.SalePrintID = TextBox1.Text.Trim();

                ClassConnection.connectionDatabase();
                ClearData();
                EnabledFalse();
                ButtonOpen.Enabled = true;
                ButtonAdd.Enabled = false;
                ButtonDelete.Enabled = false;
                ButtonCancel.Enabled = false;
                ButtonSave.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }


        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            ClearData();
            EnabledFalse();
            ButtonOpen.Enabled = true;
            ButtonAdd.Enabled = false;
            ButtonDelete.Enabled = false;
            ButtonCancel.Enabled = false;
            ButtonSave.Enabled = false;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (txtProID.Text == "")
            {
                txtProID.Focus();
                return;
            }
            else if (txtProQty.Text == "")
            {
                txtProQty.Focus();
                return;
            }
           
            string TempID = "";
            for (int i = 0; i <= listView1.Items.Count - 1; i++)
            {
                TempID = listView1.Items[i].SubItems[0].Text;
                if (txtProID.Text == TempID)
                {
                    MessageBox.Show("คุณเลือกรหัสสินค้าซ้ำกัน", "ตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtProID.Focus();
                    return;
                }
            }

            ListViewItem item = new ListViewItem(new string[] {txtProID.Text, txtProName.Text, txtProQty.Text, txtProPrice.Text, txtTotal.Text});
            listView1.Items.Add(item);

            int aaaa = 0;
            int bbbb = 0;
            int ssss = 0;
            int tttt = 0;
           
            for (int i = 0; i <= listView1.Items.Count - 1; i++)
            {
                aaaa = Convert.ToInt32(listView1.Items[i].SubItems[4].Text);
                bbbb = Convert.ToInt32(listView1.Items[i].SubItems[2].Text);
                ssss = ssss + aaaa;
                tttt = tttt + bbbb;

            }

            lblTotal.Text = Convert.ToString(ssss);

 
            txt.Text = Convert.ToString(tttt);           txtProID.Text = "";
            txtProName.Text = "";
            txtProPrice.Text = "";
            txtProQty.Text = "";
            txtTotal.Text = "";
       txtProID.Focus();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
            {
                return;
            }
            int aaaa = 0;
            int bbbb = 0;
            for (int i = 0; i <= listView1.Items.Count - 1; i++)
            {
                aaaa = Convert.ToInt32(listView1.Items[i].SubItems[4].Text);
                bbbb = Convert.ToInt32(listView1.Items[i].SubItems[2].Text);
            }
            listView1.TopItem.Remove();
            int sum = Convert.ToInt32(lblTotal.Text);
        
            int sums = Convert.ToInt32(txt.Text);    sum = sum - aaaa;
        
            sums = sums - bbbb;    lblTotal.Text = Convert.ToString(sum);
        
            txt.Text = Convert.ToString(sums);}

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            FormBuySearch form = new FormBuySearch();
            form.ShowDialog();
            if (form.IsSelect)
            {
                try
                {
                    txtProID.Text = form.productId.ToString();
                    txtProName.Text = form.productName.ToString();
                    txtProPrice.Text = form.productPrice.ToString();
                    txtProQty.Focus();
                }
                catch
                {

                }
            }
        }

        private void txtProQty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int sum = 0;
                int a = 0;
                int b = 0;
                a = Convert.ToInt32(txtProPrice.Text);
                b = Convert.ToInt32(txtProQty.Text);
                sum = a * b;
                txtTotal.Text = Convert.ToString(sum);
            }
            catch (Exception ex)
            {
                txtTotal.Text = "";
                txtProQty.Focus();
            }
        }

        private void ListViewDetail()
        {
            listView1.Columns.Add("รหัสสินค้า", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("ชื่อสินค้า", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("จำนวน", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("ราคา", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("ราคารวม", 100, HorizontalAlignment.Left);
        }


        private void EnabledTrue()
        {
            dateTimepicker1.Enabled = true;
            txtProID.Enabled = true;
            txtProQty.Enabled = true;
            listView1.Enabled = true;
            ButtonSearch.Enabled = true;
            ListViewDetail();
        }

        private void EnabledFalse()
        {
            //dateTimepicker1.Enabled = false;
            txtProID.Enabled = false;
            txtProQty.Enabled = false;
            listView1.Enabled = false;
            ButtonSearch.Enabled = false;
        }

        private void ClearData()
        {
            dateTimepicker1.Text = String.Format("{0:d MMMM yyyy}",DateTime.Now);
            txtID.Text = "";
            txtProID.Text = "";
            txtProQty.Text = "";
            txtProName.Text = "";
            txtProPrice.Text = "";
            txtTotal.Text = "0";
            listView1.Clear();
            txt.Text = "";
            lblTotal.Text = Convert.ToString(0);
            txtProID.Focus();
        }

        private void MaxID()
        {
            int maxId = 0;
            ClassConnection.connectionDatabase();
            string Sql = @"SELECT MAX(buyid) FROM tbbuy";
            ClassConnection.command = new OleDbCommand(Sql, ClassConnection.connection);
            //ClassConnection.DataReader = ClassConnection.Command.ExecuteReader();
            try
            {
                maxId = Convert.ToInt32(ClassConnection.command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                maxId = 0;
            }
            txtID.Text = (maxId + 1).ToString("000");
            textBox1.Text = txtID.Text;
        }

        private void txtProQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
