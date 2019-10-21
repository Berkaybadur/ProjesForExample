using Entities.Models;
using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities.Repository
{
    public class AracRepository
    {
        public Database databasecon;
        public AracRepository()
        {
            databasecon = new Database("sqlcon");
        }

        public List<Arac> GetAllListArac(bool tt)
        {
            if (tt == false)
                return databasecon.Fetch<Arac>($"select * from Araba where IsDeleted={(int)IsDeleted.Evet} ").ToList();
            else
                return databasecon.Fetch<Arac>($"select * from Register ").ToList();
        }

        public bool SoftDeleteArac(int id)
        {
            var s = databasecon.Fetch<Arac>($"update Araba set IsDeleted= {(int)IsDeleted.Hayır} where Id={id}");
            if (s.Count > 0)
            {
                return true;
            }
            return false;
        }
        public int Insert(Arac arac)
        {
            var id = databasecon.Insert(arac);
            return (int)id;
        }
        public int Update(Arac arac)
        {
            var id = databasecon.Update(arac);
            return (int)id;
        }
        public List<Arac> GetAracKod(string aracAdi)
        {
            return databasecon.Fetch<Arac>($"select * from Araba where AracAd=" + "'" + aracAdi + "'").ToList();
        }
        public List<Arac> GetAracList(int id)
        {
            return databasecon.Fetch<Arac>($"select * from VwListArac where   IsDeleted= {(int)IsDeleted.Evet} and ModelId=" + id).ToList(); 

        }
        enum IsDeleted
        {
            Evet = 0,
            Hayır = 1
        }
    }
}
