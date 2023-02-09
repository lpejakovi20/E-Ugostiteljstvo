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

namespace E_ugostiteljstvo
{
    public partial class FrmKreirajNarudžbenicu : Form
    {
        KatalogNamirnicaServices servisNamirnica = new KatalogNamirnicaServices();
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
        }
    }
}
