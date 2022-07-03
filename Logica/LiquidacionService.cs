using Datos;
using Entidad;

namespace Logica;
public class LiquidacionService
{
    private readonly LiquidacionContext _context;
    public LiquidacionService(LiquidacionContext context)
    {
        _context = context;
    }

    public IEnumerable<Liquidacion>? ConsultarTodos() => _context.Liduidaciones?.ToList();

    public GuardarResponse<Liquidacion> Guardar(Liquidacion liquidacion)
    {
        try
        {
            liquidacion.CalcularImpuesto();
            
            _context.Liduidaciones?.Add(liquidacion);
            _context.SaveChanges();

            return new GuardarResponse<Liquidacion>(liquidacion);
        }
        catch (System.Exception)
        {
            return new GuardarResponse<Liquidacion>("Error al guardar la liquidación");
        }
    }
}
