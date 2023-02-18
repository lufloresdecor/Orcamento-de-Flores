using LBD.Pedidos.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Orçamento_Flores.Dados
{
    public static class Data
    {
        private static DbPedidoContext db = new DbPedidoContext();
        public static IQueryable<T> Consultar<T>()
        {
            return db.GetType().GetProperties().OfType<IQueryable<T>>().FirstOrDefault() ?? new List<T>().AsQueryable();
        }
    }
}
