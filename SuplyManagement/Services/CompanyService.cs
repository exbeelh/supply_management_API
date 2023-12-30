using SuplyManagement.Contracts;

namespace SuplyManagement.Services
{
    public class CompanyService
    {
        private readonly ICompanyRespository _companyRepository;

        public CompanyService(ICompanyRespository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public int RegisterCompany()
    }
}
