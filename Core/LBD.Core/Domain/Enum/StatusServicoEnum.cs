using System.ComponentModel;

namespace LBD.Core.Domain
{
    public enum StatusServicoEnum
    {
        [Description("Orçado")]
        Orcado,
        Contratado, 
        [Description("Em Serviço")]
        EmServico,
        Executado
    }
}