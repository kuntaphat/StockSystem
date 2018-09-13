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
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
        }
        string _idcat;

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
            string Sql = @"SELECT * FROM tbemployee WHERE Id_employee Like @name
                            OR N_employee Like @name
                            ORDER BY Id_employee";
            ClassConnection.command = new OleDbCommand(Sql, ClassConnection.connection);
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
            else if (textBoxCard.Text == "")
            {
                textBoxCard.Focus();
                return;
            }
            else if (textBoxAddress.Text == "")
            {
                textBoxAddress.Focus();
                return;
            }
            else if (textBoxTel.Text == "")
            {
                textBoxTel.Focus();
                return;
            }
            else if (textBoxUsername.Text == "")
            {
                textBoxUsername.Focus();
                return;
            }
            else if (textBoxPassword.Text == "")
            {
                textBoxPassword.Focus();
                return;
            }
            
            if (ClassConnection.count == 1)
            {
                ClassConnection.connectionDatabase();

                string Sql = @"SELECT * FROM tbemployee WHERE N_employee = '" + textBoxName.Text + "'";

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
                    OleDbTransaction tr = ClassConnection.connection.BeginTransaction();
                    try
                    {
                        ClassConnection.connectionDatabase();
                        string SqlInsert = @"INSERT INTO tbemployee(Id_employee, N_employee, card_employee, address_employee, tel_employee, [username], [password])
                                                VALUES(@a,@b,@c,@d,@e,@f,@g)";
                        ClassConnection.command = new OleDbCommand(SqlInsert, ClassConnection.connection);
                        ClassConnection.command.Parameters.AddWithValue("a", textBoxID.Text);
                        ClassConnection.command.Parameters.AddWithValue("b", textBoxName.Text);
                        ClassConnection.command.Parameters.AddWithValue("c", textBoxCard.Text);
                        ClassConnection.command.Parameters.AddWithValue("d", textBoxAddress.Text);
                        ClassConnection.command.Parameters.AddWithValue("e", textBoxTel.Text);
                        ClassConnection.command.Parameters.AddWithValue("f", textBoxUsername.Text);
                        ClassConnection.command.Parameters.AddWithValue("g", textBoxPassword.Text);
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
                    string SqlUpdate = @"UPDATE tbemployee SET N_employee =@b,card_employee =@c,address_employee =@d,tel_employee =@e,[username] =@f,[password] =@g WHERE Id_employee = @id";
                    ClassConnection.command = new OleDbCommand(SqlUpdate, ClassConnection.connection);
                    ClassConnection.command.Parameters.AddWithValue("b", textBoxName.Text);
                    ClassConnection.command.Parameters.AddWithValue("c", textBoxCard.Text);
                    ClassConnection.command.Parameters.AddWithValue("d", textBoxAddress.Text);
                    ClassConnection.command.Parameters.AddWithValue("e", textBoxTel.Text);
                    ClassConnection.command.Parameters.AddWithValue("f", textBoxUsername.Text);
                    ClassConnection.command.Parameters.AddWithValue("g", textBoxPassword.Text);
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
            if (result == DialogResult.Cancel || result == DialogResult.No)
            {
                return;
            }
            OleDbTransaction tr = ClassConnection.connection.BeginTransaction();
            try
            {
                ClassConnection.connectionDatabase();
                string Sql = @"DELETE FROM tbemployee WHERE Id_employee = @id";
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

                textBoxID.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                textBoxName.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                textBoxCard.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                textBoxAddress.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                textBoxTel.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                textBoxUsername.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                textBoxPassword.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());

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


        //private void MaxID()
        //{
        //    int maxId = 0;
        //    ClassConnection.connectionDatabase();
        //    ClassConnection.Sql = @"SELECT MAX(Pro_ID) FROM Product";
        //    ClassConnection.Command = new SqlCommand(ClassConnection.Sql, ClassConnection.Connection);
        //    //ClassConnection.DataReader = ClassConnection.Command.ExecuteReader();
        //    try
        //    {
        //        maxId = Convert.ToInt32(ClassConnection.Command.ExecuteScalar());
        //    }
        //    catch (Exception ex)
        //    {
        //        maxId = 0;
        //    }
        //    textBoxID.Text = (maxId + 1).ToString();
        //}

        private void EnabledTrue()
        {
            textBoxID.Enabled = true;
            textBoxName.Enabled = true;
            textBoxCard.Enabled = true;
            textBoxTel.Enabled = true;
            textBoxAddress.Enabled = true;
            textBoxUsername.Enabled = true;
            textBoxPassword.Enabled = true;
        }
        private void EnabledFalse()
        {
            textBoxID.Enabled = false;
            textBoxName.Enabled = false;
            textBoxCard.Enabled = false;
            textBoxTel.Enabled = false;
            textBoxAddress.Enabled = false;
            textBoxUsername.Enabled = false;
            textBoxPassword.Enabled = false;
        }

        private void ClearData()
        {
            textBoxID.Text = "";
            textBoxName.Text = "";
            textBoxCard.Text = "";
            textBoxTel.Text = "";
            textBoxAddress.Text = "";
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            textBoxID.Focus();
        }

        private void ShowData()
        {
            ClassConnection.connectionDatabase();
            string Sql = @"SELECT * FROM tbemployee ORDER BY Id_employee";
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
            dataGridView1.Columns[0].HeaderText = "รหัสพนักงาน";
            dataGridView1.Columns[1].HeaderText = "ชื่อพนักงาน";
            dataGridView1.Columns[2].HeaderText = "บัตรประชาชน";
            dataGridView1.Columns[3].HeaderText = "ที่อยู่";
            dataGridView1.Columns[4].HeaderText = "เบอร์โทร";
            dataGridView1.Columns[5].HeaderText = "username";
            dataGridView1.Columns[6].HeaderText = "password";

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
