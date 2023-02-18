namespace LBD.Core.Domain
{
    public class IntervaloTempoDias : IntervaloTempo
    {
        public new DateTime HorarioInicial { get; set; }
        public new DateTime HorarioFinal { get; set; }
        public IntervaloTempoDias(DateTime Inicio, DateTime Fim) 
        {
            HorarioInicial = Inicio;
            HorarioFinal = Fim;
            TempoTotal = Fim.Subtract(Inicio).Duration();
        }
    }
}
