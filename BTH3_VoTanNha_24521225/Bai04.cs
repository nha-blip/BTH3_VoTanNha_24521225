namespace BTH3_VoTanNha_24521225
{
    public partial class Bai04 : Form
    {
        public Bai04()
        {
            InitializeComponent();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if(color.ShowDialog()==DialogResult.OK)
            this.BackColor = color.Color;
        }
    }
}
