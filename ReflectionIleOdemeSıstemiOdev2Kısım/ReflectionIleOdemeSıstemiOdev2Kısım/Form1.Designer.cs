﻿namespace ReflectionIleOdemeSıstemiOdev2Kısım
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
            cmbOdemeYontemi = new ComboBox();
            txtTutar = new TextBox();
            btnOde = new Button();
            lblSonuc = new Label();
            lblOdemeYontemi = new Label();
            lblTutar = new Label();
            SuspendLayout();
            // 
            // cmbOdemeYontemi
            // 
            cmbOdemeYontemi.FormattingEnabled = true;
            cmbOdemeYontemi.Location = new Point(265, 83);
            cmbOdemeYontemi.Name = "cmbOdemeYontemi";
            cmbOdemeYontemi.Size = new Size(163, 23);
            cmbOdemeYontemi.TabIndex = 0;
            // 
            // txtTutar
            // 
            txtTutar.Location = new Point(265, 131);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(163, 23);
            txtTutar.TabIndex = 1;
            // 
            // btnOde
            // 
            btnOde.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnOde.Location = new Point(291, 175);
            btnOde.Name = "btnOde";
            btnOde.Size = new Size(115, 34);
            btnOde.TabIndex = 2;
            btnOde.Text = "Ödeme İşlemi";
            btnOde.UseVisualStyleBackColor = true;
            btnOde.Click += btnOde_Click;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(332, 248);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(38, 15);
            lblSonuc.TabIndex = 3;
            lblSonuc.Text = "label1";
            // 
            // lblOdemeYontemi
            // 
            lblOdemeYontemi.AutoSize = true;
            lblOdemeYontemi.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblOdemeYontemi.Location = new Point(121, 85);
            lblOdemeYontemi.Name = "lblOdemeYontemi";
            lblOdemeYontemi.Size = new Size(128, 21);
            lblOdemeYontemi.TabIndex = 4;
            lblOdemeYontemi.Text = "Ödeme Yöntemi";
            // 
            // lblTutar
            // 
            lblTutar.AutoSize = true;
            lblTutar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTutar.Location = new Point(121, 129);
            lblTutar.Name = "lblTutar";
            lblTutar.Size = new Size(47, 21);
            lblTutar.TabIndex = 5;
            lblTutar.Text = "Tutar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTutar);
            Controls.Add(lblOdemeYontemi);
            Controls.Add(lblSonuc);
            Controls.Add(btnOde);
            Controls.Add(txtTutar);
            Controls.Add(cmbOdemeYontemi);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbOdemeYontemi;
        private TextBox txtTutar;
        private Button btnOde;
        private Label lblSonuc;
        private Label lblOdemeYontemi;
        private Label lblTutar;
    }
}
