using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LBD.Core.Domain
{
    [Owned]
    public class IntervaloTempo
    {
        public virtual TimeSpan HorarioInicial { get; set; }
        public virtual TimeSpan HorarioFinal { get; set; }
        public TimeSpan TempoTotal { get; protected set; }
        public IntervaloTempo() { }
        public IntervaloTempo(TimeSpan horarioInicial,TimeSpan horarioFinal)
        {
            HorarioFinal= horarioFinal;
            HorarioInicial= horarioInicial;
            TempoTotal = horarioFinal.Subtract(horarioInicial);
        }
    }
}
