using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class personeller : Form
    {
        private string filePath = Path.Combine(Application.StartupPath, "Data", "personeller.json");
        private Dictionary<int, personelData> personellerDict = new Dictionary<int, personelData>();

        public personeller()
        {
            InitializeComponent();
            veriYukle();
        }

        private void veriYukle()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    personellerDict = JsonConvert.DeserializeObject<Dictionary<int, personelData>>(json);

                    dataGridView1.DataSource = personellerDict.Values.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken bir hata oluştu: " + ex.Message);
            }
        }


        private void veriKaydet()
        {
            try
            {
                string json = JsonConvert.SerializeObject(personellerDict, Formatting.Indented);
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dosyaya yazarken bir hata oluştu: " + ex.Message);
            }
        }

        private void geriDonButon_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void silButon_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["personelId"].Value);
                if (personellerDict.ContainsKey(id))
                {
                    personellerDict.Remove(id);
                    veriKaydet();
                    veriYukle();
                }
            }
        }

        private void guncelleButon_Click(object sender, EventArgs e)
        {
            veriYukle();
        }

        private void veriKaydetButon_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["personelId"].Value);

                try
                {
                    var updatedData = new personelData
                    {
                        // Güncel Veriyi Çekme
                        personelID = id,
                        kullaniciAdi = selectedRow.Cells["kullaniciAdi"].Value.ToString(),
                        sifre = selectedRow.Cells["sifre"].Value.ToString(),
                        ePosta = selectedRow.Cells["Posta"].Value.ToString()
                    };

                    // Güncelleme
                    personellerDict[id] = updatedData;
                    veriKaydet();
                    veriYukle();

                    MessageBox.Show("Veri başarıyla güncellendi.");
                }
                catch (Exception aa)
                {
                    MessageBox.Show("Hata: " + aa.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek için bir satır seçin.");
            }
        }
    }
}
