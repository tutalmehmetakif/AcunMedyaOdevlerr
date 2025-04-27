using System.Reflection;

namespace ReflectionIleOdemeSıstemiOdev2Kısım
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Form yüklendiğinde çalışacak metod
        private void Form1_Load(object sender, EventArgs e)
        {
            // Mevcut assembly'deki (uygulama derlemesindeki) tüm tipleri al
            // Sadece IOdemeYontemi arayüzünü uygulayan ve arayüz olmayan sınıfları seç
            var odemeYontemleri = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => t.GetInterfaces().Contains(typeof(IOdemeYontemi)) && !t.IsInterface)
                .ToList();

            // Bulunan ödeme yöntemlerini combobox'a ekle
            foreach (var yontem in odemeYontemleri)
            {
                cmbOdemeYontemi.Items.Add(yontem.Name);
            }

            // Eğer ödeme yöntemi bulunduysa ilkini seçili yap
            if (cmbOdemeYontemi.Items.Count > 0)
            {
                cmbOdemeYontemi.SelectedIndex = 0;
            }
        }

        // Ödeme butonuna tıklandığında çalışacak metod
        private void btnOde_Click(object sender, EventArgs e)
        {
            // Kullanıcının girdiği tutarı kontrol et
            // Geçerli bir decimal değilse veya 0'dan küçükse hata ver
            if (!decimal.TryParse(txtTutar.Text, out decimal tutar) || tutar <= 0)
            {
                lblSonuc.Text = "Lütfen geçerli bir tutar giriniz!";
                lblSonuc.ForeColor = Color.Red; // Hata mesajını kırmızı yap
                return;
            }

            // Kullanıcı bir ödeme yöntemi seçmiş mi kontrol et
            if (cmbOdemeYontemi.SelectedItem == null)
            {
                lblSonuc.Text = "Lütfen bir ödeme yöntemi seçiniz!";
                lblSonuc.ForeColor = Color.Red;
                return;
            }

            try
            {
                // Seçilen ödeme yönteminin class adını al
                string className = cmbOdemeYontemi.SelectedItem.ToString();

                // Assembly içinde bu isimde ve IOdemeYontemi arayüzünü uygulayan bir sınıf ara
                Type paymentType = Assembly.GetExecutingAssembly()
                    .GetTypes()
                    .FirstOrDefault(t => t.Name == className && t.GetInterfaces().Contains(typeof(IOdemeYontemi)));

                if (paymentType != null)
                {
                    // Reflection ile ödeme yöntemi nesnesi oluştur
                    IOdemeYontemi odemeYontemi = (IOdemeYontemi)Activator.CreateInstance(paymentType);

                    // Ödeme işlemini gerçekleştir ve sonucu al
                    string sonuc = odemeYontemi.Ode(tutar);
                    lblSonuc.Text = sonuc;
                   
                }
                else
                {
                    lblSonuc.Text = "Ödeme yöntemi bulunamadı!";
                    lblSonuc.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                // Beklenmeyen bir hata oluşursa kullanıcıya göster
                lblSonuc.Text = $"Hata oluştu: {ex.Message}";
                lblSonuc.ForeColor = Color.Red;
            }
        }
    }
}