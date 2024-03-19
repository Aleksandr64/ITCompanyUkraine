using ITCompany.Application.Services.Interface;
using ITCompany.Domain.Entity;
using Microsoft.AspNetCore.Mvc;

namespace ITCompany.Web.Controller;

public class CompanyController : BaseApiController
{
    private readonly ICompanyService _companyService;

    public CompanyController(ICompanyService companyService)
    {
        _companyService = companyService;
    }
    
    [HttpPost]
    public async Task<IActionResult> AddCompanyInDb([FromBody] Company company)
    {
        await _companyService.AddCompany(company);
        return Ok();
    }

    [HttpGet]
    public IActionResult Test()
    {
        object a = new Company()
        {
            NameCompany = "asssd",
            EmailAddress = "ddd",
            Address = "ddd",
            PhoneNumber = "dddd"
        };
        return Ok(a);
    }
}