using System;
using System.Drawing;
using System.Windows.Forms;

namespace BTH3_VoTanNha_24521225
{
    public partial class Bai02 : Form
    {
        private int x, y;
        Random rd = new Random();
        private Color color;
        private SizeF textsize;
        private float xRatio, yRatio;
        public Bai02()
        {
            InitializeComponent();
            textsize = new SizeF(200, 100);
            UpdatePosition();
            UpdateColor();
            
        }
        private void UpdatePosition()
        {
            x = rd.Next(this.ClientSize.Width - (int)textsize.Width);
            y = rd.Next(this.ClientSize.Height - (int)textsize.Height);
            xRatio = (float)x / this.ClientSize.Width;
            yRatio = (float)y / this.ClientSize.Height;
        }
        private void UpdateColor()
        {
            color = Color.FromArgb(rd.Next(256), rd.Next(256), rd.Next(256));
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Font font = new Font("san-serif", 30);
            Brush brush = new SolidBrush(color);
            textsize = g.MeasureString("Hello World", font);
            g.DrawString("Hello world", font, brush, new Point(x, y));
        }
        private void btnPaint_Click(object sender, EventArgs e)
        {
            UpdatePosition();
            UpdateColor();
            this.Invalidate();
        }
        private void Bai02_Resize(object sender, EventArgs e)
        {
            x = (int)(this.ClientSize.Width * xRatio);
            y = (int)(this.ClientSize.Height * yRatio);
            this.Invalidate();
        }
        
    }
}
