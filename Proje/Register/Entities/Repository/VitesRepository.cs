using Entities.Models;
using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities.Repository
{
    public class VitesRepository
    {
        public Database databasecon;
        public VitesRepository()
        {
            databasecon = new Database("sqlcon");
        }

        public List<Vites> GetAllListVites(bool tt)
        {
            if (tt == false)
                return databasecon.Fetch<Vites>($"select * from Ilan where IsDeleted={(int)IsDeleted.Evet} ").ToList();
            else
                return databasecon.Fetch<Vites>($"select * from AracVites").ToList();
        }

        public List<Vites> GetAllVitesId(string code)
        {
            return databasecon.Fetch<Vites>($"select * from AracVites where  VitesKod= '{code}' ").ToList();

        }
    }
}
