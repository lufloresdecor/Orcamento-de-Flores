
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Tracing;

namespace LBD.Core.Domain
{
    public class Arranjo
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string NomeArranjo { get; set; }
        public Servico MaoDeObra { get; set; }
        public Evento Evento { get; set; }
    }
}
