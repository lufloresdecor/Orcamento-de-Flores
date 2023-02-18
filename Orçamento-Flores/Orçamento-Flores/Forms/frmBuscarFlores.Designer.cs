namespace Orçamento_Flores.Forms
{
    partial class frmBuscarFlores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbCor = new System.Windows.Forms.TextBox();
            this.lblCor = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.cmbTipoFlor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.clbResultados = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(68, 19);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(185, 27);
            this.txbNome.TabIndex = 1;
            // 
            // txbCor
            // 
            this.txbCor.Location = new System.Drawing.Point(68, 65);
            this.txbCor.Name = "txbCor";
            this.txbCor.Size = new System.Drawing.Size(185, 27);
            this.txbCor.TabIndex = 3;
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Location = new System.Drawing.Point(12, 68);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(32, 20);
            this.lblCor.TabIndex = 2;
            this.lblCor.Text = "Cor";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnPesquisar);
            this.splitContainer1.Panel1.Controls.Add(this.cmbTipoFlor);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.lblCor);
            this.splitContainer1.Panel1.Controls.Add(this.txbCor);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txbNome);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnSelecionar);
            this.splitContainer1.Panel2.Controls.Add(this.clbResultados);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 5;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(86, 190);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(94, 29);
            this.btnPesquisar.TabIndex = 6;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // cmbTipoFlor
            // 
            this.cmbTipoFlor.FormattingEnabled = true;
            this.cmbTipoFlor.Location = new System.Drawing.Point(86, 117);
            this.cmbTipoFlor.Name = "cmbTipoFlor";
            this.cmbTipoFlor.Size = new System.Drawing.Size(167, 28);
            this.cmbTipoFlor.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipo Flor";
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(427, 168);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(94, 258);
            this.btnSelecionar.TabIndex = 7;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // clbResultados
            // 
            this.clbResultados.BackColor = System.Drawing.SystemColors.Menu;
            this.clbResultados.FormattingEnabled = true;
            this.clbResultados.Location = new System.Drawing.Point(32, 26);
            this.clbResultados.Name = "clbResultados";
            this.clbResultados.Size = new System.Drawing.Size(389, 400);
            this.clbResultados.TabIndex = 0;
            // 
            // frmBuscarFlores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmBuscarFlores";
            this.Text = "Buscar Flores";
            this.Load += new System.EventHandler(this.frmBuscarFlores_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private TextBox txbNome;
        private TextBox txbCor;
        private Label lblCor;
        private SplitContainer splitContainer1;
        private ComboBox cmbTipoFlor;
        private Label label2;
        private Button btnPesquisar;
        private Button btnSelecionar;
        private CheckedListBox clbResultados;
    }
}