﻿using BusinessLogicLayer.Services;
using DataAccessLayer;
using EntitiesLayer.Entities;
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
    public partial class FrmStavkeIzdatnice : Form
    {
        public FrmStavkeIzdatnice()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FrmDodajStavkuIzdatnice form = new FrmDodajStavkuIzdatnice();
            form.ShowDialog();
            OsvjeziStavkeIzdatnice();
        }

        private void FrmStavkeIzdatnice_Load(object sender, EventArgs e)
        {
            StavkaIzdatniceRepository.lista = new List<StavkaIzdatnice>();
            OsvjeziStavkeIzdatnice();
        }

        public void OsvjeziStavkeIzdatnice()
        {
            var stavke = StavkaIzdatniceRepository.GetList();
            dgvStavkeIzdatnice.DataSource = stavke.ToList();
            dgvStavkeIzdatnice.Columns[1].Visible = false;

        }

        private void btnUkloni_Click(object sender, EventArgs e)
        {
            var odabranaStavka = dgvStavkeIzdatnice.CurrentRow.DataBoundItem as StavkaIzdatnice;
            StavkaIzdatniceRepository.lista.RemoveAll(s => s.Temp_id == odabranaStavka.Temp_id);
            OsvjeziStavkeIzdatnice();
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            if(dgvStavkeIzdatnice.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvStavkeIzdatnice.Rows)
                {
                    StavkaIzdatnice namirnica = row.DataBoundItem as StavkaIzdatnice;

                    var novaNamirnica = new namirnica
                    {
                        kolicina = namirnica.Kolicina,
                        rok = namirnica.Rok_trajanja,
                        namirnica_u_katalogu_id = namirnica.Id
                    };

                    var servis = new NamirnicaServices();
                    servis.UpdateNamirnica(novaNamirnica);
                }
                StavkaIzdatniceRepository.lista.Clear();
                OsvjeziStavkeIzdatnice();
                MessageBox.Show("Uspješno kreirana izdatnica!");
            }
            else
            {
                MessageBox.Show("Nije unešena niti jedna stavka!");
            }
        }
    }
}
