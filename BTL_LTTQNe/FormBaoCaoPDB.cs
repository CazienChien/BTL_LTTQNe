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
    public partial class FormBaoCaoPDB : Form
    {
        public FormBaoCaoPDB()
        {
            InitializeComponent();
            this.reportViewer1.LocalReport.DataSources.Clear();

            ProcessDatabase pd = new ProcessDatabase();

            reportViewer1.LocalReport.ReportEmbeddedResource =

            "BTL_LTTQNe.phieudatbanRP.rdlc";

            ReportDataSource rpd = new ReportDataSource();

            rpd.Name = "PDB";

            rpd.Value = pd.DocBang("select * from PhieuDatBan");

            reportViewer1.LocalReport.DataSources.Add(rpd);

            this.reportViewer1.RefreshReport();
        }

        private void FormBaoCaoPDB_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
