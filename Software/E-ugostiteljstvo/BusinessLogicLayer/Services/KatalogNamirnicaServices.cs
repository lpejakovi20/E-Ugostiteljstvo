using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class KatalogNamirnicaServices
    {
        public List<namirnica_u_katalogu> GetKatalogNamirnica()
        {
            using (var repo = new KatalogNamirnicaRepository())
            {
                return repo.GetAll().ToList();
            }
        }

        public List<namirnica_u_katalogu> GetKatalogNamirnicaByName(string phrase)
        {
            using (var repo = new KatalogNamirnicaRepository())
            {
                return repo.GetKatalogNamirnicaByName(phrase).ToList();
            }
        }

        public List<namirnica_u_katalogu> GetMlijecni()
        {
            using (var repo = new KatalogNamirnicaRepository())
            {
                return repo.GetMlijecni().ToList();
            }
        }

        public List<namirnica_u_katalogu> GetMeso()
        {
            using (var repo = new KatalogNamirnicaRepository())
            {
                return repo.GetMeso().ToList();
            }
        }

        public List<namirnica_u_katalogu> SortKraciRok()
        {
            using (var repo = new KatalogNamirnicaRepository())
            {
                return repo.GetAll().OrderBy(x => x.rok_uporabe).ToList();
            }
        }

        public List<namirnica_u_katalogu> SortDuziRok()
        {
            using (var repo = new KatalogNamirnicaRepository())
            {
                return repo.GetAll().OrderByDescending(x => x.rok_uporabe).ToList();
            }
        }
        public List<namirnica_u_katalogu> SortManjaCijena()
        {
            using (var repo = new KatalogNamirnicaRepository())
            {
                return repo.GetAll().OrderBy(x => x.cijena).ToList();
            }
        }
        public List<namirnica_u_katalogu> SortVecaCijena()
        {
            using (var repo = new KatalogNamirnicaRepository())
            {
                return repo.GetAll().OrderByDescending(x => x.cijena).ToList();
            }
        }

    }
}
