using System.ComponentModel;

namespace LBD.Core.Domain.Enum
{
    public enum TamanhoGeralEnum
    {
        Pequeno,
        [Description("Médio")]
        Medio,
        Grande,
        [Description("Sem Opção")]
        SemOpcao
    }
}