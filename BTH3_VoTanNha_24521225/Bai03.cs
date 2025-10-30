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
        }

        void btnChangeColor_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            Color color = Color.FromArgb(rd.Next(256), rd.Next(256), rd.Next(256));
            this.BackColor = color;
        }
    }
}
