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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // popunjavanje table adaptera s podacima
            // 1. tab
            this.tipTA.Fill(this.knjiznicaDS.tbl_tip);
            this.izdavacTA.Fill(this.knjiznicaDS.tbl_izdavac);
            this.kategorijaTA.Fill(this.knjiznicaDS.tbl_kategorija);
            this.knjigaTA.Fill(this.knjiznicaDS.tbl_knjiga);

            // 2. tab
            this.korisnikTA.Fill(this.knjiznicaDS.tbl_korisnik);

            // 3. tab
            this.posudbeTA.Fill(this.knjiznicaDS.posudbe);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // postaviti datasource na null da se forma pravilno ugasi
            dgvKatalog.DataSource = null;
            dgvKorisnici.DataSource = null;
            dgvKorisnici.DataSource = null;
        }

        /*
         * Metoda za zapis statusne poruke u statusnu traku
         */
        public void writeToStatus(String text, int duration)
        {
            lblStatus.Text = text;
            this.tmrClearStatus.Interval = duration;
            this.tmrClearStatus.Start();
        }

        private void tmrClearStatus_Tick(object sender, EventArgs e)
        {
            // nakon što timer istekne, makni tekst iz trake i zaustavi timer
            lblStatus.Text = "";
            this.tmrClearStatus.Stop();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            this.knjigaBS.AddNew();
            nupKomada.Value = 0;
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            this.knjigaBS.EndEdit();
            this.knjigaTA.Update(knjiznicaDS);
            dgvKatalog.Refresh();

            writeToStatus("Katalog ažuriran", 5000);
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            // izbriši trenutno označen red i napravi update table adaptera
            this.knjigaBS.RemoveCurrent();
            this.knjigaTA.Update(knjiznicaDS.tbl_knjiga);
            // refresh data grid view
            dgvKatalog.Refresh();
        }

        private void btnKorDodaj_Click(object sender, EventArgs e)
        {
            this.korisnikBS.AddNew();
        }

        private void btnKorAzuriraj_Click(object sender, EventArgs e)
        {
            this.korisnikBS.EndEdit();
            this.korisnikTA.Update(knjiznicaDS);
            dgvKorisnici.Refresh();

            writeToStatus("Korisnik ažuriran", 5000);
        }

        private void btnKorIzbrisi_Click(object sender, EventArgs e)
        {

        }

        private void btnPosudbe_Click(object sender, EventArgs e)
        {
            tbcMenu.SelectedIndex = 2;
            posudbeTA.FillByKorisnikId(knjiznicaDS.posudbe, Convert.ToInt32(txtClanskiBroj.Text));
            dgvPosudbe.Refresh();
        }

        private void tbcMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tbcMenu.SelectedIndex)
            {
                case 0:
                    dgvKatalog.Refresh();
                    break;
                case 1:
                    dgvKorisnici.Refresh();
                    break;
                case 2:
                    posudbeTA.Fill(knjiznicaDS.posudbe);
                    dgvPosudbe.Refresh();
                    break;
                default:
                    break;
            }
        }

        private void bntZaduzi_Click(object sender, EventArgs e)
        {
            frmIzdavanje FrmIzdavanje = new frmIzdavanje(txtISBN10.Text);
            FrmIzdavanje.Show();
        }
    }
}
