using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

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

        private int findOrCreateTip(string tipNaziv)
        {
            tipTA.FillByNaziv(this.knjiznicaDS.tbl_tip, tipNaziv);

            if (this.knjiznicaDS.tbl_tip.Count > 0)
            {
                return this.knjiznicaDS.tbl_tip.First().id;
            }
            else
            {
                tipTA.InsertByNaziv(tipNaziv);
                return findOrCreateTip(tipNaziv);
            }
          
        }

        private int findOrCreateIzdavac(string izdavacNaziv)
        {
            izdavacTA.FillByNaziv(this.knjiznicaDS.tbl_izdavac, izdavacNaziv);

            if (this.knjiznicaDS.tbl_izdavac.Count > 0)
            {
                return this.knjiznicaDS.tbl_izdavac.First().id;
            }
            else
            {
                izdavacTA.InsertByNaziv(izdavacNaziv);
                return findOrCreateIzdavac(izdavacNaziv);
            }

        }

        private void tmrClearStatus_Tick(object sender, EventArgs e)
        {
            // nakon što timer istekne, makni tekst iz trake i zaustavi timer
            lblStatus.Text = "";
            this.tmrClearStatus.Stop();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                this.knjigaBS.AddNew();
                nupKomada.Value = 0;
            }
            catch
            {
                MessageBox.Show("Polje ne smije biti prazno...");
            }
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            int tipId = findOrCreateTip(cmbTip.Text);
            this.tipTA.Update(knjiznicaDS);
            this.tipTA.Fill(this.knjiznicaDS.tbl_tip);
            dgvKatalog.CurrentRow.Cells[2].Value = tipId;

            int izdavacId = findOrCreateIzdavac(cmbIzdavac.Text);
            this.izdavacTA.Update(knjiznicaDS);
            this.izdavacTA.Fill(this.knjiznicaDS.tbl_izdavac);
            dgvKatalog.CurrentRow.Cells[4].Value = izdavacId;

            this.knjigaBS.EndEdit();
            this.knjigaTA.Update(knjiznicaDS);
            dgvKatalog.Refresh();

            checkIfBookAvailable();

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
            if (!checkIfBookAvailable())
            {
                MessageBox.Show("Nema više raspoloživih knjiga.");
                return;
            }

            frmIzdavanje FrmIzdavanje = new frmIzdavanje(txtISBN10.Text);
            FrmIzdavanje.Show();
        }

        private void dgvKatalog_SelectionChanged(object sender, EventArgs e)
        {
            checkIfBookAvailable();
        }

        private bool checkIfBookAvailable()
        {
            posudbeTA.FillByPosudeno(knjiznicaDS.posudbe, Convert.ToDouble(txtISBN10.Text));
            if (this.knjiznicaDS.posudbe.Count < nupKomada.Value)
            {
                bntZaduzi.Enabled = true;
                return true;
            }
            else
            {
                bntZaduzi.Enabled = false;
                return false;
            }
        }

        private void frmMain_Activated(object sender, EventArgs e)
        {
            checkIfBookAvailable();
            posudbeTA.Fill(this.knjiznicaDS.posudbe);
        }

        private void dgvPosudbe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmIzdavanje FrmIzdavanje = new frmIzdavanje(Convert.ToInt32(dgvPosudbe[0, e.RowIndex].Value));
            FrmIzdavanje.setActionName("Razduživanje");
            FrmIzdavanje.Show();
        }

    }
}
