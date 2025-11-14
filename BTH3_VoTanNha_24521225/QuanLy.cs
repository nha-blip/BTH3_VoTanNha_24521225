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
    public partial class QuanLy : Form
    {
        public QuanLy()
        {
            InitializeComponent();
        }
        public void btn_Run_Click(object sender, EventArgs e)
        {
            switch (cbB_choose.Text)
            {
                case "Bai01":
                    Bai01 bai01 = new Bai01();
                    bai01.ShowDialog();
                    break;
                case "Bai02":
                    Bai02 bai02 = new Bai02();
                    bai02.ShowDialog();
                    break;

                case "Bai03":
                    Bai03 bai03 = new Bai03();
                    bai03.ShowDialog();
                    break;

                case "Bai04":
                    Bai04 bai04 = new Bai04();
                    bai04.ShowDialog();
                    break;

                case "Bai05":
                    Bai05 bai05 = new Bai05();
                    bai05.ShowDialog();
                    break;

                case "Bai06":
                    Bai06 bai06 = new Bai06();
                    bai06.ShowDialog();
                    break;

                case "Bai07":
                    Bai07 bai07 = new Bai07();
                    bai07.ShowDialog();
                    break;

                case "Bai08":
                    Bai08 bai08 = new Bai08();
                    bai08.ShowDialog();
                    break;

                case "Bai09":
                    Bai09 bai09 = new Bai09();
                    bai09.ShowDialog();
                    break;
            }
        }

        private void QuanLy_Resize(object sender, EventArgs e)
        {
            pnlMain.Location= new Point((ClientSize.Width-pnlMain.Width)/2,(ClientSize.Height-pnlMain.Height)/2);
        }
    }
}
