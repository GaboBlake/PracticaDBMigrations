using Microsoft.EntityFrameworkCore;
using PracticaDBMigrations.Entities;

public class ApplicationDBContext : DbContext
{
    public ApplicationDBContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<SucursalEntity> Sucursal => Set<SucursalEntity>();
}