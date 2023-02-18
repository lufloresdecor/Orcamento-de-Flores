using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace LBD.Core.Domain
{
    public abstract class Pessoa
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual List<Documento>? Documentos { get; set; }
        public virtual List<Telefone>? Telefones { get; set; }
        public Endereco? Endereco { get; set; }
        public string? Email { get; set; }
        public List<RedeSocial> RedeSociais { get; set; }
    }

    public class PessoaFisica : Pessoa
    {
        public string NomeCompleto { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Profissao { get; set; }

    }

    public class PessoaJuridica : Pessoa 
    {
        public string RazaoSocial { get; set; }
        public List<PessoaFisica>? Representantes { get; set; }
    }
}