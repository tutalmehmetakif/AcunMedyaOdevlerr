using CustomAttributeOdev.Classes;

namespace CustomAttributeOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDogrula_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci
            {
                Ad = txtAd.Text.Trim(),
                Soyad = txtSoyad.Text.Trim(),
                Bolum = txtBolum.Text.Trim()
            };

            bool hataVar = false;
            var props = typeof(Ogrenci).GetProperties();

            foreach (var prop in props)
            {
                var attr = prop.GetCustomAttributes(typeof(ZorunluAlanAttribute), false)
                               .FirstOrDefault() as ZorunluAlanAttribute;

                if (attr != null)
                {
                    var value = prop.GetValue(ogr) as string;
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        MessageBox.Show(attr.HataMesajý, "Doðrulama Hatasý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        hataVar = true;
                        break;
                    }
                }
            }

            if (!hataVar)
            {
                lblSonuc.Text = $"Ad: {ogr.Ad}, Soyad: {ogr.Soyad}, Bölüm: {ogr.Bolum}";
                lblSonuc.ForeColor = Color.DarkGreen;
            }
        }
    }
}
