using DernekTakipOtomasyon.DataAccessLayer.Context;
using DernekTakipOtomasyon.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DernekTakipOtomasyon.PresentationLayer
{
    public partial class Borclular : Form
    {
        public Borclular()
        {
            InitializeComponent();
        }

        // Veri tabanından direkt olarak erişmemiz gerektiği durumlarda nesne üretildi.
        DernekTakipEntities db = new DernekTakipEntities();

        private void Borclular_Load(object sender, EventArgs e)
        {
            // Aidat tablosunda ödeme durumu false olan üyelerin bilgilerini sayfa yüklendiğinde listeleme işlemi

            var uyeler = db.Aidat.Where(x => x.Durum == false).Select(y => y.UyeID).ToList();

            List<Uye> borclular = new List<Uye>();

            foreach (int uyeID in uyeler)
            {
                var borclu = db.Uye.Where(x => x.ID == uyeID).FirstOrDefault();

                if (borclu != null)
                {
                    borclular.Add(borclu);
                }
            }

            dtgrBorcular.DataSource = borclular;
        }

        private void pctrbxPdfKaydet_Click(object sender, EventArgs e)
        {
            if (dtgrBorcular.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog(); // Dosyayı kaydetmek için iletişim kutusu açabilmek adına nesne oluşturuldu.
                sfd.Filter = "PDF (*.pdf)|*.pdf";   // Dosyanın formatı (pdf)
                sfd.FileName = "BorclularListesi.pdf";  // Dosyanın adı
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Hata Oluştu. Tekrar Deneyiniz." + ex.Message, "Hata", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dtgrBorcular.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dtgrBorcular.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dtgrBorcular.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("İşlem Başarılı.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hata:" + ex.Message, "Hata", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void pctrbxGonder_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient();

                mail.From = new MailAddress("uiswagger@gmail.com");  // Mail uiswagger@gmail.com adlı hesaptan gönderilecek
                mail.To.Add(txtEMail.Text.ToString());
                mail.Subject = txtKonu.Text.ToString();
                mail.Body = txtMesaj.Text.ToString();

                // Mail'in gönderileceği mail hesabı belirtildi ve şifresi hashlenerek tutuldu
                SmtpServer.Credentials = new System.Net.NetworkCredential("uiswagger@gmail.com", "uzypqmelvqfrisiu");

                SmtpServer.Host = "smtp.gmail.com";
                SmtpServer.EnableSsl = true;
                SmtpServer.Port = 587;
                SmtpServer.Send(mail);
                MessageBox.Show("Email başarıyla gönderildi", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void dtgrBorcular_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dtgrBorcular.SelectedCells[0].RowIndex;

            // Listeden seçilen kişi mail bilgisinin Email textbox'ına otomatik gelmesi için
            txtEMail.Text = dtgrBorcular.Rows[secilen].Cells[7].Value.ToString();  
        }

        private void btnTopluMail_Click(object sender, EventArgs e)
        {
            try
            {
                // E-posta gönderen hesap bilgileri
                string senderEmail = "uiswagger@gmail.com";
                string senderPassword = "uzypqmelvqfrisiu";

                // Alıcı e-posta adresleri (toplu mail gönderileceği için List formatında tutuldu)
                List<string> recipientEmails = new List<string>();

                // Belirli sütunun indeksini bul (maillerin yer aldığı sütun)
                int columnIndex = dtgrBorcular.Columns[7].Index;

                // Her bir satırdaki belirli hücrenin değerini recipientEmails listesine ekle
                foreach (DataGridViewRow row in dtgrBorcular.Rows)
                {
                    object cellValue = row.Cells[columnIndex].Value;
                    if (cellValue != null)
                    {
                        recipientEmails.Add(cellValue.ToString());
                    }
                }

                // E-posta başlığı ve içeriği
                string subject = "Borç";
                string body = "Dernek sisteminde borcunuz bulunmaktadır. Borcunuzu yakın zamanda ödeyiniz. İyi Günler...";

                // SMTP sunucu ve port bilgileri
                string smtpServer = "smtp.gmail.com";
                int smtpPort = 587;

                // E-posta gönderme işlemi
                using (SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort))
                {
                    smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);
                    smtpClient.EnableSsl = true;

                    foreach (var recipientEmail in recipientEmails)
                    {
                        using (MailMessage mailMessage = new MailMessage(senderEmail, recipientEmail, subject, body))
                        {
                            smtpClient.Send(mailMessage);

                        }
                    }
                    MessageBox.Show("E-postalar başarıyla gönderildi.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
