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
    public partial class Bai07 : Form
    {
        public Bai07()
        {
            InitializeComponent();
            for (int i = 0; i < 15; i++)
            {
                btn[i] = this.Controls.Find($"btn{i + 1}", true)[0] as Button;
            }
        }
        void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.White)
            {
                btn.BackColor = Color.Blue;
            }
            else if (btn.BackColor == Color.Blue)
            {
                btn.BackColor = Color.White;
            }
            else if (btn.BackColor == Color.Yellow)
            {
                MessageBox.Show("Vé đã được bán");
            }
        }
        Button[] btn = new Button[15];
        void btnSelect_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < 15; i++)
            {
                btn[i] = this.Controls.Find($"btn{i + 1}", true)[0] as Button;
            }
            foreach (Button Btn in btn)
            {
                if (Btn.BackColor == Color.Blue)
                {
                    Btn.BackColor = Color.Yellow;
                    if (int.Parse(Btn.Text) >= 1 && int.Parse(Btn.Text) < 6)
                    {
                        sum += 5000;
                    }
                    else if (int.Parse(Btn.Text) >= 6 && int.Parse(Btn.Text) < 10)
                    {
                        sum += 6500;
                    }
                    else sum += 8000;
                }
            }
            txtTotal.Text = sum.ToString();
        }
        void btnCancel_Click(object sender, EventArgs e)
        {
            foreach (Button button in btn)
            {
                if (button.BackColor == Color.Blue)
                {
                    button.BackColor = Color.White;
                }
            }
            txtTotal.Text = "0";
        }
        void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát!",
                            "Thoát",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void Bai07_Resize(object sender, EventArgs e)
        {
            pnlButtons.Location = new Point((ClientSize.Width-pnlButtons.Width)/2,(ClientSize.Height-pnlButtons.Height)/2);
        }
    }
}
