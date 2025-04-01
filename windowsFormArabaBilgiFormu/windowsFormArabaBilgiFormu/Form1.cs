namespace windowsFormArabaBilgiFormu
{
    public partial class Form1 : Form
    {
        string marka = "";
        string model = "";
        string renk = "";
        string kapiSayisi = "";
        string pencereSayisi = "";
        string tüketilenYakit = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           


        }

        private void btnBilgileriGoster_Click(object sender, EventArgs e)
        {
            marka = txtMarka.Text;
            model = txtModel.Text;
            renk = txtRenk.Text;
            kapiSayisi = txtKapiSayisi.Text;
            pencereSayisi = txtPencereSayisi.Text;
            tüketilenYakit = txtTüketilenLitre.Text;

            lblBilgi.Text = "Arabanýnýzýn Markasý: " + marka + " \nArabanýzýn Modeli: " + model +
                " \nArabanýzýn Rengi: " + renk + " \nArabanýzýnýn Kapý Sayýsý: " + kapiSayisi + " \nArabanýzýn Pencere Sayýsý: " + pencereSayisi + " \nArabanýnýzýn Tükettiði Yakýt: " + tüketilenYakit;
        }
    }
}
