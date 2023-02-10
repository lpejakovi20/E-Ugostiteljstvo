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
    public partial class FrmIzbornikRacunovodstvo : Form
    {
        public FrmIzbornikRacunovodstvo()
        {
            InitializeComponent();
        }

        private void btnPregledNarudzbenica_Click(object sender, EventArgs e)
        {
            var frmNarudzbenice = new FrmNarudzbenice();
            Hide();
            frmNarudzbenice.ShowDialog();
            Close();
        }
    }
}
