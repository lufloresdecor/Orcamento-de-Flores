using LBD.Core.Domain;
using LBD.Core.Domain.Enum;
using LBD.Pedidos.Domain;
using Orçamento_Flores.Dados;


namespace Orçamento_Flores.Paginas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void FrmPrincipal_Load()
        {
            
        }

        private void florToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewTab(new Orçamento_Flores.Paginas.TabNovaFlor(), "Nova Flor");
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewTab(new Orçamento_Flores.Paginas.TabNovoFornecedor(), "Novo Fornecedor");

        }
        private void NewTab(Control tab, string text)
        {
            var tabPage = new TabPage(text);
            tabPage.Controls.Add(tab);
            TabControl.TabPages.Add(tabPage);
            TabControl.SelectedTab = tabPage;
        }
    }
}