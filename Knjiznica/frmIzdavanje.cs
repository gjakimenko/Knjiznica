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

        public frmIzdavanje()
        {
            InitializeComponent();
        }

        public frmIzdavanje(string ISBN10)
        {
            InitializeComponent();
            this.ISBN10 = ISBN10;
        }

        private void frmIzdavanje_Load(object sender, EventArgs e)
        {
            this.posudbaTA.Fill(this.knjiznicaDS.tbl_posudba);
            this.korisnikTA.Fill(this.knjiznicaDS.tbl_korisnik);
            this.knjigaTA.FillByISBN10(this.knjiznicaDS.tbl_knjiga, Convert.ToDouble(this.ISBN10));
            this.izdavacTA.FillById(this.knjiznicaDS.tbl_izdavac, knjiznicaDS.tbl_knjiga.First().izdavac_id);
            this.tipTA.FillById(this.knjiznicaDS.tbl_tip, knjiznicaDS.tbl_knjiga.First().tip_id);
            this.kategorijaTA.FillById(this.knjiznicaDS.tbl_kategorija, knjiznicaDS.tbl_knjiga.First().kategorija_id);

            dtpDatumRazduzivanja.Value = System.DateTime.Now.Add(new System.TimeSpan(21, 0, 0, 0));
            refreshZaduzi();
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

        private void txtClanID_Click(object sender, EventArgs e)
        {
            txtClanID.SelectAll();
        }
    }
}
