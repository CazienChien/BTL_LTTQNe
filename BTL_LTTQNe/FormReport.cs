using BTL_LTTQ_Ne;
using Microsoft.Reporting.WinForms;
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
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }
        public FormReport(List<BaocaoTongtien> baocaoTongtiens)
        {
            InitializeComponent();

            // Sử dụng danh sách đã truyền vào thay vì tạo một đối tượng mới
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", baocaoTongtiens));
            this.reportViewer1.RefreshReport();
        }

        public FormReport(int i)
        {
            InitializeComponent();
            if(i==1) {
             
            }

        }

        private void FormReport_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
