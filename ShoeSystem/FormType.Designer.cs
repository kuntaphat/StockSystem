namespace ShoeSystem
{
    partial class FormType
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
            this.buttonSearchAll = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(14, 282);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(63, 34);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "เพิ่ม";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(83, 282);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(63, 34);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "แก้ไข";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(152, 282);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(63, 34);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "บันทึก";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(221, 282);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(63, 34);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "ลบ";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(290, 282);
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
            this.dataGridView1.Size = new System.Drawing.Size(406, 255);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseUp);
            // 
            // textBoxID
            // 
            this.textBoxID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBoxID.Location = new System.Drawing.Point(162, 61);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(204, 24);
            this.textBoxID.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(21, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "รหัสประเภทสินค้าสินค้า";
            // 
            // textBoxName
            // 
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBoxName.Location = new System.Drawing.Point(162, 101);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(204, 24);
            this.textBoxName.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(21, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "ชื่อประเภทสินค้า";
            // 
            // buttonSearchAll
            // 
            this.buttonSearchAll.Location = new System.Drawing.Point(704, 12);
            this.buttonSearchAll.Name = "buttonSearchAll";
            this.buttonSearchAll.Size = new System.Drawing.Size(85, 34);
            this.buttonSearchAll.TabIndex = 73;
            this.buttonSearchAll.Text = "ค้นหาทั้งหมด";
            this.buttonSearchAll.UseVisualStyleBackColor = true;
            this.buttonSearchAll.Click += new System.EventHandler(this.buttonSearchAll_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(635, 12);
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
            this.textBoxSearch.Location = new System.Drawing.Point(478, 17);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(151, 24);
            this.textBoxSearch.TabIndex = 71;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label12.Location = new System.Drawing.Point(332, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 18);
            this.label12.TabIndex = 70;
            this.label12.Text = "ค้นหาโดยใช้ชื่อหรือรหัส";
            // 
            // FormType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 332);
            this.Controls.Add(this.buttonSearchAll);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label12);
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
            this.Name = "FormType";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "จัดการประเภทสินค้า";
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
        private System.Windows.Forms.Button buttonSearchAll;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label12;
    }
}