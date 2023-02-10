using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class NamirnicaRepository : Repository<namirnica>
    {
        public NamirnicaRepository() : base(new DBModel())
        {
        }

        public override int Update(namirnica entity, bool saveChanges = true)
        {
            if (saveChanges)
            {
                return SaveChanges();
            }
            else
            {
                return 0;
            }
        }

        public IQueryable<namirnica> GetAll(int id)
        {
            var query = from p in Entities.Include("namirnica_u_katalogu")
                        where p.namirnica_u_katalogu_id == id
                        select p;
            return query;
        }
    }
}
