using LBD.Core.Domain;
using LBD.Pedidos.Domain;
using Microsoft.EntityFrameworkCore;


namespace Orçamento_Flores.Dados
{
    public class DbPedidoContext : DbContext
    {
        // Your context has been configured to use a 'DbPedidoContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'OrcamentoFloresTeste.Dados.DbPedidoContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DbPedidoContext' 
        // connection string in the application configuration file.

        private string ConnectionString;

        public DbPedidoContext()
        {
            ConnectionString = "server=.;data source=LUCAS_BALDASSO;initial catalog=DbPedidos;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework;TrustServerCertificate=true";
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fornecedor>()
                .HasOne(x => x.FrequenciaEntrega)
                .WithOne(x => x.Fornecedor)
                .HasPrincipalKey<Fornecedor>(x => x.Id);
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(ConnectionString, x => x.EnableRetryOnFailure());
        }



        public virtual DbSet<Documento> Documentos { get; set; }
        public virtual DbSet<Endereco> Enderecos { get; set; }
        public virtual DbSet<Produto> Produtos { get; set; }
        public virtual DbSet<RedeSocial> RedesSociais { get; set; }
        public virtual DbSet<Telefone> Telefones { get; set; }
        public virtual DbSet<Flor> Flores { get; set; }
        public virtual DbSet<Pessoa> Pessoas { get; set; }
        public virtual DbSet<PessoaFisica> PessoaFisica { get; set; }
        public virtual DbSet<PessoaJuridica> PessoaJuridica { get; set; }
        public virtual DbSet<Fornecedor> Fornecedores { get; set; }
        public virtual DbSet<Servico> Servicos { get; set; }
        public virtual DbSet<Evento> Eventos { get; set; }
        public virtual DbSet<Arranjo> Arranjos { get; set; }
        public virtual DbSet<FrequenciaEntrega> FrequenciaEntrega { get; set; }
        public virtual DbSet<ProdutosPorArranjo> ProdutosPorArranjo { get; set; }
        public virtual DbSet<ProdutoPorFornecedor> ProdutoPorFornecedor { get; set; }
    }
}