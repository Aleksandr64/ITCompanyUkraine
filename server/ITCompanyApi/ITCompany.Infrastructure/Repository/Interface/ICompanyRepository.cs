using System.Transactions;
using ITCompany.Domain.Entity;

namespace ITCompany.Infrastructure.Repository.Interface;

public interface ICompanyRepository
{
    public Task AddCompanyInDb(Company company);
}