using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer.Services;
using EntitiesLayer;
using EntitiesLayer.Entities;

namespace E_ugostiteljstvo
{
    public partial class FrmKreirajNarudžbenicu : Form
    {
        KatalogNamirnicaServices servisNamirnica = new KatalogNamirnicaServices();
        NarudzbenicaServices servisNarudzbenica = new NarudzbenicaServices();
        StavkeNarudzbeniceServices servisStavke = new StavkeNarudzbeniceServices();

        public FrmKreirajNarudžbenicu()
        {
            InitializeComponent();
        }

        private void FrmKreirajNarudžbenicu_Load(object sender, EventArgs e)
        {
            PrikaziNamirnice();
        }

        private void PrikaziNamirnice()
        {
            var namirniceIzKataloga = servisNamirnica.GetKatalogNamirnica();
            dgvNamirnice.DataSource = namirniceIzKataloga;
            dgvNamirnice.Columns[7].Visible = false;
            dgvNamirnice.Columns[9].Visible = false;
            dgvNamirnice.Columns[10].Visible = false;
            dgvNamirnice.Columns[11].Visible = false;
            dgvNamirnice.Columns[12].Visible = false;
        }

        private void btnTraži_Click(object sender, EventArgs e)
        {
            string phrase = txtTraži.Text;
            var katalogNamirnica = servisNamirnica.GetKatalogNamirnicaByName(phrase);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = katalogNamirnica;
            dgvNamirnice.DataSource = bindingSource;
        }

       
        List<StavkaNarudzbenice> stavkeNarudzbenice = new List<StavkaNarudzbenice>();
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            

           
            if(txtKolicina.Text == "")
            {
                MessageBox.Show("Potrebno je unjeti količinu!");
                    
            }
            else
            {
                var selektiranaNamirnica = dgvNamirnice.CurrentRow.DataBoundItem as namirnica_u_katalogu;
                StavkaNarudzbenice novaStavka = new StavkaNarudzbenice
                (

                    selektiranaNamirnica.id,
                    selektiranaNamirnica.naziv,
                    selektiranaNamirnica.vrsta,
                    Int32.Parse(txtKolicina.Text),
                    selektiranaNamirnica.mjerna_jedinica,
                    selektiranaNamirnica.cijena,
                    selektiranaNamirnica.cijena * Int32.Parse(txtKolicina.Text)
                );
                stavkeNarudzbenice.Add(novaStavka);
                OsvjeziStavkeNarudzbenice();
                txtKolicina.Text = "";
            }
            

            

        }

        private void OsvjeziStavkeNarudzbenice()
        {
            dgvNarudžbenica.DataSource = stavkeNarudzbenice.ToList();
        
        }

        private void btnMakni_Click(object sender, EventArgs e)
        {
            var selektiranaStavka = dgvNarudžbenica.CurrentRow.DataBoundItem as StavkaNarudzbenice;

            stavkeNarudzbenice.RemoveAll(R => R.Id == selektiranaStavka.Id);
            OsvjeziStavkeNarudzbenice();

        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            int _id = GenerateRandomnumber();
            
            decimal sveukupanIznos = 0;
            foreach (var stavka in stavkeNarudzbenice)
            {
                sveukupanIznos += stavka.Iznos;

            }
            DateTime datumKreiranja = DateTime.Now;
            narudzbenica _narudzbenica = new narudzbenica
            {
                id = _id,
                datum_kreiranja = datumKreiranja,
                sveukupan_iznos = sveukupanIznos,
                broj_stavki = stavkeNarudzbenice.Count,
                zaposlenik_id = LogiraniZaposlenik.Id
            };
            servisNarudzbenica.AddNarudzbenica(_narudzbenica);

            foreach (DataGridViewRow row in dgvNarudžbenica.Rows)
            {
                var selectedRow = row.DataBoundItem as StavkaNarudzbenice;
                var novaStavka = new namirnica_narudzbenica { 
                kolicina = selectedRow.Kolicina,
                narudzbenica_id = _id,
                namirnica_u_katalogu_id = selectedRow.Id               
                };
                servisStavke.AddStavkeNarudzbenice(novaStavka);
            }

            MessageBox.Show("Narudžbenica je usjpešo kreirana.");

        }


        private int GenerateRandomnumber()
        {
            long milliseconds = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            var tempstring = milliseconds.ToString();
            tempstring = tempstring.Substring(5);
            int random = int.Parse(tempstring);
            return random;
        }
    }
}
