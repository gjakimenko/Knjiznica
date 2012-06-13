using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Knjiznica
{
    public partial class frmIzdavanje : Form
    {
        public string ISBN10;
        public int posudbaId;
        public int korisnikId;

        public frmIzdavanje()
        {
            InitializeComponent();
        }

        /**
         * Overload za zaduživanje
         */
        public frmIzdavanje(string ISBN10)
        {
            InitializeComponent();
            
            this.ISBN10 = ISBN10;

            this.posudbaTA.Fill(this.knjiznicaDS.tbl_posudba);
            this.korisnikTA.Fill(this.knjiznicaDS.tbl_korisnik);
            this.knjigaTA.FillByISBN10(this.knjiznicaDS.tbl_knjiga, Convert.ToDouble(this.ISBN10));
            this.izdavacTA.FillById(this.knjiznicaDS.tbl_izdavac, knjiznicaDS.tbl_knjiga.First().izdavac_id);
            this.tipTA.FillById(this.knjiznicaDS.tbl_tip, knjiznicaDS.tbl_knjiga.First().tip_id);
            this.kategorijaTA.FillById(this.knjiznicaDS.tbl_kategorija, knjiznicaDS.tbl_knjiga.First().kategorija_id);

            dtpDatumRazduzivanja.Value = System.DateTime.Now.Add(new System.TimeSpan(21, 0, 0, 0));
            refreshZaduzi();
        }

        /**
         * Overload za razduživanje
         */
        public frmIzdavanje(int posudbaId)
        {
            InitializeComponent();
            
            this.posudbaId = posudbaId;
            
            this.posudbaTA.FillById(this.knjiznicaDS.tbl_posudba, this.posudbaId);
            KnjiznicaDS.tbl_posudbaRow red = this.knjiznicaDS.tbl_posudba.FindByid(this.posudbaId);
            
            this.ISBN10 = red.ISBN10.ToString();
            this.korisnikId = red.korisnik_id;

            this.korisnikTA.FillById(this.knjiznicaDS.tbl_korisnik, this.korisnikId);
            this.knjigaTA.FillByISBN10(this.knjiznicaDS.tbl_knjiga, Convert.ToDouble(this.ISBN10));
            this.izdavacTA.FillById(this.knjiznicaDS.tbl_izdavac, knjiznicaDS.tbl_knjiga.First().izdavac_id);
            this.tipTA.FillById(this.knjiznicaDS.tbl_tip, knjiznicaDS.tbl_knjiga.First().tip_id);
            this.kategorijaTA.FillById(this.knjiznicaDS.tbl_kategorija, knjiznicaDS.tbl_knjiga.First().kategorija_id);

            dtpDatumRazduzivanja.Value = System.DateTime.Now;
            txtClanID.Enabled = false;

            if (red.razduzena)
            {
                btnZaduzi.Enabled = false;
            }
        }

        private void frmIzdavanje_Load(object sender, EventArgs e)
        {

        }

        private void refreshZaduzi()
        {
            try
            {
                int clanId = Convert.ToInt32(txtClanID.Text);
                this.korisnikTA.FillById(knjiznicaDS.tbl_korisnik, int.Parse(txtClanID.Text));
            }
            catch (FormatException)
            {
                this.korisnikTA.Fill(knjiznicaDS.tbl_korisnik);
            }
            finally
            {
                if (this.knjiznicaDS.tbl_korisnik.Count > 0)
                {
                    btnZaduzi.Enabled = true;
                    btnZaduzi.Focus();
                }
                else
                {
                    btnZaduzi.Enabled = false;
                }
            }
        }

        private bool kreirajPosudbu(double ISBN10, int clanId, DateTime datumPosudbe, DateTime datumRazduzivanja)
        {
            try
            {
                this.Validate();
                this.posudbaTA.InsertPosudba(ISBN10, clanId, datumPosudbe, datumRazduzivanja);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
           
        }

        private void txtClanID_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                refreshZaduzi();
            }
        }

        private void txtClanID_Leave(object sender, EventArgs e)
        {
            refreshZaduzi();
        }

        private void btnZaduzi_Click(object sender, EventArgs e)
        {
            if (btnZaduzi.Text == "Zaduži")
            {
                if (kreirajPosudbu(Convert.ToDouble(txtISBN10.Text), Convert.ToInt32(txtClanID.Text), dtpDatumPosudbe.Value, dtpDatumRazduzivanja.Value))
                {
                    MessageBox.Show("Spremljeno!");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Fail!");
                } 
            }
            else if (btnZaduzi.Text == "Razduživanje")
            {
                this.Validate();
                this.posudbaTA.Razduzi(DateTime.Now, true, posudbaId);

                this.Dispose();
            }
        }

        private void txtClanID_Click(object sender, EventArgs e)
        {
            txtClanID.SelectAll();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setActionName(string action)
        {
            btnZaduzi.Text = action;
        }
    }
}
