using System.Drawing;
using System.Windows.Forms;

namespace BTH3_VoTanNha_24521225
{
    partial class Bai06
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            mnuMain = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuView = new ToolStripMenuItem();
            mnuHelp = new ToolStripMenuItem();
            txtDisplay = new TextBox();
            btnBlank = new Button();
            btnBackspace = new Button();
            btnCE = new Button();
            btnC = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnDivide = new Button();
            btnSqrt = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnMultiply = new Button();
            btnPercent = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnMinus = new Button();
            btnInverse = new Button();
            btn0 = new Button();
            btnDot = new Button();
            btnSign = new Button();
            btnPlus = new Button();
            btnEqual = new Button();
            btnMC = new Button();
            btnMR = new Button();
            btnMS = new Button();
            btnMPlus = new Button();
            pnlMain = new Panel();
            mnuMain.SuspendLayout();
            pnlMain.SuspendLayout();
            SuspendLayout();
            // 
            // mnuMain
            // 
            mnuMain.ImageScalingSize = new Size(20, 20);
            mnuMain.Items.AddRange(new ToolStripItem[] { mnuFile, mnuView, mnuHelp });
            mnuMain.Location = new Point(0, 0);
            mnuMain.Name = "mnuMain";
            mnuMain.Size = new Size(385, 28);
            mnuMain.TabIndex = 0;
            // 
            // mnuFile
            // 
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(46, 24);
            mnuFile.Text = "&File";
            // 
            // mnuView
            // 
            mnuView.Name = "mnuView";
            mnuView.Size = new Size(55, 24);
            mnuView.Text = "&View";
            // 
            // mnuHelp
            // 
            mnuHelp.Name = "mnuHelp";
            mnuHelp.Size = new Size(55, 24);
            mnuHelp.Text = "&Help";
            // 
            // txtDisplay
            // 
            txtDisplay.Font = new Font("Segoe UI", 10.8F);
            txtDisplay.Location = new Point(12, 31);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(342, 34);
            txtDisplay.TabIndex = 1;
            txtDisplay.Text = "0.";
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // btnBlank
            // 
            btnBlank.FlatStyle = FlatStyle.Flat;
            btnBlank.Location = new Point(12, 84);
            btnBlank.Name = "btnBlank";
            btnBlank.Size = new Size(47, 46);
            btnBlank.TabIndex = 2;
            // 
            // btnBackspace
            // 
            btnBackspace.ForeColor = Color.Red;
            btnBackspace.Location = new Point(75, 84);
            btnBackspace.Name = "btnBackspace";
            btnBackspace.Size = new Size(91, 46);
            btnBackspace.TabIndex = 3;
            btnBackspace.Text = "Backspace";
            // 
            // btnCE
            // 
            btnCE.ForeColor = Color.Red;
            btnCE.Location = new Point(172, 84);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(88, 46);
            btnCE.TabIndex = 4;
            btnCE.Text = "CE";
            // 
            // btnC
            // 
            btnC.ForeColor = Color.Red;
            btnC.Location = new Point(266, 84);
            btnC.Name = "btnC";
            btnC.Size = new Size(88, 46);
            btnC.TabIndex = 5;
            btnC.Text = "C";
            // 
            // btn7
            // 
            btn7.ForeColor = Color.Blue;
            btn7.Location = new Point(75, 153);
            btn7.Name = "btn7";
            btn7.Size = new Size(51, 42);
            btn7.TabIndex = 6;
            btn7.Text = "7";
            // 
            // btn8
            // 
            btn8.ForeColor = Color.Blue;
            btn8.Location = new Point(132, 153);
            btn8.Name = "btn8";
            btn8.Size = new Size(51, 42);
            btn8.TabIndex = 7;
            btn8.Text = "8";
            // 
            // btn9
            // 
            btn9.ForeColor = Color.Blue;
            btn9.Location = new Point(189, 153);
            btn9.Name = "btn9";
            btn9.Size = new Size(51, 42);
            btn9.TabIndex = 8;
            btn9.Text = "9";
            // 
            // btnDivide
            // 
            btnDivide.ForeColor = Color.Red;
            btnDivide.Location = new Point(246, 153);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(51, 42);
            btnDivide.TabIndex = 9;
            btnDivide.Text = "/";
            // 
            // btnSqrt
            // 
            btnSqrt.ForeColor = Color.Blue;
            btnSqrt.Location = new Point(303, 153);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(51, 42);
            btnSqrt.TabIndex = 10;
            btnSqrt.Text = "sqrt";
            // 
            // btn4
            // 
            btn4.ForeColor = Color.Blue;
            btn4.Location = new Point(75, 201);
            btn4.Name = "btn4";
            btn4.Size = new Size(51, 42);
            btn4.TabIndex = 11;
            btn4.Text = "4";
            // 
            // btn5
            // 
            btn5.ForeColor = Color.Blue;
            btn5.Location = new Point(132, 201);
            btn5.Name = "btn5";
            btn5.Size = new Size(51, 42);
            btn5.TabIndex = 12;
            btn5.Text = "5";
            // 
            // btn6
            // 
            btn6.ForeColor = Color.Blue;
            btn6.Location = new Point(189, 201);
            btn6.Name = "btn6";
            btn6.Size = new Size(51, 42);
            btn6.TabIndex = 13;
            btn6.Text = "6";
            // 
            // btnMultiply
            // 
            btnMultiply.ForeColor = Color.Red;
            btnMultiply.Location = new Point(246, 201);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(51, 42);
            btnMultiply.TabIndex = 14;
            btnMultiply.Text = "*";
            // 
            // btnPercent
            // 
            btnPercent.ForeColor = Color.Blue;
            btnPercent.Location = new Point(303, 201);
            btnPercent.Name = "btnPercent";
            btnPercent.Size = new Size(51, 42);
            btnPercent.TabIndex = 15;
            btnPercent.Text = "%";
            // 
            // btn1
            // 
            btn1.ForeColor = Color.Blue;
            btn1.Location = new Point(75, 249);
            btn1.Name = "btn1";
            btn1.Size = new Size(51, 42);
            btn1.TabIndex = 16;
            btn1.Text = "1";
            // 
            // btn2
            // 
            btn2.ForeColor = Color.Blue;
            btn2.Location = new Point(132, 249);
            btn2.Name = "btn2";
            btn2.Size = new Size(51, 42);
            btn2.TabIndex = 17;
            btn2.Text = "2";
            // 
            // btn3
            // 
            btn3.ForeColor = Color.Blue;
            btn3.Location = new Point(189, 249);
            btn3.Name = "btn3";
            btn3.Size = new Size(51, 42);
            btn3.TabIndex = 18;
            btn3.Text = "3";
            // 
            // btnMinus
            // 
            btnMinus.ForeColor = Color.Red;
            btnMinus.Location = new Point(246, 249);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(51, 42);
            btnMinus.TabIndex = 19;
            btnMinus.Text = "-";
            // 
            // btnInverse
            // 
            btnInverse.ForeColor = Color.Blue;
            btnInverse.Location = new Point(303, 249);
            btnInverse.Name = "btnInverse";
            btnInverse.Size = new Size(51, 42);
            btnInverse.TabIndex = 20;
            btnInverse.Text = "1/x";
            // 
            // btn0
            // 
            btn0.ForeColor = Color.Blue;
            btn0.Location = new Point(75, 297);
            btn0.Name = "btn0";
            btn0.Size = new Size(51, 42);
            btn0.TabIndex = 21;
            btn0.Text = "0";
            // 
            // btnDot
            // 
            btnDot.ForeColor = Color.Blue;
            btnDot.Location = new Point(132, 297);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(51, 42);
            btnDot.TabIndex = 22;
            btnDot.Text = ".";
            // 
            // btnSign
            // 
            btnSign.ForeColor = Color.Blue;
            btnSign.Location = new Point(189, 297);
            btnSign.Name = "btnSign";
            btnSign.Size = new Size(51, 42);
            btnSign.TabIndex = 23;
            btnSign.Text = "+/-";
            // 
            // btnPlus
            // 
            btnPlus.ForeColor = Color.Red;
            btnPlus.Location = new Point(246, 297);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(51, 42);
            btnPlus.TabIndex = 24;
            btnPlus.Text = "+";
            // 
            // btnEqual
            // 
            btnEqual.ForeColor = Color.Red;
            btnEqual.Location = new Point(303, 297);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(51, 42);
            btnEqual.TabIndex = 25;
            btnEqual.Text = "=";
            // 
            // btnMC
            // 
            btnMC.ForeColor = Color.Red;
            btnMC.Location = new Point(12, 153);
            btnMC.Name = "btnMC";
            btnMC.Size = new Size(51, 42);
            btnMC.TabIndex = 26;
            btnMC.Text = "MC";
            // 
            // btnMR
            // 
            btnMR.ForeColor = Color.Red;
            btnMR.Location = new Point(12, 201);
            btnMR.Name = "btnMR";
            btnMR.Size = new Size(51, 42);
            btnMR.TabIndex = 27;
            btnMR.Text = "MR";
            // 
            // btnMS
            // 
            btnMS.ForeColor = Color.Red;
            btnMS.Location = new Point(12, 249);
            btnMS.Name = "btnMS";
            btnMS.Size = new Size(51, 42);
            btnMS.TabIndex = 28;
            btnMS.Text = "MS";
            // 
            // btnMPlus
            // 
            btnMPlus.ForeColor = Color.Red;
            btnMPlus.Location = new Point(12, 297);
            btnMPlus.Name = "btnMPlus";
            btnMPlus.Size = new Size(51, 42);
            btnMPlus.TabIndex = 29;
            btnMPlus.Text = "M+";
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(txtDisplay);
            pnlMain.Controls.Add(btnBlank);
            pnlMain.Controls.Add(btnBackspace);
            pnlMain.Controls.Add(btnCE);
            pnlMain.Controls.Add(btnC);
            pnlMain.Controls.Add(btn7);
            pnlMain.Controls.Add(btn8);
            pnlMain.Controls.Add(btn9);
            pnlMain.Controls.Add(btnDivide);
            pnlMain.Controls.Add(btnSqrt);
            pnlMain.Controls.Add(btn4);
            pnlMain.Controls.Add(btn5);
            pnlMain.Controls.Add(btn6);
            pnlMain.Controls.Add(btnMultiply);
            pnlMain.Controls.Add(btnPercent);
            pnlMain.Controls.Add(btn1);
            pnlMain.Controls.Add(btn2);
            pnlMain.Controls.Add(btn3);
            pnlMain.Controls.Add(btnMinus);
            pnlMain.Controls.Add(btnInverse);
            pnlMain.Controls.Add(btn0);
            pnlMain.Controls.Add(btnDot);
            pnlMain.Controls.Add(btnSign);
            pnlMain.Controls.Add(btnPlus);
            pnlMain.Controls.Add(btnEqual);
            pnlMain.Controls.Add(btnMC);
            pnlMain.Controls.Add(btnMR);
            pnlMain.Controls.Add(btnMS);
            pnlMain.Controls.Add(btnMPlus);
            pnlMain.Location = new Point(0, 30);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(385, 391);
            pnlMain.TabIndex = 0;
            // 
            // Bai06
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 450);
            Controls.Add(pnlMain);
            Controls.Add(mnuMain);
            MainMenuStrip = mnuMain;
            Name = "Bai06";
            Text = "Calculator";
            Load += Bai06_Load;
            Resize += Bai06_Resize;
            mnuMain.ResumeLayout(false);
            mnuMain.PerformLayout();
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuMain;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuView;
        private ToolStripMenuItem mnuHelp;
        private TextBox txtDisplay;
        private Panel pnlMain;
        private Button btnBlank, btnBackspace, btnCE, btnC;
        private Button btn7, btn8, btn9, btnDivide, btnSqrt;
        private Button btn4, btn5, btn6, btnMultiply, btnPercent;
        private Button btn1, btn2, btn3, btnMinus, btnInverse;
        private Button btn0, btnDot, btnSign, btnPlus, btnEqual;
        private Button btnMC, btnMR, btnMS, btnMPlus;
    }
}
