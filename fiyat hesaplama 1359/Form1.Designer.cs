namespace fiyat_hesaplama_1359
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTutar = new System.Windows.Forms.Label();
            this.lblİndirimliFiyat = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.rb10 = new System.Windows.Forms.RadioButton();
            this.rb15 = new System.Windows.Forms.RadioButton();
            this.rb25 = new System.Windows.Forms.RadioButton();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTutar.Location = new System.Drawing.Point(71, 61);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(55, 26);
            this.lblTutar.TabIndex = 0;
            this.lblTutar.Text = "tutar";
            // 
            // lblİndirimliFiyat
            // 
            this.lblİndirimliFiyat.AutoSize = true;
            this.lblİndirimliFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblİndirimliFiyat.Location = new System.Drawing.Point(71, 116);
            this.lblİndirimliFiyat.Name = "lblİndirimliFiyat";
            this.lblİndirimliFiyat.Size = new System.Drawing.Size(139, 26);
            this.lblİndirimliFiyat.TabIndex = 1;
            this.lblİndirimliFiyat.Text = "indirimli fiyat:";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(143, 61);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(100, 20);
            this.txtTutar.TabIndex = 2;
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyat.Location = new System.Drawing.Point(216, 120);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(135, 20);
            this.lblFiyat.TabIndex = 3;
            this.lblFiyat.Text = "______________";
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb5.Location = new System.Drawing.Point(76, 173);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(103, 24);
            this.rb5.TabIndex = 4;
            this.rb5.TabStop = true;
            this.rb5.Text = "% 5 indirim";
            this.rb5.UseVisualStyleBackColor = true;
            // 
            // rb10
            // 
            this.rb10.AutoSize = true;
            this.rb10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb10.Location = new System.Drawing.Point(76, 216);
            this.rb10.Name = "rb10";
            this.rb10.Size = new System.Drawing.Size(112, 24);
            this.rb10.TabIndex = 5;
            this.rb10.TabStop = true;
            this.rb10.Text = "% 10 indirim";
            this.rb10.UseVisualStyleBackColor = true;
            // 
            // rb15
            // 
            this.rb15.AutoSize = true;
            this.rb15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb15.Location = new System.Drawing.Point(76, 260);
            this.rb15.Name = "rb15";
            this.rb15.Size = new System.Drawing.Size(112, 24);
            this.rb15.TabIndex = 6;
            this.rb15.TabStop = true;
            this.rb15.Text = "% 15 indirim";
            this.rb15.UseVisualStyleBackColor = true;
            // 
            // rb25
            // 
            this.rb25.AutoSize = true;
            this.rb25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb25.Location = new System.Drawing.Point(76, 299);
            this.rb25.Name = "rb25";
            this.rb25.Size = new System.Drawing.Size(112, 24);
            this.rb25.TabIndex = 7;
            this.rb25.TabStop = true;
            this.rb25.Text = "% 25 indirim";
            this.rb25.UseVisualStyleBackColor = true;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(112, 345);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(131, 61);
            this.btnHesapla.TabIndex = 8;
            this.btnHesapla.Text = "hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.rb25);
            this.Controls.Add(this.rb15);
            this.Controls.Add(this.rb10);
            this.Controls.Add(this.rb5);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.lblİndirimliFiyat);
            this.Controls.Add(this.lblTutar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Label lblİndirimliFiyat;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.RadioButton rb5;
        private System.Windows.Forms.RadioButton rb10;
        private System.Windows.Forms.RadioButton rb15;
        private System.Windows.Forms.RadioButton rb25;
        private System.Windows.Forms.Button btnHesapla;
    }
}

