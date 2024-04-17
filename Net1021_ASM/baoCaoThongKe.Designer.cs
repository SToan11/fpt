namespace Net1021_ASM
{
    partial class baoCaoThongKe
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_baocao = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_timkiem = new System.Windows.Forms.ComboBox();
            this.btn_tim = new System.Windows.Forms.Button();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_baocao)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_baocao);
            this.groupBox1.Location = new System.Drawing.Point(56, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1368, 581);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách ";
            // 
            // dgv_baocao
            // 
            this.dgv_baocao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_baocao.Location = new System.Drawing.Point(28, 54);
            this.dgv_baocao.Name = "dgv_baocao";
            this.dgv_baocao.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_baocao.RowHeadersWidth = 102;
            this.dgv_baocao.RowTemplate.Height = 40;
            this.dgv_baocao.Size = new System.Drawing.Size(1313, 493);
            this.dgv_baocao.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(682, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 46);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tìm kiếm";
            // 
            // cbo_timkiem
            // 
            this.cbo_timkiem.FormattingEnabled = true;
            this.cbo_timkiem.Items.AddRange(new object[] {
            "Số lượng sách",
            "Số lượng mượn",
            "Thể loại",
            "Sách"});
            this.cbo_timkiem.Location = new System.Drawing.Point(422, 143);
            this.cbo_timkiem.Name = "cbo_timkiem";
            this.cbo_timkiem.Size = new System.Drawing.Size(319, 39);
            this.cbo_timkiem.TabIndex = 23;
            // 
            // btn_tim
            // 
            this.btn_tim.Location = new System.Drawing.Point(814, 131);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(121, 61);
            this.btn_tim.TabIndex = 24;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.Location = new System.Drawing.Point(1160, 131);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(237, 61);
            this.btn_lammoi.TabIndex = 25;
            this.btn_lammoi.Text = "Làm mới";
            this.btn_lammoi.UseVisualStyleBackColor = true;
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // baoCaoThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1606, 993);
            this.Controls.Add(this.btn_lammoi);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.cbo_timkiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "baoCaoThongKe";
            this.Text = "baoCaoThongKe";
            this.Load += new System.EventHandler(this.baoCaoThongKe_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_baocao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_baocao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_timkiem;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.Button btn_lammoi;
    }
}