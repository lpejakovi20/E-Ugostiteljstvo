using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccessLayer.Repositories
{
    public class KatalogNamirnicaRepository : Repository<namirnica_u_katalogu>
    {
        public KatalogNamirnicaRepository() : base(new DBModel())
        {
        }

        public IQueryable<namirnica_u_katalogu> GetAll()
        {
            var query = from p in Entities.Include("zaposlenik")
                        select p;
            return query;
        }
        public IQueryable<namirnica_u_katalogu> GetKatalogNamirnicaByName(string phrase)
        {
            var query = from p in Entities.Include("zaposlenik") where p.naziv.Contains(phrase)
                        select p;
            return query;
        }

        public IQueryable<namirnica_u_katalogu> GetMlijecni()
        {
            var query = from p in Entities.Include("zaposlenik")
                        where p.vrsta.Contains("Mliječni")
                        select p;
            return query;
        }

        public IQueryable<namirnica_u_katalogu> GetMeso()
        {
            var query = from p in Entities.Include("zaposlenik")
                        where p.vrsta.Contains("Meso")
                        select p;
            return query;
        }


        public override int Update(namirnica_u_katalogu entity, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }
    }
}
