using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
using System.Threading;
using Newtonsoft.Json;


namespace SerializationOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJsonOku_Click(object sender, EventArgs e)
        {

            try
            {             
                string dosyaYolu = @"C:\Users\MONSTER\Desktop\AcunMedyaAkademi\SerializationOdev\SerializationOdev\urunler.json";
;

                
                string jsonText = File.ReadAllText(dosyaYolu);

                
                List<Product> urunler = JsonConvert.DeserializeObject<List<Product>>(jsonText);

                
                lstUrunler.Items.Clear();
                foreach (Product p in urunler)
                {
                    lstUrunler.Items.Add($"{p.UrunAdi} - {p.Fiyat} TL");
                }

                MessageBox.Show("JSON okuma ve gösterme tamamlandý!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluþtu: " + ex.Message);
            }


        
        }
    }
}
