using Entities.Models;
using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities.Repository;

namespace Entities.Repository
{
    public class RegisterRepository
    {
        public Database databasecon;
        public RegisterRepository()
        {
            databasecon = new Database("sqlcon");
        }
        public bool Login(string uname,string pass)
        {
            var s = databasecon.Fetch<Register>($"select * from Register where NotRegistered={(int)IsDeleted.Evet} and CAST(UserName AS BINARY)=CAST('{uname}' as BINARY)  and CAST(Password AS BINARY)=CAST('{pass}' as BINARY)");
            if (s.Count>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Register> GetAllList(bool tt)
        {
            if (tt == false)
                return databasecon.Fetch<Register>($"select * from Register where NotRegistered={(int)IsDeleted.Evet} ");
            else
                return databasecon.Fetch<Register>($"select * from Register ");
        }

        public bool SoftDelete(int id)
        {
            var s = databasecon.Fetch<Register>($"update Register set NotRegistered= {(int)IsDeleted.Hayır} where Id={id}");
            if (s.Count > 0)
            {
                return true;
            }
            return false;
        }

        public int Insert(Register register)
        {
            var id = databasecon.Insert(register);
            return (int)id;
        }

        public int Update(Register register)
        {
            var id = databasecon.Update(register);
            return (int)id;

        }

        enum IsDeleted
        {
            Evet = 0,
            Hayır = 1
        }

        public bool KullaniciKontrol(string UserName, string PhoneNumber, int id = 0)
        {
            Sql builder = new Sql($"select * from Register where NotRegistered=0 and (UserName = '{UserName}' or PhoneNumber = '{PhoneNumber}') ");

            if (id > 0)
            {
                builder.Append($" and  Id !={id}  ");
                //Güncelleme Büyük İse Güncelleme Else İse Zaten Kaydedicek.String Builder İle Her İkisinde Ortak Olanları Tutuyoruz.Lazım Olana Göre ....
            }
            var list = databasecon.Fetch<Register>(builder);
            if (list.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }

}


