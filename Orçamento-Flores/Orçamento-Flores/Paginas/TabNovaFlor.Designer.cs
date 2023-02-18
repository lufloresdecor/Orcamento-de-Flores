using LBD.Core.Domain;
using LBD.Core.Domain.Enum;
using LBD.Pedidos.Domain;
using Orçamento_Flores.Utils;

namespace Orçamento_Flores.Paginas
{
    partial class TabNovaFlor
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblUnidadeFlor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCadastrarFlor = new System.Windows.Forms.Button();
            this.cmbTipoFlor = new System.Windows.Forms.ComboBox();
            this.cmbUnidadeFlor = new System.Windows.Forms.ComboBox();
            this.txtNomeFlor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTamanhoUnidadeFlor = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblCorFlor = new System.Windows.Forms.Label();
            this.txtCorFlor = new System.Windows.Forms.TextBox();
            this.cbxSemCor = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome da Flor";
            // 
            // lblUnidadeFlor
            // 
            this.lblUnidadeFlor.AutoSize = true;
            this.lblUnidadeFlor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUnidadeFlor.Location = new System.Drawing.Point(433, 71);
            this.lblUnidadeFlor.Name = "lblUnidadeFlor";
            this.lblUnidadeFlor.Size = new System.Drawing.Size(161, 28);
            this.lblUnidadeFlor.TabIndex = 1;
            this.lblUnidadeFlor.Text = "Unidade da Flor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(23, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de Flor";
            // 
            // btnCadastrarFlor
            // 
            this.btnCadastrarFlor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrarFlor.Location = new System.Drawing.Point(600, 210);
            this.btnCadastrarFlor.Name = "btnCadastrarFlor";
            this.btnCadastrarFlor.Size = new System.Drawing.Size(135, 86);
            this.btnCadastrarFlor.TabIndex = 10;
            this.btnCadastrarFlor.Text = "Cadastrar Nova Flor";
            this.btnCadastrarFlor.UseVisualStyleBackColor = true;
            this.btnCadastrarFlor.Click += new System.EventHandler(this.btnCadastrarFlor_Click);
            // 
            // cmbTipoFlor
            // 
            this.cmbTipoFlor.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbTipoFlor.FormattingEnabled = true;
            this.cmbTipoFlor.Location = new System.Drawing.Point(167, 75);
            this.cmbTipoFlor.Name = "cmbTipoFlor";
            this.cmbTipoFlor.Size = new System.Drawing.Size(242, 27);
            this.cmbTipoFlor.TabIndex = 2;
            this.cmbTipoFlor.SelectedIndexChanged += new System.EventHandler(this.cmbTipoFlor_IndexChanged);
            // 
            // cmbUnidadeFlor
            // 
            this.cmbUnidadeFlor.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbUnidadeFlor.FormattingEnabled = true;
            this.cmbUnidadeFlor.Location = new System.Drawing.Point(600, 75);
            this.cmbUnidadeFlor.Name = "cmbUnidadeFlor";
            this.cmbUnidadeFlor.Size = new System.Drawing.Size(151, 27);
            this.cmbUnidadeFlor.TabIndex = 3;
            // 
            // txtNomeFlor
            // 
            this.txtNomeFlor.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNomeFlor.Location = new System.Drawing.Point(167, 29);
            this.txtNomeFlor.Name = "txtNomeFlor";
            this.txtNomeFlor.Size = new System.Drawing.Size(548, 27);
            this.txtNomeFlor.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(23, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 59);
            this.label4.TabIndex = 7;
            this.label4.Text = "Unidade de Flor (Tamanho)";
            // 
            // cmbTamanhoUnidadeFlor
            // 
            this.cmbTamanhoUnidadeFlor.FormattingEnabled = true;
            this.cmbTamanhoUnidadeFlor.Location = new System.Drawing.Point(190, 135);
            this.cmbTamanhoUnidadeFlor.Name = "cmbTamanhoUnidadeFlor";
            this.cmbTamanhoUnidadeFlor.Size = new System.Drawing.Size(219, 28);
            this.cmbTamanhoUnidadeFlor.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Orçamento_Flores.Properties.Resources.search;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(721, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(30, 30);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblCorFlor
            // 
            this.lblCorFlor.AutoSize = true;
            this.lblCorFlor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCorFlor.Location = new System.Drawing.Point(433, 131);
            this.lblCorFlor.Name = "lblCorFlor";
            this.lblCorFlor.Size = new System.Drawing.Size(115, 28);
            this.lblCorFlor.TabIndex = 12;
            this.lblCorFlor.Text = "Cor da Flor";
            // 
            // txtCorFlor
            // 
            this.txtCorFlor.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCorFlor.Location = new System.Drawing.Point(564, 132);
            this.txtCorFlor.Name = "txtCorFlor";
            this.txtCorFlor.Size = new System.Drawing.Size(187, 27);
            this.txtCorFlor.TabIndex = 6;
            // 
            // cbxSemCor
            // 
            this.cbxSemCor.AutoSize = true;
            this.cbxSemCor.Location = new System.Drawing.Point(433, 177);
            this.cbxSemCor.Name = "cbxSemCor";
            this.cbxSemCor.Size = new System.Drawing.Size(145, 24);
            this.cbxSemCor.TabIndex = 5;
            this.cbxSemCor.Text = "Flor de Cor Única";
            this.cbxSemCor.UseVisualStyleBackColor = true;
            this.cbxSemCor.CheckedChanged += new System.EventHandler(this.cbxSemCor_CheckedChanged);
            // 
            // TabNovaFlor
            // 
            this.AccessibleName = "Nova Flor";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbxSemCor);
            this.Controls.Add(this.txtCorFlor);
            this.Controls.Add(this.lblCorFlor);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbTamanhoUnidadeFlor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNomeFlor);
            this.Controls.Add(this.cmbUnidadeFlor);
            this.Controls.Add(this.cmbTipoFlor);
            this.Controls.Add(this.btnCadastrarFlor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblUnidadeFlor);
            this.Controls.Add(this.label1);
            this.Name = "TabNovaFlor";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(766, 319);
            this.Load += new System.EventHandler(this.TabNovaFlor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lblUnidadeFlor;
        private Label label3;
        private Button btnCadastrarFlor;
        private ComboBox cmbTipoFlor;
        private ComboBox cmbUnidadeFlor;
        private TextBox txtNomeFlor;
        private Label label4;
        private ComboBox cmbTamanhoUnidadeFlor;
        private Button btnSearch;
        private Label lblCorFlor;
        private TextBox txtCorFlor;
        private CheckBox cbxSemCor;
    }
}
