namespace WinFormsApp2
{
    partial class formsoluoc
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formsoluoc));
            lbhoten = new Label();
            tieude = new Label();
            lbdiachi = new Label();
            lbtuoi = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tbhoten = new TextBox();
            tbdiachi = new TextBox();
            dtnthangnsinh = new DateTimePicker();
            lbsdt = new Label();
            tbsdt = new TextBox();
            lbxeploai = new Label();
            nftyanh = new NotifyIcon(components);
            imageList1 = new ImageList(components);
            pbanh = new PictureBox();
            CBxeploai = new ComboBox();
            btthemanh = new Button();
            btxoaanh = new Button();
            label1 = new Label();
            btcapnhat = new Button();
            btthoat = new Button();
            gbsoluoc = new GroupBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lbghichu = new Label();
            tbghichu = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbanh).BeginInit();
            SuspendLayout();
            // 
            // lbhoten
            // 
            lbhoten.AutoSize = true;
            lbhoten.BackColor = Color.Transparent;
            lbhoten.BorderStyle = BorderStyle.Fixed3D;
            lbhoten.ForeColor = Color.Thistle;
            lbhoten.Location = new Point(12, 75);
            lbhoten.Name = "lbhoten";
            lbhoten.Size = new Size(64, 17);
            lbhoten.TabIndex = 0;
            lbhoten.Text = "Họ và Tên:";
            // 
            // tieude
            // 
            tieude.AutoSize = true;
            tieude.BackColor = Color.Transparent;
            tieude.BorderStyle = BorderStyle.FixedSingle;
            tieude.FlatStyle = FlatStyle.Flat;
            tieude.Font = new Font("Verdana", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            tieude.ForeColor = Color.Thistle;
            tieude.Location = new Point(322, 9);
            tieude.Name = "tieude";
            tieude.Size = new Size(329, 37);
            tieude.TabIndex = 1;
            tieude.Text = "Sơ Lược Về Sinh Viên";
            tieude.Click += tieude_Click;
            // 
            // lbdiachi
            // 
            lbdiachi.AutoSize = true;
            lbdiachi.BackColor = Color.Transparent;
            lbdiachi.BorderStyle = BorderStyle.Fixed3D;
            lbdiachi.ForeColor = Color.Thistle;
            lbdiachi.Location = new Point(12, 141);
            lbdiachi.Name = "lbdiachi";
            lbdiachi.Size = new Size(51, 17);
            lbdiachi.TabIndex = 2;
            lbdiachi.Text = "Địa chỉ :";
            lbdiachi.TextAlign = ContentAlignment.MiddleCenter;
            lbdiachi.Click += label2_Click;
            // 
            // lbtuoi
            // 
            lbtuoi.AutoSize = true;
            lbtuoi.BackColor = Color.Transparent;
            lbtuoi.BorderStyle = BorderStyle.Fixed3D;
            lbtuoi.ForeColor = Color.Thistle;
            lbtuoi.Location = new Point(12, 108);
            lbtuoi.Name = "lbtuoi";
            lbtuoi.Size = new Size(128, 17);
            lbtuoi.TabIndex = 3;
            lbtuoi.Text = "Ngày Tháng Năm Sinh";
            lbtuoi.Click += lbtuoi_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // tbhoten
            // 
            tbhoten.BackColor = Color.AliceBlue;
            tbhoten.ForeColor = Color.Thistle;
            tbhoten.Location = new Point(195, 75);
            tbhoten.Name = "tbhoten";
            tbhoten.Size = new Size(496, 23);
            tbhoten.TabIndex = 6;
            tbhoten.TextChanged += textBox1_TextChanged;
            // 
            // tbdiachi
            // 
            tbdiachi.BackColor = Color.AliceBlue;
            tbdiachi.Location = new Point(195, 141);
            tbdiachi.Name = "tbdiachi";
            tbdiachi.Size = new Size(496, 23);
            tbdiachi.TabIndex = 8;
            // 
            // dtnthangnsinh
            // 
            dtnthangnsinh.CalendarForeColor = Color.AliceBlue;
            dtnthangnsinh.CalendarMonthBackground = Color.AliceBlue;
            dtnthangnsinh.CalendarTitleBackColor = Color.AliceBlue;
            dtnthangnsinh.CalendarTitleForeColor = Color.AliceBlue;
            dtnthangnsinh.CalendarTrailingForeColor = Color.AliceBlue;
            dtnthangnsinh.Format = DateTimePickerFormat.Custom;
            dtnthangnsinh.Location = new Point(195, 110);
            dtnthangnsinh.MaxDate = new DateTime(2069, 12, 31, 0, 0, 0, 0);
            dtnthangnsinh.Name = "dtnthangnsinh";
            dtnthangnsinh.Size = new Size(496, 23);
            dtnthangnsinh.TabIndex = 9;
            dtnthangnsinh.Value = new DateTime(2003, 9, 2, 0, 0, 0, 0);
            dtnthangnsinh.ValueChanged += dtnthangnsinh_ValueChanged;
            // 
            // lbsdt
            // 
            lbsdt.AutoSize = true;
            lbsdt.BackColor = Color.Transparent;
            lbsdt.BorderStyle = BorderStyle.Fixed3D;
            lbsdt.ForeColor = Color.Thistle;
            lbsdt.Location = new Point(12, 178);
            lbsdt.Name = "lbsdt";
            lbsdt.Size = new Size(78, 17);
            lbsdt.TabIndex = 10;
            lbsdt.Text = "Số điện thoại";
            lbsdt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbsdt
            // 
            tbsdt.BackColor = Color.AliceBlue;
            tbsdt.Location = new Point(195, 178);
            tbsdt.Name = "tbsdt";
            tbsdt.Size = new Size(496, 23);
            tbsdt.TabIndex = 11;
            // 
            // lbxeploai
            // 
            lbxeploai.AutoSize = true;
            lbxeploai.BackColor = Color.Transparent;
            lbxeploai.BorderStyle = BorderStyle.Fixed3D;
            lbxeploai.ForeColor = Color.Thistle;
            lbxeploai.Location = new Point(13, 218);
            lbxeploai.Name = "lbxeploai";
            lbxeploai.Size = new Size(51, 17);
            lbxeploai.TabIndex = 12;
            lbxeploai.Text = "Xếp loại";
            lbxeploai.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nftyanh
            // 
            nftyanh.Text = "Ảnh 3x4";
            nftyanh.Visible = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // pbanh
            // 
            pbanh.BackColor = Color.Transparent;
            pbanh.BackgroundImageLayout = ImageLayout.Stretch;
            pbanh.Location = new Point(754, 75);
            pbanh.Name = "pbanh";
            pbanh.Size = new Size(187, 205);
            pbanh.SizeMode = PictureBoxSizeMode.StretchImage;
            pbanh.TabIndex = 16;
            pbanh.TabStop = false;
            pbanh.UseWaitCursor = true;
            pbanh.Click += pictureBox1_Click;
            // 
            // CBxeploai
            // 
            CBxeploai.BackColor = Color.AliceBlue;
            CBxeploai.FormattingEnabled = true;
            CBxeploai.Items.AddRange(new object[] { "Giỏi", "Khá", "Trung Bình", "Ngu" });
            CBxeploai.Location = new Point(195, 218);
            CBxeploai.Name = "CBxeploai";
            CBxeploai.Size = new Size(496, 23);
            CBxeploai.TabIndex = 17;
            // 
            // btthemanh
            // 
            btthemanh.BackColor = Color.Transparent;
            btthemanh.BackgroundImageLayout = ImageLayout.Center;
            btthemanh.FlatStyle = FlatStyle.Flat;
            btthemanh.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btthemanh.ForeColor = Color.Transparent;
            btthemanh.ImageKey = "(none)";
            btthemanh.Location = new Point(754, 316);
            btthemanh.Name = "btthemanh";
            btthemanh.Size = new Size(75, 23);
            btthemanh.TabIndex = 18;
            btthemanh.Text = "Thêm ảnh";
            btthemanh.UseVisualStyleBackColor = false;
            btthemanh.Click += btthemanh_Click;
            // 
            // btxoaanh
            // 
            btxoaanh.BackColor = Color.Transparent;
            btxoaanh.BackgroundImageLayout = ImageLayout.Center;
            btxoaanh.FlatStyle = FlatStyle.Flat;
            btxoaanh.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btxoaanh.ForeColor = Color.Transparent;
            btxoaanh.ImageKey = "(none)";
            btxoaanh.Location = new Point(866, 316);
            btxoaanh.Name = "btxoaanh";
            btxoaanh.RightToLeft = RightToLeft.Yes;
            btxoaanh.Size = new Size(75, 23);
            btxoaanh.TabIndex = 19;
            btxoaanh.Text = "Xoá ảnh";
            btxoaanh.UseVisualStyleBackColor = false;
            btxoaanh.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.FlatStyle = FlatStyle.Popup;
            label1.ForeColor = Color.Thistle;
            label1.Location = new Point(12, 300);
            label1.Name = "label1";
            label1.Size = new Size(113, 17);
            label1.TabIndex = 21;
            label1.Text = "Sơ lược về sinh viên";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // btcapnhat
            // 
            btcapnhat.BackColor = Color.Transparent;
            btcapnhat.BackgroundImageLayout = ImageLayout.Center;
            btcapnhat.FlatStyle = FlatStyle.Flat;
            btcapnhat.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btcapnhat.ForeColor = Color.Transparent;
            btcapnhat.ImageKey = "(none)";
            btcapnhat.Location = new Point(755, 345);
            btcapnhat.Name = "btcapnhat";
            btcapnhat.Size = new Size(186, 23);
            btcapnhat.TabIndex = 22;
            btcapnhat.Text = "Cập nhập thông tin";
            btcapnhat.UseVisualStyleBackColor = false;
            btcapnhat.Click += btcapnhat_Click;
            // 
            // btthoat
            // 
            btthoat.BackColor = Color.Transparent;
            btthoat.BackgroundImageLayout = ImageLayout.Center;
            btthoat.DialogResult = DialogResult.Cancel;
            btthoat.FlatStyle = FlatStyle.Flat;
            btthoat.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btthoat.ForeColor = Color.Transparent;
            btthoat.ImageKey = "(none)";
            btthoat.Location = new Point(755, 377);
            btthoat.Name = "btthoat";
            btthoat.Size = new Size(186, 23);
            btthoat.TabIndex = 23;
            btthoat.Text = "Thoát";
            btthoat.UseVisualStyleBackColor = false;
            btthoat.Click += btthoat_Click;
            // 
            // gbsoluoc
            // 
            gbsoluoc.BackColor = Color.Transparent;
            gbsoluoc.ForeColor = Color.Thistle;
            gbsoluoc.Location = new Point(195, 298);
            gbsoluoc.Name = "gbsoluoc";
            gbsoluoc.Size = new Size(496, 129);
            gbsoluoc.TabIndex = 24;
            gbsoluoc.TabStop = false;
            gbsoluoc.Enter += gbsoluoc_Enter;
            // 
            // lbghichu
            // 
            lbghichu.AutoSize = true;
            lbghichu.BackColor = Color.Transparent;
            lbghichu.BorderStyle = BorderStyle.Fixed3D;
            lbghichu.ForeColor = Color.Thistle;
            lbghichu.Location = new Point(13, 257);
            lbghichu.Name = "lbghichu";
            lbghichu.Size = new Size(52, 17);
            lbghichu.TabIndex = 25;
            lbghichu.Text = "Ghi Chú";
            lbghichu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbghichu
            // 
            tbghichu.BackColor = Color.AliceBlue;
            tbghichu.Location = new Point(195, 257);
            tbghichu.Name = "tbghichu";
            tbghichu.Size = new Size(496, 23);
            tbghichu.TabIndex = 26;
            // 
            // formsoluoc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ButtonFace;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(960, 725);
            Controls.Add(tbghichu);
            Controls.Add(lbghichu);
            Controls.Add(gbsoluoc);
            Controls.Add(btthoat);
            Controls.Add(btcapnhat);
            Controls.Add(label1);
            Controls.Add(btxoaanh);
            Controls.Add(btthemanh);
            Controls.Add(CBxeploai);
            Controls.Add(pbanh);
            Controls.Add(lbxeploai);
            Controls.Add(tbsdt);
            Controls.Add(lbsdt);
            Controls.Add(dtnthangnsinh);
            Controls.Add(tbdiachi);
            Controls.Add(tbhoten);
            Controls.Add(lbtuoi);
            Controls.Add(lbdiachi);
            Controls.Add(tieude);
            Controls.Add(lbhoten);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "formsoluoc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Sơ Lược Về Sinh Viên";
            Load += formsoluoc_Load;
            ((System.ComponentModel.ISupportInitialize)pbanh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbhoten;
        private Label tieude;
        private Label lbdiachi;
        private Label lbtuoi;
        private ContextMenuStrip contextMenuStrip1;
        private Panel imgkhunganh;
        private TextBox tbhoten;
        private TextBox textBox2;
        private TextBox tbdiachi;
        private DateTimePicker dtnthangnsinh;
        private Label lbsdt;
        private TextBox tbsdt;
        private Label lbxeploai;
        private NotifyIcon nftyanh;
        private ImageList imageList1;
        private PictureBox pbanh;
        private ComboBox CBxeploai;
        private Button btthemanh;
        private Button btxoaanh;
        private Label label1;
        private Button btcapnhat;
        private Button btthoat;
        private GroupBox gbsoluoc;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lbghichu;
        private TextBox tbghichu;
    }
}