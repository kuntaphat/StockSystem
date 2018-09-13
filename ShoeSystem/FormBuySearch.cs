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
    public partial class FormBuySearch : Form
    {
        private DataSet _dataset;
        private OleDbConnection _conn;
        private OleDbCommand _command;
        private OleDbDataAdapter _adapter;
        public bool IsSelect = false;
        public string productId;
        public string productName;
        public string productPrice;
        public FormBuySearch()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            IsSelect = false;
            this.Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            IsSelect = true;
            Int32 row_current;
            if(((dataGridView1 != null)) && (dataGridView1.RowCount > 0)) 
            {
                if(dataGridView1.CurrentRow != null)
                {
                    row_current=dataGridView1.CurrentRow.Index;
                }
                else
                {
                    row_current = 0;
                }
                try
                {
                productId = dataGridView1[0, row_current].Value.ToString();
                productName = dataGridView1[1, row_current].Value.ToString();
                productPrice =  dataGridView1[3, row_current].Value.ToString();
                }
                catch
                { 
                    productId = ""; 
                    productName = "";
                    productPrice ="";
                }

            }               
            this.Close();
        }

        private void FormBuySearch_Load(object sender, EventArgs e)
        {
            OleDbConnection objConn = new OleDbConnection();
            OleDbCommand objCmd = new OleDbCommand();
            string strConnString = null;
            string strSQL = null;

            strConnString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=database.accdb;Persist Security Info=True;";
            objConn.ConnectionString = strConnString;
            objConn.Open();
            strSQL = "SELECT Id_product as รหัสสินค้า,N_product as ชื่อสินค้า, N_seller as ผู้ขาย, pricebuy as ราคาสินค้าต่อหน่วย, unit as จำนวนที่มี FROM tbproduct ";
            objCmd = new OleDbCommand(strSQL, objConn);
            OleDbDataAdapter adapter = new OleDbDataAdapter(objCmd);
            _dataset = new DataSet();
            adapter.Fill(_dataset, "Products");

            if (_dataset.Tables["Products"].Rows.Count > 0)
            {
                dataGridView1.DataSource = _dataset.Tables["Products"];
            }
            objConn.Close();
            objConn = null;

            try
            {
                productId = dataGridView1[0, 0].Value.ToString();
                productName = dataGridView1[1, 0].Value.ToString();
                productPrice = dataGridView1[2, 0].Value.ToString();
                //productQty = dataGridView1[3, 0].Value.ToString();
            }
            catch
            {
                productId = "";
                productName = "";
                productPrice = "";
            }
        }
    }
}

