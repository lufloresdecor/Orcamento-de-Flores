using LBD.Core.Domain;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LBD.Pedidos.Domain
{
    public class Fornecedor : PessoaJuridica
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public new int Id { get; set; }
        public bool FazEntrega { get; set; }
        public virtual FrequenciaEntrega? FrequenciaEntrega { get; set; }
        public virtual IntervaloTempo? HorarioFuncionamento { get; set; }
        public bool TemPedido { get; set; }
        public virtual List<Produto>? PedidoAtivo { get; set; }
    }
}