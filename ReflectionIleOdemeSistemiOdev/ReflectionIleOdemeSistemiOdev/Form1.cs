namespace ReflectionIleOdemeSistemiOdev
{
    using System.IO; // Dosya işlemleri için System.IO kütüphanesini kullandım.

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }

        private void Tara_Click(object sender, EventArgs e)
        {
            // Klasör seçmek için FolderBrowserDialog kullandım.
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                // Eğer kullanıcı bir klasör seçerse devam edeceğim
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    // Seçilen klasörün tam yolunu aldım
                    string anaKlasor = fbd.SelectedPath;

                    // Önce ListBox'ı temizliyorum ki eski veriler kalmasın
                    listBox1.Items.Clear();

                    // Ana klasörün içindeki tüm klasörleri buluyorum
                    string[] klasorler = Directory.GetDirectories(anaKlasor);

                    foreach (string klasor in klasorler)
                    {
                        // Klasörün sadece adını aldım (yol değil)
                        string klasorAdi = Path.GetFileName(klasor);

                        // ListBox'a klasör adını 📁 ikonu ile ekledim
                        listBox1.Items.Add("📁 " + klasorAdi);

                        // Klasördeki tüm .cs uzantılı dosyaları buluyorum
                        string[] csDosyalari = Directory.GetFiles(klasor, "*.cs");

                        foreach (string csDosya in csDosyalari)
                        {
                            // Her .cs dosyasının içeriğini satır satır okuyorum
                            string[] satirlar = File.ReadAllLines(csDosya);

                            foreach (string satir in satirlar)
                            {
                                // Eğer satırda "class " kelimesi geçiyorsa, o satırı işliyorum
                                if (satir.Contains("class "))
                                {
                                    // Satırın başındaki boşlukları temizliyorum
                                    string temizSatir = satir.Trim();

                                    // Satırı boşluklardan ayırıyorum
                                    string[] kelimeler = temizSatir.Split(' ');

                                    // "class" kelimesinin hangi indekste olduğunu buluyorum
                                    int classIndex = Array.IndexOf(kelimeler, "class");

                                    // Eğer "class" kelimesinden sonra bir şeyler varsa class adını alıyorum
                                    if (classIndex != -1 && classIndex < kelimeler.Length - 1)
                                    {
                                        string classAdi = kelimeler[classIndex + 1];

                                        // ListBox'a girintili şekilde class adını 📄 ikonu ile ekliyorum
                                        listBox1.Items.Add("   📄 " + classAdi);
                                    }
                                }
                            }
                        }
                    }
                }

            }
        }
    }
}
