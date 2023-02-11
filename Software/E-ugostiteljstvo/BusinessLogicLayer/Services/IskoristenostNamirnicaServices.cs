using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class IskoristenostNamirnicaServices
    {
        public List<dynamic> GetNamirniceIstecenogRoka(int month, int year)
        {
            using (var repo = new IskoristenostNamirnicaRepository())
            {
                return repo.GetIskoristeneNamirniceByMonth(month,year).ToList();
            }
        }
    }
}
