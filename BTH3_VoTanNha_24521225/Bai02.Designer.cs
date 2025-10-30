namespace BTH3_VoTanNha_24521225
{
    partial class Bai02
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
            btnPaint = new Button();
            SuspendLayout();
            // 
            // btnPaint
            // 
            btnPaint.Location = new Point(12, 12);
            btnPaint.Name = "btnPaint";
            btnPaint.Size = new Size(94, 29);
            btnPaint.TabIndex = 0;
            btnPaint.Text = "Paint";
            btnPaint.UseVisualStyleBackColor = true;
            btnPaint.Click += btnPaint_Click;
            // 
            // Bai02
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPaint);
            Name = "Bai02";
            Text = "Bai2";
            Resize += Bai02_Resize;
            ResumeLayout(false);
        }

        #endregion

        private Button btnPaint;
    }
}