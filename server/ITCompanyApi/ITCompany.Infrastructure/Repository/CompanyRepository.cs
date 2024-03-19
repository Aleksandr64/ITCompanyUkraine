using Dapper;
using ITCompany.Domain.Entity;
using ITCompany.Infrastructure.Repository.Interface;

namespace ITCompany.Infrastructure.Repository;

public class CompanyRepository : ICompanyRepository
{
    private readonly DapperContext _context;

    public CompanyRepository(DapperContext context)
    {
        _context = context;
    }
    
    public async Task AddCompanyInDb(Company company)
    {
        string sql = @"INSERT INTO Компанія (Назва_Компанії, Адреса, Телефон, Електронна_Пошта)
                                VALUES (@NameCompany, @Address, @PhoneNumber, @EmailAddress)";


        using (var connection = _context.CreateConnection())
        {
            await connection.ExecuteAsync(sql, company);
        }
        
    }
}