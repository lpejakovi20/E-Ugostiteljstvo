using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;

namespace BusinessLogicLayer.Services
{
    public class NarudzbenicaServices
    {
        public bool AddNarudzbenica(narudzbenica _narudzbenica)
        {
            bool isSuccessful = false;
            using (var repo = new NarudzbenicaRepository())
            {
                int affectedRows = repo.Add(_narudzbenica);
                isSuccessful = affectedRows > 0;
            }
            return isSuccessful;
        }
    }
}
