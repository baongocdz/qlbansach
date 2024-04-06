using LAB_2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_2
{
    public partial class cau2 : Form
    {
        private List<GiaoVien> gv;
        private List<Lop> lop;
        private int dem;
        public cau2()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            string giaovien = listBox1.SelectedItem.ToString();
            string lophoc = listBox2.SelectedItem.ToString();
            int dem = 0;
            
            foreach (var item in listBox3.Items)
            {
                string[] check = item.ToString().Split('.');
                if (check[0] == giaovien)
                {
                    if (check[2] != lophoc) 
                    {
                        dem++;
                    }
                    else
                    {
                        MessageBox.Show("Giáo viên này đã chủ nhiệm lớp này.");
                        return;
                    }
                    
                }
            }
           
            if (dem < 2)
            {
                listBox3.Items.Add(giaovien + ". chủ nhiệm lớp ." + lophoc);
            }
            else
            {
                MessageBox.Show("Giáo viên đã chủ nhiệm đủ lớp.");
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
