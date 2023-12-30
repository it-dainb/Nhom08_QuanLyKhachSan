namespace Nhom08_QuanLyKhachSan.GUI
{
    partial class DP
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
            this.dtvRoom = new System.Windows.Forms.DataGridView();
            this.dtvKH = new System.Windows.Forms.DataGridView();
            this.btnDP = new System.Windows.Forms.Button();
            this.labelDMP = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbPH = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbLP = new System.Windows.Forms.Label();
            this.lbDG = new System.Windows.Forms.Label();
            this.lbSN = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbPT = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboTtr = new System.Windows.Forms.ComboBox();
            this.comboLP = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.boxCMND = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.boxTen = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtvDK_PT = new System.Windows.Forms.DataGridView();
            this.panelNoneKH = new System.Windows.Forms.Panel();
            this.lbNone = new System.Windows.Forms.Label();
            this.panelNonePH = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.btnClean = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtvRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvKH)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvDK_PT)).BeginInit();
            this.panelNoneKH.SuspendLayout();
            this.panelNonePH.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtvRoom
            // 
            this.dtvRoom.AllowUserToAddRows = false;
            this.dtvRoom.AllowUserToDeleteRows = false;
            this.dtvRoom.AllowUserToOrderColumns = true;
            this.dtvRoom.AllowUserToResizeColumns = false;
            this.dtvRoom.AllowUserToResizeRows = false;
            this.dtvRoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtvRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvRoom.BackgroundColor = System.Drawing.Color.White;
            this.dtvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvRoom.Location = new System.Drawing.Point(63, 464);
            this.dtvRoom.Name = "dtvRoom";
            this.dtvRoom.ReadOnly = true;
            this.dtvRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvRoom.Size = new System.Drawing.Size(386, 264);
            this.dtvRoom.TabIndex = 1;
            this.dtvRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtRoom_CellClick);
            // 
            // dtvKH
            // 
            this.dtvKH.AllowUserToAddRows = false;
            this.dtvKH.AllowUserToDeleteRows = false;
            this.dtvKH.AllowUserToResizeColumns = false;
            this.dtvKH.AllowUserToResizeRows = false;
            this.dtvKH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtvKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvKH.BackgroundColor = System.Drawing.Color.White;
            this.dtvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvKH.Location = new System.Drawing.Point(506, 376);
            this.dtvKH.Name = "dtvKH";
            this.dtvKH.ReadOnly = true;
            this.dtvKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvKH.Size = new System.Drawing.Size(463, 160);
            this.dtvKH.TabIndex = 2;
            this.dtvKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtKH_CellClick);
            // 
            // btnDP
            // 
            this.btnDP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDP.BackColor = System.Drawing.Color.White;
            this.btnDP.FlatAppearance.BorderSize = 2;
            this.btnDP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDP.Location = new System.Drawing.Point(92, 248);
            this.btnDP.Name = "btnDP";
            this.btnDP.Size = new System.Drawing.Size(201, 55);
            this.btnDP.TabIndex = 3;
            this.btnDP.Text = "Đặt Phòng";
            this.btnDP.UseVisualStyleBackColor = false;
            this.btnDP.Click += new System.EventHandler(this.btnDP_Click);
            // 
            // labelDMP
            // 
            this.labelDMP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDMP.AutoSize = true;
            this.labelDMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDMP.ForeColor = System.Drawing.Color.White;
            this.labelDMP.Location = new System.Drawing.Point(57, 416);
            this.labelDMP.Name = "labelDMP";
            this.labelDMP.Size = new System.Drawing.Size(244, 31);
            this.labelDMP.TabIndex = 4;
            this.labelDMP.Text = "Danh sách Phòng";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(500, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Danh sách Khách Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DimGray;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(52, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã Phòng";
            // 
            // lbPH
            // 
            this.lbPH.AutoSize = true;
            this.lbPH.BackColor = System.Drawing.Color.DimGray;
            this.lbPH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbPH.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPH.ForeColor = System.Drawing.Color.White;
            this.lbPH.Location = new System.Drawing.Point(228, 42);
            this.lbPH.Name = "lbPH";
            this.lbPH.Size = new System.Drawing.Size(65, 25);
            this.lbPH.TabIndex = 7;
            this.lbPH.Text = "PH01";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DimGray;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(52, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Loại Phòng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DimGray;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(52, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Đơn Giá";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DimGray;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(52, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Số Lượng";
            // 
            // lbLP
            // 
            this.lbLP.AutoSize = true;
            this.lbLP.BackColor = System.Drawing.Color.DimGray;
            this.lbLP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLP.ForeColor = System.Drawing.Color.White;
            this.lbLP.Location = new System.Drawing.Point(228, 76);
            this.lbLP.Name = "lbLP";
            this.lbLP.Size = new System.Drawing.Size(115, 25);
            this.lbLP.TabIndex = 11;
            this.lbLP.Text = "Phòng VIP";
            // 
            // lbDG
            // 
            this.lbDG.AutoSize = true;
            this.lbDG.BackColor = System.Drawing.Color.DimGray;
            this.lbDG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDG.ForeColor = System.Drawing.Color.White;
            this.lbDG.Location = new System.Drawing.Point(228, 110);
            this.lbDG.Name = "lbDG";
            this.lbDG.Size = new System.Drawing.Size(90, 25);
            this.lbDG.TabIndex = 12;
            this.lbDG.Text = "200,000";
            // 
            // lbSN
            // 
            this.lbSN.AutoSize = true;
            this.lbSN.BackColor = System.Drawing.Color.DimGray;
            this.lbSN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSN.ForeColor = System.Drawing.Color.White;
            this.lbSN.Location = new System.Drawing.Point(228, 144);
            this.lbSN.Name = "lbSN";
            this.lbSN.Size = new System.Drawing.Size(24, 25);
            this.lbSN.TabIndex = 13;
            this.lbSN.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.DimGray;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(181, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 25);
            this.label12.TabIndex = 15;
            this.label12.Text = ":";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.DimGray;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(181, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 25);
            this.label13.TabIndex = 16;
            this.label13.Text = ":";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.DimGray;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(181, 110);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 25);
            this.label14.TabIndex = 17;
            this.label14.Text = ":";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.DimGray;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(181, 144);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(19, 25);
            this.label15.TabIndex = 18;
            this.label15.Text = ":";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.lbPT);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.lbSN);
            this.panel1.Controls.Add(this.lbDG);
            this.panel1.Controls.Add(this.lbLP);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbPH);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnDP);
            this.panel1.Location = new System.Drawing.Point(63, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 341);
            this.panel1.TabIndex = 19;
            // 
            // lbPT
            // 
            this.lbPT.AutoSize = true;
            this.lbPT.BackColor = System.Drawing.Color.DimGray;
            this.lbPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPT.ForeColor = System.Drawing.Color.White;
            this.lbPT.Location = new System.Drawing.Point(228, 178);
            this.lbPT.Name = "lbPT";
            this.lbPT.Size = new System.Drawing.Size(24, 25);
            this.lbPT.TabIndex = 21;
            this.lbPT.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.DimGray;
            this.label20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(181, 178);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(19, 25);
            this.label20.TabIndex = 20;
            this.label20.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DimGray;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(52, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 25);
            this.label9.TabIndex = 19;
            this.label9.Text = "Phụ thu";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.comboTtr);
            this.panel2.Controls.Add(this.comboLP);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.boxCMND);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.boxTen);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(506, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(463, 212);
            this.panel2.TabIndex = 20;
            // 
            // comboTtr
            // 
            this.comboTtr.BackColor = System.Drawing.Color.White;
            this.comboTtr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTtr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTtr.FormattingEnabled = true;
            this.comboTtr.Items.AddRange(new object[] {
            "Trống",
            "Đã đặt"});
            this.comboTtr.Location = new System.Drawing.Point(185, 159);
            this.comboTtr.Name = "comboTtr";
            this.comboTtr.Size = new System.Drawing.Size(152, 28);
            this.comboTtr.TabIndex = 37;
            this.comboTtr.SelectedValueChanged += new System.EventHandler(this.sortPH);
            // 
            // comboLP
            // 
            this.comboLP.BackColor = System.Drawing.Color.White;
            this.comboLP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboLP.FormattingEnabled = true;
            this.comboLP.Location = new System.Drawing.Point(185, 115);
            this.comboLP.MaxDropDownItems = 5;
            this.comboLP.Name = "comboLP";
            this.comboLP.Size = new System.Drawing.Size(152, 28);
            this.comboLP.TabIndex = 36;
            this.comboLP.SelectedValueChanged += new System.EventHandler(this.sortPH);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(185, 95);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(266, 2);
            this.panel4.TabIndex = 33;
            // 
            // boxCMND
            // 
            this.boxCMND.BackColor = System.Drawing.Color.DimGray;
            this.boxCMND.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxCMND.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.boxCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxCMND.ForeColor = System.Drawing.Color.White;
            this.boxCMND.Location = new System.Drawing.Point(185, 72);
            this.boxCMND.Name = "boxCMND";
            this.boxCMND.Size = new System.Drawing.Size(251, 22);
            this.boxCMND.TabIndex = 32;
            this.boxCMND.Text = "NGUYỄN VĂN A";
            this.boxCMND.TextChanged += new System.EventHandler(this.sortKH);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(185, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(266, 2);
            this.panel3.TabIndex = 29;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.DimGray;
            this.label22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(157, 26);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(19, 25);
            this.label22.TabIndex = 28;
            this.label22.Text = ":";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.DimGray;
            this.label21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(157, 70);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(19, 25);
            this.label21.TabIndex = 27;
            this.label21.Text = ":";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.DimGray;
            this.label19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(157, 158);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(19, 25);
            this.label19.TabIndex = 25;
            this.label19.Text = ":";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.DimGray;
            this.label18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(157, 114);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(19, 25);
            this.label18.TabIndex = 19;
            this.label18.Text = ":";
            // 
            // boxTen
            // 
            this.boxTen.BackColor = System.Drawing.Color.DimGray;
            this.boxTen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxTen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.boxTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxTen.ForeColor = System.Drawing.Color.White;
            this.boxTen.Location = new System.Drawing.Point(185, 28);
            this.boxTen.Name = "boxTen";
            this.boxTen.Size = new System.Drawing.Size(251, 22);
            this.boxTen.TabIndex = 24;
            this.boxTen.Text = "NGUYỄN VĂN A";
            this.boxTen.TextChanged += new System.EventHandler(this.sortKH);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.DimGray;
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(35, 158);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(118, 25);
            this.label16.TabIndex = 23;
            this.label16.Text = "Tình Trạng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DimGray;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(35, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 25);
            this.label10.TabIndex = 22;
            this.label10.Text = "Loại Phòng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DimGray;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(35, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "Tên KH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DimGray;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(35, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "CMND";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(500, 46);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(135, 31);
            this.label17.TabIndex = 21;
            this.label17.Text = "Tìm Kiếm";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(500, 560);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 31);
            this.label1.TabIndex = 22;
            this.label1.Text = "Danh sách Điều Kiện Phụ Thu";
            // 
            // dtvDK_PT
            // 
            this.dtvDK_PT.AllowUserToAddRows = false;
            this.dtvDK_PT.AllowUserToDeleteRows = false;
            this.dtvDK_PT.AllowUserToResizeColumns = false;
            this.dtvDK_PT.AllowUserToResizeRows = false;
            this.dtvDK_PT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvDK_PT.BackgroundColor = System.Drawing.Color.White;
            this.dtvDK_PT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvDK_PT.Location = new System.Drawing.Point(506, 608);
            this.dtvDK_PT.Name = "dtvDK_PT";
            this.dtvDK_PT.ReadOnly = true;
            this.dtvDK_PT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvDK_PT.Size = new System.Drawing.Size(463, 120);
            this.dtvDK_PT.TabIndex = 23;
            this.dtvDK_PT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvDK_PT_CellClick);
            // 
            // panelNoneKH
            // 
            this.panelNoneKH.BackColor = System.Drawing.Color.LightCoral;
            this.panelNoneKH.Controls.Add(this.lbNone);
            this.panelNoneKH.Location = new System.Drawing.Point(507, 376);
            this.panelNoneKH.Name = "panelNoneKH";
            this.panelNoneKH.Size = new System.Drawing.Size(462, 159);
            this.panelNoneKH.TabIndex = 24;
            // 
            // lbNone
            // 
            this.lbNone.AutoSize = true;
            this.lbNone.BackColor = System.Drawing.Color.Transparent;
            this.lbNone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbNone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNone.ForeColor = System.Drawing.Color.White;
            this.lbNone.Location = new System.Drawing.Point(22, 53);
            this.lbNone.Name = "lbNone";
            this.lbNone.Size = new System.Drawing.Size(413, 50);
            this.lbNone.TabIndex = 22;
            this.lbNone.Text = "Không tồn tại khách hàng chưa đặt phòng\r\nHãy thêm khách hàng";
            this.lbNone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbNone.Click += new System.EventHandler(this.lbNone_Click);
            // 
            // panelNonePH
            // 
            this.panelNonePH.BackColor = System.Drawing.Color.LightCoral;
            this.panelNonePH.Controls.Add(this.label11);
            this.panelNonePH.Location = new System.Drawing.Point(63, 464);
            this.panelNonePH.Name = "panelNonePH";
            this.panelNonePH.Size = new System.Drawing.Size(385, 264);
            this.panelNonePH.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(62, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(261, 50);
            this.label11.TabIndex = 22;
            this.label11.Text = "Không tồn tại phòng trống\r\nHãy chọn loại phòng khác";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClean
            // 
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.Location = new System.Drawing.Point(880, 328);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(89, 31);
            this.btnClean.TabIndex = 26;
            this.btnClean.Text = "Xoá";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // DP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1036, 774);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.dtvDK_PT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelDMP);
            this.Controls.Add(this.dtvRoom);
            this.Controls.Add(this.panelNonePH);
            this.Controls.Add(this.dtvKH);
            this.Controls.Add(this.panelNoneKH);
            this.Name = "DP";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtvRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvKH)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvDK_PT)).EndInit();
            this.panelNoneKH.ResumeLayout(false);
            this.panelNoneKH.PerformLayout();
            this.panelNonePH.ResumeLayout(false);
            this.panelNonePH.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtvRoom;
        private System.Windows.Forms.DataGridView dtvKH;
        private System.Windows.Forms.Button btnDP;
        private System.Windows.Forms.Label labelDMP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbPH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbLP;
        private System.Windows.Forms.Label lbDG;
        private System.Windows.Forms.Label lbSN;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox boxTen;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox boxCMND;
        private System.Windows.Forms.ComboBox comboLP;
        private System.Windows.Forms.ComboBox comboTtr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtvDK_PT;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbPT;
        private System.Windows.Forms.Panel panelNoneKH;
        private System.Windows.Forms.Label lbNone;
        private System.Windows.Forms.Panel panelNonePH;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnClean;
    }
}