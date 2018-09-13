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
    public partial class FormSale : Form
    {
        public FormSale()
        {
            InitializeComponent();            
        }

        private void FormSale_Load(object sender, EventArgs e)
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
            try
            {
                ClassConnection.connectionDatabase();
                string sqls = "";
                //MessageBox.Show(txtID.Text);

                sqls = @"INSERT INTO tbsale(saleid, saletotal, saledate) VALUES(@a,@b,@c)";
                OleDbCommand yourCommands = new OleDbCommand(sqls, ClassConnection.connection);
                yourCommands.Parameters.AddWithValue("a", Convert.ToString(txtID.Text));
                yourCommands.Parameters.AddWithValue("b", Convert.ToString(lblTotal.Text));
                yourCommands.Parameters.AddWithValue("c", dateTimepicker1.Value.ToShortDateString());
                yourCommands.ExecuteNonQuery();

                for (int i = 0; i <= listView1.Items.Count - 1; i++)
                {
                    ClassConnection.connectionDatabase();

                    string Sql = @"INSERT INTO tbsaleitem(saleid, Id_product, N_customer, saleitemqty) VALUES(@a, @b, @c, @d)";
                    ClassConnection.command = new OleDbCommand(Sql, ClassConnection.connection);
                    ClassConnection.command.Parameters.AddWithValue("a", txtID.Text);
                    ClassConnection.command.Parameters.AddWithValue("b", listView1.Items[i].SubItems[0].Text);    // รหัสสินค้า
                    ClassConnection.command.Parameters.AddWithValue("c", listView1.Items[i].SubItems[3].Text);     // ชื่อลูกค้า
                    ClassConnection.command.Parameters.AddWithValue("d", Convert.ToInt32(listView1.Items[i].SubItems[2].Text));    // จำนวนเบิก

                    ClassConnection.command.ExecuteNonQuery();

                    string sqlStrings = "";

                    sqlStrings = "UPDATE tbproduct SET unit = unit - @a WHERE Id_product= @id";
                    OleDbCommand myCommands = new OleDbCommand(sqlStrings, ClassConnection.connection);
                    myCommands.Parameters.AddWithValue("a", Convert.ToInt32(listView1.Items[i].SubItems[2].Text));
                    myCommands.Parameters.AddWithValue("id", Convert.ToString(listView1.Items[i].SubItems[0].Text));
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

        bool firstTime = true;

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

            /*string TempID = "";
            for (int i = 0; i <= listView1.Items.Count - 1; i++)
            {
                TempID = listView1.Items[i].SubItems[0].Text;
                if (txtProID.Text == TempID)
                {
                    MessageBox.Show("คุณเลือกรหัสสินค้าซ้ำกัน", "ตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtProID.Focus();
                    return;
                }
            }*/

            if (firstTime == true)
            {
                ListViewItem item = new ListViewItem(new string[] { txtProID.Text, txtProName.Text, txtQty.Text, txtCustomer.Text, txtTotal.Text });
                listView1.Items.Add(item);

                int proSale = 0;
                int total = 0;
                for (int i = 0; i <= listView1.Items.Count - 1; i++)
                {
                    proSale = Convert.ToInt32(listView1.Items[i].SubItems[2].Text); // จำนวนเบิก
                                                                                    //proQty = Convert.ToInt32(listView1.Items[i].SubItems[2].Text);
                    total = total + proSale;    // จำนวนเบิกรวม
                                                //saleTotal = saleTotal + proQty;

                    lblTotal.Text = Convert.ToString(total);
                }

                firstTime = false;
            }

            else
            {
                string TempID = "";
                int proSale = 0;
                int proQty = 0;
                int total = 0;
                int sum = 0;

                for (int i = 0; i <= listView1.Items.Count - 1; i++)
                {
                    TempID = listView1.Items[i].SubItems[0].Text;   // Id_product

                    if (txtProID.Text == TempID)    // Duplicate product
                    {
                        proQty = Convert.ToInt32(listView1.Items[i].SubItems[4].Text);
                        proSale = Convert.ToInt32(txtQty.Text);

                        total = proQty - proSale;

                        if (total < 0)  // เบิกไม่ได้
                        {
                            MessageBox.Show("สินค้าเหลือไม่พอเบิก", "ตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtProID.Focus();
                            return;
                        }

                        else
                        {
                            ListViewItem item = new ListViewItem(new string[] { txtProID.Text, txtProName.Text, txtQty.Text, txtCustomer.Text, Convert.ToString(total) });
                            listView1.Items.Add(item);
                            
                            sum = Convert.ToInt32(lblTotal.Text) + Convert.ToInt32(txtQty.Text);

                            lblTotal.Text = Convert.ToString(sum);

                            return;
                        }
                    }
                }
            }
            //txtTotal.Text = Convert.ToString(saleTotal);

            txtProID.Text = "";
            txtProName.Text = "";          
            txtProQty.Text = "";
            txtTotal.Text = "";
            txtCustomer.Text = "";
            txtQty.Text = "";
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
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            FormSaleSearch form = new FormSaleSearch();
            form.ShowDialog();
            if (form.IsSelect)
            {
                try
                {
                    txtProID.Text = form.productId.ToString();
                    txtProName.Text = form.productName.ToString();
                    txtProQty.Text = form.productQty.ToString();
                    txtQty.Focus();
                }
                catch
                {

                }
            }
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                int ptoQty = Convert.ToInt32(txtQty.Text.Trim());
                int qty = Convert.ToInt32(txtProQty.Text.Trim());
                if (ptoQty > qty)   // Sell > Product
                {
                    MessageBox.Show("จำนวนไม่เพียงพอกรุณาตรวจสอบ", "ตรวจสอบ");
                    txtQty.Text = "";
                    txtQty.Focus();
                    return;
                }

                int sum = 0;
                int a = 0;
                int b = 0;
                a = Convert.ToInt32(txtProQty.Text);
                b = Convert.ToInt32(txtQty.Text);
                sum = a - b;
                txtTotal.Text = Convert.ToString(sum);
            }
            catch (Exception ex)
            {
                txtTotal.Text = "";
                txtQty.Focus();
            }
        }

        private void ListViewDetail()
        {
            listView1.Columns.Add("รหัสสินค้า", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("ชื่อสินค้า", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("จำนวนเบิก", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("ชื่อลูกค้า", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("คงเหลือ", 100, HorizontalAlignment.Left);
        }


        private void EnabledTrue()
        {
            dateTimepicker1.Enabled = true;
            txtProID.Enabled = true;
            txtProQty.Enabled = true;
            listView1.Enabled = true;
            txtQty.Enabled = true;
            txtCustomer.Enabled = true;
            ButtonSearch.Enabled = true;
            ListViewDetail();
        }

        private void EnabledFalse()
        {
            dateTimepicker1.Enabled = false;
            txtProID.Enabled = false;
            txtProQty.Enabled = false;
            listView1.Enabled = false;
            txtQty.Enabled = false;
            txtCustomer.Enabled = false;
            ButtonSearch.Enabled = false;
        }

        private void ClearData()
        {
            dateTimepicker1.Text = String.Format("{0:d MMMM yyyy}", DateTime.Now);
            txtID.Text = "";
            txtProID.Text = "";
            txtProQty.Text = "";
            txtProName.Text = "";
            txtTotal.Text = "";
            txtQty.Text = "";
            txtCustomer.Text = "";
            txt.Text = "";
            listView1.Clear();

            txtProID.Focus();
        }

        private void MaxID()
        {
            int maxId = 0;
            ClassConnection.connectionDatabase();
            string Sql = @"SELECT MAX(saleid) FROM tbsale";
            ClassConnection.command = new OleDbCommand(Sql, ClassConnection.connection);
            //ClassConnection.DataReader = ClassConnection.Command.ExecuteReader();
            try
            {
                maxId = Convert.ToInt32(ClassConnection.command.ExecuteScalar());
                //MessageBox.Show(maxId.ToString());
            }
            catch (Exception ex)
            {
                maxId = 0;
            }
            txtID.Text = (maxId + 1).ToString("000");
            
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtProID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
