
namespace DernekTakipOtomasyon.PresentationLayer
{
    partial class Raporlar
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSehir = new System.Windows.Forms.ComboBox();
            this.dtgrdSehir = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbKanGrup = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtgrdKanGrubu = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbtnPasif = new System.Windows.Forms.RadioButton();
            this.rdbtnAktif = new System.Windows.Forms.RadioButton();
            this.dtgrdDurum = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dtgrdTarih = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdSehir)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdKanGrubu)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdDurum)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdTarih)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbSehir);
            this.groupBox1.Controls.Add(this.dtgrdSehir);
            this.groupBox1.Location = new System.Drawing.Point(5, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(975, 503);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Şehre Göre Üye Listesi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Şehir Seçiniz";
            // 
            // cmbSehir
            // 
            this.cmbSehir.FormattingEnabled = true;
            this.cmbSehir.Location = new System.Drawing.Point(134, 35);
            this.cmbSehir.Name = "cmbSehir";
            this.cmbSehir.Size = new System.Drawing.Size(235, 31);
            this.cmbSehir.TabIndex = 1;
            this.cmbSehir.SelectedIndexChanged += new System.EventHandler(this.cmbSehir_SelectedIndexChanged);
            // 
            // dtgrdSehir
            // 
            this.dtgrdSehir.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(210)))), ((int)(((byte)(251)))));
            this.dtgrdSehir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdSehir.Location = new System.Drawing.Point(5, 91);
            this.dtgrdSehir.Name = "dtgrdSehir";
            this.dtgrdSehir.Size = new System.Drawing.Size(960, 404);
            this.dtgrdSehir.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbKanGrup);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dtgrdKanGrubu);
            this.groupBox2.Location = new System.Drawing.Point(990, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(929, 503);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kan Grubuna Göre Üye Listesi";
            // 
            // cmbKanGrup
            // 
            this.cmbKanGrup.FormattingEnabled = true;
            this.cmbKanGrup.Items.AddRange(new object[] {
            "A Rh+",
            "A Rh-",
            "B Rh+",
            "B Rh-",
            "0 Rh+",
            "0 Rh-",
            "AB Rh+",
            "AB Rh-"});
            this.cmbKanGrup.Location = new System.Drawing.Point(177, 35);
            this.cmbKanGrup.Name = "cmbKanGrup";
            this.cmbKanGrup.Size = new System.Drawing.Size(166, 31);
            this.cmbKanGrup.TabIndex = 14;
            this.cmbKanGrup.SelectedIndexChanged += new System.EventHandler(this.cmbKanGrup_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Kan Grubu Seçiniz";
            // 
            // dtgrdKanGrubu
            // 
            this.dtgrdKanGrubu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.dtgrdKanGrubu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdKanGrubu.Location = new System.Drawing.Point(12, 91);
            this.dtgrdKanGrubu.Name = "dtgrdKanGrubu";
            this.dtgrdKanGrubu.Size = new System.Drawing.Size(909, 404);
            this.dtgrdKanGrubu.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbtnPasif);
            this.groupBox3.Controls.Add(this.rdbtnAktif);
            this.groupBox3.Controls.Add(this.dtgrdDurum);
            this.groupBox3.Location = new System.Drawing.Point(5, 517);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(975, 495);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Duruma Göre Üye Listesi";
            // 
            // rdbtnPasif
            // 
            this.rdbtnPasif.AutoSize = true;
            this.rdbtnPasif.Location = new System.Drawing.Point(176, 45);
            this.rdbtnPasif.Name = "rdbtnPasif";
            this.rdbtnPasif.Size = new System.Drawing.Size(126, 27);
            this.rdbtnPasif.TabIndex = 2;
            this.rdbtnPasif.TabStop = true;
            this.rdbtnPasif.Text = "Pasif Üyeler";
            this.rdbtnPasif.UseVisualStyleBackColor = true;
            this.rdbtnPasif.CheckedChanged += new System.EventHandler(this.rdbtnPasif_CheckedChanged);
            // 
            // rdbtnAktif
            // 
            this.rdbtnAktif.AutoSize = true;
            this.rdbtnAktif.Location = new System.Drawing.Point(21, 45);
            this.rdbtnAktif.Name = "rdbtnAktif";
            this.rdbtnAktif.Size = new System.Drawing.Size(127, 27);
            this.rdbtnAktif.TabIndex = 1;
            this.rdbtnAktif.TabStop = true;
            this.rdbtnAktif.Text = "Aktif Üyeler";
            this.rdbtnAktif.UseVisualStyleBackColor = true;
            this.rdbtnAktif.CheckedChanged += new System.EventHandler(this.rdbtnAktif_CheckedChanged);
            // 
            // dtgrdDurum
            // 
            this.dtgrdDurum.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(234)))), ((int)(((byte)(213)))));
            this.dtgrdDurum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdDurum.Location = new System.Drawing.Point(5, 89);
            this.dtgrdDurum.Name = "dtgrdDurum";
            this.dtgrdDurum.Size = new System.Drawing.Size(960, 394);
            this.dtgrdDurum.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.dateTimePicker2);
            this.groupBox4.Controls.Add(this.dateTimePicker1);
            this.groupBox4.Controls.Add(this.dtgrdTarih);
            this.groupBox4.Location = new System.Drawing.Point(990, 517);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox4.Size = new System.Drawing.Size(929, 495);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tarihe Göre Ödeme Listesi";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(751, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(408, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bitiş Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Başlangıç Tarihi";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(525, 37);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 31);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(148, 39);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 31);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dtgrdTarih
            // 
            this.dtgrdTarih.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(210)))), ((int)(((byte)(251)))));
            this.dtgrdTarih.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdTarih.Location = new System.Drawing.Point(8, 89);
            this.dtgrdTarih.Name = "dtgrdTarih";
            this.dtgrdTarih.Size = new System.Drawing.Size(913, 394);
            this.dtgrdTarih.TabIndex = 0;
            // 
            // Raporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 845);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Raporlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RAPORLAR";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Raporlar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdSehir)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdKanGrubu)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdDurum)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdTarih)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dtgrdSehir;
        private System.Windows.Forms.DataGridView dtgrdKanGrubu;
        private System.Windows.Forms.DataGridView dtgrdDurum;
        private System.Windows.Forms.DataGridView dtgrdTarih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSehir;
        private System.Windows.Forms.ComboBox cmbKanGrup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdbtnPasif;
        private System.Windows.Forms.RadioButton rdbtnAktif;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
    }
}