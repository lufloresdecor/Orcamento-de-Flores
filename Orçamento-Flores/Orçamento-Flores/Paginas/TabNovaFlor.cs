using LBD.Core.Domain;
using LBD.Core.Domain.Enum;
using LBD.Utils.Extensions;
using LBD.Utils.Utils;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Orçamento_Flores.Dados;
using Orçamento_Flores.Dados.Managers;
using Orçamento_Flores.Dados.Transformers;
using Orçamento_Flores.Forms;
using Orçamento_Flores.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orçamento_Flores.Paginas
{
    public partial class TabNovaFlor : UserControl
    {
        public TabNovaFlor()
        {
            InitializeComponent();
            SearchManager.Instance.OnFlorSearched += FlorEncontrada;
        }

        private FlorTransform NovaFlor = new FlorTransform();

        #region Events

        private void TabNovaFlor_Load(object sender, EventArgs e)
        {
            IniciarCombos();
            CriarBindings();
        }

        private void btnCadastrarFlor_Click(object sender, EventArgs e)
        {
            TentarRegistrarFlor();
        }

        private void cmbTipoFlor_IndexChanged(Object sender, EventArgs e)
        {
            DefinirEnumDestino();
        }

        private void cbxSemCor_CheckedChanged(object sender, EventArgs e)
        {
            AtivarControlesDeCor();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ProcurarFlores();
        }

        #endregion

        private void ProcurarFlores()
        {
            new frmBuscarFlores().ShowDialog();
        }

        private void FlorEncontrada(Flor flor)
        {
            this.txtNomeFlor.Text = flor.Nome;
        }

        private void IniciarCombos()
        {
            cmbTipoFlor.DataSource = UtilsMethods.GetDescriptions<TamanhoFlorEnum>();
            cmbUnidadeFlor.DataSource = UtilsMethods.GetDescriptions<UnidadeFlorEnum>();
            cmbTamanhoUnidadeFlor.DataSource = UtilsMethods.GetDescriptions<TamanhoGeralEnum>();
            cmbTipoFlor.SelectedItem = null;
            cmbUnidadeFlor.SelectedItem = null;
            cmbTamanhoUnidadeFlor.SelectedItem = null;
        }
        
        private void CriarBindings()
        {
            txtCorFlor.DataBindings.Add(new Binding(nameof(txtCorFlor.Text), NovaFlor, nameof(NovaFlor.CorFlor)));
            txtNomeFlor.DataBindings.Add(new Binding(nameof(txtNomeFlor.Text), NovaFlor, nameof(NovaFlor.Nome)));
        }

        private void DefinirEnumDestino()
        {
            cmbTamanhoUnidadeFlor.DataBindings.Clear();
            bool vasoNotSelected = cmbTipoFlor.SelectedItem?.ToString() != TamanhoFlorEnum.Vaso.GetDescription();
            if (!vasoNotSelected)
                cmbTamanhoUnidadeFlor.DataBindings.Add(new Binding(
                    nameof(cmbTamanhoUnidadeFlor.SelectedItem),
                    NovaFlor,
                    nameof(NovaFlor.TamanhoVaso)));
            else
                cmbTamanhoUnidadeFlor.DataBindings.Add(new Binding(
                   nameof(cmbTamanhoUnidadeFlor.SelectedItem),
                   NovaFlor,
                   nameof(NovaFlor.TamanhoUnidade)));
            cmbUnidadeFlor.Visible = vasoNotSelected;
            cmbUnidadeFlor.Enabled = vasoNotSelected;
            lblUnidadeFlor.Visible = vasoNotSelected;
            NovaFlor.TamanhoUnidade = null;
            NovaFlor.TamanhoVaso = null;
        }
        
        private void AtivarControlesDeCor()
        {
            lblCorFlor.Visible = !cbxSemCor.Checked;
            txtCorFlor.Visible = !cbxSemCor.Checked;
        }

        private void TentarRegistrarFlor()
        {
            if (!this.IsFormCompleted())
            {
                MessageBox.Show("Existem campos vazios. Favor preencher todos os necessários");
                return;
            }
            NovaFlor.Transform();
            var flor = NovaFlor.Object;
            if(flor is not null)
            {
                if(MessageBox.Show("Confirma a criação da flor?\n" + flor.ToString(), "Confirma Criação", MessageBoxButtons.OKCancel)==DialogResult.OK)
                    TentarAdicionarFlorAoBanco(flor);
            }
        }

        private void TentarAdicionarFlorAoBanco(Flor flor)
        {
            DbPedidoContext db = new();
            db.Flores.Add(flor);
            db.SaveChangesAsync();
        }

    }
}
