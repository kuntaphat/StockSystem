﻿namespace ShoeSystem
{
    partial class FormBuy
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
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonOpen = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.dateTimepicker1 = new System.Windows.Forms.DateTimePicker();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtProQty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.txtProID = new System.Windows.Forms.TextBox();
            this.txtProName = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtProPrice = new System.Windows.Forms.TextBox();
            this.txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // ButtonSave
            // 
            this.ButtonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ButtonSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonSave.Location = new System.Drawing.Point(475, 396);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(65, 34);
            this.ButtonSave.TabIndex = 13;
            this.ButtonSave.Text = "บันทึก";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ButtonCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonCancel.Location = new System.Drawing.Point(557, 396);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(65, 34);
            this.ButtonCancel.TabIndex = 14;
            this.ButtonCancel.Text = "ยกเลิก";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonOpen
            // 
            this.ButtonOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ButtonOpen.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonOpen.Location = new System.Drawing.Point(352, 396);
            this.ButtonOpen.Name = "ButtonOpen";
            this.ButtonOpen.Size = new System.Drawing.Size(103, 34);
            this.ButtonOpen.TabIndex = 8;
            this.ButtonOpen.Text = "ซื้อสินค้า";
            this.ButtonOpen.UseVisualStyleBackColor = true;
            this.ButtonOpen.Click += new System.EventHandler(this.ButtonOpen_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(411, 19);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(217, 60);
            this.lblTotal.TabIndex = 35;
            this.lblTotal.Text = "0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonAdd.Location = new System.Drawing.Point(470, 136);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(76, 26);
            this.ButtonAdd.TabIndex = 39;
            this.ButtonAdd.Text = "เพิ่ม";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Cordia New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Label6.Location = new System.Drawing.Point(62, 50);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(96, 29);
            this.Label6.TabIndex = 46;
            this.Label6.Text = "วันที่ซื้อสินค้า :";
            // 
            // dateTimepicker1
            // 
            this.dateTimepicker1.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dateTimepicker1.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dateTimepicker1.CustomFormat = "d MMMM yyyy";
            this.dateTimepicker1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimepicker1.Location = new System.Drawing.Point(164, 52);
            this.dateTimepicker1.Name = "dateTimepicker1";
            this.dateTimepicker1.Size = new System.Drawing.Size(178, 26);
            this.dateTimepicker1.TabIndex = 45;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Cordia New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Label9.Location = new System.Drawing.Point(357, 104);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(35, 29);
            this.Label9.TabIndex = 44;
            this.Label9.Text = "รวม";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Cordia New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Label8.Location = new System.Drawing.Point(293, 102);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(53, 29);
            this.Label8.TabIndex = 43;
            this.Label8.Text = "จำนวน";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Cordia New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Label5.Location = new System.Drawing.Point(229, 104);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(42, 29);
            this.Label5.TabIndex = 42;
            this.Label5.Text = "ราคา";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Cordia New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Label4.Location = new System.Drawing.Point(116, 104);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(63, 29);
            this.Label4.TabIndex = 41;
            this.Label4.Text = "ชื่อสินค้า";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Cordia New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Label2.Location = new System.Drawing.Point(36, 19);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(122, 29);
            this.Label2.TabIndex = 40;
            this.Label2.Text = "เลขที่การซื้อสินค้า :";
            // 
            // txtProQty
            // 
            this.txtProQty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProQty.Location = new System.Drawing.Point(288, 134);
            this.txtProQty.Name = "txtProQty";
            this.txtProQty.Size = new System.Drawing.Size(58, 26);
            this.txtProQty.TabIndex = 38;
            this.txtProQty.TextChanged += new System.EventHandler(this.txtProQty_TextChanged);
            this.txtProQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProQty_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cordia New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.Location = new System.Drawing.Point(18, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 29);
            this.label7.TabIndex = 53;
            this.label7.Text = "รหัสสินค้า";
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonSearch.Location = new System.Drawing.Point(84, 132);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(33, 26);
            this.ButtonSearch.TabIndex = 55;
            this.ButtonSearch.Text = "..";
            this.ButtonSearch.UseVisualStyleBackColor = false;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonDelete.Location = new System.Drawing.Point(552, 135);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(76, 26);
            this.ButtonDelete.TabIndex = 57;
            this.ButtonDelete.Text = "ลบ";
            this.ButtonDelete.UseVisualStyleBackColor = false;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // txtProID
            // 
            this.txtProID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProID.Location = new System.Drawing.Point(20, 132);
            this.txtProID.Name = "txtProID";
            this.txtProID.Size = new System.Drawing.Size(58, 26);
            this.txtProID.TabIndex = 58;
            // 
            // txtProName
            // 
            this.txtProName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProName.Location = new System.Drawing.Point(123, 132);
            this.txtProName.Name = "txtProName";
            this.txtProName.ReadOnly = true;
            this.txtProName.Size = new System.Drawing.Size(58, 26);
            this.txtProName.TabIndex = 59;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(362, 132);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(93, 26);
            this.txtTotal.TabIndex = 61;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(164, 19);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(182, 26);
            this.txtID.TabIndex = 62;
            // 
            // txtProPrice
            // 
            this.txtProPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProPrice.Location = new System.Drawing.Point(213, 132);
            this.txtProPrice.Name = "txtProPrice";
            this.txtProPrice.ReadOnly = true;
            this.txtProPrice.Size = new System.Drawing.Size(58, 26);
            this.txtProPrice.TabIndex = 60;
            // 
            // txt
            // 
            this.txt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.Location = new System.Drawing.Point(151, 404);
            this.txt.Name = "txt";
            this.txt.ReadOnly = true;
            this.txt.Size = new System.Drawing.Size(182, 26);
            this.txt.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cordia New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(11, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 29);
            this.label1.TabIndex = 63;
            this.label1.Text = "จำนวนที่ซื้อสินค้า :";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(334, 220);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(58, 26);
            this.textBox1.TabIndex = 65;
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Cordia New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(16, 168);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(606, 216);
            this.listView1.TabIndex = 66;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // FormBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 452);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtProPrice);
            this.Controls.Add(this.txtProName);
            this.Controls.Add(this.txtProID);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonOpen);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.dateTimepicker1);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtProQty);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBuy";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ซื้อสินค้า";
            this.Load += new System.EventHandler(this.FormImport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button ButtonSave;
        internal System.Windows.Forms.Button ButtonCancel;
        internal System.Windows.Forms.Button ButtonOpen;
        internal System.Windows.Forms.Label lblTotal;
        internal System.Windows.Forms.Button ButtonAdd;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.DateTimePicker dateTimepicker1;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtProQty;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Button ButtonSearch;
        internal System.Windows.Forms.Button ButtonDelete;
        internal System.Windows.Forms.TextBox txtProID;
        internal System.Windows.Forms.TextBox txtProName;
        internal System.Windows.Forms.TextBox txtTotal;
        internal System.Windows.Forms.TextBox txtID;
        internal System.Windows.Forms.TextBox txtProPrice;
        internal System.Windows.Forms.TextBox txt;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listView1;

    }
}