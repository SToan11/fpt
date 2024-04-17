namespace Net1021_ASM
{
    partial class menuQuanLy
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuQuanLy));
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.lbl_menu = new System.Windows.Forms.Label();
            this.picture_menu = new System.Windows.Forms.PictureBox();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_qlsach = new System.Windows.Forms.Button();
            this.btn_qldocgia = new System.Windows.Forms.Button();
            this.btn_qlmuontra = new System.Windows.Forms.Button();
            this.btn_baocaoThongKe = new System.Windows.Forms.Button();
            this.btn_qlTK = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.slidebar_timer = new System.Windows.Forms.Timer(this.components);
            this.panel_body = new System.Windows.Forms.Panel();
            this.picture_body = new System.Windows.Forms.PictureBox();
            this.sidebar.SuspendLayout();
            this.panel_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_menu)).BeginInit();
            this.panel_body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_body)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.sidebar.Controls.Add(this.panel_menu);
            this.sidebar.Controls.Add(this.btn_home);
            this.sidebar.Controls.Add(this.btn_qlsach);
            this.sidebar.Controls.Add(this.btn_qldocgia);
            this.sidebar.Controls.Add(this.btn_qlmuontra);
            this.sidebar.Controls.Add(this.btn_baocaoThongKe);
            this.sidebar.Controls.Add(this.btn_qlTK);
            this.sidebar.Controls.Add(this.btn_thoat);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(480, 1110);
            this.sidebar.MinimumSize = new System.Drawing.Size(131, 1110);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(480, 1110);
            this.sidebar.TabIndex = 0;
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel_menu.Controls.Add(this.lbl_menu);
            this.panel_menu.Controls.Add(this.picture_menu);
            this.panel_menu.Location = new System.Drawing.Point(3, 3);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(477, 221);
            this.panel_menu.TabIndex = 1;
            // 
            // lbl_menu
            // 
            this.lbl_menu.AutoSize = true;
            this.lbl_menu.Font = new System.Drawing.Font("Segoe UI", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_menu.Location = new System.Drawing.Point(114, 75);
            this.lbl_menu.Name = "lbl_menu";
            this.lbl_menu.Size = new System.Drawing.Size(166, 71);
            this.lbl_menu.TabIndex = 1;
            this.lbl_menu.Text = "Menu";
            // 
            // picture_menu
            // 
            this.picture_menu.Image = ((System.Drawing.Image)(resources.GetObject("picture_menu.Image")));
            this.picture_menu.Location = new System.Drawing.Point(27, 75);
            this.picture_menu.Name = "picture_menu";
            this.picture_menu.Size = new System.Drawing.Size(69, 72);
            this.picture_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_menu.TabIndex = 0;
            this.picture_menu.TabStop = false;
            this.picture_menu.Click += new System.EventHandler(this.picture_menu_Click);
            // 
            // btn_home
            // 
            this.btn_home.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.Location = new System.Drawing.Point(3, 230);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(477, 84);
            this.btn_home.TabIndex = 7;
            this.btn_home.Text = "Home";
            this.btn_home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_qlsach
            // 
            this.btn_qlsach.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_qlsach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_qlsach.Location = new System.Drawing.Point(3, 320);
            this.btn_qlsach.Name = "btn_qlsach";
            this.btn_qlsach.Size = new System.Drawing.Size(477, 84);
            this.btn_qlsach.TabIndex = 1;
            this.btn_qlsach.Text = "Quản lý sách";
            this.btn_qlsach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_qlsach.UseVisualStyleBackColor = true;
            this.btn_qlsach.Click += new System.EventHandler(this.btn_qlsach_Click);
            // 
            // btn_qldocgia
            // 
            this.btn_qldocgia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_qldocgia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_qldocgia.Location = new System.Drawing.Point(3, 410);
            this.btn_qldocgia.Name = "btn_qldocgia";
            this.btn_qldocgia.Size = new System.Drawing.Size(477, 84);
            this.btn_qldocgia.TabIndex = 2;
            this.btn_qldocgia.Text = "Quản lý độc giả";
            this.btn_qldocgia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_qldocgia.UseVisualStyleBackColor = true;
            this.btn_qldocgia.Click += new System.EventHandler(this.btn_qldocgia_Click);
            // 
            // btn_qlmuontra
            // 
            this.btn_qlmuontra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_qlmuontra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_qlmuontra.Location = new System.Drawing.Point(3, 500);
            this.btn_qlmuontra.Name = "btn_qlmuontra";
            this.btn_qlmuontra.Size = new System.Drawing.Size(477, 84);
            this.btn_qlmuontra.TabIndex = 3;
            this.btn_qlmuontra.Text = "Quản lý mượn";
            this.btn_qlmuontra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_qlmuontra.UseVisualStyleBackColor = true;
            this.btn_qlmuontra.Click += new System.EventHandler(this.btn_qlmuontra_Click);
            // 
            // btn_baocaoThongKe
            // 
            this.btn_baocaoThongKe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_baocaoThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_baocaoThongKe.Location = new System.Drawing.Point(3, 590);
            this.btn_baocaoThongKe.Name = "btn_baocaoThongKe";
            this.btn_baocaoThongKe.Size = new System.Drawing.Size(477, 84);
            this.btn_baocaoThongKe.TabIndex = 5;
            this.btn_baocaoThongKe.Text = "Báo cáo thống kê";
            this.btn_baocaoThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_baocaoThongKe.UseVisualStyleBackColor = true;
            this.btn_baocaoThongKe.Click += new System.EventHandler(this.btn_qlTK_Click);
            // 
            // btn_qlTK
            // 
            this.btn_qlTK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_qlTK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_qlTK.Location = new System.Drawing.Point(3, 680);
            this.btn_qlTK.Name = "btn_qlTK";
            this.btn_qlTK.Size = new System.Drawing.Size(477, 84);
            this.btn_qlTK.TabIndex = 8;
            this.btn_qlTK.Text = "Quản lý tài khoản";
            this.btn_qlTK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_qlTK.UseVisualStyleBackColor = true;
            this.btn_qlTK.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.Location = new System.Drawing.Point(3, 770);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(477, 84);
            this.btn_thoat.TabIndex = 6;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // slidebar_timer
            // 
            this.slidebar_timer.Tick += new System.EventHandler(this.slidebarTimer_tick);
            // 
            // panel_body
            // 
            this.panel_body.Controls.Add(this.picture_body);
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(480, 0);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1386, 1110);
            this.panel_body.TabIndex = 1;
            // 
            // picture_body
            // 
            this.picture_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture_body.Image = ((System.Drawing.Image)(resources.GetObject("picture_body.Image")));
            this.picture_body.Location = new System.Drawing.Point(0, 0);
            this.picture_body.Name = "picture_body";
            this.picture_body.Size = new System.Drawing.Size(1386, 1110);
            this.picture_body.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_body.TabIndex = 0;
            this.picture_body.TabStop = false;
            // 
            // menuQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1866, 1110);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.sidebar);
            this.Name = "menuQuanLy";
            this.Text = "Menu quản lý";
            this.Load += new System.EventHandler(this.menuQuanLy_Load);
            this.sidebar.ResumeLayout(false);
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_menu)).EndInit();
            this.panel_body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_body)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Button btn_qlsach;
        private System.Windows.Forms.Button btn_qldocgia;
        private System.Windows.Forms.Button btn_qlmuontra;
        private System.Windows.Forms.Button btn_baocaoThongKe;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Label lbl_menu;
        private System.Windows.Forms.PictureBox picture_menu;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Timer slidebar_timer;
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.PictureBox picture_body;
        private System.Windows.Forms.Button btn_qlTK;
    }
}