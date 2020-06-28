namespace KFCSiparisOtomasyon
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chckKurye = new System.Windows.Forms.CheckBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.lblNumara = new System.Windows.Forms.Label();
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTamamla = new System.Windows.Forms.Button();
            this.chckHardal = new System.Windows.Forms.CheckBox();
            this.chckSMayonez = new System.Windows.Forms.CheckBox();
            this.chckBarbekü = new System.Windows.Forms.CheckBox();
            this.chckRanch = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radiKing = new System.Windows.Forms.RadioButton();
            this.radioBig = new System.Windows.Forms.RadioButton();
            this.radioSmall = new System.Windows.Forms.RadioButton();
            this.cmbMenu = new System.Windows.Forms.ComboBox();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lstSiparis = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblOnayAdSoyad = new System.Windows.Forms.Label();
            this.lblFisAdSoyad = new System.Windows.Forms.Label();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackgroundImage = global::KFCSiparisOtomasyon.Properties.Resources.background;
            this.groupBox1.Controls.Add(this.chckKurye);
            this.groupBox1.Controls.Add(this.lblAdres);
            this.groupBox1.Controls.Add(this.txtAdres);
            this.groupBox1.Controls.Add(this.lblNumara);
            this.groupBox1.Controls.Add(this.txtNumara);
            this.groupBox1.Controls.Add(this.lblAdSoyad);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(270, 423);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişisel Bilgi";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chckKurye
            // 
            this.chckKurye.AutoSize = true;
            this.chckKurye.BackColor = System.Drawing.Color.IndianRed;
            this.chckKurye.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.chckKurye.Location = new System.Drawing.Point(187, 39);
            this.chckKurye.Name = "chckKurye";
            this.chckKurye.Size = new System.Drawing.Size(65, 27);
            this.chckKurye.TabIndex = 6;
            this.chckKurye.Text = "Kurye";
            this.chckKurye.UseVisualStyleBackColor = false;
            this.chckKurye.CheckedChanged += new System.EventHandler(this.chckKurye_CheckedChanged);
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.BackColor = System.Drawing.Color.DarkRed;
            this.lblAdres.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdres.Location = new System.Drawing.Point(23, 243);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(46, 23);
            this.lblAdres.TabIndex = 5;
            this.lblAdres.Text = "Adres";
            // 
            // txtAdres
            // 
            this.txtAdres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdres.Location = new System.Drawing.Point(20, 269);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(215, 118);
            this.txtAdres.TabIndex = 4;
            // 
            // lblNumara
            // 
            this.lblNumara.AutoSize = true;
            this.lblNumara.BackColor = System.Drawing.Color.DarkRed;
            this.lblNumara.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNumara.Location = new System.Drawing.Point(23, 161);
            this.lblNumara.Name = "lblNumara";
            this.lblNumara.Size = new System.Drawing.Size(60, 23);
            this.lblNumara.TabIndex = 3;
            this.lblNumara.Text = "Numara";
            // 
            // txtNumara
            // 
            this.txtNumara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumara.Location = new System.Drawing.Point(20, 187);
            this.txtNumara.Multiline = true;
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(215, 33);
            this.txtNumara.TabIndex = 2;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.BackColor = System.Drawing.Color.DarkRed;
            this.lblAdSoyad.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.Location = new System.Drawing.Point(23, 72);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(67, 23);
            this.lblAdSoyad.TabIndex = 1;
            this.lblAdSoyad.Text = "Ad Soyad";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdSoyad.Location = new System.Drawing.Point(20, 98);
            this.txtAdSoyad.Multiline = true;
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(215, 33);
            this.txtAdSoyad.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.BackgroundImage = global::KFCSiparisOtomasyon.Properties.Resources.background;
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.btnTamamla);
            this.groupBox2.Controls.Add(this.chckHardal);
            this.groupBox2.Controls.Add(this.chckSMayonez);
            this.groupBox2.Controls.Add(this.chckBarbekü);
            this.groupBox2.Controls.Add(this.chckRanch);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.cmbMenu);
            this.groupBox2.Controls.Add(this.lblMenu);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(313, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(267, 423);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sipariş Bilgi";
            // 
            // btnTamamla
            // 
            this.btnTamamla.BackColor = System.Drawing.Color.ForestGreen;
            this.btnTamamla.Location = new System.Drawing.Point(161, 384);
            this.btnTamamla.Name = "btnTamamla";
            this.btnTamamla.Size = new System.Drawing.Size(82, 33);
            this.btnTamamla.TabIndex = 5;
            this.btnTamamla.Text = "Tamamla";
            this.btnTamamla.UseVisualStyleBackColor = false;
            this.btnTamamla.Click += new System.EventHandler(this.btnTamamla_Click);
            // 
            // chckHardal
            // 
            this.chckHardal.AutoSize = true;
            this.chckHardal.BackColor = System.Drawing.Color.DarkRed;
            this.chckHardal.Location = new System.Drawing.Point(128, 351);
            this.chckHardal.Name = "chckHardal";
            this.chckHardal.Size = new System.Drawing.Size(71, 27);
            this.chckHardal.TabIndex = 3;
            this.chckHardal.Text = "Hardal";
            this.chckHardal.UseVisualStyleBackColor = false;
            // 
            // chckSMayonez
            // 
            this.chckSMayonez.AutoSize = true;
            this.chckSMayonez.BackColor = System.Drawing.Color.DarkRed;
            this.chckSMayonez.Location = new System.Drawing.Point(128, 318);
            this.chckSMayonez.Name = "chckSMayonez";
            this.chckSMayonez.Size = new System.Drawing.Size(97, 27);
            this.chckSMayonez.TabIndex = 3;
            this.chckSMayonez.Text = "S. Mayonez";
            this.chckSMayonez.UseVisualStyleBackColor = false;
            // 
            // chckBarbekü
            // 
            this.chckBarbekü.AutoSize = true;
            this.chckBarbekü.BackColor = System.Drawing.Color.DarkRed;
            this.chckBarbekü.Location = new System.Drawing.Point(22, 351);
            this.chckBarbekü.Name = "chckBarbekü";
            this.chckBarbekü.Size = new System.Drawing.Size(82, 27);
            this.chckBarbekü.TabIndex = 3;
            this.chckBarbekü.Text = "Barbekü";
            this.chckBarbekü.UseVisualStyleBackColor = false;
            // 
            // chckRanch
            // 
            this.chckRanch.AutoSize = true;
            this.chckRanch.BackColor = System.Drawing.Color.DarkRed;
            this.chckRanch.Location = new System.Drawing.Point(22, 318);
            this.chckRanch.Name = "chckRanch";
            this.chckRanch.Size = new System.Drawing.Size(94, 27);
            this.chckRanch.TabIndex = 3;
            this.chckRanch.Text = "Ranch Sos";
            this.chckRanch.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = global::KFCSiparisOtomasyon.Properties.Resources.background;
            this.groupBox3.Controls.Add(this.radiKing);
            this.groupBox3.Controls.Add(this.radioBig);
            this.groupBox3.Controls.Add(this.radioSmall);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(34, 150);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(209, 150);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Boy Seçimi";
            // 
            // radiKing
            // 
            this.radiKing.AutoSize = true;
            this.radiKing.BackColor = System.Drawing.Color.DarkRed;
            this.radiKing.Location = new System.Drawing.Point(43, 98);
            this.radiKing.Name = "radiKing";
            this.radiKing.Size = new System.Drawing.Size(56, 27);
            this.radiKing.TabIndex = 0;
            this.radiKing.TabStop = true;
            this.radiKing.Text = "King";
            this.radiKing.UseVisualStyleBackColor = false;
            // 
            // radioBig
            // 
            this.radioBig.AutoSize = true;
            this.radioBig.BackColor = System.Drawing.Color.DarkRed;
            this.radioBig.Location = new System.Drawing.Point(43, 65);
            this.radioBig.Name = "radioBig";
            this.radioBig.Size = new System.Drawing.Size(48, 27);
            this.radioBig.TabIndex = 0;
            this.radioBig.TabStop = true;
            this.radioBig.Text = "Big";
            this.radioBig.UseVisualStyleBackColor = false;
            // 
            // radioSmall
            // 
            this.radioSmall.AutoSize = true;
            this.radioSmall.BackColor = System.Drawing.Color.DarkRed;
            this.radioSmall.Location = new System.Drawing.Point(43, 32);
            this.radioSmall.Name = "radioSmall";
            this.radioSmall.Size = new System.Drawing.Size(64, 27);
            this.radioSmall.TabIndex = 0;
            this.radioSmall.TabStop = true;
            this.radioSmall.Text = "Small";
            this.radioSmall.UseVisualStyleBackColor = false;
            // 
            // cmbMenu
            // 
            this.cmbMenu.FormattingEnabled = true;
            this.cmbMenu.Items.AddRange(new object[] {
            "King Burger",
            "Whooper",
            "Double Burger",
            "Fish Royale",
            "Chicken Royale"});
            this.cmbMenu.Location = new System.Drawing.Point(34, 100);
            this.cmbMenu.Name = "cmbMenu";
            this.cmbMenu.Size = new System.Drawing.Size(187, 31);
            this.cmbMenu.TabIndex = 0;
            this.cmbMenu.Text = "Seçiniz..";
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.BackColor = System.Drawing.Color.DarkRed;
            this.lblMenu.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMenu.Location = new System.Drawing.Point(36, 72);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(98, 23);
            this.lblMenu.TabIndex = 1;
            this.lblMenu.Text = "Menü Seçiniz..";
            // 
            // lstSiparis
            // 
            this.lstSiparis.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstSiparis.FormattingEnabled = true;
            this.lstSiparis.ItemHeight = 23;
            this.lstSiparis.Location = new System.Drawing.Point(23, 483);
            this.lstSiparis.Name = "lstSiparis";
            this.lstSiparis.Size = new System.Drawing.Size(557, 142);
            this.lstSiparis.TabIndex = 7;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.BackgroundImage = global::KFCSiparisOtomasyon.Properties.Resources.background;
            this.groupBox4.Controls.Add(this.lblToplamTutar);
            this.groupBox4.Controls.Add(this.btnOnayla);
            this.groupBox4.Controls.Add(this.lblFisAdSoyad);
            this.groupBox4.Controls.Add(this.lblOnayAdSoyad);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox4.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Location = new System.Drawing.Point(609, 12);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox4.Size = new System.Drawing.Size(270, 149);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ödeme Bilgileri";
            // 
            // lblOnayAdSoyad
            // 
            this.lblOnayAdSoyad.AutoSize = true;
            this.lblOnayAdSoyad.BackColor = System.Drawing.Color.DarkRed;
            this.lblOnayAdSoyad.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOnayAdSoyad.Location = new System.Drawing.Point(25, 43);
            this.lblOnayAdSoyad.Name = "lblOnayAdSoyad";
            this.lblOnayAdSoyad.Size = new System.Drawing.Size(76, 23);
            this.lblOnayAdSoyad.TabIndex = 2;
            this.lblOnayAdSoyad.Text = "Ad Soyad : ";
            // 
            // lblFisAdSoyad
            // 
            this.lblFisAdSoyad.AutoSize = true;
            this.lblFisAdSoyad.BackColor = System.Drawing.Color.DarkRed;
            this.lblFisAdSoyad.Font = new System.Drawing.Font("Bahnschrift Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFisAdSoyad.Location = new System.Drawing.Point(122, 39);
            this.lblFisAdSoyad.Name = "lblFisAdSoyad";
            this.lblFisAdSoyad.Size = new System.Drawing.Size(0, 42);
            this.lblFisAdSoyad.TabIndex = 3;
            // 
            // btnOnayla
            // 
            this.btnOnayla.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnOnayla.Location = new System.Drawing.Point(159, 98);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(75, 40);
            this.btnOnayla.TabIndex = 4;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = false;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.BackColor = System.Drawing.Color.DarkRed;
            this.lblToplamTutar.Font = new System.Drawing.Font("Bahnschrift Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamTutar.ForeColor = System.Drawing.Color.Lime;
            this.lblToplamTutar.Location = new System.Drawing.Point(22, 96);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(0, 42);
            this.lblToplamTutar.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(22, 387);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(51, 30);
            this.numericUpDown1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button2.Location = new System.Drawing.Point(505, 454);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Sipariş Verildi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(4F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KFCSiparisOtomasyon.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(911, 657);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lstSiparis);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chckKurye;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label lblNumara;
        private System.Windows.Forms.TextBox txtNumara;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbMenu;
        private System.Windows.Forms.CheckBox chckHardal;
        private System.Windows.Forms.CheckBox chckSMayonez;
        private System.Windows.Forms.CheckBox chckBarbekü;
        private System.Windows.Forms.CheckBox chckRanch;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radiKing;
        private System.Windows.Forms.RadioButton radioBig;
        private System.Windows.Forms.RadioButton radioSmall;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.ListBox lstSiparis;
        private System.Windows.Forms.Button btnTamamla;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Label lblFisAdSoyad;
        private System.Windows.Forms.Label lblOnayAdSoyad;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button2;
    }
}

