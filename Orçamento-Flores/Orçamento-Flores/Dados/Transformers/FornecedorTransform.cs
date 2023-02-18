using LBD.Core.Domain;
using LBD.Pedidos.Domain;

namespace Orçamento_Flores.Dados.Transformers
{
    public class FornecedorTransform : ITransformer<Fornecedor>
    {
        public Fornecedor? Object { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public string? Email { get; set; }
        public string? InicioExpediente { get; set; }
        public string? FimExpediente { get; set; }
        public string? DiaEntrega { get; set; }
        public bool FazEntrega { get; set; }
        public bool Horario { get; set; }
        public bool DiaFixo { get; set; }
        public List<PessoaFisica>? Representantes { get; set; }
        public Endereco Endereco { get; set; }
        public List<Telefone> Telefones { get; set; }
        public void Transform()
        {
            Object = new Fornecedor
            {
                Documentos = new List<Documento> { 
                    new Documento {
                        TipoDocumento  = LBD.Core.Domain.Enum.TipoDocumentoEnum.CNPJ,
                        NumeroDocumento = CNPJ,
                    }
                },
                FazEntrega = this.FazEntrega,
                Nome = this.Nome,
                RazaoSocial = this.Nome,
                Endereco = this.Endereco,
                Telefones = this.Telefones,
                Email = this.Email
            };
        }
    }
}
