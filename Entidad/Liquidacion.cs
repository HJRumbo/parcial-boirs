namespace Entidad;
public class Liquidacion
{
    public int Id { get; set; }
    public double GradoDeAlcohol { get; set; }
    public double Tarifa { get; set; }
    public double Impuesto { get; set; }

    public void CalcularImpuesto()
    {
        if (GradoDeAlcohol <= 35)
        {
            Tarifa = 200;
        }
        else
        {
            Tarifa = 400;
        }

        Impuesto = Tarifa*GradoDeAlcohol;
    }
}
