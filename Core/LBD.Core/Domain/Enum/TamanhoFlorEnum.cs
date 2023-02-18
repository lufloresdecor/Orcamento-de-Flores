using System.ComponentModel;

namespace LBD.Core.Domain
{
    public enum TamanhoFlorEnum
    {
        Mini,
        [Description("Cabo Curto")]
        CaboCurto,
        [Description("Cabo Medio")]
        CaboMedio,
        [Description("Cabo Longo")]
        CaboLongo,
        Vaso,
    }
}