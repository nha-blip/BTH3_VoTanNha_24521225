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
    public partial class Bai05 : Form
    {
        public Bai05()
        {
            InitializeComponent();
            pnlMain.Location = new Point((ClientSize.Width - pnlMain.Size.Width) / 2, (ClientSize.Height - pnlMain.Size.Height) / 2);
        }
        // Hàm cộng
        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (TryGetNumbers(out double a, out double b))
                txtAnswer.Text = (a + b).ToString();
        }

        // Hàm trừ
        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (TryGetNumbers(out double a, out double b))
                txtAnswer.Text = (a - b).ToString();
        }

        // Hàm nhân
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (TryGetNumbers(out double a, out double b))
                txtAnswer.Text = (a * b).ToString();
        }

        // Hàm chia
        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (TryGetNumbers(out double a, out double b))
            {
                if (b == 0)
                {
                    MessageBox.Show("Không thể chia cho 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAnswer.Text = "";
                    return;
                }
                txtAnswer.Text = (a / b).ToString();
            }
        }
        private bool TryGetNumbers(out double a, out double b)
        {
            if (!double.TryParse(txtNumber1.Text, out a))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ cho Number1!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                b = 0;
                txtAnswer.Text = "";
                return false;
            }

            if (!double.TryParse(txtNumber2.Text, out b))
            {
                txtAnswer.Text = "";
                MessageBox.Show("Vui lòng nhập số hợp lệ cho Number2!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void Bai05_Resize(object sender, EventArgs e)
        {
            pnlMain.Location = new Point((ClientSize.Width - pnlMain.Size.Width) / 2, (ClientSize.Height - pnlMain.Size.Height) / 2);
        }
    }
}

