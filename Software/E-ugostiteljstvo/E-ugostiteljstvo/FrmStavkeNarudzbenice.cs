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
using EntitiesLayer.Entities;

namespace E_ugostiteljstvo
{

    
    public partial class FrmStavkeNarudzbenice : Form
    {
        private narudzbenica SelektiranaNarudzbenica;

        KatalogNamirnicaServices servisKatalog = new KatalogNamirnicaServices();

        NarudzbenicaServices servisNarudzbenice = new NarudzbenicaServices();
        public FrmStavkeNarudzbenice(narudzbenica _narudzbenica)
        {
            InitializeComponent();
            SelektiranaNarudzbenica = _narudzbenica;
        }

        

        

        private void FrmStavkeNarudzbenice_Load(object sender, EventArgs e)
        {

            var idNarudzbenice = SelektiranaNarudzbenica.id;
            var stavkeNarudzbenice = servisKatalog.GetStavkeNarudzbenice(idNarudzbenice);
            dgvStavkeNarudzbenice.DataSource = stavkeNarudzbenice;

            var selektiranaNarudzbenica = servisNarudzbenice.GetNarudzbenicaById(idNarudzbenice);
            lblIznos.Text = selektiranaNarudzbenica.sveukupan_iznos.ToString();


        }
    }
}
