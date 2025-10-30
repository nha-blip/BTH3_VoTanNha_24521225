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
    public partial class Bai01 : Form
    {

        public Bai01()
        {
            InitializeComponent();
        }
        private void Bai01_Load(object sender, EventArgs e)
        {
            lbl_Hienthi.Text += "Form vừa được Load\n";
        }

        private void Bai1_Activated(object sender, EventArgs e)
        {
            lbl_Hienthi.Text += "Form vừa được kích hoạt\n";
        }

        private void Bai1_Shown(object sender, EventArgs e)
        {
            lbl_Hienthi.Text += "Form vừa được hiện thị\n";
        }
        private void FormCon_FormClosed(object? sender, FormClosedEventArgs e)
        {
            lbl_Hienthi.Text += "Form con vừa được đóng\n";
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            Form form_Con = new Form();
            lbl_Hienthi.Text += "Form con vừa được sinh ra\n";
            form_Con.FormClosed += new FormClosedEventHandler(FormCon_FormClosed);
            form_Con.Show();
        }

        private void Bai1_Closing(object sender, FormClosingEventArgs e)
        {   
            lbl_Hienthi.Text += "Form đang đóng\n";
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát",
                                                   "Thoát",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                
            }  
            else
            {
                e.Cancel = true; 
                lbl_Hienthi.Text += "Form đã hủy đóng";
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
