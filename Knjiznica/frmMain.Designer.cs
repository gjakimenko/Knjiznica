namespace Knjiznica
{
    partial class frmMain
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
            this.tbcMenu = new System.Windows.Forms.TabControl();
            this.tabKatalog = new System.Windows.Forms.TabPage();
            this.spcKatalog = new System.Windows.Forms.SplitContainer();
            this.grpUredi = new System.Windows.Forms.GroupBox();
            this.bntZaduzi = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.cmbKategorija = new System.Windows.Forms.ComboBox();
            this.kategorijaBS = new System.Windows.Forms.BindingSource(this.components);
            this.knjiznicaDS = new Knjiznica.KnjiznicaDS();
            this.lblKategorija = new System.Windows.Forms.Label();
            this.cmbIzdavac = new System.Windows.Forms.ComboBox();
            this.izdavacBS = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtISBN13 = new System.Windows.Forms.TextBox();
            this.knjigaBS = new System.Windows.Forms.BindingSource(this.components);
            this.txtISBN10 = new System.Windows.Forms.TextBox();
            this.lblISBN13 = new System.Windows.Forms.Label();
            this.lblISBN10 = new System.Windows.Forms.Label();
            this.nupKomada = new System.Windows.Forms.NumericUpDown();
            this.lblKomada = new System.Windows.Forms.Label();
            this.cmbTip = new System.Windows.Forms.ComboBox();
            this.tipBS = new System.Windows.Forms.BindingSource(this.components);
            this.txtGodina = new System.Windows.Forms.TextBox();
            this.lblGodina = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.grpPrikaz = new System.Windows.Forms.GroupBox();
            this.dgvKatalog = new System.Windows.Forms.DataGridView();
            this.naslovDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.godinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izdavacidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.komadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBN10DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBN13DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategorijaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabKorisnici = new System.Windows.Forms.TabPage();
            this.scpKorisnici = new System.Windows.Forms.SplitContainer();
            this.grpKorUredi = new System.Windows.Forms.GroupBox();
            this.btnPosudbe = new System.Windows.Forms.Button();
            this.btnKorIzbrisi = new System.Windows.Forms.Button();
            this.btnKorDodaj = new System.Windows.Forms.Button();
            this.btnKorAzuriraj = new System.Windows.Forms.Button();
            this.txtBrojTelefona = new System.Windows.Forms.TextBox();
            this.korisnikBS = new System.Windows.Forms.BindingSource(this.components);
            this.lblBrojTelefona = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.txtClanskiBroj = new System.Windows.Forms.TextBox();
            this.lblClanskiBroj = new System.Windows.Forms.Label();
            this.grpKorPrikaz = new System.Windows.Forms.GroupBox();
            this.dgvKorisnici = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojtelefonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPosudba = new System.Windows.Forms.TabPage();
            this.grpPosPrikaz = new System.Windows.Forms.GroupBox();
            this.dgvPosudbe = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBN10DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naslovDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumizdavanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumrazduzenjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posudbeBS = new System.Windows.Forms.BindingSource(this.components);
            this.knjigaTA = new Knjiznica.KnjiznicaDSTableAdapters.knjigaTA();
            this.kategorijaTA = new Knjiznica.KnjiznicaDSTableAdapters.kategorijaTA();
            this.izdavacTA = new Knjiznica.KnjiznicaDSTableAdapters.izdavacTA();
            this.tipTA = new Knjiznica.KnjiznicaDSTableAdapters.tipTA();
            this.stsStatus = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrClearStatus = new System.Windows.Forms.Timer(this.components);
            this.korisnikTA = new Knjiznica.KnjiznicaDSTableAdapters.korisnikTA();
            this.posudbeTA = new Knjiznica.KnjiznicaDSTableAdapters.posudbeTA();
            this.fKknjigatipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbcMenu.SuspendLayout();
            this.tabKatalog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcKatalog)).BeginInit();
            this.spcKatalog.Panel1.SuspendLayout();
            this.spcKatalog.Panel2.SuspendLayout();
            this.spcKatalog.SuspendLayout();
            this.grpUredi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjiznicaDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.izdavacBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjigaBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupKomada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipBS)).BeginInit();
            this.grpPrikaz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKatalog)).BeginInit();
            this.tabKorisnici.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scpKorisnici)).BeginInit();
            this.scpKorisnici.Panel1.SuspendLayout();
            this.scpKorisnici.Panel2.SuspendLayout();
            this.scpKorisnici.SuspendLayout();
            this.grpKorUredi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBS)).BeginInit();
            this.grpKorPrikaz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).BeginInit();
            this.tabPosudba.SuspendLayout();
            this.grpPosPrikaz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosudbe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posudbeBS)).BeginInit();
            this.stsStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKknjigatipBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcMenu
            // 
            this.tbcMenu.Controls.Add(this.tabKatalog);
            this.tbcMenu.Controls.Add(this.tabKorisnici);
            this.tbcMenu.Controls.Add(this.tabPosudba);
            this.tbcMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcMenu.Location = new System.Drawing.Point(0, 0);
            this.tbcMenu.Name = "tbcMenu";
            this.tbcMenu.SelectedIndex = 0;
            this.tbcMenu.Size = new System.Drawing.Size(1234, 587);
            this.tbcMenu.TabIndex = 0;
            this.tbcMenu.SelectedIndexChanged += new System.EventHandler(this.tbcMenu_SelectedIndexChanged);
            // 
            // tabKatalog
            // 
            this.tabKatalog.Controls.Add(this.spcKatalog);
            this.tabKatalog.Location = new System.Drawing.Point(4, 22);
            this.tabKatalog.Name = "tabKatalog";
            this.tabKatalog.Padding = new System.Windows.Forms.Padding(3);
            this.tabKatalog.Size = new System.Drawing.Size(1226, 561);
            this.tabKatalog.TabIndex = 0;
            this.tabKatalog.Text = "Katalog";
            this.tabKatalog.UseVisualStyleBackColor = true;
            // 
            // spcKatalog
            // 
            this.spcKatalog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.spcKatalog.Location = new System.Drawing.Point(3, 3);
            this.spcKatalog.Name = "spcKatalog";
            // 
            // spcKatalog.Panel1
            // 
            this.spcKatalog.Panel1.Controls.Add(this.grpUredi);
            // 
            // spcKatalog.Panel2
            // 
            this.spcKatalog.Panel2.Controls.Add(this.grpPrikaz);
            this.spcKatalog.Size = new System.Drawing.Size(1220, 537);
            this.spcKatalog.SplitterDistance = 345;
            this.spcKatalog.TabIndex = 2;
            // 
            // grpUredi
            // 
            this.grpUredi.BackColor = System.Drawing.Color.Transparent;
            this.grpUredi.Controls.Add(this.bntZaduzi);
            this.grpUredi.Controls.Add(this.btnIzbrisi);
            this.grpUredi.Controls.Add(this.btnDodaj);
            this.grpUredi.Controls.Add(this.btnAzuriraj);
            this.grpUredi.Controls.Add(this.cmbKategorija);
            this.grpUredi.Controls.Add(this.lblKategorija);
            this.grpUredi.Controls.Add(this.cmbIzdavac);
            this.grpUredi.Controls.Add(this.label1);
            this.grpUredi.Controls.Add(this.txtISBN13);
            this.grpUredi.Controls.Add(this.txtISBN10);
            this.grpUredi.Controls.Add(this.lblISBN13);
            this.grpUredi.Controls.Add(this.lblISBN10);
            this.grpUredi.Controls.Add(this.nupKomada);
            this.grpUredi.Controls.Add(this.lblKomada);
            this.grpUredi.Controls.Add(this.cmbTip);
            this.grpUredi.Controls.Add(this.txtGodina);
            this.grpUredi.Controls.Add(this.lblGodina);
            this.grpUredi.Controls.Add(this.lblTip);
            this.grpUredi.Controls.Add(this.txtAutor);
            this.grpUredi.Controls.Add(this.lblAutor);
            this.grpUredi.Controls.Add(this.txtNaslov);
            this.grpUredi.Controls.Add(this.lblNaslov);
            this.grpUredi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpUredi.Location = new System.Drawing.Point(0, 0);
            this.grpUredi.Name = "grpUredi";
            this.grpUredi.Size = new System.Drawing.Size(345, 537);
            this.grpUredi.TabIndex = 1;
            this.grpUredi.TabStop = false;
            this.grpUredi.Text = "Uredi";
            // 
            // bntZaduzi
            // 
            this.bntZaduzi.Location = new System.Drawing.Point(238, 447);
            this.bntZaduzi.Name = "bntZaduzi";
            this.bntZaduzi.Size = new System.Drawing.Size(97, 37);
            this.bntZaduzi.TabIndex = 18;
            this.bntZaduzi.Text = "Zaduži";
            this.bntZaduzi.UseVisualStyleBackColor = true;
            this.bntZaduzi.Click += new System.EventHandler(this.bntZaduzi_Click);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIzbrisi.Location = new System.Drawing.Point(238, 490);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(98, 37);
            this.btnIzbrisi.TabIndex = 17;
            this.btnIzbrisi.Text = "Izbriši";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDodaj.Location = new System.Drawing.Point(10, 490);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(98, 37);
            this.btnDodaj.TabIndex = 16;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAzuriraj.Location = new System.Drawing.Point(124, 490);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(98, 37);
            this.btnAzuriraj.TabIndex = 15;
            this.btnAzuriraj.Text = "Ažuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // cmbKategorija
            // 
            this.cmbKategorija.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbKategorija.DataSource = this.kategorijaBS;
            this.cmbKategorija.DisplayMember = "naziv";
            this.cmbKategorija.FormattingEnabled = true;
            this.cmbKategorija.Location = new System.Drawing.Point(80, 308);
            this.cmbKategorija.Name = "cmbKategorija";
            this.cmbKategorija.Size = new System.Drawing.Size(256, 21);
            this.cmbKategorija.TabIndex = 8;
            this.cmbKategorija.ValueMember = "id";
            // 
            // kategorijaBS
            // 
            this.kategorijaBS.DataMember = "tbl_kategorija";
            this.kategorijaBS.DataSource = this.knjiznicaDS;
            // 
            // knjiznicaDS
            // 
            this.knjiznicaDS.DataSetName = "KnjiznicaDS";
            this.knjiznicaDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblKategorija
            // 
            this.lblKategorija.AutoSize = true;
            this.lblKategorija.Location = new System.Drawing.Point(7, 310);
            this.lblKategorija.Name = "lblKategorija";
            this.lblKategorija.Size = new System.Drawing.Size(54, 13);
            this.lblKategorija.TabIndex = 14;
            this.lblKategorija.Text = "Kategorija";
            // 
            // cmbIzdavac
            // 
            this.cmbIzdavac.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbIzdavac.DataSource = this.izdavacBS;
            this.cmbIzdavac.DisplayMember = "naziv";
            this.cmbIzdavac.FormattingEnabled = true;
            this.cmbIzdavac.Location = new System.Drawing.Point(80, 127);
            this.cmbIzdavac.Name = "cmbIzdavac";
            this.cmbIzdavac.Size = new System.Drawing.Size(256, 21);
            this.cmbIzdavac.TabIndex = 3;
            this.cmbIzdavac.ValueMember = "id";
            // 
            // izdavacBS
            // 
            this.izdavacBS.DataMember = "tbl_izdavac";
            this.izdavacBS.DataSource = this.knjiznicaDS;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Izdavač";
            // 
            // txtISBN13
            // 
            this.txtISBN13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtISBN13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.knjigaBS, "ISBN13", true));
            this.txtISBN13.Location = new System.Drawing.Point(80, 272);
            this.txtISBN13.Name = "txtISBN13";
            this.txtISBN13.Size = new System.Drawing.Size(256, 20);
            this.txtISBN13.TabIndex = 7;
            // 
            // knjigaBS
            // 
            this.knjigaBS.DataMember = "tbl_knjiga";
            this.knjigaBS.DataSource = this.knjiznicaDS;
            // 
            // txtISBN10
            // 
            this.txtISBN10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtISBN10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.knjigaBS, "ISBN10", true));
            this.txtISBN10.Location = new System.Drawing.Point(80, 236);
            this.txtISBN10.Name = "txtISBN10";
            this.txtISBN10.Size = new System.Drawing.Size(256, 20);
            this.txtISBN10.TabIndex = 6;
            // 
            // lblISBN13
            // 
            this.lblISBN13.AutoSize = true;
            this.lblISBN13.Location = new System.Drawing.Point(7, 274);
            this.lblISBN13.Name = "lblISBN13";
            this.lblISBN13.Size = new System.Drawing.Size(44, 13);
            this.lblISBN13.TabIndex = 10;
            this.lblISBN13.Text = "ISBN13";
            // 
            // lblISBN10
            // 
            this.lblISBN10.AutoSize = true;
            this.lblISBN10.Location = new System.Drawing.Point(7, 238);
            this.lblISBN10.Name = "lblISBN10";
            this.lblISBN10.Size = new System.Drawing.Size(44, 13);
            this.lblISBN10.TabIndex = 9;
            this.lblISBN10.Text = "ISBN10";
            // 
            // nupKomada
            // 
            this.nupKomada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.nupKomada.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.knjigaBS, "komada", true));
            this.nupKomada.Location = new System.Drawing.Point(247, 200);
            this.nupKomada.Name = "nupKomada";
            this.nupKomada.Size = new System.Drawing.Size(89, 20);
            this.nupKomada.TabIndex = 5;
            // 
            // lblKomada
            // 
            this.lblKomada.AutoSize = true;
            this.lblKomada.Location = new System.Drawing.Point(7, 202);
            this.lblKomada.Name = "lblKomada";
            this.lblKomada.Size = new System.Drawing.Size(46, 13);
            this.lblKomada.TabIndex = 8;
            this.lblKomada.Text = "Komada";
            // 
            // cmbTip
            // 
            this.cmbTip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTip.FormattingEnabled = true;
            this.cmbTip.Location = new System.Drawing.Point(80, 90);
            this.cmbTip.Name = "cmbTip";
            this.cmbTip.Size = new System.Drawing.Size(256, 21);
            this.cmbTip.TabIndex = 2;
            // 
            // tipBS
            // 
            this.tipBS.DataMember = "tbl_tip";
            this.tipBS.DataSource = this.knjiznicaDS;
            // 
            // txtGodina
            // 
            this.txtGodina.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGodina.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.knjigaBS, "godina", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "-"));
            this.txtGodina.Location = new System.Drawing.Point(247, 164);
            this.txtGodina.Name = "txtGodina";
            this.txtGodina.Size = new System.Drawing.Size(89, 20);
            this.txtGodina.TabIndex = 4;
            // 
            // lblGodina
            // 
            this.lblGodina.AutoSize = true;
            this.lblGodina.Location = new System.Drawing.Point(7, 166);
            this.lblGodina.Name = "lblGodina";
            this.lblGodina.Size = new System.Drawing.Size(41, 13);
            this.lblGodina.TabIndex = 6;
            this.lblGodina.Text = "Godina";
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(7, 94);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(22, 13);
            this.lblTip.TabIndex = 4;
            this.lblTip.Text = "Tip";
            // 
            // txtAutor
            // 
            this.txtAutor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAutor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.knjigaBS, "autor", true));
            this.txtAutor.Location = new System.Drawing.Point(80, 54);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(256, 20);
            this.txtAutor.TabIndex = 1;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(7, 58);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(32, 13);
            this.lblAutor.TabIndex = 2;
            this.lblAutor.Text = "Autor";
            // 
            // txtNaslov
            // 
            this.txtNaslov.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNaslov.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.knjigaBS, "naslov", true));
            this.txtNaslov.Location = new System.Drawing.Point(80, 18);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(256, 20);
            this.txtNaslov.TabIndex = 0;
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Location = new System.Drawing.Point(7, 22);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(40, 13);
            this.lblNaslov.TabIndex = 1;
            this.lblNaslov.Text = "Naslov";
            // 
            // grpPrikaz
            // 
            this.grpPrikaz.Controls.Add(this.dgvKatalog);
            this.grpPrikaz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPrikaz.Location = new System.Drawing.Point(0, 0);
            this.grpPrikaz.Name = "grpPrikaz";
            this.grpPrikaz.Size = new System.Drawing.Size(871, 537);
            this.grpPrikaz.TabIndex = 2;
            this.grpPrikaz.TabStop = false;
            this.grpPrikaz.Text = "Prikaz";
            // 
            // dgvKatalog
            // 
            this.dgvKatalog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKatalog.AutoGenerateColumns = false;
            this.dgvKatalog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvKatalog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKatalog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.naslovDataGridViewTextBoxColumn,
            this.autorDataGridViewTextBoxColumn,
            this.tipidDataGridViewTextBoxColumn,
            this.godinaDataGridViewTextBoxColumn,
            this.izdavacidDataGridViewTextBoxColumn,
            this.komadaDataGridViewTextBoxColumn,
            this.iSBN10DataGridViewTextBoxColumn,
            this.iSBN13DataGridViewTextBoxColumn,
            this.kategorijaidDataGridViewTextBoxColumn});
            this.dgvKatalog.DataSource = this.knjigaBS;
            this.dgvKatalog.Location = new System.Drawing.Point(3, 16);
            this.dgvKatalog.Name = "dgvKatalog";
            this.dgvKatalog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKatalog.Size = new System.Drawing.Size(865, 515);
            this.dgvKatalog.TabIndex = 1;
            this.dgvKatalog.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvKatalog_MouseDoubleClick);
            // 
            // naslovDataGridViewTextBoxColumn
            // 
            this.naslovDataGridViewTextBoxColumn.DataPropertyName = "naslov";
            this.naslovDataGridViewTextBoxColumn.HeaderText = "Naslov";
            this.naslovDataGridViewTextBoxColumn.Name = "naslovDataGridViewTextBoxColumn";
            this.naslovDataGridViewTextBoxColumn.Width = 65;
            // 
            // autorDataGridViewTextBoxColumn
            // 
            this.autorDataGridViewTextBoxColumn.DataPropertyName = "autor";
            this.autorDataGridViewTextBoxColumn.HeaderText = "Autor";
            this.autorDataGridViewTextBoxColumn.Name = "autorDataGridViewTextBoxColumn";
            this.autorDataGridViewTextBoxColumn.Width = 57;
            // 
            // tipidDataGridViewTextBoxColumn
            // 
            this.tipidDataGridViewTextBoxColumn.DataPropertyName = "tip_id";
            this.tipidDataGridViewTextBoxColumn.DataSource = this.tipBS;
            this.tipidDataGridViewTextBoxColumn.DisplayMember = "naziv";
            this.tipidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.tipidDataGridViewTextBoxColumn.HeaderText = "Tip";
            this.tipidDataGridViewTextBoxColumn.Name = "tipidDataGridViewTextBoxColumn";
            this.tipidDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tipidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tipidDataGridViewTextBoxColumn.ValueMember = "id";
            this.tipidDataGridViewTextBoxColumn.Width = 47;
            // 
            // godinaDataGridViewTextBoxColumn
            // 
            this.godinaDataGridViewTextBoxColumn.DataPropertyName = "godina";
            this.godinaDataGridViewTextBoxColumn.HeaderText = "Godina";
            this.godinaDataGridViewTextBoxColumn.Name = "godinaDataGridViewTextBoxColumn";
            this.godinaDataGridViewTextBoxColumn.Width = 66;
            // 
            // izdavacidDataGridViewTextBoxColumn
            // 
            this.izdavacidDataGridViewTextBoxColumn.DataPropertyName = "izdavac_id";
            this.izdavacidDataGridViewTextBoxColumn.DataSource = this.izdavacBS;
            this.izdavacidDataGridViewTextBoxColumn.DisplayMember = "naziv";
            this.izdavacidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.izdavacidDataGridViewTextBoxColumn.HeaderText = "Izdavač";
            this.izdavacidDataGridViewTextBoxColumn.Name = "izdavacidDataGridViewTextBoxColumn";
            this.izdavacidDataGridViewTextBoxColumn.ReadOnly = true;
            this.izdavacidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.izdavacidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.izdavacidDataGridViewTextBoxColumn.ValueMember = "id";
            this.izdavacidDataGridViewTextBoxColumn.Width = 70;
            // 
            // komadaDataGridViewTextBoxColumn
            // 
            this.komadaDataGridViewTextBoxColumn.DataPropertyName = "komada";
            this.komadaDataGridViewTextBoxColumn.HeaderText = "Komada";
            this.komadaDataGridViewTextBoxColumn.Name = "komadaDataGridViewTextBoxColumn";
            this.komadaDataGridViewTextBoxColumn.Width = 71;
            // 
            // iSBN10DataGridViewTextBoxColumn
            // 
            this.iSBN10DataGridViewTextBoxColumn.DataPropertyName = "ISBN10";
            this.iSBN10DataGridViewTextBoxColumn.HeaderText = "ISBN10";
            this.iSBN10DataGridViewTextBoxColumn.Name = "iSBN10DataGridViewTextBoxColumn";
            this.iSBN10DataGridViewTextBoxColumn.Width = 69;
            // 
            // iSBN13DataGridViewTextBoxColumn
            // 
            this.iSBN13DataGridViewTextBoxColumn.DataPropertyName = "ISBN13";
            this.iSBN13DataGridViewTextBoxColumn.HeaderText = "ISBN13";
            this.iSBN13DataGridViewTextBoxColumn.Name = "iSBN13DataGridViewTextBoxColumn";
            this.iSBN13DataGridViewTextBoxColumn.Width = 69;
            // 
            // kategorijaidDataGridViewTextBoxColumn
            // 
            this.kategorijaidDataGridViewTextBoxColumn.DataPropertyName = "kategorija_id";
            this.kategorijaidDataGridViewTextBoxColumn.DataSource = this.kategorijaBS;
            this.kategorijaidDataGridViewTextBoxColumn.DisplayMember = "naziv";
            this.kategorijaidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.kategorijaidDataGridViewTextBoxColumn.HeaderText = "Kategorija";
            this.kategorijaidDataGridViewTextBoxColumn.Name = "kategorijaidDataGridViewTextBoxColumn";
            this.kategorijaidDataGridViewTextBoxColumn.ReadOnly = true;
            this.kategorijaidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.kategorijaidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.kategorijaidDataGridViewTextBoxColumn.ValueMember = "id";
            this.kategorijaidDataGridViewTextBoxColumn.Width = 79;
            // 
            // tabKorisnici
            // 
            this.tabKorisnici.Controls.Add(this.scpKorisnici);
            this.tabKorisnici.Location = new System.Drawing.Point(4, 22);
            this.tabKorisnici.Name = "tabKorisnici";
            this.tabKorisnici.Padding = new System.Windows.Forms.Padding(3);
            this.tabKorisnici.Size = new System.Drawing.Size(1226, 561);
            this.tabKorisnici.TabIndex = 2;
            this.tabKorisnici.Text = "Korisnici";
            this.tabKorisnici.UseVisualStyleBackColor = true;
            // 
            // scpKorisnici
            // 
            this.scpKorisnici.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.scpKorisnici.Location = new System.Drawing.Point(3, 3);
            this.scpKorisnici.Name = "scpKorisnici";
            // 
            // scpKorisnici.Panel1
            // 
            this.scpKorisnici.Panel1.Controls.Add(this.grpKorUredi);
            // 
            // scpKorisnici.Panel2
            // 
            this.scpKorisnici.Panel2.Controls.Add(this.grpKorPrikaz);
            this.scpKorisnici.Size = new System.Drawing.Size(1220, 537);
            this.scpKorisnici.SplitterDistance = 344;
            this.scpKorisnici.TabIndex = 0;
            // 
            // grpKorUredi
            // 
            this.grpKorUredi.Controls.Add(this.btnPosudbe);
            this.grpKorUredi.Controls.Add(this.btnKorIzbrisi);
            this.grpKorUredi.Controls.Add(this.btnKorDodaj);
            this.grpKorUredi.Controls.Add(this.btnKorAzuriraj);
            this.grpKorUredi.Controls.Add(this.txtBrojTelefona);
            this.grpKorUredi.Controls.Add(this.lblBrojTelefona);
            this.grpKorUredi.Controls.Add(this.txtEmail);
            this.grpKorUredi.Controls.Add(this.lblEmail);
            this.grpKorUredi.Controls.Add(this.txtPrezime);
            this.grpKorUredi.Controls.Add(this.lblPrezime);
            this.grpKorUredi.Controls.Add(this.txtIme);
            this.grpKorUredi.Controls.Add(this.lblIme);
            this.grpKorUredi.Controls.Add(this.txtClanskiBroj);
            this.grpKorUredi.Controls.Add(this.lblClanskiBroj);
            this.grpKorUredi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpKorUredi.Location = new System.Drawing.Point(0, 0);
            this.grpKorUredi.Name = "grpKorUredi";
            this.grpKorUredi.Size = new System.Drawing.Size(344, 537);
            this.grpKorUredi.TabIndex = 0;
            this.grpKorUredi.TabStop = false;
            this.grpKorUredi.Text = "Uredi";
            // 
            // btnPosudbe
            // 
            this.btnPosudbe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPosudbe.Location = new System.Drawing.Point(262, 211);
            this.btnPosudbe.Name = "btnPosudbe";
            this.btnPosudbe.Size = new System.Drawing.Size(75, 23);
            this.btnPosudbe.TabIndex = 21;
            this.btnPosudbe.Text = "Posudbe";
            this.btnPosudbe.UseVisualStyleBackColor = true;
            this.btnPosudbe.Click += new System.EventHandler(this.btnPosudbe_Click);
            // 
            // btnKorIzbrisi
            // 
            this.btnKorIzbrisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKorIzbrisi.Location = new System.Drawing.Point(239, 492);
            this.btnKorIzbrisi.Name = "btnKorIzbrisi";
            this.btnKorIzbrisi.Size = new System.Drawing.Size(98, 37);
            this.btnKorIzbrisi.TabIndex = 20;
            this.btnKorIzbrisi.Text = "Izbriši";
            this.btnKorIzbrisi.UseVisualStyleBackColor = true;
            this.btnKorIzbrisi.Click += new System.EventHandler(this.btnKorIzbrisi_Click);
            // 
            // btnKorDodaj
            // 
            this.btnKorDodaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKorDodaj.Location = new System.Drawing.Point(9, 492);
            this.btnKorDodaj.Name = "btnKorDodaj";
            this.btnKorDodaj.Size = new System.Drawing.Size(98, 37);
            this.btnKorDodaj.TabIndex = 19;
            this.btnKorDodaj.Text = "Dodaj";
            this.btnKorDodaj.UseVisualStyleBackColor = true;
            this.btnKorDodaj.Click += new System.EventHandler(this.btnKorDodaj_Click);
            // 
            // btnKorAzuriraj
            // 
            this.btnKorAzuriraj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKorAzuriraj.Location = new System.Drawing.Point(124, 492);
            this.btnKorAzuriraj.Name = "btnKorAzuriraj";
            this.btnKorAzuriraj.Size = new System.Drawing.Size(98, 37);
            this.btnKorAzuriraj.TabIndex = 18;
            this.btnKorAzuriraj.Text = "Ažuriraj";
            this.btnKorAzuriraj.UseVisualStyleBackColor = true;
            this.btnKorAzuriraj.Click += new System.EventHandler(this.btnKorAzuriraj_Click);
            // 
            // txtBrojTelefona
            // 
            this.txtBrojTelefona.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBrojTelefona.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnikBS, "broj_telefona", true));
            this.txtBrojTelefona.Location = new System.Drawing.Point(82, 175);
            this.txtBrojTelefona.Name = "txtBrojTelefona";
            this.txtBrojTelefona.Size = new System.Drawing.Size(256, 20);
            this.txtBrojTelefona.TabIndex = 10;
            // 
            // korisnikBS
            // 
            this.korisnikBS.DataMember = "tbl_korisnik";
            this.korisnikBS.DataSource = this.knjiznicaDS;
            // 
            // lblBrojTelefona
            // 
            this.lblBrojTelefona.AutoSize = true;
            this.lblBrojTelefona.Location = new System.Drawing.Point(6, 178);
            this.lblBrojTelefona.Name = "lblBrojTelefona";
            this.lblBrojTelefona.Size = new System.Drawing.Size(66, 13);
            this.lblBrojTelefona.TabIndex = 11;
            this.lblBrojTelefona.Text = "Broj telefona";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnikBS, "email", true));
            this.txtEmail.Location = new System.Drawing.Point(82, 136);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(256, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 139);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 13);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "E-Mail";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrezime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnikBS, "prezime", true));
            this.txtPrezime.Location = new System.Drawing.Point(82, 97);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(256, 20);
            this.txtPrezime.TabIndex = 6;
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(6, 100);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(44, 13);
            this.lblPrezime.TabIndex = 7;
            this.lblPrezime.Text = "Prezime";
            // 
            // txtIme
            // 
            this.txtIme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIme.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnikBS, "ime", true));
            this.txtIme.Location = new System.Drawing.Point(82, 58);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(256, 20);
            this.txtIme.TabIndex = 4;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(6, 61);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(24, 13);
            this.lblIme.TabIndex = 5;
            this.lblIme.Text = "Ime";
            // 
            // txtClanskiBroj
            // 
            this.txtClanskiBroj.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClanskiBroj.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnikBS, "id", true));
            this.txtClanskiBroj.Location = new System.Drawing.Point(82, 19);
            this.txtClanskiBroj.Name = "txtClanskiBroj";
            this.txtClanskiBroj.ReadOnly = true;
            this.txtClanskiBroj.Size = new System.Drawing.Size(256, 20);
            this.txtClanskiBroj.TabIndex = 2;
            // 
            // lblClanskiBroj
            // 
            this.lblClanskiBroj.AutoSize = true;
            this.lblClanskiBroj.Location = new System.Drawing.Point(6, 22);
            this.lblClanskiBroj.Name = "lblClanskiBroj";
            this.lblClanskiBroj.Size = new System.Drawing.Size(61, 13);
            this.lblClanskiBroj.TabIndex = 3;
            this.lblClanskiBroj.Text = "Članski broj";
            // 
            // grpKorPrikaz
            // 
            this.grpKorPrikaz.Controls.Add(this.dgvKorisnici);
            this.grpKorPrikaz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpKorPrikaz.Location = new System.Drawing.Point(0, 0);
            this.grpKorPrikaz.Name = "grpKorPrikaz";
            this.grpKorPrikaz.Size = new System.Drawing.Size(872, 537);
            this.grpKorPrikaz.TabIndex = 0;
            this.grpKorPrikaz.TabStop = false;
            this.grpKorPrikaz.Text = "Prikaz";
            // 
            // dgvKorisnici
            // 
            this.dgvKorisnici.AutoGenerateColumns = false;
            this.dgvKorisnici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKorisnici.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.brojtelefonaDataGridViewTextBoxColumn});
            this.dgvKorisnici.DataSource = this.korisnikBS;
            this.dgvKorisnici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKorisnici.Location = new System.Drawing.Point(3, 16);
            this.dgvKorisnici.Name = "dgvKorisnici";
            this.dgvKorisnici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKorisnici.Size = new System.Drawing.Size(866, 518);
            this.dgvKorisnici.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Članski broj";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E-Mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // brojtelefonaDataGridViewTextBoxColumn
            // 
            this.brojtelefonaDataGridViewTextBoxColumn.DataPropertyName = "broj_telefona";
            this.brojtelefonaDataGridViewTextBoxColumn.HeaderText = "Broj telefona";
            this.brojtelefonaDataGridViewTextBoxColumn.Name = "brojtelefonaDataGridViewTextBoxColumn";
            // 
            // tabPosudba
            // 
            this.tabPosudba.Controls.Add(this.grpPosPrikaz);
            this.tabPosudba.Location = new System.Drawing.Point(4, 22);
            this.tabPosudba.Name = "tabPosudba";
            this.tabPosudba.Padding = new System.Windows.Forms.Padding(3);
            this.tabPosudba.Size = new System.Drawing.Size(1226, 561);
            this.tabPosudba.TabIndex = 1;
            this.tabPosudba.Text = "Posudba";
            this.tabPosudba.UseVisualStyleBackColor = true;
            // 
            // grpPosPrikaz
            // 
            this.grpPosPrikaz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPosPrikaz.Controls.Add(this.dgvPosudbe);
            this.grpPosPrikaz.Location = new System.Drawing.Point(3, 3);
            this.grpPosPrikaz.Name = "grpPosPrikaz";
            this.grpPosPrikaz.Size = new System.Drawing.Size(1220, 537);
            this.grpPosPrikaz.TabIndex = 1;
            this.grpPosPrikaz.TabStop = false;
            this.grpPosPrikaz.Text = "Prikaz";
            // 
            // dgvPosudbe
            // 
            this.dgvPosudbe.AutoGenerateColumns = false;
            this.dgvPosudbe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPosudbe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPosudbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosudbe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.imeDataGridViewTextBoxColumn1,
            this.prezimeDataGridViewTextBoxColumn1,
            this.iSBN10DataGridViewTextBoxColumn1,
            this.naslovDataGridViewTextBoxColumn1,
            this.autorDataGridViewTextBoxColumn1,
            this.datumizdavanjaDataGridViewTextBoxColumn,
            this.datumrazduzenjaDataGridViewTextBoxColumn});
            this.dgvPosudbe.DataSource = this.posudbeBS;
            this.dgvPosudbe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPosudbe.Location = new System.Drawing.Point(3, 16);
            this.dgvPosudbe.Name = "dgvPosudbe";
            this.dgvPosudbe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPosudbe.Size = new System.Drawing.Size(1214, 518);
            this.dgvPosudbe.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.Width = 40;
            // 
            // imeDataGridViewTextBoxColumn1
            // 
            this.imeDataGridViewTextBoxColumn1.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn1.HeaderText = "ime";
            this.imeDataGridViewTextBoxColumn1.Name = "imeDataGridViewTextBoxColumn1";
            this.imeDataGridViewTextBoxColumn1.Width = 48;
            // 
            // prezimeDataGridViewTextBoxColumn1
            // 
            this.prezimeDataGridViewTextBoxColumn1.DataPropertyName = "prezime";
            this.prezimeDataGridViewTextBoxColumn1.HeaderText = "prezime";
            this.prezimeDataGridViewTextBoxColumn1.Name = "prezimeDataGridViewTextBoxColumn1";
            this.prezimeDataGridViewTextBoxColumn1.Width = 68;
            // 
            // iSBN10DataGridViewTextBoxColumn1
            // 
            this.iSBN10DataGridViewTextBoxColumn1.DataPropertyName = "ISBN10";
            this.iSBN10DataGridViewTextBoxColumn1.HeaderText = "ISBN10";
            this.iSBN10DataGridViewTextBoxColumn1.Name = "iSBN10DataGridViewTextBoxColumn1";
            this.iSBN10DataGridViewTextBoxColumn1.Width = 69;
            // 
            // naslovDataGridViewTextBoxColumn1
            // 
            this.naslovDataGridViewTextBoxColumn1.DataPropertyName = "naslov";
            this.naslovDataGridViewTextBoxColumn1.HeaderText = "naslov";
            this.naslovDataGridViewTextBoxColumn1.Name = "naslovDataGridViewTextBoxColumn1";
            this.naslovDataGridViewTextBoxColumn1.Width = 63;
            // 
            // autorDataGridViewTextBoxColumn1
            // 
            this.autorDataGridViewTextBoxColumn1.DataPropertyName = "autor";
            this.autorDataGridViewTextBoxColumn1.HeaderText = "autor";
            this.autorDataGridViewTextBoxColumn1.Name = "autorDataGridViewTextBoxColumn1";
            this.autorDataGridViewTextBoxColumn1.Width = 56;
            // 
            // datumizdavanjaDataGridViewTextBoxColumn
            // 
            this.datumizdavanjaDataGridViewTextBoxColumn.DataPropertyName = "datum_izdavanja";
            this.datumizdavanjaDataGridViewTextBoxColumn.HeaderText = "datum_izdavanja";
            this.datumizdavanjaDataGridViewTextBoxColumn.Name = "datumizdavanjaDataGridViewTextBoxColumn";
            this.datumizdavanjaDataGridViewTextBoxColumn.Width = 112;
            // 
            // datumrazduzenjaDataGridViewTextBoxColumn
            // 
            this.datumrazduzenjaDataGridViewTextBoxColumn.DataPropertyName = "datum_razduzenja";
            this.datumrazduzenjaDataGridViewTextBoxColumn.HeaderText = "datum_razduzenja";
            this.datumrazduzenjaDataGridViewTextBoxColumn.Name = "datumrazduzenjaDataGridViewTextBoxColumn";
            this.datumrazduzenjaDataGridViewTextBoxColumn.Width = 118;
            // 
            // posudbeBS
            // 
            this.posudbeBS.DataMember = "posudbe";
            this.posudbeBS.DataSource = this.knjiznicaDS;
            // 
            // knjigaTA
            // 
            this.knjigaTA.ClearBeforeFill = true;
            // 
            // kategorijaTA
            // 
            this.kategorijaTA.ClearBeforeFill = true;
            // 
            // izdavacTA
            // 
            this.izdavacTA.ClearBeforeFill = true;
            // 
            // tipTA
            // 
            this.tipTA.ClearBeforeFill = true;
            // 
            // stsStatus
            // 
            this.stsStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.stsStatus.Location = new System.Drawing.Point(0, 565);
            this.stsStatus.Name = "stsStatus";
            this.stsStatus.Size = new System.Drawing.Size(1234, 22);
            this.stsStatus.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // tmrClearStatus
            // 
            this.tmrClearStatus.Tick += new System.EventHandler(this.tmrClearStatus_Tick);
            // 
            // korisnikTA
            // 
            this.korisnikTA.ClearBeforeFill = true;
            // 
            // posudbeTA
            // 
            this.posudbeTA.ClearBeforeFill = true;
            // 
            // fKknjigatipBindingSource
            // 
            this.fKknjigatipBindingSource.DataMember = "FK_knjiga_tip";
            this.fKknjigatipBindingSource.DataSource = this.tipBS;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 587);
            this.Controls.Add(this.stsStatus);
            this.Controls.Add(this.tbcMenu);
            this.Name = "frmMain";
            this.Text = "Knjižnica";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tbcMenu.ResumeLayout(false);
            this.tabKatalog.ResumeLayout(false);
            this.spcKatalog.Panel1.ResumeLayout(false);
            this.spcKatalog.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcKatalog)).EndInit();
            this.spcKatalog.ResumeLayout(false);
            this.grpUredi.ResumeLayout(false);
            this.grpUredi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjiznicaDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.izdavacBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjigaBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupKomada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipBS)).EndInit();
            this.grpPrikaz.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKatalog)).EndInit();
            this.tabKorisnici.ResumeLayout(false);
            this.scpKorisnici.Panel1.ResumeLayout(false);
            this.scpKorisnici.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scpKorisnici)).EndInit();
            this.scpKorisnici.ResumeLayout(false);
            this.grpKorUredi.ResumeLayout(false);
            this.grpKorUredi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBS)).EndInit();
            this.grpKorPrikaz.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).EndInit();
            this.tabPosudba.ResumeLayout(false);
            this.grpPosPrikaz.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosudbe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posudbeBS)).EndInit();
            this.stsStatus.ResumeLayout(false);
            this.stsStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKknjigatipBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbcMenu;
        private System.Windows.Forms.TabPage tabKatalog;
        private System.Windows.Forms.TabPage tabPosudba;
        private KnjiznicaDS knjiznicaDS;
        private System.Windows.Forms.BindingSource knjigaBS;
        private KnjiznicaDSTableAdapters.knjigaTA knjigaTA;
        private System.Windows.Forms.BindingSource kategorijaBS;
        private KnjiznicaDSTableAdapters.kategorijaTA kategorijaTA;
        private System.Windows.Forms.BindingSource izdavacBS;
        private KnjiznicaDSTableAdapters.izdavacTA izdavacTA;
        private System.Windows.Forms.BindingSource tipBS;
        private KnjiznicaDSTableAdapters.tipTA tipTA;
        private System.Windows.Forms.StatusStrip stsStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Timer tmrClearStatus;
        private System.Windows.Forms.TabPage tabKorisnici;
        private System.Windows.Forms.SplitContainer scpKorisnici;
        private System.Windows.Forms.GroupBox grpKorUredi;
        private System.Windows.Forms.GroupBox grpKorPrikaz;
        private System.Windows.Forms.DataGridView dgvKorisnici;
        private System.Windows.Forms.SplitContainer spcKatalog;
        private System.Windows.Forms.GroupBox grpUredi;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.ComboBox cmbKategorija;
        private System.Windows.Forms.Label lblKategorija;
        private System.Windows.Forms.ComboBox cmbIzdavac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtISBN13;
        private System.Windows.Forms.TextBox txtISBN10;
        private System.Windows.Forms.Label lblISBN13;
        private System.Windows.Forms.Label lblISBN10;
        private System.Windows.Forms.NumericUpDown nupKomada;
        private System.Windows.Forms.Label lblKomada;
        private System.Windows.Forms.ComboBox cmbTip;
        private System.Windows.Forms.TextBox txtGodina;
        private System.Windows.Forms.Label lblGodina;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.GroupBox grpPrikaz;
        private System.Windows.Forms.DataGridView dgvKatalog;
        private System.Windows.Forms.DataGridViewTextBoxColumn naslovDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn tipidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn godinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn izdavacidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn komadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBN10DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBN13DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn kategorijaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtClanskiBroj;
        private System.Windows.Forms.Label lblClanskiBroj;
        private System.Windows.Forms.TextBox txtBrojTelefona;
        private System.Windows.Forms.Label lblBrojTelefona;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Button btnKorIzbrisi;
        private System.Windows.Forms.Button btnKorDodaj;
        private System.Windows.Forms.Button btnKorAzuriraj;
        private System.Windows.Forms.Button btnPosudbe;
        private System.Windows.Forms.GroupBox grpPosPrikaz;
        private System.Windows.Forms.DataGridView dgvPosudbe;
        private System.Windows.Forms.Button bntZaduzi;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojtelefonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource korisnikBS;
        private KnjiznicaDSTableAdapters.korisnikTA korisnikTA;
        private System.Windows.Forms.BindingSource posudbeBS;
        private KnjiznicaDSTableAdapters.posudbeTA posudbeTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBN10DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn naslovDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumizdavanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumrazduzenjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fKknjigatipBindingSource;
    }
}

