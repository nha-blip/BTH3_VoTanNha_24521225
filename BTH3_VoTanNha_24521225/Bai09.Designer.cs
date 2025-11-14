namespace BTH3_VoTanNha_24521225
{
    partial class Bai09
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
            grb_Nhap = new GroupBox();
            btn_Delete = new Button();
            btn_Save = new Button();
            btn_Right = new Button();
            btn_Left = new Button();
            lb_ThamGia = new ListBox();
            lb_MonHoc = new ListBox();
            chB_Male = new CheckBox();
            chB_female = new CheckBox();
            cbB_ChuyenNganh = new ComboBox();
            txt_HoTen = new TextBox();
            txt_MSSV = new TextBox();
            lbl_MonHoc = new Label();
            lbl_Chuyennganh = new Label();
            lbl_GioiTinh = new Label();
            lbl_HoTen = new Label();
            lbl_MSV = new Label();
            lv_QuanLy = new ListView();
            clH_STT = new ColumnHeader();
            clH_MSV = new ColumnHeader();
            clH_HoTen = new ColumnHeader();
            clH_ChuyenNganh = new ColumnHeader();
            clH_GioiTinh = new ColumnHeader();
            clH_SoMon = new ColumnHeader();
            pnlMain = new Panel();
            grb_Nhap.SuspendLayout();
            pnlMain.SuspendLayout();
            SuspendLayout();
            // 
            // grb_Nhap
            // 
            grb_Nhap.Controls.Add(btn_Delete);
            grb_Nhap.Controls.Add(btn_Save);
            grb_Nhap.Controls.Add(btn_Right);
            grb_Nhap.Controls.Add(btn_Left);
            grb_Nhap.Controls.Add(lb_ThamGia);
            grb_Nhap.Controls.Add(lb_MonHoc);
            grb_Nhap.Controls.Add(chB_Male);
            grb_Nhap.Controls.Add(chB_female);
            grb_Nhap.Controls.Add(cbB_ChuyenNganh);
            grb_Nhap.Controls.Add(txt_HoTen);
            grb_Nhap.Controls.Add(txt_MSSV);
            grb_Nhap.Controls.Add(lbl_MonHoc);
            grb_Nhap.Controls.Add(lbl_Chuyennganh);
            grb_Nhap.Controls.Add(lbl_GioiTinh);
            grb_Nhap.Controls.Add(lbl_HoTen);
            grb_Nhap.Controls.Add(lbl_MSV);
            grb_Nhap.Location = new Point(95, 11);
            grb_Nhap.Name = "grb_Nhap";
            grb_Nhap.Size = new Size(860, 447);
            grb_Nhap.TabIndex = 0;
            grb_Nhap.TabStop = false;
            grb_Nhap.Text = "Thông tin sinh viên";
            // 
            // btn_Delete
            // 
            btn_Delete.Font = new Font("Segoe UI", 10.8F);
            btn_Delete.Location = new Point(388, 387);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(153, 51);
            btn_Delete.TabIndex = 15;
            btn_Delete.Text = "Xóa chọn";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Save
            // 
            btn_Save.Font = new Font("Segoe UI", 10.8F);
            btn_Save.Location = new Point(191, 387);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(153, 51);
            btn_Save.TabIndex = 14;
            btn_Save.Text = "Lưu thông tin";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // btn_Right
            // 
            btn_Right.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Right.Location = new Point(324, 300);
            btn_Right.Name = "btn_Right";
            btn_Right.Size = new Size(45, 29);
            btn_Right.TabIndex = 13;
            btn_Right.Text = "<";
            btn_Right.UseVisualStyleBackColor = true;
            btn_Right.Click += btn_Right_Click;
            // 
            // btn_Left
            // 
            btn_Left.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Left.Location = new Point(324, 251);
            btn_Left.Name = "btn_Left";
            btn_Left.Size = new Size(45, 29);
            btn_Left.TabIndex = 12;
            btn_Left.Text = ">";
            btn_Left.UseVisualStyleBackColor = true;
            btn_Left.Click += btn_Left_Click;
            // 
            // lb_ThamGia
            // 
            lb_ThamGia.Font = new Font("Segoe UI", 10.8F);
            lb_ThamGia.FormattingEnabled = true;
            lb_ThamGia.Location = new Point(388, 227);
            lb_ThamGia.Name = "lb_ThamGia";
            lb_ThamGia.Size = new Size(233, 154);
            lb_ThamGia.TabIndex = 11;
            // 
            // lb_MonHoc
            // 
            lb_MonHoc.Font = new Font("Segoe UI", 10.8F);
            lb_MonHoc.FormattingEnabled = true;
            lb_MonHoc.Items.AddRange(new object[] { "Cơ sở dữ liệu", "Lập trình trực quan", "Nhập môn mạng máy tính", "Hệ điều hành", "Nhập môn lập trình" });
            lb_MonHoc.Location = new Point(75, 227);
            lb_MonHoc.Name = "lb_MonHoc";
            lb_MonHoc.SelectionMode = SelectionMode.MultiSimple;
            lb_MonHoc.Size = new Size(233, 154);
            lb_MonHoc.TabIndex = 10;
            // 
            // chB_Male
            // 
            chB_Male.AutoSize = true;
            chB_Male.FlatStyle = FlatStyle.Flat;
            chB_Male.Font = new Font("Segoe UI", 10.8F);
            chB_Male.Location = new Point(362, 157);
            chB_Male.Name = "chB_Male";
            chB_Male.Size = new Size(68, 29);
            chB_Male.TabIndex = 9;
            chB_Male.Text = "Nam";
            chB_Male.UseVisualStyleBackColor = true;
            chB_Male.CheckedChanged += chB_Male_CheckedChanged;
            // 
            // chB_female
            // 
            chB_female.AutoSize = true;
            chB_female.FlatStyle = FlatStyle.Flat;
            chB_female.Font = new Font("Segoe UI", 10.8F);
            chB_female.Location = new Point(302, 157);
            chB_female.Name = "chB_female";
            chB_female.Size = new Size(54, 29);
            chB_female.TabIndex = 8;
            chB_female.Text = "Nữ";
            chB_female.UseVisualStyleBackColor = true;
            chB_female.CheckedChanged += chB_female_CheckedChanged;
            // 
            // cbB_ChuyenNganh
            // 
            cbB_ChuyenNganh.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_ChuyenNganh.FormattingEnabled = true;
            cbB_ChuyenNganh.Items.AddRange(new object[] { "Kỹ thuật phần mềm", "Truyền thông đa phương tiền", "Khoa học máy tính", "Kỹ thuật máy tính", "Trí tuệ nhân tạo", "Thương mại điện tử" });
            cbB_ChuyenNganh.Location = new Point(302, 111);
            cbB_ChuyenNganh.Name = "cbB_ChuyenNganh";
            cbB_ChuyenNganh.Size = new Size(262, 33);
            cbB_ChuyenNganh.TabIndex = 7;
            cbB_ChuyenNganh.Text = "Kỹ thuật phần mềm";
            // 
            // txt_HoTen
            // 
            txt_HoTen.Location = new Point(302, 78);
            txt_HoTen.Name = "txt_HoTen";
            txt_HoTen.Size = new Size(262, 27);
            txt_HoTen.TabIndex = 6;
            // 
            // txt_MSSV
            // 
            txt_MSSV.Location = new Point(302, 45);
            txt_MSSV.Name = "txt_MSSV";
            txt_MSSV.Size = new Size(201, 27);
            txt_MSSV.TabIndex = 5;
            // 
            // lbl_MonHoc
            // 
            lbl_MonHoc.AutoSize = true;
            lbl_MonHoc.Font = new Font("Segoe UI", 10.8F);
            lbl_MonHoc.Location = new Point(38, 199);
            lbl_MonHoc.Name = "lbl_MonHoc";
            lbl_MonHoc.Size = new Size(235, 25);
            lbl_MonHoc.TabIndex = 4;
            lbl_MonHoc.Text = "Chọn các môn học tham gia";
            // 
            // lbl_Chuyennganh
            // 
            lbl_Chuyennganh.AutoSize = true;
            lbl_Chuyennganh.Font = new Font("Segoe UI", 10.8F);
            lbl_Chuyennganh.Location = new Point(147, 123);
            lbl_Chuyennganh.Name = "lbl_Chuyennganh";
            lbl_Chuyennganh.Size = new Size(126, 25);
            lbl_Chuyennganh.TabIndex = 3;
            lbl_Chuyennganh.Text = "Chuyên ngành";
            // 
            // lbl_GioiTinh
            // 
            lbl_GioiTinh.AutoSize = true;
            lbl_GioiTinh.Font = new Font("Segoe UI", 10.8F);
            lbl_GioiTinh.Location = new Point(195, 161);
            lbl_GioiTinh.Name = "lbl_GioiTinh";
            lbl_GioiTinh.Size = new Size(78, 25);
            lbl_GioiTinh.TabIndex = 2;
            lbl_GioiTinh.Text = "Giới tính";
            // 
            // lbl_HoTen
            // 
            lbl_HoTen.AutoSize = true;
            lbl_HoTen.Font = new Font("Segoe UI", 10.8F);
            lbl_HoTen.Location = new Point(207, 85);
            lbl_HoTen.Name = "lbl_HoTen";
            lbl_HoTen.Size = new Size(66, 25);
            lbl_HoTen.TabIndex = 1;
            lbl_HoTen.Text = "Họ tên";
            // 
            // lbl_MSV
            // 
            lbl_MSV.AutoSize = true;
            lbl_MSV.Font = new Font("Segoe UI", 10.8F);
            lbl_MSV.Location = new Point(158, 47);
            lbl_MSV.Name = "lbl_MSV";
            lbl_MSV.Size = new Size(115, 25);
            lbl_MSV.TabIndex = 0;
            lbl_MSV.Text = "Mã Sinh Viên";
            // 
            // lv_QuanLy
            // 
            lv_QuanLy.Columns.AddRange(new ColumnHeader[] { clH_STT, clH_MSV, clH_HoTen, clH_ChuyenNganh, clH_GioiTinh, clH_SoMon });
            lv_QuanLy.Location = new Point(95, 455);
            lv_QuanLy.Name = "lv_QuanLy";
            lv_QuanLy.Size = new Size(860, 411);
            lv_QuanLy.TabIndex = 1;
            lv_QuanLy.UseCompatibleStateImageBehavior = false;
            lv_QuanLy.View = View.Details;
            // 
            // clH_STT
            // 
            clH_STT.Text = "";
            // 
            // clH_MSV
            // 
            clH_MSV.Text = "MSSV";
            clH_MSV.Width = 110;
            // 
            // clH_HoTen
            // 
            clH_HoTen.Text = "Họ tên";
            clH_HoTen.Width = 210;
            // 
            // clH_ChuyenNganh
            // 
            clH_ChuyenNganh.Text = "Chuyên ngành";
            clH_ChuyenNganh.Width = 310;
            // 
            // clH_GioiTinh
            // 
            clH_GioiTinh.Text = "Giới tính";
            clH_GioiTinh.Width = 90;
            // 
            // clH_SoMon
            // 
            clH_SoMon.Text = "Số môn";
            clH_SoMon.Width = 80;
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(lv_QuanLy);
            pnlMain.Controls.Add(grb_Nhap);
            pnlMain.Location = new Point(42, 1);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1038, 891);
            pnlMain.TabIndex = 2;
            // 
            // Bai09
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 897);
            Controls.Add(pnlMain);
            Name = "Bai09";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhập liệu sinh viên";
            Resize += Bai09_Resize;
            grb_Nhap.ResumeLayout(false);
            grb_Nhap.PerformLayout();
            pnlMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grb_Nhap;
        private Label lbl_MSV;
        private ComboBox cbB_ChuyenNganh;
        private TextBox txt_HoTen;
        private TextBox txt_MSSV;
        private Label lbl_MonHoc;
        private Label lbl_Chuyennganh;
        private Label lbl_GioiTinh;
        private Label lbl_HoTen;
        private CheckBox chB_Male;
        private CheckBox chB_female;
        private ListBox lb_ThamGia;
        private ListBox lb_MonHoc;
        private Button btn_Delete;
        private Button btn_Save;
        private Button btn_Right;
        private Button btn_Left;
        private ListView lv_QuanLy;
        private ColumnHeader clH_STT;
        private ColumnHeader clH_MSV;
        private ColumnHeader clH_HoTen;
        private ColumnHeader clH_ChuyenNganh;
        private ColumnHeader clH_GioiTinh;
        private ColumnHeader clH_SoMon;
        private Panel pnlMain;
    }
}