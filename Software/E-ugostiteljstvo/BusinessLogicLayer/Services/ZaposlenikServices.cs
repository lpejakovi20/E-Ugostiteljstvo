using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;

namespace BusinessLogicLayer.Services
{
    public class ZaposlenikServices
    {
        public bool AddZaposlenik(zaposlenik _zaposlenik)
        {
            bool isSuccessful = false;
            using (var repo = new ZaposlenikRepository())
            {
                int affectedRows = repo.Add(_zaposlenik);
                isSuccessful = affectedRows > 0;
            }
            return isSuccessful;
        }
        public List<zaposlenik> GetZaposlenici()
        {
            using (var repo = new ZaposlenikRepository())
            {
                return repo.GetAll().ToList();
            }
        }

        public zaposlenik GetZaposlenikByEmail(string phrase)
        {
            using (var repo = new ZaposlenikRepository())
            {
                return repo.GetZaposlenikByEmail(phrase);
            }
        }
    }
}
