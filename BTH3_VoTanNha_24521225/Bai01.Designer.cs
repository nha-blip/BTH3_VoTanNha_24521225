namespace BTH3_VoTanNha_24521225
{
    partial class Bai01
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
            lbl_Hienthi = new Label();
            btnOpen = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lbl_Hienthi
            // 
            lbl_Hienthi.AutoSize = true;
            lbl_Hienthi.Location = new Point(9, 30);
            lbl_Hienthi.Name = "lbl_Hienthi";
            lbl_Hienthi.Size = new Size(0, 20);
            lbl_Hienthi.TabIndex = 0;
            // 
            // btnOpen
            // 
            btnOpen.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOpen.Location = new Point(681, 30);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(94, 29);
            btnOpen.TabIndex = 1;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Location = new Point(681, 79);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // Bai01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(btnOpen);
            Controls.Add(lbl_Hienthi);
            Name = "Bai01";
            Text = "Bai1";
            Activated += Bai1_Activated;
            FormClosing += Bai1_Closing;
            Load += Bai01_Load;
            Shown += Bai1_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Hienthi;
        private Button btnOpen;
        private Button btnClose;
    }
}