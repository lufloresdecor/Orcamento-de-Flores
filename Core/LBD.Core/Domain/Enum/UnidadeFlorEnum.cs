using System.ComponentModel;

namespace LBD.Core.Domain.Enum
{
    public enum UnidadeFlorEnum
    {
        Pacote,
        Rolo,
        [Description("Dúzia")]
        Duzia,
        Caixa,
        Unidade,
        Tubete
    }
}