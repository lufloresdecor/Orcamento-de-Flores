namespace Orçamento_Flores.Paginas
{
    partial class TabConsultarFlores
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
            this.btnProcurarFlores = new System.Windows.Forms.Button();
            this.txtFlor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnProcurarFlores
            // 
            this.btnProcurarFlores.Location = new System.Drawing.Point(500, 326);
            this.btnProcurarFlores.Name = "btnProcurarFlores";
            this.btnProcurarFlores.Size = new System.Drawing.Size(94, 29);
            this.btnProcurarFlores.TabIndex = 0;
            this.btnProcurarFlores.Text = "Procurar";
            this.btnProcurarFlores.UseVisualStyleBackColor = true;
            this.btnProcurarFlores.Click += new System.EventHandler(this.btnProcurarFlores_Click);
            // 
            // txtFlor
            // 
            this.txtFlor.Location = new System.Drawing.Point(79, 38);
            this.txtFlor.Name = "txtFlor";
            this.txtFlor.Size = new System.Drawing.Size(125, 27);
            this.txtFlor.TabIndex = 1;
            // 
            // TabConsultarFlores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtFlor);
            this.Controls.Add(this.btnProcurarFlores);
            this.Name = "TabConsultarFlores";
            this.Size = new System.Drawing.Size(664, 419);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnProcurarFlores;
        private TextBox txtFlor;
    }
}
