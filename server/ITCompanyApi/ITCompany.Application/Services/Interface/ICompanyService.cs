using ITCompany.Domain.Entity;

namespace ITCompany.Application.Services.Interface;

public interface ICompanyService
{
    public Task AddCompany(Company company);
}