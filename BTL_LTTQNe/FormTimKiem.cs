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


//-Form Tìm Kiếm:

//Tìm kiếm nguyên liệu theo tên, công dụng và chống chỉ định 
//Tìm kiếm món ăn theo loại, công dụng và tên món ăn

namespace BTL_LTTQNe
{
    public partial class FormTimKiem : Form
    {
        ProcessDatabase process = new ProcessDatabase();
        public FormTimKiem()
        {
            InitializeComponent();
            dataGridView1.DataSource = process.DocBang("select * from MonAn");  

        }

		private void FormTimKiem_Load(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
            dataGridView1.Columns[0].HeaderText = "Mã món ăn";
            dataGridView1.Columns[1].HeaderText = "Tên món ăn";
            dataGridView1.Columns[2].HeaderText = "Mã công dụng";
			dataGridView1.Columns[3].HeaderText = "mã loại món ăn";
            dataGridView1.Columns[4].HeaderText = "Cách làm";
            dataGridView1.Columns[5].HeaderText = "Yêu cầu";
            dataGridView1.Columns[6].HeaderText = "Đơn giá";

		}
        //tôi muốn tìm kiếm món ăn theo loại món ăn
        private void button1_Click(object sender, EventArgs e)
        {
			dataGridView1.DataSource = process.DocBang("select * from MonAn where MaLoaiMonAn = '" + textBox1.Text + "'");
		}



	}
}
