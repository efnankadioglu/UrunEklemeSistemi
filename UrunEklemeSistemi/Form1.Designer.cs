namespace UrunEklemeSistemi
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            btnSil = new Button();
            btnGuncelle = new Button();
            btnKaydet = new Button();
            cmbKategori = new ComboBox();
            nuStok = new NumericUpDown();
            nuFiyat = new NumericUpDown();
            label4 = new Label();
            txtUrunAdi = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lvUrunler = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            rdAd = new RadioButton();
            rdKategoriAd = new RadioButton();
            txtAra = new TextBox();
            btnAra = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nuStok).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nuFiyat).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAra);
            groupBox1.Controls.Add(txtAra);
            groupBox1.Controls.Add(rdKategoriAd);
            groupBox1.Controls.Add(rdAd);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(btnGuncelle);
            groupBox1.Controls.Add(btnKaydet);
            groupBox1.Controls.Add(cmbKategori);
            groupBox1.Controls.Add(nuStok);
            groupBox1.Controls.Add(nuFiyat);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtUrunAdi);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(822, 285);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "ÜRÜN EKLEME PANELİ";
            // 
            // btnSil
            // 
            btnSil.Location = new Point(362, 162);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(168, 38);
            btnSil.TabIndex = 12;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(362, 118);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(168, 38);
            btnGuncelle.TabIndex = 11;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(362, 65);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(168, 38);
            btnKaydet.TabIndex = 10;
            btnKaydet.Text = "KAYDET";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(129, 201);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(151, 28);
            cmbKategori.TabIndex = 9;
            // 
            // nuStok
            // 
            nuStok.Location = new Point(129, 153);
            nuStok.Name = "nuStok";
            nuStok.Size = new Size(150, 27);
            nuStok.TabIndex = 8;
            // 
            // nuFiyat
            // 
            nuFiyat.Location = new Point(129, 97);
            nuFiyat.Name = "nuFiyat";
            nuFiyat.Size = new Size(150, 27);
            nuFiyat.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 209);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 6;
            label4.Text = "Kategori Adı :";
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.Location = new Point(129, 49);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(125, 27);
            txtUrunAdi.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 160);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 2;
            label3.Text = "Ürün Stok :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 104);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 1;
            label2.Text = "Ürün Fiyatı :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 52);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 0;
            label1.Text = "Ürün Adı :";
            // 
            // lvUrunler
            // 
            lvUrunler.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lvUrunler.FullRowSelect = true;
            lvUrunler.GridLines = true;
            lvUrunler.Location = new Point(12, 303);
            lvUrunler.Name = "lvUrunler";
            lvUrunler.Size = new Size(822, 242);
            lvUrunler.TabIndex = 1;
            lvUrunler.UseCompatibleStateImageBehavior = false;
            lvUrunler.View = View.Details;
            lvUrunler.DoubleClick += lvUrunler_DoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ad";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Stok";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Fiyat";
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Kategori Ad";
            columnHeader5.Width = 150;
            // 
            // rdAd
            // 
            rdAd.AutoSize = true;
            rdAd.Location = new Point(609, 65);
            rdAd.Name = "rdAd";
            rdAd.Size = new Size(105, 24);
            rdAd.TabIndex = 13;
            rdAd.TabStop = true;
            rdAd.Text = "Adında Ara";
            rdAd.UseVisualStyleBackColor = true;
            // 
            // rdKategoriAd
            // 
            rdKategoriAd.AutoSize = true;
            rdKategoriAd.Location = new Point(609, 104);
            rdKategoriAd.Name = "rdKategoriAd";
            rdKategoriAd.Size = new Size(166, 24);
            rdKategoriAd.TabIndex = 14;
            rdKategoriAd.TabStop = true;
            rdKategoriAd.Text = "Kategori Adında Ara";
            rdKategoriAd.UseVisualStyleBackColor = true;
            // 
            // txtAra
            // 
            txtAra.Location = new Point(609, 143);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(175, 27);
            txtAra.TabIndex = 15;
            // 
            // btnAra
            // 
            btnAra.Location = new Point(609, 185);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(175, 44);
            btnAra.TabIndex = 16;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 557);
            Controls.Add(lvUrunler);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nuStok).EndInit();
            ((System.ComponentModel.ISupportInitialize)nuFiyat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListView lvUrunler;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Label label4;
        private TextBox txtUrunAdi;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbKategori;
        private NumericUpDown nuStok;
        private NumericUpDown nuFiyat;
        private Button btnSil;
        private Button btnGuncelle;
        private Button btnKaydet;
        private Button btnAra;
        private TextBox txtAra;
        private RadioButton rdKategoriAd;
        private RadioButton rdAd;
    }
}
