namespace BTL_LTTQNe
{
    partial class Form1
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
            this.btnTKNL = new System.Windows.Forms.Button();
            this.btnTKMA = new System.Windows.Forms.Button();
            this.btnQLMA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTKNL
            // 
            this.btnTKNL.Location = new System.Drawing.Point(358, 111);
            this.btnTKNL.Name = "btnTKNL";
            this.btnTKNL.Size = new System.Drawing.Size(117, 32);
            this.btnTKNL.TabIndex = 0;
            this.btnTKNL.Text = "Tìm kiếm nguyên liệu";
            this.btnTKNL.UseVisualStyleBackColor = true;
            this.btnTKNL.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTKMA
            // 
            this.btnTKMA.Location = new System.Drawing.Point(550, 111);
            this.btnTKMA.Name = "btnTKMA";
            this.btnTKMA.Size = new System.Drawing.Size(120, 32);
            this.btnTKMA.TabIndex = 1;
            this.btnTKMA.Text = "Tìm kiếm món ăn";
            this.btnTKMA.UseVisualStyleBackColor = true;
            this.btnTKMA.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnQLMA
            // 
            this.btnQLMA.Location = new System.Drawing.Point(158, 111);
            this.btnQLMA.Name = "btnQLMA";
            this.btnQLMA.Size = new System.Drawing.Size(117, 32);
            this.btnQLMA.TabIndex = 2;
            this.btnQLMA.Text = "Thêm món ăn";
            this.btnQLMA.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 515);
            this.Controls.Add(this.btnQLMA);
            this.Controls.Add(this.btnTKMA);
            this.Controls.Add(this.btnTKNL);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button btnTKNL;
        private System.Windows.Forms.Button btnTKMA;
        private System.Windows.Forms.Button btnQLMA;
    }
}

