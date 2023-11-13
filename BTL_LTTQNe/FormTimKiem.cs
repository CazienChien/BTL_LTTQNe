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
            dataGridView1.DataSource = process.DocBang("select * from NguyenLieu");  

        }

		private void FormTimKiem_Load(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
            dataGridView1.Columns[0].HeaderText = "Mã nguyên liệu";
            dataGridView1.Columns[1].HeaderText = "Tên guyên liệu";
            dataGridView1.Columns[2].HeaderText = "Đơn vị tính";
			dataGridView1.Columns[3].HeaderText = "Số lg";
            dataGridView1.Columns[4].HeaderText = "Đơn giá nhập";
            dataGridView1.Columns[5].HeaderText = "Đơn giá bán";
            dataGridView1.Columns[6].HeaderText = "Công dụng";
            dataGridView1.Columns[7].HeaderText = "Yêu cầu";
            dataGridView1.Columns[8].HeaderText = "Chống chỉ định";
            
		}

        private void button1_Click(object sender, EventArgs e)
        {
		}

		private void button3_Click(object sender, EventArgs e)
		{
			dataGridView1.DataSource = process.DocBang("select * from NguyenLieu where ma_nguyen_lieu = '" + textBox1.Text + "'");

		}



		private void button4_Click(object sender, EventArgs e)
		{
            reset();
		}

        private void reset()
        {
            textBox1.Text = "";
			textBox2.Text = "";
			comboBox1.Text = "";
        }


	}
}
