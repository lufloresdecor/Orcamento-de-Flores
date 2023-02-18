using LBD.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orçamento_Flores.Dados.Managers
{
    public class SearchManager
    {
        public event Action<Flor> OnFlorSearched;
        public static SearchManager Instance;
        public SearchManager() {
            Instance = this;
        }
        public void FoundFlorOnSearch(Flor flor)
        {
            OnFlorSearched?.Invoke(flor);
        }

    }
}
