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
    public partial class FormType : Form
    {
        public FormType()
        {
            InitializeComponent();
        }

        private void FormInventory_Load(object sender, EventArgs e)
        {
            ClassConnection.connectionDatabase();
            ShowData();
            EnabledFalse();
            buttonDelete.Enabled = false;
            buttonSave.Enabled = false;
            buttonCancel.Enabled = false;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            ClassConnection.connectionDatabase();
            String sql = @"SELECT * FROM tbcategory WHERE Id_category Like @name OR N_category Like @name ORDER BY Id_category";
            ClassConnection.command = new OleDbCommand(sql, ClassConnection.connection);
            ClassConnection.command.Parameters.AddWithValue("name", "%" + textBoxSearch.Text + "%");
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
            EnabledTrue();
            textBoxID.Enabled = false;
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

            
            if (ClassConnection.count == 1)
            {
                ClassConnection.connectionDatabase();

                String Sql = @"SELECT * FROM tbcategory WHERE N_category = '" + textBoxName.Text + "'";

                ClassConnection.command = new OleDbCommand(Sql, ClassConnection.connection);

                OleDbDataReader DataReader = ClassConnection.command.ExecuteReader();

                if (DataReader.HasRows)
                {
                    MessageBox.Show("มีข้อมูลซ้ำกรุณาตรวจสอบ", "ตรวจสอบ");
                    return;
                }
                else
                {
                   DataReader.Close();
                    OleDbTransaction tr = ClassConnection.connection.BeginTransaction();
                    try
                    {
                        ClassConnection.connectionDatabase();
                        string SqlInsert = @"INSERT INTO tbcategory(Id_category,N_category)
                                                VALUES(@a,@b)";
                        ClassConnection.command = new OleDbCommand(SqlInsert, ClassConnection.connection);
                        ClassConnection.command.Parameters.AddWithValue("a", textBoxID.Text);
                        ClassConnection.command.Parameters.AddWithValue("b", textBoxName.Text);
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

                    }
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
                    string SqlUpdate = @"UPDATE tbcategory SET N_category =@b WHERE Id_category = @id";
                    ClassConnection.command = new OleDbCommand(SqlUpdate, ClassConnection.connection);
                    ClassConnection.command.Parameters.AddWithValue("b", textBoxName.Text);
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
            DialogResult result = MessageBox.Show("ต้องการลบข้อมูลจริงหรือไม่", "ยืนยันการลบ");
            if (result == DialogResult.Cancel)
            {
                return;
            }
            OleDbTransaction tr = ClassConnection.connection.BeginTransaction();
            try
            {
                ClassConnection.connectionDatabase();
                string SqlDelete = @"DELETE FROM tbcategory WHERE Id_category = @id";
                ClassConnection.command = new OleDbCommand(SqlDelete, ClassConnection.connection);
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

                textBoxID.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                textBoxName.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            
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
        }
        private void EnabledFalse()
        {
            textBoxID.Enabled = false;
            textBoxName.Enabled = false;
        }

        private void ClearData()
        {
            textBoxID.Text = "";
            textBoxName.Text = "";
            textBoxID.Focus();
        }

        private void ShowData()
        {
            ClassConnection.connectionDatabase();
            string Sql = @"SELECT * FROM tbcategory ORDER BY Id_category";
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
            dataGridView1.Columns[0].HeaderText = "รหัสประเภทสินค้า";
            dataGridView1.Columns[1].HeaderText = "ชื่อประเภทสินค้า";

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
