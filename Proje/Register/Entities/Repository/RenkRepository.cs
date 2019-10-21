using Entities.Models;
using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities.Repository
{
  public  class RenkRepository
    {
        public Database databasecon;
        public RenkRepository()
        {
            databasecon = new Database("sqlcon");
        }
        public List<Renk> GetAllListRenk(bool tt)
        {
            if (tt == false)
                return databasecon.Fetch<Renk>($"select * from Ilan where IsDeleted={(int)IsDeleted.Evet} ").ToList();
            else
                return databasecon.Fetch<Renk>($"select * from Renk").ToList();
        }

        public List<Renk> GetAllListRenkId(string  code)
        {
            return databasecon.Fetch<Renk>($"select * from Renk where  RenkKod= '{code}' ").ToList();

        }

    }
}
