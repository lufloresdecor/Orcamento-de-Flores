using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using LBD.Core.Domain.Enum;
using System.Security.Cryptography.X509Certificates;

namespace LBD.Core.Domain
{
    public class Evento
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime DataEvento { get; set; }
        public Endereco LocalEvento { get; set; }
        public TipoEventoEnum TipoEvento { get; set; }
        public TimeSpan HorarioEvento { get; set; }
        public Evento() { }
        public Evento(DateTime dataEvento, Endereco localEvento,TipoEventoEnum tipoEvento)
        {
            DataEvento = dataEvento;
            LocalEvento = localEvento;
            TipoEvento = tipoEvento;
            HorarioEvento = dataEvento.TimeOfDay;
        }
        public Evento(DateTime dataEvento, Endereco localEvento, TipoEventoEnum tipoEvento, TimeSpan horarioEvento)
         : this(dataEvento, localEvento, tipoEvento) => HorarioEvento = horarioEvento;
        }
}
