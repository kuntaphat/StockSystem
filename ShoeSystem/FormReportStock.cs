using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ShoeSystem
{
    public partial class FormReportStock : Form
    {
        private string StrConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=database.accdb;Persist Security Info=True;";
        private OleDbConnection Connection;
        private DataSet DataSt;
        private OleDbCommand command;
        private OleDbDataAdapter DataAdapter;
        private DataTable dataTable;
        private string Sql = "";

        public FormReportStock()
        {
            InitializeComponent();
        }

        private void FormatDataGridView()
        {
            dgvStock.Columns[0].HeaderText = "รหัสสินค้า";
            dgvStock.Columns[1].HeaderText = "ชื่อสินค้า";
            dgvStock.Columns[2].HeaderText = "รายละเอียดสินค้า";
            dgvStock.Columns[3].HeaderText = "ประเภทสินค้า";
            dgvStock.Columns[4].HeaderText = "ผู้ขาย";
            dgvStock.Columns[5].HeaderText = "ราคาต่อหน่วย";
            dgvStock.Columns[6].HeaderText = "จำนวน";


            dgvStock.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvStock.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvStock.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvStock.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvStock.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvStock.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvStock.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void ConnectionDatabase()
        {
            Connection = new OleDbConnection();
            if (Connection.State == ConnectionState.Open)
            {
                Connection.Close();
            }
            else {
                Connection.ConnectionString = StrConn;
                Connection.Open();
            }
        }

        private void DataReport(string filename)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workBook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet workSheet = null;

            workSheet = workBook.Sheets["Sheet1"];
            workSheet = workBook.ActiveSheet;
            workSheet.Name = "Sale Report";

            //app.Columns.ColumnWidth = 30;
            app.DisplayAlerts = false;
          
            System.Globalization.CultureInfo _cultureTHInfo = new System.Globalization.CultureInfo("th-TH");

            if(dgvStock.Rows.Count - 1 > 0)
            {
                for (int i = 1; i < dgvStock.Columns.Count + 1; i++)
                {
                    workSheet.Cells[1, i] = dgvStock.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgvStock.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgvStock.Columns.Count; j++)
                    {
                        /*if (j == 0)
                        {// Datetime

                            dt = Convert.ToDateTime(dgvStock.Rows[i].Cells[j].Value.ToString());
                            workSheet.Cells[i + 2, j + 1] = dt.ToString("dd MMM yyyy", _cultureTHInfo);
                        }*/

                        //else
                        workSheet.Cells[i + 2, j + 1] = dgvStock.Rows[i].Cells[j].Value.ToString();
                    }
                }

                string lastRow = "G" + Convert.ToString(dgvStock.Rows.Count);

                workSheet.Columns[1].ColumnWidth = 10;
                workSheet.Columns[2].AutoFit();
                workSheet.Columns[3].AutoFit();
                workSheet.Columns[4].AutoFit();
                workSheet.Columns[5].AutoFit();
                workSheet.Columns[6].ColumnWidth = 15;
                workSheet.Columns[7].ColumnWidth = 15;

                workSheet.get_Range("A1", lastRow).Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                workSheet.get_Range("A1", "G1").Cells.Font.Bold = true;     // Header
                //workSheet.get_Range("A1", lastRow).Columns.AutoFit();
                //workSheet.get_Range("A1", lastRow).Font.Size = 20;

                workBook.SaveAs(filename, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                workBook.Close();
                app.Quit();
            }     
        }

        private void SearchDataAll()
        {

            Sql = "SELECT tbproduct.Id_product, tbproduct.N_product, tbproduct.N_product_desc, tbcategory.N_category,";
            Sql += "tbproduct.N_seller, tbproduct.pricebuy, tbproduct.unit";
            Sql += " FROM tbproduct, tbcategory";
            Sql += " WHERE tbproduct.Id_category = tbcategory.Id_category";
            //Sql += " AND tbbuy.buyid = tbbuyitem.buyid";
            //Sql += " GROUP BY tbbuyitem.Id_product,tbproduct.N_product,tbbuyitem.buyitempricebuy,tbbuy.buydate";
            //Sql += " AND Format(tbbuy.buydate , '" + "dd/mm/yyyy" + "') BETWEEN #" + dateTimePicker1.Text + "# And #" + dateTimePicker2.Text + "#";
            //Sql += " ORDER BY tbproduct.Id_product";

            command = new OleDbCommand(Sql, Connection);

            OleDbDataReader DataReader = command.ExecuteReader();
            if (DataReader.HasRows)
            {
                dataTable = new DataTable();
                dataTable.Load(DataReader);
                dgvStock.DataSource = dataTable;
                FormatDataGridView();
                DataReader.Close();
            }
            else
            {
                dataTable = new DataTable();
                dataTable.Load(DataReader);
                dgvStock.DataSource = dataTable;
                FormatDataGridView();
                DataReader.Close();
            }


        }

        private void buttonStockCheck_Click(object sender, EventArgs e)
        {
            SearchDataAll();
        }

        private void buttonStockReport_Click(object sender, EventArgs e)
        {
            if(dgvStock.DataSource != null || dgvStock.Rows.Count -1 > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Files|*.xlsx";
                sfd.FileName = "รายงานสต๊อกสินค้า.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    DataReport(sfd.FileName);
                    MessageBox.Show("บันทึกสำเร็จ", "ตกลง");
                }
            }       
        }

        private void buttonStockCancel_Click(object sender, EventArgs e)
        {
            dgvStock.DataSource = null;
        }

        private void FormReportStock_Load(object sender, EventArgs e)
        {
            ConnectionDatabase();
        }

        private void ReportOrderNew_Load(object sender, EventArgs e)
        {
            ConnectionDatabase();
        }
    }
}
