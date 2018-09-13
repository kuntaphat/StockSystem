namespace ShoeSystem
{
    partial class FormSale
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
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonOpen = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.dateTimepicker1 = new System.Windows.Forms.DateTimePicker();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.labelQty = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtProID = new System.Windows.Forms.TextBox();
            this.txtProName = new System.Windows.Forms.TextBox();
            this.txtProQty = new System.Windows.Forms.TextBox();
            this.txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonDelete.Location = new System.Drawing.Point(782, 138);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(67, 26);
            this.ButtonDelete.TabIndex = 79;
            this.ButtonDelete.Text = "ลบ";
            this.ButtonDelete.UseVisualStyleBackColor = false;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Cordia New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(19, 170);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(830, 222);
            this.listView1.TabIndex = 78;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonSearch.Location = new System.Drawing.Point(85, 138);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(33, 26);
            this.ButtonSearch.TabIndex = 77;
            this.ButtonSearch.Text = "..";
            this.ButtonSearch.UseVisualStyleBackColor = false;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cordia New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.Location = new System.Drawing.Point(18, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 29);
            this.label7.TabIndex = 75;
            this.label7.Text = "รหัสสินค้า";
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ButtonCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonCancel.Location = new System.Drawing.Point(777, 411);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(72, 34);
            this.ButtonCancel.TabIndex = 60;
            this.ButtonCancel.Text = "ยกเลิก";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ButtonSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonSave.Location = new System.Drawing.Point(685, 411);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(72, 34);
            this.ButtonSave.TabIndex = 59;
            this.ButtonSave.Text = "บันทึก";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonOpen
            // 
            this.ButtonOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ButtonOpen.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonOpen.Location = new System.Drawing.Point(560, 411);
            this.ButtonOpen.Name = "ButtonOpen";
            this.ButtonOpen.Size = new System.Drawing.Size(103, 34);
            this.ButtonOpen.TabIndex = 58;
            this.ButtonOpen.Text = "ขายสินค้า";
            this.ButtonOpen.UseVisualStyleBackColor = true;
            this.ButtonOpen.Click += new System.EventHandler(this.ButtonOpen_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonAdd.Location = new System.Drawing.Point(709, 138);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(67, 26);
            this.ButtonAdd.TabIndex = 63;
            this.ButtonAdd.Text = "เพิ่ม";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Cordia New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Label6.Location = new System.Drawing.Point(39, 51);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(103, 29);
            this.Label6.TabIndex = 70;
            this.Label6.Text = "วันที่ขายสินค้า :";
            // 
            // dateTimepicker1
            // 
            this.dateTimepicker1.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dateTimepicker1.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dateTimepicker1.CustomFormat = "d MMMM yyyy";
            this.dateTimepicker1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimepicker1.Location = new System.Drawing.Point(166, 54);
            this.dateTimepicker1.Name = "dateTimepicker1";
            this.dateTimepicker1.Size = new System.Drawing.Size(178, 26);
            this.dateTimepicker1.TabIndex = 69;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Cordia New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Label8.Location = new System.Drawing.Point(235, 106);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(71, 29);
            this.Label8.TabIndex = 67;
            this.Label8.Text = "จำนวนที่มี";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Cordia New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Label4.Location = new System.Drawing.Point(117, 110);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(63, 29);
            this.Label4.TabIndex = 65;
            this.Label4.Text = "ชื่อสินค้า";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Cordia New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Label2.Location = new System.Drawing.Point(19, 21);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(129, 29);
            this.Label2.TabIndex = 64;
            this.Label2.Text = "เลขที่การขายสินค้า :";
            // 
            // labelQty
            // 
            this.labelQty.AutoSize = true;
            this.labelQty.Font = new System.Drawing.Font("Cordia New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelQty.Location = new System.Drawing.Point(312, 106);
            this.labelQty.Name = "labelQty";
            this.labelQty.Size = new System.Drawing.Size(74, 29);
            this.labelQty.TabIndex = 81;
            this.labelQty.Text = "จำนวนเบิก";
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(314, 138);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(72, 26);
            this.txtQty.TabIndex = 80;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(166, 22);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(178, 26);
            this.txtID.TabIndex = 82;
            // 
            // txtProID
            // 
            this.txtProID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProID.Location = new System.Drawing.Point(23, 138);
            this.txtProID.Name = "txtProID";
            this.txtProID.Size = new System.Drawing.Size(56, 26);
            this.txtProID.TabIndex = 83;
            this.txtProID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProID_KeyPress);
            // 
            // txtProName
            // 
            this.txtProName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProName.Location = new System.Drawing.Point(122, 138);
            this.txtProName.Name = "txtProName";
            this.txtProName.ReadOnly = true;
            this.txtProName.Size = new System.Drawing.Size(102, 26);
            this.txtProName.TabIndex = 84;
            // 
            // txtProQty
            // 
            this.txtProQty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProQty.Location = new System.Drawing.Point(236, 138);
            this.txtProQty.Name = "txtProQty";
            this.txtProQty.ReadOnly = true;
            this.txtProQty.Size = new System.Drawing.Size(72, 26);
            this.txtProQty.TabIndex = 86;
            // 
            // txt
            // 
            this.txt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.Location = new System.Drawing.Point(159, 414);
            this.txt.Name = "txt";
            this.txt.ReadOnly = true;
            this.txt.Size = new System.Drawing.Size(182, 26);
            this.txt.TabIndex = 89;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cordia New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(12, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 29);
            this.label1.TabIndex = 88;
            this.label1.Text = "จำนวนที่ขายสินค้า :";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomer.Location = new System.Drawing.Point(480, 138);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(213, 26);
            this.txtCustomer.TabIndex = 90;
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Font = new System.Drawing.Font("Cordia New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelCustomer.Location = new System.Drawing.Point(555, 106);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(62, 29);
            this.labelCustomer.TabIndex = 91;
            this.labelCustomer.Text = "ชื่อลูกค้า";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(392, 138);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(72, 26);
            this.txtTotal.TabIndex = 92;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Cordia New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelTotal.Location = new System.Drawing.Point(399, 106);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(59, 29);
            this.labelTotal.TabIndex = 93;
            this.labelTotal.Text = "คงเหลือ";
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(595, 9);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(254, 89);
            this.lblTotal.TabIndex = 61;
            this.lblTotal.Text = "0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 460);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.labelCustomer);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProQty);
            this.Controls.Add(this.txtProName);
            this.Controls.Add(this.txtProID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.labelQty);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonOpen);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.dateTimepicker1);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.lblTotal);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSale";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ขายสินค้า";
            this.Load += new System.EventHandler(this.FormSale_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.ListView listView1;
        internal System.Windows.Forms.Button ButtonSearch;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Button ButtonCancel;
        internal System.Windows.Forms.Button ButtonSave;
        internal System.Windows.Forms.Button ButtonOpen;
        internal System.Windows.Forms.Button ButtonAdd;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.DateTimePicker dateTimepicker1;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label labelQty;
        internal System.Windows.Forms.TextBox txtQty;
        internal System.Windows.Forms.TextBox txtID;
        internal System.Windows.Forms.TextBox txtProID;
        internal System.Windows.Forms.TextBox txtProName;
        internal System.Windows.Forms.TextBox txtProQty;
        internal System.Windows.Forms.TextBox txt;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtCustomer;
        internal System.Windows.Forms.Label labelCustomer;
        internal System.Windows.Forms.TextBox txtTotal;
        internal System.Windows.Forms.Label labelTotal;
        internal System.Windows.Forms.Label lblTotal;
    }
}