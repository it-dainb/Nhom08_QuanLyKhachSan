namespace Nhom08_QuanLyKhachSan.GUI
{
    partial class BC
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnToday = new System.Windows.Forms.Button();
            this.btn6mon = new System.Windows.Forms.Button();
            this.btn12mon = new System.Windows.Forms.Button();
            this.dataBC = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnCus = new System.Windows.Forms.Button();
            this.dpEndDate = new DateTimePickerYearMonth();
            this.dpStartDate = new DateTimePickerYearMonth();
            ((System.ComponentModel.ISupportInitialize)(this.dataBC)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Báo cáo";
            // 
            // btnToday
            // 
            this.btnToday.BackColor = System.Drawing.Color.White;
            this.btnToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToday.Location = new System.Drawing.Point(215, 133);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(75, 23);
            this.btnToday.TabIndex = 8;
            this.btnToday.Text = "Tháng này";
            this.btnToday.UseVisualStyleBackColor = false;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // btn6mon
            // 
            this.btn6mon.BackColor = System.Drawing.Color.White;
            this.btn6mon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6mon.Location = new System.Drawing.Point(296, 133);
            this.btn6mon.Name = "btn6mon";
            this.btn6mon.Size = new System.Drawing.Size(75, 23);
            this.btn6mon.TabIndex = 9;
            this.btn6mon.Text = "6 Tháng";
            this.btn6mon.UseVisualStyleBackColor = false;
            this.btn6mon.Click += new System.EventHandler(this.btn6mon_Click);
            // 
            // btn12mon
            // 
            this.btn12mon.BackColor = System.Drawing.Color.White;
            this.btn12mon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn12mon.Location = new System.Drawing.Point(377, 133);
            this.btn12mon.Name = "btn12mon";
            this.btn12mon.Size = new System.Drawing.Size(75, 23);
            this.btn12mon.TabIndex = 10;
            this.btn12mon.Text = "12 Tháng";
            this.btn12mon.UseVisualStyleBackColor = false;
            this.btn12mon.Click += new System.EventHandler(this.btn12mon_Click);
            // 
            // dataBC
            // 
            this.dataBC.AllowUserToAddRows = false;
            this.dataBC.AllowUserToDeleteRows = false;
            this.dataBC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataBC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataBC.BackgroundColor = System.Drawing.Color.White;
            this.dataBC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBC.Location = new System.Drawing.Point(134, 184);
            this.dataBC.Name = "dataBC";
            this.dataBC.ReadOnly = true;
            this.dataBC.Size = new System.Drawing.Size(780, 487);
            this.dataBC.TabIndex = 11;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.White;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Location = new System.Drawing.Point(839, 133);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 12;
            this.btnPrint.Text = "In";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnCus
            // 
            this.btnCus.BackColor = System.Drawing.Color.White;
            this.btnCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCus.Location = new System.Drawing.Point(134, 133);
            this.btnCus.Name = "btnCus";
            this.btnCus.Size = new System.Drawing.Size(75, 23);
            this.btnCus.TabIndex = 13;
            this.btnCus.Text = "Tuỳ chỉnh";
            this.btnCus.UseVisualStyleBackColor = false;
            this.btnCus.Click += new System.EventHandler(this.btnCus_Click);
            // 
            // dpEndDate
            // 
            this.dpEndDate.CustomFormat = "MM / yyyy";
            this.dpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpEndDate.Location = new System.Drawing.Point(255, 89);
            this.dpEndDate.Name = "dpEndDate";
            this.dpEndDate.Size = new System.Drawing.Size(92, 20);
            this.dpEndDate.TabIndex = 6;
            this.dpEndDate.Value = new System.DateTime(2023, 12, 26, 18, 26, 33, 902);
            this.dpEndDate.ValueChanged += new System.EventHandler(this.dpEndDate_ValueChanged);
            // 
            // dpStartDate
            // 
            this.dpStartDate.CustomFormat = "MM / yyyy";
            this.dpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpStartDate.Location = new System.Drawing.Point(136, 89);
            this.dpStartDate.Name = "dpStartDate";
            this.dpStartDate.Size = new System.Drawing.Size(92, 20);
            this.dpStartDate.TabIndex = 5;
            this.dpStartDate.Value = new System.DateTime(2023, 12, 26, 18, 26, 33, 902);
            this.dpStartDate.ValueChanged += new System.EventHandler(this.dpStartDate_ValueChanged);
            // 
            // BC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1036, 774);
            this.Controls.Add(this.btnCus);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dataBC);
            this.Controls.Add(this.btn12mon);
            this.Controls.Add(this.btn6mon);
            this.Controls.Add(this.btnToday);
            this.Controls.Add(this.dpEndDate);
            this.Controls.Add(this.dpStartDate);
            this.Controls.Add(this.label2);
            this.Name = "BC";
            this.Text = "BC";
            ((System.ComponentModel.ISupportInitialize)(this.dataBC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private DateTimePickerYearMonth dpStartDate;
        private DateTimePickerYearMonth dpEndDate;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Button btn6mon;
        private System.Windows.Forms.Button btn12mon;
        private System.Windows.Forms.DataGridView dataBC;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnCus;
    }
}