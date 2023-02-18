using LBD.Core.Domain.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LBD.Core.Domain
{
    public class Documento
    {
        public Documento() { NumeroDocumento = ""; }
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string NumeroDocumento { get; set; }
        [Required]
        public TipoDocumentoEnum TipoDocumento { get; set; }
        public DateTime DataEmissao { get; set; }
    }
}
