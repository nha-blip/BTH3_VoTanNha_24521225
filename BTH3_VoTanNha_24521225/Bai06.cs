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
    public partial class Bai06 : Form
    {
        public Bai06()
        {
            InitializeComponent();
        }
        // Biến toàn cục trong lớp Bai06
        double memory = 0;         // bộ nhớ
        double result = 0;         // kết quả hiện tại
        string operation = "";     // phép toán hiện hành
        bool isNewInput = true;    // đánh dấu nhập mới

        private void Bai06_Load(object sender, EventArgs e)
        {
            foreach (Button btn in pnlMain.Controls.OfType<Button>())
            {
                btn.Click += Button_Click;
            }
        }

        // Xử lý sự kiện click chung cho tất cả button
        private void Button_Click(object? sender, EventArgs e)
        {
            Button btn = sender as Button;
            string text = btn.Text;

            // --- Nhập số hoặc dấu chấm ---
            if ((text.Length==1 && char.IsDigit(text, 0)) || text == ".")
            {
                if (isNewInput)
                {
                    txtDisplay.Text = (text == ".") ? "0." : text;
                    isNewInput = false;
                }
                else if (!(text == "." && txtDisplay.Text.Contains(".")))
                {
                    txtDisplay.Text += text;
                }
            }

            // --- Xóa ---
            else if (text == "C")
            {
                txtDisplay.Text = "0.";
                result = 0;
                operation = "";
                isNewInput = true;
            }
            else if (text == "CE")
            {
                txtDisplay.Text = "0.";
                isNewInput = true;
            }
            else if (text == "Backspace")
            {
                if (!isNewInput && txtDisplay.Text.Length > 0)
                {
                    txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
                    if (txtDisplay.Text == "") txtDisplay.Text = "0.";
                }
            }

            // --- Phép toán ---
            else if ("+-*/".Contains(text))
            {
                result = double.Parse(txtDisplay.Text);
                operation = text;
                isNewInput = true;
            }

            // --- Dấu bằng ---
            else if (text == "=")
            {
                double second = double.Parse(txtDisplay.Text);
                switch (operation)
                {
                    case "+": result += second; break;
                    case "-": result -= second; break;
                    case "*": result *= second; break;
                    case "/":
                        if (second == 0) { MessageBox.Show("Không thể chia cho 0"); return; }
                        result /= second;
                        break;
                }
                txtDisplay.Text = result.ToString();
                operation = "";
                isNewInput = true;
            }

            // --- Các phép đặc biệt ---
            else if (text == "sqrt")
            {
                double val = double.Parse(txtDisplay.Text);
                if (val < 0) { MessageBox.Show("Không thể căn bậc hai số âm!"); return; }
                txtDisplay.Text = Math.Sqrt(val).ToString();
                isNewInput = true;
            }
            else if (text == "1/x")
            {
                if (double.TryParse(txtDisplay.Text, out double val))
                {
                    if (val == 0)
                    {
                        MessageBox.Show("Không thể chia cho 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    double resultVal = 1 / val;
                    txtDisplay.Text = resultVal.ToString();
                    isNewInput = true;
                }
                else
                {
                    MessageBox.Show("Giá trị không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (text == "%")
            {
                double val = double.Parse(txtDisplay.Text);
                txtDisplay.Text = (val / 100).ToString();
                isNewInput = true;
            }
            else if (text == "+/-")
            {
                double val = double.Parse(txtDisplay.Text);
                txtDisplay.Text = (-val).ToString();
            }

            // --- Bộ nhớ ---
            else if (text == "MC") memory = 0;
            else if (text == "MR") txtDisplay.Text = memory.ToString();
            else if (text == "MS") memory = double.Parse(txtDisplay.Text);
            else if (text == "M+") memory += double.Parse(txtDisplay.Text);
        }

        private void Bai06_Resize(object sender, EventArgs e)
        {
            pnlMain.Location = new Point((ClientSize.Width - pnlMain.Width) / 2, (ClientSize.Height - pnlMain.Height) / 2);
        }
    }
}
