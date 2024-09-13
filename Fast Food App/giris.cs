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
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp3
{

    public partial class giris : Form
    {
        public giris()
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


        private void kayitButon_Click(object sender, EventArgs e)
        {
            new kontrol().Show();
            this.Hide();
        }

        private void girisButon_Click(object sender, EventArgs e)
        {
            string girilenAd = adTextbox.Text;
            string girilenSifre = sifreTextbox.Text;

            // ad şifre kontrolü
            var user = personellerDict.Values.FirstOrDefault(u => u.kullaniciAdi == girilenAd && u.sifre == girilenSifre);
            if (user != null)
            {
                MessageBox.Show("Giriş başarılı!");
                new anaSayfa().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
            }
        }
    }
}
