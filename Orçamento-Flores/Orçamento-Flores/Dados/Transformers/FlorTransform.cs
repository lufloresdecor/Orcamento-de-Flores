using LBD.Core.Domain;
using LBD.Core.Domain.Enum;
using LBD.Utils.Extensions;
using Orçamento_Flores.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orçamento_Flores.Dados.Transformers
{
    public class FlorTransform : ITransformer<Flor>
    {
        public Flor? Object { get; set; }
        public string Nome { get; set; }
        public string TamanhoFlor { get; set; }
        public string UnidadeFlor { get; set; }
        public string? CorFlor { get; set; }
        public string? TamanhoUnidade { get; set; }
        public string? TamanhoVaso { get; set; }
        public void Transform()
        {
            Object = new Flor
            {
                Nome = Nome,
                TamanhoFlor = TamanhoFlor.GetEnumByDescription<TamanhoFlorEnum>(),
                UnidadeFlor = UnidadeFlor.GetEnumByDescription<UnidadeFlorEnum>(),
                TamanhoUnidade = TamanhoUnidade?.GetEnumByDescription<TamanhoGeralEnum>(),
                TamanhoVaso = TamanhoVaso?.GetEnumByDescription<TamanhoGeralEnum>(),
                Cor = CorFlor,
            };
        }
    }
}
