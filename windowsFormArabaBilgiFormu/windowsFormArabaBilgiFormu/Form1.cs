namespace windowsFormArabaBilgiFormu
{
    public partial class Form1 : Form
    {
        string marka = "";
        string model = "";
        string renk = "";
        string kapiSayisi = "";
        string pencereSayisi = "";
        string t�ketilenYakit = "";
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
            t�ketilenYakit = txtT�ketilenLitre.Text;

            lblBilgi.Text = "Araban�n�z�n Markas�: " + marka + " \nAraban�z�n Modeli: " + model +
                " \nAraban�z�n Rengi: " + renk + " \nAraban�z�n�n Kap� Say�s�: " + kapiSayisi + " \nAraban�z�n Pencere Say�s�: " + pencereSayisi + " \nAraban�n�z�n T�ketti�i Yak�t: " + t�ketilenYakit;
        }
    }
}
