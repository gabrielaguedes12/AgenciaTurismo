using AgenciaTurismo.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

public class AgenciaContext : DbContext
{
    public AgenciaContext(DbContextOptions<AgenciaContext> options)
        : base(options)
    {
    }

    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Reserva> Reservas { get; set; }
    public DbSet<PacoteTuristico> Pacotes { get; set; }
    public DbSet<Destino> Destinos { get; set; }
}