using Datos;
using Entidad;
using Logica;
using Microsoft.AspNetCore.Mvc;
using parcial_boris.Models;

namespace parcial_boris.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LiquidacionController : ControllerBase
    {
        private LiquidacionService liquidacionService;

        public LiquidacionController(LiquidacionContext context) => liquidacionService = new LiquidacionService(context);

        [HttpGet]
        public IEnumerable<LiquidacionViewModel> Get() => liquidacionService.ConsultarTodos()!
            .Select(l => new LiquidacionViewModel(l));

        [HttpPost]
        public ActionResult<LiquidacionViewModel> Post(LiquidacionInputModel liquidacion)
        {

            Liquidacion liq = Mapear(liquidacion);

            var respuesta = liquidacionService.Guardar(liq);

            if(respuesta.Error){

                ModelState.AddModelError("Guardar liquidacion", respuesta.Mensaje!);
                var problemDetails = new ValidationProblemDetails(ModelState)
                {
                    Status = StatusCodes.Status400BadRequest,
                };

            }

            return new LiquidacionViewModel(respuesta.Objeto!);
        }

        public Liquidacion Mapear(LiquidacionInputModel liquidacion) {

            Liquidacion liq = new Liquidacion();
            liq.GradoDeAlcohol = liquidacion.GradoDeAlcohol;

            return liq;
        }
    }
}