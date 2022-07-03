using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entidad;

namespace parcial_boris.Models
{
    public class LiquidacionInputModel
    {
        public double GradoDeAlcohol { get; set; }
    }

    public class LiquidacionViewModel : LiquidacionInputModel
    {
        public LiquidacionViewModel(Liquidacion liquidacion) {
            this.Id = liquidacion.Id;
            this.Tarifa =  liquidacion.Tarifa;
            this.Impuesto =  liquidacion.Impuesto;
            this.GradoDeAlcohol =  liquidacion.GradoDeAlcohol;
        }

        public int Id { get; set; }
        public double Tarifa { get; set; }
        public double Impuesto { get; set; }
    }
}