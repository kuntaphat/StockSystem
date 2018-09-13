using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.Sql;
using System.Configuration;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Globalization;
using Microsoft.Office.Core;

namespace ShoeSystem
{
    public partial class FormReportSale : Form
    {
        private string StrConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=database.accdb;Persist Security Info=True;";
        private OleDbConnection Connection;
        private DataSet DataSt;
        private OleDbCommand command;
        private OleDbDataAdapter DataAdapter;
        private DataTable dataTable;
        private string Sql = "";

        public FormReportSale()
        {
            InitializeComponent();
        }


        private void FormatDataGridView()
        {
            dataGridView1.Columns[0].HeaderText = "วันเดือนปีที่ขาย";
            dataGridView1.Columns[1].HeaderText = "รหัสสินค้า";
            dataGridView1.Columns[2].HeaderText = "ชื่อสินค้า";
            dataGridView1.Columns[3].HeaderText = "ชื่อลูกค้า";
            dataGridView1.Columns[4].HeaderText = "จำนวนที่ขาย";

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
            Sql = "SELECT tbsale.saledate, tbsaleitem.Id_product, tbproduct.N_product,";
            Sql += "tbsaleitem.N_customer, tbsaleitem.saleitemqty";
            Sql += " FROM tbsale, tbproduct, tbsaleitem";
            Sql += " WHERE tbsaleitem.Id_product = tbproduct.Id_product";
            Sql += " AND tbsale.saleid = tbsaleitem.saleid";
            //Sql += " AND tbsale.saledate BETWEEN #" + "5/4/2015" + "# And #" + "5/4/2015" + "#";
            Sql += " AND tbsale.saledate BETWEEN #" + dateTimePicker1.Value.ToString("M/d/yyyy") + "# And #" + dateTimePicker2.Value.ToString("M/d/yyyy") + "#";
            //Sql += " GROUP BY tbsaleitem.Id_product, tbproduct.N_product, tbsaleitem.N_customer, tbsale.saledate";
            Sql += " ORDER BY tbsale.saledate";

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


        public void DataReport(string filename)
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

            for (int i=1; i < dataGridView1.Columns.Count + 1; i++)
            {
                workSheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;       
            }

            for(int i=0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for(int j=0; j < dataGridView1.Columns.Count; j++)
                {
                    if (j == 0) { // Datetime

                        dt = Convert.ToDateTime(dataGridView1.Rows[i].Cells[j].Value.ToString());
                        workSheet.Cells[i + 2, j + 1] = dt.ToString("dd MMM yyyy", _cultureTHInfo);
                    }  

                    else
                        workSheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }

            string lastRow = "E" + Convert.ToString(dataGridView1.Rows.Count);

            workSheet.get_Range("A1", lastRow).Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            workSheet.get_Range("A1", "E1").Cells.Font.Bold = true;     // Header

            workBook.SaveAs(filename, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            workBook.Close();
            app.Quit();
        }

        private void SearchDataAll()
        {

            Sql = "SELECT tbsale.saledate, tbsaleitem.Id_product, tbproduct.N_product,";
            Sql += "tbsaleitem.N_customer, tbsaleitem.saleitemqty";
            Sql += " FROM tbsale, tbproduct, tbsaleitem";
            Sql += " WHERE tbsaleitem.Id_product = tbproduct.Id_product";
            Sql += " AND tbsale.saleid = tbsaleitem.saleid";
            //Sql += " GROUP BY tbsaleitem.Id_product, tbproduct.N_product, tbsale.saledate";
            //Sql += " AND Format(tbsale.saledate , '" + "dd/mm/yyyy" + "') BETWEEN #" + dateTimePicker1.Text + "# And #" + dateTimePicker2.Text + "#";
            Sql += " ORDER BY tbsale.saledate";

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
            //System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
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
                sfd.FileName = "รายงานการขาย.xlsx";

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
