namespace ShoeSystem
{
    partial class FormEmployee
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
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonSearchAll = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCard = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 414);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(63, 34);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "เพิ่ม";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(81, 414);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(63, 34);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "แก้ไข";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(150, 414);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(63, 34);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "บันทึก";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(219, 414);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(63, 34);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "ลบ";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(288, 414);
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
            this.dataGridView1.Size = new System.Drawing.Size(406, 387);
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
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(19, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "รหัสพนักงาน";
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
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "ชื่อพนักงาน";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBoxPassword.Location = new System.Drawing.Point(149, 326);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(215, 24);
            this.textBoxPassword.TabIndex = 17;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBoxAddress.Location = new System.Drawing.Point(149, 187);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(191, 24);
            this.textBoxAddress.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.Location = new System.Drawing.Point(21, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.Location = new System.Drawing.Point(19, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "ที่อยู่";
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
            this.label12.Location = new System.Drawing.Point(332, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 18);
            this.label12.TabIndex = 70;
            this.label12.Text = "ค้นหาโดยใช้ชื่อหรือรหัส";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(19, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 18);
            this.label6.TabIndex = 74;
            this.label6.Text = "บัตรประชาชน";
            // 
            // textBoxTel
            // 
            this.textBoxTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBoxTel.Location = new System.Drawing.Point(149, 234);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(191, 24);
            this.textBoxTel.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(21, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 76;
            this.label3.Text = "เบอร์โทรศัพท์";
            // 
            // textBoxCard
            // 
            this.textBoxCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBoxCard.Location = new System.Drawing.Point(153, 142);
            this.textBoxCard.MaxLength = 13;
            this.textBoxCard.Name = "textBoxCard";
            this.textBoxCard.Size = new System.Drawing.Size(191, 24);
            this.textBoxCard.TabIndex = 79;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBoxUsername.Location = new System.Drawing.Point(149, 278);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(191, 24);
            this.textBoxUsername.TabIndex = 81;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label10.Location = new System.Drawing.Point(21, 278);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 18);
            this.label10.TabIndex = 80;
            this.label10.Text = "username";
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 479);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxCard);
            this.Controls.Add(this.textBoxTel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonSearchAll);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxAddress);
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
            this.Name = "FormEmployee";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "จัดการพนักงาน";
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
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonSearchAll;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCard;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label10;
    }
}