using LBD.Core.Domain;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LBD.Pedidos.Domain
{
    public class ProdutoPorFornecedor
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public Produto Produto { get; set; }
        public decimal ValorProduto { get; set; }
    }
}
