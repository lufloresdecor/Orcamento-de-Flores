using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using LBD.Core.Domain.Enum;

namespace LBD.Core.Domain
{
    public class Flor : Produto
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public new int Id { get; set; }
        [Required]
        public int Quantidade { get; set; }
        public string? Cor { get; set; }
        public decimal IndicePerda { get; set; } = 0;
        public UnidadeFlorEnum UnidadeFlor { get; set; }
        public TamanhoGeralEnum? TamanhoVaso { get; set; }
        public TamanhoGeralEnum? TamanhoUnidade { get; set; }
        public TamanhoFlorEnum TamanhoFlor { get; set; }
        public override string ToString()
        {
            var result = String.Format(
                "Flor: {0}\n" +
                "Cor: {1}\n" +
                "Quantidade: {2}\n" +
                "Unidade: {3}\n" +
                "Tamanho da Unidade: {4}\n" +
                "Tamanho da Flor: {5}\n" +
                "Tamanho do Vaso: {6}\n" +
                "Tipo Produto: {7}\n" +
                "Tipo de Contagem: {8}\n",
                this.Nome, this.Cor, this.Quantidade, this.UnidadeFlor,
                this.TamanhoUnidade, this.TamanhoFlor, this.TamanhoVaso, this.TipoDeProduto, this.TipoDeContagem);
            return result;
        }
        public Flor() : base(TipoProdutoEnum.Flor,TipoContagemEnum.Unidade) { this.IndicePerda = 0.5m; }
        public Flor(string nome, int quantidade, TamanhoFlorEnum tamanhoFlor)
            : this()
        {
            Quantidade = quantidade;
            TamanhoFlor = tamanhoFlor;
        }
        public Flor(string nome, int quantidade, TamanhoFlorEnum tamanhoFlor, decimal indicePerda, string? cor = null, TamanhoGeralEnum? tamanhoVaso = null)
            : this(nome,quantidade,tamanhoFlor)
        {
            IndicePerda = indicePerda;
            Cor = cor;
            TamanhoVaso = tamanhoVaso;
        }
    }
}
