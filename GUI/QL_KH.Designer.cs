namespace Nhom08_QuanLyKhachSan.GUI
{
    partial class QL_KH
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtvKH = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.boxTEN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboLKH = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.boxDC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.boxCMND = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelNone = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnDeSelect = new System.Windows.Forms.Button();
            this.btnEditMode = new System.Windows.Forms.Button();
            this.btnSearchMode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtvKH)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelNone.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý khách hàng";
            // 
            // dtvKH
            // 
            this.dtvKH.AllowUserToAddRows = false;
            this.dtvKH.AllowUserToDeleteRows = false;
            this.dtvKH.AllowUserToResizeColumns = false;
            this.dtvKH.AllowUserToResizeRows = false;
            this.dtvKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvKH.BackgroundColor = System.Drawing.Color.White;
            this.dtvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvKH.Location = new System.Drawing.Point(70, 133);
            this.dtvKH.Name = "dtvKH";
            this.dtvKH.ReadOnly = true;
            this.dtvKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvKH.Size = new System.Drawing.Size(408, 602);
            this.dtvKH.TabIndex = 2;
            this.dtvKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvKH_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(64, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Danh sách Khách Hàng";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(761, 583);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(208, 44);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(541, 583);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(208, 44);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(156, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(245, 2);
            this.panel3.TabIndex = 33;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.DimGray;
            this.label22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(115, 48);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(19, 25);
            this.label22.TabIndex = 32;
            this.label22.Text = ":";
            // 
            // boxTEN
            // 
            this.boxTEN.BackColor = System.Drawing.Color.DimGray;
            this.boxTEN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxTEN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.boxTEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxTEN.ForeColor = System.Drawing.Color.White;
            this.boxTEN.Location = new System.Drawing.Point(156, 50);
            this.boxTEN.Name = "boxTEN";
            this.boxTEN.Size = new System.Drawing.Size(251, 22);
            this.boxTEN.TabIndex = 31;
            this.boxTEN.Text = "NGUYỄN VĂN A";
            this.boxTEN.TextChanged += new System.EventHandler(this.sortKH);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DimGray;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(30, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 25);
            this.label8.TabIndex = 30;
            this.label8.Text = "Tên KH";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.comboLKH);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.boxDC);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.boxCMND);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.boxTEN);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(541, 221);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 294);
            this.panel1.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DimGray;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(115, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 25);
            this.label7.TabIndex = 44;
            this.label7.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DimGray;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(30, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 25);
            this.label9.TabIndex = 43;
            this.label9.Text = "Loại";
            // 
            // comboLKH
            // 
            this.comboLKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboLKH.FormattingEnabled = true;
            this.comboLKH.Items.AddRange(new object[] {
            "Nội Địa",
            "Quốc Tế"});
            this.comboLKH.Location = new System.Drawing.Point(156, 210);
            this.comboLKH.Name = "comboLKH";
            this.comboLKH.Size = new System.Drawing.Size(155, 33);
            this.comboLKH.TabIndex = 42;
            this.comboLKH.SelectedValueChanged += new System.EventHandler(this.sortKH);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(156, 183);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(245, 2);
            this.panel4.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DimGray;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(115, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 25);
            this.label5.TabIndex = 40;
            this.label5.Text = ":";
            // 
            // boxDC
            // 
            this.boxDC.BackColor = System.Drawing.Color.DimGray;
            this.boxDC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxDC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.boxDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxDC.ForeColor = System.Drawing.Color.White;
            this.boxDC.Location = new System.Drawing.Point(156, 160);
            this.boxDC.Name = "boxDC";
            this.boxDC.Size = new System.Drawing.Size(251, 22);
            this.boxDC.TabIndex = 39;
            this.boxDC.Text = "NGUYỄN VĂN A";
            this.boxDC.TextChanged += new System.EventHandler(this.sortKH);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DimGray;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(30, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 25);
            this.label6.TabIndex = 38;
            this.label6.Text = "Địa chỉ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(156, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 2);
            this.panel2.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DimGray;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(115, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 25);
            this.label3.TabIndex = 36;
            this.label3.Text = ":";
            // 
            // boxCMND
            // 
            this.boxCMND.BackColor = System.Drawing.Color.DimGray;
            this.boxCMND.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxCMND.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.boxCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxCMND.ForeColor = System.Drawing.Color.White;
            this.boxCMND.Location = new System.Drawing.Point(156, 104);
            this.boxCMND.Name = "boxCMND";
            this.boxCMND.Size = new System.Drawing.Size(251, 22);
            this.boxCMND.TabIndex = 35;
            this.boxCMND.Text = "NGUYỄN VĂN A";
            this.boxCMND.TextChanged += new System.EventHandler(this.sortKH);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DimGray;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(30, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 34;
            this.label4.Text = "CMND";
            // 
            // panelNone
            // 
            this.panelNone.BackColor = System.Drawing.Color.LightCoral;
            this.panelNone.Controls.Add(this.label10);
            this.panelNone.Location = new System.Drawing.Point(71, 133);
            this.panelNone.Name = "panelNone";
            this.panelNone.Size = new System.Drawing.Size(406, 601);
            this.panelNone.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(28, 282);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(343, 44);
            this.label10.TabIndex = 45;
            this.label10.Text = "Không tồn tại khách hàng chưa đặt phòng\r\nHãy thêm khách hàng\r\n";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(635, 583);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(243, 44);
            this.btnDel.TabIndex = 36;
            this.btnDel.Text = "Xoá";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnDeSelect
            // 
            this.btnDeSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeSelect.ForeColor = System.Drawing.Color.Black;
            this.btnDeSelect.Location = new System.Drawing.Point(541, 532);
            this.btnDeSelect.Name = "btnDeSelect";
            this.btnDeSelect.Size = new System.Drawing.Size(106, 33);
            this.btnDeSelect.TabIndex = 37;
            this.btnDeSelect.Text = "Bỏ chọn";
            this.btnDeSelect.UseVisualStyleBackColor = true;
            this.btnDeSelect.Click += new System.EventHandler(this.btnDeSelect_Click);
            // 
            // btnEditMode
            // 
            this.btnEditMode.BackColor = System.Drawing.Color.DarkGray;
            this.btnEditMode.FlatAppearance.BorderSize = 0;
            this.btnEditMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMode.Location = new System.Drawing.Point(541, 178);
            this.btnEditMode.Name = "btnEditMode";
            this.btnEditMode.Size = new System.Drawing.Size(148, 44);
            this.btnEditMode.TabIndex = 38;
            this.btnEditMode.Text = "Chỉnh Sửa";
            this.btnEditMode.UseVisualStyleBackColor = false;
            this.btnEditMode.Click += new System.EventHandler(this.btnEditMode_Click);
            // 
            // btnSearchMode
            // 
            this.btnSearchMode.BackColor = System.Drawing.Color.DarkGray;
            this.btnSearchMode.FlatAppearance.BorderSize = 0;
            this.btnSearchMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMode.Location = new System.Drawing.Point(689, 178);
            this.btnSearchMode.Name = "btnSearchMode";
            this.btnSearchMode.Size = new System.Drawing.Size(214, 44);
            this.btnSearchMode.TabIndex = 39;
            this.btnSearchMode.Text = "Tìm Kiếm/Xoá";
            this.btnSearchMode.UseVisualStyleBackColor = false;
            this.btnSearchMode.Click += new System.EventHandler(this.btnSearchMode_Click);
            // 
            // QL_KH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1036, 774);
            this.Controls.Add(this.btnSearchMode);
            this.Controls.Add(this.btnEditMode);
            this.Controls.Add(this.btnDeSelect);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtvKH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelNone);
            this.Name = "QL_KH";
            this.Text = "QL_KH";
            this.Load += new System.EventHandler(this.QL_KH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvKH)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelNone.ResumeLayout(false);
            this.panelNone.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtvKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox boxTEN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox boxCMND;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox boxDC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboLKH;
        private System.Windows.Forms.Panel panelNone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnDeSelect;
        private System.Windows.Forms.Button btnEditMode;
        private System.Windows.Forms.Button btnSearchMode;
    }
}