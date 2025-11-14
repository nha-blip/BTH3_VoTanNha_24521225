using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH3_VoTanNha_24521225
{
    public partial class Bai03 : Form
    {
        public Bai03()
        {
            InitializeComponent();
            btnChangeColor.Location = new Point((ClientSize.Width - btnChangeColor.Size.Width) / 2, (ClientSize.Height - btnChangeColor.Size.Height) / 2);
        }

        void btnChangeColor_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            Color color = Color.FromArgb(rd.Next(256), rd.Next(256), rd.Next(256));
            this.BackColor = color;
        }

        private void Bai03_Resize(object sender, EventArgs e)
        {
            btnChangeColor.Location = new Point((ClientSize.Width - btnChangeColor.Size.Width) / 2, (ClientSize.Height - btnChangeColor.Size.Height) / 2);
        }
    }
}
