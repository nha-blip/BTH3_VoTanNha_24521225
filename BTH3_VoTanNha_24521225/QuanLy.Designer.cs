namespace BTH3_VoTanNha_24521225
{
    partial class QuanLy
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
            cbB_choose = new ComboBox();
            lbl_Choose = new Label();
            btn_Run = new Button();
            pnlMain = new Panel();
            pnlMain.SuspendLayout();
            SuspendLayout();
            // 
            // cbB_choose
            // 
            cbB_choose.DropDownStyle = ComboBoxStyle.DropDownList;
            cbB_choose.FormattingEnabled = true;
            cbB_choose.Items.AddRange(new object[] { "Bai01", "Bai02", "Bai03", "Bai04", "Bai05", "Bai06", "Bai07", "Bai08", "Bai09" });
            cbB_choose.Location = new Point(44, 36);
            cbB_choose.Name = "cbB_choose";
            cbB_choose.Size = new Size(151, 28);
            cbB_choose.TabIndex = 0;
            // 
            // lbl_Choose
            // 
            lbl_Choose.AutoSize = true;
            lbl_Choose.Location = new Point(44, 13);
            lbl_Choose.Name = "lbl_Choose";
            lbl_Choose.Size = new Size(144, 20);
            lbl_Choose.TabIndex = 1;
            lbl_Choose.Text = "Chọn bài muốn chạy";
            // 
            // btn_Run
            // 
            btn_Run.Location = new Point(73, 70);
            btn_Run.Name = "btn_Run";
            btn_Run.Size = new Size(93, 36);
            btn_Run.TabIndex = 2;
            btn_Run.Text = "Run";
            btn_Run.UseVisualStyleBackColor = true;
            btn_Run.Click += btn_Run_Click;
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(btn_Run);
            pnlMain.Controls.Add(lbl_Choose);
            pnlMain.Controls.Add(cbB_choose);
            pnlMain.Location = new Point(269, 133);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(250, 125);
            pnlMain.TabIndex = 3;
            // 
            // QuanLy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlMain);
            Name = "QuanLy";
            Text = "Form1";
            Resize += QuanLy_Resize;
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbB_choose;
        private Label lbl_Choose;
        private Button btn_Run;
        private Panel pnlMain;
    }
}