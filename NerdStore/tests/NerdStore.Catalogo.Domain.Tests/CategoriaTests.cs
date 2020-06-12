using NerdStore.Core.DomainObjects;
using Xunit;

namespace NerdStore.Catalogo.Domain.Tests
{
    public class CategoriaTests
    {
        [Fact]
        public void Categoria_Validar_ValidacoesDevemRetornarExceptions()
        {
            var ex = Assert.Throws<DomainException>(() =>
            {
                new Categoria("", 1);
            });

            Assert.Equal("O campo Nome da categoria não pode estar vazio", ex.Message);

            ex = Assert.Throws<DomainException>(() =>
            {
                new Categoria("Vitrine", 0);
            });

            Assert.Equal("O campo Codigo não pode ser 0", ex.Message);
        }
    }
}
