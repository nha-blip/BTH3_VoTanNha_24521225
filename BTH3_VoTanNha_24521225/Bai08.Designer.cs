namespace BTH3_VoTanNha_24521225
{
    partial class Bai08
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtDiaChi = new TextBox();
            txtSoTien = new TextBox();
            txtSTK = new TextBox();
            txtTenKH = new TextBox();
            lVThongTin = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            btnThem = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            pnlMain = new Panel();
            pnlMain.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Control;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1068, 56);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.Location = new Point(325, 65);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(111, 25);
            label2.TabIndex = 1;
            label2.Text = "Số tài khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F);
            label3.Location = new Point(302, 104);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(134, 25);
            label3.TabIndex = 2;
            label3.Text = "Tên khách hàng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F);
            label4.Location = new Point(275, 141);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(161, 25);
            label4.TabIndex = 3;
            label4.Text = "Địa chỉ khách hàng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F);
            label5.Location = new Point(242, 178);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(194, 25);
            label5.TabIndex = 4;
            label5.Text = "Số tiền trong tài khoản";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(443, 135);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(299, 31);
            txtDiaChi.TabIndex = 6;
            // 
            // txtSoTien
            // 
            txtSoTien.Location = new Point(443, 172);
            txtSoTien.Name = "txtSoTien";
            txtSoTien.Size = new Size(299, 31);
            txtSoTien.TabIndex = 7;
            // 
            // txtSTK
            // 
            txtSTK.Location = new Point(443, 59);
            txtSTK.Name = "txtSTK";
            txtSTK.Size = new Size(299, 31);
            txtSTK.TabIndex = 8;
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(443, 98);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(299, 31);
            txtTenKH.TabIndex = 9;
            // 
            // lVThongTin
            // 
            lVThongTin.BorderStyle = BorderStyle.FixedSingle;
            lVThongTin.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lVThongTin.FullRowSelect = true;
            lVThongTin.Location = new Point(50, 266);
            lVThongTin.MultiSelect = false;
            lVThongTin.Name = "lVThongTin";
            lVThongTin.Size = new Size(964, 365);
            lVThongTin.TabIndex = 10;
            lVThongTin.UseCompatibleStateImageBehavior = false;
            lVThongTin.View = View.Details;
            lVThongTin.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "STT";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Mã tài khoản";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Tên khách hàng";
            columnHeader3.Width = 300;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Địa chỉ";
            columnHeader4.Width = 300;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Số tiền ";
            columnHeader5.Width = 100;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(302, 219);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(154, 41);
            btnThem.TabIndex = 11;
            btnThem.Text = "Thêm/Cập nhật";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(483, 219);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 41);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(610, 219);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 41);
            btnThoat.TabIndex = 13;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(btnThoat);
            pnlMain.Controls.Add(btnXoa);
            pnlMain.Controls.Add(btnThem);
            pnlMain.Controls.Add(lVThongTin);
            pnlMain.Controls.Add(txtTenKH);
            pnlMain.Controls.Add(txtSTK);
            pnlMain.Controls.Add(txtSoTien);
            pnlMain.Controls.Add(txtDiaChi);
            pnlMain.Controls.Add(label5);
            pnlMain.Controls.Add(label4);
            pnlMain.Controls.Add(label3);
            pnlMain.Controls.Add(label2);
            pnlMain.Controls.Add(label1);
            pnlMain.Location = new Point(24, 1);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1068, 680);
            pnlMain.TabIndex = 14;
            // 
            // Bai08
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 734);
            Controls.Add(pnlMain);
            Font = new Font("Segoe UI", 10.8F);
            Margin = new Padding(4);
            Name = "Bai08";
            Text = "Quản lý tài khoản";
            Resize += Bai08_Resize;
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtDiaChi;
        private TextBox txtSoTien;
        private TextBox txtSTK;
        private TextBox txtTenKH;
        private ListView lVThongTin;
        private Button btnThem;
        private Button btnXoa;
        private Button btnThoat;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Panel pnlMain;
    }
}