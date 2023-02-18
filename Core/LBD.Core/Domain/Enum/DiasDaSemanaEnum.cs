using System.ComponentModel;

namespace LBD.Core.Domain.Enum
{
    public enum DiasDaSemanaEnum
    {
        Domingo,
        [Description("Segunda Feira")]
        Segunda,
        [Description("Terça Feira")]
        Terca,
        [Description("Quarta Feira")]
        Quarta,
        [Description("Quinta Feira")]
        Quinta,
        [Description("Sexta Feira")]
        Sexta,
        [Description("Sábado")]
        Sabado
    }
}
