namespace BTH3_VoTanNha_24521225
{
    partial class Bai05
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
            txtNumber1 = new TextBox();
            txtNumber2 = new TextBox();
            txtAnswer = new TextBox();
            btnPlus = new Button();
            btnMinus = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            pnlMain = new Panel();
            pnlMain.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 70);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 0;
            label1.Text = "Number1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 110);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 1;
            label2.Text = "Number2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 233);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 2;
            label3.Text = "Answer";
            // 
            // txtNumber1
            // 
            txtNumber1.Location = new Point(206, 70);
            txtNumber1.Name = "txtNumber1";
            txtNumber1.Size = new Size(230, 27);
            txtNumber1.TabIndex = 3;
            // 
            // txtNumber2
            // 
            txtNumber2.Location = new Point(206, 110);
            txtNumber2.Name = "txtNumber2";
            txtNumber2.Size = new Size(230, 27);
            txtNumber2.TabIndex = 4;
            // 
            // txtAnswer
            // 
            txtAnswer.Location = new Point(206, 226);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.ReadOnly = true;
            txtAnswer.Size = new Size(230, 27);
            txtAnswer.TabIndex = 5;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = SystemColors.ActiveBorder;
            btnPlus.FlatStyle = FlatStyle.Flat;
            btnPlus.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPlus.Location = new Point(137, 151);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(59, 52);
            btnPlus.TabIndex = 6;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = SystemColors.ActiveBorder;
            btnMinus.FlatStyle = FlatStyle.Flat;
            btnMinus.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMinus.Location = new Point(215, 151);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(59, 52);
            btnMinus.TabIndex = 7;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = SystemColors.ActiveBorder;
            btnMultiply.FlatStyle = FlatStyle.Flat;
            btnMultiply.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMultiply.Location = new Point(291, 151);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(59, 52);
            btnMultiply.TabIndex = 8;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = SystemColors.ActiveBorder;
            btnDivide.FlatStyle = FlatStyle.Flat;
            btnDivide.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDivide.Location = new Point(368, 151);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(59, 52);
            btnDivide.TabIndex = 9;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_Click;
            // 
            // pnlMain
            // 
            pnlMain.Anchor = AnchorStyles.None;
            pnlMain.Controls.Add(label1);
            pnlMain.Controls.Add(label2);
            pnlMain.Controls.Add(label3);
            pnlMain.Controls.Add(txtNumber1);
            pnlMain.Controls.Add(txtNumber2);
            pnlMain.Controls.Add(txtAnswer);
            pnlMain.Controls.Add(btnPlus);
            pnlMain.Controls.Add(btnMinus);
            pnlMain.Controls.Add(btnMultiply);
            pnlMain.Controls.Add(btnDivide);
            pnlMain.Location = new Point(403, 317);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(516, 298);
            pnlMain.TabIndex = 10;
            // 
            // Bai05
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 578);
            Controls.Add(pnlMain);
            Name = "Bai05";
            Text = "Bai05";
            Resize += Bai05_Resize;
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNumber1;
        private TextBox txtNumber2;
        private TextBox txtAnswer;
        private Button btnPlus;
        private Button btnMinus;
        private Button btnMultiply;
        private Button btnDivide;
        private Panel pnlMain;
    }
}