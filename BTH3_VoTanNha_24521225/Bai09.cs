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
    public partial class Bai09 : Form
    {
        public Bai09()
        {
            InitializeComponent();
        }
        public void btn_Left_Click(object sender, EventArgs e)
        {
            foreach (object item in lb_MonHoc.SelectedItems)
            {
                bool flag = false;
                foreach(object item2 in lb_ThamGia.Items)
                {
                    if (item == item2)
                        flag = true;
                    
                }
                if(!flag)   lb_ThamGia.Items.Add(item);
                
            }
        }
        public void btn_Right_Click(object sender, EventArgs e)
        {
            lb_ThamGia.Items.Clear();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_MSSV.Text == "" || txt_HoTen.Text == "" || (chB_female.Checked == false && chB_Male.Checked == false))
                MessageBox.Show("Hãy nhập đủ thông tin!");
            else
            {
                ListViewItem item = new ListViewItem("*");
                item.SubItems.Add(txt_MSSV.Text);
                item.SubItems.Add(txt_HoTen.Text);
                item.SubItems.Add(cbB_ChuyenNganh.Text);
                item.SubItems.Add(chB_female.Checked ? "Nữ" : "Nam");
                item.SubItems.Add(lb_ThamGia.Items.Count.ToString());
                for(int i=0;i<lv_QuanLy.Items.Count;i++)
                {
                    if (lv_QuanLy.Items[i].SubItems[1].Text == txt_MSSV.Text)
                    {
                        lv_QuanLy.Items[i].SubItems[5].Text =lb_ThamGia.Items.Count.ToString();
                        return;
                    }
                }
                lv_QuanLy.Items.Add(item);
                lb_ThamGia.Items.Clear();
            }
        }

        private void chB_female_CheckedChanged(object sender, EventArgs e)
        {
            if (chB_female.Checked == true)
                chB_Male.Checked = false;
        }

        private void chB_Male_CheckedChanged(object sender, EventArgs e)
        {
            if (chB_Male.Checked == true)
                chB_female.Checked = false;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            lb_MonHoc.SelectedItems.Clear();
        }
    }
}
