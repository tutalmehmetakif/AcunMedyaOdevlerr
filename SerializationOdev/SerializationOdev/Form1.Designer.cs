namespace SerializationOdev
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
            btnJsonOku = new Button();
            lstUrunler = new ListBox();
            SuspendLayout();
            // 
            // btnJsonOku
            // 
            btnJsonOku.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnJsonOku.Location = new Point(278, 246);
            btnJsonOku.Name = "btnJsonOku";
            btnJsonOku.Size = new Size(176, 57);
            btnJsonOku.TabIndex = 0;
            btnJsonOku.Text = "JsonOku";
            btnJsonOku.UseVisualStyleBackColor = true;
            btnJsonOku.Click += btnJsonOku_Click;
            // 
            // lstUrunler
            // 
            lstUrunler.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lstUrunler.FormattingEnabled = true;
            lstUrunler.ItemHeight = 25;
            lstUrunler.Location = new Point(113, 28);
            lstUrunler.Name = "lstUrunler";
            lstUrunler.Size = new Size(511, 179);
            lstUrunler.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstUrunler);
            Controls.Add(btnJsonOku);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnJsonOku;
        private ListBox lstUrunler;
    }
}
