using BusinessLogicLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace E_ugostiteljstvo
{
    public partial class FrmKatalogNamirnica : Form
    {
        private KatalogNamirnicaServices services = new KatalogNamirnicaServices();
        public FrmKatalogNamirnica()
        {
            InitializeComponent();
        }

        private void FrmKatalogNamirnica_Load(object sender, EventArgs e)
        {
            ShowKatalogNamirnica();
        }

        private void ShowKatalogNamirnica()
        {
            var katalogNamirnica = services.GetKatalogNamirnica();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = katalogNamirnica;
            dgvKatalogNamirnica.DataSource = bindingSource;
            dgvKatalogNamirnica.Columns[7].Visible = false;
            dgvKatalogNamirnica.Columns[9].Visible = false;
            dgvKatalogNamirnica.Columns[10].Visible = false;
            dgvKatalogNamirnica.Columns[11].Visible = false;
            dgvKatalogNamirnica.Columns[12].Visible = false;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string phrase = txtSearch.Text;
            var katalogNamirnica = services.GetKatalogNamirnicaByName(phrase);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = katalogNamirnica;
            dgvKatalogNamirnica.DataSource = bindingSource;


            Filtered(cmbFilters.SelectedIndex);
            cmbFilters.SelectedIndex = -1;
        }

        private void Filtered(int optionIndex)
        {
            switch (optionIndex)
            {
                case 0: ShowMlijecni(); break;
                case 1: ShowMeso(); break;
                default:
                    break;
            }
        }

        private void ShowMeso()
        {
            var katalogNamirnica = services.GetMeso();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = katalogNamirnica;
            dgvKatalogNamirnica.DataSource = bindingSource;
        }

        private void ShowMlijecni()
        {
            var katalogNamirnica = services.GetMlijecni();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = katalogNamirnica;
            dgvKatalogNamirnica.DataSource = bindingSource;
        }

        private void btnObrisiPrikaz_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();

            ShowKatalogNamirnica();

        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            Sort(cmbSort.SelectedIndex);
        }

        private void Sort(int selectedIndex)
        {
            switch (selectedIndex)
            {
                case 0:
                    SortirajPoKracemRoku();
                    break;
                case 1: SortirajPoDuzemRoku();
                    break;
                case 2:
                    SortirajPoManjojCijeni();
                    break;
                case 3:
                    SortirajPoVecojCijeni();
                    break;

                default:
                    break;
            }
        }

        private void SortirajPoVecojCijeni()
        {
            var katalogNamirnica = services.SortVecaCijena();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = katalogNamirnica;
            dgvKatalogNamirnica.DataSource = bindingSource;
        }

        private void SortirajPoManjojCijeni()
        {
            var katalogNamirnica = services.SortManjaCijena();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = katalogNamirnica;
            dgvKatalogNamirnica.DataSource = bindingSource;
        }

        private void SortirajPoDuzemRoku()
        {
            var katalogNamirnica = services.SortDuziRok();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = katalogNamirnica;
            dgvKatalogNamirnica.DataSource = bindingSource;
        }

        private void SortirajPoKracemRoku()
        {
            var katalogNamirnica = services.SortKraciRok();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = katalogNamirnica;
            dgvKatalogNamirnica.DataSource = bindingSource;
        }
    }
}
