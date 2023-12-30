namespace otomasyon
{
    partial class FrmYeniMusteri
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
            groupBox1 = new GroupBox();
            Sayac = new Label();
            CmbCinsiyet = new ComboBox();
            label11 = new Label();
            DtpCıkısTarihi = new DateTimePicker();
            DtpGirisTarihi = new DateTimePicker();
            label8 = new Label();
            label7 = new Label();
            TxtUcret = new TextBox();
            label10 = new Label();
            label9 = new Label();
            BtnKaydet = new Button();
            MskTxtTelefon = new MaskedTextBox();
            TxtOdaNo = new TextBox();
            TxtKimlikNo = new TextBox();
            TxtMail = new TextBox();
            TxtSoyadi = new TextBox();
            TxtAdi = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            BtnOda111 = new Button();
            BtnOda112 = new Button();
            BtnOda110 = new Button();
            BtnOda109 = new Button();
            BtnOda108 = new Button();
            BtnOda107 = new Button();
            BtnOda106 = new Button();
            BtnOda105 = new Button();
            BtnOda104 = new Button();
            BtnOda103 = new Button();
            BtnOda102 = new Button();
            BtnOda101 = new Button();
            BtnOdaDolu = new Button();
            BtnOdaBos = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(128, 255, 255);
            groupBox1.Controls.Add(Sayac);
            groupBox1.Controls.Add(CmbCinsiyet);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(DtpCıkısTarihi);
            groupBox1.Controls.Add(DtpGirisTarihi);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(TxtUcret);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(BtnKaydet);
            groupBox1.Controls.Add(MskTxtTelefon);
            groupBox1.Controls.Add(TxtOdaNo);
            groupBox1.Controls.Add(TxtKimlikNo);
            groupBox1.Controls.Add(TxtMail);
            groupBox1.Controls.Add(TxtSoyadi);
            groupBox1.Controls.Add(TxtAdi);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(-4, -1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(536, 663);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Müşteri Kayıt";
            // 
            // Sayac
            // 
            Sayac.AutoSize = true;
            Sayac.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            Sayac.Location = new Point(454, 566);
            Sayac.Name = "Sayac";
            Sayac.Size = new Size(22, 25);
            Sayac.TabIndex = 47;
            Sayac.Text = "0";
            // 
            // CmbCinsiyet
            // 
            CmbCinsiyet.BackColor = Color.FromArgb(255, 255, 192);
            CmbCinsiyet.FormattingEnabled = true;
            CmbCinsiyet.Items.AddRange(new object[] { "Bay", "Bayan" });
            CmbCinsiyet.Location = new Point(161, 208);
            CmbCinsiyet.Name = "CmbCinsiyet";
            CmbCinsiyet.Size = new Size(250, 33);
            CmbCinsiyet.TabIndex = 46;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(86, 210);
            label11.Name = "label11";
            label11.Size = new Size(82, 25);
            label11.TabIndex = 45;
            label11.Text = "Cinsiyet:";
            // 
            // DtpCıkısTarihi
            // 
            DtpCıkısTarihi.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            DtpCıkısTarihi.Location = new Point(161, 529);
            DtpCıkısTarihi.Name = "DtpCıkısTarihi";
            DtpCıkısTarihi.Size = new Size(250, 31);
            DtpCıkısTarihi.TabIndex = 44;
            DtpCıkısTarihi.ValueChanged += DtpCıkısTarihi_ValueChanged;
            // 
            // DtpGirisTarihi
            // 
            DtpGirisTarihi.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            DtpGirisTarihi.Location = new Point(161, 486);
            DtpGirisTarihi.Name = "DtpGirisTarihi";
            DtpGirisTarihi.Size = new Size(250, 31);
            DtpGirisTarihi.TabIndex = 43;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(60, 529);
            label8.Name = "label8";
            label8.Size = new Size(103, 25);
            label8.TabIndex = 42;
            label8.Text = "Çıkış Tarihi:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(60, 486);
            label7.Name = "label7";
            label7.Size = new Size(103, 25);
            label7.TabIndex = 41;
            label7.Text = "Giriş Tarihi:";
            // 
            // TxtUcret
            // 
            TxtUcret.BackColor = Color.FromArgb(255, 255, 192);
            TxtUcret.Enabled = false;
            TxtUcret.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            TxtUcret.Location = new Point(161, 440);
            TxtUcret.Name = "TxtUcret";
            TxtUcret.Size = new Size(250, 31);
            TxtUcret.TabIndex = 40;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(95, 443);
            label10.Name = "label10";
            label10.Size = new Size(61, 25);
            label10.TabIndex = 39;
            label10.Text = "Ücret:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(192, 255, 192);
            label9.Font = new Font("Algerian", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Blue;
            label9.Location = new Point(95, 67);
            label9.Name = "label9";
            label9.Size = new Size(381, 20);
            label9.TabIndex = 38;
            label9.Text = "MÜŞTERİ KAYIT ALANINA HOŞ GELDİNİZ..";
            // 
            // BtnKaydet
            // 
            BtnKaydet.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnKaydet.Location = new Point(193, 571);
            BtnKaydet.Name = "BtnKaydet";
            BtnKaydet.Size = new Size(132, 35);
            BtnKaydet.TabIndex = 37;
            BtnKaydet.Text = "Kaydet";
            BtnKaydet.UseVisualStyleBackColor = true;
            BtnKaydet.Click += BtnKaydet_Click;
            // 
            // MskTxtTelefon
            // 
            MskTxtTelefon.BackColor = Color.FromArgb(255, 255, 192);
            MskTxtTelefon.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            MskTxtTelefon.Location = new Point(161, 295);
            MskTxtTelefon.Mask = "(999) 000-0000";
            MskTxtTelefon.Name = "MskTxtTelefon";
            MskTxtTelefon.Size = new Size(250, 31);
            MskTxtTelefon.TabIndex = 34;
            // 
            // TxtOdaNo
            // 
            TxtOdaNo.BackColor = Color.FromArgb(255, 255, 192);
            TxtOdaNo.Enabled = false;
            TxtOdaNo.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            TxtOdaNo.Location = new Point(161, 393);
            TxtOdaNo.Name = "TxtOdaNo";
            TxtOdaNo.Size = new Size(250, 31);
            TxtOdaNo.TabIndex = 33;
            // 
            // TxtKimlikNo
            // 
            TxtKimlikNo.BackColor = Color.FromArgb(255, 255, 192);
            TxtKimlikNo.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            TxtKimlikNo.Location = new Point(161, 338);
            TxtKimlikNo.MaxLength = 11;
            TxtKimlikNo.Name = "TxtKimlikNo";
            TxtKimlikNo.Size = new Size(250, 31);
            TxtKimlikNo.TabIndex = 32;
            // 
            // TxtMail
            // 
            TxtMail.BackColor = Color.FromArgb(255, 255, 192);
            TxtMail.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            TxtMail.Location = new Point(161, 247);
            TxtMail.Name = "TxtMail";
            TxtMail.Size = new Size(250, 31);
            TxtMail.TabIndex = 31;
            // 
            // TxtSoyadi
            // 
            TxtSoyadi.BackColor = Color.FromArgb(255, 255, 192);
            TxtSoyadi.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            TxtSoyadi.Location = new Point(161, 164);
            TxtSoyadi.Name = "TxtSoyadi";
            TxtSoyadi.Size = new Size(250, 31);
            TxtSoyadi.TabIndex = 30;
            // 
            // TxtAdi
            // 
            TxtAdi.BackColor = Color.FromArgb(255, 255, 192);
            TxtAdi.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            TxtAdi.Location = new Point(161, 110);
            TxtAdi.Name = "TxtAdi";
            TxtAdi.Size = new Size(250, 31);
            TxtAdi.TabIndex = 29;
            TxtAdi.TextChanged += TxtAdi_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(29, 393);
            label6.Name = "label6";
            label6.Size = new Size(134, 25);
            label6.TabIndex = 26;
            label6.Text = "Oda Numarası:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(38, 338);
            label5.Name = "label5";
            label5.Size = new Size(125, 25);
            label5.TabIndex = 25;
            label5.Text = "T.C Kimlik No:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(86, 294);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 24;
            label3.Text = "Telefon:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(111, 247);
            label4.Name = "label4";
            label4.Size = new Size(52, 25);
            label4.TabIndex = 23;
            label4.Text = "Mail:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(92, 164);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 22;
            label2.Text = "Soyadı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(119, 113);
            label1.Name = "label1";
            label1.Size = new Size(44, 25);
            label1.TabIndex = 21;
            label1.Text = "Adı:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(255, 255, 128);
            groupBox2.Controls.Add(BtnOda111);
            groupBox2.Controls.Add(BtnOda112);
            groupBox2.Controls.Add(BtnOda110);
            groupBox2.Controls.Add(BtnOda109);
            groupBox2.Controls.Add(BtnOda108);
            groupBox2.Controls.Add(BtnOda107);
            groupBox2.Controls.Add(BtnOda106);
            groupBox2.Controls.Add(BtnOda105);
            groupBox2.Controls.Add(BtnOda104);
            groupBox2.Controls.Add(BtnOda103);
            groupBox2.Controls.Add(BtnOda102);
            groupBox2.Controls.Add(BtnOda101);
            groupBox2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(532, -1);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(444, 549);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Odalar";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // BtnOda111
            // 
            BtnOda111.BackColor = Color.Lime;
            BtnOda111.Location = new Point(170, 332);
            BtnOda111.Name = "BtnOda111";
            BtnOda111.Size = new Size(83, 46);
            BtnOda111.TabIndex = 12;
            BtnOda111.Text = "O:111";
            BtnOda111.UseVisualStyleBackColor = false;
            BtnOda111.Click += BtnOda111_Click;
            // 
            // BtnOda112
            // 
            BtnOda112.BackColor = Color.Lime;
            BtnOda112.Location = new Point(313, 332);
            BtnOda112.Name = "BtnOda112";
            BtnOda112.Size = new Size(83, 46);
            BtnOda112.TabIndex = 11;
            BtnOda112.Text = "O:112";
            BtnOda112.UseVisualStyleBackColor = false;
            BtnOda112.Click += BtnOda112_Click;
            // 
            // BtnOda110
            // 
            BtnOda110.BackColor = Color.Lime;
            BtnOda110.Location = new Point(29, 332);
            BtnOda110.Name = "BtnOda110";
            BtnOda110.Size = new Size(83, 46);
            BtnOda110.TabIndex = 9;
            BtnOda110.Text = "O:110";
            BtnOda110.UseVisualStyleBackColor = false;
            BtnOda110.Click += BtnOda110_Click;
            // 
            // BtnOda109
            // 
            BtnOda109.BackColor = Color.Lime;
            BtnOda109.Location = new Point(313, 247);
            BtnOda109.Name = "BtnOda109";
            BtnOda109.Size = new Size(83, 46);
            BtnOda109.TabIndex = 8;
            BtnOda109.Text = "O:109";
            BtnOda109.UseVisualStyleBackColor = false;
            BtnOda109.Click += BtnOda109_Click;
            // 
            // BtnOda108
            // 
            BtnOda108.BackColor = Color.Lime;
            BtnOda108.Location = new Point(170, 247);
            BtnOda108.Name = "BtnOda108";
            BtnOda108.Size = new Size(83, 46);
            BtnOda108.TabIndex = 7;
            BtnOda108.Text = "O:108";
            BtnOda108.UseVisualStyleBackColor = false;
            BtnOda108.Click += BtnOda108_Click;
            // 
            // BtnOda107
            // 
            BtnOda107.BackColor = Color.Lime;
            BtnOda107.Location = new Point(29, 247);
            BtnOda107.Name = "BtnOda107";
            BtnOda107.Size = new Size(83, 46);
            BtnOda107.TabIndex = 6;
            BtnOda107.Text = "O:107";
            BtnOda107.UseVisualStyleBackColor = false;
            BtnOda107.Click += BtnOda107_Click;
            // 
            // BtnOda106
            // 
            BtnOda106.BackColor = Color.Lime;
            BtnOda106.Location = new Point(313, 156);
            BtnOda106.Name = "BtnOda106";
            BtnOda106.Size = new Size(83, 46);
            BtnOda106.TabIndex = 5;
            BtnOda106.Text = "O:106";
            BtnOda106.UseVisualStyleBackColor = false;
            BtnOda106.Click += BtnOda106_Click;
            // 
            // BtnOda105
            // 
            BtnOda105.BackColor = Color.Lime;
            BtnOda105.Location = new Point(170, 156);
            BtnOda105.Name = "BtnOda105";
            BtnOda105.Size = new Size(83, 46);
            BtnOda105.TabIndex = 4;
            BtnOda105.Text = "O:105";
            BtnOda105.UseVisualStyleBackColor = false;
            BtnOda105.Click += BtnOda105_Click;
            // 
            // BtnOda104
            // 
            BtnOda104.BackColor = Color.Lime;
            BtnOda104.Location = new Point(29, 156);
            BtnOda104.Name = "BtnOda104";
            BtnOda104.Size = new Size(83, 46);
            BtnOda104.TabIndex = 3;
            BtnOda104.Text = "O:104";
            BtnOda104.UseVisualStyleBackColor = false;
            BtnOda104.Click += BtnOda104_Click;
            // 
            // BtnOda103
            // 
            BtnOda103.BackColor = Color.Lime;
            BtnOda103.Location = new Point(313, 70);
            BtnOda103.Name = "BtnOda103";
            BtnOda103.Size = new Size(83, 46);
            BtnOda103.TabIndex = 2;
            BtnOda103.Text = "O:103";
            BtnOda103.UseVisualStyleBackColor = false;
            BtnOda103.Click += BtnOda103_Click;
            // 
            // BtnOda102
            // 
            BtnOda102.BackColor = Color.Lime;
            BtnOda102.Location = new Point(170, 70);
            BtnOda102.Name = "BtnOda102";
            BtnOda102.Size = new Size(83, 46);
            BtnOda102.TabIndex = 1;
            BtnOda102.Text = "O:102";
            BtnOda102.UseVisualStyleBackColor = false;
            BtnOda102.Click += BtnOda102_Click;
            // 
            // BtnOda101
            // 
            BtnOda101.BackColor = Color.Lime;
            BtnOda101.Location = new Point(29, 67);
            BtnOda101.Name = "BtnOda101";
            BtnOda101.Size = new Size(83, 46);
            BtnOda101.TabIndex = 0;
            BtnOda101.Text = "O:101";
            BtnOda101.UseVisualStyleBackColor = false;
            BtnOda101.Click += BtnOda101_Click;
            // 
            // BtnOdaDolu
            // 
            BtnOdaDolu.BackColor = Color.Red;
            BtnOdaDolu.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnOdaDolu.Location = new Point(739, 565);
            BtnOdaDolu.Name = "BtnOdaDolu";
            BtnOdaDolu.Size = new Size(83, 46);
            BtnOdaDolu.TabIndex = 10;
            BtnOdaDolu.Text = "DOLU";
            BtnOdaDolu.UseVisualStyleBackColor = false;
            BtnOdaDolu.Click += BtnOdaDolu_Click;
            // 
            // BtnOdaBos
            // 
            BtnOdaBos.BackColor = Color.FromArgb(128, 255, 128);
            BtnOdaBos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnOdaBos.Location = new Point(864, 565);
            BtnOdaBos.Name = "BtnOdaBos";
            BtnOdaBos.Size = new Size(83, 46);
            BtnOdaBos.TabIndex = 11;
            BtnOdaBos.Text = "BOŞ";
            BtnOdaBos.UseVisualStyleBackColor = false;
            BtnOdaBos.Click += BtnOdaBos_Click;
            // 
            // FrmYeniMusteri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Orange;
            ClientSize = new Size(976, 674);
            Controls.Add(BtnOdaBos);
            Controls.Add(BtnOdaDolu);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmYeniMusteri";
            Text = "Yeni Müşteri Ekle";
            Load += FrmYeniMusteri_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private GroupBox groupBox1;
        private Button BtnKaydet;
        private MaskedTextBox MskTxtTelefon;
        private TextBox TxtOdaNo;
        private TextBox TxtKimlikNo;
        private TextBox TxtMail;
        private TextBox TxtSoyadi;
        private TextBox TxtAdi;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button BtnOda112;
        private Button BtnOda110;
        private Button BtnOda109;
        private Button BtnOda108;
        private Button BtnOda107;
        private Button BtnOda106;
        private Button BtnOda105;
        private Button BtnOda104;
        private Button BtnOda103;
        private Button BtnOda102;
        private Button BtnOda101;
        private Button BtnOda111;
        private Button BtnOdaDolu;
        private Button BtnOdaBos;
        private Label label9;
        private DateTimePicker DtpCıkısTarihi;
        private DateTimePicker DtpGirisTarihi;
        private Label label8;
        private Label label7;
        private TextBox TxtUcret;
        private Label label10;
        private Label label11;
        private ComboBox CmbCinsiyet;
        private Label Sayac;
    }
}