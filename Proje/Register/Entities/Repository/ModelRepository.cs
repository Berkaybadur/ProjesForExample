using Entities.Models;
using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities.Repository
{
   public class ModelRepository
    {

        public Database databasecon;
        public ModelRepository()
        {
            databasecon = new Database("sqlcon");
        }


        public List<AracModel> GetAllListModel(bool tt)
        {
            if (tt == false)
                return databasecon.Fetch<AracModel>($"select * from AracModel where IsDeleted={(int)IsDeleted.Evet} ").ToList();
            else
                return databasecon.Fetch<AracModel>($"select * from AracModel ").ToList();
        }


        public List<AracModel> GetAllListAracModel(string code)
        {
         return databasecon.Fetch<AracModel>($"select * from AracModel where IsDeleted={(int)IsDeleted.Evet} and  AracCode = '{code}' ").ToList();
           
        }

        public List<AracModel> GetAllListAracModel(int id)
        {
            return databasecon.Fetch<AracModel>($"select * from AracModel where IsDeleted={(int)IsDeleted.Evet} and  ModelId = '{id}' ").ToList();

        }

        public List<AracModel> GetAllAracModelCode(string code)
        {
            return databasecon.Fetch<AracModel>($"select * from AracModel where IsDeleted={(int)IsDeleted.Evet} and  AracCode = '{code}' ").ToList();

        }

        public List<AracModel> GetAllAracModelAd(string ad)
        {
            return databasecon.Fetch<AracModel>($"select * from AracModel where IsDeleted={(int)IsDeleted.Evet} and  ModelAd = '{ad}' ").ToList();

        }


        public bool SoftDeleteAracModel(int id)
        {
            var s = databasecon.Fetch<AracModel>($"update AracModel set IsDeleted= {(int)IsDeleted.Hayır} where Id={id}");
            if (s.Count > 0)
            {
                return true;
            }
            return false;
        }
        public int Insert(AracModel aracmodel)
        {
            var id = databasecon.Insert(aracmodel);
            return (int)id;
        }
        public int Update(AracModel aracmodel)
        {
            var id = databasecon.Update(aracmodel);
            return (int)id;
        }


        public List<Arac> GetViewAracModelId(string aracAdi)
        {
            return databasecon.Fetch<Arac>($"select * from VwListArac where AracAd=" + "'" + aracAdi + "'").ToList();
        }

        public List<Arac> GetAracModelId(string aracAdi)
        {
            return databasecon.Fetch<Arac>($"select * from Araba where AracAd=" + "'" + aracAdi + "'").ToList();
        }

        public List<AracModel> GetAllModel(bool tt)
        {
            if (tt == false)
                return databasecon.Fetch<AracModel>($"select * from AracModel where IsDeleted={(int)IsDeleted.Evet} ").ToList();
            else
                return databasecon.Fetch<AracModel>($"select * from AracModel ").ToList();
        }
    }

  

    enum IsDeleted
        {
            Evet = 0,
            Hayır = 1
        }
    }

