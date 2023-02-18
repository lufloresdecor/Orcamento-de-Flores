using LBD.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orçamento_Flores.Dados.Managers
{
    public class CadastroManager
    {
        public static CadastroManager Instance { get; private set; }
        public event Action<PessoaFisica> OnPessoaFisicaCreated;
        public event Action<PessoaJuridica> OnPessoaJuridicaCreated;
        public CadastroManager() => Instance = this;

        public void CreatePessoa(Pessoa p)
        {
            if (p is PessoaFisica) OnPessoaFisicaCreated?.Invoke(p as PessoaFisica);
            if (p is PessoaJuridica) OnPessoaJuridicaCreated?.Invoke(p as PessoaJuridica);
        }

    }
}
