using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LBD.Core.Domain
{
    public class Endereco
    {
        
        public Endereco() { }

        public Endereco(string CEP, int Numero) { }

        public Endereco(string nomeRua, string bairro, string cidade, string pais, int numero)
        {
            this.NomeRua= nomeRua;
            this.Bairro= bairro;
            this.Cidade= cidade;
            this.Pais= pais;
            this.Numero= numero;
        }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? CEP { get; set; }
        public string NomeRua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Pais { get; set; }
        public int Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Referencia { get; set; }
    }
}
