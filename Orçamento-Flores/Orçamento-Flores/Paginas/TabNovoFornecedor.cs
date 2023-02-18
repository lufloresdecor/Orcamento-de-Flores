using LBD.Core.Domain.Enum;
using LBD.Utils.Utils;
using Orçamento_Flores.Dados.Transformers;
using Orçamento_Flores.Forms;
using Orçamento_Flores.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orçamento_Flores.Paginas
{
    public partial class TabNovoFornecedor : UserControl
    {
        FornecedorTransform Fornecedor = new FornecedorTransform();
        public TabNovoFornecedor()
        {
            InitializeComponent();
        }

        #region Events
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Fornecedor.Transform();
            MessageBox.Show(Fornecedor.Object.ToString());
        }

        private void TabNovoFornecedor_Load(object sender, EventArgs e)
        {
            PopularCombos();
            CriarBindings();
            IniciarVisual();
        }

        private void cbxFazEntrega_CheckedChanged(object sender, EventArgs e)
        {
            pnlEntrega.Visible = cbxFazEntrega.Checked;
            cbxFazEntrega.Font = cbxFazEntrega.Font.SetBold(cbxFazEntrega.Checked);
        }

        private void cbxHorarioDeFuncionamento_CheckedChanged(object sender, EventArgs e)
        {
            pnlHorario.Visible = cbxHorarioDeFuncionamento.Checked;
            cbxHorarioDeFuncionamento.Font = cbxHorarioDeFuncionamento.Font.SetBold(cbxHorarioDeFuncionamento.Checked);
        }

        private void cbxDiaFixo_CheckedChanged(object sender, EventArgs e)
        {
            cbxDiaFixo.Font = cbxDiaFixo.Font.SetBold(cbxDiaFixo.Checked);
        }
        #endregion

        private void IniciarVisual()
        {
            pnlEntrega.Visible = false;
            pnlHorario.Visible = false;
        }

        private void PopularCombos()
        {
            for(int i = 6; i<22;i++)
            {
                if(i<14)
                    cmbInicio.Items.Add($"{i}:00");
                if(i>12)
                    cmbFim.Items.Add($"{i}:00");
            }
            cmbDiaDaSemana.DataSource = UtilsMethods.GetDescriptions<DiasDaSemanaEnum>();
            cmbDiaDaSemana.SelectedItem = null;
            cmbFim.SelectedItem = null;
            cmbFim.SelectedItem = null;
        }

        private void CriarBindings()
        {
            txtNome.DataBindings.Add(new Binding(
                    nameof(txtNome.Text),
                    Fornecedor,
                    nameof(Fornecedor.Nome))
                );
            txtNome.DataBindings.Add(new Binding(
                    nameof(txtEmail.Text),
                    Fornecedor,
                    nameof(Fornecedor.Email))
                );
            txtNome.DataBindings.Add(new Binding(
                    nameof(lbxEndereco.SelectedItem),
                    Fornecedor,
                    nameof(Fornecedor.Endereco))
                );
            txtNome.DataBindings.Add(new Binding(
                    nameof(lbxRepresentantes.Items),
                    Fornecedor,
                    nameof(Fornecedor.Representantes))
                );
            txtNome.DataBindings.Add(new Binding(
                    nameof(lbxTelefones.Items),
                    Fornecedor,
                    nameof(Fornecedor.Telefones))
                );
            txtNome.DataBindings.Add(new Binding(
                    nameof(txtCNPJ.Text),
                    Fornecedor,
                    nameof(Fornecedor.CNPJ))
                );
        }

        private void btnAdicionarRepresentante_Click(object sender, EventArgs e)
        {
            new frmCadastrarRepresentante().ShowDialog();
        }
    }
}
