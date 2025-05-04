namespace CustomAttributeOdev
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
            txtAd = new TextBox();
            lblAd = new Label();
            lblSoyad = new Label();
            lblSonuc = new Label();
            lblBolum = new Label();
            txtSoyad = new TextBox();
            txtBolum = new TextBox();
            btnDogrula = new Button();
            SuspendLayout();
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            txtAd.Location = new Point(324, 79);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(145, 33);
            txtAd.TabIndex = 0;
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblAd.Location = new Point(181, 87);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(36, 25);
            lblAd.TabIndex = 1;
            lblAd.Text = "Ad";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblSoyad.Location = new Point(181, 127);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(64, 25);
            lblSoyad.TabIndex = 2;
            lblSoyad.Text = "Soyad";
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSonuc.Location = new Point(181, 259);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(71, 30);
            lblSonuc.TabIndex = 4;
            lblSonuc.Text = "Sonuç";
            // 
            // lblBolum
            // 
            lblBolum.AutoSize = true;
            lblBolum.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblBolum.Location = new Point(178, 163);
            lblBolum.Name = "lblBolum";
            lblBolum.Size = new Size(67, 25);
            lblBolum.TabIndex = 3;
            lblBolum.Text = "Bölüm";
            // 
            // txtSoyad
            // 
            txtSoyad.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            txtSoyad.Location = new Point(324, 119);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(145, 33);
            txtSoyad.TabIndex = 5;
            // 
            // txtBolum
            // 
            txtBolum.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            txtBolum.Location = new Point(324, 155);
            txtBolum.Name = "txtBolum";
            txtBolum.Size = new Size(145, 33);
            txtBolum.TabIndex = 6;
            // 
            // btnDogrula
            // 
            btnDogrula.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDogrula.Location = new Point(298, 208);
            btnDogrula.Name = "btnDogrula";
            btnDogrula.Size = new Size(144, 33);
            btnDogrula.TabIndex = 7;
            btnDogrula.Text = "Doğrula";
            btnDogrula.UseVisualStyleBackColor = true;
            btnDogrula.Click += btnDogrula_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDogrula);
            Controls.Add(txtBolum);
            Controls.Add(txtSoyad);
            Controls.Add(lblSonuc);
            Controls.Add(lblBolum);
            Controls.Add(lblSoyad);
            Controls.Add(lblAd);
            Controls.Add(txtAd);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAd;
        private Label lblAd;
        private Label lblSoyad;
        private Label lblSonuc;
        private Label lblBolum;
        private TextBox txtSoyad;
        private TextBox txtBolum;
        private Button btnDogrula;
    }
}
