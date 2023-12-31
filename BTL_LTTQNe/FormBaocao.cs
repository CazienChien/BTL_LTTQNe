﻿using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;


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
            for (int i = 1; i <= 4; i++)
            {
                cbQuyPDB.Items.Add(i.ToString());
            }
            cbQuyPDB.Items.Add("");

            cbThangPDB.DataSource = process.DocBang("SELECT DISTINCT MONTH(ngay_dat) AS Thang FROM PhieuDatBan");
            cbThangPDB.DisplayMember = "Thang";

            cbNamPDB.DataSource = process.DocBang("SELECT DISTINCT YEAR(ngay_dat) AS Nam FROM PhieuDatBan");
            cbNamPDB.DisplayMember = "Nam"; 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            dgvThongKe.DataSource = process.DocBang("select * from MonAn");
            FormReportTTMonAn formReport = new FormReportTTMonAn();
            formReport.Show();
            this.Hide();
        }

        private void btnTHNX_Click(object sender, EventArgs e)
        {
            dgvThongKe.DataSource = process.DocBang("SELECT * FROM NguyenLieu WHERE MONTH(ngay_nhap) = MONTH(GETDATE()) AND YEAR(ngay_nhap) = YEAR(GETDATE()); ");
            FormReportNXNguyenLieu formReport = new FormReportNXNguyenLieu();
            formReport.Show();
            this.Hide();
        
        }

        private void btnTKPDB_Click(object sender, EventArgs e)
        {
            dgvThongKe.DataSource = process.DocBang("select * from PhieuDatBan");
            FormBaoCaoPDB formReport = new FormBaoCaoPDB();
            formReport.Show();
            this.Hide();
        }

        private void btnTongTienPDB_Click(object sender, EventArgs e)
        {
            List<BaocaoTongtien> list = new List<BaocaoTongtien>();
            string sql = "SELECT " +
                         "  MONTH(ngay_dat) AS Thang, " +
                         "  YEAR(ngay_dat) AS Nam, " +
                         "  SUM(tong_tien) AS TongTienTheoThang " +
                         "FROM " +
                         "  PhieuDatBan " +
                         "WHERE 1 = 1 "; // Thêm điều kiện mặc định để dễ dàng thêm điều kiện tiếp theo

            if (!string.IsNullOrEmpty(cbThangPDB.Text) && !string.IsNullOrEmpty(cbNamPDB.Text))
            {
                sql += " AND MONTH(ngay_dat) = '" + cbThangPDB.Text + "' AND YEAR(ngay_dat) = '" + cbNamPDB.Text + "' GROUP BY MONTH(ngay_dat), YEAR(ngay_dat)";
                dgvThongKe.DataSource = process.DocBang(sql);
                System.Data.DataTable dataTable = process.DocBang(sql);
                foreach (DataRow row in dataTable.Rows)
                {
                    list.Add(new BaocaoTongtien
                    {
                        Thang = Convert.ToInt32(row["Thang"]),
                        Nam = Convert.ToInt32(row["Nam"]),
                        TongTienTheoThang = Convert.ToDouble(row["TongTienTheoThang"]),
                    });
                }
                if (MessageBox.Show("Bạn có muốn xuất bao cao không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FormReport formReport = new FormReport(list);
                    formReport.Show();
                    this.Hide();

                }
            }
            string sql1 = "SELECT " +
                 "  YEAR(ngay_dat) AS Nam, " +
                 "  SUM(tong_tien) AS TongTienTheoNam " +
                 "FROM " +
                 "  PhieuDatBan " +
                 "WHERE 1 = 1 "; // Thêm điều kiện mặc định để dễ dàng thêm điều kiện tiếp theo

            if (!string.IsNullOrEmpty(cbNamPDB.Text))
            {
                sql1 += $" AND YEAR(ngay_dat) = '{cbNamPDB.Text}' GROUP BY YEAR(ngay_dat)";
                dgvThongKe.DataSource = process.DocBang(sql1);

                System.Data.DataTable dataTable = process.DocBang(sql1);
                foreach (DataRow row in dataTable.Rows)
                {
                    list.Add(new BaocaoTongtien
                    {
                        Nam = Convert.ToInt32(row["Nam"]),
                        TongTienTheoNam = Convert.ToDouble(row["TongTienTheoNam"]),
                    });
                }
                if (MessageBox.Show("Bạn có muốn xuất bao cao  không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FormReport formReport = new FormReport(list);
                    formReport.Show();
                    this.Hide();

                }
            }

            string sql2 = "SELECT " +
                          "  DATEPART(QUARTER, ngay_dat) AS Quy, " +
                          "  YEAR(ngay_dat) AS Nam, " +
                          "  SUM(tong_tien) AS TongTienTheoQuy " +
                          "FROM " +
                          "  PhieuDatBan " +
                          "WHERE 1 = 1 "; // Thêm điều kiện mặc định

            if (!string.IsNullOrEmpty(cbQuyPDB.Text) && !string.IsNullOrEmpty(cbNamPDB.Text))
            {
                sql2 += " AND DATEPART(QUARTER, ngay_dat) = '" + cbQuyPDB.Text + "' AND YEAR(ngay_dat) = '" + cbNamPDB.Text + "' GROUP BY " +
                        "  DATEPART(QUARTER, ngay_dat), YEAR(ngay_dat);";
                dgvThongKe.DataSource = process.DocBang(sql2);
                System.Data.DataTable dataTable = process.DocBang(sql2);
                foreach (DataRow row in dataTable.Rows)
                {
                    list.Add(new BaocaoTongtien
                    {
                        Quy = Convert.ToInt32(row["Quy"]),
                        TongTienTheoThang = Convert.ToDouble(row["TongTienTheoQuy"]),
                    });
                }

               
                if (MessageBox.Show("Bạn có muốn xuất bao cao  không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FormReport formReport = new FormReport(list);
                    formReport.Show();
                    this.Hide();

                }

            }
            else if(string.IsNullOrEmpty(cbNamPDB.Text) && string.IsNullOrEmpty(cbQuyPDB.Text) && string.IsNullOrEmpty(cbThangPDB.Text))
            {
                MessageBox.Show("Vui lòng chọn năm và quý hoặc năm và tháng hoặc chỉ năm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            export2Excel(dgvThongKe, @"E:\", "xuatfileExcel");

        }
        private void export2Excel(DataGridView g, string duongDan, string tenTap)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for (int i = 1; i < g.Columns.Count + 1; i++) { obj.Cells[1, i] = g.Columns[i - 1].HeaderText; }
            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null) { obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString(); }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongDan + tenTap + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }

    }

}
