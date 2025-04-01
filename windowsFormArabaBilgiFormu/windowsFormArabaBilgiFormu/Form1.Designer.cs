namespace windowsFormArabaBilgiFormu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMarka = new Label();
            lblModel = new Label();
            lblColor = new Label();
            lblKapiSayisi = new Label();
            lblPencereSayisi = new Label();
            label1 = new Label();
            txtMarka = new TextBox();
            txtModel = new TextBox();
            txtRenk = new TextBox();
            txtKapiSayisi = new TextBox();
            txtPencereSayisi = new TextBox();
            txtTüketilenLitre = new TextBox();
            btnBilgileriGoster = new Button();
            lblBilgi = new Label();
            SuspendLayout();
            // 
            // lblMarka
            // 
            lblMarka.AutoSize = true;
            lblMarka.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblMarka.Location = new Point(28, 24);
            lblMarka.Name = "lblMarka";
            lblMarka.Size = new Size(101, 38);
            lblMarka.TabIndex = 0;
            lblMarka.Text = "Marka";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblModel.Location = new Point(28, 89);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(101, 38);
            lblModel.TabIndex = 1;
            lblModel.Text = "Model";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblColor.Location = new Point(28, 154);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(82, 38);
            lblColor.TabIndex = 2;
            lblColor.Text = "Renk";
            // 
            // lblKapiSayisi
            // 
            lblKapiSayisi.AutoSize = true;
            lblKapiSayisi.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblKapiSayisi.Location = new Point(28, 222);
            lblKapiSayisi.Name = "lblKapiSayisi";
            lblKapiSayisi.Size = new Size(157, 38);
            lblKapiSayisi.TabIndex = 3;
            lblKapiSayisi.Text = "Kapı Sayısı";
            // 
            // lblPencereSayisi
            // 
            lblPencereSayisi.AutoSize = true;
            lblPencereSayisi.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPencereSayisi.Location = new Point(28, 282);
            lblPencereSayisi.Name = "lblPencereSayisi";
            lblPencereSayisi.Size = new Size(201, 38);
            lblPencereSayisi.TabIndex = 4;
            lblPencereSayisi.Text = "Pencere Sayısı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(28, 342);
            label1.Name = "label1";
            label1.Size = new Size(316, 38);
            label1.TabIndex = 5;
            label1.Text = "100 Km'de yaktığı litre";
            // 
            // txtMarka
            // 
            txtMarka.Location = new Point(372, 35);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(222, 27);
            txtMarka.TabIndex = 6;
            txtMarka.TextChanged += textBox1_TextChanged;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(372, 100);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(222, 27);
            txtModel.TabIndex = 7;
            // 
            // txtRenk
            // 
            txtRenk.Location = new Point(372, 165);
            txtRenk.Name = "txtRenk";
            txtRenk.Size = new Size(222, 27);
            txtRenk.TabIndex = 8;
            // 
            // txtKapiSayisi
            // 
            txtKapiSayisi.Location = new Point(372, 233);
            txtKapiSayisi.Name = "txtKapiSayisi";
            txtKapiSayisi.Size = new Size(222, 27);
            txtKapiSayisi.TabIndex = 9;
            // 
            // txtPencereSayisi
            // 
            txtPencereSayisi.Location = new Point(372, 293);
            txtPencereSayisi.Name = "txtPencereSayisi";
            txtPencereSayisi.Size = new Size(222, 27);
            txtPencereSayisi.TabIndex = 10;
            // 
            // txtTüketilenLitre
            // 
            txtTüketilenLitre.Location = new Point(372, 353);
            txtTüketilenLitre.Name = "txtTüketilenLitre";
            txtTüketilenLitre.Size = new Size(222, 27);
            txtTüketilenLitre.TabIndex = 11;
            // 
            // btnBilgileriGoster
            // 
            btnBilgileriGoster.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnBilgileriGoster.Location = new Point(393, 398);
            btnBilgileriGoster.Name = "btnBilgileriGoster";
            btnBilgileriGoster.Size = new Size(201, 54);
            btnBilgileriGoster.TabIndex = 12;
            btnBilgileriGoster.Text = "Bilgileri Göster";
            btnBilgileriGoster.UseVisualStyleBackColor = true;
            btnBilgileriGoster.Click += btnBilgileriGoster_Click;
            // 
            // lblBilgi
            // 
            lblBilgi.AutoSize = true;
            lblBilgi.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBilgi.Location = new Point(31, 398);
            lblBilgi.Name = "lblBilgi";
            lblBilgi.Size = new Size(79, 31);
            lblBilgi.TabIndex = 13;
            lblBilgi.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 634);
            Controls.Add(lblBilgi);
            Controls.Add(btnBilgileriGoster);
            Controls.Add(txtTüketilenLitre);
            Controls.Add(txtPencereSayisi);
            Controls.Add(txtKapiSayisi);
            Controls.Add(txtRenk);
            Controls.Add(txtModel);
            Controls.Add(txtMarka);
            Controls.Add(label1);
            Controls.Add(lblPencereSayisi);
            Controls.Add(lblKapiSayisi);
            Controls.Add(lblColor);
            Controls.Add(lblModel);
            Controls.Add(lblMarka);
            Name = "Form1";
            Text = "Araba Bilgi Formu";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMarka;
        private Label lblModel;
        private Label lblColor;
        private Label lblKapiSayisi;
        private Label lblPencereSayisi;
        private Label label1;
        private TextBox txtMarka;
        private TextBox txtModel;
        private TextBox txtRenk;
        private TextBox txtKapiSayisi;
        private TextBox txtPencereSayisi;
        private TextBox txtTüketilenLitre;
        private Button btnBilgileriGoster;
        private Label lblBilgi;
    }
}
