using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TravelApp.Data.Models
{
    public partial class TravelMobilContext : DbContext
    {
        public TravelMobilContext()
        {
        }

        public TravelMobilContext(DbContextOptions<TravelMobilContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AirRoutes> AirRoutes { get; set; }
        public virtual DbSet<AirSeatType> AirSeatType { get; set; }
        public virtual DbSet<AirShipExpedition> AirShipExpedition { get; set; }
        public virtual DbSet<AirShipTickets> AirShipTickets { get; set; }
        public virtual DbSet<AirShips> AirShips { get; set; }
        public virtual DbSet<Airports> Airports { get; set; }
        public virtual DbSet<Articles> Articles { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<District> District { get; set; }
        public virtual DbSet<OtelRooms> OtelRooms { get; set; }
        public virtual DbSet<OtelTypes> OtelTypes { get; set; }
        public virtual DbSet<Otels> Otels { get; set; }
        public virtual DbSet<Provinces> Provinces { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=BERKAY\\SQLEXPRESS;Database=TravelMobil;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AirRoutes>(entity =>
            {
                entity.HasKey(e => e.RoutesId)
                    .HasName("PK__AirRoute__EC7E59D4BE1BA46D");

                entity.Property(e => e.RoutesId).HasColumnName("Routes_Id");

                entity.Property(e => e.FlyDate).HasColumnType("date");

                entity.Property(e => e.RoutesFromId).HasColumnName("Routes_From_Id");

                entity.Property(e => e.RoutesToId).HasColumnName("Routes_To_Id");

                entity.HasOne(d => d.RoutesFrom)
                    .WithMany(p => p.AirRoutesRoutesFrom)
                    .HasForeignKey(d => d.RoutesFromId)
                    .HasConstraintName("FK__AirRoutes__Route__29572725");

                entity.HasOne(d => d.RoutesTo)
                    .WithMany(p => p.AirRoutesRoutesTo)
                    .HasForeignKey(d => d.RoutesToId)
                    .HasConstraintName("FK__AirRoutes__Route__2A4B4B5E");
            });

            modelBuilder.Entity<AirSeatType>(entity =>
            {
                entity.HasKey(e => e.SeatTypeId)
                    .HasName("PK__AirSeatT__9BB5FA086C7F4CC3");

                entity.Property(e => e.SeatTypeId).HasColumnName("SeatType_Id");

                entity.Property(e => e.SeatTypeName)
                    .HasColumnName("SeatType_Name")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<AirShipExpedition>(entity =>
            {
                entity.HasKey(e => e.ExpeditionId)
                    .HasName("PK__AirShipE__0522DA3FF958C540");

                entity.Property(e => e.ExpeditionId).HasColumnName("Expedition_Id");

                entity.Property(e => e.AirShipsIdNumb).HasColumnName("AirShips_IdNumb");

                entity.Property(e => e.IsFull).HasDefaultValueSql("((0))");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.HasOne(d => d.ExpeditionClassNavigation)
                    .WithMany(p => p.AirShipExpedition)
                    .HasForeignKey(d => d.ExpeditionClass)
                    .HasConstraintName("FK__AirShipEx__AirSh__39237A9A");

                entity.HasOne(d => d.ExpeditionClass1)
                    .WithMany(p => p.AirShipExpedition)
                    .HasForeignKey(d => d.ExpeditionClass)
                    .HasConstraintName("FK__AirShipEx__Exped__3A179ED3");
            });

            modelBuilder.Entity<AirShipTickets>(entity =>
            {
                entity.HasKey(e => e.TicketId)
                    .HasName("PK__AirShipT__ED7260B9FBD65127");

                entity.Property(e => e.TicketId).HasColumnName("Ticket_Id");

                entity.Property(e => e.ExpeditionId).HasColumnName("Expedition_Id");

                entity.HasOne(d => d.CustomerNumbNavigation)
                    .WithMany(p => p.AirShipTickets)
                    .HasForeignKey(d => d.CustomerNumb)
                    .HasConstraintName("FK__AirShipTi__Custo__3DE82FB7");

                entity.HasOne(d => d.Expedition)
                    .WithMany(p => p.AirShipTickets)
                    .HasForeignKey(d => d.ExpeditionId)
                    .HasConstraintName("FK__AirShipTi__Custo__3CF40B7E");
            });

            modelBuilder.Entity<AirShips>(entity =>
            {
                entity.Property(e => e.AirShipsId).HasColumnName("AirShips_Id");

                entity.Property(e => e.CardCvv).HasMaxLength(50);

                entity.Property(e => e.CardExpirationDate).HasMaxLength(50);

                entity.Property(e => e.CardNumber).HasMaxLength(50);

                entity.Property(e => e.FlyDate).HasColumnType("date");

                entity.Property(e => e.RouteFrom).HasMaxLength(50);

                entity.Property(e => e.RouteTo).HasMaxLength(50);

            });

            modelBuilder.Entity<Airports>(entity =>
            {
                entity.HasKey(e => e.AirportId)
                    .HasName("PK__Airports__3DBD86F3F2B70194");

                entity.Property(e => e.AirportId).HasColumnName("Airport_Id");

                entity.Property(e => e.AirportName)
                    .HasColumnName("Airport_Name")
                    .HasMaxLength(55);

                entity.Property(e => e.DiscId).HasColumnName("Disc_Id");

                entity.HasOne(d => d.Disc)
                    .WithMany(p => p.Airports)
                    .HasForeignKey(d => d.DiscId)
                    .HasConstraintName("FK__Airports__Disc_I__267ABA7A");
            });

            modelBuilder.Entity<Articles>(entity =>
            {
                entity.Property(e => e.ArticlesId).HasColumnName("Articles_Id");

                entity.Property(e => e.Article).HasColumnType("text");

                entity.Property(e => e.ArticleTitle).HasMaxLength(50);

                entity.Property(e => e.Image).HasColumnType("text");
            });

            modelBuilder.Entity<Countries>(entity =>
            {
                entity.HasKey(e => e.CountryId)
                    .HasName("PK__Countrie__8036CBAEA829126A");

                entity.Property(e => e.CountryId).HasColumnName("Country_Id");

                entity.Property(e => e.CountryDesc).HasColumnType("text");

                entity.Property(e => e.CountryName)
                    .HasColumnName("Country_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.CountryPopulation).HasColumnType("text");

                entity.Property(e => e.Image).HasColumnType("text");
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("PK__Customer__8CB28699F79CD4C0");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_Id");

                entity.Property(e => e.CustomerName)
                    .HasColumnName("Customer_Name")
                    .HasMaxLength(25);

                entity.Property(e => e.CustomerPassword)
                    .HasColumnName("Customer_Password")
                    .HasMaxLength(25);

                entity.Property(e => e.CustomerPhone)
                    .HasColumnName("Customer_Phone")
                    .HasMaxLength(16);

                entity.Property(e => e.CustomerSurname)
                    .HasColumnName("Customer_Surname")
                    .HasMaxLength(25);

                entity.Property(e => e.CustomerUserName)
                    .HasColumnName("Customer_UserName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<District>(entity =>
            {
                entity.Property(e => e.DistrictId).HasColumnName("District_Id");

                entity.Property(e => e.DistrictName)
                    .HasColumnName("District_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.ProvId).HasColumnName("Prov_Id");

                entity.HasOne(d => d.Prov)
                    .WithMany(p => p.District)
                    .HasForeignKey(d => d.ProvId)
                    .HasConstraintName("FK__District__Prov_I__239E4DCF");
            });

            modelBuilder.Entity<OtelRooms>(entity =>
            {
                entity.HasKey(e => e.RoomId)
                    .HasName("PK__OtelRoom__19EE6A13438CFEC1");

                entity.Property(e => e.RoomId).HasColumnName("Room_Id");

                entity.Property(e => e.OteId).HasColumnName("Ote_Id");

                entity.Property(e => e.RoomIsFull)
                    .HasColumnName("Room_IsFULL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RoomPrice)
                    .HasColumnName("Room_Price")
                    .HasColumnType("money");

                entity.HasOne(d => d.Ote)
                    .WithMany(p => p.OtelRooms)
                    .HasForeignKey(d => d.OteId)
                    .HasConstraintName("FK__OtelRooms__Ote_I__52593CB8");
            });

            modelBuilder.Entity<OtelTypes>(entity =>
            {
                entity.HasKey(e => e.TypesId)
                    .HasName("PK__Otel_Typ__B9F9743ADFABB7D3");

                entity.ToTable("Otel_Types");

                entity.Property(e => e.TypesId).HasColumnName("Types_Id");

                entity.Property(e => e.TypesDescription)
                    .HasColumnName("Types_Description")
                    .HasMaxLength(35);
            });

            modelBuilder.Entity<Otels>(entity =>
            {
                entity.HasKey(e => e.OtelId)
                    .HasName("PK__Otels__4345D261B728CB9B");

                entity.Property(e => e.OtelId).HasColumnName("Otel_Id");

                entity.Property(e => e.Image).HasColumnType("text");

                entity.Property(e => e.OtelAddress)
                    .HasColumnName("Otel_Address")
                    .HasMaxLength(255);

                entity.Property(e => e.OtelDistrictId).HasColumnName("Otel_District_Id");

                entity.Property(e => e.OtelName)
                    .HasColumnName("Otel_Name")
                    .HasMaxLength(55);

                entity.Property(e => e.OtelTypeId).HasColumnName("Otel_Type_Id");

                entity.Property(e => e.Rooms).HasColumnType("text");

                entity.HasOne(d => d.OtelDistrict)
                    .WithMany(p => p.Otels)
                    .HasForeignKey(d => d.OtelDistrictId)
                    .HasConstraintName("FK__Otels__Otel_Dist__4D94879B");

                entity.HasOne(d => d.OtelType)
                    .WithMany(p => p.Otels)
                    .HasForeignKey(d => d.OtelTypeId)
                    .HasConstraintName("FK__Otels__Otel_Type__4E88ABD4");
            });

            modelBuilder.Entity<Provinces>(entity =>
            {
                entity.HasKey(e => e.ProvinceId)
                    .HasName("PK__Province__D445B662E10A6797");

                entity.Property(e => e.ProvinceId).HasColumnName("Province_Id");

                entity.Property(e => e.ContId).HasColumnName("Cont_Id");

                entity.Property(e => e.ProvName)
                    .HasColumnName("Prov_Name")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Cont)
                    .WithMany(p => p.Provinces)
                    .HasForeignKey(d => d.ContId)
                    .HasConstraintName("FK__Provinces__Cont___20C1E124");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
