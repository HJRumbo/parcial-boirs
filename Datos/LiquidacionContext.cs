using Entidad;
using Microsoft.EntityFrameworkCore;

namespace Datos;
public class LiquidacionContext : DbContext
{
    public LiquidacionContext(DbContextOptions<LiquidacionContext> options) : base(options)
    {
        
    }
    public DbSet<Liquidacion>? Liduidaciones { get; set; }

}
