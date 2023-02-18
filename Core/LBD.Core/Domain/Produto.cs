using LBD.Core.Domain.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LBD.Core.Domain
{
    public class Produto
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string? Localizacao { get; set; }
        public DateTime? DataValidade { get; set; }
        public TipoProdutoEnum TipoDeProduto { get; set; }
        public TipoContagemEnum TipoDeContagem { get; set; }
        public TamanhoGeralEnum? TamanhoDeContagem { get; set; }
        public Produto() { }
        public Produto(TipoProdutoEnum tipoProduto, TipoContagemEnum tipoDeContagem)
        {
            TipoDeProduto = tipoProduto;
            TipoDeContagem = tipoDeContagem;
        }
        public Produto(string nome, TipoProdutoEnum tipoDeProduto, TipoContagemEnum tipoDeContagem, string? localizacao = null , DateTime? dataValidade = null , TamanhoGeralEnum? tamanhoDeContagem = null)
        {
            Nome = nome;
            Localizacao = localizacao;
            DataValidade = dataValidade;
            TipoDeProduto = tipoDeProduto;
            TipoDeContagem = tipoDeContagem;
            TamanhoDeContagem = tamanhoDeContagem;
        }
    }
}