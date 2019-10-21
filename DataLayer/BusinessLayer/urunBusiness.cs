using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class urunBusiness : BusinessLayer<urunler>
    {
        LimanOtomEntities1 le = new LimanOtomEntities1();
        public override void Create(urunler t)
        {
            le.urunlers.Add(t);
            le.SaveChanges();
        }

        public override void Delete(int id)
        {
            urunler ur = le.urunlers.Find(id);
            le.urunlers.Remove(ur);
            le.SaveChanges();
        }

        public override void Delete(urunler t)
        {
            le.urunlers.Remove(t);
            le.SaveChanges();
        }

        public override List<urunler> List()
        {
            return le.urunlers.ToList();
        }

        public override urunler Read(int id)
        {
            return le.urunlers.SingleOrDefault(u => u.UrunId == id);
        }

        public override void Update(urunler t)
        {
            le.urunlers.Attach(t);
            le.Entry(t).State = System.Data.Entity.EntityState.Modified;
            le.SaveChanges();
        }
    }
}
