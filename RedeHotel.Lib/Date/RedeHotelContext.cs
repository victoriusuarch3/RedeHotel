using Microsoft.EntityFramework;
using RedeHotel.Models;

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
            modelBuilder.Entity<Estadia>().HasOne(x => x.IdResposavel);
            modelBuilder.Entity<Estadia>().HasOne(x => x.IdQuarto);

            modelBuilder.Entity<Estadias_x_Hospedes>().ToTable("Estadias_x_Hospedes");
            modelBuilder.Entity<Estadias_x_Hospedes>().HasKey(x => x.Id);
            modelBuilder.Entity<Estadias_x_Hospedes>().HasOne(x => x.IdEstadia);
            modelBuilder.Entity<Estadias_x_Hospedes>().HasOne(x => x.IdHospede);

            modelBuilder.Entity<Hospede>().ToTable("Hospede");
            modelBuilder.Entity<Hospede>().HasKey(x => x.Id);

            modelBuilder.Entity<Hotel>().ToTable("Hotel");
            modelBuilder.Entity<Hotel>().HasKey(key => key.Id);

            modelBuilder.Entity<Quarto>().ToTable("Quartos");
            modelBuilder.Entity<Quarto>().HasKey(x => x.Id);
            modelBuilder.Entity<Quarto>().HasOne(x => x.IdHotel).WithMany(x => Quartos).HasForeignKey(x => x.IdHotel);            

            modelBuilder.Entity<Servico>().ToTable("Servicos");
            modelBuilder.Entity<Servico>().HasKey(x => x.Id);    

            modelBuilder.Entity<ServicoXHotel>().ToTable("Servicos_x_Hoteis");
            modelBuilder.Entity<ServicoXHotel>().HasKey(x => x.Id);     

            modelBuilder.Entity<TipoQuarto>().ToTable("TiposQuartos");
            modelBuilder.Entity<TipoQuarto>().HasKey(x => x.Id);    
        }
        public DbSet<Estadia> Estadias { get; set; }
        public DbSet<EstadiaXHospede> EstadiasXHospedes { get; set; }
        public DbSet<Hospede> Hospedes { get; set; }
        public DbSet<Hotel> Hoteis { get; set; }
        public DbSet<Quarto> Quartos { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<ServicoXHotel> ServicosXHoteis { get; set; }
        public DbSet<TipoQuarto> TiposQuartos { get; set; }

    }
}