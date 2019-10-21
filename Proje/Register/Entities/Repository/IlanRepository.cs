using Entities.Models;
using PetaPoco;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Entities.Repository
{
  public  class IlanRepository
    {
        public Database databasecon;
        public IlanRepository()
        {
            databasecon = new Database("sqlcon");
        }

        public List<Ilan> GetAllListIlan(bool tt)
        {
            if (tt == false)
                return databasecon.Fetch<Ilan>($"select * from Ilan where IsDeleted={(int)IsDeleted.Evet} ").ToList();
            else
                return databasecon.Fetch<Ilan>($"select * from Ilan ").ToList();
        }

        public bool SoftDeleteIlan(int id)
        {
            var s = databasecon.Fetch<Ilan>($"update Ilan set IsDeleted= {(int)IsDeleted.Hayır} where Id={id}");
            if (s.Count > 0)
            {
                
                return true;
            }
            return false;
        } 
        public int Insert(Ilan ılan)
        {
            var id = databasecon.Insert(ılan);
            return (int)id;
        }
        public int Update(Ilan ılan)
        {
            var id = databasecon.Update(ılan);
            return (int)id;
        }

        public  List<Ilan> SelectedItemIlan(int id)
        {
            return databasecon.Fetch<Ilan>($"select * from Ilan  where Id="+id).ToList();
        }

        public List<Ilan> Search(Ilan model)
        {
            Sql builder = new Sql($"Select * from Ilan where IsDeleted=0 ");
            if (!string.IsNullOrWhiteSpace(model.AracModel))
            {
                builder.Append($" and  AracModel = {model.AracModel} ");
            }
            if (!string.IsNullOrWhiteSpace(model.AracAd))
            {
                builder.Append($" and  AracAd = {model.AracAd} ");
            }
            return databasecon.Fetch<Ilan>(builder);
        }

        public List<Ilan> GetSearch(string aracAd)
        {
            if (true)
            {
                return databasecon.Fetch<Ilan>($"select * from Ilan  where   IsDeleted={(int)IsDeleted.Evet} and AracAd LIKE '" + aracAd + "'  ").ToList();
            }
        }


        public List<Ilan> GetAra(decimal Km,string yil,string renk,string vites,decimal fiyat)
        {
            if (true)
            {
                return databasecon.Fetch<Ilan>($"select * from Ilan  where   IsDeleted={(int)IsDeleted.Evet} and KM  LIKE '" + Km + "' and  Yil LIKE  '" + yil + "'  and  Renk LIKE  '" + renk + "'  and  Vites LIKE  '" + vites + "' and Fiyat LIKE '"+fiyat +"' ").ToList();
            }
        }

        enum IsDeleted
        {
            Evet = 0,
            Hayır = 1
        }
    }
}
