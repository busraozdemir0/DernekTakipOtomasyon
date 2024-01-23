
namespace DernekTakipOtomasyon.PresentationLayer
{
    partial class AidatIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AidatIslemleri));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.msktxtTc = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rdbtnAktif = new System.Windows.Forms.RadioButton();
            this.rdbtnPasif = new System.Windows.Forms.RadioButton();
            this.btnEkle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbAylar = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.dataGridAidat = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridUye = new System.Windows.Forms.DataGridView();
            this.btnAktif = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAidat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUye)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÜYE TC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "MİKTAR:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "ÖDEME TARİHİ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "DURUM:";
            // 
            // msktxtTc
            // 
            this.msktxtTc.Location = new System.Drawing.Point(153, 43);
            this.msktxtTc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.msktxtTc.Mask = "00000000000";
            this.msktxtTc.Name = "msktxtTc";
            this.msktxtTc.Size = new System.Drawing.Size(203, 31);
            this.msktxtTc.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(153, 201);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(203, 31);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // rdbtnAktif
            // 
            this.rdbtnAktif.AutoSize = true;
            this.rdbtnAktif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(121)))), ((int)(((byte)(222)))));
            this.rdbtnAktif.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbtnAktif.Location = new System.Drawing.Point(153, 253);
            this.rdbtnAktif.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbtnAktif.Name = "rdbtnAktif";
            this.rdbtnAktif.Size = new System.Drawing.Size(65, 27);
            this.rdbtnAktif.TabIndex = 7;
            this.rdbtnAktif.TabStop = true;
            this.rdbtnAktif.Text = "Aktif";
            this.rdbtnAktif.UseVisualStyleBackColor = false;
            // 
            // rdbtnPasif
            // 
            this.rdbtnPasif.AutoSize = true;
            this.rdbtnPasif.BackColor = System.Drawing.Color.Red;
            this.rdbtnPasif.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbtnPasif.Location = new System.Drawing.Point(292, 250);
            this.rdbtnPasif.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbtnPasif.Name = "rdbtnPasif";
            this.rdbtnPasif.Size = new System.Drawing.Size(64, 27);
            this.rdbtnPasif.TabIndex = 8;
            this.rdbtnPasif.TabStop = true;
            this.rdbtnPasif.Text = "Pasif";
            this.rdbtnPasif.UseVisualStyleBackColor = false;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(151, 285);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(205, 43);
            this.btnEkle.TabIndex = 9;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(91, 279);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // cmbAylar
            // 
            this.cmbAylar.FormattingEnabled = true;
            this.cmbAylar.Location = new System.Drawing.Point(153, 96);
            this.cmbAylar.Name = "cmbAylar";
            this.cmbAylar.Size = new System.Drawing.Size(203, 31);
            this.cmbAylar.TabIndex = 13;
            this.cmbAylar.SelectedIndexChanged += new System.EventHandler(this.cmbAylar_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "ÖDEME AYI:";
            // 
            // txtMiktar
            // 
            this.txtMiktar.Enabled = false;
            this.txtMiktar.Location = new System.Drawing.Point(153, 149);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(203, 31);
            this.txtMiktar.TabIndex = 15;
            // 
            // dataGridAidat
            // 
            this.dataGridAidat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.dataGridAidat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAidat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridAidat.Location = new System.Drawing.Point(3, 28);
            this.dataGridAidat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridAidat.Name = "dataGridAidat";
            this.dataGridAidat.RowHeadersWidth = 51;
            this.dataGridAidat.Size = new System.Drawing.Size(808, 283);
            this.dataGridAidat.TabIndex = 0;
            this.dataGridAidat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAidat_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridAidat);
            this.groupBox1.Location = new System.Drawing.Point(378, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(814, 315);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AİDAT LİSTESİ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridUye);
            this.groupBox2.Location = new System.Drawing.Point(12, 389);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(1177, 395);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aidat Ekleme İşlemi İçin Üye Seçiniz";
            // 
            // dataGridUye
            // 
            this.dataGridUye.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.dataGridUye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUye.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridUye.Location = new System.Drawing.Point(3, 28);
            this.dataGridUye.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridUye.Name = "dataGridUye";
            this.dataGridUye.RowHeadersWidth = 51;
            this.dataGridUye.Size = new System.Drawing.Size(1171, 363);
            this.dataGridUye.TabIndex = 0;
            this.dataGridUye.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUye_CellClick);
            // 
            // btnAktif
            // 
            this.btnAktif.Location = new System.Drawing.Point(681, 348);
            this.btnAktif.Name = "btnAktif";
            this.btnAktif.Size = new System.Drawing.Size(203, 44);
            this.btnAktif.TabIndex = 17;
            this.btnAktif.Text = "Aktif Yap";
            this.btnAktif.UseVisualStyleBackColor = true;
            this.btnAktif.Click += new System.EventHandler(this.btnAktif_Click);
            // 
            // AidatIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 797);
            this.Controls.Add(this.btnAktif);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbAylar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.rdbtnPasif);
            this.Controls.Add(this.rdbtnAktif);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.msktxtTc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AidatIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AİDAT İŞLEMLERİ";
            this.Load += new System.EventHandler(this.AidatIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAidat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox msktxtTc;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton rdbtnAktif;
        private System.Windows.Forms.RadioButton rdbtnPasif;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbAylar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.DataGridView dataGridAidat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridUye;
        private System.Windows.Forms.Button btnAktif;
    }
}