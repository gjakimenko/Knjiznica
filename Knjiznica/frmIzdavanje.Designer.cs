namespace Knjiznica
{
    partial class frmIzdavanje
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
            this.lblNaslov = new System.Windows.Forms.Label();
            this.lblIzdavac = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.lblKategorija = new System.Windows.Forms.Label();
            this.lblISBN10 = new System.Windows.Forms.Label();
            this.grpKnjiga = new System.Windows.Forms.GroupBox();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.knjigaBS = new System.Windows.Forms.BindingSource(this.components);
            this.knjiznicaDS = new Knjiznica.KnjiznicaDS();
            this.txtISBN10 = new System.Windows.Forms.TextBox();
            this.txtKategorija = new System.Windows.Forms.TextBox();
            this.kategorijaBS = new System.Windows.Forms.BindingSource(this.components);
            this.txtTip = new System.Windows.Forms.TextBox();
            this.tipBS = new System.Windows.Forms.BindingSource(this.components);
            this.txtIzdavac = new System.Windows.Forms.TextBox();
            this.izdavacBS = new System.Windows.Forms.BindingSource(this.components);
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.grpKorisnik = new System.Windows.Forms.GroupBox();
            this.txtClanID = new System.Windows.Forms.TextBox();
            this.korisnikBS = new System.Windows.Forms.BindingSource(this.components);
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblBrojtelefona = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtBrojTelefona = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.knjigaTA = new Knjiznica.KnjiznicaDSTableAdapters.knjigaTA();
            this.izdavacTA = new Knjiznica.KnjiznicaDSTableAdapters.izdavacTA();
            this.tipTA = new Knjiznica.KnjiznicaDSTableAdapters.tipTA();
            this.kategorijaTA = new Knjiznica.KnjiznicaDSTableAdapters.kategorijaTA();
            this.korisnikTA = new Knjiznica.KnjiznicaDSTableAdapters.korisnikTA();
            this.grpAktivnosti = new System.Windows.Forms.GroupBox();
            this.lblDatumRazduzivanja = new System.Windows.Forms.Label();
            this.lblDatumPosudbe = new System.Windows.Forms.Label();
            this.dtpDatumRazduzivanja = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumPosudbe = new System.Windows.Forms.DateTimePicker();
            this.btnZaduzi = new System.Windows.Forms.Button();
            this.posudbaBS = new System.Windows.Forms.BindingSource(this.components);
            this.posudbaTA = new Knjiznica.KnjiznicaDSTableAdapters.posudbaTA();
            this.tableAdapterManager = new Knjiznica.KnjiznicaDSTableAdapters.TableAdapterManager();
            this.grpKnjiga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.knjigaBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjiznicaDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.izdavacBS)).BeginInit();
            this.grpKorisnik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBS)).BeginInit();
            this.grpAktivnosti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posudbaBS)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Location = new System.Drawing.Point(6, 48);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(40, 13);
            this.lblNaslov.TabIndex = 0;
            this.lblNaslov.Text = "Naslov";
            // 
            // lblIzdavac
            // 
            this.lblIzdavac.AutoSize = true;
            this.lblIzdavac.Location = new System.Drawing.Point(6, 102);
            this.lblIzdavac.Name = "lblIzdavac";
            this.lblIzdavac.Size = new System.Drawing.Size(45, 13);
            this.lblIzdavac.TabIndex = 1;
            this.lblIzdavac.Text = "Izdavač";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(6, 75);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(32, 13);
            this.lblAutor.TabIndex = 2;
            this.lblAutor.Text = "Autor";
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(6, 129);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(22, 13);
            this.lblTip.TabIndex = 3;
            this.lblTip.Text = "Tip";
            // 
            // lblKategorija
            // 
            this.lblKategorija.AutoSize = true;
            this.lblKategorija.Location = new System.Drawing.Point(6, 156);
            this.lblKategorija.Name = "lblKategorija";
            this.lblKategorija.Size = new System.Drawing.Size(54, 13);
            this.lblKategorija.TabIndex = 4;
            this.lblKategorija.Text = "Kategorija";
            // 
            // lblISBN10
            // 
            this.lblISBN10.AutoSize = true;
            this.lblISBN10.Location = new System.Drawing.Point(6, 21);
            this.lblISBN10.Name = "lblISBN10";
            this.lblISBN10.Size = new System.Drawing.Size(44, 13);
            this.lblISBN10.TabIndex = 5;
            this.lblISBN10.Text = "ISBN10";
            // 
            // grpKnjiga
            // 
            this.grpKnjiga.Controls.Add(this.txtNaslov);
            this.grpKnjiga.Controls.Add(this.txtISBN10);
            this.grpKnjiga.Controls.Add(this.txtKategorija);
            this.grpKnjiga.Controls.Add(this.txtTip);
            this.grpKnjiga.Controls.Add(this.txtIzdavac);
            this.grpKnjiga.Controls.Add(this.txtAutor);
            this.grpKnjiga.Controls.Add(this.lblAutor);
            this.grpKnjiga.Controls.Add(this.lblISBN10);
            this.grpKnjiga.Controls.Add(this.lblNaslov);
            this.grpKnjiga.Controls.Add(this.lblKategorija);
            this.grpKnjiga.Controls.Add(this.lblIzdavac);
            this.grpKnjiga.Controls.Add(this.lblTip);
            this.grpKnjiga.Location = new System.Drawing.Point(12, 9);
            this.grpKnjiga.Name = "grpKnjiga";
            this.grpKnjiga.Size = new System.Drawing.Size(269, 184);
            this.grpKnjiga.TabIndex = 6;
            this.grpKnjiga.TabStop = false;
            this.grpKnjiga.Text = "Knjiga";
            // 
            // txtNaslov
            // 
            this.txtNaslov.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.knjigaBS, "naslov", true));
            this.txtNaslov.Location = new System.Drawing.Point(79, 45);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.ReadOnly = true;
            this.txtNaslov.Size = new System.Drawing.Size(177, 20);
            this.txtNaslov.TabIndex = 1;
            // 
            // knjigaBS
            // 
            this.knjigaBS.DataMember = "tbl_knjiga";
            this.knjigaBS.DataSource = this.knjiznicaDS;
            // 
            // knjiznicaDS
            // 
            this.knjiznicaDS.DataSetName = "KnjiznicaDS";
            this.knjiznicaDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtISBN10
            // 
            this.txtISBN10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.knjigaBS, "ISBN10", true));
            this.txtISBN10.Location = new System.Drawing.Point(79, 18);
            this.txtISBN10.Name = "txtISBN10";
            this.txtISBN10.ReadOnly = true;
            this.txtISBN10.Size = new System.Drawing.Size(177, 20);
            this.txtISBN10.TabIndex = 0;
            // 
            // txtKategorija
            // 
            this.txtKategorija.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kategorijaBS, "naziv", true));
            this.txtKategorija.Location = new System.Drawing.Point(79, 153);
            this.txtKategorija.Name = "txtKategorija";
            this.txtKategorija.ReadOnly = true;
            this.txtKategorija.Size = new System.Drawing.Size(177, 20);
            this.txtKategorija.TabIndex = 5;
            // 
            // kategorijaBS
            // 
            this.kategorijaBS.DataMember = "tbl_kategorija";
            this.kategorijaBS.DataSource = this.knjiznicaDS;
            // 
            // txtTip
            // 
            this.txtTip.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tipBS, "naziv", true));
            this.txtTip.Location = new System.Drawing.Point(79, 126);
            this.txtTip.Name = "txtTip";
            this.txtTip.ReadOnly = true;
            this.txtTip.Size = new System.Drawing.Size(177, 20);
            this.txtTip.TabIndex = 4;
            // 
            // tipBS
            // 
            this.tipBS.DataMember = "tbl_tip";
            this.tipBS.DataSource = this.knjiznicaDS;
            // 
            // txtIzdavac
            // 
            this.txtIzdavac.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.izdavacBS, "naziv", true));
            this.txtIzdavac.Location = new System.Drawing.Point(79, 99);
            this.txtIzdavac.Name = "txtIzdavac";
            this.txtIzdavac.ReadOnly = true;
            this.txtIzdavac.Size = new System.Drawing.Size(177, 20);
            this.txtIzdavac.TabIndex = 3;
            // 
            // izdavacBS
            // 
            this.izdavacBS.DataMember = "tbl_izdavac";
            this.izdavacBS.DataSource = this.knjiznicaDS;
            // 
            // txtAutor
            // 
            this.txtAutor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.knjigaBS, "autor", true));
            this.txtAutor.Location = new System.Drawing.Point(79, 72);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.ReadOnly = true;
            this.txtAutor.Size = new System.Drawing.Size(177, 20);
            this.txtAutor.TabIndex = 2;
            // 
            // grpKorisnik
            // 
            this.grpKorisnik.Controls.Add(this.txtClanID);
            this.grpKorisnik.Controls.Add(this.lblEmail);
            this.grpKorisnik.Controls.Add(this.lblBrojtelefona);
            this.grpKorisnik.Controls.Add(this.lblID);
            this.grpKorisnik.Controls.Add(this.lblPrezime);
            this.grpKorisnik.Controls.Add(this.txtEmail);
            this.grpKorisnik.Controls.Add(this.txtBrojTelefona);
            this.grpKorisnik.Controls.Add(this.txtPrezime);
            this.grpKorisnik.Controls.Add(this.txtIme);
            this.grpKorisnik.Controls.Add(this.lblIme);
            this.grpKorisnik.Location = new System.Drawing.Point(287, 9);
            this.grpKorisnik.Name = "grpKorisnik";
            this.grpKorisnik.Size = new System.Drawing.Size(269, 184);
            this.grpKorisnik.TabIndex = 0;
            this.grpKorisnik.TabStop = false;
            this.grpKorisnik.Text = "Korisnik";
            // 
            // txtClanID
            // 
            this.txtClanID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnikBS, "id", true));
            this.txtClanID.Location = new System.Drawing.Point(79, 18);
            this.txtClanID.Name = "txtClanID";
            this.txtClanID.Size = new System.Drawing.Size(177, 20);
            this.txtClanID.TabIndex = 0;
            this.txtClanID.Click += new System.EventHandler(this.txtClanID_Click);
            this.txtClanID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtClanID_KeyUp);
            this.txtClanID.Leave += new System.EventHandler(this.txtClanID_Leave);
            // 
            // korisnikBS
            // 
            this.korisnikBS.DataMember = "tbl_korisnik";
            this.korisnikBS.DataSource = this.knjiznicaDS;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 129);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 21;
            this.lblEmail.Text = "Email";
            // 
            // lblBrojtelefona
            // 
            this.lblBrojtelefona.AutoSize = true;
            this.lblBrojtelefona.Location = new System.Drawing.Point(6, 102);
            this.lblBrojtelefona.Name = "lblBrojtelefona";
            this.lblBrojtelefona.Size = new System.Drawing.Size(66, 13);
            this.lblBrojtelefona.TabIndex = 20;
            this.lblBrojtelefona.Text = "Broj telefona";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(6, 21);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(61, 13);
            this.lblID.TabIndex = 19;
            this.lblID.Text = "Članski broj";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(6, 48);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(44, 13);
            this.lblPrezime.TabIndex = 18;
            this.lblPrezime.Text = "Prezime";
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnikBS, "email", true));
            this.txtEmail.Location = new System.Drawing.Point(79, 123);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(177, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // txtBrojTelefona
            // 
            this.txtBrojTelefona.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnikBS, "broj_telefona", true));
            this.txtBrojTelefona.Location = new System.Drawing.Point(79, 97);
            this.txtBrojTelefona.Name = "txtBrojTelefona";
            this.txtBrojTelefona.ReadOnly = true;
            this.txtBrojTelefona.Size = new System.Drawing.Size(177, 20);
            this.txtBrojTelefona.TabIndex = 3;
            // 
            // txtPrezime
            // 
            this.txtPrezime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnikBS, "prezime", true));
            this.txtPrezime.Location = new System.Drawing.Point(79, 45);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.ReadOnly = true;
            this.txtPrezime.Size = new System.Drawing.Size(177, 20);
            this.txtPrezime.TabIndex = 1;
            // 
            // txtIme
            // 
            this.txtIme.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnikBS, "ime", true));
            this.txtIme.Location = new System.Drawing.Point(79, 71);
            this.txtIme.Name = "txtIme";
            this.txtIme.ReadOnly = true;
            this.txtIme.Size = new System.Drawing.Size(177, 20);
            this.txtIme.TabIndex = 2;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(6, 75);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(24, 13);
            this.lblIme.TabIndex = 13;
            this.lblIme.Text = "Ime";
            // 
            // knjigaTA
            // 
            this.knjigaTA.ClearBeforeFill = true;
            // 
            // izdavacTA
            // 
            this.izdavacTA.ClearBeforeFill = true;
            // 
            // tipTA
            // 
            this.tipTA.ClearBeforeFill = true;
            // 
            // kategorijaTA
            // 
            this.kategorijaTA.ClearBeforeFill = true;
            // 
            // korisnikTA
            // 
            this.korisnikTA.ClearBeforeFill = true;
            // 
            // grpAktivnosti
            // 
            this.grpAktivnosti.Controls.Add(this.lblDatumRazduzivanja);
            this.grpAktivnosti.Controls.Add(this.lblDatumPosudbe);
            this.grpAktivnosti.Controls.Add(this.dtpDatumRazduzivanja);
            this.grpAktivnosti.Controls.Add(this.dtpDatumPosudbe);
            this.grpAktivnosti.Controls.Add(this.btnZaduzi);
            this.grpAktivnosti.Location = new System.Drawing.Point(12, 199);
            this.grpAktivnosti.Name = "grpAktivnosti";
            this.grpAktivnosti.Size = new System.Drawing.Size(544, 70);
            this.grpAktivnosti.TabIndex = 1;
            this.grpAktivnosti.TabStop = false;
            // 
            // lblDatumRazduzivanja
            // 
            this.lblDatumRazduzivanja.AutoSize = true;
            this.lblDatumRazduzivanja.Location = new System.Drawing.Point(6, 45);
            this.lblDatumRazduzivanja.Name = "lblDatumRazduzivanja";
            this.lblDatumRazduzivanja.Size = new System.Drawing.Size(100, 13);
            this.lblDatumRazduzivanja.TabIndex = 4;
            this.lblDatumRazduzivanja.Text = "Datum razduživanja";
            // 
            // lblDatumPosudbe
            // 
            this.lblDatumPosudbe.AutoSize = true;
            this.lblDatumPosudbe.Location = new System.Drawing.Point(6, 16);
            this.lblDatumPosudbe.Name = "lblDatumPosudbe";
            this.lblDatumPosudbe.Size = new System.Drawing.Size(82, 13);
            this.lblDatumPosudbe.TabIndex = 3;
            this.lblDatumPosudbe.Text = "Datum posudbe";
            // 
            // dtpDatumRazduzivanja
            // 
            this.dtpDatumRazduzivanja.Location = new System.Drawing.Point(117, 42);
            this.dtpDatumRazduzivanja.Name = "dtpDatumRazduzivanja";
            this.dtpDatumRazduzivanja.Size = new System.Drawing.Size(139, 20);
            this.dtpDatumRazduzivanja.TabIndex = 2;
            // 
            // dtpDatumPosudbe
            // 
            this.dtpDatumPosudbe.Location = new System.Drawing.Point(117, 15);
            this.dtpDatumPosudbe.Name = "dtpDatumPosudbe";
            this.dtpDatumPosudbe.Size = new System.Drawing.Size(139, 20);
            this.dtpDatumPosudbe.TabIndex = 1;
            // 
            // btnZaduzi
            // 
            this.btnZaduzi.Location = new System.Drawing.Point(427, 15);
            this.btnZaduzi.Name = "btnZaduzi";
            this.btnZaduzi.Size = new System.Drawing.Size(104, 44);
            this.btnZaduzi.TabIndex = 3;
            this.btnZaduzi.Text = "Zaduži";
            this.btnZaduzi.UseVisualStyleBackColor = true;
            this.btnZaduzi.Click += new System.EventHandler(this.btnZaduzi_Click);
            // 
            // posudbaBS
            // 
            this.posudbaBS.DataMember = "tbl_posudba";
            this.posudbaBS.DataSource = this.knjiznicaDS;
            // 
            // posudbaTA
            // 
            this.posudbaTA.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.izdavacTA = this.izdavacTA;
            this.tableAdapterManager.kategorijaTA = this.kategorijaTA;
            this.tableAdapterManager.knjigaTA = this.knjigaTA;
            this.tableAdapterManager.korisnikTA = this.korisnikTA;
            this.tableAdapterManager.posudbaTA = this.posudbaTA;
            this.tableAdapterManager.tipTA = this.tipTA;
            this.tableAdapterManager.UpdateOrder = Knjiznica.KnjiznicaDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmIzdavanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 280);
            this.ControlBox = false;
            this.Controls.Add(this.grpAktivnosti);
            this.Controls.Add(this.grpKorisnik);
            this.Controls.Add(this.grpKnjiga);
            this.Name = "frmIzdavanje";
            this.ShowInTaskbar = false;
            this.Text = "Izdavanje";
            this.Load += new System.EventHandler(this.frmIzdavanje_Load);
            this.grpKnjiga.ResumeLayout(false);
            this.grpKnjiga.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.knjigaBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjiznicaDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.izdavacBS)).EndInit();
            this.grpKorisnik.ResumeLayout(false);
            this.grpKorisnik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBS)).EndInit();
            this.grpAktivnosti.ResumeLayout(false);
            this.grpAktivnosti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posudbaBS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label lblIzdavac;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Label lblKategorija;
        private System.Windows.Forms.Label lblISBN10;
        private System.Windows.Forms.GroupBox grpKnjiga;
        private System.Windows.Forms.TextBox txtISBN10;
        private System.Windows.Forms.TextBox txtKategorija;
        private System.Windows.Forms.TextBox txtTip;
        private System.Windows.Forms.TextBox txtIzdavac;
        private System.Windows.Forms.TextBox txtAutor;
        private KnjiznicaDS knjiznicaDS;
        private System.Windows.Forms.BindingSource knjigaBS;
        private KnjiznicaDSTableAdapters.knjigaTA knjigaTA;
        private System.Windows.Forms.GroupBox grpKorisnik;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblBrojtelefona;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtBrojTelefona;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.BindingSource izdavacBS;
        private KnjiznicaDSTableAdapters.izdavacTA izdavacTA;
        private System.Windows.Forms.BindingSource tipBS;
        private KnjiznicaDSTableAdapters.tipTA tipTA;
        private System.Windows.Forms.BindingSource kategorijaBS;
        private KnjiznicaDSTableAdapters.kategorijaTA kategorijaTA;
        private System.Windows.Forms.BindingSource korisnikBS;
        private KnjiznicaDSTableAdapters.korisnikTA korisnikTA;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.GroupBox grpAktivnosti;
        private System.Windows.Forms.Button btnZaduzi;
        private System.Windows.Forms.Label lblDatumRazduzivanja;
        private System.Windows.Forms.Label lblDatumPosudbe;
        private System.Windows.Forms.DateTimePicker dtpDatumRazduzivanja;
        private System.Windows.Forms.DateTimePicker dtpDatumPosudbe;
        private System.Windows.Forms.BindingSource posudbaBS;
        private KnjiznicaDSTableAdapters.posudbaTA posudbaTA;
        private KnjiznicaDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtClanID;
    }
}