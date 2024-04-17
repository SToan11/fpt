namespace Net1021_ASM
{
    partial class quenMK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quenMK));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picture_quenmk = new System.Windows.Forms.PictureBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_laylaimk = new System.Windows.Forms.Button();
            this.lbl_mk = new System.Windows.Forms.Label();
            this.lbl_taikhoandk = new System.Windows.Forms.Label();
            this.txt_emaildk = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_quenmk)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picture_quenmk);
            this.groupBox1.Controls.Add(this.btn_thoat);
            this.groupBox1.Controls.Add(this.btn_laylaimk);
            this.groupBox1.Controls.Add(this.lbl_mk);
            this.groupBox1.Controls.Add(this.lbl_taikhoandk);
            this.groupBox1.Controls.Add(this.txt_emaildk);
            this.groupBox1.Location = new System.Drawing.Point(84, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(807, 805);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quên mật khẩu";
            // 
            // picture_quenmk
            // 
            this.picture_quenmk.Image = ((System.Drawing.Image)(resources.GetObject("picture_quenmk.Image")));
            this.picture_quenmk.Location = new System.Drawing.Point(212, 61);
            this.picture_quenmk.Name = "picture_quenmk";
            this.picture_quenmk.Size = new System.Drawing.Size(328, 338);
            this.picture_quenmk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_quenmk.TabIndex = 9;
            this.picture_quenmk.TabStop = false;
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_thoat.Location = new System.Drawing.Point(457, 597);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(222, 76);
            this.btn_thoat.TabIndex = 8;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_laylaimk
            // 
            this.btn_laylaimk.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_laylaimk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_laylaimk.Location = new System.Drawing.Point(72, 597);
            this.btn_laylaimk.Name = "btn_laylaimk";
            this.btn_laylaimk.Size = new System.Drawing.Size(284, 76);
            this.btn_laylaimk.TabIndex = 7;
            this.btn_laylaimk.Text = "Lấy lại mật khẩu";
            this.btn_laylaimk.UseVisualStyleBackColor = false;
            this.btn_laylaimk.Click += new System.EventHandler(this.btn_laylaimk_Click);
            // 
            // lbl_mk
            // 
            this.lbl_mk.AutoSize = true;
            this.lbl_mk.Location = new System.Drawing.Point(34, 503);
            this.lbl_mk.Name = "lbl_mk";
            this.lbl_mk.Size = new System.Drawing.Size(130, 32);
            this.lbl_mk.TabIndex = 4;
            this.lbl_mk.Text = "Mật khẩu";
            // 
            // lbl_taikhoandk
            // 
            this.lbl_taikhoandk.AutoSize = true;
            this.lbl_taikhoandk.Location = new System.Drawing.Point(34, 431);
            this.lbl_taikhoandk.Name = "lbl_taikhoandk";
            this.lbl_taikhoandk.Size = new System.Drawing.Size(238, 32);
            this.lbl_taikhoandk.TabIndex = 3;
            this.lbl_taikhoandk.Text = "Tài khoản đăng kí";
            // 
            // txt_emaildk
            // 
            this.txt_emaildk.Location = new System.Drawing.Point(364, 428);
            this.txt_emaildk.Name = "txt_emaildk";
            this.txt_emaildk.Size = new System.Drawing.Size(397, 38);
            this.txt_emaildk.TabIndex = 1;
            // 
            // quenMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 979);
            this.Controls.Add(this.groupBox1);
            this.Name = "quenMK";
            this.Text = "Quên mật khẩu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_quenmk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_laylaimk;
        private System.Windows.Forms.Label lbl_mk;
        private System.Windows.Forms.Label lbl_taikhoandk;
        private System.Windows.Forms.TextBox txt_emaildk;
        private System.Windows.Forms.PictureBox picture_quenmk;
    }
}