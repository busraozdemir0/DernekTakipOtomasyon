namespace DernekTakipOtomasyon.PresentationLayer
{
    partial class Borclular
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Borclular));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgrBorcular = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtKonu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMesaj = new System.Windows.Forms.RichTextBox();
            this.txtEMail = new System.Windows.Forms.TextBox();
            this.pctrbxGonder = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pctrbxPdfKaydet = new System.Windows.Forms.PictureBox();
            this.btnTopluMail = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrBorcular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxGonder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxPdfKaydet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgrBorcular);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1146, 353);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Borcu Olanların Listesi";
            // 
            // dtgrBorcular
            // 
            this.dtgrBorcular.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.dtgrBorcular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrBorcular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgrBorcular.Location = new System.Drawing.Point(3, 27);
            this.dtgrBorcular.Name = "dtgrBorcular";
            this.dtgrBorcular.Size = new System.Drawing.Size(1140, 323);
            this.dtgrBorcular.TabIndex = 0;
            this.dtgrBorcular.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrBorcular_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-220, 185);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtKonu);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtMesaj);
            this.groupBox2.Controls.Add(this.txtEMail);
            this.groupBox2.Controls.Add(this.pctrbxGonder);
            this.groupBox2.Location = new System.Drawing.Point(644, 359);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(511, 301);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "E-Posta Gönder";
            // 
            // txtKonu
            // 
            this.txtKonu.Location = new System.Drawing.Point(176, 91);
            this.txtKonu.Name = "txtKonu";
            this.txtKonu.Size = new System.Drawing.Size(285, 31);
            this.txtKonu.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Konu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mesaj:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "E-Mail Adresi:";
            // 
            // txtMesaj
            // 
            this.txtMesaj.Location = new System.Drawing.Point(176, 146);
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(285, 138);
            this.txtMesaj.TabIndex = 6;
            this.txtMesaj.Text = "";
            // 
            // txtEMail
            // 
            this.txtEMail.Location = new System.Drawing.Point(176, 36);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(285, 31);
            this.txtEMail.TabIndex = 5;
            // 
            // pctrbxGonder
            // 
            this.pctrbxGonder.Image = ((System.Drawing.Image)(resources.GetObject("pctrbxGonder.Image")));
            this.pctrbxGonder.Location = new System.Drawing.Point(58, 218);
            this.pctrbxGonder.Name = "pctrbxGonder";
            this.pctrbxGonder.Size = new System.Drawing.Size(101, 66);
            this.pctrbxGonder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrbxGonder.TabIndex = 2;
            this.pctrbxGonder.TabStop = false;
            this.pctrbxGonder.Click += new System.EventHandler(this.pctrbxGonder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(84, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "PDF olarak kaydet";
            // 
            // pctrbxPdfKaydet
            // 
            this.pctrbxPdfKaydet.Image = ((System.Drawing.Image)(resources.GetObject("pctrbxPdfKaydet.Image")));
            this.pctrbxPdfKaydet.Location = new System.Drawing.Point(114, 458);
            this.pctrbxPdfKaydet.Name = "pctrbxPdfKaydet";
            this.pctrbxPdfKaydet.Size = new System.Drawing.Size(139, 128);
            this.pctrbxPdfKaydet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrbxPdfKaydet.TabIndex = 4;
            this.pctrbxPdfKaydet.TabStop = false;
            this.pctrbxPdfKaydet.Click += new System.EventHandler(this.pctrbxPdfKaydet_Click);
            // 
            // btnTopluMail
            // 
            this.btnTopluMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(78)))), ((int)(((byte)(63)))));
            this.btnTopluMail.Font = new System.Drawing.Font("Sitka Banner", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTopluMail.ForeColor = System.Drawing.Color.White;
            this.btnTopluMail.Location = new System.Drawing.Point(360, 479);
            this.btnTopluMail.Name = "btnTopluMail";
            this.btnTopluMail.Size = new System.Drawing.Size(192, 82);
            this.btnTopluMail.TabIndex = 11;
            this.btnTopluMail.Text = "Borçlulara Toplu Mail Gönder";
            this.btnTopluMail.UseVisualStyleBackColor = false;
            this.btnTopluMail.Click += new System.EventHandler(this.btnTopluMail_Click);
            // 
            // Borclular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 671);
            this.Controls.Add(this.btnTopluMail);
            this.Controls.Add(this.pctrbxPdfKaydet);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Borclular";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BORÇLULAR LİSTESİ";
            this.Load += new System.EventHandler(this.Borclular_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrBorcular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxGonder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxPdfKaydet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgrBorcular;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtKonu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtMesaj;
        private System.Windows.Forms.TextBox txtEMail;
        private System.Windows.Forms.PictureBox pctrbxGonder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pctrbxPdfKaydet;
        private System.Windows.Forms.Button btnTopluMail;
    }
}