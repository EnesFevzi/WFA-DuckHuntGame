namespace WFA_DuckHuntGame
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
			this.components = new System.ComponentModel.Container();
			this.pnlUcusAlani = new System.Windows.Forms.Panel();
			this.flpAtisHakki = new System.Windows.Forms.FlowLayoutPanel();
			this.lblToplamOrdek = new System.Windows.Forms.Label();
			this.lblVurulanOrdek = new System.Windows.Forms.Label();
			this.lblToplamOrdekSayi = new System.Windows.Forms.Label();
			this.lblVurulanOrdekSayi = new System.Windows.Forms.Label();
			this.tmrYatay = new System.Windows.Forms.Timer(this.components);
			this.tmrDikey = new System.Windows.Forms.Timer(this.components);
			this.tmrOluOrdek = new System.Windows.Forms.Timer(this.components);
			this.tmrKopekCikis = new System.Windows.Forms.Timer(this.components);
			this.tmrKopekGiris = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// pnlUcusAlani
			// 
			this.pnlUcusAlani.BackColor = System.Drawing.Color.Transparent;
			this.pnlUcusAlani.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlUcusAlani.Location = new System.Drawing.Point(0, 0);
			this.pnlUcusAlani.Name = "pnlUcusAlani";
			this.pnlUcusAlani.Size = new System.Drawing.Size(917, 404);
			this.pnlUcusAlani.TabIndex = 0;
			this.pnlUcusAlani.Click += new System.EventHandler(this.pnlUcusAlani_Click);
			// 
			// flpAtisHakki
			// 
			this.flpAtisHakki.BackColor = System.Drawing.Color.Transparent;
			this.flpAtisHakki.Location = new System.Drawing.Point(12, 470);
			this.flpAtisHakki.Name = "flpAtisHakki";
			this.flpAtisHakki.Size = new System.Drawing.Size(200, 72);
			this.flpAtisHakki.TabIndex = 1;
			// 
			// lblToplamOrdek
			// 
			this.lblToplamOrdek.AutoSize = true;
			this.lblToplamOrdek.BackColor = System.Drawing.Color.Transparent;
			this.lblToplamOrdek.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblToplamOrdek.Location = new System.Drawing.Point(719, 470);
			this.lblToplamOrdek.Name = "lblToplamOrdek";
			this.lblToplamOrdek.Size = new System.Drawing.Size(149, 24);
			this.lblToplamOrdek.TabIndex = 2;
			this.lblToplamOrdek.Text = "Toplam Ördek:";
			// 
			// lblVurulanOrdek
			// 
			this.lblVurulanOrdek.AutoSize = true;
			this.lblVurulanOrdek.BackColor = System.Drawing.Color.Transparent;
			this.lblVurulanOrdek.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblVurulanOrdek.Location = new System.Drawing.Point(719, 505);
			this.lblVurulanOrdek.Name = "lblVurulanOrdek";
			this.lblVurulanOrdek.Size = new System.Drawing.Size(152, 24);
			this.lblVurulanOrdek.TabIndex = 2;
			this.lblVurulanOrdek.Text = "Vurulan Ördek:";
			// 
			// lblToplamOrdekSayi
			// 
			this.lblToplamOrdekSayi.AutoSize = true;
			this.lblToplamOrdekSayi.BackColor = System.Drawing.Color.Transparent;
			this.lblToplamOrdekSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblToplamOrdekSayi.Location = new System.Drawing.Point(871, 470);
			this.lblToplamOrdekSayi.Name = "lblToplamOrdekSayi";
			this.lblToplamOrdekSayi.Size = new System.Drawing.Size(21, 24);
			this.lblToplamOrdekSayi.TabIndex = 2;
			this.lblToplamOrdekSayi.Text = "0";
			// 
			// lblVurulanOrdekSayi
			// 
			this.lblVurulanOrdekSayi.AutoSize = true;
			this.lblVurulanOrdekSayi.BackColor = System.Drawing.Color.Transparent;
			this.lblVurulanOrdekSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblVurulanOrdekSayi.Location = new System.Drawing.Point(871, 505);
			this.lblVurulanOrdekSayi.Name = "lblVurulanOrdekSayi";
			this.lblVurulanOrdekSayi.Size = new System.Drawing.Size(21, 24);
			this.lblVurulanOrdekSayi.TabIndex = 2;
			this.lblVurulanOrdekSayi.Text = "0";
			// 
			// tmrYatay
			// 
			this.tmrYatay.Interval = 10;
			this.tmrYatay.Tick += new System.EventHandler(this.tmrYatay_Tick);
			// 
			// tmrDikey
			// 
			this.tmrDikey.Interval = 10;
			this.tmrDikey.Tick += new System.EventHandler(this.tmrDikey_Tick);
			// 
			// tmrOluOrdek
			// 
			this.tmrOluOrdek.Interval = 10;
			this.tmrOluOrdek.Tick += new System.EventHandler(this.tmrOluOrdek_Tick);
			// 
			// tmrKopekCikis
			// 
			this.tmrKopekCikis.Interval = 10;
			this.tmrKopekCikis.Tick += new System.EventHandler(this.tmrKopekCikis_Tick);
			// 
			// tmrKopekGiris
			// 
			this.tmrKopekGiris.Interval = 10;
			this.tmrKopekGiris.Tick += new System.EventHandler(this.tmrKopekGiris_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::WFA_DuckHuntGame.Properties.Resources.stage;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(917, 554);
			this.Controls.Add(this.lblVurulanOrdekSayi);
			this.Controls.Add(this.lblVurulanOrdek);
			this.Controls.Add(this.lblToplamOrdekSayi);
			this.Controls.Add(this.lblToplamOrdek);
			this.Controls.Add(this.flpAtisHakki);
			this.Controls.Add(this.pnlUcusAlani);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel pnlUcusAlani;
		private System.Windows.Forms.FlowLayoutPanel flpAtisHakki;
		private System.Windows.Forms.Label lblToplamOrdek;
		private System.Windows.Forms.Label lblVurulanOrdek;
		private System.Windows.Forms.Label lblToplamOrdekSayi;
		private System.Windows.Forms.Label lblVurulanOrdekSayi;
		private System.Windows.Forms.Timer tmrYatay;
		private System.Windows.Forms.Timer tmrDikey;
		private System.Windows.Forms.Timer tmrOluOrdek;
		private System.Windows.Forms.Timer tmrKopekCikis;
		private System.Windows.Forms.Timer tmrKopekGiris;
	}
}

