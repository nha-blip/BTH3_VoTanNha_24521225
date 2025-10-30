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

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtSTK.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("“Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].SubItems[1].Text == txtSTK.Text)
                    {
                        listView1.Items[i].SubItems[2].Text = textBox2.Text;
                        listView1.Items[i].SubItems[3].Text = textBox3.Text;
                        listView1.Items[i].SubItems[4].Text = (int.Parse(listView1.Items[i].SubItems[4].Text)+textBox4.Text).ToString();
                        MessageBox.Show("Cập nhật dữ liệu thành công!");
                        return;
                    }
                }
                int stt = listView1.Items.Count + 1;
                ListViewItem items = new ListViewItem(stt.ToString());
                items.SubItems.Add(txtSTK.Text);
                items.SubItems.Add(textBox2.Text);
                items.SubItems.Add(textBox3.Text);
                items.SubItems.Add(textBox4.Text);
                listView1.Items.Add(items);
                MessageBox.Show("Cập nhật dữ liệu thành công!");
            }
        }
        private void UpdateSTT()
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                listView1.Items[i].SubItems[0].Text = (i + 1).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa",
                                                 "Xóa",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Warning);
            if (result == DialogResult.No) return;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[1].Text == txtSTK.Text)
                {
                    listView1.Items[i].Remove();
                    UpdateSTT();
                    MessageBox.Show("Xóa tài khoản thành công");
                    return;
                }
            }
            MessageBox.Show("Không tìm thấy số tài khoản cần xóa");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem lvI = listView1.SelectedItems[0];
                txtSTK.Text = lvI.SubItems[1].Text;
                textBox2.Text=lvI.SubItems[2].Text;
                textBox3.Text=lvI.SubItems[3].Text;
                textBox4.Text=lvI.SubItems[4].Text;
            }
            
        }
    }
}
