namespace Nhom08_QuanLyKhachSan.GUI
{
    partial class QL_NV
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
            this.btnSearchMode = new System.Windows.Forms.Button();
            this.btnEditMode = new System.Windows.Forms.Button();
            this.btnDeSelect = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.boxCV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.boxTEN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtvNV = new System.Windows.Forms.DataGridView();
            this.panelNone = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.boxNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvNV)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(248, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý nhân viên";
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
            this.btnSearchMode.TabIndex = 49;
            this.btnSearchMode.Text = "Tìm Kiếm/Xoá";
            this.btnSearchMode.UseVisualStyleBackColor = false;
            this.btnSearchMode.Click += new System.EventHandler(this.btnSearchMode_Click);
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
            this.btnEditMode.TabIndex = 48;
            this.btnEditMode.Text = "Chỉnh Sửa";
            this.btnEditMode.UseVisualStyleBackColor = false;
            this.btnEditMode.Click += new System.EventHandler(this.btnEditMode_Click);
            // 
            // btnDeSelect
            // 
            this.btnDeSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeSelect.ForeColor = System.Drawing.Color.Black;
            this.btnDeSelect.Location = new System.Drawing.Point(541, 532);
            this.btnDeSelect.Name = "btnDeSelect";
            this.btnDeSelect.Size = new System.Drawing.Size(106, 33);
            this.btnDeSelect.TabIndex = 47;
            this.btnDeSelect.Text = "Bỏ chọn";
            this.btnDeSelect.UseVisualStyleBackColor = true;
            this.btnDeSelect.Click += new System.EventHandler(this.btnDeSelect_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(635, 583);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(243, 44);
            this.btnDel.TabIndex = 46;
            this.btnDel.Text = "Xoá";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.panelEdit);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.boxNV);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.boxCV);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.boxTEN);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(541, 221);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 294);
            this.panel1.TabIndex = 44;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(156, 161);
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
            this.label5.Location = new System.Drawing.Point(115, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 25);
            this.label5.TabIndex = 40;
            this.label5.Text = ":";
            // 
            // boxCV
            // 
            this.boxCV.BackColor = System.Drawing.Color.DimGray;
            this.boxCV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxCV.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.boxCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxCV.ForeColor = System.Drawing.Color.White;
            this.boxCV.Location = new System.Drawing.Point(156, 138);
            this.boxCV.Name = "boxCV";
            this.boxCV.Size = new System.Drawing.Size(251, 22);
            this.boxCV.TabIndex = 39;
            this.boxCV.Text = "NHÂN VIÊN";
            this.boxCV.TextChanged += new System.EventHandler(this.sortNV);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DimGray;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(30, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 25);
            this.label6.TabIndex = 38;
            this.label6.Text = "Chức vụ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(156, 103);
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
            this.label22.Location = new System.Drawing.Point(115, 78);
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
            this.boxTEN.Location = new System.Drawing.Point(156, 80);
            this.boxTEN.Name = "boxTEN";
            this.boxTEN.Size = new System.Drawing.Size(251, 22);
            this.boxTEN.TabIndex = 31;
            this.boxTEN.Text = "NGUYỄN VĂN A";
            this.boxTEN.TextChanged += new System.EventHandler(this.sortNV);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DimGray;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(30, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 25);
            this.label8.TabIndex = 30;
            this.label8.Text = "Tên NV";
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(541, 583);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(208, 44);
            this.btnEdit.TabIndex = 43;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(761, 583);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(208, 44);
            this.btnAdd.TabIndex = 42;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.label2.Size = new System.Drawing.Size(296, 31);
            this.label2.TabIndex = 41;
            this.label2.Text = "Danh sách Nhân Viên";
            // 
            // dtvNV
            // 
            this.dtvNV.AllowUserToAddRows = false;
            this.dtvNV.AllowUserToDeleteRows = false;
            this.dtvNV.AllowUserToResizeColumns = false;
            this.dtvNV.AllowUserToResizeRows = false;
            this.dtvNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvNV.BackgroundColor = System.Drawing.Color.White;
            this.dtvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvNV.Location = new System.Drawing.Point(70, 133);
            this.dtvNV.Name = "dtvNV";
            this.dtvNV.ReadOnly = true;
            this.dtvNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvNV.Size = new System.Drawing.Size(408, 602);
            this.dtvNV.TabIndex = 40;
            this.dtvNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvNV_CellClick);
            this.dtvNV.Leave += new System.EventHandler(this.dtvNV_Leave);
            // 
            // panelNone
            // 
            this.panelNone.BackColor = System.Drawing.Color.LightCoral;
            this.panelNone.Controls.Add(this.label10);
            this.panelNone.Location = new System.Drawing.Point(71, 133);
            this.panelNone.Name = "panelNone";
            this.panelNone.Size = new System.Drawing.Size(406, 601);
            this.panelNone.TabIndex = 45;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DimGray;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(30, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 46;
            this.label4.Text = "Mã NV";
            // 
            // boxNV
            // 
            this.boxNV.AcceptsTab = true;
            this.boxNV.BackColor = System.Drawing.Color.DimGray;
            this.boxNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxNV.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.boxNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxNV.ForeColor = System.Drawing.Color.White;
            this.boxNV.Location = new System.Drawing.Point(156, 197);
            this.boxNV.Name = "boxNV";
            this.boxNV.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.boxNV.Size = new System.Drawing.Size(251, 22);
            this.boxNV.TabIndex = 47;
            this.boxNV.Text = "NV01";
            this.boxNV.TextChanged += new System.EventHandler(this.sortNV);
            this.boxNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxNV_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DimGray;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(115, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 25);
            this.label3.TabIndex = 48;
            this.label3.Text = ":";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(156, 220);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 2);
            this.panel2.TabIndex = 49;
            // 
            // panelEdit
            // 
            this.panelEdit.BackColor = System.Drawing.Color.DimGray;
            this.panelEdit.Location = new System.Drawing.Point(21, 185);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(386, 53);
            this.panelEdit.TabIndex = 50;
            // 
            // QL_NV
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
            this.Controls.Add(this.dtvNV);
            this.Controls.Add(this.panelNone);
            this.Controls.Add(this.label1);
            this.Name = "QL_NV";
            this.Text = "QL_NV";
            this.Load += new System.EventHandler(this.QL_NV_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvNV)).EndInit();
            this.panelNone.ResumeLayout(false);
            this.panelNone.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchMode;
        private System.Windows.Forms.Button btnEditMode;
        private System.Windows.Forms.Button btnDeSelect;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox boxCV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox boxTEN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtvNV;
        private System.Windows.Forms.Panel panelNone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox boxNV;
        private System.Windows.Forms.Label label4;
    }
}