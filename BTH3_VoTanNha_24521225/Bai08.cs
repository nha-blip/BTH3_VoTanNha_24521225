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
    public partial class Bai08 : Form
    {
        public Bai08()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtSTK.Text == "" || txtDiaChi.Text == "" || txtSoTien.Text == "" || txtTenKH.Text == "")
            {
                MessageBox.Show("“Vui lòng nhập đầy đủ thông tin!");
            }
            else if (!float.TryParse(txtSTK.Text, out float b))
            {
                MessageBox.Show("Số tài khoản phải là một số");
            }
            else if (!float.TryParse(txtSoTien.Text, out float a))
            {
                MessageBox.Show("Số tiền phải là một số");
            }
            else
            {
                for (int i = 0; i < lVThongTin.Items.Count; i++)
                {
                    if (lVThongTin.Items[i].SubItems[1].Text == txtSTK.Text)
                    {
                        lVThongTin.Items[i].SubItems[2].Text = txtTenKH.Text;
                        lVThongTin.Items[i].SubItems[3].Text = txtDiaChi.Text;
                        lVThongTin.Items[i].SubItems[4].Text = (int.Parse(lVThongTin.Items[i].SubItems[4].Text) + int.Parse(txtSoTien.Text)).ToString();
                        MessageBox.Show("Cập nhật dữ liệu thành công!");
                        return;
                    }
                }
                int stt = lVThongTin.Items.Count + 1;
                ListViewItem items = new ListViewItem(stt.ToString());
                items.SubItems.Add(txtSTK.Text);
                items.SubItems.Add(txtTenKH.Text);
                items.SubItems.Add(txtDiaChi.Text);
                items.SubItems.Add(txtSoTien.Text);
                lVThongTin.Items.Add(items);
                MessageBox.Show("Thêm dữ liệu thành công!");
            }
        }
        private void UpdateSTT()
        {
            for (int i = 0; i < lVThongTin.Items.Count; i++)
            {
                lVThongTin.Items[i].SubItems[0].Text = (i + 1).ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa",
                                                 "Xóa",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Warning);
            if (result == DialogResult.No) return;
            for (int i = 0; i < lVThongTin.Items.Count; i++)
            {
                if (lVThongTin.Items[i].SubItems[1].Text == txtSTK.Text)
                {
                    lVThongTin.Items[i].Remove();
                    UpdateSTT();
                    MessageBox.Show("Xóa tài khoản thành công");
                    return;
                }
            }
            MessageBox.Show("Không tìm thấy số tài khoản cần xóa");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lVThongTin.SelectedItems.Count > 0)
            {
                ListViewItem lvI = lVThongTin.SelectedItems[0];
                txtSTK.Text = lvI.SubItems[1].Text;
                txtTenKH.Text = lvI.SubItems[2].Text;
                txtDiaChi.Text = lvI.SubItems[3].Text;
                txtSoTien.Text = lvI.SubItems[4].Text;
            }

        }

        private void Bai08_Resize(object sender, EventArgs e)
        {
            pnlMain.Location = new Point((ClientSize.Width - pnlMain.Width) / 2, (ClientSize.Height - pnlMain.Height) / 2);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Thoát",
                                                   "Bạn có chắc muốn thoát",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
