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
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
        }
        string _idcat;

        private void FormInventory_Load(object sender, EventArgs e)
        {
            ClassConnection.connectionDatabase();
            showcombobox();
            ShowData();
            EnabledFalse();
            buttonDelete.Enabled = false;
            buttonSave.Enabled = false;
            buttonCancel.Enabled = false;
        }

        private void showcombobox()
        {
            try
            {
                comboBox1.Items.Clear();
                ClassConnection.connectionDatabase();
                string Sql = "SELECT Distinct N_category FROM tbcategory ORDER BY N_category";
                ClassConnection.command = new OleDbCommand(Sql, ClassConnection.connection);
                OleDbDataReader DataReader = ClassConnection.command.ExecuteReader();
                while (DataReader.Read())
                {
                    comboBox1.Items.Add(DataReader["N_category"]);
                }               
                DataReader.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message.ToString());
                comboBox1.Text = "";
            }
        }   

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            ClassConnection.connectionDatabase();
            string Sql = @"SELECT tbproduct.Id_product, tbproduct.N_product, tbproduct.N_product_desc, tbproduct.N_seller,
                           tbcategory.N_category, tbproduct.pricebuy, tbproduct.unit
                            FROM tbproduct,tbcategory WHERE tbproduct.Id_category = tbcategory.Id_category
                            AND (tbproduct.Id_product Like @name
                            OR tbproduct.N_product Like @name)
                            ORDER BY tbproduct.Id_product";
            ClassConnection.command = new OleDbCommand(Sql, ClassConnection.connection);
            ClassConnection.command.Parameters.AddWithValue("name", "%" + textBoxSearch.Text + "%");//ค้นหา
            OleDbDataReader DataReader = ClassConnection.command.ExecuteReader();
            ClassConnection.dataTable = new DataTable();
            ClassConnection.dataTable.Load(DataReader);
            dataGridView1.DataSource = ClassConnection.dataTable;
            FormatDataGridView();
        }

        private void buttonSearchAll_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ClassConnection.count = 1;
            buttonAdd.Enabled = false;
            buttonEdit.Enabled = false;
            buttonDelete.Enabled = false;
            buttonCancel.Enabled = true;
            buttonSave.Enabled = true;
            EnabledTrue();
            ClearData();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            ClassConnection.count = 2;
            buttonAdd.Enabled = false;
            buttonEdit.Enabled = false;
            buttonDelete.Enabled = false;
            buttonCancel.Enabled = true;
            buttonSave.Enabled = true;
            textBoxID.Enabled = false;
            EnabledTrue();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            if (textBoxID.Text == "")
            {
                textBoxID.Focus();
                return;
            }
            else if (textBoxName.Text == "")
            {
                textBoxName.Focus();
                return;
            }
            else if (textboxDesc.Text == "")
            {
                textBoxName.Focus();
                return;
            }
            else if (comboBox1.Text == "")
            {
                comboBox1.Select();
                return;
            }
            else if (textboxSeller.Text == "")
            {
                textBoxPriceBuy.Focus();
                return;
            }
            else if (textBoxPriceBuy.Text == "")
            {
                textBoxPriceBuy.Focus();
                return;
            }
            else if (textBoxNum.Text == "")
            {
                textBoxNum.Focus();
                return;
            }
            
            if (ClassConnection.count == 1)
            {
                ClassConnection.connectionDatabase();

                string Sql = @"SELECT * FROM tbproduct WHERE N_product = '" + textBoxName.Text + "'";

                ClassConnection.command = new OleDbCommand(Sql, ClassConnection.connection);

                OleDbDataReader DataReader= ClassConnection.command.ExecuteReader();

                if (DataReader.HasRows)
                {
                    MessageBox.Show("มีข้อมูลซ้ำกรุณาตรวจสอบ", "ตรวจสอบ");
                    return;
                }
                else
                {
                    DataReader.Close();
                    OleDbTransaction tr = ClassConnection.connection.BeginTransaction();//คนแรกให้เข้าคนที่สองเข้ามาซ้ำไม่ได้
                    try
                    {
                        ClassConnection.connectionDatabase();
                        string SqlInsert = @"INSERT INTO tbproduct(Id_product, N_product, N_product_desc, Id_category, N_seller, pricebuy ,unit)
                                                VALUES(@a,@b,@c,@d,@e,@f,@g)";
                        ClassConnection.command = new OleDbCommand(SqlInsert, ClassConnection.connection);
                        ClassConnection.command.Parameters.AddWithValue("a", textBoxID.Text);
                        ClassConnection.command.Parameters.AddWithValue("b", textBoxName.Text);
                        ClassConnection.command.Parameters.AddWithValue("c", textboxDesc.Text);                   
                        ClassConnection.command.Parameters.AddWithValue("d", _idcat);
                        ClassConnection.command.Parameters.AddWithValue("e", textboxSeller.Text);
                        ClassConnection.command.Parameters.AddWithValue("f", textBoxPriceBuy.Text);
                        ClassConnection.command.Parameters.AddWithValue("g", textBoxNum.Text);
                        int result = ClassConnection.command.ExecuteNonQuery();
                        if (result == -1)
                        {
                            MessageBox.Show("เกิดข้อผิดพลาด ไม่สามารถเพิ่มข้อมูลได้", "ตรวจสอบ");
                            tr.Rollback();
                        }
                        else
                        {
                            MessageBox.Show("บันทึกข้อมูลแล้ว", "ตรวจสอบ");
                            tr.Commit();
                        }
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                        tr.Rollback();

                    }//หาสาเหตุ
                    finally
                    {
                        ClassConnection.connectionDatabase();
                        tr.Dispose();
                    }
                }
            }
            else if (ClassConnection.count == 2)
            {
                OleDbTransaction tr = ClassConnection.connection.BeginTransaction();
                try
                {
                    ClassConnection.connectionDatabase();
                    string SqlUpdate = @"UPDATE tbproduct SET N_product =@b, N_product_desc =@c, Id_category =@d, N_seller =@e, pricebuy =@f,unit =@g WHERE Id_product = @id";
                    ClassConnection.command = new OleDbCommand(SqlUpdate, ClassConnection.connection);
                    ClassConnection.command.Parameters.AddWithValue("b", textBoxName.Text);
                    ClassConnection.command.Parameters.AddWithValue("c", textboxDesc.Text);
                    ClassConnection.command.Parameters.AddWithValue("d", _idcat);
                    ClassConnection.command.Parameters.AddWithValue("e", textboxSeller.Text);
                    ClassConnection.command.Parameters.AddWithValue("f", textBoxPriceBuy.Text);
                    ClassConnection.command.Parameters.AddWithValue("g", textBoxNum.Text);
                    ClassConnection.command.Parameters.AddWithValue("id", textBoxID.Text);
                    int result = ClassConnection.command.ExecuteNonQuery();
                    if (result == -1)
                    {
                        MessageBox.Show("เกิดข้อผิดพลาด ไม่สามารถแก้ไขข้อมูลได้", "ตรวจสอบ");
                        tr.Rollback();
                    }
                    else
                    {
                        MessageBox.Show("แก้ไขข้อมูลแล้ว", "ตรวจสอบ");
                        tr.Commit();
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                    tr.Rollback();
                }
                finally
                {
                    ClassConnection.connectionDatabase();
                    tr.Dispose();
                }

            }
            buttonSave.Enabled = false;
            buttonCancel.Enabled = false;
            buttonAdd.Enabled = true;
            buttonEdit.Enabled = true;
            buttonDelete.Enabled = true;
            ClearData();
            ShowData();
            ClassConnection.count = 0;
            EnabledFalse();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ต้องการลบข้อมูลจริงหรือไม่", "ยืนยันการลบ", MessageBoxButtons.YesNo);
            if (result == DialogResult.No || result == DialogResult.Cancel)
            {
                return;
            }
            OleDbTransaction tr = ClassConnection.connection.BeginTransaction();
            try
            {
                ClassConnection.connectionDatabase();
                string Sql = @"DELETE FROM tbproduct WHERE Id_product = @id";
                ClassConnection.command = new OleDbCommand(Sql, ClassConnection.connection);
                ClassConnection.command.Parameters.AddWithValue("id", textBoxID.Text);
                int r = (int)ClassConnection.command.ExecuteNonQuery();
                if (r == -1)
                {
                    MessageBox.Show("เกิดข้อผิดพลาด ไม่สามารถลบข้อมูลได้", "ตรวจสอบ");
                    tr.Rollback();
                }
                else
                {
                    MessageBox.Show("ลบข้อมูลแล้ว", "ตรวจสอบ");
                    tr.Commit();
                    ClearData();
                    ShowData();
                }
            }
            catch
            {
                tr.Rollback();
            }
            finally
            {
                ClassConnection.connectionDatabase();
                tr.Dispose();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ClassConnection.connectionDatabase();
            ClearData();
            ShowData();
            EnabledFalse();
            buttonAdd.Enabled = true;
            buttonEdit.Enabled = true;
            buttonDelete.Enabled = false;
            buttonSave.Enabled = false;
            buttonCancel.Enabled = false;
        }

        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1)
                {
                    return;
                }

                textBoxID.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());    // รหัสสินค้า
                textBoxName.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());  // ชื่อสินค้า
                textboxDesc.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());    // รายละเอียด
                comboBox1.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());    // ประเภทสินค้า
                textboxSeller.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());    // คนขาย
                textBoxPriceBuy.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());   // ราคาต่อหน่วย
                textBoxNum.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());   // จำนวน

                buttonEdit.Enabled = true;
                buttonDelete.Enabled = true;
            }
            catch
            {
                buttonEdit.Enabled = false;
                buttonDelete.Enabled = false;
                ClearData();
            }
        }

        private void EnabledTrue()
        {
            textBoxID.Enabled = true;
            textBoxName.Enabled = true;
            textboxDesc.Enabled = true;
            comboBox1.Enabled = true;           
            textBoxPriceBuy.Enabled = true;
            textboxSeller.Enabled = true;
            textBoxNum.Enabled = true;
        }
        private void EnabledFalse()
        {
            textBoxID.Enabled = false;
            textBoxName.Enabled = false;
            textboxDesc.Enabled = false;
            comboBox1.Enabled = false;
            textBoxPriceBuy.Enabled = false;
            textboxSeller.Enabled = false;
            textBoxNum.Enabled = false;
        }

        private void ClearData()
        {
            textBoxID.Text = "";
            textBoxName.Text = "";
            textboxDesc.Text = "";
            comboBox1.Text = "";
            textBoxPriceBuy.Text = "";
            textboxSeller.Text = "";
            textBoxNum.Text = "";
            textBoxID.Focus();
        }

        private void ShowData()
        {
            ClassConnection.connectionDatabase();
            string Sql = @"SELECT tbproduct.Id_product,tbproduct.N_product,tbproduct.N_product_desc,tbcategory.N_category,tbproduct.N_seller, tbproduct.pricebuy,tbproduct.unit
                            FROM tbproduct,tbcategory WHERE tbproduct.Id_category = tbcategory.Id_category
                            ORDER BY tbproduct.Id_product";
            ClassConnection.command = new OleDbCommand(Sql, ClassConnection.connection);
            OleDbDataReader DataReader = ClassConnection.command.ExecuteReader();
            if (DataReader.HasRows)
            {
                ClassConnection.dataTable = new DataTable();
                ClassConnection.dataTable.Load(DataReader);
                dataGridView1.DataSource = ClassConnection.dataTable;
                FormatDataGridView();
                DataReader.Close();
            }
            else
            {
                ClassConnection.dataTable = new DataTable();
                ClassConnection.dataTable.Load(DataReader);
                dataGridView1.DataSource = ClassConnection.dataTable;
                FormatDataGridView();
                DataReader.Close();
            }
        }

        private void FormatDataGridView()
        {
            dataGridView1.Columns[0].HeaderText = "รหัสสินค้า";    // Id_product
            dataGridView1.Columns[1].HeaderText = "ชื่อสินค้า";     // N_product
            dataGridView1.Columns[2].HeaderText = "รายละเอียดสินค้า";  // N_product_desc
            dataGridView1.Columns[3].HeaderText = "ผู้ขาย";
            dataGridView1.Columns[4].HeaderText = "ชื่อประเภทสินค้า";   // tbcatedory.N_category
            dataGridView1.Columns[5].HeaderText = "ราคาต่อหน่วย";    // pricebuy
            dataGridView1.Columns[6].HeaderText = "จำนวนที่มี"; // unit

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            //dataGridView1.Columns[2].Visible = false;
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //comboBox1.Items.Clear();
                ClassConnection.connectionDatabase();
                string Sql = "SELECT Id_category FROM tbcategory WHERE N_category =@cat";
                ClassConnection.command = new OleDbCommand(Sql, ClassConnection.connection);
                ClassConnection.command.Parameters.AddWithValue("cat",comboBox1.Text);
                OleDbDataReader DataReader = ClassConnection.command.ExecuteReader();
                DataReader.Read();
                _idcat = DataReader["Id_category"].ToString();
                DataReader.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message.ToString());
                comboBox1.Text = "";
            }
        }

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            /*if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }*/
        }

        private void textBoxPriceBuy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            /*if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }*/
        }
    }
}
