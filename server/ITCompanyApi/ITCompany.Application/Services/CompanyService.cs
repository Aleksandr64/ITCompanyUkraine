using System.Net;
using ITCompany.Application.Services.Interface;
using ITCompany.Domain;
using ITCompany.Domain.Entity;
using ITCompany.Infrastructure.Repository.Interface;

namespace ITCompany.Application.Services;

public class CompanyService : ICompanyService
{
    private readonly ICompanyRepository _companyRepository;

    public CompanyService(ICompanyRepository companyRepository)
    {
        _companyRepository = companyRepository;
    }
    
    public async Task AddCompany(Company company)
    {
        List<string> list = new List<string>();
        list.Add("ddd");
        list.Add("ddd");
        throw new ApiException("Testing", list, (int)HttpStatusCode.BadRequest);
        await _companyRepository.AddCompanyInDb(company);
    }
}