namespace Die_Werwölfe
{
	partial class Main
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.btnPlayerAdd = new System.Windows.Forms.Button();
			this.btnRemovePlayer = new System.Windows.Forms.Button();
			this.txtPlayer = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblPlayQuantity = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lblRollQuantity = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.lstBoxPlayer = new System.Windows.Forms.ListBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnPlayerLink = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.txtRolle16 = new System.Windows.Forms.TextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.txtRolle15 = new System.Windows.Forms.TextBox();
			this.txtRolle14 = new System.Windows.Forms.TextBox();
			this.txtRolle13 = new System.Windows.Forms.TextBox();
			this.txtRolle12 = new System.Windows.Forms.TextBox();
			this.txtRolle11 = new System.Windows.Forms.TextBox();
			this.txtRolle10 = new System.Windows.Forms.TextBox();
			this.txtRolle9 = new System.Windows.Forms.TextBox();
			this.txtRolle8 = new System.Windows.Forms.TextBox();
			this.txtRolle7 = new System.Windows.Forms.TextBox();
			this.txtRolle6 = new System.Windows.Forms.TextBox();
			this.txtRolle5 = new System.Windows.Forms.TextBox();
			this.txtRolle4 = new System.Windows.Forms.TextBox();
			this.txtRolle3 = new System.Windows.Forms.TextBox();
			this.txtRolle2 = new System.Windows.Forms.TextBox();
			this.txtRolle1 = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lstBoxCards = new System.Windows.Forms.ListBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnClear = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnPlayerAdd
			// 
			this.btnPlayerAdd.Location = new System.Drawing.Point(90, 58);
			this.btnPlayerAdd.Name = "btnPlayerAdd";
			this.btnPlayerAdd.Size = new System.Drawing.Size(104, 23);
			this.btnPlayerAdd.TabIndex = 0;
			this.btnPlayerAdd.Text = "Spieler hinzufügen";
			this.btnPlayerAdd.UseVisualStyleBackColor = true;
			this.btnPlayerAdd.Click += new System.EventHandler(this.btnPlayerAdd_Click);
			// 
			// btnRemovePlayer
			// 
			this.btnRemovePlayer.Location = new System.Drawing.Point(49, 87);
			this.btnRemovePlayer.Name = "btnRemovePlayer";
			this.btnRemovePlayer.Size = new System.Drawing.Size(145, 23);
			this.btnRemovePlayer.TabIndex = 1;
			this.btnRemovePlayer.Text = "Letzten Spieler entfernen";
			this.btnRemovePlayer.UseVisualStyleBackColor = true;
			this.btnRemovePlayer.Click += new System.EventHandler(this.btnRemovePlayer_Click);
			// 
			// txtPlayer
			// 
			this.txtPlayer.Location = new System.Drawing.Point(6, 32);
			this.txtPlayer.Name = "txtPlayer";
			this.txtPlayer.Size = new System.Drawing.Size(188, 20);
			this.txtPlayer.TabIndex = 2;
			this.txtPlayer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPlayer_KeyDown);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(24, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Anzahl Spieler:";
			// 
			// lblPlayQuantity
			// 
			this.lblPlayQuantity.AutoSize = true;
			this.lblPlayQuantity.Location = new System.Drawing.Point(104, 24);
			this.lblPlayQuantity.Name = "lblPlayQuantity";
			this.lblPlayQuantity.Size = new System.Drawing.Size(72, 13);
			this.lblPlayQuantity.TabIndex = 4;
			this.lblPlayQuantity.Text = "SpielerMenge";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtPlayer);
			this.groupBox1.Controls.Add(this.btnRemovePlayer);
			this.groupBox1.Controls.Add(this.btnPlayerAdd);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 120);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Spieler hinzufügen";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Name des Spielers";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lblRollQuantity);
			this.groupBox2.Controls.Add(this.label20);
			this.groupBox2.Controls.Add(this.lblPlayQuantity);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Location = new System.Drawing.Point(12, 272);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(200, 82);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Spiel Infos";
			// 
			// lblRollQuantity
			// 
			this.lblRollQuantity.AutoSize = true;
			this.lblRollQuantity.Location = new System.Drawing.Point(104, 48);
			this.lblRollQuantity.Name = "lblRollQuantity";
			this.lblRollQuantity.Size = new System.Drawing.Size(70, 13);
			this.lblRollQuantity.TabIndex = 6;
			this.lblRollQuantity.Text = "RollenMenge";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(24, 48);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(75, 13);
			this.label20.TabIndex = 5;
			this.label20.Text = "Anzahl Rollen:";
			// 
			// lstBoxPlayer
			// 
			this.lstBoxPlayer.FormattingEnabled = true;
			this.lstBoxPlayer.Location = new System.Drawing.Point(353, 38);
			this.lstBoxPlayer.Name = "lstBoxPlayer";
			this.lstBoxPlayer.SelectionMode = System.Windows.Forms.SelectionMode.None;
			this.lstBoxPlayer.Size = new System.Drawing.Size(120, 316);
			this.lstBoxPlayer.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(350, 22);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(38, 13);
			this.label5.TabIndex = 6;
			this.label5.Text = "Name:";
			// 
			// btnPlayerLink
			// 
			this.btnPlayerLink.Location = new System.Drawing.Point(26, 165);
			this.btnPlayerLink.Name = "btnPlayerLink";
			this.btnPlayerLink.Size = new System.Drawing.Size(160, 44);
			this.btnPlayerLink.TabIndex = 5;
			this.btnPlayerLink.Text = "Spieler Rollen zuweisen";
			this.btnPlayerLink.UseVisualStyleBackColor = true;
			this.btnPlayerLink.Click += new System.EventHandler(this.btnPlayerLink_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.txtRolle16);
			this.groupBox3.Controls.Add(this.label21);
			this.groupBox3.Controls.Add(this.txtRolle15);
			this.groupBox3.Controls.Add(this.txtRolle14);
			this.groupBox3.Controls.Add(this.txtRolle13);
			this.groupBox3.Controls.Add(this.txtRolle12);
			this.groupBox3.Controls.Add(this.txtRolle11);
			this.groupBox3.Controls.Add(this.txtRolle10);
			this.groupBox3.Controls.Add(this.txtRolle9);
			this.groupBox3.Controls.Add(this.txtRolle8);
			this.groupBox3.Controls.Add(this.txtRolle7);
			this.groupBox3.Controls.Add(this.txtRolle6);
			this.groupBox3.Controls.Add(this.txtRolle5);
			this.groupBox3.Controls.Add(this.txtRolle4);
			this.groupBox3.Controls.Add(this.txtRolle3);
			this.groupBox3.Controls.Add(this.txtRolle2);
			this.groupBox3.Controls.Add(this.txtRolle1);
			this.groupBox3.Controls.Add(this.label19);
			this.groupBox3.Controls.Add(this.label18);
			this.groupBox3.Controls.Add(this.label17);
			this.groupBox3.Controls.Add(this.label16);
			this.groupBox3.Controls.Add(this.label15);
			this.groupBox3.Controls.Add(this.label14);
			this.groupBox3.Controls.Add(this.label13);
			this.groupBox3.Controls.Add(this.label12);
			this.groupBox3.Controls.Add(this.label11);
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Location = new System.Drawing.Point(218, 12);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(123, 342);
			this.groupBox3.TabIndex = 7;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Rollenanzahl";
			// 
			// txtRolle16
			// 
			this.txtRolle16.Location = new System.Drawing.Point(94, 317);
			this.txtRolle16.Name = "txtRolle16";
			this.txtRolle16.Size = new System.Drawing.Size(20, 20);
			this.txtRolle16.TabIndex = 31;
			this.txtRolle16.Text = "0";
			this.txtRolle16.Leave += new System.EventHandler(this.TextChanged);
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(10, 320);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(38, 13);
			this.label21.TabIndex = 30;
			this.label21.Text = "Welpe";
			// 
			// txtRolle15
			// 
			this.txtRolle15.Location = new System.Drawing.Point(94, 297);
			this.txtRolle15.Name = "txtRolle15";
			this.txtRolle15.Size = new System.Drawing.Size(20, 20);
			this.txtRolle15.TabIndex = 29;
			this.txtRolle15.Text = "0";
			this.txtRolle15.Leave += new System.EventHandler(this.TextChanged);
			// 
			// txtRolle14
			// 
			this.txtRolle14.Location = new System.Drawing.Point(94, 277);
			this.txtRolle14.Name = "txtRolle14";
			this.txtRolle14.Size = new System.Drawing.Size(20, 20);
			this.txtRolle14.TabIndex = 28;
			this.txtRolle14.Text = "0";
			this.txtRolle14.Leave += new System.EventHandler(this.TextChanged);
			// 
			// txtRolle13
			// 
			this.txtRolle13.Location = new System.Drawing.Point(94, 257);
			this.txtRolle13.Name = "txtRolle13";
			this.txtRolle13.Size = new System.Drawing.Size(20, 20);
			this.txtRolle13.TabIndex = 27;
			this.txtRolle13.Text = "0";
			this.txtRolle13.Leave += new System.EventHandler(this.TextChanged);
			// 
			// txtRolle12
			// 
			this.txtRolle12.Location = new System.Drawing.Point(94, 237);
			this.txtRolle12.Name = "txtRolle12";
			this.txtRolle12.Size = new System.Drawing.Size(20, 20);
			this.txtRolle12.TabIndex = 26;
			this.txtRolle12.Text = "0";
			this.txtRolle12.Leave += new System.EventHandler(this.TextChanged);
			// 
			// txtRolle11
			// 
			this.txtRolle11.Location = new System.Drawing.Point(94, 217);
			this.txtRolle11.Name = "txtRolle11";
			this.txtRolle11.Size = new System.Drawing.Size(20, 20);
			this.txtRolle11.TabIndex = 25;
			this.txtRolle11.Text = "0";
			this.txtRolle11.Leave += new System.EventHandler(this.TextChanged);
			// 
			// txtRolle10
			// 
			this.txtRolle10.Location = new System.Drawing.Point(94, 197);
			this.txtRolle10.Name = "txtRolle10";
			this.txtRolle10.Size = new System.Drawing.Size(20, 20);
			this.txtRolle10.TabIndex = 24;
			this.txtRolle10.Text = "0";
			this.txtRolle10.Leave += new System.EventHandler(this.TextChanged);
			// 
			// txtRolle9
			// 
			this.txtRolle9.Location = new System.Drawing.Point(94, 177);
			this.txtRolle9.Name = "txtRolle9";
			this.txtRolle9.Size = new System.Drawing.Size(20, 20);
			this.txtRolle9.TabIndex = 23;
			this.txtRolle9.Text = "0";
			this.txtRolle9.Leave += new System.EventHandler(this.TextChanged);
			// 
			// txtRolle8
			// 
			this.txtRolle8.Location = new System.Drawing.Point(94, 157);
			this.txtRolle8.Name = "txtRolle8";
			this.txtRolle8.Size = new System.Drawing.Size(20, 20);
			this.txtRolle8.TabIndex = 22;
			this.txtRolle8.Text = "0";
			this.txtRolle8.Leave += new System.EventHandler(this.TextChanged);
			// 
			// txtRolle7
			// 
			this.txtRolle7.Location = new System.Drawing.Point(94, 137);
			this.txtRolle7.Name = "txtRolle7";
			this.txtRolle7.Size = new System.Drawing.Size(20, 20);
			this.txtRolle7.TabIndex = 21;
			this.txtRolle7.Text = "0";
			this.txtRolle7.Leave += new System.EventHandler(this.TextChanged);
			// 
			// txtRolle6
			// 
			this.txtRolle6.Location = new System.Drawing.Point(94, 117);
			this.txtRolle6.Name = "txtRolle6";
			this.txtRolle6.Size = new System.Drawing.Size(20, 20);
			this.txtRolle6.TabIndex = 20;
			this.txtRolle6.Text = "0";
			this.txtRolle6.Leave += new System.EventHandler(this.TextChanged);
			// 
			// txtRolle5
			// 
			this.txtRolle5.Location = new System.Drawing.Point(94, 97);
			this.txtRolle5.Name = "txtRolle5";
			this.txtRolle5.Size = new System.Drawing.Size(20, 20);
			this.txtRolle5.TabIndex = 19;
			this.txtRolle5.Text = "0";
			this.txtRolle5.Leave += new System.EventHandler(this.TextChanged);
			// 
			// txtRolle4
			// 
			this.txtRolle4.Location = new System.Drawing.Point(94, 77);
			this.txtRolle4.Name = "txtRolle4";
			this.txtRolle4.Size = new System.Drawing.Size(20, 20);
			this.txtRolle4.TabIndex = 18;
			this.txtRolle4.Text = "0";
			this.txtRolle4.Leave += new System.EventHandler(this.TextChanged);
			// 
			// txtRolle3
			// 
			this.txtRolle3.Location = new System.Drawing.Point(94, 57);
			this.txtRolle3.Name = "txtRolle3";
			this.txtRolle3.Size = new System.Drawing.Size(20, 20);
			this.txtRolle3.TabIndex = 17;
			this.txtRolle3.Text = "0";
			this.txtRolle3.Leave += new System.EventHandler(this.TextChanged);
			// 
			// txtRolle2
			// 
			this.txtRolle2.Location = new System.Drawing.Point(94, 37);
			this.txtRolle2.Name = "txtRolle2";
			this.txtRolle2.Size = new System.Drawing.Size(20, 20);
			this.txtRolle2.TabIndex = 16;
			this.txtRolle2.Text = "0";
			this.txtRolle2.Leave += new System.EventHandler(this.TextChanged);
			// 
			// txtRolle1
			// 
			this.txtRolle1.Location = new System.Drawing.Point(94, 17);
			this.txtRolle1.Name = "txtRolle1";
			this.txtRolle1.Size = new System.Drawing.Size(20, 20);
			this.txtRolle1.TabIndex = 15;
			this.txtRolle1.Text = "0";
			this.txtRolle1.Leave += new System.EventHandler(this.TextChanged);
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(10, 300);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(41, 13);
			this.label19.TabIndex = 14;
			this.label19.Text = "Unhold";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(10, 280);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(43, 13);
			this.label18.TabIndex = 13;
			this.label18.Text = "Kindred";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(10, 240);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(48, 13);
			this.label17.TabIndex = 12;
			this.label17.Text = "Wächter";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(10, 260);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(39, 13);
			this.label16.TabIndex = 11;
			this.label16.Text = "Magier";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(10, 220);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(47, 13);
			this.label15.TabIndex = 10;
			this.label15.Text = "Erlöserin";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(10, 200);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(53, 13);
			this.label14.TabIndex = 9;
			this.label14.Text = "Alphawolf";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(10, 180);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(40, 13);
			this.label13.TabIndex = 8;
			this.label13.Text = "Hänsel";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(10, 160);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(55, 13);
			this.label12.TabIndex = 7;
			this.label12.Text = "Sukkubus";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(10, 140);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(33, 13);
			this.label11.TabIndex = 6;
			this.label11.Text = "Jäger";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(10, 120);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(43, 13);
			this.label10.TabIndex = 5;
			this.label10.Text = "Seherin";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(10, 100);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(31, 13);
			this.label9.TabIndex = 4;
			this.label9.Text = "Amor";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(10, 80);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(32, 13);
			this.label8.TabIndex = 3;
			this.label8.Text = "Hexe";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(10, 60);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(42, 13);
			this.label7.TabIndex = 2;
			this.label7.Text = "Gärtner";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(10, 40);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(46, 13);
			this.label6.TabIndex = 1;
			this.label6.Text = "Werwolf";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(10, 20);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Bürger";
			// 
			// lstBoxCards
			// 
			this.lstBoxCards.Enabled = false;
			this.lstBoxCards.FormattingEnabled = true;
			this.lstBoxCards.Location = new System.Drawing.Point(479, 38);
			this.lstBoxCards.Name = "lstBoxCards";
			this.lstBoxCards.SelectionMode = System.Windows.Forms.SelectionMode.None;
			this.lstBoxCards.Size = new System.Drawing.Size(120, 316);
			this.lstBoxCards.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(476, 22);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "Rolle im Spiel:";
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(142, 209);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(44, 20);
			this.btnClear.TabIndex = 10;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(613, 361);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lstBoxCards);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.btnPlayerLink);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lstBoxPlayer);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Main";
			this.Text = "Die Werwölfe von Finsterwald";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnPlayerAdd;
		private System.Windows.Forms.Button btnRemovePlayer;
		private System.Windows.Forms.TextBox txtPlayer;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblPlayQuantity;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox lstBoxPlayer;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnPlayerLink;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ListBox lstBoxCards;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblRollQuantity;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.TextBox txtRolle16;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.TextBox txtRolle15;
		private System.Windows.Forms.TextBox txtRolle14;
		private System.Windows.Forms.TextBox txtRolle13;
		private System.Windows.Forms.TextBox txtRolle12;
		private System.Windows.Forms.TextBox txtRolle11;
		private System.Windows.Forms.TextBox txtRolle10;
		private System.Windows.Forms.TextBox txtRolle9;
		private System.Windows.Forms.TextBox txtRolle8;
		private System.Windows.Forms.TextBox txtRolle7;
		private System.Windows.Forms.TextBox txtRolle6;
		private System.Windows.Forms.TextBox txtRolle5;
		private System.Windows.Forms.TextBox txtRolle4;
		private System.Windows.Forms.TextBox txtRolle3;
		private System.Windows.Forms.TextBox txtRolle2;
		private System.Windows.Forms.TextBox txtRolle1;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnClear;
	}
}

