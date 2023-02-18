using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LBD.Core.Domain.Enum;

namespace LBD.Pedidos.Domain
{
    public class FrequenciaEntrega
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public bool TemDiaFixo { get; set; }
        public DiasDaSemanaEnum? DiaFixo { get; set; }
        public DateTime? UltimaEntrega { get; set; }
        public DateTime? ProximaEntregaPrevista { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }
    }
}
