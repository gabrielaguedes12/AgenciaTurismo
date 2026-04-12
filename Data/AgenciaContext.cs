using Microsoft.EntityFrameworkCore;
using AgenciaTurismo.Models;

namespace AgenciaTurismo.Data
{
    public class AgenciaContext : DbContext
    {
        public AgenciaContext(DbContextOptions<AgenciaContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<PacoteTuristico> Pacotes { get; set; }
    }
}