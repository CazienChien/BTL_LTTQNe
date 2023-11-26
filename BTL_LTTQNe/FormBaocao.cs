using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BTL_LTTQ_Ne;

namespace BTL_LTTQNe
{
    public partial class FormBaocao : Form
    {
        ProcessDatabase process = new ProcessDatabase();
        public FormBaocao()
        {
            InitializeComponent();
        }

        private void FormBaocao_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            dgvThongKe.DataSource = process.DocBang("select * from MonAn");
        }

        private void btnTHNX_Click(object sender, EventArgs e)
        {
            dgvThongKe.DataSource = process.DocBang("select * from ChiTietHoaDonNhap ");
        }
        
    }
    
}
