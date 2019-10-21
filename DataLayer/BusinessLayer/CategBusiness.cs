using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CategBusiness : BusinessLayer<urunKateg>
    {
        LimanOtomEntities1 le = new LimanOtomEntities1();
        public override void Create(urunKateg t)
        {
            le.urunKategs.Add(t);
            le.SaveChanges();
        }

        public override void Delete(int id)
        {
            urunKateg uk = new urunKateg();
            le.urunKategs.Remove(uk);
            le.SaveChanges();
        }

        public override void Delete(urunKateg t)
        {
            le.urunKategs.Remove(t);
            le.SaveChanges();
        }

        public override List<urunKateg> List()
        {
            return le.urunKategs.ToList();
        }

        public override urunKateg Read(int id)
        {
            return le.urunKategs.SingleOrDefault(uk => uk.KategoriId == id);
        }

        public override void Update(urunKateg t)
        {
            le.urunKategs.Attach(t);
            le.Entry(t).State = System.Data.Entity.EntityState.Modified;
            le.SaveChanges();
        }
    }
}
