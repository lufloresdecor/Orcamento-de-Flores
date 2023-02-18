using System.ComponentModel;

namespace LBD.Core.Domain.Enum
{
    public enum TipoDocumentoEnum
    {
        RG,
        CPF,
        CNPJ,
        CNH,
        CTPS,
        [Description("Certidão de Nascimento")]
        CertidaoNascimento,
        [Description("Certidão de Casamento")]
        CertidaoCasamento,
        Passaporte,
        [Description("Carteira de Vacinação")]
        CarteiraVacinacao
    }
}