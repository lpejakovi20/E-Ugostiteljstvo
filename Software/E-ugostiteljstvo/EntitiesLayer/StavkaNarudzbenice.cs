using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class StavkaNarudzbenice
    {
      /*  public StavkaNarudzbenice(int id, string naziv, string vrsta, int kolicina, string mjernajedinica, decimal cijena,decimal iznos)
        {
            Id = id;
            Naziv = naziv;
            Vrsta = vrsta;
            Kolicina = kolicina;
            MjernaJedinica = mjernajedinica;
            Cijena = cijena;
            Iznos = iznos;
        }*/

        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Vrsta { get; set; }
        public int Kolicina { get; set; }
        public string MjernaJedinica { get; set; }

        public decimal Cijena { get; set; }
        public decimal Iznos { get; set; }


    }
}
