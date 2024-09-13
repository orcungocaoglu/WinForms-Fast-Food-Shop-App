using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Kayıt : Form
    {
        public Kayıt()
        {
            InitializeComponent();
        }

        // JSON dosyası yolu
        private string filePath = Path.Combine(Application.StartupPath, "Data", "personeller.json");

        // Mevcut personelleri tutan dictionary
        private Dictionary<int, personelData> personellerDict = new Dictionary<int, personelData>();

        private void kayitButon_Click(object sender, EventArgs e)
        {
            // Formda eksik bilgi kontrolü
            if (string.IsNullOrWhiteSpace(adTextbox.Text) ||
                string.IsNullOrWhiteSpace(sifreTextbox.Text) ||
                string.IsNullOrWhiteSpace(ePostaTextbox.Text))
            {
                MessageBox.Show("Formda Eksik Bilgi Bulunuyor");
                return;
            }

            // Yeni personel oluşturma
            personelData personel = new personelData
            {
                kullaniciAdi = adTextbox.Text.Trim(),
                sifre = sifreTextbox.Text.Trim(),
                ePosta = ePostaTextbox.Text.Trim()
            };

            // Mevcut JSON dosyasını okuma ve dictionary'ye yükleme
            if (File.Exists(filePath))
            {
                try
                {
                    string existingJson = File.ReadAllText(filePath);
                    if (!string.IsNullOrEmpty(existingJson))
                    {
                        personellerDict = JsonConvert.DeserializeObject<Dictionary<int, personelData>>(existingJson);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("JSON dosyası okunurken bir hata oluştu: " + ex.Message);
                    return;
                }
            }

            // Yeni personelID belirleme
            int yeniPersonelID = (personellerDict.Count > 0) ? personellerDict.Keys.Max() + 1 : 1;
            personel.personelID = yeniPersonelID;

            // Personeli dictionary'ye ekleme
            personellerDict.Add(yeniPersonelID, personel);

            // Güncellenmiş personel listesini JSON dosyasına yazma
            try
            {
                string json = JsonConvert.SerializeObject(personellerDict, Formatting.Indented);
                File.WriteAllText(filePath, json);
                MessageBox.Show("Yeni kullanıcı kaydedildi.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler kaydedilirken bir hata oluştu: " + ex.Message);
            }

            // TextBox'ları temizleme
            adTextbox.Clear();
            sifreTextbox.Clear();
            ePostaTextbox.Clear();
        }

        private void geriDonButon_Click(object sender, EventArgs e)
        {
            new giris().Show();
            this.Close();
        }
    }
}
