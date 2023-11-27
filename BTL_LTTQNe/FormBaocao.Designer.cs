namespace BTL_LTTQNe
{
    partial class FormBaocao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.btnTHNX = new System.Windows.Forms.Button();
            this.btnTKTTMA = new System.Windows.Forms.Button();
            this.btnTKPDB = new System.Windows.Forms.Button();
            this.btnTongTienPDB = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvThongKe);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 483);
            this.panel1.TabIndex = 0;
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Location = new System.Drawing.Point(0, 2);
            this.dgvThongKe.Margin = new System.Windows.Forms.Padding(2);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.RowHeadersWidth = 51;
            this.dgvThongKe.RowTemplate.Height = 24;
            this.dgvThongKe.Size = new System.Drawing.Size(530, 481);
            this.dgvThongKe.TabIndex = 0;
            this.dgvThongKe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnTHNX
            // 
            this.btnTHNX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTHNX.Location = new System.Drawing.Point(553, 332);
            this.btnTHNX.Margin = new System.Windows.Forms.Padding(2);
            this.btnTHNX.Name = "btnTHNX";
            this.btnTHNX.Size = new System.Drawing.Size(107, 80);
            this.btnTHNX.TabIndex = 5;
            this.btnTHNX.Text = "Thống kê nhập xuất nguyên liệu";
            this.btnTHNX.UseVisualStyleBackColor = true;
            this.btnTHNX.Click += new System.EventHandler(this.btnTHNX_Click);
            // 
            // btnTKTTMA
            // 
            this.btnTKTTMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTKTTMA.Location = new System.Drawing.Point(554, 113);
            this.btnTKTTMA.Margin = new System.Windows.Forms.Padding(2);
            this.btnTKTTMA.Name = "btnTKTTMA";
            this.btnTKTTMA.Size = new System.Drawing.Size(107, 67);
            this.btnTKTTMA.TabIndex = 4;
            this.btnTKTTMA.Text = "Thống kê thông tin món ăn";
            this.btnTKTTMA.UseVisualStyleBackColor = true;
            this.btnTKTTMA.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnTKPDB
            // 
            this.btnTKPDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTKPDB.Location = new System.Drawing.Point(554, 223);
            this.btnTKPDB.Margin = new System.Windows.Forms.Padding(2);
            this.btnTKPDB.Name = "btnTKPDB";
            this.btnTKPDB.Size = new System.Drawing.Size(107, 80);
            this.btnTKPDB.TabIndex = 6;
            this.btnTKPDB.Text = "Thống kê phiếu đặt bàn";
            this.btnTKPDB.UseVisualStyleBackColor = true;
            this.btnTKPDB.Click += new System.EventHandler(this.btnTKPDB_Click);
            // 
            // btnTongTienPDB
            // 
            this.btnTongTienPDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTongTienPDB.Location = new System.Drawing.Point(554, 2);
            this.btnTongTienPDB.Margin = new System.Windows.Forms.Padding(2);
            this.btnTongTienPDB.Name = "btnTongTienPDB";
            this.btnTongTienPDB.Size = new System.Drawing.Size(107, 80);
            this.btnTongTienPDB.TabIndex = 7;
            this.btnTongTienPDB.Text = "Thống kê tổng tiền phiếu đặt bàn";
            this.btnTongTienPDB.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(599, 440);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(61, 20);
            this.textBox1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(551, 443);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tháng:";
            // 
            // FormBaocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 483);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnTongTienPDB);
            this.Controls.Add(this.btnTKPDB);
            this.Controls.Add(this.btnTHNX);
            this.Controls.Add(this.btnTKTTMA);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormBaocao";
            this.Text = "FormBaocao";
            this.Load += new System.EventHandler(this.FormBaocao_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.Button btnTHNX;
        private System.Windows.Forms.Button btnTKTTMA;
        private System.Windows.Forms.Button btnTKPDB;
        private System.Windows.Forms.Button btnTongTienPDB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}