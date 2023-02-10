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
        }
    }
}
