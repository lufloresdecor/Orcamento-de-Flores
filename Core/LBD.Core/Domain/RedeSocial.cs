using LBD.Core.Domain.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LBD.Core.Domain
{
    public class RedeSocial
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Usuario { get; set; }
        public string Url { get; set; }
        public TipoRedeSocialEnum TipoRedeSocial { get; set; }
    }
}
