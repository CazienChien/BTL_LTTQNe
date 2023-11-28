using BTL_LTTQ_Ne;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_LTTQNe
{
    public partial class ChiTietPhieuDatBan : Form
    {
        ProcessDatabase processssData = new ProcessDatabase();

        public ChiTietPhieuDatBan()
        {
            InitializeComponent();

        }
        public void LoadDataGridView2()
        {
            dataGridView2.DataSource = processssData.DocBang("select * from ChiTietPhieuDatBan ");
        }

        private void ChiTietPhieuDatBan_Load(object sender, EventArgs e)
        {
            LoadDataGridView2();
        }

        private void btnThem1_Click(object sender, EventArgs e)
        {
            string sql1 = "INSERT INTO ChiTietPhieuDatBan (ma_phieu, ma_mon_an, ma_loai, so_luong, giam_gia, thanh_tien) VALUES"
              + "(N'" + txtMaPhieu.Text + "'," +
                 "N'" + txtMaMonAn.Text + "'," +
                 "N'" + txtMaLoai.Text + "'," +
                 "N'" + txtSoLuong.Text + "'," +
                 "N'" + txtGiamGia.Text + "'," +
                 "N'" + txtThanhTien.Text + "')";
            processssData.RunSQL(sql1);
            LoadDataGridView2();
        }

        private void btnQuayLai1_Click(object sender, EventArgs e)
        {
            Form1 otherForm = new Form1();
            otherForm.Show();
            this.Hide();
        }
        
    }
}
