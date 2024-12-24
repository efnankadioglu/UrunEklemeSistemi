namespace UrunEklemeSistemi
{
    partial class KategoriEkle
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
            label1 = new Label();
            label2 = new Label();
            txtAd = new TextBox();
            txtAciklama = new TextBox();
            btnKaydet = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 77);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 0;
            label1.Text = "Ad :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 124);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = "Açıklama :";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(172, 70);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(157, 27);
            txtAd.TabIndex = 2;
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(172, 121);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(157, 67);
            txtAciklama.TabIndex = 3;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(172, 211);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(157, 36);
            btnKaydet.TabIndex = 4;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // KategoriEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 399);
            Controls.Add(btnKaydet);
            Controls.Add(txtAciklama);
            Controls.Add(txtAd);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "KategoriEkle";
            Text = "KategoriEkle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtAd;
        private TextBox txtAciklama;
        private Button btnKaydet;
    }
}