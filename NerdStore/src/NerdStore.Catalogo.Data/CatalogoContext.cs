using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NerdStore.Catalogo.Domain;
using NerdStore.Core.Data;
//using NerdStore.Core.Messages;

namespace NerdStore.Catalogo.Data
{
    class CatalogoContext : DbContext, IUnitOfWork
    {
        /// <summary>
        /// DbContextOptions é o parametro necessário para configurar o contexto na classe startUp. Isso é uma prática para quem vai trabalhar 
        /// com asp net core ou entityframework core. É uma espécie de factory
        /// </summary>
        /// <param name="options"></param>
        protected CatalogoContext(DbContextOptions<CatalogoContext> options) : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(
                e => e.GetProperties().Where(p => p.ClrType == typeof(string))))
                property.SetColumnType("varchar(100)");

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CatalogoContext).Assembly);
        }

        public Task<bool> Commit()
        {
            throw new NotImplementedException();
        }
    }
}
