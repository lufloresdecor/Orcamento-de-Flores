namespace Orçamento_Flores.Paginas
{
    partial class TabNovoFornecedor
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.cbxFazEntrega = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.cbxDiaFixo = new System.Windows.Forms.CheckBox();
            this.pnlEntrega = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDiaDaSemana = new System.Windows.Forms.ComboBox();
            this.cbxHorarioDeFuncionamento = new System.Windows.Forms.CheckBox();
            this.pnlHorario = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbFim = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbInicio = new System.Windows.Forms.ComboBox();
            this.lbxRepresentantes = new System.Windows.Forms.ListBox();
            this.btnAdicionarRepresentante = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRemoverRepresentante = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lbxTelefones = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lbxEndereco = new System.Windows.Forms.ListBox();
            this.pnlEntrega.SuspendLayout();
            this.pnlHorario.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.Location = new System.Drawing.Point(533, 280);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(113, 50);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar Fornecedor";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // cbxFazEntrega
            // 
            this.cbxFazEntrega.AutoSize = true;
            this.cbxFazEntrega.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxFazEntrega.Location = new System.Drawing.Point(31, 200);
            this.cbxFazEntrega.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxFazEntrega.Name = "cbxFazEntrega";
            this.cbxFazEntrega.Size = new System.Drawing.Size(108, 25);
            this.cbxFazEntrega.TabIndex = 1;
            this.cbxFazEntrega.Text = "Faz Entrega";
            this.cbxFazEntrega.UseVisualStyleBackColor = true;
            this.cbxFazEntrega.CheckedChanged += new System.EventHandler(this.cbxFazEntrega_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome/Razão Social *";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome.Location = new System.Drawing.Point(29, 39);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(291, 29);
            this.txtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(354, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "CNPJ *";
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCNPJ.Location = new System.Drawing.Point(354, 39);
            this.txtCNPJ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCNPJ.Mask = "00,000,000/0000-00";
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(132, 29);
            this.txtCNPJ.TabIndex = 2;
            // 
            // cbxDiaFixo
            // 
            this.cbxDiaFixo.AutoSize = true;
            this.cbxDiaFixo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxDiaFixo.Location = new System.Drawing.Point(7, 6);
            this.cbxDiaFixo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxDiaFixo.Name = "cbxDiaFixo";
            this.cbxDiaFixo.Size = new System.Drawing.Size(84, 25);
            this.cbxDiaFixo.TabIndex = 6;
            this.cbxDiaFixo.Text = "Dia Fixo";
            this.cbxDiaFixo.UseVisualStyleBackColor = true;
            this.cbxDiaFixo.CheckedChanged += new System.EventHandler(this.cbxDiaFixo_CheckedChanged);
            // 
            // pnlEntrega
            // 
            this.pnlEntrega.Controls.Add(this.label3);
            this.pnlEntrega.Controls.Add(this.cmbDiaDaSemana);
            this.pnlEntrega.Controls.Add(this.cbxDiaFixo);
            this.pnlEntrega.Location = new System.Drawing.Point(26, 228);
            this.pnlEntrega.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlEntrega.Name = "pnlEntrega";
            this.pnlEntrega.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlEntrega.Size = new System.Drawing.Size(151, 103);
            this.pnlEntrega.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(7, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Dia Da Semana";
            // 
            // cmbDiaDaSemana
            // 
            this.cmbDiaDaSemana.FormattingEnabled = true;
            this.cmbDiaDaSemana.Location = new System.Drawing.Point(7, 72);
            this.cmbDiaDaSemana.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDiaDaSemana.Name = "cmbDiaDaSemana";
            this.cmbDiaDaSemana.Size = new System.Drawing.Size(133, 23);
            this.cmbDiaDaSemana.TabIndex = 7;
            // 
            // cbxHorarioDeFuncionamento
            // 
            this.cbxHorarioDeFuncionamento.AutoSize = true;
            this.cbxHorarioDeFuncionamento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxHorarioDeFuncionamento.Location = new System.Drawing.Point(207, 200);
            this.cbxHorarioDeFuncionamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxHorarioDeFuncionamento.Name = "cbxHorarioDeFuncionamento";
            this.cbxHorarioDeFuncionamento.Size = new System.Drawing.Size(215, 25);
            this.cbxHorarioDeFuncionamento.TabIndex = 9;
            this.cbxHorarioDeFuncionamento.Text = "Horário de Funcionamento";
            this.cbxHorarioDeFuncionamento.UseVisualStyleBackColor = true;
            this.cbxHorarioDeFuncionamento.CheckedChanged += new System.EventHandler(this.cbxHorarioDeFuncionamento_CheckedChanged);
            // 
            // pnlHorario
            // 
            this.pnlHorario.Controls.Add(this.label6);
            this.pnlHorario.Controls.Add(this.cmbFim);
            this.pnlHorario.Controls.Add(this.label5);
            this.pnlHorario.Controls.Add(this.label4);
            this.pnlHorario.Controls.Add(this.cmbInicio);
            this.pnlHorario.Location = new System.Drawing.Point(203, 228);
            this.pnlHorario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlHorario.Name = "pnlHorario";
            this.pnlHorario.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlHorario.Size = new System.Drawing.Size(239, 103);
            this.pnlHorario.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(110, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "-";
            // 
            // cmbFim
            // 
            this.cmbFim.FormattingEnabled = true;
            this.cmbFim.Location = new System.Drawing.Point(142, 52);
            this.cmbFim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFim.Name = "cmbFim";
            this.cmbFim.Size = new System.Drawing.Size(91, 23);
            this.cmbFim.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(142, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(7, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Início";
            // 
            // cmbInicio
            // 
            this.cmbInicio.FormattingEnabled = true;
            this.cmbInicio.Location = new System.Drawing.Point(7, 52);
            this.cmbInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbInicio.Name = "cmbInicio";
            this.cmbInicio.Size = new System.Drawing.Size(91, 23);
            this.cmbInicio.TabIndex = 7;
            // 
            // lbxRepresentantes
            // 
            this.lbxRepresentantes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbxRepresentantes.FormattingEnabled = true;
            this.lbxRepresentantes.ItemHeight = 21;
            this.lbxRepresentantes.Location = new System.Drawing.Point(508, 39);
            this.lbxRepresentantes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbxRepresentantes.Name = "lbxRepresentantes";
            this.lbxRepresentantes.Size = new System.Drawing.Size(138, 193);
            this.lbxRepresentantes.TabIndex = 11;
            // 
            // btnAdicionarRepresentante
            // 
            this.btnAdicionarRepresentante.Location = new System.Drawing.Point(586, 236);
            this.btnAdicionarRepresentante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdicionarRepresentante.Name = "btnAdicionarRepresentante";
            this.btnAdicionarRepresentante.Size = new System.Drawing.Size(26, 22);
            this.btnAdicionarRepresentante.TabIndex = 12;
            this.btnAdicionarRepresentante.Text = "+";
            this.btnAdicionarRepresentante.UseVisualStyleBackColor = true;
            this.btnAdicionarRepresentante.Click += new System.EventHandler(this.btnAdicionarRepresentante_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(507, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Representantes";
            // 
            // btnRemoverRepresentante
            // 
            this.btnRemoverRepresentante.Location = new System.Drawing.Point(618, 236);
            this.btnRemoverRepresentante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoverRepresentante.Name = "btnRemoverRepresentante";
            this.btnRemoverRepresentante.Size = new System.Drawing.Size(26, 22);
            this.btnRemoverRepresentante.TabIndex = 14;
            this.btnRemoverRepresentante.Text = "-";
            this.btnRemoverRepresentante.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(26, 161);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(291, 29);
            this.txtEmail.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(24, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 21);
            this.label8.TabIndex = 16;
            this.label8.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(24, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 21);
            this.label9.TabIndex = 18;
            this.label9.Text = "Endereço *";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Orçamento_Flores.Properties.Resources.search;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(290, 95);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 26);
            this.button1.TabIndex = 19;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(354, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 21);
            this.label10.TabIndex = 20;
            this.label10.Text = "Telefones";
            // 
            // lbxTelefones
            // 
            this.lbxTelefones.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbxTelefones.FormattingEnabled = true;
            this.lbxTelefones.ItemHeight = 21;
            this.lbxTelefones.Location = new System.Drawing.Point(354, 95);
            this.lbxTelefones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbxTelefones.Name = "lbxTelefones";
            this.lbxTelefones.Size = new System.Drawing.Size(132, 46);
            this.lbxTelefones.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(459, 145);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 22);
            this.button2.TabIndex = 23;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(428, 145);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 22);
            this.button3.TabIndex = 22;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lbxEndereco
            // 
            this.lbxEndereco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbxEndereco.FormattingEnabled = true;
            this.lbxEndereco.ItemHeight = 21;
            this.lbxEndereco.Location = new System.Drawing.Point(29, 95);
            this.lbxEndereco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbxEndereco.Name = "lbxEndereco";
            this.lbxEndereco.Size = new System.Drawing.Size(256, 25);
            this.lbxEndereco.TabIndex = 24;
            // 
            // TabNovoFornecedor
            // 
            this.AccessibleDescription = "Novo Fornecedor";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbxEndereco);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lbxTelefones);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnRemoverRepresentante);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAdicionarRepresentante);
            this.Controls.Add(this.lbxRepresentantes);
            this.Controls.Add(this.cbxHorarioDeFuncionamento);
            this.Controls.Add(this.pnlHorario);
            this.Controls.Add(this.pnlEntrega);
            this.Controls.Add(this.txtCNPJ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxFazEntrega);
            this.Controls.Add(this.btnCadastrar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TabNovoFornecedor";
            this.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Size = new System.Drawing.Size(675, 346);
            this.Load += new System.EventHandler(this.TabNovoFornecedor_Load);
            this.pnlEntrega.ResumeLayout(false);
            this.pnlEntrega.PerformLayout();
            this.pnlHorario.ResumeLayout(false);
            this.pnlHorario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCadastrar;
        private CheckBox cbxFazEntrega;
        private Label label1;
        private TextBox txtNome;
        private Label label2;
        private MaskedTextBox txtCNPJ;
        private CheckBox cbxDiaFixo;
        private Panel pnlEntrega;
        private Label label3;
        private ComboBox cmbDiaDaSemana;
        private CheckBox cbxHorarioDeFuncionamento;
        private Panel pnlHorario;
        private Label label4;
        private ComboBox cmbInicio;
        private ComboBox cmbFim;
        private Label label5;
        private Label label6;
        private ListBox lbxRepresentantes;
        private Button btnAdicionarRepresentante;
        private Label label7;
        private Button btnRemoverRepresentante;
        private TextBox txtEmail;
        private Label label8;
        private Label label9;
        private Button button1;
        private Label label10;
        private ListBox lbxTelefones;
        private Button button2;
        private Button button3;
        private ListBox lbxEndereco;
    }
}
