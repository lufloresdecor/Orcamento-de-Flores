using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using LBD.Core.Domain.Enum;

namespace LBD.Core.Domain
{
    public class Servico
    {
        public Servico() { }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal? ValorHora { get; set; }
        public decimal? ValorFixo { get; set; }
        public virtual Pessoa PessoaResponsavel { get; set; }
        public TipoServicoEnum TipoServicoEnum { get; set; }
        public IntervaloTempo? TempoServico { get; set; }
        public StatusServicoEnum StatusServico { get; set; }
    }
}
