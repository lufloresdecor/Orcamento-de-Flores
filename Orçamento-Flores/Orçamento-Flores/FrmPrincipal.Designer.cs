namespace Orçamento_Flores.Paginas
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TabPage tbpNovaFlor;
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.florToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arranjoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.florToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arranjosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orçamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoOrçamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarOrçamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabControl = new System.Windows.Forms.TabControl();
            tbpNovaFlor = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbpNovaFlor
            // 
            tbpNovaFlor.Location = new System.Drawing.Point(0, 0);
            tbpNovaFlor.Name = "tbpNovaFlor";
            tbpNovaFlor.Size = new System.Drawing.Size(200, 100);
            tbpNovaFlor.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.orçamentoToolStripMenuItem,
            this.pedidosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(914, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.florToolStripMenuItem,
            this.fornecedorToolStripMenuItem,
            this.arranjoToolStripMenuItem,
            this.eventoToolStripMenuItem});
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.novoToolStripMenuItem.Text = "Novo";
            // 
            // florToolStripMenuItem
            // 
            this.florToolStripMenuItem.Name = "florToolStripMenuItem";
            this.florToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.florToolStripMenuItem.Text = "Flor";
            this.florToolStripMenuItem.Click += new System.EventHandler(this.florToolStripMenuItem_Click);
            // 
            // fornecedorToolStripMenuItem
            // 
            this.fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            this.fornecedorToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.fornecedorToolStripMenuItem.Text = "Fornecedor";
            this.fornecedorToolStripMenuItem.Click += new System.EventHandler(this.fornecedorToolStripMenuItem_Click);
            // 
            // arranjoToolStripMenuItem
            // 
            this.arranjoToolStripMenuItem.Name = "arranjoToolStripMenuItem";
            this.arranjoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.arranjoToolStripMenuItem.Text = "Arranjo";
            // 
            // eventoToolStripMenuItem
            // 
            this.eventoToolStripMenuItem.Name = "eventoToolStripMenuItem";
            this.eventoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.eventoToolStripMenuItem.Text = "Evento";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.florToolStripMenuItem1,
            this.fToolStripMenuItem,
            this.arranjosToolStripMenuItem,
            this.eventosToolStripMenuItem});
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // florToolStripMenuItem1
            // 
            this.florToolStripMenuItem1.Name = "florToolStripMenuItem1";
            this.florToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.florToolStripMenuItem1.Text = "Flores";
            // 
            // fToolStripMenuItem
            // 
            this.fToolStripMenuItem.Name = "fToolStripMenuItem";
            this.fToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.fToolStripMenuItem.Text = "Fornecedores";
            // 
            // arranjosToolStripMenuItem
            // 
            this.arranjosToolStripMenuItem.Name = "arranjosToolStripMenuItem";
            this.arranjosToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.arranjosToolStripMenuItem.Text = "Arranjos";
            // 
            // eventosToolStripMenuItem
            // 
            this.eventosToolStripMenuItem.Name = "eventosToolStripMenuItem";
            this.eventosToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.eventosToolStripMenuItem.Text = "Eventos";
            // 
            // orçamentoToolStripMenuItem
            // 
            this.orçamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoOrçamentoToolStripMenuItem,
            this.consultarOrçamentosToolStripMenuItem});
            this.orçamentoToolStripMenuItem.Name = "orçamentoToolStripMenuItem";
            this.orçamentoToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.orçamentoToolStripMenuItem.Text = "Orçamento";
            // 
            // novoOrçamentoToolStripMenuItem
            // 
            this.novoOrçamentoToolStripMenuItem.Name = "novoOrçamentoToolStripMenuItem";
            this.novoOrçamentoToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.novoOrçamentoToolStripMenuItem.Text = "Novo Orçamento";
            // 
            // consultarOrçamentosToolStripMenuItem
            // 
            this.consultarOrçamentosToolStripMenuItem.Name = "consultarOrçamentosToolStripMenuItem";
            this.consultarOrçamentosToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.consultarOrçamentosToolStripMenuItem.Text = "Consultar Orçamentos";
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarPedidosToolStripMenuItem});
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // realizarPedidosToolStripMenuItem
            // 
            this.realizarPedidosToolStripMenuItem.Name = "realizarPedidosToolStripMenuItem";
            this.realizarPedidosToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.realizarPedidosToolStripMenuItem.Text = "Realizar Pedidos";
            // 
            // TabControl
            // 
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 30);
            this.TabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(914, 570);
            this.TabControl.TabIndex = 2;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmPrincipal";
            this.Text = "Orçametos Flores";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem novoToolStripMenuItem;
        private ToolStripMenuItem florToolStripMenuItem;
        private ToolStripMenuItem fornecedorToolStripMenuItem;
        private ToolStripMenuItem arranjoToolStripMenuItem;
        private ToolStripMenuItem eventoToolStripMenuItem;
        private ToolStripMenuItem consultarToolStripMenuItem;
        private ToolStripMenuItem florToolStripMenuItem1;
        private ToolStripMenuItem fToolStripMenuItem;
        private ToolStripMenuItem arranjosToolStripMenuItem;
        private ToolStripMenuItem eventosToolStripMenuItem;
        private ToolStripMenuItem orçamentoToolStripMenuItem;
        private ToolStripMenuItem novoOrçamentoToolStripMenuItem;
        private ToolStripMenuItem consultarOrçamentosToolStripMenuItem;
        private ToolStripMenuItem pedidosToolStripMenuItem;
        private ToolStripMenuItem realizarPedidosToolStripMenuItem;
        private TabControl TabControl;
        private TabPage tbpNovaFlor;
    }
}