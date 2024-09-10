

namespace SEGURA_ASSETMENTS.Models
{
    public class Tarifa
{
    public int ID_Tarifa { get; set; }
    public int ID_Sede { get; set; }
    public int NumeroPersonas { get; set; }
    public int NumeroHabitaciones { get; set; }
    public string TipoAlojamiento { get; set; }
    public decimal TarifaValor { get; set; }

    // Relaciones
    public Sede Sede { get; set; }
}

}