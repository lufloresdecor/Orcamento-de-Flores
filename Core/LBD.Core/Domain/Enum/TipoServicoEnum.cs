using System.ComponentModel;

namespace LBD.Core.Domain.Enum
{
    public enum TipoServicoEnum
    {
        Transporte,
        [Description("Desing Floral")]
        DesignFloral,
        Limpeza,
        Retirada,
        Montagem,
        Igreja,
        [Description("Tempo Insuficiente")]
        TempoInsuficiente,
        Cerimonial,
        [Description("Hora Extra")]
        HoraExtra,
        [Description("Reunião")]
        Reuniao,
        Evento,
        [Description("Locação")]
        Locacao
    }
}