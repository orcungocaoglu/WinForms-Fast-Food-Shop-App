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
    public partial class siparisler : Form
    {
        private string filePath = Path.Combine(Application.StartupPath, "Data", "siparisler.json");
        private Dictionary<int, siparisData> siparisDict = new Dictionary<int, siparisData>();

        public siparisler()
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
                    siparisDict = JsonConvert.DeserializeObject<Dictionary<int, siparisData>>(json);

                    dataGridView1.DataSource = siparisDict.Values.ToList();
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
                string json = JsonConvert.SerializeObject(siparisDict, Formatting.Indented);
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


        private void silButon_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
                if (siparisDict.ContainsKey(id))
                {
                    siparisDict.Remove(id);
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
                int id = Convert.ToInt32(selectedRow.Cells["id"].Value);

                try
                {
                    var updatedData = new siparisData
                    {
                        id = id,
                        musteriAd = selectedRow.Cells["musteriAd"].Value.ToString(),
                        anaMenu = selectedRow.Cells["anaMenu"].Value.ToString(),
                        icecek = selectedRow.Cells["icecek"].Value.ToString(),
                        ekstralar = selectedRow.Cells["ekstralar"].Value.ToString(),
                        tutar = Convert.ToInt32(selectedRow.Cells["tutar"].Value),
                        not = selectedRow.Cells["not"].Value.ToString()
                    };

                    // Güncelleme
                    siparisDict[id] = updatedData;
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
