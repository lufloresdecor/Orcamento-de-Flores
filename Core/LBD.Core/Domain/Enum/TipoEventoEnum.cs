using System.ComponentModel;

namespace LBD.Core.Domain.Enum
{
    public enum TipoEventoEnum
    {
        Casamento,
        [Description("Aniversário de 15 Anos")]
        AniversarioXV,
        Corporativo,
    }
}