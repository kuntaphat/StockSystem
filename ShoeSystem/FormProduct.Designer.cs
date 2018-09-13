namespace ShoeSystem
{
    partial class FormProduct
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonSearchAll = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPriceBuy = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textboxDesc = new System.Windows.Forms.TextBox();
            this.labelDesc = new System.Windows.Forms.Label();
            this.textboxSeller = new System.Windows.Forms.TextBox();
            this.labelSeller = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 412);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(63, 34);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "เพิ่ม";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(81, 412);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(63, 34);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "แก้ไข";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(150, 412);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(63, 34);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "บันทึก";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(219, 412);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(63, 34);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "ลบ";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(288, 412);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(63, 34);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "ยกเลิก";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(383, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(669, 385);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseUp);
            // 
            // textBoxID
            // 
            this.textBoxID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBoxID.Location = new System.Drawing.Point(149, 61);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(215, 24);
            this.textBoxID.TabIndex = 8;
            this.textBoxID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(19, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "รหัสสินค้า";
            // 
            // textBoxName
            // 
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBoxName.Location = new System.Drawing.Point(149, 101);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(215, 24);
            this.textBoxName.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(19, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "ชื่อสินค้า";
            // 
            // textBoxNum
            // 
            this.textBoxNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBoxNum.Location = new System.Drawing.Point(147, 357);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(213, 24);
            this.textBoxNum.TabIndex = 17;
            this.textBoxNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNum_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.Location = new System.Drawing.Point(19, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "จำนวนที่มี";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.Location = new System.Drawing.Point(19, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "ราคาซื้อ";
            // 
            // buttonSearchAll
            // 
            this.buttonSearchAll.Location = new System.Drawing.Point(967, 12);
            this.buttonSearchAll.Name = "buttonSearchAll";
            this.buttonSearchAll.Size = new System.Drawing.Size(85, 34);
            this.buttonSearchAll.TabIndex = 73;
            this.buttonSearchAll.Text = "ค้นหาทั้งหมด";
            this.buttonSearchAll.UseVisualStyleBackColor = true;
            this.buttonSearchAll.Click += new System.EventHandler(this.buttonSearchAll_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(898, 12);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(63, 34);
            this.buttonSearch.TabIndex = 72;
            this.buttonSearch.Text = "ค้นหา";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBoxSearch.Location = new System.Drawing.Point(741, 17);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(151, 24);
            this.textBoxSearch.TabIndex = 71;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label12.Location = new System.Drawing.Point(595, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 18);
            this.label12.TabIndex = 70;
            this.label12.Text = "ค้นหาโดยใช้ชื่อหรือรหัส";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(19, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 18);
            this.label6.TabIndex = 74;
            this.label6.Text = "ประเภทสินค้า";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(345, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 18);
            this.label2.TabIndex = 78;
            this.label2.Text = "บาท";
            // 
            // textBoxPriceBuy
            // 
            this.textBoxPriceBuy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPriceBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBoxPriceBuy.Location = new System.Drawing.Point(147, 316);
            this.textBoxPriceBuy.Name = "textBoxPriceBuy";
            this.textBoxPriceBuy.Size = new System.Drawing.Size(191, 24);
            this.textBoxPriceBuy.TabIndex = 77;
            this.textBoxPriceBuy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPriceBuy_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(147, 231);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(213, 26);
            this.comboBox1.TabIndex = 79;
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // textboxDesc
            // 
            this.textboxDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textboxDesc.Location = new System.Drawing.Point(147, 140);
            this.textboxDesc.Multiline = true;
            this.textboxDesc.Name = "textboxDesc";
            this.textboxDesc.Size = new System.Drawing.Size(215, 72);
            this.textboxDesc.TabIndex = 80;
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelDesc.Location = new System.Drawing.Point(19, 142);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(71, 18);
            this.labelDesc.TabIndex = 81;
            this.labelDesc.Text = "รายละเอียด";
            // 
            // textboxSeller
            // 
            this.textboxSeller.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxSeller.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textboxSeller.Location = new System.Drawing.Point(147, 273);
            this.textboxSeller.Name = "textboxSeller";
            this.textboxSeller.Size = new System.Drawing.Size(215, 24);
            this.textboxSeller.TabIndex = 82;
            // 
            // labelSeller
            // 
            this.labelSeller.AutoSize = true;
            this.labelSeller.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelSeller.Location = new System.Drawing.Point(19, 275);
            this.labelSeller.Name = "labelSeller";
            this.labelSeller.Size = new System.Drawing.Size(38, 18);
            this.labelSeller.TabIndex = 83;
            this.labelSeller.Text = "ผู้ขาย";
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 459);
            this.Controls.Add(this.labelSeller);
            this.Controls.Add(this.textboxSeller);
            this.Controls.Add(this.labelDesc);
            this.Controls.Add(this.textboxDesc);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPriceBuy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonSearchAll);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxNum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProduct";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "จัดการสินค้า";
            this.Load += new System.EventHandler(this.FormInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonSearchAll;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPriceBuy;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textboxDesc;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.TextBox textboxSeller;
        private System.Windows.Forms.Label labelSeller;
    }
}