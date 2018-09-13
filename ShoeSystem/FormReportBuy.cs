using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ShoeSystem
{
    public partial class FormReportBuy : Form
    {
        private string StrConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=database.accdb;Persist Security Info=True;";
        private OleDbConnection Connection;
        private DataSet DataSt;
        private OleDbCommand command;
        private OleDbDataAdapter DataAdapter;
        private DataTable dataTable;
        private string Sql = "";

        public FormReportBuy()
        {
            InitializeComponent();
        }


        private void FormatDataGridView()
        {
            dataGridView1.Columns[0].HeaderText = "วันที่รับของ";
            dataGridView1.Columns[1].HeaderText = "รหัสสินค้า";
            dataGridView1.Columns[2].HeaderText = "ชื่อสินค้า";
            dataGridView1.Columns[3].HeaderText = "รายละเอียดสินค้า";
            dataGridView1.Columns[4].HeaderText = "ผู้ขาย";
            dataGridView1.Columns[5].HeaderText = "จำนวน";
            dataGridView1.Columns[6].HeaderText = "ราคาต่อหน่วย";
            dataGridView1.Columns[7].HeaderText = "รวม";

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void ConnectionDatabase()
        {  
	        Connection = new OleDbConnection();
	        if (Connection.State == ConnectionState.Open) {
		        Connection.Close();
	        } else {
		        Connection.ConnectionString = StrConn;
		        Connection.Open();
	        }
        }

        private void SearchData()
        {

            Sql = "SELECT tbbuy.buydate, tbproduct.Id_product, tbproduct.N_product,";
            Sql += "tbproduct.N_product_desc, tbproduct.N_seller, tbbuyitem.buyitemqty, tbbuyitem.buyitempricebuy, tbbuyitem.buyitemtotal";
            Sql += " FROM tbbuy, tbproduct, tbbuyitem";
            Sql += " WHERE tbbuyitem.Id_product = tbproduct.Id_product";
            Sql += " AND tbbuy.buyid = tbbuyitem.buyid";
            Sql += " AND tbbuy.buydate BETWEEN #" + dateTimePicker1.Value.ToString("M/d/yyyy") + "# And #" + dateTimePicker2.Value.ToString("M/d/yyyy") + "#";
            //Sql += " GROUP BY tbbuyitem.Id_product,tbproduct.N_product,tbbuyitem.buyitempricebuy,tbbuy.buydate";
            Sql += " ORDER BY tbbuy.buydate";

            command = new OleDbCommand(Sql, Connection);


            OleDbDataReader DataReader = command.ExecuteReader();
            if (DataReader.HasRows)
            {
                dataTable = new DataTable();
                dataTable.Load(DataReader);
                dataGridView1.DataSource = dataTable;
                FormatDataGridView();
                DataReader.Close();
            }
            else
            {
                dataTable = new DataTable();
                dataTable.Load(DataReader);
                dataGridView1.DataSource = dataTable;
                FormatDataGridView();
                DataReader.Close();
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

            app.Columns.ColumnWidth = 30;
            app.DisplayAlerts = false;

            System.Globalization.CultureInfo _cultureTHInfo = new System.Globalization.CultureInfo("th-TH");
            DateTime dt;

            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                workSheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (j == 0) {// Datetime

                        dt = Convert.ToDateTime(dataGridView1.Rows[i].Cells[j].Value.ToString());
                        workSheet.Cells[i + 2, j + 1] = dt.ToString("dd MMM yyyy", _cultureTHInfo);
                    }

                    else
                        workSheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }

            string lastRow = "H" + Convert.ToString(dataGridView1.Rows.Count);

            workSheet.get_Range("A1", lastRow).Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            workSheet.get_Range("A1", "H1").Cells.Font.Bold = true;     // Header

            workBook.SaveAs(filename, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            workBook.Close();
            app.Quit();
        }

        private void SearchDataAll()
        {

            Sql = "SELECT tbbuy.buydate, tbproduct.Id_product, tbproduct.N_product,";
            Sql += "tbproduct.N_product_desc, tbproduct.N_seller, tbbuyitem.buyitemqty, tbbuyitem.buyitempricebuy, tbbuyitem.buyitemtotal";
            Sql += " FROM tbbuy, tbproduct, tbbuyitem";
            Sql += " WHERE tbbuyitem.Id_product = tbproduct.Id_product";
            Sql += " AND tbbuy.buyid = tbbuyitem.buyid";
            //Sql += " GROUP BY tbbuyitem.Id_product,tbproduct.N_product,tbbuyitem.buyitempricebuy,tbbuy.buydate";
            //Sql += " AND Format(tbbuy.buydate , '" + "dd/mm/yyyy" + "') BETWEEN #" + dateTimePicker1.Text + "# And #" + dateTimePicker2.Text + "#";
            Sql += " ORDER BY tbbuy.buydate";

            command = new OleDbCommand(Sql, Connection);

            OleDbDataReader DataReader = command.ExecuteReader();
            if (DataReader.HasRows)
            {
                dataTable = new DataTable();
                dataTable.Load(DataReader);
                dataGridView1.DataSource = dataTable;
                FormatDataGridView();
                DataReader.Close();
            }
            else
            {
                dataTable = new DataTable();
                dataTable.Load(DataReader);
                dataGridView1.DataSource = dataTable;
                FormatDataGridView();
                DataReader.Close();
            }


        }


        private void ReportOrderNew_Load(object sender, EventArgs e)
        {
            ConnectionDatabase();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchDataAll();
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource != null || dataGridView1.Rows.Count - 1 > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                sfd.FileName = "รายงานการซื้อ.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    DataReport(sfd.FileName);
                    MessageBox.Show("บันทึกสำเร็จ", "ตกลง");
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
        }

    }
}
