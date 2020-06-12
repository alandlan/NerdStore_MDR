using System.Threading.Tasks;

namespace NerdStore.Core.Data
{
    /// <summary>
    /// Conceito do IUnitOfWork 
    /// </summary>
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}
