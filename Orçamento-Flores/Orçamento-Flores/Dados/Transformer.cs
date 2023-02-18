using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orçamento_Flores.Dados
{
    public interface ITransformer<T> where T : class
    {
        public T? Object { get; set; }
        public abstract void Transform();
    }
}
