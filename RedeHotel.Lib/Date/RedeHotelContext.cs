using Microsoft.EntityFrameworkCore;
using RedeHotel.Lib.Models;

namespace RedeHotel.Lib.Date
{
    public class RedeHotelContext : DbContext
    {
        public RedeHotelContext(DbContextOptions context) : base(context)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estadia>().ToTable("Estadia");
            modelBuilder.Entity<Estadia>().HasKey(x => x.Id);
            modelBuilder.Entity<Estadia>().HasOne(x => x.Responsavel).WithMany(x => x.Estadias).HasForeignKey(x => x.IdResposavel); //referências de foreignKey
            modelBuilder.Entity<Estadia>().HasOne(x => x.Quartos).WithMany(x => x.Estadias).HasForeignKey(x => x.IdQuarto);

            modelBuilder.Entity<EstadiasxHospedes>().ToTable("Estadias_x_Hospedes");
            modelBuilder.Entity<EstadiasxHospedes>().HasKey(x => x.Id);
            modelBuilder.Entity<EstadiasxHospedes>().HasOne(x => x.Estadia).WithMany(x => x.Estadias_x_Hospedes).HasForeignKey(x => x.IdEstadia);
            modelBuilder.Entity<EstadiasxHospedes>().HasOne(x => x.Hospede).WithMany(x => x.Estadias_x_Hospedes).HasForeignKey(x => x.IdHospede);

            modelBuilder.Entity<Hospede>().ToTable("Hospede");
            modelBuilder.Entity<Hospede>().HasKey(x => x.Id);

            modelBuilder.Entity<Hotel>().ToTable("Hotel");
            modelBuilder.Entity<Hotel>().HasKey(key => key.Id);

            modelBuilder.Entity<Quartos>().ToTable("Quartos");
            modelBuilder.Entity<Quartos>().HasKey(x => x.Id);
            modelBuilder.Entity<Quartos>().HasOne(x => x.Hotel).WithMany(x => Quartos).HasForeignKey(x => x.IdHotel);            

            modelBuilder.Entity<Servicos>().ToTable("Servicos");
            modelBuilder.Entity<Servicos>().HasKey(x => x.Id);    

            modelBuilder.Entity<ServicosxHoteis>().ToTable("Servicos_x_Hoteis");
            modelBuilder.Entity<ServicosxHoteis>().HasKey(x => x.Id);     

            modelBuilder.Entity<TiposQuartos>().ToTable("TiposQuartos");
            modelBuilder.Entity<TiposQuartos>().HasKey(x => x.Id);    
        }
        public DbSet<Estadia> Estadias { get; set; }
        public DbSet<EstadiasxHospedes> EstadiasXHospedes { get; set; }
        public DbSet<Hospede> Hospedes { get; set; }
        public DbSet<Hotel> Hoteis { get; set; }
        public DbSet<Quartos> Quartos { get; set; }
        public DbSet<Servicos> Servicos { get; set; }
        public DbSet<ServicosxHoteis> ServicosxHoteis { get; set; }
        public DbSet<TiposQuartos> TiposQuartos { get; set; }

    }
}