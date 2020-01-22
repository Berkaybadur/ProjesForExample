using Airport.DataEntities.Context;
using Airport.DataEntities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.DataEntities.Context
{
    public class AirportContext : DbContext
    {
    //    public BerberDBContext(DbContextOptions<BerberDBContext> options) : base(options)
    //    {

    //    }
        public AirportContext() : base("AirportDBConnection")
    {

        Database.SetInitializer<AirportContext>(null);
    }
        public DbSet<Airplane> Airplane { get; set; }
        public DbSet<Airports> Airports { get; set; }
        public DbSet<Countries> Country { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Degree> Degree { get; set; }
        public DbSet<District> District { get; set; }
        public DbSet<Expedition> Expedition { get; set; }
        public DbSet<Personel> Personel { get; set; }
        public DbSet<Province> Province { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<Title> Title { get; set; }
        public DbSet<Classes> Class { get; set; }
        public DbSet<UserTicket> UserTicket { get; set; }

    }
}
