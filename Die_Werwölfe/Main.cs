using System;
using System.IO;
using System.Windows.Forms;

namespace Die_Werwölfe
{
	public partial class Main : Form
	{
		int anzahlSpieler, Rollensumme = 0;
		int[] rollen;
		public Main()
		{
			InitializeComponent();
			lblPlayQuantity.Text = "0";
			lblRollQuantity.Text = "0";
		}

		private void btnPlayerAdd_Click(object sender, EventArgs e)
		{
			if (txtPlayer.Text == String.Empty)
			{
				StringWriter sw = new StringWriter();
				sw.WriteLine("Es ist ein Fehler aufgetreten!");
				sw.WriteLine("Meldung: Es wurde kein Name eingegeben!");
				MessageBox.Show(sw.ToString(), "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			lstBoxPlayer.Items.Add(txtPlayer.Text);
			txtPlayer.Text = "";
			anzahlSpieler++;
			lblPlayQuantity.Text = anzahlSpieler.ToString();
		}
		

		private void TextChanged(object sender, EventArgs e)
		{
			Rollensumme = 0;
			try
			{
				rollen = new int[16] { int.Parse(txtRolle1.Text), int.Parse(txtRolle2.Text), int.Parse(txtRolle3.Text), int.Parse(txtRolle4.Text), int.Parse(txtRolle5.Text), int.Parse(txtRolle6.Text), int.Parse(txtRolle7.Text), int.Parse(txtRolle8.Text), int.Parse(txtRolle9.Text), int.Parse(txtRolle10.Text), int.Parse(txtRolle11.Text), int.Parse(txtRolle12.Text), int.Parse(txtRolle13.Text), int.Parse(txtRolle14.Text), int.Parse(txtRolle15.Text), int.Parse(txtRolle16.Text) };
			}
			catch (Exception error)
			{
				StringWriter sw = new StringWriter();
				sw.WriteLine("Es ist ein Fehler aufgetreten!");
				sw.WriteLine("Meldung: " + error.Message);
				MessageBox.Show(sw.ToString(), "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			foreach (object rolle in rollen)
			{
				Rollensumme += (int)rolle;
			}
			lblRollQuantity.Text = Rollensumme.ToString();
		}


		private void btnPlayerLink_Click(object sender, EventArgs e)
		{
			if (anzahlSpieler < 1)
			{
				StringWriter sw = new StringWriter();
				sw.WriteLine("Es ist ein Fehler aufgetreten!");
				sw.WriteLine("Meldung: Es wurden keine Spieler in die Liste eingegeben!");
				MessageBox.Show(sw.ToString(), "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			btnPlayerAdd.Enabled = false;
			btnRemovePlayer.Enabled = false;
			lstBoxCards.Enabled = true;
			randomizer();
		}

		private void randomizer()
		{
			string[] rollennamen = new string[16] {"Bürger","Werwolf","Gärtner","Hexe","Amor","Seherin","Jäger","Sukkubus","Hänsel","Alphawolf","Erlöserin","Wächter","Magier","Kindred","Unhold","Welpe"};
			int rollensumme = Rollensumme;
			Random rand = new Random();
			object[] namen = new object[lstBoxPlayer.Items.Count];

			if (Rollensumme == 0)
			{
				StringWriter sw = new StringWriter();
				sw.WriteLine("Es ist ein Fehler aufgetreten!");
				sw.WriteLine("Meldung: Es wurden keine Rollen eingegeben!");
				MessageBox.Show(sw.ToString(),"Fehler",MessageBoxButtons.OK,MessageBoxIcon.Error);
				btnPlayerAdd.Enabled = true;
				btnRemovePlayer.Enabled = true;
				return;
			}
			else if (namen.Length > Rollensumme)
			{
				StringWriter sw = new StringWriter();
				sw.WriteLine("Es ist ein Fehler aufgetreten!");
				sw.WriteLine("Meldung: Es wurden mehr Spieler als Rollen eingegeben!");
				MessageBox.Show(sw.ToString(), "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				btnPlayerAdd.Enabled = true;
				btnRemovePlayer.Enabled = true;
				return;
			}

			lstBoxPlayer.Items.CopyTo(namen, 0);
			foreach (object spieler in namen)
			{
				int zufalszahl;
				bool repeat = true;
				do
				{
					zufalszahl = rand.Next(0, 16);
					if (rollen[zufalszahl] > 0)
					{
						lstBoxCards.Items.Add(rollennamen[zufalszahl]);
						rollen[zufalszahl]--;
						repeat = false;
					}
				} while (repeat);
			}
			btnPlayerLink.Enabled = false;

		}

		private void txtPlayer_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) btnPlayerAdd_Click(null, null);
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			Application.Restart();
		}

		private void btnRemovePlayer_Click(object sender, EventArgs e)
		{
			if (anzahlSpieler < 1)
			{
				StringWriter sw = new StringWriter();
				sw.WriteLine("Es ist ein Fehler aufgetreten!");
				sw.WriteLine("Meldung: Es können keine nicht vorhandenen Spieler gelöscht werden!");
				MessageBox.Show(sw.ToString(), "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			lstBoxPlayer.Items.RemoveAt(anzahlSpieler-1);
			anzahlSpieler--;
			lblPlayQuantity.Text = anzahlSpieler.ToString();
		}
	}
}
