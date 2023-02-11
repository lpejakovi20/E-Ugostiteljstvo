using BusinessLogicLayer.Services;
using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_ugostiteljstvo
{
    public partial class FrmStatistikaIskoristenosti : Form
    {
        public FrmStatistikaIskoristenosti()
        {
            InitializeComponent();
        }

        private void FrmStatistikaIskoristenosti_Load(object sender, EventArgs e)
        {
            var servis = new NamirnicaServices();
            var listaNamirnica = servis.GetNamirniceIstecenogRoka();

            dgvNamirniceIstekaoRok.DataSource = listaNamirnica;

            decimal sveukupno = 0;

            foreach (DataGridViewRow row in dgvNamirniceIstekaoRok.Rows)
            {

                sveukupno += decimal.Parse(row.Cells[6].Value.ToString());   
            }

            dgvNamirniceIstekaoRok.Columns[6].Visible = false;

            txtSveukupnaVrijednost.Text = Math.Round(sveukupno, 2).ToString() + "€";
        }
    }
}
