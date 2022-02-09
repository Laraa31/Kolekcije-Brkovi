namespace Kolekcij_Brkovi
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
            this.btnUnesi = new System.Windows.Forms.Button();
            this.btnObradi = new System.Windows.Forms.Button();
            this.btnIspiši = new System.Windows.Forms.Button();
            this.txtbIme = new System.Windows.Forms.TextBox();
            this.txtbPrezime = new System.Windows.Forms.TextBox();
            this.txtbGodina = new System.Windows.Forms.TextBox();
            this.combSpol = new System.Windows.Forms.ComboBox();
            this.rtbIspis = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(193, 12);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(131, 116);
            this.btnUnesi.TabIndex = 0;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // btnObradi
            // 
            this.btnObradi.Location = new System.Drawing.Point(330, 12);
            this.btnObradi.Name = "btnObradi";
            this.btnObradi.Size = new System.Drawing.Size(131, 116);
            this.btnObradi.TabIndex = 1;
            this.btnObradi.Text = "Obradi";
            this.btnObradi.UseVisualStyleBackColor = true;
            this.btnObradi.Click += new System.EventHandler(this.btnObradi_Click);
            // 
            // btnIspiši
            // 
            this.btnIspiši.Location = new System.Drawing.Point(468, 12);
            this.btnIspiši.Name = "btnIspiši";
            this.btnIspiši.Size = new System.Drawing.Size(126, 116);
            this.btnIspiši.TabIndex = 2;
            this.btnIspiši.Text = "Ispiši";
            this.btnIspiši.UseVisualStyleBackColor = true;
            this.btnIspiši.Click += new System.EventHandler(this.btnIspiši_Click);
            // 
            // txtbIme
            // 
            this.txtbIme.Location = new System.Drawing.Point(12, 12);
            this.txtbIme.Name = "txtbIme";
            this.txtbIme.Size = new System.Drawing.Size(162, 22);
            this.txtbIme.TabIndex = 3;
            // 
            // txtbPrezime
            // 
            this.txtbPrezime.Location = new System.Drawing.Point(13, 41);
            this.txtbPrezime.Name = "txtbPrezime";
            this.txtbPrezime.Size = new System.Drawing.Size(161, 22);
            this.txtbPrezime.TabIndex = 4;
            // 
            // txtbGodina
            // 
            this.txtbGodina.Location = new System.Drawing.Point(13, 70);
            this.txtbGodina.Name = "txtbGodina";
            this.txtbGodina.Size = new System.Drawing.Size(161, 22);
            this.txtbGodina.TabIndex = 5;
            // 
            // combSpol
            // 
            this.combSpol.FormattingEnabled = true;
            this.combSpol.Items.AddRange(new object[] {
            "M",
            "Ž"});
            this.combSpol.Location = new System.Drawing.Point(13, 99);
            this.combSpol.Name = "combSpol";
            this.combSpol.Size = new System.Drawing.Size(161, 24);
            this.combSpol.TabIndex = 6;
            // 
            // rtbIspis
            // 
            this.rtbIspis.Location = new System.Drawing.Point(13, 141);
            this.rtbIspis.Name = "rtbIspis";
            this.rtbIspis.Size = new System.Drawing.Size(581, 275);
            this.rtbIspis.TabIndex = 7;
            this.rtbIspis.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 450);
            this.Controls.Add(this.rtbIspis);
            this.Controls.Add(this.combSpol);
            this.Controls.Add(this.txtbGodina);
            this.Controls.Add(this.txtbPrezime);
            this.Controls.Add(this.txtbIme);
            this.Controls.Add(this.btnIspiši);
            this.Controls.Add(this.btnObradi);
            this.Controls.Add(this.btnUnesi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Button btnObradi;
        private System.Windows.Forms.Button btnIspiši;
        private System.Windows.Forms.TextBox txtbIme;
        private System.Windows.Forms.TextBox txtbPrezime;
        private System.Windows.Forms.TextBox txtbGodina;
        private System.Windows.Forms.ComboBox combSpol;
        private System.Windows.Forms.RichTextBox rtbIspis;
    }
}

