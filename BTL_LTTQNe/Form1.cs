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
    public partial class Form1 : Form
    {
        private Button currentButton;
        public Form1()
        {
            InitializeComponent();
        }

        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    currentButton.BackColor = Color.FromArgb(37, 36, 81);
                    // mau nut khi nhan
                    currentButton.ForeColor = Color.White;
                    currentButton.TextAlign = ContentAlignment.MiddleCenter;
                    currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                    currentButton.ImageAlign = ContentAlignment.MiddleRight;
                    currentButton.Padding = new Padding(40, 0, 0, 0);
                }
            }
        }

		private void button1_Click(object sender, EventArgs e)
		{
			FormTimKiem otherForm = new FormTimKiem();
			otherForm.Show();
			this.Hide();
		}

        private void button2_Click(object sender, EventArgs e)
        {
            FormTimkiemMonAn otherForm = new FormTimkiemMonAn();
            otherForm.Show();
            this.Hide();
        }
    }
}
