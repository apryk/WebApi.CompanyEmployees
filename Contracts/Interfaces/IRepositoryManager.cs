using System;
using System.Threading.Tasks;

namespace Contracts.Interfaces
{
    public interface IRepositoryManager
    {
        ICompanyRepository Company { get; }
        IEmployeeRepository Employee { get; }
        Task SaveAsync();
    }
}
