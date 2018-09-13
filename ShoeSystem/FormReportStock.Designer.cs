namespace ShoeSystem
{
    partial class FormReportStock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.buttonStockCancel = new System.Windows.Forms.Button();
            this.buttonStockReport = new System.Windows.Forms.Button();
            this.buttonStockCheck = new System.Windows.Forms.Button();
            this.lbHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStock
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStock.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStock.Location = new System.Drawing.Point(12, 44);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.Size = new System.Drawing.Size(1045, 344);
            this.dgvStock.TabIndex = 4;
            // 
            // buttonStockCancel
            // 
            this.buttonStockCancel.Location = new System.Drawing.Point(977, 406);
            this.buttonStockCancel.Name = "buttonStockCancel";
            this.buttonStockCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonStockCancel.TabIndex = 8;
            this.buttonStockCancel.Text = "ยกเลิก";
            this.buttonStockCancel.UseVisualStyleBackColor = true;
            this.buttonStockCancel.Click += new System.EventHandler(this.buttonStockCancel_Click);
            // 
            // buttonStockReport
            // 
            this.buttonStockReport.Location = new System.Drawing.Point(896, 406);
            this.buttonStockReport.Name = "buttonStockReport";
            this.buttonStockReport.Size = new System.Drawing.Size(75, 23);
            this.buttonStockReport.TabIndex = 9;
            this.buttonStockReport.Text = "ออกรายงาน";
            this.buttonStockReport.UseVisualStyleBackColor = true;
            this.buttonStockReport.Click += new System.EventHandler(this.buttonStockReport_Click);
            // 
            // buttonStockCheck
            // 
            this.buttonStockCheck.Location = new System.Drawing.Point(815, 406);
            this.buttonStockCheck.Name = "buttonStockCheck";
            this.buttonStockCheck.Size = new System.Drawing.Size(75, 23);
            this.buttonStockCheck.TabIndex = 10;
            this.buttonStockCheck.Text = "เช็คสต๊อก";
            this.buttonStockCheck.UseVisualStyleBackColor = true;
            this.buttonStockCheck.Click += new System.EventHandler(this.buttonStockCheck_Click);
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbHeader.Location = new System.Drawing.Point(438, 9);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(177, 25);
            this.lbHeader.TabIndex = 11;
            this.lbHeader.Text = "รายงานสต๊อกสินค้า";
            this.lbHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormReportStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 441);
            this.Controls.Add(this.lbHeader);
            this.Controls.Add(this.buttonStockCheck);
            this.Controls.Add(this.buttonStockReport);
            this.Controls.Add(this.buttonStockCancel);
            this.Controls.Add(this.dgvStock);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormReportStock";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "รายงานสต๊อกสินค้า";
            this.Load += new System.EventHandler(this.FormReportStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Button buttonStockCancel;
        private System.Windows.Forms.Button buttonStockReport;
        private System.Windows.Forms.Button buttonStockCheck;
        private System.Windows.Forms.Label lbHeader;
    }
}