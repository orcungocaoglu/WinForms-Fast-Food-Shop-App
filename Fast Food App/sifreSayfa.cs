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
    public partial class sifreSayfa : Form
    {
        public sifreSayfa()
        {
            InitializeComponent();
            LoadUsers();
        }

        // directory
        private string filePath = Path.Combine(Application.StartupPath, "Data", "personeller.json");
        // dictionarye kaydetme
        private Dictionary<int, personelData> personellerDict = new Dictionary<int, personelData>();

        private void LoadUsers()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    personellerDict = JsonConvert.DeserializeObject<Dictionary<int, personelData>>(json);
                }
                else
                {
                    MessageBox.Show("Kullanıcı bilgileri dosyası bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kullanıcı bilgileri yüklenemedi: " + ex.Message);
            }
        }

        private void gonderButon_Click(object sender, EventArgs e)
        {
            string girilenEPosta = ePostaTextbox.Text;

            var user = personellerDict.Values.FirstOrDefault(u => u.ePosta == girilenEPosta);
            if (user != null)
            {
                MessageBox.Show("E-Postanız sistemde bulunmakta.");
            }
            else
            {
                MessageBox.Show("E-Postanız sistemde bulunamadı.");
            }
        }
    }
}