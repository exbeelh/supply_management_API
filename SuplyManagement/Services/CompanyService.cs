using SuplyManagement.Contracts;
using SuplyManagement.DTOs.CompanyDto;

namespace SuplyManagement.Services
{
    public class CompanyService
    {
        private readonly ICompanyRespository _companyRepository;

        public CompanyService(ICompanyRespository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public IEnumerable<GetCompanyDto> GetAll()
        {
            var companies = _companyRepository.GetAll();
            List<GetCompanyDto> companyDto = new();
            foreach (var company in companies)
            {
                companyDto.Add(new GetCompanyDto
                {
                    CompanyId = company.CompanyId,
                    CompanyName = company.CompanyName,
                    CompanyEmail = company.Email,
                    CompanyPhone = company.PhoneNumber!,
                    Photo = company.Photo
                });
            }

            return companyDto;

        }

        public GetCompanyDto? GetCompanyById(string companyId)
        {
            var company = _companyRepository.GetByGuid(companyId);
            
            if (company is null) return null;

            return new GetCompanyDto
            {
                CompanyId = company.CompanyId,
                CompanyName = company.CompanyName,
                CompanyEmail = company.Email,
                CompanyPhone = company.PhoneNumber!,
                Photo = company.Photo
            };
        }

        public int RegisterCompany(CreateCompanyDto companyDto)
        {
            var createCompany = _companyRepository.Create(companyDto);
            if (createCompany is null) return 0;
            return 1;
        }

        public int UpdateCompany(UpdateCompanyDto companyDto)
        {
            var company = _companyRepository.GetByGuid(companyDto.CompanyId);
            if (company is null) return -1;

            company.CompanyId = companyDto.CompanyId;
            company.CompanyName = companyDto.CompanyName;
            company.Email = companyDto.Email;
            company.PhoneNumber = companyDto.CompanyPhone;
            company.Photo = companyDto.Photo;

            var isUpdate = _companyRepository.Update(company);
            return !isUpdate ? 0 : 1;

        }
    }
}
