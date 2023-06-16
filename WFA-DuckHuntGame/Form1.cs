using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_DuckHuntGame
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		Random random = new Random();
		PictureBox pbOrdek;
		PictureBox pbKopek = new PictureBox();
		int atisHakki = 3;
		int toplamOrdekSayisi;
		int vurulanOrdekSayisi;



		private void Form1_Load(object sender, EventArgs e)
		{
			AtisHakkiDoldur();
			SesCal(WFA_DuckHuntGame.Properties.Resources.intro);
			pbKopek.Image = WFA_DuckHuntGame.Properties.Resources._2;
			pbKopek.Width = 120;
			pbKopek.Height = 90;
			pbKopek.SizeMode = PictureBoxSizeMode.StretchImage;
			pbKopek.Top = pnlUcusAlani.Height;
			pbKopek.Left = (pnlUcusAlani.Width / 2) - (pbKopek.Width / 2);



			pnlUcusAlani.Controls.Add(pbKopek);

			pbOrdek = new PictureBox();
			pbOrdek.Image = WFA_DuckHuntGame.Properties.Resources.pngegg__1_;
			pbOrdek.Width = 120;
			pbOrdek.Height = 80;
			pbOrdek.Click += PbOrdek_Click;



			pbOrdek.SizeMode = PictureBoxSizeMode.StretchImage;
			pnlUcusAlani.Controls.Add(pbOrdek);
			tmrYatay.Start();
			tmrDikey.Start();
		}

		private void AtisHakkiDoldur()
		{
			flpAtisHakki.Controls.Clear();
			for (int i = 0; i < atisHakki; i++)
			{
				PictureBox picturebox = new PictureBox();
				picturebox.Width = 35;
				picturebox.Height = 70;

				picturebox.Image = WFA_DuckHuntGame.Properties.Resources.bullet_gun_bullet_pointed_images_3;
				picturebox.SizeMode = PictureBoxSizeMode.StretchImage;

				flpAtisHakki.Controls.Add(picturebox);
			}
		}

		private void PbOrdek_Click(object sender, EventArgs e)
		{

			tmrDikey.Stop();
			tmrYatay.Stop();
			AtisHakkiAzalt();
			

			if (Convert.ToBoolean(pbOrdek.Tag))
			{
				pbOrdek.Image = WFA_DuckHuntGame.Properties.Resources.pngegg__1___3_;
			}
			else
			{
				pbOrdek.Image = WFA_DuckHuntGame.Properties.Resources.pngegg__1___2_;
			}

			tmrOluOrdek.Start();
			vurulanOrdekSayisi++;
			lblVurulanOrdekSayi.Text=vurulanOrdekSayisi.ToString();


		}

		private void AtisHakkiAzalt()
		{
			atisHakki--;
			flpAtisHakki.Controls.RemoveAt(flpAtisHakki.Controls.Count - 1);
			if (atisHakki==0)
			{
				MessageBox.Show("Merminiz Kalmamıştır", "DUCK HUNT");
				Application.Exit();
			}
		}

		int yatayHiz = 5;

		private void tmrYatay_Tick(object sender, EventArgs e)
		{
			if (pbOrdek.Right >= pnlUcusAlani.Width)
			{
				pbOrdek.Tag = false;
				pbOrdek.Image = WFA_DuckHuntGame.Properties.Resources.pngegg__1___1_;
				yatayHiz = -5;
			}
			else if (pbOrdek.Left <= 0)
			{
				pbOrdek.Tag = true;
				pbOrdek.Image = WFA_DuckHuntGame.Properties.Resources.pngegg__1_;
				yatayHiz = 5;
			}
			pbOrdek.Left += yatayHiz;

		}
		int dikeyHiz = 5;
		private void tmrDikey_Tick(object sender, EventArgs e)
		{
			if (pbOrdek.Bottom >= pnlUcusAlani.Height)
			{
				dikeyHiz = -5;
			}
			else if (pbOrdek.Top <= 0)
			{
				dikeyHiz = 5;
			}
			pbOrdek.Top += dikeyHiz;
		}
		void SesCal(Stream ses)
		{
			SoundPlayer soundPlayer = new SoundPlayer();
			soundPlayer.Stream = ses;
			soundPlayer.Play();
		}

		private void pnlUcusAlani_Click(object sender, EventArgs e)
		{
			AtisHakkiAzalt();
		}

		private void tmrOluOrdek_Tick(object sender, EventArgs e)
		{
			pbOrdek.Top += 5;
			if (pbOrdek.Top >= pnlUcusAlani.Height)
			{
				tmrOluOrdek.Stop();
				tmrKopekCikis.Start();
			}
			else
			{
				pbOrdek.Top += 5;
			}
		}

		private void tmrKopekCikis_Tick(object sender, EventArgs e)
		{
			if (pbKopek.Bottom >= pnlUcusAlani.Height)
			{
				pbKopek.Top -= 5;
			}
			else
			{
				tmrKopekCikis.Stop();
				System.Threading.Thread.Sleep(2000);
				atisHakki = 3;
				AtisHakkiDoldur();
				tmrKopekGiris.Start();
				toplamOrdekSayisi++;
				lblToplamOrdekSayi.Text = toplamOrdekSayisi.ToString();
			}
		}

		private void tmrKopekGiris_Tick(object sender, EventArgs e)
		{
			if (pbKopek.Top <= pnlUcusAlani.Height)
			{
				pbKopek.Top += 5;
			}
			else
			{
				tmrKopekGiris.Stop();

				pbOrdek.Top = random.Next(0, pnlUcusAlani.Height);
				pbOrdek.Left= random.Next(0, pnlUcusAlani.Width);
				pbOrdek.Image = WFA_DuckHuntGame.Properties.Resources.pngegg__1___1_;

				tmrDikey.Start();
				tmrYatay.Start();
			}
		}
	}
}
