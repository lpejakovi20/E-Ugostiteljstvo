using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class IskoristenostNamirnicaRepository : Repository<iskoristenost_namirnice>
    {
        public IskoristenostNamirnicaRepository() : base(new DBModel())
        {

        }

        public override int Update(iskoristenost_namirnice entity, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }

        public IQueryable<dynamic> GetIskoristeneNamirniceByMonth(int month, int year)
        {
            var result = from p in Entities
                         join n in Context.namirnica_u_katalogu on p.namirnica_u_katalogu_id equals n.id into pn
                         from n in pn where p.datum.Month == month && p.datum.Year == year
                         select new
                         {
                             p.namirnica_u_katalogu_id,
                             n.naziv,
                             n.vrsta,
                             p.iskoristeno,
                             n.mjerna_jedinica
                         };

            return result;
        }

    }
}
