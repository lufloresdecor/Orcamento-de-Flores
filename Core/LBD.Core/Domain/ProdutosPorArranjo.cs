using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LBD.Core.Domain
{
    public class ProdutosPorArranjo
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public virtual Produto Produto { get; set; }
        public virtual Arranjo Arranjo { get; set; }
        public int Quantidade { get; set; }
        /*public ProdutosPorArranjo(Produto produto, Arranjo arranjo, int quantidade)
        {
            Produto = produto;
            Arranjo = arranjo;
            Quantidade = quantidade;
        }*/
    }
}
