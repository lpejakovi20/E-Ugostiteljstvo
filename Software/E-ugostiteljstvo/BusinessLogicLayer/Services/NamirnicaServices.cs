using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class NamirnicaServices
    {
        public List<namirnica> GetAll(int id)
        {
            using (var repo = new NamirnicaRepository())
            {
                return repo.GetAll(id).ToList();
            }
        }
    }
}
