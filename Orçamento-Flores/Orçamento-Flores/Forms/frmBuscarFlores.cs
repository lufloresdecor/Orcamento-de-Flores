using LBD.Core.Domain;
using LBD.Utils.Extensions;
using LBD.Utils.Utils;
using Orçamento_Flores.Dados;
using Orçamento_Flores.Dados.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orçamento_Flores.Forms
{
    public partial class frmBuscarFlores : Form
    {
        private List<Flor> _resultados;

        public frmBuscarFlores()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            LimparResultados();
            CriarPesquisa();
            PopularResultados();
        }

        private void frmBuscarFlores_Load(object sender, EventArgs e)
        {
            cmbTipoFlor.DataSource = UtilsMethods.GetDescriptions<TamanhoFlorEnum>();
            cmbTipoFlor.SelectedItem = null;
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            SearchManager.Instance.FoundFlorOnSearch(clbResultados.SelectedItem as Flor);
            this.Close();
        }

        private void PopularResultados()
        {
            foreach (var flor in _resultados)
            {
                clbResultados.Items.Add(flor);
            }
        }

        private void CriarPesquisa()
        {
            string nome = txbNome.Text;
            string cor = txbCor.Text;
            TamanhoFlorEnum? tamanhoFlor = cmbTipoFlor.SelectedItem?.ToString()
                .GetEnumByDescription<TamanhoFlorEnum>();
            DbPedidoContext db = new();
            var query = db.Flores.AsQueryable();
            if (nome != "")
                query = query.Where(x => x.Nome.Contains(nome));
            if (cor != "")
                query = query.Where(x => x.Cor.Contains(cor));
            if (tamanhoFlor != null)
                query = query.Where(x => x.TamanhoFlor == tamanhoFlor);
            _resultados = query.OrderBy(x => x.Nome).ToList();
        }

        private void LimparResultados() => clbResultados.Items.Clear();
    }
}
