using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp3
{
    public partial class anaSayfa : Form
    {
        private string filePath = Path.Combine(Application.StartupPath, "Data", "siparisler.json");
        private Dictionary<int, siparisData> siparisDict = new Dictionary<int, siparisData>();

        int tutar = 0;

        // Fiyatlar //
        int anaYemek1Fiyat = 180;
        int anaYemek2Fiyat = 170;
        int anaYemek3Fiyat = 165;
        int anaYemek4Fiyat = 155;
        int anaYemek5Fiyat = 150;
        int anaYemek6Fiyat = 145;
        int icecek1Fiyat = 35;
        int icecek2Fiyat = 35;
        int icecek3Fiyat = 35;
        int icecek4Fiyat = 35;
        int icecek5Fiyat = 20;
        int icecek6Fiyat = 15;
        int ekstra1Fiyat = 50;
        int ekstra2Fiyat = 45;
        int ekstra3Fiyat = 45;
        int ekstra4Fiyat = 35;
        int ekstra5Fiyat = 30;
        int ekstra6Fiyat = 20;
        
        int musteriID = 1;

        private void SaveDictionaryToFile()
        {
            try
            {
                string json = JsonConvert.SerializeObject(siparisDict, Formatting.Indented);
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dosyaya yazarken bir hata oluştu: " + ex.Message);
            }
        }

        private void LoadDictionaryFromFile()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    siparisDict = JsonConvert.DeserializeObject<Dictionary<int, siparisData>>(json) ?? new Dictionary<int, siparisData>();

                    if (siparisDict.Count > 0)
                    {
                        musteriID = siparisDict.Keys.Max() + 1;
                    }
                    else
                    {
                        musteriID = 1;
                    }
                }
                else
                {
                    musteriID = 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dosyayı okurken bir hata oluştu: " + ex.Message);
                musteriID = 1;
            }
        }

        private void formTemizle()
        {
            musteriAdTextbox.Clear();
            anaYemek1CheckBox.Checked = false;
            anaYemek2CheckBox.Checked = false;
            anaYemek3CheckBox.Checked = false;
            anaYemek4CheckBox.Checked = false;
            anaYemek5CheckBox.Checked = false;
            anaYemek6CheckBox.Checked = false;
            icecek1CheckBox.Checked = false;
            icecek2CheckBox.Checked = false;
            icecek3CheckBox.Checked = false;
            icecek4CheckBox.Checked = false;
            icecek5CheckBox.Checked = false;
            icecek6CheckBox.Checked = false;
            ekstra1Checkbox.Checked = false;
            ekstra2Checkbox.Checked = false;
            ekstra3Checkbox.Checked = false;
            ekstra4Checkbox.Checked = false;
            ekstra5Checkbox.Checked = false;
            ekstra6Checkbox.Checked = false;
            siparisListbox.Items.Clear();
            tutarLabel.Text = "Tutar: ";
            notTextbox.Text = "";
            sifreTextbox.Text = "";
        }

        private void HandleCheckBoxChanged(System.Windows.Forms.CheckBox checkBox, ListBox listBox, string itemText, int itemFiyat)
        {
            if (checkBox.Checked)
            {
                if (!listBox.Items.Contains(itemText))
                {
                    listBox.Items.Add(itemText);
                    tutar += itemFiyat;
                }
            }
            else
            {
                int index = listBox.Items.IndexOf(itemText);
                if (index != -1)
                {
                    listBox.Items.RemoveAt(index);
                    tutar -= itemFiyat;
                }
            }

            UpdateTotalPriceUI();
        }

        private void UpdateTotalPriceUI()
        {
            tutarLabel.Text = "Toplam Fiyat: " + tutar.ToString("C2");
        }



        public anaSayfa()
        {
            LoadDictionaryFromFile();
            InitializeComponent();
        }

        private void girisSayfaButon_Click(object sender, EventArgs e)
        {
            this.Close();

            // Açık formları tutmak için bir liste
            List<Form> formlar = new List<Form>();

            // Açık form kontrolü
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm.Name == "personeller" || openForm.Name == "siparisler")
                {
                    formlar.Add(openForm);
                }
            }

            // Açık olan formları kapatma
            foreach (Form form in formlar)
            {
                form.Close();
            }

            new giris().Show();
        }



        private void siparisButon_Click(object sender, EventArgs e)
        {

            siparisData siparis = new siparisData();
            string musteriAd = musteriAdTextbox.Text;
            string anaMenu = "";
            string icecek = "";
            string ekstralar = "";
            string not = notTextbox.Text;

            if (anaYemek1CheckBox.Checked)
            {
                anaMenu += anaYemek1CheckBox.Text + ", ";
            }
            if (anaYemek2CheckBox.Checked)
            {
                anaMenu += anaYemek2CheckBox.Text + ", ";
            }
            if (anaYemek3CheckBox.Checked)
            {
                anaMenu += anaYemek3CheckBox.Text + ", ";
            }
            if (anaYemek4CheckBox.Checked)
            {
                anaMenu += anaYemek4CheckBox.Text + ", ";
            }
            if (anaYemek5CheckBox.Checked)
            {
                anaMenu += anaYemek5CheckBox.Text + ", ";
            }
            if (anaYemek6CheckBox.Checked)
            {
                anaMenu += anaYemek6CheckBox.Text + ", ";
            }

            //////////////////////////////////////////////////////

            if (icecek1CheckBox.Checked)
            {
                icecek += icecek1CheckBox.Text + ", ";
            }
            if (icecek2CheckBox.Checked)
            {
                icecek += icecek2CheckBox.Text + ", ";
            }
            if (icecek3CheckBox.Checked)
            {
                icecek += icecek3CheckBox.Text + ", ";
            }
            if (icecek4CheckBox.Checked)
            {
                icecek += icecek4CheckBox.Text + ", ";
            }
            if (icecek5CheckBox.Checked)
            {
                icecek += icecek5CheckBox.Text + ", ";
            }
            if (icecek6CheckBox.Checked)
            {
                icecek += icecek6CheckBox.Text + ", ";
            }

            //////////////////////////////////////////////////////


            if (ekstra1Checkbox.Checked)
            {
                ekstralar += ekstra1Checkbox.Text + ", ";
            }
            if (ekstra2Checkbox.Checked)
            {
                ekstralar += ekstra2Checkbox.Text + ", ";
            }
            if (ekstra3Checkbox.Checked)
            {
                ekstralar += ekstra3Checkbox.Text + ", ";
            }
            if (ekstra4Checkbox.Checked)
            {
                ekstralar += ekstra4Checkbox.Text + ", ";
            }
            if (ekstra5Checkbox.Checked)
            {
                ekstralar += ekstra5Checkbox.Text + ", ";
            }
            if (ekstra6Checkbox.Checked)
            {
                ekstralar += ekstra6Checkbox.Text + ", ";
            }

            //////////////////////////////////////////////////////////////////
            if (musteriAd == "")
            {
                MessageBox.Show("Müşteri Adı Girilmemiş.");
            }

            else if (tutar == 0)
            {
                MessageBox.Show("Herhangi Bir İçerik Bulunmuyor.");
            }
            else
            {
                if (anaMenu.EndsWith(", "))
                {
                    anaMenu = anaMenu.Substring(0, anaMenu.Length - 2);
                }
                if (icecek.EndsWith(", "))
                {
                    icecek = icecek.Substring(0, icecek.Length - 2);
                }
                if (ekstralar.EndsWith(", "))
                {
                    ekstralar = ekstralar.Substring(0, ekstralar.Length - 2);
                }

                siparisDict.Add(musteriID, new siparisData
                {
                    id = musteriID,
                    musteriAd = musteriAd,
                    anaMenu = anaMenu,
                    icecek = icecek,
                    ekstralar = ekstralar,
                    tutar = tutar,
                    not = not
                });

                musteriID++;


                MessageBox.Show("Sipariş alınmıştır");

                SaveDictionaryToFile();

                formTemizle();
            }
        }

        private void siparisSayfaButon_Click(object sender, EventArgs e)
        {
            if (sifreTextbox.Text == "1234")
            {
                new siparisler().Show();
                sifreTextbox.Clear();
            }
            else
            {
                MessageBox.Show("Girdiğiniz Şifre Yanlış, Tekrar Deneyin.");
                sifreTextbox.Clear();
            }
        }

        private void personelSayfaButon_Click(object sender, EventArgs e)
        {
            if (sifreTextbox.Text == "1234")
            {
                new personeller().Show();
                sifreTextbox.Clear();
            }
            else
            {
                MessageBox.Show("Girdiğiniz Şifre Yanlış, Tekrar Deneyin.");
                sifreTextbox.Clear();
            }
        }

        private void temizleButon_Click(object sender, EventArgs e)
        {
            string mesaj = "Temizlemek İstediğinize Emin Misiniz?";
            string başlık = "Temizle";
            MessageBoxButtons butonlar = MessageBoxButtons.YesNo;
            DialogResult cevap;

            cevap = MessageBox.Show(mesaj, başlık, butonlar);
            if (cevap == System.Windows.Forms.DialogResult.Yes)
            {
                formTemizle();
                MessageBox.Show("Sayfa Temizlendi");
            }
        }

        private void anaYemek1CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            string itemText = anaYemek1CheckBox.Text + " - " + anaYemek1Fiyat;
            HandleCheckBoxChanged(anaYemek1CheckBox, siparisListbox, itemText, anaYemek1Fiyat);
        }

        private void anaYemek2CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            string itemText = anaYemek2CheckBox.Text + " - " + anaYemek2Fiyat;
            HandleCheckBoxChanged(anaYemek2CheckBox, siparisListbox, itemText, anaYemek2Fiyat);
        }

        private void anaYemek3CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            string itemText = anaYemek3CheckBox.Text + " - " + anaYemek3Fiyat;
            HandleCheckBoxChanged(anaYemek3CheckBox, siparisListbox, itemText, anaYemek3Fiyat);
        }

        private void anaYemek4CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            string itemText = anaYemek4CheckBox.Text + " - " + anaYemek4Fiyat;
            HandleCheckBoxChanged(anaYemek4CheckBox, siparisListbox, itemText, anaYemek4Fiyat);
        }

        private void anaYemek5CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            string itemText = anaYemek5CheckBox.Text + " - " + anaYemek5Fiyat;
            HandleCheckBoxChanged(anaYemek5CheckBox, siparisListbox, itemText, anaYemek5Fiyat);
        }

        private void anaYemek6CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            string itemText = anaYemek6CheckBox.Text + " - " + anaYemek6Fiyat;
            HandleCheckBoxChanged(anaYemek6CheckBox, siparisListbox, itemText, anaYemek6Fiyat);
        }

        private void icecek1CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            string itemText = icecek1CheckBox.Text + " - " + icecek1Fiyat;
            HandleCheckBoxChanged(icecek1CheckBox, siparisListbox, itemText, icecek1Fiyat);
        }

        private void icecek2CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            string itemText = icecek2CheckBox.Text + " - " + icecek2Fiyat;
            HandleCheckBoxChanged(icecek2CheckBox, siparisListbox, itemText, icecek2Fiyat);
        }

        private void icecek3CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            string itemText = icecek3CheckBox.Text + " - " + icecek3Fiyat;
            HandleCheckBoxChanged(icecek3CheckBox, siparisListbox, itemText, icecek3Fiyat);
        }

        private void icecek4CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            string itemText = icecek4CheckBox.Text + " - " + icecek4Fiyat;
            HandleCheckBoxChanged(icecek4CheckBox, siparisListbox, itemText, icecek4Fiyat);
        }

        private void icecek5CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            string itemText = icecek5CheckBox.Text + " - " + icecek5Fiyat;
            HandleCheckBoxChanged(icecek5CheckBox, siparisListbox, itemText, icecek5Fiyat);
        }

        private void icecek6CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            string itemText = icecek6CheckBox.Text + " - " + icecek6Fiyat;
            HandleCheckBoxChanged(icecek6CheckBox, siparisListbox, itemText, icecek6Fiyat);
        }

        private void ekstra1Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            string itemText = ekstra1Checkbox.Text + " - " + ekstra1Fiyat;
            HandleCheckBoxChanged(ekstra1Checkbox, siparisListbox, itemText, ekstra1Fiyat);
        }

        private void ekstra2Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            string itemText = ekstra2Checkbox.Text + " - " + ekstra2Fiyat;
            HandleCheckBoxChanged(ekstra2Checkbox, siparisListbox, itemText, ekstra2Fiyat);
        }

        private void ekstra3Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            string itemText = ekstra3Checkbox.Text + " - " + ekstra3Fiyat;
            HandleCheckBoxChanged(ekstra3Checkbox, siparisListbox, itemText, ekstra3Fiyat);
        }

        private void ekstra4Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            string itemText = ekstra4Checkbox.Text + " - " + ekstra4Fiyat;
            HandleCheckBoxChanged(ekstra4Checkbox, siparisListbox, itemText, ekstra4Fiyat);
        }

        private void ekstra5Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            string itemText = ekstra5Checkbox.Text + " - " + ekstra5Fiyat;
            HandleCheckBoxChanged(ekstra5Checkbox, siparisListbox, itemText, ekstra5Fiyat);
        }

        private void ekstra6Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            string itemText = ekstra6Checkbox.Text + " - " + ekstra6Fiyat;
            HandleCheckBoxChanged(ekstra6Checkbox, siparisListbox, itemText, ekstra6Fiyat);
        }
    }
}
