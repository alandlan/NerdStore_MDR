using NerdStore.Core.DomainObjects;
using System;

namespace NerdStore.Core.Data
{
    /// <summary>
    ///  IRepository onde ele vai implementar o IDisposable para fazer uso do dispose onde T é do tipo IAggregateRoot(Raiz de agregação)
    ///  que obrigatoriamente tera que passar(no T) um agregado
    ///  Para respeitar a regra. Um agregado por repositório.
    /// </summary>
    /// <typeparam name="T">Classe do tipo IAggregateRoot</typeparam>
    public interface IRepository<T> : IDisposable where T : IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
